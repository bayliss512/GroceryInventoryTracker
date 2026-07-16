using GroceryInventoryTracker.Data;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace GroceryInventoryTracker.Tests.TestHelpers
{
    /// <summary>
    /// A real relational (Sqlite) database, held open for the lifetime of one test, so
    /// foreign keys, unique indexes, and cascade/restrict delete behavior are exercised
    /// the same way they would be against SQL Server. Each instance starts from a clean
    /// slate — the model's HasData seed catalog is removed so tests control their own
    /// fixture data instead of asserting around 288 seeded products.
    /// </summary>
    public sealed class SqliteInMemoryDatabase : IDisposable
    {
        private readonly SqliteConnection _connection;

        public InventoryDbContext Context { get; }

        public SqliteInMemoryDatabase()
        {
            _connection = new SqliteConnection("Data Source=:memory:");
            _connection.Open();

            var options = new DbContextOptionsBuilder<InventoryDbContext>()
                .UseSqlite(_connection)
                .Options;

            Context = new InventoryDbContext(options);
            Context.Database.EnsureCreated();

            Context.Shipments.RemoveRange(Context.Shipments);
            Context.Products.RemoveRange(Context.Products);
            Context.Categories.RemoveRange(Context.Categories);
            Context.SaveChanges();
        }

        /// <summary>Opens a second context over the same connection, e.g. to assert persisted state independent of the first context's change tracker.</summary>
        public InventoryDbContext CreateContext()
        {
            var options = new DbContextOptionsBuilder<InventoryDbContext>()
                .UseSqlite(_connection)
                .Options;
            return new InventoryDbContext(options);
        }

        public void Dispose()
        {
            Context.Dispose();
            _connection.Dispose();
        }
    }
}
