using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GroceryInventoryTracker.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ProductService _products;

        public IndexModel(ProductService products)
        {
            _products = products;
        }

        [TempData]
        public string? SuccessMessage { get; set; }

        [TempData]
        public string? ErrorMessage { get; set; }

        public List<Product> Products { get; set; } = new();

        public async Task OnGetAsync()
        {
            Products = await _products.GetAllProductsAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            if (User.Identity?.IsAuthenticated != true)
            {
                return RedirectToPage("/Account");
            }

            var (success, error) = await _products.DeleteAsync(id);
            ErrorMessage = success ? null : error;
            SuccessMessage = success ? "Product deleted." : null;

            return RedirectToPage();
        }
    }
}
