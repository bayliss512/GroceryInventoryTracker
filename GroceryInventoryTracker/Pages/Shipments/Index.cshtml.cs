using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GroceryInventoryTracker.Pages.Shipments
{
    public class IndexModel : PageModel
    {
        private readonly ShipmentService _shipments;
        private readonly ProductService _products;

        public IndexModel(ShipmentService shipments, ProductService products)
        {
            _shipments = shipments;
            _products = products;
        }

        [TempData]
        public string? SuccessMessage { get; set; }

        [TempData]
        public string? ErrorMessage { get; set; }

        [FromQuery]
        public int? ProductId { get; set; }

        public List<Shipment> Shipments { get; set; } = new();

        public List<SelectListItem> ProductOptions { get; set; } = new();

        public async Task OnGetAsync()
        {
            Shipments = await _shipments.GetAllAsync(ProductId);

            var products = await _products.GetAllProductsAsync();
            ProductOptions = products
                .Select(p => new SelectListItem { Value = p.Id.ToString(), Text = p.Name })
                .ToList();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            if (User.Identity?.IsAuthenticated != true)
            {
                return RedirectToPage("/Account");
            }

            var success = await _shipments.DeleteAsync(id);
            ErrorMessage = success ? null : "Shipment not found.";
            SuccessMessage = success ? "Shipment deleted." : null;

            return RedirectToPage(new { ProductId });
        }
    }
}
