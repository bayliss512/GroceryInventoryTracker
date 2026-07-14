using System.ComponentModel.DataAnnotations;
using GroceryInventoryTracker.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GroceryInventoryTracker.Pages.Categories
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly CategoryService _categories;

        public CreateModel(CategoryService categories)
        {
            _categories = categories;
        }

        [BindProperty]
        public InputModel Input { get; set; } = new();

        public class InputModel
        {
            [Required(ErrorMessage = "Name is required.")]
            [StringLength(100, ErrorMessage = "Name must be 100 characters or fewer.")]
            public string Name { get; set; } = default!;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _categories.CreateAsync(Input.Name.Trim());
            TempData["SuccessMessage"] = "Category created.";
            return RedirectToPage("Index");
        }
    }
}
