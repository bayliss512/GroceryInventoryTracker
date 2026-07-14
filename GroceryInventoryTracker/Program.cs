using GroceryInventoryTracker.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Configure Entity Framework DbContext
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
    "Server=(localdb)\\mssqllocaldb;Database=GroceryInventoryTracker;Trusted_Connection=True;";

builder.Services.AddDbContext<GroceryInventoryTracker.Data.InventoryDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<GroceryInventoryTracker.Services.ProductService>();
builder.Services.AddScoped<GroceryInventoryTracker.Services.UserService>();
builder.Services.AddScoped<GroceryInventoryTracker.Services.CategoryService>();
builder.Services.AddScoped<GroceryInventoryTracker.Services.SupplierService>();
builder.Services.AddScoped<GroceryInventoryTracker.Services.ShipmentService>();
builder.Services.AddScoped<GroceryInventoryTracker.Services.DashboardService>();

builder.Services.AddAuthentication(Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Account";
        options.AccessDeniedPath = "/Account/AccessDenied";
        options.ExpireTimeSpan = TimeSpan.FromDays(7);
    });

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Admin", policy => policy.RequireClaim("IsAdmin", "true"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Initialize database (apply migrations if available)
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<InventoryDbContext>();
    var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
    try
    {
        // First, ensure the database and tables are created
        var dbCreated = db.Database.EnsureCreated();
        if (dbCreated)
        {
            logger.LogInformation("Database created with schema and seed data.");
        }

        // Then try to apply migrations for tracking
        try
        {
            db.Database.Migrate();
            logger.LogInformation("Migrations applied successfully.");
        }
        catch (Exception migrateEx)
        {
            logger.LogWarning(migrateEx, "Migration tracking failed but database was created with EnsureCreated.");
        }

        // Upgrade the Users table on databases created before it (or before its latest columns) existed
        db.EnsureUsersSchemaAsync().GetAwaiter().GetResult();
    }
    catch (Exception ex)
    {
        logger.LogWarning(ex, "Failed to initialize database during startup. Application will continue but database features may not work until properly initialized.");
    }
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
