using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GroceryInventoryTracker.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ProductService _products;
        private readonly AuditService _audit;

        public IndexModel(ProductService products, AuditService audit)
        {
            _products = products;
            _audit = audit;
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
            if (!User.IsInRole("Administrator"))
            {
                return Forbid();
            }

            var product = await _products.GetProductByIdAsync(id);
            var (success, error) = await _products.DeleteAsync(id);
            ErrorMessage = success ? null : error;
            SuccessMessage = success ? "Product deleted." : null;

            if (success)
            {
                await _audit.LogAsync(User.Identity?.Name, "ProductDeleted", $"Deleted product '{product?.Name}' (Id={id}).");
            }

            return RedirectToPage();
        }
    }
}
