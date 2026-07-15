using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GroceryInventoryTracker.Pages
{
    [Authorize(Roles = "Administrator")]
    public class AdminModel : PageModel
    {
        private readonly UserService _users;
        private readonly AuditService _audit;
        private readonly ILogger<AdminModel> _logger;

        public AdminModel(UserService users, AuditService audit, ILogger<AdminModel> logger)
        {
            _users = users;
            _audit = audit;
            _logger = logger;
        }

        [TempData]
        public string? SuccessMessage { get; set; }

        [TempData]
        public string? ErrorMessage { get; set; }

        public List<User> Users { get; set; } = new();

        public async Task OnGetAsync()
        {
            Users = await _users.GetAllUsersAsync();
        }

        public async Task<IActionResult> OnPostMakeAdminAsync(int id)
        {
            var target = await _users.GetByIdAsync(id);
            if (!await _users.SetAdminAsync(id, true))
            {
                ErrorMessage = "Unable to grant admin access to that user.";
            }
            else
            {
                SuccessMessage = "Admin access granted.";
                await _audit.LogAsync(User.Identity?.Name, "UserPromoted", $"Granted Administrator role to '{target?.Username}' (Id={id}).");
            }

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostRevokeAdminAsync(int id)
        {
            var target = await _users.GetByIdAsync(id);
            if (!await _users.SetAdminAsync(id, false))
            {
                ErrorMessage = "Unable to revoke admin access. At least one admin must remain.";
            }
            else
            {
                SuccessMessage = "Admin access revoked.";
                await _audit.LogAsync(User.Identity?.Name, "UserDemoted", $"Revoked Administrator role from '{target?.Username}' (Id={id}).");
            }

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            if (User.Identity?.Name != null)
            {
                var currentUser = await _users.GetByUsernameAsync(User.Identity.Name);
                if (currentUser?.Id == id)
                {
                    ErrorMessage = "You cannot delete your own account.";
                    return RedirectToPage();
                }
            }

            var target = await _users.GetByIdAsync(id);
            if (!await _users.DeleteUserAsync(id))
            {
                ErrorMessage = "Unable to delete that user. At least one admin must remain.";
            }
            else
            {
                SuccessMessage = "User deleted.";
                await _audit.LogAsync(User.Identity?.Name, "UserDeleted", $"Deleted user '{target?.Username}' (Id={id}).");
            }

            return RedirectToPage();
        }
    }
}
