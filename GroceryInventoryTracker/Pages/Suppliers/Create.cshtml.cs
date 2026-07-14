using System.ComponentModel.DataAnnotations;
using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GroceryInventoryTracker.Pages.Suppliers
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly SupplierService _suppliers;

        public CreateModel(SupplierService suppliers)
        {
            _suppliers = suppliers;
        }

        [BindProperty]
        public InputModel Input { get; set; } = new();

        public class InputModel
        {
            [Required(ErrorMessage = "Name is required.")]
            [StringLength(200, ErrorMessage = "Name must be 200 characters or fewer.")]
            public string Name { get; set; } = default!;

            [StringLength(200)]
            public string? ContactName { get; set; }

            [StringLength(30)]
            [Phone(ErrorMessage = "Enter a valid phone number.")]
            public string? Phone { get; set; }

            [StringLength(200)]
            [EmailAddress(ErrorMessage = "Enter a valid email address.")]
            public string? Email { get; set; }

            [StringLength(300)]
            public string? Address { get; set; }
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

            await _suppliers.CreateAsync(new Supplier
            {
                Name = Input.Name.Trim(),
                ContactName = string.IsNullOrWhiteSpace(Input.ContactName) ? null : Input.ContactName.Trim(),
                Phone = string.IsNullOrWhiteSpace(Input.Phone) ? null : Input.Phone.Trim(),
                Email = string.IsNullOrWhiteSpace(Input.Email) ? null : Input.Email.Trim(),
                Address = string.IsNullOrWhiteSpace(Input.Address) ? null : Input.Address.Trim()
            });

            TempData["SuccessMessage"] = "Supplier created.";
            return RedirectToPage("Index");
        }
    }
}
