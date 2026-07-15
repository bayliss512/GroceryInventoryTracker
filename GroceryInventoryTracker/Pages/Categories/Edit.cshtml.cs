using System.ComponentModel.DataAnnotations;
using GroceryInventoryTracker.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GroceryInventoryTracker.Pages.Categories
{
    [Authorize(Roles = "Administrator")]
    public class EditModel : PageModel
    {
        private readonly CategoryService _categories;

        public EditModel(CategoryService categories)
        {
            _categories = categories;
        }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        [BindProperty]
        public InputModel Input { get; set; } = new();

        public class InputModel
        {
            [Required(ErrorMessage = "Name is required.")]
            [StringLength(100, ErrorMessage = "Name must be 100 characters or fewer.")]
            public string Name { get; set; } = default!;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var category = await _categories.GetByIdAsync(Id);
            if (category == null)
            {
                return RedirectToPage("Index");
            }

            Input = new InputModel { Name = category.Name };
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (!await _categories.UpdateAsync(Id, Input.Name.Trim()))
            {
                TempData["ErrorMessage"] = "Category not found.";
                return RedirectToPage("Index");
            }

            TempData["SuccessMessage"] = "Category updated.";
            return RedirectToPage("Index");
        }
    }
}
