# Migration Setup for GroceryInventoryTracker

## What Was Fixed
The database schema was out of sync with the Entity Framework Core models. The Product entity defines `CategoryId` and `ImagePath` columns, but the database table didn't have these columns.

## Migration Files Created
1. **20240101000000_InitialCreate.cs** - The initial migration that creates all tables with the correct schema
2. **InventoryDbContextModelSnapshot.cs** - The model snapshot that tracks the current state of the database schema

## How to Apply the Migration

### Option 1: Automatic (via Program.cs - Recommended)
The `Program.cs` is already configured to apply migrations automatically on application startup:
```csharp
db.Database.Migrate();
```

**Steps:**
1. Delete the existing `GroceryInventoryTracker` database from SQL Server (or LocalDB)
2. Run the application
3. The migration will be applied automatically and seed data will be inserted

### Option 2: Manual (via Package Manager Console)
1. Open Package Manager Console in Visual Studio
2. Ensure the Default Project is set to `GroceryInventoryTracker`
3. Run: `Update-Database`

### Option 3: Command Line
1. Open terminal/command prompt at the solution root
2. Run: `dotnet ef database update`

## Expected Result
After applying the migration:
- **Categories** table will be created with 5 seed categories
- **Products** table will be created with `CategoryId` and `ImagePath` columns, plus 8 seed products
- **Shipments** table will be created with 16 seed shipments
- Foreign key relationships will be established

## If You Get an Error
If the migration fails because the database doesn't exist, Entity Framework will automatically create it.
If you want a clean slate, you can delete the database and let the application recreate it.
