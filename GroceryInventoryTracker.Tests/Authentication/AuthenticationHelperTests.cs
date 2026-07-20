using System.Security.Claims;
using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using GroceryInventoryTracker.Tests.TestHelpers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace GroceryInventoryTracker.Tests.Authentication
{
    public class AuthenticationHelperTests
    {
        private static (HttpContext context, FakeAuthenticationService auth) CreateHttpContext()
        {
            var auth = new FakeAuthenticationService();
            var services = new ServiceCollection();
            services.AddSingleton<IAuthenticationService>(auth);
            var context = new DefaultHttpContext { RequestServices = services.BuildServiceProvider() };
            return (context, auth);
        }

        [Fact]
        public async Task SignInAsync_GrantsTheAdministratorRoleToAnAdminUser()
        {
            var (context, auth) = CreateHttpContext();
            var user = new User { Username = "alice", PasswordHash = "x", IconSvg = "<svg></svg>", Role = UserRole.Administrator };

            await AuthenticationHelper.SignInAsync(context, user);

            Assert.Equal("Administrator", auth.Principal!.FindFirst(ClaimTypes.Role)!.Value);
        }

        [Fact]
        public async Task SignInAsync_GrantsTheEmployeeRoleToAnEmployeeUser()
        {
            var (context, auth) = CreateHttpContext();
            var user = new User { Username = "bob", PasswordHash = "x", IconSvg = "<svg></svg>", Role = UserRole.Employee };

            await AuthenticationHelper.SignInAsync(context, user);

            Assert.Equal("Employee", auth.Principal!.FindFirst(ClaimTypes.Role)!.Value);
        }

        [Fact]
        public async Task SignInAsync_GrantsTheGuestRoleToAGuestUser()
        {
            var (context, auth) = CreateHttpContext();
            var user = new User { Username = "carol", PasswordHash = "x", IconSvg = "<svg></svg>", Role = UserRole.Guest };

            await AuthenticationHelper.SignInAsync(context, user);

            Assert.Equal("Guest", auth.Principal!.FindFirst(ClaimTypes.Role)!.Value);
        }

        [Fact]
        public async Task SignInAsync_SetsTheNameAndIconClaims()
        {
            var (context, auth) = CreateHttpContext();
            var user = new User { Username = "alice", PasswordHash = "x", IconSvg = "<svg>identicon</svg>", Role = UserRole.Guest };

            await AuthenticationHelper.SignInAsync(context, user);

            Assert.Equal("alice", auth.Principal!.Identity!.Name);
            Assert.Equal("<svg>identicon</svg>", auth.Principal.FindFirst("IconSvg")!.Value);
        }

        [Fact]
        public async Task SignInAsync_OmitsTheProfileImageClaimWhenTheUserHasNoUploadedPicture()
        {
            var (context, auth) = CreateHttpContext();
            var user = new User { Username = "alice", PasswordHash = "x", IconSvg = "<svg></svg>", Role = UserRole.Guest, ProfileImagePath = null };

            await AuthenticationHelper.SignInAsync(context, user);

            Assert.Null(auth.Principal!.FindFirst("ProfileImagePath"));
        }

        [Fact]
        public async Task SignInAsync_IncludesTheProfileImageClaimWhenSet()
        {
            var (context, auth) = CreateHttpContext();
            var user = new User { Username = "alice", PasswordHash = "x", IconSvg = "<svg></svg>", Role = UserRole.Guest, ProfileImagePath = "/uploads/alice.png" };

            await AuthenticationHelper.SignInAsync(context, user);

            Assert.Equal("/uploads/alice.png", auth.Principal!.FindFirst("ProfileImagePath")!.Value);
        }

        [Fact]
        public async Task SignInAsync_UsesTheCookieSchemeAndAPersistentCookie()
        {
            var (context, auth) = CreateHttpContext();
            var user = new User { Username = "alice", PasswordHash = "x", IconSvg = "<svg></svg>", Role = UserRole.Guest };

            await AuthenticationHelper.SignInAsync(context, user);

            Assert.Equal(CookieAuthenticationDefaults.AuthenticationScheme, auth.Scheme);
            Assert.True(auth.Properties!.IsPersistent);
        }
    }
}
