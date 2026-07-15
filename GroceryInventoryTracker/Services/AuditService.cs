using GroceryInventoryTracker.Data;
using GroceryInventoryTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace GroceryInventoryTracker.Services
{
    public class AuditService
    {
        private readonly InventoryDbContext _db;

        public AuditService(InventoryDbContext db)
        {
            _db = db;
        }

        public async Task LogAsync(string? username, string action, string details)
        {
            _db.AuditLogs.Add(new AuditLog
            {
                Timestamp = DateTime.UtcNow,
                Username = string.IsNullOrWhiteSpace(username) ? "Unknown" : username,
                Action = action,
                Details = details
            });
            await _db.SaveChangesAsync();
        }

        public async Task<List<AuditLog>> GetRecentAsync(int count = 200)
        {
            return await _db.AuditLogs
                .AsNoTracking()
                .OrderByDescending(a => a.Timestamp)
                .Take(count)
                .ToListAsync();
        }
    }
}
