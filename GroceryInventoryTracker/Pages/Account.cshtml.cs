using System.Security.Claims;
using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GroceryInventoryTracker.Pages
{
    public class AccountModel : PageModel
    {
        private readonly UserService _users;
        private readonly ILogger<AccountModel> _logger;

        public AccountModel(UserService users, ILogger<AccountModel> logger)
        {
            _users = users;
            _logger = logger;
        }

        [BindProperty]
        public string? Username { get; set; }

        [BindProperty]
        public string? Password { get; set; }

        public string? ErrorMessage { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostLoginAsync()
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrEmpty(Password))
            {
                ErrorMessage = "Username and password are required.";
                return Page();
            }

            try
            {
                var user = await _users.ValidateLoginAsync(Username.Trim(), Password);
                if (user == null)
                {
                    ErrorMessage = "Invalid username or password.";
                    return Page();
                }

                await SignInUserAsync(user);
                return RedirectToPage("/Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Login failed");
                ErrorMessage = "Unable to log in. The database may need to be initialized from the Configuration page.";
                return Page();
            }
        }

        public async Task<IActionResult> OnPostSignUpAsync()
        {
            if (string.IsNullOrWhiteSpace(Username))
            {
                ErrorMessage = "Username is required.";
                return Page();
            }

            var passwordError = UserService.ValidatePassword(Password);
            if (passwordError != null)
            {
                ErrorMessage = passwordError;
                return Page();
            }

            try
            {
                var username = Username.Trim();
                if (await _users.GetByUsernameAsync(username) != null)
                {
                    ErrorMessage = "That username is already taken.";
                    return Page();
                }

                var user = await _users.CreateUserAsync(username, Password!);
                await SignInUserAsync(user);
                return RedirectToPage("/Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Sign up failed");
                ErrorMessage = "Unable to sign up. The database may need to be initialized from the Configuration page.";
                return Page();
            }
        }

        public async Task<IActionResult> OnPostLogoutAsync()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToPage("/Index");
        }

        private Task SignInUserAsync(User user)
        {
            return AuthenticationHelper.SignInAsync(HttpContext, user);
        }
    }
}
