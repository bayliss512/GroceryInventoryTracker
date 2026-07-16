using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using GroceryInventoryTracker.Tests.TestHelpers;
using Microsoft.Extensions.Logging.Abstractions;
using Xunit;

namespace GroceryInventoryTracker.Tests.Services
{
    public class ProductServiceTests : IDisposable
    {
        private readonly SqliteInMemoryDatabase _db;
        private readonly ProductService _products;

        public ProductServiceTests()
        {
            _db = new SqliteInMemoryDatabase();
            _products = new ProductService(_db.Context, new FakeWebHostEnvironment(), NullLogger<ProductService>.Instance);
        }

        public void Dispose() => _db.Dispose();

        private Category AddCategory(string name = "Produce")
        {
            var category = new Category { Name = name };
            _db.Context.Categories.Add(category);
            _db.Context.SaveChanges();
            return category;
        }

        [Fact]
        public async Task CreateAsync_PersistsTheProduct()
        {
            var category = AddCategory();

            var created = await _products.CreateAsync(new Product { Name = "Apples", CategoryId = category.Id });

            var reloaded = await _products.GetProductByIdAsync(created.Id);
            Assert.NotNull(reloaded);
            Assert.Equal("Apples", reloaded!.Name);
        }

        [Fact]
        public async Task UpdateAsync_ChangesEditableFields()
        {
            var category = AddCategory();
            var other = AddCategory("Bakery");
            var product = await _products.CreateAsync(new Product { Name = "Apples", CategoryId = category.Id, IsPerishable = true, LowStockThreshold = 20 });

            var updated = await _products.UpdateAsync(product.Id, new Product { Name = "Bread", CategoryId = other.Id, IsPerishable = false, LowStockThreshold = 40 });

            Assert.True(updated);
            var reloaded = await _products.GetProductByIdAsync(product.Id);
            Assert.Equal("Bread", reloaded!.Name);
            Assert.Equal(other.Id, reloaded.CategoryId);
            Assert.False(reloaded.IsPerishable);
            Assert.Equal(40, reloaded.LowStockThreshold);
        }

        [Fact]
        public async Task UpdateAsync_ReturnsFalseWhenTheProductDoesNotExist()
        {
            var result = await _products.UpdateAsync(999, new Product { Name = "Ghost", CategoryId = 1 });

            Assert.False(result);
        }

        [Fact]
        public async Task DeleteAsync_RemovesAProductWithNoShipments()
        {
            var category = AddCategory();
            var product = await _products.CreateAsync(new Product { Name = "Apples", CategoryId = category.Id });

            var (success, error) = await _products.DeleteAsync(product.Id);

            Assert.True(success);
            Assert.Null(error);
            Assert.Null(await _products.GetProductByIdAsync(product.Id));
        }

        [Fact]
        public async Task DeleteAsync_IsBlockedWhileShipmentsReferenceTheProduct()
        {
            var category = AddCategory();
            var product = await _products.CreateAsync(new Product { Name = "Apples", CategoryId = category.Id });
            _db.Context.Shipments.Add(new Shipment { ProductId = product.Id, ShipmentNumber = "SHP-1", Quantity = 10, Location = "InStorage", CreatedAt = DateTime.UtcNow });
            await _db.Context.SaveChangesAsync();

            var (success, error) = await _products.DeleteAsync(product.Id);

            Assert.False(success);
            Assert.Contains("shipment", error);
            Assert.NotNull(await _products.GetProductByIdAsync(product.Id));
        }

        [Fact]
        public async Task GetAllProductsAsync_ComputesStoredAndSalesFloorQuantitiesFromShipments()
        {
            var category = AddCategory();
            var product = await _products.CreateAsync(new Product { Name = "Apples", CategoryId = category.Id });
            _db.Context.Shipments.AddRange(
                new Shipment { ProductId = product.Id, ShipmentNumber = "SHP-1", Quantity = 30, Location = "InStorage", CreatedAt = DateTime.UtcNow },
                new Shipment { ProductId = product.Id, ShipmentNumber = "SHP-2", Quantity = 12, Location = "OnFloor", CreatedAt = DateTime.UtcNow });
            await _db.Context.SaveChangesAsync();

            var all = await _products.GetAllProductsAsync();

            var reloaded = Assert.Single(all);
            Assert.Equal(30, reloaded.QuantityStored);
            Assert.Equal(12, reloaded.QuantityOnSalesFloor);
        }

