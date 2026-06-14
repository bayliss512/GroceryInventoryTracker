using GroceryInventoryTracker.Data;
using GroceryInventoryTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace GroceryInventoryTracker.Services
{
    public class ProductService
    {
        private readonly InventoryDbContext _db;

        public ProductService(InventoryDbContext db)
        {
            _db = db;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _db.Products
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _db.Products
                .Include(p => p.Shipments)
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Shipment>> GetShipmentsForProductAsync(int productId)
        {
            return await _db.Shipments
                .AsNoTracking()
                .Where(s => s.ProductId == productId)
                .OrderBy(s => s.ExpirationDate)
                .ToListAsync();
        }
    }
}
