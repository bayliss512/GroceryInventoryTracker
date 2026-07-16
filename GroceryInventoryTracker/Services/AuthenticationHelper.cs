using System.Security.Claims;
using GroceryInventoryTracker.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace GroceryInventoryTracker.Services
{
    public static class AuthenticationHelper
    {
        /// <summary>
        /// Issues (or refreshes) the authentication cookie with the user's
        /// current name, identicon, and profile picture claims.
        /// </summary>
        public static async Task SignInAsync(HttpContext httpContext, User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim("IconSvg", user.IconSvg),
                new Claim(ClaimTypes.Role, user.IsAdmin ? "Administrator" : "Employee"),
                new Claim("Theme", user.DarkModeEnabled ? "dark" : "light")
            };

            if (!string.IsNullOrEmpty(user.ProfileImagePath))
            {
                claims.Add(new Claim("ProfileImagePath", user.ProfileImagePath));
            }

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            await httpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(identity),
                new AuthenticationProperties { IsPersistent = true });
        }
    }
}
