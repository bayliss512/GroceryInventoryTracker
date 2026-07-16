using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using GroceryInventoryTracker.Tests.TestHelpers;
using Microsoft.Extensions.Logging.Abstractions;
using Xunit;

namespace GroceryInventoryTracker.Tests.Services
{
    public class ShipmentServiceTests : IDisposable
    {
        private readonly SqliteInMemoryDatabase _db;
        private readonly ShipmentService _shipments;
        private readonly Product _product;

        public ShipmentServiceTests()
        {
            _db = new SqliteInMemoryDatabase();
            _shipments = new ShipmentService(_db.Context, NullLogger<ShipmentService>.Instance);

            var category = new Category { Name = "Produce" };
            _db.Context.Categories.Add(category);
            _db.Context.SaveChanges();
            _product = new Product { Name = "Apples", CategoryId = category.Id };
            _db.Context.Products.Add(_product);
            _db.Context.SaveChanges();
        }

        public void Dispose() => _db.Dispose();

        [Fact]
        public async Task CreateAsync_PersistsTheShipmentAndStampsCreatedAt()
        {
            var before = DateTime.UtcNow;

            var created = await _shipments.CreateAsync(new Shipment { ProductId = _product.Id, ShipmentNumber = "SHP-1", Quantity = 10, Location = "InStorage" });

            var reloaded = await _shipments.GetByIdAsync(created.Id);
            Assert.NotNull(reloaded);
            Assert.Equal(10, reloaded!.Quantity);
            Assert.True(reloaded.CreatedAt >= before);
        }

        [Fact]
        public async Task UpdateAsync_ChangesEditableFields()
        {
            var shipment = await _shipments.CreateAsync(new Shipment { ProductId = _product.Id, ShipmentNumber = "SHP-1", Quantity = 10, Location = "InStorage" });

            var updated = await _shipments.UpdateAsync(shipment.Id, new Shipment
            {
                ProductId = _product.Id,
                ShipmentNumber = "SHP-1-REV",
                Quantity = 25,
                Location = "OnFloor"
            });

            Assert.True(updated);
            var reloaded = await _shipments.GetByIdAsync(shipment.Id);
            Assert.Equal("SHP-1-REV", reloaded!.ShipmentNumber);
            Assert.Equal(25, reloaded.Quantity);
            Assert.Equal("OnFloor", reloaded.Location);
        }

        [Fact]
        public async Task UpdateAsync_ReturnsFalseWhenTheShipmentDoesNotExist()
        {
            var updated = await _shipments.UpdateAsync(999, new Shipment { ProductId = _product.Id, ShipmentNumber = "SHP-X", Quantity = 1, Location = "InStorage" });

            Assert.False(updated);
        }

        [Fact]
        public async Task DeleteAsync_RemovesTheShipment()
        {
            var shipment = await _shipments.CreateAsync(new Shipment { ProductId = _product.Id, ShipmentNumber = "SHP-1", Quantity = 10, Location = "InStorage" });

            var result = await _shipments.DeleteAsync(shipment.Id);

            Assert.True(result);
            Assert.Null(await _shipments.GetByIdAsync(shipment.Id));
        }

        [Fact]
        public async Task DeleteAsync_ReturnsFalseWhenTheShipmentDoesNotExist()
        {
            var result = await _shipments.DeleteAsync(999);

            Assert.False(result);
        }

        [Fact]
        public async Task GetAllAsync_FiltersByProductId()
        {
            var category = new Category { Name = "Bakery" };
            _db.Context.Categories.Add(category);
            await _db.Context.SaveChangesAsync();
            var otherProduct = new Product { Name = "Bread", CategoryId = category.Id };
            _db.Context.Products.Add(otherProduct);
            await _db.Context.SaveChangesAsync();

            await _shipments.CreateAsync(new Shipment { ProductId = _product.Id, ShipmentNumber = "SHP-1", Quantity = 10, Location = "InStorage" });
            await _shipments.CreateAsync(new Shipment { ProductId = otherProduct.Id, ShipmentNumber = "SHP-2", Quantity = 5, Location = "InStorage" });

            var forProduct = await _shipments.GetAllAsync(_product.Id);

            var match = Assert.Single(forProduct);
            Assert.Equal("SHP-1", match.ShipmentNumber);
        }
    }
}
