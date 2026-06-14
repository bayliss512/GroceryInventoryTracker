using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GroceryInventoryTracker.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = default!;

        public int QuantityStored { get; set; }

        public int QuantityOnShelves { get; set; }

        public ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();
    }
}
