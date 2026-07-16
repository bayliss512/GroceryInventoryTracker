namespace GroceryInventoryTracker.ViewModels
{
    public class EmptyStateViewModel
    {
        public string Icon { get; set; } = "icon-inbox";
        public string Message { get; set; } = default!;
        public string? CtaText { get; set; }
        public string? CtaHref { get; set; }
    }
}
