using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using GroceryInventoryTracker.Tests.TestHelpers;
using Microsoft.Extensions.Logging.Abstractions;
using Xunit;

namespace GroceryInventoryTracker.Tests.Services
{
    public class CategoryServiceTests : IDisposable
    {
        private readonly SqliteInMemoryDatabase _db;
        private readonly CategoryService _categories;

        public CategoryServiceTests()
        {
            _db = new SqliteInMemoryDatabase();
            _categories = new CategoryService(_db.Context, NullLogger<CategoryService>.Instance);
        }

        public void Dispose() => _db.Dispose();

        [Fact]
        public async Task CreateAsync_PersistsTheCategory()
        {
            var created = await _categories.CreateAsync("Produce");

            var reloaded = await _categories.GetByIdAsync(created.Id);
            Assert.NotNull(reloaded);
            Assert.Equal("Produce", reloaded!.Name);
        }

        [Fact]
        public async Task UpdateAsync_RenamesAnExistingCategory()
        {
            var category = await _categories.CreateAsync("Produce");

            var updated = await _categories.UpdateAsync(category.Id, "Fresh Produce");

            Assert.True(updated);
            Assert.Equal("Fresh Produce", (await _categories.GetByIdAsync(category.Id))!.Name);
        }

        [Fact]
        public async Task UpdateAsync_ReturnsFalseWhenTheCategoryDoesNotExist()
        {
            var updated = await _categories.UpdateAsync(999, "Nope");

            Assert.False(updated);
        }

        [Fact]
        public async Task DeleteAsync_RemovesACategoryWithNoProducts()
        {
            var category = await _categories.CreateAsync("Produce");

            var (success, error) = await _categories.DeleteAsync(category.Id);

            Assert.True(success);
            Assert.Null(error);
            Assert.Null(await _categories.GetByIdAsync(category.Id));
        }

        [Fact]
        public async Task DeleteAsync_IsBlockedWhileProductsReferenceTheCategory()
        {
            var category = await _categories.CreateAsync("Produce");
            _db.Context.Products.Add(new Product { Name = "Apples", CategoryId = category.Id });
            await _db.Context.SaveChangesAsync();

            var (success, error) = await _categories.DeleteAsync(category.Id);

            Assert.False(success);
            Assert.Contains("product", error);
            Assert.NotNull(await _categories.GetByIdAsync(category.Id));
        }

        [Fact]
        public async Task GetAllWithProductCountsAsync_CountsProductsPerCategory()
        {
            var produce = await _categories.CreateAsync("Produce");
            var bakery = await _categories.CreateAsync("Bakery");
            _db.Context.Products.AddRange(
                new Product { Name = "Apples", CategoryId = produce.Id },
                new Product { Name = "Bananas", CategoryId = produce.Id },
                new Product { Name = "Bread", CategoryId = bakery.Id });
            await _db.Context.SaveChangesAsync();

            var all = await _categories.GetAllWithProductCountsAsync();

            Assert.Equal(2, all.Single(c => c.Id == produce.Id).Products.Count);
            Assert.Single(all.Single(c => c.Id == bakery.Id).Products);
        }
    }
}
