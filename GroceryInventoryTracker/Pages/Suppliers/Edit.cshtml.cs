using System.ComponentModel.DataAnnotations;
using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GroceryInventoryTracker.Pages.Suppliers
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly SupplierService _suppliers;

        public EditModel(SupplierService suppliers)
        {
            _suppliers = suppliers;
        }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

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

        public async Task<IActionResult> OnGetAsync()
        {
            var supplier = await _suppliers.GetByIdAsync(Id);
            if (supplier == null)
            {
                return RedirectToPage("Index");
            }

            Input = new InputModel
            {
                Name = supplier.Name,
                ContactName = supplier.ContactName,
                Phone = supplier.Phone,
                Email = supplier.Email,
                Address = supplier.Address
            };
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var updated = await _suppliers.UpdateAsync(Id, new Supplier
            {
                Name = Input.Name.Trim(),
                ContactName = string.IsNullOrWhiteSpace(Input.ContactName) ? null : Input.ContactName.Trim(),
                Phone = string.IsNullOrWhiteSpace(Input.Phone) ? null : Input.Phone.Trim(),
                Email = string.IsNullOrWhiteSpace(Input.Email) ? null : Input.Email.Trim(),
                Address = string.IsNullOrWhiteSpace(Input.Address) ? null : Input.Address.Trim()
            });

            if (!updated)
            {
                TempData["ErrorMessage"] = "Supplier not found.";
                return RedirectToPage("Index");
            }

            TempData["SuccessMessage"] = "Supplier updated.";
            return RedirectToPage("Index");
        }
    }
}
