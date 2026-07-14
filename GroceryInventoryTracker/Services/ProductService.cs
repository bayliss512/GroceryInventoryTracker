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
        private readonly ILogger<ProductService> _logger;

        // Image directory constants
        private const string PRODUCT_IMAGES_DIRECTORY = "Images/ProductImages";
        private const string WEB_IMAGE_PATH = "/Images/ProductImages";

        public ProductService(InventoryDbContext db, IWebHostEnvironment webHostEnvironment, ILogger<ProductService> logger)
        {
            _db = db;
            _logger = logger;

            // Initialize image path resolver
            try
            {
                var physicalImagePath = Path.Combine(webHostEnvironment.WebRootPath, PRODUCT_IMAGES_DIRECTORY);
                _logger.LogInformation($"Image resolver initialized with path: {physicalImagePath}");
                _imagePathResolver = new ImagePathResolver(physicalImagePath, WEB_IMAGE_PATH, logger);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to initialize image path resolver");
                _imagePathResolver = new ImagePathResolver(string.Empty, WEB_IMAGE_PATH, logger);
            }
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
                .Include(p => p.Shipments)
                .AsNoTracking()
                .OrderBy(p => p.Name)
                .ToListAsync();
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            return await _db.Categories
                .AsNoTracking()
                .OrderBy(c => c.Name)
                .ToListAsync();
        }

        public async Task<PagedResult<Product>> GetProductsAsync(string? search, int? categoryId, int page, int pageSize)
        {
            var query = _db.Products
                .Include(p => p.Category)
                .Include(p => p.Shipments)
                .AsNoTracking()
                .AsQueryable();

            if (categoryId.HasValue)
            {
                query = query.Where(p => p.CategoryId == categoryId.Value);
            }

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
                .Include(p => p.Category)
                .Include(p => p.Shipments)
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Product> CreateAsync(Product product)
        {
            _db.Products.Add(product);
            await _db.SaveChangesAsync();

            _logger.LogInformation("Created product '{Name}'.", product.Name);
            return product;
        }

        /// <summary>
        /// Updates a product's editable fields. Returns false if the product does not exist.
        /// </summary>
        public async Task<bool> UpdateAsync(int id, Product updated)
        {
            var product = await _db.Products.FirstOrDefaultAsync(p => p.Id == id);
            if (product == null)
            {
                return false;
            }

            product.Name = updated.Name;
            product.CategoryId = updated.CategoryId;
            product.ImagePath = updated.ImagePath;

            await _db.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Deletes a product. Returns false if it doesn't exist, or a friendly error message
        /// if it can't be deleted because shipments still reference it.
        /// </summary>
        public async Task<(bool Success, string? Error)> DeleteAsync(int id)
        {
            var product = await _db.Products.FirstOrDefaultAsync(p => p.Id == id);
            if (product == null)
            {
                return (false, "Product not found.");
            }

            var shipmentCount = await _db.Shipments.CountAsync(s => s.ProductId == id);
            if (shipmentCount > 0)
            {
                return (false, $"Cannot delete '{product.Name}' — it has {shipmentCount} shipment(s) on record. Remove those shipments first.");
            }

            _db.Products.Remove(product);
            await _db.SaveChangesAsync();

            _logger.LogInformation("Deleted product '{Name}'.", product.Name);
            return (true, null);
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
            try
            {
                var result = _imagePathResolver.ResolveImagePath(productName);
                if (string.IsNullOrEmpty(result))
                {
                    _logger.LogWarning($"Could not resolve image path for product: {productName}");
                }
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error resolving image path for product: {productName}");
                return null;
            }
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
