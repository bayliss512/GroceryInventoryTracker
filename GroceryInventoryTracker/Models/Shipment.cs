using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryInventoryTracker.Models
{
    public class Shipment
    {
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public string ShipmentNumber { get; set; } = default!;

        [Required]
        public DateTime ExpirationDate { get; set; }

        public int Quantity { get; set; }

        [Required]
        public string Location { get; set; } = "InStorage"; // "OnFloor" or "InStorage"

        public DateTime CreatedAt { get; set; }

        public Product? Product { get; set; }

        public int? SupplierId { get; set; }
        public Supplier? Supplier { get; set; }
    }
}
