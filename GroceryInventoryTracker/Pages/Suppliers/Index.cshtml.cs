using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GroceryInventoryTracker.Pages.Suppliers
{
    public class IndexModel : PageModel
    {
        private readonly SupplierService _suppliers;

        public IndexModel(SupplierService suppliers)
        {
            _suppliers = suppliers;
        }

        [TempData]
        public string? SuccessMessage { get; set; }

        [TempData]
        public string? ErrorMessage { get; set; }

        public List<Supplier> Suppliers { get; set; } = new();

        public async Task OnGetAsync()
        {
            Suppliers = await _suppliers.GetAllAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            if (User.Identity?.IsAuthenticated != true)
            {
                return RedirectToPage("/Account");
            }

            var (success, error) = await _suppliers.DeleteAsync(id);
            ErrorMessage = success ? null : error;
            SuccessMessage = success ? "Supplier deleted." : null;

            return RedirectToPage();
        }
    }
}
