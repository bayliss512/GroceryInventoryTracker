using System.ComponentModel.DataAnnotations;

namespace GroceryInventoryTracker.Models
{
    public class AuditLog
    {
        public int Id { get; set; }

        public DateTime Timestamp { get; set; }

        [Required]
        [MaxLength(64)]
        public string Username { get; set; } = default!;

        [Required]
        [MaxLength(100)]
        public string Action { get; set; } = default!;

        [Required]
        public string Details { get; set; } = default!;
    }
}
