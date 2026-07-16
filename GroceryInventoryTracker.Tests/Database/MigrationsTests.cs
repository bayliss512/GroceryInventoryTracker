using GroceryInventoryTracker.Data;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace GroceryInventoryTracker.Tests.Database
{
    /// <summary>
    /// Guards against the exact class of bug documented for this project: the EF model
    /// drifting out of sync with the latest migration (three early migrations were never
    /// actually recognized by EF, and seed data was expanded without a corresponding
    /// migration). These tests fail loudly the moment that happens again.
    /// </summary>
    public class MigrationsTests
    {
        /// <summary>
        /// Uses the SqlServer provider (production's actual provider) purely to build the
        /// model with the right conventions — this comparison is static (model vs. the
        /// latest migration's embedded snapshot) and needs no live connection. Sqlite is
        /// deliberately NOT used here: its different column-mapping conventions make this
        /// check report false positives against a snapshot generated for SQL Server.
        /// </summary>
        [Fact]
        public void TheCurrentModelHasNoPendingChangesAgainstTheLatestMigration()
        {
            using var context = new InventoryDbContext(new DbContextOptionsBuilder<InventoryDbContext>()
                .UseSqlServer("Server=.;Database=PendingModelChangesCheckOnly;Trusted_Connection=True;")
                .Options);

            var hasPendingChanges = context.Database.HasPendingModelChanges();

            Assert.False(hasPendingChanges);
        }

        // The remaining tests use EnsureCreated (schema built fresh from the current model)
        // rather than replaying the actual migration files: several migrations bake in
        // explicit SQL Server type strings (e.g. "nvarchar(max)") that Sqlite's parser
        // rejects outright. That's a real, provider-specific limitation of the migration
        // *files* themselves, not something a fake DB can validate — see
        // Migrate_AppliesTheRealMigrationFilesAgainstSqlServer below for that check.

        [Fact]
        public async Task EnsureCreated_BuildsASchemaThatMatchesTheSeededCatalog()
        {
            using var connection = new SqliteConnection("Data Source=:memory:");
            connection.Open();
            using var context = new InventoryDbContext(new DbContextOptionsBuilder<InventoryDbContext>().UseSqlite(connection).Options);

            await context.Database.EnsureCreatedAsync();

            Assert.Equal(21, await context.Categories.CountAsync());
            Assert.Equal(288, await context.Products.CountAsync());
            Assert.True(await context.Shipments.CountAsync() > 0);
        }

        [Fact]
        public async Task EnsureCreated_CascadeDeletingAProductRemovesItsShipments()
        {
            using var connection = new SqliteConnection("Data Source=:memory:");
            connection.Open();
            using var context = new InventoryDbContext(new DbContextOptionsBuilder<InventoryDbContext>().UseSqlite(connection).Options);
            await context.Database.EnsureCreatedAsync();

            var product = await context.Products.FirstAsync(p => p.Shipments.Count > 0);
            var shipmentIds = await context.Shipments.Where(s => s.ProductId == product.Id).Select(s => s.Id).ToListAsync();

            context.Products.Remove(product);
            await context.SaveChangesAsync();

            Assert.False(await context.Shipments.AnyAsync(s => shipmentIds.Contains(s.Id)));
        }

        /// <summary>
        /// Applies the real, on-disk migration files against a real SQL Server database —
        /// the only way to actually prove they run cleanly end-to-end, since they contain
        /// SQL-Server-specific type strings a fake database can't execute. Requires a local
        /// SQLEXPRESS instance (same one the app's default connection string targets); skip
        /// or replace with a SQL Server service container in CI if one isn't available.
        /// </summary>
        [Fact]
        public async Task Migrate_AppliesTheRealMigrationFilesAgainstSqlServer()
        {
            var connectionString = $@"Server=.\SQLEXPRESS;Database=GroceryInventoryTrackerMigrationTest_{Guid.NewGuid():N};Trusted_Connection=True;TrustServerCertificate=True;";
            using var context = new InventoryDbContext(new DbContextOptionsBuilder<InventoryDbContext>().UseSqlServer(connectionString).Options);
            try
            {
                await context.Database.MigrateAsync();

                var appliedMigrations = await context.Database.GetAppliedMigrationsAsync();
                var allMigrations = context.Database.GetMigrations();
                Assert.Equal(allMigrations.Count(), appliedMigrations.Count());
                Assert.Equal(21, await context.Categories.CountAsync());
                Assert.Equal(288, await context.Products.CountAsync());
            }
            finally
            {
                await context.Database.EnsureDeletedAsync();
            }
        }
    }
}
