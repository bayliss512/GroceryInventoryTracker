This folder is reserved for Entity Framework Core migrations.

To create and apply migrations locally, run the following from the solution directory in your development environment (PowerShell):

dotnet tool install --global dotnet-ef
dotnet ef migrations add InitialCreate -p GroceryInventoryTracker -s GroceryInventoryTracker
dotnet ef database update -p GroceryInventoryTracker -s GroceryInventoryTracker

If you prefer a local tool manifest instead of a global install, run:

dotnet new tool-manifest
dotnet tool install dotnet-ef

After migrations are applied the database will be created and seeded with initial data.
