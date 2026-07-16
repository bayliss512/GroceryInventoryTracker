using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using GroceryInventoryTracker.Tests.TestHelpers;
using Xunit;

namespace GroceryInventoryTracker.Tests.Services
{
    public class DashboardServiceTests : IDisposable
    {
        private readonly SqliteInMemoryDatabase _db;
        private readonly DashboardService _dashboard;
        private readonly Category _category;

        public DashboardServiceTests()
        {
            _db = new SqliteInMemoryDatabase();
            _dashboard = new DashboardService(_db.Context);

            _category = new Category { Name = "Produce" };
            _db.Context.Categories.Add(_category);
            _db.Context.SaveChanges();
        }

        public void Dispose() => _db.Dispose();

        private Product AddProduct(string name)
        {
            var product = new Product { Name = name, CategoryId = _category.Id };
            _db.Context.Products.Add(product);
            _db.Context.SaveChanges();
            return product;
        }

        private void AddShipment(Product product, int quantity, string location = "InStorage", DateTime? expirationDate = null)
        {
            _db.Context.Shipments.Add(new Shipment
            {
                ProductId = product.Id,
                ShipmentNumber = $"SHP-{Guid.NewGuid():N}"[..12],
                Quantity = quantity,
                Location = location,
                ExpirationDate = expirationDate,
                CreatedAt = DateTime.UtcNow
            });
            _db.Context.SaveChanges();
        }

        [Fact]
        public async Task GetSummaryAsync_CountsTotalProducts()
        {
            AddProduct("Apples");
            AddProduct("Bananas");

            var summary = await _dashboard.GetSummaryAsync();

            Assert.Equal(2, summary.TotalProducts);
        }

        [Fact]
        public async Task GetSummaryAsync_ClassifiesAProductWithNoShipmentsAsOutOfStock()
        {
            var product = AddProduct("Apples");

            var summary = await _dashboard.GetSummaryAsync();

            Assert.Equal(1, summary.OutOfStockCount);
            Assert.Contains(product.Name, summary.OutOfStockProducts);
            Assert.Equal(0, summary.LowStockCount);
        }

        [Fact]
        public async Task GetSummaryAsync_ClassifiesBelowThresholdQuantityAsLowStock()
        {
            var product = AddProduct("Apples");
            AddShipment(product, DashboardService.LowStockThreshold - 1);

            var summary = await _dashboard.GetSummaryAsync();

            Assert.Equal(1, summary.LowStockCount);
            Assert.Contains(product.Name, summary.LowStockProducts);
            Assert.Equal(0, summary.OutOfStockCount);
        }

        [Fact]
        public async Task GetSummaryAsync_QuantityExactlyAtTheThresholdIsNotLowStock()
        {
            var product = AddProduct("Apples");
            AddShipment(product, DashboardService.LowStockThreshold);

            var summary = await _dashboard.GetSummaryAsync();

            Assert.Equal(0, summary.LowStockCount);
            Assert.Equal(0, summary.OutOfStockCount);
        }

        [Fact]
        public async Task GetSummaryAsync_LowAndOutOfStockListsAreAlphabeticalAndCappedAtFive()
        {
            var names = new[] { "Zucchini", "Mango", "Apple", "Yam", "Bean", "Xigua" };
            foreach (var name in names)
            {
                AddProduct(name);
            }

            var summary = await _dashboard.GetSummaryAsync();

            Assert.Equal(6, summary.OutOfStockCount);
            Assert.Equal(5, summary.OutOfStockProducts.Count);
            Assert.Equal(new[] { "Apple", "Bean", "Mango", "Xigua", "Yam" }, summary.OutOfStockProducts);
        }

        [Fact]
        public async Task GetSummaryAsync_IncludesAShipmentExpiringExactlyAtTheWindowBoundary()
        {
            var product = AddProduct("Apples");
            AddShipment(product, 5, expirationDate: DateTime.Today.AddDays(DashboardService.ExpiringSoonDays));

            var summary = await _dashboard.GetSummaryAsync();

            Assert.Equal(1, summary.ExpiringSoonCount);
        }

        [Fact]
        public async Task GetSummaryAsync_ExcludesAShipmentThatExpiredAlready()
        {
            var product = AddProduct("Apples");
            AddShipment(product, 5, expirationDate: DateTime.Today.AddDays(-1));

            var summary = await _dashboard.GetSummaryAsync();

            Assert.Equal(0, summary.ExpiringSoonCount);
        }

        [Fact]
        public async Task GetSummaryAsync_ExcludesAShipmentExpiringAfterTheWindow()
        {
            var product = AddProduct("Apples");
            AddShipment(product, 5, expirationDate: DateTime.Today.AddDays(DashboardService.ExpiringSoonDays + 1));

            var summary = await _dashboard.GetSummaryAsync();

            Assert.Equal(0, summary.ExpiringSoonCount);
        }

        [Fact]
        public async Task GetSummaryAsync_RecentShipmentsAreOrderedNewestFirst()
        {
            var older = AddProduct("Older Shipment Product");
            var newer = AddProduct("Newer Shipment Product");
            _db.Context.Shipments.Add(new Shipment { ProductId = older.Id, ShipmentNumber = "SHP-OLD", Quantity = 1, Location = "InStorage", CreatedAt = DateTime.UtcNow.AddDays(-5) });
            _db.Context.Shipments.Add(new Shipment { ProductId = newer.Id, ShipmentNumber = "SHP-NEW", Quantity = 1, Location = "InStorage", CreatedAt = DateTime.UtcNow });
            await _db.Context.SaveChangesAsync();

            var summary = await _dashboard.GetSummaryAsync();

            Assert.Equal(newer.Name, summary.RecentShipments[0].ProductName);
            Assert.Equal(older.Name, summary.RecentShipments[1].ProductName);
        }
    }
}
