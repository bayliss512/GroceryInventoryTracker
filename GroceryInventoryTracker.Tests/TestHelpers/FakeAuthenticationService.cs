using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace GroceryInventoryTracker.Tests.TestHelpers
{
    /// <summary>Captures the arguments passed to SignInAsync so tests can assert on the issued claims without a running host.</summary>
    public class FakeAuthenticationService : IAuthenticationService
    {
        public string? Scheme { get; private set; }
        public ClaimsPrincipal? Principal { get; private set; }
        public AuthenticationProperties? Properties { get; private set; }

        public Task SignInAsync(HttpContext context, string? scheme, ClaimsPrincipal principal, AuthenticationProperties? properties)
        {
            Scheme = scheme;
            Principal = principal;
            Properties = properties;
            return Task.CompletedTask;
        }

        public Task<AuthenticateResult> AuthenticateAsync(HttpContext context, string? scheme) => throw new NotImplementedException();
        public Task ChallengeAsync(HttpContext context, string? scheme, AuthenticationProperties? properties) => throw new NotImplementedException();
        public Task ForbidAsync(HttpContext context, string? scheme, AuthenticationProperties? properties) => throw new NotImplementedException();
        public Task SignOutAsync(HttpContext context, string? scheme, AuthenticationProperties? properties) => throw new NotImplementedException();
    }
}
