using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using GroceryInventoryTracker.Tests.TestHelpers;
using Microsoft.Extensions.Logging.Abstractions;
using Xunit;

namespace GroceryInventoryTracker.Tests.Services
{
    public class UserServiceTests : IDisposable
    {
        private readonly SqliteInMemoryDatabase _db;
        private readonly UserService _users;

        public UserServiceTests()
        {
            _db = new SqliteInMemoryDatabase();
            _users = new UserService(_db.Context, NullLogger<UserService>.Instance);
        }

        public void Dispose() => _db.Dispose();

        [Theory]
        [InlineData(null, "Password must be at least 8 characters long.")]
        [InlineData("", "Password must be at least 8 characters long.")]
        [InlineData("short1", "Password must be at least 8 characters long.")]
        [InlineData("alllettersnodigit", "Password must contain at least one number.")]
        [InlineData("12345678", "Password must contain at least one letter.")]
        public void ValidatePassword_RejectsInvalidPasswords(string? password, string expectedError)
        {
            var error = UserService.ValidatePassword(password);

            Assert.Equal(expectedError, error);
        }

        [Fact]
        public void ValidatePassword_AcceptsAPasswordWithALetterAndADigit()
        {
            var error = UserService.ValidatePassword("Password123");

            Assert.Null(error);
        }

        [Fact]
        public async Task CreateUserAsync_MakesTheFirstUserAdmin()
        {
            var first = await _users.CreateUserAsync("alice", "Password123");

            Assert.Equal(UserRole.Administrator, first.Role);
        }

        [Fact]
        public async Task CreateUserAsync_MakesSubsequentUsersGuestsByDefault()
        {
            await _users.CreateUserAsync("alice", "Password123");
            var second = await _users.CreateUserAsync("bob", "Password123");

            Assert.Equal(UserRole.Guest, second.Role);
        }

        [Fact]
        public async Task CreateUserAsync_NeverStoresThePlaintextPassword()
        {
            var user = await _users.CreateUserAsync("alice", "Password123");

            Assert.DoesNotContain("Password123", user.PasswordHash);
        }

        [Fact]
        public async Task CreateUserAsync_GeneratesAnIdenticonSvg()
        {
            var user = await _users.CreateUserAsync("alice", "Password123");

            Assert.Contains("<svg", user.IconSvg);
        }

        [Fact]
        public async Task ValidateLoginAsync_SucceedsWithTheCorrectPassword()
        {
            await _users.CreateUserAsync("alice", "Password123");

            var result = await _users.ValidateLoginAsync("alice", "Password123");

            Assert.NotNull(result);
            Assert.Equal("alice", result!.Username);
        }

        [Fact]
        public async Task ValidateLoginAsync_FailsWithTheWrongPassword()
        {
            await _users.CreateUserAsync("alice", "Password123");

            var result = await _users.ValidateLoginAsync("alice", "WrongPassword1");

            Assert.Null(result);
        }

        [Fact]
        public async Task ValidateLoginAsync_FailsForAnUnknownUsername()
        {
            var result = await _users.ValidateLoginAsync("nobody", "Password123");

            Assert.Null(result);
        }

        [Fact]
        public async Task ChangePasswordAsync_UpdatesTheHashWhenTheCurrentPasswordIsCorrect()
        {
            await _users.CreateUserAsync("alice", "Password123");

            var changed = await _users.ChangePasswordAsync("alice", "Password123", "NewPassword1");

            Assert.True(changed);
            Assert.Null(await _users.ValidateLoginAsync("alice", "Password123"));
            Assert.NotNull(await _users.ValidateLoginAsync("alice", "NewPassword1"));
        }

        [Fact]
        public async Task ChangePasswordAsync_FailsAndLeavesTheHashUnchangedWhenCurrentPasswordIsWrong()
        {
            await _users.CreateUserAsync("alice", "Password123");

            var changed = await _users.ChangePasswordAsync("alice", "WrongCurrent1", "NewPassword1");

            Assert.False(changed);
            Assert.NotNull(await _users.ValidateLoginAsync("alice", "Password123"));
        }

        [Fact]
        public async Task SetRoleAsync_CannotDemoteTheLastRemainingAdmin()
        {
            var admin = await _users.CreateUserAsync("alice", "Password123");

            var result = await _users.SetRoleAsync(admin.Id, UserRole.Employee);

            Assert.False(result);
            var reloaded = await _users.GetByIdAsync(admin.Id);
            Assert.Equal(UserRole.Administrator, reloaded!.Role);
        }

        [Fact]
        public async Task SetRoleAsync_CanDemoteOneOfTwoAdmins()
        {
            var admin = await _users.CreateUserAsync("alice", "Password123");
            var second = await _users.CreateUserAsync("bob", "Password123");
            await _users.SetRoleAsync(second.Id, UserRole.Administrator);

            var result = await _users.SetRoleAsync(second.Id, UserRole.Guest);

            Assert.True(result);
            var reloaded = await _users.GetByIdAsync(second.Id);
            Assert.Equal(UserRole.Guest, reloaded!.Role);
        }

        [Fact]
        public async Task SetRoleAsync_CanPromoteAGuestToAdministrator()
        {
            await _users.CreateUserAsync("alice", "Password123");
            var bob = await _users.CreateUserAsync("bob", "Password123");

            var result = await _users.SetRoleAsync(bob.Id, UserRole.Administrator);

            Assert.True(result);
            var reloaded = await _users.GetByIdAsync(bob.Id);
            Assert.Equal(UserRole.Administrator, reloaded!.Role);
        }

        [Fact]
        public async Task SetRoleAsync_CanPromoteAGuestToEmployee()
        {
            await _users.CreateUserAsync("alice", "Password123");
            var bob = await _users.CreateUserAsync("bob", "Password123");

            var result = await _users.SetRoleAsync(bob.Id, UserRole.Employee);

            Assert.True(result);
            var reloaded = await _users.GetByIdAsync(bob.Id);
            Assert.Equal(UserRole.Employee, reloaded!.Role);
        }

        [Fact]
        public async Task DeleteUserAsync_CannotDeleteTheLastRemainingAdmin()
        {
            var admin = await _users.CreateUserAsync("alice", "Password123");

            var result = await _users.DeleteUserAsync(admin.Id);

            Assert.False(result);
            Assert.NotNull(await _users.GetByIdAsync(admin.Id));
        }

        [Fact]
        public async Task DeleteUserAsync_CanDeleteAStandardUser()
        {
            await _users.CreateUserAsync("alice", "Password123");
            var bob = await _users.CreateUserAsync("bob", "Password123");

            var result = await _users.DeleteUserAsync(bob.Id);

            Assert.True(result);
            Assert.Null(await _users.GetByIdAsync(bob.Id));
        }

        [Fact]
        public async Task GetAllUsersAsync_OrdersByCreatedAt()
        {
            await _users.CreateUserAsync("alice", "Password123");
            await _users.CreateUserAsync("bob", "Password123");

            var all = await _users.GetAllUsersAsync();

            Assert.Equal(new[] { "alice", "bob" }, all.Select(u => u.Username));
        }
    }
}
