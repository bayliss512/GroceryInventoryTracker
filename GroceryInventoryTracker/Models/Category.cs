using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace GroceryInventoryTracker.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = default!;

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
