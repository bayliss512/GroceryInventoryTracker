using GroceryInventoryTracker.Data;
using GroceryInventoryTracker.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace GroceryInventoryTracker.Services
{
    public class ProductService
    {
        private readonly InventoryDbContext _db;
        private readonly ImagePathResolver _imagePathResolver;

        // Image directory constants
        private const string PRODUCT_IMAGES_DIRECTORY = "Images/ProductImages";
        private const string WEB_IMAGE_PATH = "/Images/ProductImages";

        public ProductService(InventoryDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;

            // Initialize image path resolver
            var physicalImagePath = Path.Combine(webHostEnvironment.WebRootPath, PRODUCT_IMAGES_DIRECTORY);
            _imagePathResolver = new ImagePathResolver(physicalImagePath, WEB_IMAGE_PATH);
        }

        // Simple paged result helper
        public class PagedResult<T>
        {
            public List<T> Items { get; set; } = new List<T>();
            public int TotalCount { get; set; }
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _db.Products
                .Include(p => p.Category)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<PagedResult<Product>> GetProductsAsync(string? search, int page, int pageSize)
        {
            var query = _db.Products
                .Include(p => p.Category)
                .AsNoTracking()
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                var term = search.Trim().ToLower();
                query = query.Where(p => p.Name.ToLower().Contains(term) || (p.Category != null && p.Category.Name.ToLower().Contains(term)));
            }

            var total = await query.CountAsync();

            var items = await query
                .OrderBy(p => p.CategoryId)
                .ThenBy(p => p.Name)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PagedResult<Product>
            {
                Items = items,
                TotalCount = total
            };
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

        public async Task<Shipment> CreateShipmentAsync(int productId, string shipmentNumber, DateTime expirationDate, int quantity)
        {
            // Verify product exists
            var product = await _db.Products.FindAsync(productId);
            if (product == null)
            {
                throw new ArgumentException($"Product with ID {productId} not found.");
            }

            var shipment = new Shipment
            {
                ProductId = productId,
                ShipmentNumber = shipmentNumber,
                ExpirationDate = expirationDate,
                Quantity = quantity
            };

            _db.Shipments.Add(shipment);
            await _db.SaveChangesAsync();

            return shipment;
        }

        /// <summary>
        /// Resolves the image path for a product based on its name using smart matching.
        /// </summary>
        public string ResolveProductImagePath(string productName)
        {
            return _imagePathResolver.ResolveImagePath(productName);
        }

        /// <summary>
        /// Gets the full list of available image files from the ProductImages directory.
        /// </summary>
        public string[] GetAvailableProductImages()
        {
            var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", PRODUCT_IMAGES_DIRECTORY);
            if (Directory.Exists(imagePath))
            {
                return Directory.GetFiles(imagePath)
                    .Select(Path.GetFileName)
                    .OrderBy(f => f)
                    .ToArray();
            }
            return new string[0];
        }
    }
}
