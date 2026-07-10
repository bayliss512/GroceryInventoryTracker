using GroceryInventoryTracker.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GroceryInventoryTracker.Pages
{
    [Authorize]
    public class SettingsModel : PageModel
    {
        private readonly UserService _users;
        private readonly IWebHostEnvironment _env;
        private readonly ILogger<SettingsModel> _logger;

        private const long MaxProfilePictureBytes = 2 * 1024 * 1024;
        private static readonly string[] AllowedImageExtensions = { ".png", ".jpg", ".jpeg", ".gif", ".webp" };
        private const string ProfilePicturesDirectory = "Images/ProfilePictures";

        public SettingsModel(UserService users, IWebHostEnvironment env, ILogger<SettingsModel> logger)
        {
            _users = users;
            _env = env;
            _logger = logger;
        }

        // TempData so the message survives the redirect after a successful post
        [TempData]
        public string? SuccessMessage { get; set; }

        public string? ErrorMessage { get; set; }

        public Models.User? CurrentUser { get; set; }

        [BindProperty]
        public string? CurrentPassword { get; set; }

        [BindProperty]
        public string? NewPassword { get; set; }

        [BindProperty]
        public string? ConfirmPassword { get; set; }

        [BindProperty]
        public IFormFile? ProfilePicture { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            return await LoadCurrentUserAsync() ? Page() : await SignOutToAccountAsync();
        }

        public async Task<IActionResult> OnPostChangePasswordAsync()
        {
            if (!await LoadCurrentUserAsync())
            {
                return await SignOutToAccountAsync();
            }

            if (string.IsNullOrEmpty(CurrentPassword) || string.IsNullOrEmpty(NewPassword) || string.IsNullOrEmpty(ConfirmPassword))
            {
                ErrorMessage = "All password fields are required.";
                return Page();
            }

            if (NewPassword != ConfirmPassword)
            {
                ErrorMessage = "New passwords do not match.";
                return Page();
            }

            var passwordError = UserService.ValidatePassword(NewPassword);
            if (passwordError != null)
            {
                ErrorMessage = passwordError;
                return Page();
            }

            if (!await _users.ChangePasswordAsync(User.Identity!.Name!, CurrentPassword, NewPassword))
            {
                ErrorMessage = "Current password is incorrect.";
                return Page();
            }

            SuccessMessage = "Password changed successfully.";
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostUploadPictureAsync()
        {
            if (!await LoadCurrentUserAsync())
            {
                return await SignOutToAccountAsync();
            }

            if (ProfilePicture == null || ProfilePicture.Length == 0)
            {
                ErrorMessage = "Choose an image file to upload.";
                return Page();
            }

            if (ProfilePicture.Length > MaxProfilePictureBytes)
            {
                ErrorMessage = "Profile picture must be 2 MB or smaller.";
                return Page();
            }

            var extension = Path.GetExtension(ProfilePicture.FileName).ToLowerInvariant();
            if (!AllowedImageExtensions.Contains(extension))
            {
                ErrorMessage = $"Unsupported image type. Allowed: {string.Join(", ", AllowedImageExtensions)}";
                return Page();
            }

            try
            {
                var directory = Path.Combine(_env.WebRootPath, ProfilePicturesDirectory);
                Directory.CreateDirectory(directory);

                // Timestamped filename so the browser never serves a stale cached picture
                var fileName = $"user-{CurrentUser!.Id}-{DateTime.UtcNow.Ticks}{extension}";
                var filePath = Path.Combine(directory, fileName);

                using (var stream = System.IO.File.Create(filePath))
                {
                    await ProfilePicture.CopyToAsync(stream);
                }

                DeleteProfilePictureFiles(CurrentUser.Id, exceptFileName: fileName);

                var webPath = $"/{ProfilePicturesDirectory}/{fileName}";
                var updated = await _users.SetProfileImagePathAsync(User.Identity!.Name!, webPath);
                if (updated == null)
                {
                    return await SignOutToAccountAsync();
                }

                // Refresh the cookie so the navbar picks up the new picture; the
                // redirect makes the very next request render with the new claims
                await AuthenticationHelper.SignInAsync(HttpContext, updated);

                SuccessMessage = "Profile picture updated.";
                return RedirectToPage();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to upload profile picture");
                ErrorMessage = "Unable to save the profile picture. Please try again.";
            }

            return Page();
        }

        public async Task<IActionResult> OnPostRemovePictureAsync()
        {
            if (!await LoadCurrentUserAsync())
            {
                return await SignOutToAccountAsync();
            }

            try
            {
                DeleteProfilePictureFiles(CurrentUser!.Id, exceptFileName: null);

                var updated = await _users.SetProfileImagePathAsync(User.Identity!.Name!, null);
                if (updated == null)
                {
                    return await SignOutToAccountAsync();
                }

                await AuthenticationHelper.SignInAsync(HttpContext, updated);

                SuccessMessage = "Profile picture removed. Your identicon is shown again.";
                return RedirectToPage();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to remove profile picture");
                ErrorMessage = "Unable to remove the profile picture. Please try again.";
            }

            return Page();
        }

        private async Task<bool> LoadCurrentUserAsync()
        {
            var username = User.Identity?.Name;
            if (string.IsNullOrEmpty(username))
            {
                return false;
            }

            CurrentUser = await _users.GetByUsernameAsync(username);
            return CurrentUser != null;
        }

        private async Task<IActionResult> SignOutToAccountAsync()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToPage("/Account");
        }

        private void DeleteProfilePictureFiles(int userId, string? exceptFileName)
        {
            var directory = Path.Combine(_env.WebRootPath, ProfilePicturesDirectory);
            if (!Directory.Exists(directory))
            {
                return;
            }

            foreach (var file in Directory.GetFiles(directory, $"user-{userId}-*"))
            {
                if (exceptFileName != null && Path.GetFileName(file) == exceptFileName)
                {
                    continue;
                }
                System.IO.File.Delete(file);
            }
        }
    }
}
