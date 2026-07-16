using System.ComponentModel.DataAnnotations;

namespace GroceryInventoryTracker.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string Username { get; set; } = default!;

        // Format: "{iterations}.{base64 salt}.{base64 hash}" (PBKDF2-SHA256); the plaintext password is never stored
        [Required]
        public string PasswordHash { get; set; } = default!;

        // Random GitHub-style identicon (SVG markup) assigned at sign-up
        [Required]
        public string IconSvg { get; set; } = default!;

        // Optional uploaded profile picture (web path under wwwroot); falls back to IconSvg when null
        public string? ProfileImagePath { get; set; }

        public DateTime CreatedAt { get; set; }

        // Grants access to the /Admin page (user management). The first account created is made admin automatically.
        public bool IsAdmin { get; set; }

        // User-level dark mode preference, toggled from /Settings.
        public bool DarkModeEnabled { get; set; }
    }
}
