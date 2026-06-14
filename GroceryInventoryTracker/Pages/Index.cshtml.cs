using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryInventoryTracker.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ProductService _service;

        public IndexModel(ProductService service)
        {
            _service = service;
        }

        public List<Product> Products { get; set; } = new();

        public async Task OnGetAsync()
        {
            Products = await _service.GetAllProductsAsync();
        }

        public async Task<IActionResult> OnGetShipmentsAsync(int productId)
        {
            var shipments = await _service.GetShipmentsForProductAsync(productId);
            var result = shipments.Select(s => new
            {
                s.Id,
                shipmentNumber = s.ShipmentNumber,
                expirationDate = s.ExpirationDate,
                quantity = s.Quantity
            }).ToList();

            return new JsonResult(result);
        }
    }
}
