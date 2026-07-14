using System.ComponentModel.DataAnnotations;
using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GroceryInventoryTracker.Pages.Products
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly ProductService _products;

        public EditModel(ProductService products)
        {
            _products = products;
        }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

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
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var product = await _products.GetProductByIdAsync(Id);
            if (product == null)
            {
                return RedirectToPage("Index");
            }

            Input = new InputModel
            {
                Name = product.Name,
                CategoryId = product.CategoryId,
                ImagePath = product.ImagePath
            };
            await LoadCategoryOptionsAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                await LoadCategoryOptionsAsync();
                return Page();
            }

            var updated = await _products.UpdateAsync(Id, new Product
            {
                Name = Input.Name.Trim(),
                CategoryId = Input.CategoryId,
                ImagePath = string.IsNullOrWhiteSpace(Input.ImagePath) ? null : Input.ImagePath.Trim()
            });

            if (!updated)
            {
                TempData["ErrorMessage"] = "Product not found.";
                return RedirectToPage("Index");
            }

            TempData["SuccessMessage"] = "Product updated.";
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
