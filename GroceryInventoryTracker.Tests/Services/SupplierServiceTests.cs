using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using GroceryInventoryTracker.Tests.TestHelpers;
using Microsoft.Extensions.Logging.Abstractions;
using Xunit;

namespace GroceryInventoryTracker.Tests.Services
{
    public class SupplierServiceTests : IDisposable
    {
        private readonly SqliteInMemoryDatabase _db;
        private readonly SupplierService _suppliers;

        public SupplierServiceTests()
        {
            _db = new SqliteInMemoryDatabase();
            _suppliers = new SupplierService(_db.Context, NullLogger<SupplierService>.Instance);
        }

        public void Dispose() => _db.Dispose();

        [Fact]
        public async Task CreateAsync_PersistsTheSupplier()
        {
            var created = await _suppliers.CreateAsync(new Supplier { Name = "Acme Foods" });

            var reloaded = await _suppliers.GetByIdAsync(created.Id);
            Assert.NotNull(reloaded);
            Assert.Equal("Acme Foods", reloaded!.Name);
        }

        [Fact]
        public async Task UpdateAsync_ChangesEditableFields()
        {
            var supplier = await _suppliers.CreateAsync(new Supplier { Name = "Acme Foods" });

            var updated = await _suppliers.UpdateAsync(supplier.Id, new Supplier
            {
                Name = "Acme Foods Inc",
                ContactName = "Jane Doe",
                Phone = "555-1234",
                Email = "jane@acme.test",
                Address = "1 Main St"
            });

            Assert.True(updated);
            var reloaded = await _suppliers.GetByIdAsync(supplier.Id);
            Assert.Equal("Acme Foods Inc", reloaded!.Name);
            Assert.Equal("Jane Doe", reloaded.ContactName);
        }

        [Fact]
        public async Task DeleteAsync_RemovesASupplierWithNoShipments()
        {
            var supplier = await _suppliers.CreateAsync(new Supplier { Name = "Acme Foods" });

            var (success, error) = await _suppliers.DeleteAsync(supplier.Id);

            Assert.True(success);
            Assert.Null(error);
            Assert.Null(await _suppliers.GetByIdAsync(supplier.Id));
        }

        [Fact]
        public async Task DeleteAsync_IsBlockedWhileShipmentsReferenceTheSupplier()
        {
            var category = new Category { Name = "Produce" };
            _db.Context.Categories.Add(category);
            await _db.Context.SaveChangesAsync();
            var product = new Product { Name = "Apples", CategoryId = category.Id };
            _db.Context.Products.Add(product);
            await _db.Context.SaveChangesAsync();
            var supplier = await _suppliers.CreateAsync(new Supplier { Name = "Acme Foods" });
            _db.Context.Shipments.Add(new Shipment { ProductId = product.Id, SupplierId = supplier.Id, ShipmentNumber = "SHP-1", Quantity = 5, Location = "InStorage", CreatedAt = DateTime.UtcNow });
            await _db.Context.SaveChangesAsync();

            var (success, error) = await _suppliers.DeleteAsync(supplier.Id);

            Assert.False(success);
            Assert.Contains("shipment", error);
            Assert.NotNull(await _suppliers.GetByIdAsync(supplier.Id));
        }
    }
}
