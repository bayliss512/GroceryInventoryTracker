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
        private readonly SupplierService _suppliers;

        public IndexModel(ProductService service, SupplierService suppliers)
        {
            _service = service;
            _suppliers = suppliers;
        }

        public List<Product> Products { get; set; } = new();

            // Search, filters, sorting, and pagination
            [FromQuery]
            public string? Search { get; set; }

            [FromQuery]
            public int? CategoryId { get; set; }

            [FromQuery]
            public int? SupplierId { get; set; }

            [FromQuery]
            public string? ExpirationFilter { get; set; }

            [FromQuery]
            public string? SortBy { get; set; }

            public List<Category> Categories { get; set; } = new();

            public List<Supplier> Suppliers { get; set; } = new();

            [FromQuery(Name = "Page")]
            public int CurrentPage { get; set; } = 1;

            public int PageSize { get; set; } = 10;

            public int TotalCount { get; set; }

            public string? ErrorMessage { get; set; }

            public int TotalPages => (int)System.Math.Ceiling((double)TotalCount / PageSize);

            public async Task OnGetAsync()
            {
                await LoadProductsAsync();
            }

            /// <summary>
            /// AJAX handler used by the live search box: returns just the results markup
            /// (product grid + pagination) so the page can be updated without a full reload.
            /// </summary>
            public async Task<IActionResult> OnGetResultsAsync()
            {
                await LoadProductsAsync();
                return Partial("_ProductResults", this);
            }

            private async Task LoadProductsAsync()
            {
                try
                {
                    var pageToUse = CurrentPage < 1 ? 1 : CurrentPage;
                    Categories = await _service.GetCategoriesAsync();
                    Suppliers = await _suppliers.GetAllAsync();

                    var expirationFilter = Enum.TryParse<Services.ExpirationFilter>(ExpirationFilter, out var parsedExpiration)
                        ? parsedExpiration
                        : Services.ExpirationFilter.All;
                    var sortBy = Enum.TryParse<ProductSortBy>(SortBy, out var parsedSort)
                        ? parsedSort
                        : ProductSortBy.Name;

                    var result = await _service.GetProductsAsync(Search, CategoryId, pageToUse, PageSize, SupplierId, expirationFilter, sortBy);
                    Products = result.Items;

                    foreach (var product in Products)
                    {
                        // Resolve image paths using smart algorithm
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

        /// <summary>
        /// Builds a pagination link for the given page number that preserves every active
        /// filter/sort so paging never silently drops them.
        /// </summary>
        public string PageUrl(int page)
        {
            var query = new List<string> { $"Page={page}" };

            if (!string.IsNullOrEmpty(Search))
                query.Add($"Search={System.Net.WebUtility.UrlEncode(Search)}");
            if (CategoryId.HasValue)
                query.Add($"CategoryId={CategoryId.Value}");
            if (SupplierId.HasValue)
                query.Add($"SupplierId={SupplierId.Value}");
            if (!string.IsNullOrEmpty(ExpirationFilter))
                query.Add($"ExpirationFilter={ExpirationFilter}");
            if (!string.IsNullOrEmpty(SortBy))
                query.Add($"SortBy={SortBy}");

            return "?" + string.Join("&", query);
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
