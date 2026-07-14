using GroceryInventoryTracker.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GroceryInventoryTracker.Pages
{
    [Authorize]
    public class DashboardModel : PageModel
    {
        private readonly DashboardService _dashboard;

        public DashboardModel(DashboardService dashboard)
        {
            _dashboard = dashboard;
        }

        public DashboardService.DashboardSummary Summary { get; set; } = new();

        public int LowStockThreshold => DashboardService.LowStockThreshold;
        public int ExpiringSoonDays => DashboardService.ExpiringSoonDays;

        public async Task OnGetAsync()
        {
            Summary = await _dashboard.GetSummaryAsync();
        }

        public async Task<IActionResult> OnGetDataAsync()
        {
            var summary = await _dashboard.GetSummaryAsync();
            return new JsonResult(summary);
        }
    }
}
