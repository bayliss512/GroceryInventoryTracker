using GroceryInventoryTracker.Data;
using GroceryInventoryTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace GroceryInventoryTracker.Services
{
    public class DashboardService
    {
        private readonly InventoryDbContext _db;

        public const int ExpiringSoonDays = 7;
        private const int ListSize = 5;

        public DashboardService(InventoryDbContext db)
        {
            _db = db;
        }

        public class DashboardSummary
        {
            public int TotalProducts { get; set; }

            public int OutOfStockCount { get; set; }
            public List<string> OutOfStockProducts { get; set; } = new();

            public int LowStockCount { get; set; }
            public List<string> LowStockProducts { get; set; } = new();

            public int ExpiringSoonCount { get; set; }
            public List<ExpiringShipmentInfo> ExpiringSoonShipments { get; set; } = new();

            public List<RecentShipmentInfo> RecentShipments { get; set; } = new();
            public List<RecentUserInfo> RecentUsers { get; set; } = new();
        }

        public class ExpiringShipmentInfo
        {
            public string ProductName { get; set; } = default!;
            public string ShipmentNumber { get; set; } = default!;
            public DateTime ExpirationDate { get; set; }
            public int Quantity { get; set; }
        }

        public class RecentShipmentInfo
        {
            public string ProductName { get; set; } = default!;
            public string? SupplierName { get; set; }
            public int Quantity { get; set; }
            public string Location { get; set; } = default!;
            public DateTime CreatedAt { get; set; }
        }

        public class RecentUserInfo
        {
            public string Username { get; set; } = default!;
            public DateTime CreatedAt { get; set; }
        }

        public async Task<DashboardSummary> GetSummaryAsync()
        {
            var summary = new DashboardSummary
            {
                TotalProducts = await _db.Products.CountAsync()
            };

            // Classify every product as out-of-stock, low-stock, or fine using a single
            // grouped query, avoiding a per-product N+1. Each product carries its own
            // LowStockThreshold, so this can't be a single global cutoff.
            var products = await _db.Products
                .Select(p => new { p.Id, p.Name, p.LowStockThreshold })
                .ToListAsync();

            var stockTotals = await _db.Shipments
                .GroupBy(s => s.ProductId)
                .Select(g => new { ProductId = g.Key, Total = g.Sum(s => s.Quantity) })
                .ToDictionaryAsync(x => x.ProductId, x => x.Total);

            var outOfStock = new List<string>();
            var lowStock = new List<string>();

            foreach (var product in products)
            {
                var total = stockTotals.TryGetValue(product.Id, out var qty) ? qty : 0;
                if (total <= 0)
                {
                    outOfStock.Add(product.Name);
                }
                else if (total < product.LowStockThreshold)
                {
                    lowStock.Add(product.Name);
                }
            }

            summary.OutOfStockCount = outOfStock.Count;
            summary.OutOfStockProducts = outOfStock.OrderBy(n => n).Take(ListSize).ToList();

            summary.LowStockCount = lowStock.Count;
            summary.LowStockProducts = lowStock.OrderBy(n => n).Take(ListSize).ToList();

            var today = DateTime.Today;
            var expiringWindowEnd = today.AddDays(ExpiringSoonDays);

            var expiringSoonQuery = _db.Shipments
                .Include(s => s.Product)
                .Where(s => s.ExpirationDate.HasValue && s.ExpirationDate >= today && s.ExpirationDate <= expiringWindowEnd)
                .OrderBy(s => s.ExpirationDate);

            summary.ExpiringSoonCount = await expiringSoonQuery.CountAsync();
            summary.ExpiringSoonShipments = await expiringSoonQuery
                .Take(ListSize)
                .Select(s => new ExpiringShipmentInfo
                {
                    ProductName = s.Product!.Name,
                    ShipmentNumber = s.ShipmentNumber,
                    ExpirationDate = s.ExpirationDate!.Value,
                    Quantity = s.Quantity
                })
                .ToListAsync();

            summary.RecentShipments = await _db.Shipments
                .Include(s => s.Product)
                .Include(s => s.Supplier)
                .OrderByDescending(s => s.CreatedAt)
                .Take(ListSize)
                .Select(s => new RecentShipmentInfo
                {
                    ProductName = s.Product!.Name,
                    SupplierName = s.Supplier != null ? s.Supplier.Name : null,
                    Quantity = s.Quantity,
                    Location = s.Location,
                    CreatedAt = s.CreatedAt
                })
                .ToListAsync();

            summary.RecentUsers = await _db.Users
                .OrderByDescending(u => u.CreatedAt)
                .Take(ListSize)
                .Select(u => new RecentUserInfo
                {
                    Username = u.Username,
                    CreatedAt = u.CreatedAt
                })
                .ToListAsync();

            return summary;
        }
    }
}
