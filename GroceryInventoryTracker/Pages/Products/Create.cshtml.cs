using System.ComponentModel.DataAnnotations;
using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GroceryInventoryTracker.Pages.Products
{
    [Authorize(Roles = "Administrator")]
    public class CreateModel : PageModel
    {
        private readonly ProductService _products;
        private readonly AuditService _audit;

        public CreateModel(ProductService products, AuditService audit)
        {
            _products = products;
            _audit = audit;
        }

        [BindProperty]
        public InputModel Input { get; set; } = new();

        public List<SelectListItem> CategoryOptions { get; set; } = new();

        public class InputModel
        {
            [Required(ErrorMessage = "Name is required.")]
            [StringLength(200, ErrorMessage = "Name must be 200 characters or fewer.")]
            public string Name { get; set; } = default!;

            [Required(ErrorMessage = "Category is required.")]
            public int CategoryId { get; set; }

            [StringLength(300)]
            public string? ImagePath { get; set; }

            public bool IsPerishable { get; set; } = true;

            [Range(0, int.MaxValue, ErrorMessage = "Low stock threshold cannot be negative.")]
            public int LowStockThreshold { get; set; } = Product.DefaultLowStockThreshold;
        }

        public async Task OnGetAsync()
        {
            await LoadCategoryOptionsAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                await LoadCategoryOptionsAsync();
                return Page();
            }

            await _products.CreateAsync(new Product
            {
                Name = Input.Name.Trim(),
                CategoryId = Input.CategoryId,
                ImagePath = string.IsNullOrWhiteSpace(Input.ImagePath) ? null : Input.ImagePath.Trim(),
                IsPerishable = Input.IsPerishable,
                LowStockThreshold = Input.LowStockThreshold
            });
            await _audit.LogAsync(User.Identity?.Name, "ProductCreated", $"Created product '{Input.Name.Trim()}'.");

            TempData["SuccessMessage"] = "Product created.";
            return RedirectToPage("Index");
        }

        private async Task LoadCategoryOptionsAsync()
        {
            var categories = await _products.GetCategoriesAsync();
            CategoryOptions = categories
                .Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
                .ToList();
        }
    }
}
