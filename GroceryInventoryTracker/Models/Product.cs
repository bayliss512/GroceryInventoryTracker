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

        public ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();
    }
}
