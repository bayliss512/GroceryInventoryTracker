using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace GroceryInventoryTracker.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; } = default!;

        // Computed from Shipments (which must be loaded/Included by the caller); not stored in the database.
        [NotMapped]
        public int QuantityStored => Shipments.Where(s => s.Location == "InStorage").Sum(s => s.Quantity);

        [NotMapped]
        public int QuantityOnSalesFloor => Shipments.Where(s => s.Location == "OnFloor").Sum(s => s.Quantity);

        [Required]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public string? ImagePath { get; set; }

        public bool IsPerishable { get; set; } = true;

        public const int DefaultLowStockThreshold = 20;

        // Total quantity (across all shipments/locations) at or below out-of-stock is 0, and this
        // is the dividing line between "low stock" and "well stocked" — configurable per product
        // since a case of soda and a single high-value item shouldn't share one global number.
        [Range(0, int.MaxValue, ErrorMessage = "Low stock threshold cannot be negative.")]
        public int LowStockThreshold { get; set; } = DefaultLowStockThreshold;

        public ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();
    }
}
