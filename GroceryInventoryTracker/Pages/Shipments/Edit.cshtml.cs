using System.ComponentModel.DataAnnotations;
using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GroceryInventoryTracker.Pages.Shipments
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly ShipmentService _shipments;
        private readonly ProductService _products;
        private readonly SupplierService _suppliers;

        public EditModel(ShipmentService shipments, ProductService products, SupplierService suppliers)
        {
            _shipments = shipments;
            _products = products;
            _suppliers = suppliers;
        }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        [BindProperty]
        public InputModel Input { get; set; } = new();

        public List<SelectListItem> ProductOptions { get; set; } = new();
        public List<SelectListItem> SupplierOptions { get; set; } = new();

        public class InputModel
        {
            [Required(ErrorMessage = "Product is required.")]
            public int ProductId { get; set; }

            public int? SupplierId { get; set; }

            [Required(ErrorMessage = "Shipment number is required.")]
            [StringLength(50, ErrorMessage = "Shipment number must be 50 characters or fewer.")]
            public string ShipmentNumber { get; set; } = default!;

            [Required(ErrorMessage = "Expiration date is required.")]
            [DataType(DataType.Date)]
            public DateTime ExpirationDate { get; set; }

            [Required]
            [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
            public int Quantity { get; set; }

            [Required]
            public string Location { get; set; } = "InStorage";
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var shipment = await _shipments.GetByIdAsync(Id);
            if (shipment == null)
            {
                return RedirectToPage("Index");
            }

            Input = new InputModel
            {
                ProductId = shipment.ProductId,
                SupplierId = shipment.SupplierId,
                ShipmentNumber = shipment.ShipmentNumber,
                ExpirationDate = shipment.ExpirationDate,
                Quantity = shipment.Quantity,
                Location = shipment.Location
            };
            await LoadOptionsAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                await LoadOptionsAsync();
                return Page();
            }

            var updated = await _shipments.UpdateAsync(Id, new Shipment
            {
                ProductId = Input.ProductId,
                SupplierId = Input.SupplierId,
                ShipmentNumber = Input.ShipmentNumber.Trim(),
                ExpirationDate = Input.ExpirationDate,
                Quantity = Input.Quantity,
                Location = Input.Location
            });

            if (!updated)
            {
                TempData["ErrorMessage"] = "Shipment not found.";
                return RedirectToPage("Index");
            }

            TempData["SuccessMessage"] = "Shipment updated.";
            return RedirectToPage("Index");
        }

        private async Task LoadOptionsAsync()
        {
            var products = await _products.GetAllProductsAsync();
            ProductOptions = products
                .Select(p => new SelectListItem { Value = p.Id.ToString(), Text = p.Name })
                .ToList();

            var suppliers = await _suppliers.GetAllAsync();
            SupplierOptions = suppliers
                .Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name })
                .ToList();
        }
    }
}
