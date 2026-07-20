namespace GroceryInventoryTracker.Models
{
    // Guest is the default role for newly signed-up users (aside from the first account, which
    // becomes Administrator automatically). Employee must be granted explicitly by an Administrator.
    public enum UserRole
    {
        Guest = 0,
        Employee = 1,
        Administrator = 2
    }
}
