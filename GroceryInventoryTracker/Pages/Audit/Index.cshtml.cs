using GroceryInventoryTracker.Models;
using GroceryInventoryTracker.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GroceryInventoryTracker.Pages.Audit
{
    [Authorize(Roles = "Administrator")]
    public class IndexModel : PageModel
    {
        private readonly AuditService _audit;

        public IndexModel(AuditService audit)
        {
            _audit = audit;
        }

        public List<AuditLog> Entries { get; set; } = new();

        public async Task OnGetAsync()
        {
            Entries = await _audit.GetRecentAsync();
        }
    }
}
