using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryInventoryTracker.Pages
{
    public class AddShipmentModel : PageModel
    {
        private readonly ProductService _service;

        public AddShipmentModel(ProductService service)
        {
            _service = service;
        }

        [BindProperty]
        public AddShipmentInput Input { get; set; } = new();

        public SelectList ProductSelectList { get; set; } = new(new List<SelectListItem>());

        public string? SuccessMessage { get; set; }
        public string? ErrorMessage { get; set; }

        public async Task OnGetAsync()
        {
            await LoadProductsAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                await LoadProductsAsync();
                return Page();
            }

            try
            {
                await _service.CreateShipmentAsync(
                    Input.ProductId,
                    Input.ShipmentNumber,
                    Input.ExpirationDate,
                    Input.Quantity
                );

                SuccessMessage = $"Shipment '{Input.ShipmentNumber}' created successfully!";
                Input = new(); // Reset form
                await LoadProductsAsync();
                return Page();
            }
            catch (ArgumentException ex)
            {
                ErrorMessage = ex.Message;
                await LoadProductsAsync();
                return Page();
            }
            catch (Exception ex)
            {
                ErrorMessage = $"An error occurred while creating the shipment: {ex.Message}";
                await LoadProductsAsync();
                return Page();
            }
        }

        private async Task LoadProductsAsync()
        {
            var products = await _service.GetAllProductsAsync();
            var selectItems = products
                .OrderBy(p => p.Category?.Name)
                .ThenBy(p => p.Name)
                .Select(p => new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = $"{p.Name} ({p.Category?.Name ?? "Uncategorized"})"
                })
                .ToList();

            ProductSelectList = new SelectList(selectItems, "Value", "Text");
        }

        public class AddShipmentInput
        {
            [Required(ErrorMessage = "Please select a product.")]
            public int ProductId { get; set; }

            [Required(ErrorMessage = "Shipment number is required.")]
            [StringLength(50, ErrorMessage = "Shipment number cannot exceed 50 characters.")]
            public string ShipmentNumber { get; set; } = default!;

            [Required(ErrorMessage = "Expiration date is required.")]
            [DataType(DataType.Date)]
            public DateTime ExpirationDate { get; set; }

            [Required(ErrorMessage = "Quantity is required.")]
            [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0.")]
            public int Quantity { get; set; }
        }
    }
}
