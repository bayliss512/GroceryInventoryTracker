using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GroceryInventoryTracker.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly CategoryService _categories;

        public IndexModel(CategoryService categories)
        {
            _categories = categories;
        }

        [TempData]
        public string? SuccessMessage { get; set; }

        [TempData]
        public string? ErrorMessage { get; set; }

        public List<Category> Categories { get; set; } = new();

        public async Task OnGetAsync()
        {
            Categories = await _categories.GetAllWithProductCountsAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            if (User.Identity?.IsAuthenticated != true)
            {
                return RedirectToPage("/Account");
            }
            if (!User.IsInRole("Administrator"))
            {
                return Forbid();
            }

            var (success, error) = await _categories.DeleteAsync(id);
            ErrorMessage = success ? null : error;
            SuccessMessage = success ? "Category deleted." : null;

            return RedirectToPage();
        }
    }
}
