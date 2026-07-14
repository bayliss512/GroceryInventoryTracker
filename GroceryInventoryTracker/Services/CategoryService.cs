using GroceryInventoryTracker.Data;
using GroceryInventoryTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace GroceryInventoryTracker.Services
{
    public class CategoryService
    {
        private readonly InventoryDbContext _db;
        private readonly ILogger<CategoryService> _logger;

        public CategoryService(InventoryDbContext db, ILogger<CategoryService> logger)
        {
            _db = db;
            _logger = logger;
        }

        public async Task<List<Category>> GetAllWithProductCountsAsync()
        {
            return await _db.Categories
                .Include(c => c.Products)
                .AsNoTracking()
                .OrderBy(c => c.Name)
                .ToListAsync();
        }

        public async Task<Category?> GetByIdAsync(int id)
        {
            return await _db.Categories
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Category> CreateAsync(string name)
        {
            var category = new Category { Name = name };
            _db.Categories.Add(category);
            await _db.SaveChangesAsync();

            _logger.LogInformation("Created category '{Name}'.", name);
            return category;
        }

        /// <summary>
        /// Renames a category. Returns false if the category does not exist.
        /// </summary>
        public async Task<bool> UpdateAsync(int id, string name)
        {
            var category = await _db.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (category == null)
            {
                return false;
            }

            category.Name = name;
            await _db.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Deletes a category. Returns false if it doesn't exist, or a friendly error message
        /// if it can't be deleted because products still reference it.
        /// </summary>
        public async Task<(bool Success, string? Error)> DeleteAsync(int id)
        {
            var category = await _db.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (category == null)
            {
                return (false, "Category not found.");
            }

            var productCount = await _db.Products.CountAsync(p => p.CategoryId == id);
            if (productCount > 0)
            {
                return (false, $"Cannot delete '{category.Name}' — it has {productCount} product(s) assigned to it. Move or delete those products first.");
            }

            _db.Categories.Remove(category);
            await _db.SaveChangesAsync();

            _logger.LogInformation("Deleted category '{Name}'.", category.Name);
            return (true, null);
        }
    }
}
