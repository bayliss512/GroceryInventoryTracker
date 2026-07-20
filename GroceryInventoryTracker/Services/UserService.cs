using System.Security.Cryptography;
using System.Text;
using GroceryInventoryTracker.Data;
using GroceryInventoryTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace GroceryInventoryTracker.Services
{
    public class UserService
    {
        private readonly InventoryDbContext _db;
        private readonly ILogger<UserService> _logger;

        private const int SaltSize = 16;
        private const int HashSize = 32;
        private const int Iterations = 100_000;

        public const string PasswordRequirements = "At least 8 characters, including a letter and a number.";

        public UserService(InventoryDbContext db, ILogger<UserService> logger)
        {
            _db = db;
            _logger = logger;
        }

        /// <summary>
        /// Returns an error message if the password does not meet the sign-up requirements, otherwise null.
        /// </summary>
        public static string? ValidatePassword(string? password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
            {
                return "Password must be at least 8 characters long.";
            }
            if (!password.Any(char.IsLetter))
            {
                return "Password must contain at least one letter.";
            }
            if (!password.Any(char.IsDigit))
            {
                return "Password must contain at least one number.";
            }
            return null;
        }

        public async Task<User?> GetByUsernameAsync(string username)
        {
            return await _db.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task<User> CreateUserAsync(string username, string password)
        {
            var isFirstUser = !await _db.Users.AnyAsync();

            var user = new User
            {
                Username = username,
                PasswordHash = HashPassword(password),
                IconSvg = GenerateIdenticonSvg(),
                CreatedAt = DateTime.UtcNow,
                Role = isFirstUser ? UserRole.Administrator : UserRole.Guest
            };

            _db.Users.Add(user);
            await _db.SaveChangesAsync();

            _logger.LogInformation($"Created new user '{username}'.");
            return user;
        }

        /// <summary>
        /// Returns the user if the username/password combination is valid, otherwise null.
        /// </summary>
        public async Task<User?> ValidateLoginAsync(string username, string password)
        {
            var user = await GetByUsernameAsync(username);
            if (user == null || !VerifyPassword(password, user.PasswordHash))
            {
                return null;
            }
            return user;
        }

        /// <summary>
        /// Changes the user's password after verifying the current one.
        /// Returns false if the user does not exist or the current password is wrong.
        /// </summary>
        public async Task<bool> ChangePasswordAsync(string username, string currentPassword, string newPassword)
        {
            var user = await _db.Users.FirstOrDefaultAsync(u => u.Username == username);
            if (user == null || !VerifyPassword(currentPassword, user.PasswordHash))
            {
                return false;
            }

            user.PasswordHash = HashPassword(newPassword);
            await _db.SaveChangesAsync();

            _logger.LogInformation($"Password changed for user '{username}'.");
            return true;
        }

        /// <summary>
        /// Sets (or clears, when null) the user's uploaded profile picture path.
        /// Returns the updated user, or null if not found.
        /// </summary>
        public async Task<User?> SetProfileImagePathAsync(string username, string? path)
        {
            var user = await _db.Users.FirstOrDefaultAsync(u => u.Username == username);
            if (user == null)
            {
                return null;
            }

            user.ProfileImagePath = path;
            await _db.SaveChangesAsync();
            return user;
        }

        /// <summary>
        /// Sets the user's dark mode preference. Returns the updated user, or null if not found.
        /// </summary>
        public async Task<User?> SetDarkModeEnabledAsync(string username, bool enabled)
        {
            var user = await _db.Users.FirstOrDefaultAsync(u => u.Username == username);
            if (user == null)
            {
                return null;
            }

            user.DarkModeEnabled = enabled;
            await _db.SaveChangesAsync();
            return user;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _db.Users
                .AsNoTracking()
                .OrderBy(u => u.CreatedAt)
                .ToListAsync();
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            return await _db.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        /// <summary>
        /// Sets a user's role (Guest, Employee, or Administrator). Returns false if the user
        /// does not exist, or if this would leave the system with no remaining admins.
        /// </summary>
        public async Task<bool> SetRoleAsync(int userId, UserRole role)
        {
            var user = await _db.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (user == null)
            {
                return false;
            }

            if (user.Role == UserRole.Administrator && role != UserRole.Administrator
                && await _db.Users.CountAsync(u => u.Role == UserRole.Administrator) <= 1)
            {
                return false;
            }

            user.Role = role;
            await _db.SaveChangesAsync();

            _logger.LogInformation($"User '{user.Username}' role set to {role}.");
            return true;
        }

        /// <summary>
        /// Deletes a user. Returns false if the user does not exist, or if the user is the
        /// last remaining admin.
        /// </summary>
        public async Task<bool> DeleteUserAsync(int userId)
        {
            var user = await _db.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (user == null)
            {
                return false;
            }

            if (user.Role == UserRole.Administrator && await _db.Users.CountAsync(u => u.Role == UserRole.Administrator) <= 1)
            {
                return false;
            }

            _db.Users.Remove(user);
            await _db.SaveChangesAsync();

            _logger.LogInformation($"Deleted user '{user.Username}'.");
            return true;
        }

        private static string HashPassword(string password)
        {
            var salt = RandomNumberGenerator.GetBytes(SaltSize);
            var hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithmName.SHA256, HashSize);
            return $"{Iterations}.{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}";
        }

        private static bool VerifyPassword(string password, string storedHash)
        {
            var parts = storedHash.Split('.');
            if (parts.Length != 3 || !int.TryParse(parts[0], out var iterations))
            {
                return false;
            }

            var salt = Convert.FromBase64String(parts[1]);
            var expected = Convert.FromBase64String(parts[2]);
            var actual = Rfc2898DeriveBytes.Pbkdf2(password, salt, iterations, HashAlgorithmName.SHA256, expected.Length);
            return CryptographicOperations.FixedTimeEquals(actual, expected);
        }

        /// <summary>
        /// Generates a random GitHub-style identicon: a horizontally symmetric 5x5
        /// block grid in a random color on a light background.
        /// </summary>
        public static string GenerateIdenticonSvg()
        {
            var bytes = RandomNumberGenerator.GetBytes(4);
            var hue = bytes[0] * 360 / 256;
            var color = $"hsl({hue}, 60%, 45%)";

            var sb = new StringBuilder();
            sb.Append("<svg xmlns=\"http://www.w3.org/2000/svg\" viewBox=\"0 0 5 5\" shape-rendering=\"crispEdges\">");
            sb.Append("<rect width=\"5\" height=\"5\" fill=\"#f0f0f0\"/>");

            // 15 random bits fill the left 3 columns; the right 2 mirror the left
            var bits = (bytes[1] << 16) | (bytes[2] << 8) | bytes[3];
            var bit = 0;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    var on = ((bits >> bit) & 1) == 1;
                    bit++;
                    if (!on) continue;

                    sb.Append($"<rect x=\"{x}\" y=\"{y}\" width=\"1\" height=\"1\" fill=\"{color}\"/>");
                    if (x < 2)
                    {
                        sb.Append($"<rect x=\"{4 - x}\" y=\"{y}\" width=\"1\" height=\"1\" fill=\"{color}\"/>");
                    }
                }
            }

            sb.Append("</svg>");
            return sb.ToString();
        }
    }
}
