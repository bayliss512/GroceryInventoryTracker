# Quick Start Guide - Apply Migrations

## Before You Start

Make sure you have:
- ✅ Visual Studio Community 2026 open
- ✅ GroceryInventoryTracker.slnx solution loaded
- ✅ Project builds successfully

## Method 1: Using PowerShell Script (Easiest)

1. Open PowerShell in the project root directory
2. Run one of these commands:

```powershell
# Apply latest migrations (UPDATE)
.\update-database.ps1 -Action Update

# Revert to previous migration state (ROLLBACK)
.\update-database.ps1 -Action Rollback

# Delete database and start fresh (RESET)
.\update-database.ps1 -Action Reset
```

## Method 2: Using Package Manager Console (Visual Studio)

1. In Visual Studio, open **Tools > NuGet Package Manager > Package Manager Console**
2. The console will open at the bottom of the screen
3. Run this command to apply all pending migrations:

```powershell
Update-Database
```

Expected output:
```
Build started...
Build succeeded.
Applying migration '20250115000002_RemoveQuantityColumnsFromProducts'.
Done.
```

## Method 3: Using .NET CLI (Command Line)

1. Open PowerShell/Terminal in the GroceryInventoryTracker directory
2. Run:

```powershell
dotnet ef database update
```

## Method 4: Delete & Reinitialize (Fresh Start)

If you want to delete the existing database and start completely fresh:

### Using Package Manager Console:
```powershell
Drop-Database
Update-Database
```

### Using .NET CLI:
```powershell
dotnet ef database drop --force
dotnet ef database update
```

## What Happens During Migration

When you apply the migration:

1. **Database is updated**: Removes QuantityStored and QuantityOnSalesFloor columns from Products table
2. **Shipment table remains**: All existing shipment data is preserved
3. **Seed data is reloaded**: 8 default products are recreated without quantity columns
4. **Shipments are seeded**: 16 sample shipments are created with Location values

## Verify It Worked

After running the migration:

1. Start the application: `dotnet run`
2. Navigate to the Index page
3. Check that products display with calculated quantities:
   - Look for "Quantity in Storage" 
   - Look for "Quantity on Sales Floor"
4. These values should match the sum of shipments for that product

### Example:
```
Product: Apples
├─ Shipment 1: 25 units (InStorage)
├─ Shipment 2: 60 units (OnFloor)
├─ Shipment 3: 65 units (InStorage)
└─ Total InStorage: 90
   Total OnFloor: 60
```

## If Something Goes Wrong

### Error: "Unsupported use of multiple DbContext instances"
- Close and reopen Visual Studio
- Rebuild the solution: `Build > Rebuild Solution`
- Try the migration again

### Error: "Cannot drop database - it's in use"
- Close the application if running
- Close all Visual Studio instances
- Try the drop command again

### Error: "Migration pending"
- Run `Update-Database` again to apply all pending migrations
- Check that all migration files exist in the Migrations folder

## Rollback Instructions

If you need to undo the migration and go back to stored quantity columns:

```powershell
# Revert to the previous migration
Update-Database -TargetMigration AddLocationToShipments
```

This will:
- Add QuantityStored column back
- Add QuantityOnSalesFloor column back
- Re-apply seed data with quantity values

## Files Created/Modified

### New Files:
- `Migrations/20250115000002_RemoveQuantityColumnsFromProducts.cs` - The migration
- `MIGRATION_GUIDE.md` - Detailed documentation
- `update-database.ps1` - Helper PowerShell script
- `QUICK_START.md` - This file

### Modified Files:
- `Models/Product.cs` - Calculated properties
- `Data/InventoryDbContext.cs` - Updated seed data
- `Migrations/InventoryDbContextModelSnapshot.cs` - Updated schema snapshot

## Next Steps

After successfully applying the migration:

1. ✅ Run the application
2. ✅ Test the Index page displays quantities
3. ✅ Test Add Shipment functionality
4. ✅ Verify shipment locations (InStorage/OnFloor)
5. ✅ Commit changes to Git

## Need More Help?

See `MIGRATION_GUIDE.md` for detailed architecture notes and performance considerations.
