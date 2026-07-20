using System.Reflection;
using GroceryInventoryTracker.Pages;
using Microsoft.AspNetCore.Authorization;
using Xunit;

namespace GroceryInventoryTracker.Tests.Authentication
{
    /// <summary>
    /// Asserts the exact authorization gate on each page model, so a future change can't
    /// silently loosen (or over-restrict) access without a test failing. Mirrors the
    /// Administrator/Employee split established in Phase 4.
    /// </summary>
    public class AuthorizationCoverageTests
    {
        private static AuthorizeAttribute? GetAuthorize(Type pageModelType) =>
            pageModelType.GetCustomAttribute<AuthorizeAttribute>();

        [Theory]
        [InlineData(typeof(AdminModel))]
        [InlineData(typeof(ConfigurationModel))]
        [InlineData(typeof(Pages.Products.CreateModel))]
        [InlineData(typeof(Pages.Products.EditModel))]
        [InlineData(typeof(Pages.Categories.CreateModel))]
        [InlineData(typeof(Pages.Categories.EditModel))]
        [InlineData(typeof(Pages.Suppliers.CreateModel))]
        [InlineData(typeof(Pages.Suppliers.EditModel))]
        [InlineData(typeof(Pages.Audit.IndexModel))]
        public void AdministratorOnlyPages_RequireTheAdministratorRole(Type pageModelType)
        {
            var attribute = GetAuthorize(pageModelType);

            Assert.NotNull(attribute);
            Assert.Equal("Administrator", attribute!.Roles);
        }

        [Theory]
        [InlineData(typeof(DashboardModel))]
        [InlineData(typeof(SettingsModel))]
        public void AnyAuthenticatedUserPages_RequireLoginButNoSpecificRole(Type pageModelType)
        {
            var attribute = GetAuthorize(pageModelType);

            Assert.NotNull(attribute);
            Assert.True(string.IsNullOrEmpty(attribute!.Roles));
        }

        [Theory]
        [InlineData(typeof(Pages.Shipments.CreateModel))]
        [InlineData(typeof(Pages.Shipments.EditModel))]
        public void EmployeeAndAdministratorPages_ExcludeGuests(Type pageModelType)
        {
            var attribute = GetAuthorize(pageModelType);

            Assert.NotNull(attribute);
            Assert.Equal("Administrator,Employee", attribute!.Roles);
        }

        [Theory]
        [InlineData(typeof(IndexModel))]
        [InlineData(typeof(Pages.Products.IndexModel))]
        [InlineData(typeof(Pages.Categories.IndexModel))]
        [InlineData(typeof(Pages.Suppliers.IndexModel))]
        [InlineData(typeof(Pages.Shipments.IndexModel))]
        [InlineData(typeof(AccountModel))]
        [InlineData(typeof(PrivacyModel))]
        public void CatalogViewingAndPublicPages_CarryNoAuthorizeAttribute(Type pageModelType)
        {
            // These stay viewable without logging in; any admin-only actions on them
            // (e.g. delete handlers) are enforced with an explicit in-handler role check
            // instead of a class-level attribute, since the page itself must stay public.
            Assert.Null(GetAuthorize(pageModelType));
        }
    }
}
