using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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

            // Search and pagination
            [FromQuery]
            public string? Search { get; set; }

            [FromQuery(Name = "Page")]
            public int CurrentPage { get; set; } = 1;

            public int PageSize { get; set; } = 10;

            public int TotalCount { get; set; }

            public string? ErrorMessage { get; set; }

            public int TotalPages => (int)System.Math.Ceiling((double)TotalCount / PageSize);

            public async Task OnGetAsync()
            {
                try
                {
                    var pageToUse = CurrentPage < 1 ? 1 : CurrentPage;
                    var result = await _service.GetProductsAsync(Search, pageToUse, PageSize);
                    Products = result.Items;

                    // Resolve image paths using smart algorithm
                    foreach (var product in Products)
                    {
                        var resolvedPath = _service.ResolveProductImagePath(product.Name);
                        if (!string.IsNullOrEmpty(resolvedPath))
                        {
                            product.ImagePath = resolvedPath;
                        }
                    }

                    TotalCount = result.TotalCount;
                }
                catch (SqlException ex)
                {
                    // Only show error for actual database connection/structure issues
                    ErrorMessage = "Unable to load products. The database may not be properly initialized. Please use the Configuration page to initialize the database.";
                    Products = new();
                    TotalCount = 0;
                }
                catch (DbUpdateException ex)
                {
                    ErrorMessage = "Unable to load products. The database may not be properly initialized. Please use the Configuration page to initialize the database.";
                    Products = new();
                    TotalCount = 0;
                }
                catch (Exception ex)
                {
                    ErrorMessage = "Unable to load products. The database may not be properly initialized. Please use the Configuration page to initialize the database.";
                    Products = new();
                    TotalCount = 0;
                }
            }

        public async Task<IActionResult> OnGetShipmentsAsync(int productId)
        {
            try
            {
                var shipments = await _service.GetShipmentsForProductAsync(productId);
                var result = shipments.Select(s => new
                {
                    s.Id,
                    shipmentNumber = s.ShipmentNumber,
                    expirationDate = s.ExpirationDate,
                    quantity = s.Quantity,
                    location = s.Location
                }).ToList();

                return new JsonResult(result);
            }
            catch (Exception ex)
            {
                return new JsonResult(new { error = "Unable to load shipments. The database may not be properly initialized." }) { StatusCode = 500 };
            }
        }

        /// <summary>
        /// Helper method to get resolved image path for a product using smart matching.
        /// </summary>
        public string GetProductImagePath(Product product)
        {
            if (product == null || string.IsNullOrEmpty(product.Name))
                return null;

            var resolvedPath = _service.ResolveProductImagePath(product.Name);
            return !string.IsNullOrEmpty(resolvedPath) ? resolvedPath : product.ImagePath;
        }
    }
}
