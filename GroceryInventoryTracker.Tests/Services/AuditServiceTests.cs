using GroceryInventoryTracker.Services;
using GroceryInventoryTracker.Tests.TestHelpers;
using Xunit;

namespace GroceryInventoryTracker.Tests.Services
{
    public class AuditServiceTests : IDisposable
    {
        private readonly SqliteInMemoryDatabase _db;
        private readonly AuditService _audit;

        public AuditServiceTests()
        {
            _db = new SqliteInMemoryDatabase();
            _audit = new AuditService(_db.Context);
        }

        public void Dispose() => _db.Dispose();

        [Fact]
        public async Task LogAsync_PersistsAnEntryWithATimestamp()
        {
            var before = DateTime.UtcNow;

            await _audit.LogAsync("alice", "ProductCreated", "Created product 'Apples'.");

            var entries = await _audit.GetRecentAsync();
            var entry = Assert.Single(entries);
            Assert.Equal("alice", entry.Username);
            Assert.Equal("ProductCreated", entry.Action);
            Assert.Equal("Created product 'Apples'.", entry.Details);
            Assert.True(entry.Timestamp >= before);
        }

        [Fact]
        public async Task LogAsync_FallsBackToUnknownWhenNoUsernameIsProvided()
        {
            await _audit.LogAsync(null, "ProductCreated", "Created product 'Apples'.");

            var entry = Assert.Single(await _audit.GetRecentAsync());
            Assert.Equal("Unknown", entry.Username);
        }

        [Fact]
        public async Task GetRecentAsync_OrdersEntriesNewestFirst()
        {
            await _audit.LogAsync("alice", "First", "First action");
            await Task.Delay(5);
            await _audit.LogAsync("alice", "Second", "Second action");

            var entries = await _audit.GetRecentAsync();

            Assert.Equal("Second", entries[0].Action);
            Assert.Equal("First", entries[1].Action);
        }

        [Fact]
        public async Task GetRecentAsync_RespectsTheCountLimit()
        {
            for (var i = 0; i < 5; i++)
            {
                await _audit.LogAsync("alice", $"Action{i}", "Details");
            }

            var entries = await _audit.GetRecentAsync(count: 3);

            Assert.Equal(3, entries.Count);
        }
    }
}
