using GroceryInventoryTracker.Services;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GroceryInventoryTracker.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = default!;

        // QuantityStored and QuantityOnSalesFloor are now calculated properties
        // that sum shipments based on their Location
        public int QuantityStored;

        public int QuantityOnSalesFloor;
public void UpdateQuantities(ICollection<Shipment> shipments)
        {
            QuantityStored = shipments.Where(s => s.Location == "InStorage").Sum(s => s.Quantity);
            QuantityOnSalesFloor = shipments.Where(s => s.Location == "OnFloor").Sum(s => s.Quantity);
        }

        // Category relationship (added for Phase 6)
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        // Path to product image (reserved for Phase 8)
        public string? ImagePath { get; set; }

        public ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();
    }
}
