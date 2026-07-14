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
    public class CreateModel : PageModel
    {
        private readonly ProductService _products;

        public CreateModel(ProductService products)
        {
            _products = products;
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
                ImagePath = string.IsNullOrWhiteSpace(Input.ImagePath) ? null : Input.ImagePath.Trim()
            });

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
