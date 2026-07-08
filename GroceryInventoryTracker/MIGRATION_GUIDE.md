# Database Migration Instructions

## Summary of Changes

This migration removes the `QuantityStored` and `QuantityOnSalesFloor` database columns from the Products table.

These values are now **calculated properties** that dynamically compute totals from related Shipment records:
- `QuantityStored` = Sum of all shipments where Location = "InStorage"
- `QuantityOnSalesFloor` = Sum of all shipments where Location = "OnFloor"

## Files Changed

1. **Migration**: `Migrations/20250115000002_RemoveQuantityColumnsFromProducts.cs`
   - Removes QuantityStored and QuantityOnSalesFloor columns from Products table
   - Includes a Down() method to revert if needed

2. **Model Snapshot**: `Migrations/InventoryDbContextModelSnapshot.cs`
   - Updated to reflect current schema without the removed columns

3. **Product Model**: `Models/Product.cs`
   - QuantityStored and QuantityOnSalesFloor are now calculated properties
   - No longer backed by database columns

4. **Database Context**: `Data/InventoryDbContext.cs`
   - Removed seed data for QuantityStored and QuantityOnSalesFloor
   - Updated shipment seeding to include Location values

## Steps to Apply Migration

### Option 1: Using Package Manager Console (Recommended)

1. Open Visual Studio
2. Go to **Tools > NuGet Package Manager > Package Manager Console**
3. Run this command:
   ```powershell
   Update-Database
   ```

### Option 2: Using .NET CLI

1. Open PowerShell/Terminal in the project directory
2. Run this command:
   ```powershell
   dotnet ef database update
   ```

### Option 3: Delete and Reinitialize (Cleanest Start)

1. Delete the existing database file (typically in `GroceryInventoryTracker/app.db` or SQL Server instance)
2. Run migrations from scratch:
   ```powershell
   dotnet ef database update
   ```
3. The database will be created with:
   - All 3 migrations applied
   - Categories, Products, and Shipments seeded with data
   - Products with calculated quantity properties

## Verification

After applying the migration, verify everything works:

1. **Run the application**: `dotnet run`
2. **Check the Index page**: Quantities should display based on shipment totals
3. **Add a shipment**:
   - Go to "Add Shipment"
   - Add a shipment with Location = "InStorage" or "OnFloor"
   - Verify quantities update automatically

## Rollback (if needed)

If you need to revert to the previous version with stored columns:

```powershell
# Revert to the previous migration
Update-Database -TargetMigration AddLocationToShipments
```

This will re-add the QuantityStored and QuantityOnSalesFloor columns.

## Architecture Notes

### Why Calculated Properties?

**Single Source of Truth**: All inventory quantities now come from shipment records. This prevents data inconsistencies and eliminates the need to manually update two separate columns.

**Automatic Calculations**: Adding or updating shipments automatically reflects in product quantity displays.

**Better Data Integrity**: No risk of stored values becoming out of sync with actual shipment data.

### Performance Consideration

Calculated properties use LINQ `.Where()` and `.Sum()` operations. For small to medium databases (< 10,000 products), this is performant enough. If you need to optimize for very large datasets later, consider:

1. Creating a database view
2. Using computed columns in SQL Server
3. Implementing a background job to update a denormalized quantity cache

For now, the calculated property approach is clean, maintainable, and recommended for this project.
