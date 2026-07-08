using GroceryInventoryTracker.Data;
using GroceryInventoryTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GroceryInventoryTracker.Pages
{
    public class ConfigurationModel : PageModel
    {
        private readonly InventoryDbContext _db;
        private readonly ILogger<ConfigurationModel> _logger;

        public ConfigurationModel(InventoryDbContext db, ILogger<ConfigurationModel> logger)
        {
            _db = db;
            _logger = logger;
        }

        public string? SuccessMessage { get; set; }
        public string? ErrorMessage { get; set; }

        public async Task OnGetAsync()
        {
            // Page loads with current state
            await Task.CompletedTask;
        }

        public async Task<IActionResult> OnPostInitializeDatabaseAsync()
        {
            try
            {
                _logger.LogInformation("Attempting to initialize database...");

                // First, ensure database exists
                var dbCreated = await _db.Database.EnsureCreatedAsync();
                if (dbCreated)
                {
                    _logger.LogInformation("Database created with EnsureCreated.");
                }
                else
                {
                    _logger.LogInformation("Database already exists.");
                }

                // Now apply migrations for tracking and any additional setup
                try
                {
                    await _db.Database.MigrateAsync();
                    _logger.LogInformation("Migrations applied successfully.");
                }
                catch (Exception migrateEx)
                {
                    _logger.LogWarning(migrateEx, "Migration tracking failed but tables may have been created by EnsureCreated.");
                }

                // Verify tables were created by checking if we can query them
                var productCount = await _db.Products.CountAsync();
                var categoryCount = await _db.Categories.CountAsync();
                var shipmentCount = await _db.Shipments.CountAsync();

                SuccessMessage = $"Database initialized successfully! " +
                    $"Categories: {categoryCount}, Products: {productCount}, Shipments: {shipmentCount}";
                _logger.LogInformation($"Database verification - Categories: {categoryCount}, Products: {productCount}, Shipments: {shipmentCount}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to initialize database");
                ErrorMessage = $"Failed to initialize database: {ex.Message}";
            }

            return Page();
        }

        public async Task<IActionResult> OnPostDeleteDatabaseAsync()
        {
            try
            {
                _logger.LogInformation("Attempting to delete database...");

                // Delete the database
                await _db.Database.EnsureDeletedAsync();

                SuccessMessage = "Database deleted successfully. You can reinitialize it using the 'Initialize Database' button.";
                _logger.LogInformation("Database deleted successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to delete database");
                ErrorMessage = $"Failed to delete database: {ex.Message}";
            }

            return Page();
        }

        public async Task<IActionResult> OnPostGenerateRandomShipmentAsync()
        {
            try
            {
                _logger.LogInformation("Attempting to generate random shipment...");

                // Get all products
                var products = await _db.Products.ToListAsync();

                if (products.Count == 0)
                {
                    ErrorMessage = "No products available. Initialize the database first to add products.";
                    return Page();
                }

                // Select a random product
                var random = new Random();
                var randomProduct = products[random.Next(products.Count)];

                // Generate a random quantity divisible by 2 or 5, up to 50
                var quantity = GenerateRandomQuantity(random);

                // Generate a random future expiration date (1 to 365 days from now)
                var expirationDate = DateTime.Now.AddDays(random.Next(1, 366));

                // Create a unique shipment number
                var shipmentNumber = $"SHP-{DateTime.Now:yyyyMMddHHmmss}-{random.Next(1000, 9999)}";

                var shipment = new Shipment
                {
                    ProductId = randomProduct.Id,
                    ShipmentNumber = shipmentNumber,
                    ExpirationDate = expirationDate,
                    Quantity = quantity
                };

                _db.Shipments.Add(shipment);
                await _db.SaveChangesAsync();

                SuccessMessage = $"Random shipment created! Product: {randomProduct.Name}, Quantity: {quantity}, Expires: {expirationDate:MMM dd, yyyy}";
                _logger.LogInformation($"Random shipment generated for product {randomProduct.Name} with quantity {quantity}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to generate random shipment");
                ErrorMessage = $"Failed to generate random shipment: {ex.Message}";
            }

            return Page();
        }

        public async Task<IActionResult> OnPostGenerateConfigurableShipmentAsync()
        {
            // TODO - Show pop-up menu that allows user to select product, quantity, and expiration date. Then create shipment based on user input.
            // If a field is left blank, grey out the option to enter the product. 
            // If the shipment number is left blank, generate a unique shipment number automatically.



            return Page();
        }

        private int GenerateRandomQuantity(Random random)
        {
            // Generate quantities divisible by 2 or 5
            // Valid options: 2, 4, 5, 6, 8, 10, 12, 14, 15, 16, 18, 20, 22, 24, 25, 26, 28, 30, 32, 34, 35, 36, 38, 40, 42, 44, 45, 46, 48, 50
            var divisors = new List<int>();

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0 || i % 5 == 0)
                {
                    divisors.Add(i);
                }
            }

            return divisors[random.Next(divisors.Count)];
        }
    }
}
