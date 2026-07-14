using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GroceryInventoryTracker.Models
{
    public class Supplier
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; } = default!;

        [MaxLength(200)]
        public string? ContactName { get; set; }

        [MaxLength(30)]
        public string? Phone { get; set; }

        [MaxLength(200)]
        [EmailAddress]
        public string? Email { get; set; }

        [MaxLength(300)]
        public string? Address { get; set; }

        public ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();
    }
}
