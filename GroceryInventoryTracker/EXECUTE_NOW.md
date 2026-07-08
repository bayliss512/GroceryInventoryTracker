# 🚀 EXECUTE NOW - Complete Migration Instructions

## TL;DR - Copy & Paste Ready

Choose **ONE** of these options and run it now:

---

## Option 1: PowerShell Script (Recommended - Handles Everything)

```powershell
# Navigate to project root, then run:
.\update-database.ps1 -Action Reset
```

**What it does:**
- ✅ Deletes old database
- ✅ Applies all migrations
- ✅ Reseeds data
- ✅ Shows progress

**Time: ~5 seconds**

---

## Option 2: Package Manager Console (Visual Studio)

```powershell
# Steps:
# 1. In Visual Studio: Tools > NuGet Package Manager > Package Manager Console
# 2. Paste and run:

Update-Database
```

**What it does:**
- ✅ Applies pending migrations
- ✅ Keeps existing database if schema compatible

**Time: ~3 seconds**

---

## Option 3: .NET CLI (Command Line)

```powershell
# Open PowerShell in project directory and run:
dotnet ef database update
```

**What it does:**
- ✅ Same as Package Manager Console
- ✅ Works from any terminal

**Time: ~3 seconds**

---

## Option 4: Complete Fresh Start (CLI)

```powershell
# If database is corrupted or you want completely fresh:
dotnet ef database drop --force
dotnet ef database update
```

---

## AFTER Running Migration

### Step 1: Start the Application
```powershell
dotnet run
```

### Step 2: Open Browser
```
https://localhost:7120  # or whatever port appears in console
```

### Step 3: Verify Quantities Display
Look for:
- ✅ "Quantity in Storage" - shows calculated value
- ✅ "Quantity on Sales Floor" - shows calculated value
- ✅ Values match sum of shipments

### Step 4: Test Add Shipment
1. Click any product
2. Click "Add Shipment"
3. Fill in details
4. Choose Location (InStorage or OnFloor)
5. Click Save
6. Go back to products
7. Verify quantity updated ✓

---

## Expected Console Output

```
Build started...
Build succeeded.
Applying migration '20250115000002_RemoveQuantityColumnsFromProducts'.
Done.
```

---

## Troubleshooting

### ❌ "This project is not ready for migration"
- Rebuild solution: `Ctrl+Shift+B`
- Try again

### ❌ "Database is locked"
- Close Visual Studio completely
- Wait 3 seconds
- Reopen and try again

### ❌ "Migration already applied"
- Perfect! Your database is up to date
- Just run the app: `dotnet run`

### ❌ "QuantityStored/QuantityOnSalesFloor still showing zero"
- Make sure migration was applied (check steps above)
- Restart application: `Ctrl+C` then `dotnet run`
- Verify shipments exist in database

---

## Files You'll Need to Know About

| File | Purpose |
|------|---------|
| `Migrations/20250115000002_RemoveQuantityColumnsFromProducts.cs` | The migration file |
| `Models/Product.cs` | Has calculated properties |
| `Data/InventoryDbContext.cs` | Seeds shipments with locations |
| `QUICK_START.md` | Detailed help |
| `MIGRATION_GUIDE.md` | Technical details |

---

## What Gets Deleted/Changed

### ❌ Removed from Database
- QuantityStored column
- QuantityOnSalesFloor column

### ✅ Preserved
- All shipment data
- All category data
- All product names/images
- All relationships

### ✨ New
- Products get calculated quantities from shipments
- Better data integrity
- Single source of truth

---

## Next Commands to Run

After migration succeeds:

```powershell
# Start the app
dotnet run

# Run tests (if you have them)
dotnet test

# Commit to git
git add .
git commit -m "refactor: convert quantity fields to calculated properties"
```

---

## 🎯 You're Ready!

Pick one option above, run it, and you're done. The database will be updated and ready to use.

**Recommended:** Use Option 1 (PowerShell script) for the smoothest experience.

Any issues? Check `QUICK_START.md` for detailed troubleshooting.
