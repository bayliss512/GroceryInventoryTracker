using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GroceryInventoryTracker.Pages
{
    [Authorize(Policy = "Admin")]
    public class AdminModel : PageModel
    {
        private readonly UserService _users;
        private readonly ILogger<AdminModel> _logger;

        public AdminModel(UserService users, ILogger<AdminModel> logger)
        {
            _users = users;
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
            if (!await _users.SetAdminAsync(id, true))
            {
                ErrorMessage = "Unable to grant admin access to that user.";
            }
            else
            {
                SuccessMessage = "Admin access granted.";
            }

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostRevokeAdminAsync(int id)
        {
            if (!await _users.SetAdminAsync(id, false))
            {
                ErrorMessage = "Unable to revoke admin access. At least one admin must remain.";
            }
            else
            {
                SuccessMessage = "Admin access revoked.";
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

            if (!await _users.DeleteUserAsync(id))
            {
                ErrorMessage = "Unable to delete that user. At least one admin must remain.";
            }
            else
            {
                SuccessMessage = "User deleted.";
            }

            return RedirectToPage();
        }
    }
}
