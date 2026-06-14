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

        public Product? Product { get; set; }
    }
}