        [Fact]
        public async Task GetProductsAsync_FiltersBySearchTerm()
        {
            var category = AddCategory();
            await _products.CreateAsync(new Product { Name = "Apples", CategoryId = category.Id });
            await _products.CreateAsync(new Product { Name = "Bananas", CategoryId = category.Id });

            var result = await _products.GetProductsAsync(search: "app", categoryId: null, page: 1, pageSize: 10);

            var match = Assert.Single(result.Items);
            Assert.Equal("Apples", match.Name);
            Assert.Equal(1, result.TotalCount);
        }

        [Fact]
        public async Task GetProductsAsync_FiltersByCategory()
        {
            var produce = AddCategory("Produce");
            var bakery = AddCategory("Bakery");
            await _products.CreateAsync(new Product { Name = "Apples", CategoryId = produce.Id });
            await _products.CreateAsync(new Product { Name = "Bread", CategoryId = bakery.Id });

            var result = await _products.GetProductsAsync(search: null, categoryId: bakery.Id, page: 1, pageSize: 10);

            var match = Assert.Single(result.Items);
            Assert.Equal("Bread", match.Name);
        }

        [Fact]
        public async Task GetProductsAsync_ExpiredFilterOnlyReturnsProductsWithAPastExpirationDate()
        {
            var category = AddCategory();
            var expired = await _products.CreateAsync(new Product { Name = "Old milk", CategoryId = category.Id });
            var fresh = await _products.CreateAsync(new Product { Name = "New milk", CategoryId = category.Id });
            _db.Context.Shipments.Add(new Shipment { ProductId = expired.Id, ShipmentNumber = "SHP-1", Quantity = 5, Location = "InStorage", ExpirationDate = DateTime.Today.AddDays(-1), CreatedAt = DateTime.UtcNow });
            _db.Context.Shipments.Add(new Shipment { ProductId = fresh.Id, ShipmentNumber = "SHP-2", Quantity = 5, Location = "InStorage", ExpirationDate = DateTime.Today.AddDays(30), CreatedAt = DateTime.UtcNow });
            await _db.Context.SaveChangesAsync();

            var result = await _products.GetProductsAsync(search: null, categoryId: null, page: 1, pageSize: 10, expirationFilter: ExpirationFilter.Expired);

            var match = Assert.Single(result.Items);
            Assert.Equal("Old milk", match.Name);
        }

        [Fact]
        public async Task GetProductsAsync_SortsByQuantityDescending()
        {
            var category = AddCategory();
            var low = await _products.CreateAsync(new Product { Name = "Low", CategoryId = category.Id });
            var high = await _products.CreateAsync(new Product { Name = "High", CategoryId = category.Id });
            _db.Context.Shipments.Add(new Shipment { ProductId = low.Id, ShipmentNumber = "SHP-1", Quantity = 5, Location = "InStorage", CreatedAt = DateTime.UtcNow });
            _db.Context.Shipments.Add(new Shipment { ProductId = high.Id, ShipmentNumber = "SHP-2", Quantity = 50, Location = "InStorage", CreatedAt = DateTime.UtcNow });
            await _db.Context.SaveChangesAsync();

            var result = await _products.GetProductsAsync(search: null, categoryId: null, page: 1, pageSize: 10, sortBy: ProductSortBy.Quantity);

            Assert.Equal(new[] { "High", "Low" }, result.Items.Select(p => p.Name));
        }

        [Fact]
        public async Task GetProductsAsync_PagesResults()
        {
            var category = AddCategory();
            for (var i = 1; i <= 5; i++)
            {
                await _products.CreateAsync(new Product { Name = $"Product {i:00}", CategoryId = category.Id });
            }

            var page1 = await _products.GetProductsAsync(search: null, categoryId: null, page: 1, pageSize: 2);
            var page2 = await _products.GetProductsAsync(search: null, categoryId: null, page: 2, pageSize: 2);

            Assert.Equal(5, page1.TotalCount);
            Assert.Equal(2, page1.Items.Count);
            Assert.Equal(2, page2.Items.Count);
            Assert.NotEqual(page1.Items[0].Id, page2.Items[0].Id);
        }
    }
}
