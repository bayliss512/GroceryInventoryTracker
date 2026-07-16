using System;
using GroceryInventoryTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace GroceryInventoryTracker.Data
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Shipment> Shipments { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Supplier> Suppliers { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<AuditLog> AuditLogs { get; set; } = null!;

        /// <summary>
        /// Creates or upgrades the Users table on databases that predate it.
        /// EnsureCreated only builds schema for brand-new databases, so
        /// later additions have to be applied here.
        /// </summary>
        public async Task EnsureUsersSchemaAsync()
        {
            await Database.ExecuteSqlRawAsync(@"
IF OBJECT_ID(N'[Users]') IS NULL
BEGIN
    CREATE TABLE [Users] (
        [Id] int NOT NULL IDENTITY,
        [Username] nvarchar(64) NOT NULL,
        [PasswordHash] nvarchar(max) NOT NULL,
        [IconSvg] nvarchar(max) NOT NULL,
        [ProfileImagePath] nvarchar(max) NULL,
        [CreatedAt] datetime2 NOT NULL,
        [IsAdmin] bit NOT NULL DEFAULT 0,
        CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
    );
    CREATE UNIQUE INDEX [IX_Users_Username] ON [Users] ([Username]);
END;
IF COL_LENGTH(N'[Users]', 'ProfileImagePath') IS NULL
    ALTER TABLE [Users] ADD [ProfileImagePath] nvarchar(max) NULL;
IF COL_LENGTH(N'[Users]', 'IsAdmin') IS NULL
    ALTER TABLE [Users] ADD [IsAdmin] bit NOT NULL DEFAULT 0;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(b =>
            {
                b.HasKey(p => p.Id);
                b.Property(p => p.Name).IsRequired();
                b.Property(p => p.LowStockThreshold).IsRequired().HasDefaultValue(Product.DefaultLowStockThreshold);
                b.HasOne(p => p.Category)
                    .WithMany(c => c.Products)
                    .HasForeignKey(p => p.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Shipment>(b =>
            {
                b.HasKey(s => s.Id);
                b.Property(s => s.ShipmentNumber).IsRequired();
                b.HasOne(s => s.Product)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(s => s.ProductId)
                    .OnDelete(DeleteBehavior.Cascade);
                b.HasOne(s => s.Supplier)
                    .WithMany(sup => sup.Shipments)
                    .HasForeignKey(s => s.SupplierId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Supplier>(b =>
            {
                b.HasKey(s => s.Id);
                b.Property(s => s.Name).IsRequired().HasMaxLength(200);
            });

            modelBuilder.Entity<User>(b =>
            {
                b.HasKey(u => u.Id);
                b.Property(u => u.Username).IsRequired().HasMaxLength(64);
                b.Property(u => u.PasswordHash).IsRequired();
                b.Property(u => u.IconSvg).IsRequired();
                b.Property(u => u.IsAdmin).IsRequired().HasDefaultValue(false);
                b.HasIndex(u => u.Username).IsUnique();
            });

            modelBuilder.Entity<AuditLog>(b =>
            {
                b.HasKey(a => a.Id);
                b.Property(a => a.Username).IsRequired().HasMaxLength(64);
                b.Property(a => a.Action).IsRequired().HasMaxLength(100);
                b.Property(a => a.Details).IsRequired();
                b.HasIndex(a => a.Timestamp);
            });

            // Seed categories
            var categories = new List<Category>
            {
                new Category { Id = 1, Name = "Produce" },
                new Category { Id = 2, Name = "Meat & Seafood" },
                new Category { Id = 3, Name = "Dairy & Refrigerated" },
                new Category { Id = 4, Name = "Bakery" },
                new Category { Id = 5, Name = "Frozen Foods" },
                new Category { Id = 6, Name = "Pantry Staples" },
                new Category { Id = 7, Name = "Canned Goods" },
                new Category { Id = 8, Name = "Breakfast Foods" },
                new Category { Id = 9, Name = "Snacks" },
                new Category { Id = 10, Name = "Beverages" },
                new Category { Id = 11, Name = "Condiments & Sauces" },
                new Category { Id = 12, Name = "Herbs, Spices & Seasonings" },
                new Category { Id = 13, Name = "International Foods" },
                new Category { Id = 14, Name = "Health & Specialty Foods" },
                new Category { Id = 15, Name = "Baby Products" },
                new Category { Id = 16, Name = "Household Supplies" },
                new Category { Id = 17, Name = "Cleaning Supplies" },
                new Category { Id = 18, Name = "Personal Care" },
                new Category { Id = 19, Name = "Pharmacy & Wellness" },
                new Category { Id = 20, Name = "Pet Supplies" },
                new Category { Id = 21, Name = "Seasonal & Miscellaneous" }
            };

            modelBuilder.Entity<Category>().HasData(categories);

            // Seed products
            var products = new List<Product>
            {
                // Produce (1-21)
                new Product { Id = 1, Name = "Apples", CategoryId = 1, ImagePath = "/Images/ProductImages/Apples.png" },
                new Product { Id = 2, Name = "Bananas", CategoryId = 1, ImagePath = "/Images/ProductImages/Bananas.png" },
                new Product { Id = 3, Name = "Oranges", CategoryId = 1, ImagePath = "/Images/ProductImages/Oranges.png" },
                new Product { Id = 4, Name = "Grapes", CategoryId = 1, ImagePath = "/Images/ProductImages/Grapes.png" },
                new Product { Id = 5, Name = "Strawberries", CategoryId = 1, ImagePath = "/Images/ProductImages/Strawberries.png" },
                new Product { Id = 6, Name = "Blueberries", CategoryId = 1, ImagePath = "/Images/ProductImages/Blueberries.png" },
                new Product { Id = 7, Name = "Lemons", CategoryId = 1, ImagePath = "/Images/ProductImages/Lemons.png" },
                new Product { Id = 8, Name = "Limes", CategoryId = 1, ImagePath = "/Images/ProductImages/Limes.png" },
                new Product { Id = 9, Name = "Avocados", CategoryId = 1, ImagePath = "/Images/ProductImages/Avocados.png" },
                new Product { Id = 10, Name = "Tomatoes", CategoryId = 1, ImagePath = "/Images/ProductImages/Tomatoes.png" },
                new Product { Id = 11, Name = "Potatoes", CategoryId = 1, ImagePath = "/Images/ProductImages/Potatoes.png" },
                new Product { Id = 12, Name = "Sweet potatoes", CategoryId = 1, ImagePath = "/Images/ProductImages/Sweet potatoes.png" },
                new Product { Id = 13, Name = "Onions", CategoryId = 1, ImagePath = "/Images/ProductImages/Onions.png" },
                new Product { Id = 14, Name = "Garlic", CategoryId = 1, ImagePath = "/Images/ProductImages/Garlic.png" },
                new Product { Id = 15, Name = "Carrots", CategoryId = 1, ImagePath = "/Images/ProductImages/Carrots.png" },
                new Product { Id = 16, Name = "Celery", CategoryId = 1, ImagePath = "/Images/ProductImages/Celery.png" },
                new Product { Id = 17, Name = "Bell peppers", CategoryId = 1, ImagePath = "/Images/ProductImages/Bell peppers.png" },
                new Product { Id = 18, Name = "Cucumbers", CategoryId = 1, ImagePath = "/Images/ProductImages/Cucumbers.png" },
                new Product { Id = 19, Name = "Broccoli", CategoryId = 1, ImagePath = "/Images/ProductImages/Broccoli.png" },
                new Product { Id = 20, Name = "Cauliflower", CategoryId = 1, ImagePath = "/Images/ProductImages/Cauliflower.png" },
                new Product { Id = 21, Name = "Lettuce", CategoryId = 1, ImagePath = "/Images/ProductImages/Lettuce.png" },
                new Product { Id = 22, Name = "Spinach", CategoryId = 1, ImagePath = "/Images/ProductImages/Spinach.png" },
                new Product { Id = 23, Name = "Kale", CategoryId = 1, ImagePath = "/Images/ProductImages/Kale.png" },
                new Product { Id = 24, Name = "Cabbage", CategoryId = 1, ImagePath = "/Images/ProductImages/Cabbage.png" },
                new Product { Id = 25, Name = "Mushrooms", CategoryId = 1, ImagePath = "/Images/ProductImages/Mushrooms.png" },
                new Product { Id = 26, Name = "Zucchini", CategoryId = 1, ImagePath = "/Images/ProductImages/Zucchini.png" },

                // Meat & Seafood (27-44)
                new Product { Id = 27, Name = "Ground beef", CategoryId = 2, ImagePath = "/Images/ProductImages/Ground beef.png" },
                new Product { Id = 28, Name = "Beef steaks", CategoryId = 2, ImagePath = "/Images/ProductImages/Beef steaks.png" },
                new Product { Id = 29, Name = "Pork chops", CategoryId = 2, ImagePath = "/Images/ProductImages/Pork chops.png" },
                new Product { Id = 30, Name = "Pork shoulder", CategoryId = 2, ImagePath = "/Images/ProductImages/Pork shoulder.png" },
                new Product { Id = 31, Name = "Bacon", CategoryId = 2, ImagePath = "/Images/ProductImages/Bacon.png" },
                new Product { Id = 32, Name = "Sausage", CategoryId = 2, ImagePath = "/Images/ProductImages/Sausage.png" },
                new Product { Id = 33, Name = "Chicken breasts", CategoryId = 2, ImagePath = "/Images/ProductImages/Chicken breasts.png" },
                new Product { Id = 34, Name = "Chicken thighs", CategoryId = 2, ImagePath = "/Images/ProductImages/Chicken thighs.png" },
                new Product { Id = 35, Name = "Whole chicken", CategoryId = 2, ImagePath = "/Images/ProductImages/Whole chicken.png" },
                new Product { Id = 36, Name = "Turkey breast", CategoryId = 2, ImagePath = "/Images/ProductImages/Turkey breast.png" },
                new Product { Id = 37, Name = "Deli turkey", CategoryId = 2, ImagePath = "/Images/ProductImages/Deli turkey.png" },
                new Product { Id = 38, Name = "Salmon fillets", CategoryId = 2, ImagePath = "/Images/ProductImages/Salmon fillets.png" },
                new Product { Id = 39, Name = "Tilapia fillets", CategoryId = 2, ImagePath = "/Images/ProductImages/Tilapia fillets.png" },
                new Product { Id = 40, Name = "Shrimp", CategoryId = 2, ImagePath = "/Images/ProductImages/Shrimp.png" },
                new Product { Id = 41, Name = "Cod fillets", CategoryId = 2, ImagePath = "/Images/ProductImages/Cod fillets.png" },
                new Product { Id = 42, Name = "Crab meat", CategoryId = 2, ImagePath = "/Images/ProductImages/Crab meat.png" },
                new Product { Id = 43, Name = "Canned tuna", CategoryId = 2, ImagePath = "/Images/ProductImages/Canned tuna.png" },
                new Product { Id = 44, Name = "Canned salmon", CategoryId = 2, ImagePath = "/Images/ProductImages/Canned salmon.png" },

                // Dairy & Refrigerated (45-60)
                new Product { Id = 45, Name = "Milk", CategoryId = 3, ImagePath = "/Images/ProductImages/Milk.png" },
                new Product { Id = 46, Name = "Chocolate milk", CategoryId = 3, ImagePath = "/Images/ProductImages/Chocolate milk.png" },
                new Product { Id = 47, Name = "Butter", CategoryId = 3, ImagePath = "/Images/ProductImages/Butter.png" },
                new Product { Id = 48, Name = "Heavy cream", CategoryId = 3, ImagePath = "/Images/ProductImages/Heavy cream.png" },
                new Product { Id = 49, Name = "Sour cream", CategoryId = 3, ImagePath = "/Images/ProductImages/Sour cream.png" },
                new Product { Id = 50, Name = "Cottage cheese", CategoryId = 3, ImagePath = "/Images/ProductImages/Cottage cheese.png" },
                new Product { Id = 51, Name = "Cream cheese", CategoryId = 3, ImagePath = "/Images/ProductImages/Cream cheese.png" },
                new Product { Id = 52, Name = "Yogurt", CategoryId = 3, ImagePath = "/Images/ProductImages/Yogurt.png" },
                new Product { Id = 53, Name = "Greek yogurt", CategoryId = 3, ImagePath = "/Images/ProductImages/Greek yogurt.png" },
                new Product { Id = 54, Name = "Shredded cheddar cheese", CategoryId = 3, ImagePath = "/Images/ProductImages/Shredded cheddar cheese.png" },
                new Product { Id = 55, Name = "Mozzarella cheese", CategoryId = 3, ImagePath = "/Images/ProductImages/Mozzarella cheese.png" },
                new Product { Id = 56, Name = "Swiss cheese", CategoryId = 3, ImagePath = "/Images/ProductImages/Swiss cheese.png" },
                new Product { Id = 57, Name = "American cheese", CategoryId = 3, ImagePath = "/Images/ProductImages/American cheese.png" },
                new Product { Id = 58, Name = "Eggs", CategoryId = 3, ImagePath = "/Images/ProductImages/Eggs.png" },
                new Product { Id = 59, Name = "Egg whites", CategoryId = 3, ImagePath = "/Images/ProductImages/Egg whites.png" },
                new Product { Id = 60, Name = "Refrigerated biscuits", CategoryId = 3, ImagePath = "/Images/ProductImages/Refrigerated biscuits.png" },
                new Product { Id = 61, Name = "Refrigerated cookie dough", CategoryId = 3, ImagePath = "/Images/ProductImages/Refrigerated cookie dough.png" },

                // Bakery (62-75)
                new Product { Id = 62, Name = "White bread", CategoryId = 4, ImagePath = "/Images/ProductImages/White bread.png" },
                new Product { Id = 63, Name = "Whole wheat bread", CategoryId = 4, ImagePath = "/Images/ProductImages/Whole wheat bread.png" },
                new Product { Id = 64, Name = "Hamburger buns", CategoryId = 4, ImagePath = "/Images/ProductImages/Hamburger buns.png" },
                new Product { Id = 65, Name = "Hot dog buns", CategoryId = 4, ImagePath = "/Images/ProductImages/Hot dog buns.png" },
                new Product { Id = 66, Name = "Bagels", CategoryId = 4, ImagePath = "/Images/ProductImages/Bagels.png" },
                new Product { Id = 67, Name = "English muffins", CategoryId = 4, ImagePath = "/Images/ProductImages/English muffins.png" },
                new Product { Id = 68, Name = "Tortillas", CategoryId = 4, ImagePath = "/Images/ProductImages/Tortillas.png" },
                new Product { Id = 69, Name = "Croissants", CategoryId = 4, ImagePath = "/Images/ProductImages/Croissants.png" },
                new Product { Id = 70, Name = "Donuts", CategoryId = 4, ImagePath = "/Images/ProductImages/Donuts.png" },
                new Product { Id = 71, Name = "Muffins", CategoryId = 4, ImagePath = "/Images/ProductImages/Muffins.png" },
                new Product { Id = 72, Name = "Dinner rolls", CategoryId = 4, ImagePath = "/Images/ProductImages/Dinner rolls.png" },
                new Product { Id = 73, Name = "Pita bread", CategoryId = 4, ImagePath = "/Images/ProductImages/Pita bread.png" },
                new Product { Id = 74, Name = "Artisan loaves", CategoryId = 4, ImagePath = "/Images/ProductImages/Artisan loaves.png" },
                new Product { Id = 75, Name = "Cakes", CategoryId = 4, ImagePath = "/Images/ProductImages/Cakes.png" },
                new Product { Id = 76, Name = "Cupcakes", CategoryId = 4, ImagePath = "/Images/ProductImages/Cupcakes.png" },

                // Frozen Foods (77-90)
                new Product { Id = 77, Name = "Frozen pizza", CategoryId = 5, ImagePath = "/Images/ProductImages/Frozen pizza.png" },
                new Product { Id = 78, Name = "Frozen vegetables", CategoryId = 5, ImagePath = "/Images/ProductImages/Frozen vegetables.png" },
                new Product { Id = 79, Name = "Frozen berries", CategoryId = 5, ImagePath = "/Images/ProductImages/Frozen berries.png" },
                new Product { Id = 80, Name = "Ice cream", CategoryId = 5, ImagePath = "/Images/ProductImages/Ice cream.png" },
                new Product { Id = 81, Name = "Frozen dinners", CategoryId = 5, ImagePath = "/Images/ProductImages/Frozen dinners.png" },
                new Product { Id = 82, Name = "Chicken nuggets", CategoryId = 5, ImagePath = "/Images/ProductImages/Chicken nuggets.png" },
                new Product { Id = 83, Name = "French fries", CategoryId = 5, ImagePath = "/Images/ProductImages/French fries.png" },
                new Product { Id = 84, Name = "Frozen waffles", CategoryId = 5, ImagePath = "/Images/ProductImages/Frozen waffles.png" },
                new Product { Id = 85, Name = "Frozen pancakes", CategoryId = 5, ImagePath = "/Images/ProductImages/Frozen pancakes.png" },
                new Product { Id = 86, Name = "Frozen fish fillets", CategoryId = 5, ImagePath = "/Images/ProductImages/Frozen fish fillets.png" },
                new Product { Id = 87, Name = "Frozen shrimp", CategoryId = 5, ImagePath = "/Images/ProductImages/Frozen shrimp.png" },
                new Product { Id = 88, Name = "Frozen meatballs", CategoryId = 5, ImagePath = "/Images/ProductImages/Frozen meatballs.png" },
                new Product { Id = 89, Name = "Frozen fruit", CategoryId = 5, ImagePath = "/Images/ProductImages/Frozen fruit.png" },
                new Product { Id = 90, Name = "Frozen garlic bread", CategoryId = 5, ImagePath = "/Images/ProductImages/Frozen garlic bread.png" },

                // Pantry Staples (91-108)
                new Product { Id = 91, Name = "White rice", CategoryId = 6, ImagePath = "/Images/ProductImages/White rice.png" },
                new Product { Id = 92, Name = "Brown rice", CategoryId = 6, ImagePath = "/Images/ProductImages/Brown rice.png" },
                new Product { Id = 93, Name = "Pasta", CategoryId = 6, ImagePath = "/Images/ProductImages/Pasta.png" },
                new Product { Id = 94, Name = "Macaroni and cheese", CategoryId = 6, ImagePath = "/Images/ProductImages/Macaroni and cheese.png" },
                new Product { Id = 95, Name = "Flour", CategoryId = 6, ImagePath = "/Images/ProductImages/Flour.png" },
                new Product { Id = 96, Name = "Sugar", CategoryId = 6, ImagePath = "/Images/ProductImages/Sugar.png" },
                new Product { Id = 97, Name = "Brown sugar", CategoryId = 6, ImagePath = "/Images/ProductImages/Brown sugar.png" },
                new Product { Id = 98, Name = "Cornmeal", CategoryId = 6, ImagePath = "/Images/ProductImages/Cornmeal.png" },
                new Product { Id = 99, Name = "Oats", CategoryId = 6, ImagePath = "/Images/ProductImages/Oats.png" },
                new Product { Id = 100, Name = "Breadcrumbs", CategoryId = 6, ImagePath = "/Images/ProductImages/Breadcrumbs.png" },
                new Product { Id = 101, Name = "Pancake mix", CategoryId = 6, ImagePath = "/Images/ProductImages/Pancake mix.png" },
                new Product { Id = 102, Name = "Cake mix", CategoryId = 6, ImagePath = "/Images/ProductImages/Cake mix.png" },
                new Product { Id = 103, Name = "Baking soda", CategoryId = 6, ImagePath = "/Images/ProductImages/Baking soda.png" },
                new Product { Id = 104, Name = "Baking powder", CategoryId = 6, ImagePath = "/Images/ProductImages/Baking powder.png" },
                new Product { Id = 105, Name = "Cornstarch", CategoryId = 6, ImagePath = "/Images/ProductImages/Cornstarch.png" },
                new Product { Id = 106, Name = "Honey", CategoryId = 6, ImagePath = "/Images/ProductImages/Honey.png" },
                new Product { Id = 107, Name = "Maple syrup", CategoryId = 6, ImagePath = "/Images/ProductImages/Maple syrup.png" },

                // Canned Goods (108-130)
                new Product { Id = 108, Name = "Pinto beans", CategoryId = 7, ImagePath = "/Images/ProductImages/Pinto beans.png" },
                new Product { Id = 109, Name = "Black beans", CategoryId = 7, ImagePath = "/Images/ProductImages/Black beans.png" },
                new Product { Id = 110, Name = "Kidney beans", CategoryId = 7, ImagePath = "/Images/ProductImages/Kidney beans.png" },
                new Product { Id = 111, Name = "Chickpeas", CategoryId = 7, ImagePath = "/Images/ProductImages/Chickpeas.png" },
                new Product { Id = 112, Name = "Canned corn", CategoryId = 7, ImagePath = "/Images/ProductImages/Canned corn.png" },
                new Product { Id = 113, Name = "Green beans", CategoryId = 7, ImagePath = "/Images/ProductImages/Green beans.png" },
                new Product { Id = 114, Name = "Peas", CategoryId = 7, ImagePath = "/Images/ProductImages/Peas.png" },
                new Product { Id = 115, Name = "Diced tomatoes", CategoryId = 7, ImagePath = "/Images/ProductImages/Diced tomatoes.png" },
                new Product { Id = 116, Name = "Tomato sauce", CategoryId = 7, ImagePath = "/Images/ProductImages/Tomato sauce.png" },
                new Product { Id = 117, Name = "Tomato paste", CategoryId = 7, ImagePath = "/Images/ProductImages/Tomato paste.png" },
                new Product { Id = 118, Name = "Chicken noodle soup", CategoryId = 7, ImagePath = "/Images/ProductImages/Chicken noodle soup.png" },
                new Product { Id = 119, Name = "Cream of mushroom soup", CategoryId = 7, ImagePath = "/Images/ProductImages/Cream of mushroom soup.png" },
                new Product { Id = 120, Name = "Beef stew", CategoryId = 7, ImagePath = "/Images/ProductImages/Beef stew.png" },
                new Product { Id = 121, Name = "Canned fruit", CategoryId = 7, ImagePath = "/Images/ProductImages/Canned fruit.png" },
                new Product { Id = 122, Name = "Pumpkin puree", CategoryId = 7, ImagePath = "/Images/ProductImages/Pumpkin puree.png" },

                // Breakfast Foods (123-131)
                new Product { Id = 123, Name = "Cold cereal", CategoryId = 8, ImagePath = "/Images/ProductImages/Cold cereal.png" },
                new Product { Id = 124, Name = "Granola", CategoryId = 8, ImagePath = "/Images/ProductImages/Granola.png" },
                new Product { Id = 125, Name = "Instant oatmeal", CategoryId = 8, ImagePath = "/Images/ProductImages/Instant oatmeal.png" },
                new Product { Id = 126, Name = "Grits", CategoryId = 8, ImagePath = "/Images/ProductImages/Grits.png" },
                new Product { Id = 127, Name = "Breakfast bars", CategoryId = 8, ImagePath = "/Images/ProductImages/Breakfast bars.png" },
                new Product { Id = 128, Name = "Pop-tarts", CategoryId = 8, ImagePath = "/Images/ProductImages/Pop-tarts.png" },
                new Product { Id = 129, Name = "Pancake syrup", CategoryId = 8, ImagePath = "/Images/ProductImages/Pancake syrup.png" },
                new Product { Id = 130, Name = "Toaster pastries", CategoryId = 8, ImagePath = "/Images/ProductImages/Toaster pastries.png" },
                new Product { Id = 131, Name = "Breakfast sausage", CategoryId = 8, ImagePath = "/Images/ProductImages/Breakfast sausage.png" },
                new Product { Id = 132, Name = "Hash browns", CategoryId = 8, ImagePath = "/Images/ProductImages/Hash browns.png" },

                // Snacks (133-148)
                new Product { Id = 133, Name = "Potato chips", CategoryId = 9, ImagePath = "/Images/ProductImages/Potato chips.png" },
                new Product { Id = 134, Name = "Tortilla chips", CategoryId = 9, ImagePath = "/Images/ProductImages/Tortilla chips.png" },
                new Product { Id = 135, Name = "Pretzels", CategoryId = 9, ImagePath = "/Images/ProductImages/Pretzels.png" },
                new Product { Id = 136, Name = "Popcorn", CategoryId = 9, ImagePath = "/Images/ProductImages/Popcorn.png" },
                new Product { Id = 137, Name = "Crackers", CategoryId = 9, ImagePath = "/Images/ProductImages/Crackers.png" },
                new Product { Id = 138, Name = "Trail mix", CategoryId = 9, ImagePath = "/Images/ProductImages/Trail mix.png" },
                new Product { Id = 139, Name = "Mixed nuts", CategoryId = 9, ImagePath = "/Images/ProductImages/Mixed nuts.png" },
                new Product { Id = 140, Name = "Peanuts", CategoryId = 9, ImagePath = "/Images/ProductImages/Peanuts.png" },
                new Product { Id = 141, Name = "Granola bars", CategoryId = 9, ImagePath = "/Images/ProductImages/Granola bars.png" },
                new Product { Id = 142, Name = "Rice cakes", CategoryId = 9, ImagePath = "/Images/ProductImages/Rice cakes.png" },
                new Product { Id = 143, Name = "Beef jerky", CategoryId = 9, ImagePath = "/Images/ProductImages/Beef jerky.png" },
                new Product { Id = 144, Name = "Fruit snacks", CategoryId = 9, ImagePath = "/Images/ProductImages/Fruit snacks.png" },
                new Product { Id = 145, Name = "Cookies", CategoryId = 9, ImagePath = "/Images/ProductImages/Cookies.png" },
                new Product { Id = 146, Name = "Candy bars", CategoryId = 9, ImagePath = "/Images/ProductImages/Candy bars.png" },

                // Beverages (147-161)
                new Product { Id = 147, Name = "Bottled water", CategoryId = 10, ImagePath = "/Images/ProductImages/Bottled water.png" },
                new Product { Id = 148, Name = "Sparkling water", CategoryId = 10, ImagePath = "/Images/ProductImages/Sparkling water.png" },
                new Product { Id = 149, Name = "Soda", CategoryId = 10, ImagePath = "/Images/ProductImages/Soda.png" },
                new Product { Id = 150, Name = "Diet soda", CategoryId = 10, ImagePath = "/Images/ProductImages/Diet soda.png" },
                new Product { Id = 151, Name = "Energy drinks", CategoryId = 10, ImagePath = "/Images/ProductImages/Energy drinks.png" },
                new Product { Id = 152, Name = "Sports drinks", CategoryId = 10, ImagePath = "/Images/ProductImages/Sports drinks.png" },
                new Product { Id = 153, Name = "Coffee", CategoryId = 10, ImagePath = "/Images/ProductImages/Coffee.png" },
                new Product { Id = 154, Name = "Ground coffee", CategoryId = 10, ImagePath = "/Images/ProductImages/Ground coffee.png" },
                new Product { Id = 155, Name = "Tea bags", CategoryId = 10, ImagePath = "/Images/ProductImages/Tea bags.png" },
                new Product { Id = 156, Name = "Hot chocolate mix", CategoryId = 10, ImagePath = "/Images/ProductImages/Hot chocolate mix.png" },
                new Product { Id = 157, Name = "Fruit juice", CategoryId = 10, ImagePath = "/Images/ProductImages/Fruit juice.png" },
                new Product { Id = 158, Name = "Apple juice", CategoryId = 10, ImagePath = "/Images/ProductImages/Apple juice.png" },
                new Product { Id = 159, Name = "Orange juice", CategoryId = 10, ImagePath = "/Images/ProductImages/Orange juice.png" },
                new Product { Id = 160, Name = "Coconut water", CategoryId = 10, ImagePath = "/Images/ProductImages/Coconut water.png" },

                // Condiments & Sauces (161-174)
                new Product { Id = 161, Name = "Ketchup", CategoryId = 11, ImagePath = "/Images/ProductImages/Ketchup.png" },
                new Product { Id = 162, Name = "Mustard", CategoryId = 11, ImagePath = "/Images/ProductImages/Mustard.png" },
                new Product { Id = 163, Name = "Mayonnaise", CategoryId = 11, ImagePath = "/Images/ProductImages/Mayonnaise.png" },
                new Product { Id = 164, Name = "Barbecue sauce", CategoryId = 11, ImagePath = "/Images/ProductImages/Barbecue sauce.png" },
                new Product { Id = 165, Name = "Ranch dressing", CategoryId = 11, ImagePath = "/Images/ProductImages/Ranch dressing.png" },
                new Product { Id = 166, Name = "Italian dressing", CategoryId = 11, ImagePath = "/Images/ProductImages/Italian dressing.png" },
                new Product { Id = 167, Name = "Soy sauce", CategoryId = 11, ImagePath = "/Images/ProductImages/Soy sauce.png" },
                new Product { Id = 168, Name = "Hot sauce", CategoryId = 11, ImagePath = "/Images/ProductImages/Hot sauce.png" },
                new Product { Id = 169, Name = "Salsa", CategoryId = 11, ImagePath = "/Images/ProductImages/Salsa.png" },
                new Product { Id = 170, Name = "Marinara sauce", CategoryId = 11, ImagePath = "/Images/ProductImages/Marinara sauce.png" },
                new Product { Id = 171, Name = "Alfredo sauce", CategoryId = 11, ImagePath = "/Images/ProductImages/Alfredo sauce.png" },
                new Product { Id = 172, Name = "Worcestershire sauce", CategoryId = 11, ImagePath = "/Images/ProductImages/Worcestershire sauce.png" },
                new Product { Id = 173, Name = "Relish", CategoryId = 11, ImagePath = "/Images/ProductImages/Relish.png" },
                new Product { Id = 174, Name = "Vinegar", CategoryId = 11, ImagePath = "/Images/ProductImages/Vinegar.png" },
                new Product { Id = 175, Name = "Olive oil", CategoryId = 11, ImagePath = "/Images/ProductImages/Olive oil.png" },

                // Herbs, Spices & Seasonings (176-191)
                new Product { Id = 176, Name = "Salt", CategoryId = 12, ImagePath = "/Images/ProductImages/Salt.png" },
                new Product { Id = 177, Name = "Black pepper", CategoryId = 12, ImagePath = "/Images/ProductImages/Black pepper.png" },
                new Product { Id = 178, Name = "Garlic powder", CategoryId = 12, ImagePath = "/Images/ProductImages/Garlic powder.png" },
                new Product { Id = 179, Name = "Onion powder", CategoryId = 12, ImagePath = "/Images/ProductImages/Onion powder.png" },
                new Product { Id = 180, Name = "Paprika", CategoryId = 12, ImagePath = "/Images/ProductImages/Paprika.png" },
                new Product { Id = 181, Name = "Chili powder", CategoryId = 12, ImagePath = "/Images/ProductImages/Chili powder.png" },
                new Product { Id = 182, Name = "Cumin", CategoryId = 12, ImagePath = "/Images/ProductImages/Cumin.png" },
                new Product { Id = 183, Name = "Oregano", CategoryId = 12, ImagePath = "/Images/ProductImages/Oregano.png" },
                new Product { Id = 184, Name = "Basil", CategoryId = 12, ImagePath = "/Images/ProductImages/Basil.png" },
                new Product { Id = 185, Name = "Cinnamon", CategoryId = 12, ImagePath = "/Images/ProductImages/Cinnamon.png" },
                new Product { Id = 186, Name = "Nutmeg", CategoryId = 12, ImagePath = "/Images/ProductImages/Nutmeg.png" },
                new Product { Id = 187, Name = "Italian seasoning", CategoryId = 12, ImagePath = "/Images/ProductImages/Italian seasoning.png" },
                new Product { Id = 188, Name = "Red pepper flakes", CategoryId = 12, ImagePath = "/Images/ProductImages/Red pepper flakes.png" },
                new Product { Id = 189, Name = "Taco seasoning", CategoryId = 12, ImagePath = "/Images/ProductImages/Taco seasoning.png" },

                // International Foods (190-200)
                new Product { Id = 190, Name = "Rice noodles", CategoryId = 13, ImagePath = "/Images/ProductImages/Rice noodles.png" },
                new Product { Id = 191, Name = "Curry paste", CategoryId = 13, ImagePath = "/Images/ProductImages/Curry paste.png" },
                new Product { Id = 192, Name = "Coconut milk", CategoryId = 13, ImagePath = "/Images/ProductImages/Coconut milk.png" },
                new Product { Id = 193, Name = "Ramen noodles", CategoryId = 13, ImagePath = "/Images/ProductImages/Ramen noodles.png" },
                new Product { Id = 194, Name = "Sushi rice", CategoryId = 13, ImagePath = "/Images/ProductImages/Sushi rice.png" },
                new Product { Id = 195, Name = "Teriyaki sauce", CategoryId = 13, ImagePath = "/Images/ProductImages/Teriyaki sauce.png" },
                new Product { Id = 196, Name = "Naan", CategoryId = 13, ImagePath = "/Images/ProductImages/Naan.png" },
                new Product { Id = 197, Name = "Taco shells", CategoryId = 13, ImagePath = "/Images/ProductImages/Taco shells.png" },
                new Product { Id = 198, Name = "Refried beans", CategoryId = 13, ImagePath = "/Images/ProductImages/Refried beans.png" },
                new Product { Id = 199, Name = "Enchilada sauce", CategoryId = 13, ImagePath = "/Images/ProductImages/Enchilada sauce.png" },
                new Product { Id = 200, Name = "Kimchi", CategoryId = 13, ImagePath = "/Images/ProductImages/Kimchi.png" },
                new Product { Id = 201, Name = "Miso paste", CategoryId = 13, ImagePath = "/Images/ProductImages/Miso paste.png" },
                new Product { Id = 202, Name = "Gochujang", CategoryId = 13, ImagePath = "/Images/ProductImages/Gochujang.png" },

                // Health & Specialty Foods (203-216)
                new Product { Id = 203, Name = "Protein powder", CategoryId = 14, ImagePath = "/Images/ProductImages/Protein powder.png" },
                new Product { Id = 204, Name = "Protein bars", CategoryId = 14, ImagePath = "/Images/ProductImages/Protein bars.png" },
                new Product { Id = 205, Name = "Plant-based milk", CategoryId = 14, ImagePath = "/Images/ProductImages/Plant-based milk.png" },
                new Product { Id = 206, Name = "Almond milk", CategoryId = 14, ImagePath = "/Images/ProductImages/Almond milk.png" },
                new Product { Id = 207, Name = "Oat milk", CategoryId = 14, ImagePath = "/Images/ProductImages/Oat milk.png" },
                new Product { Id = 208, Name = "Lactose-free milk", CategoryId = 14, ImagePath = "/Images/ProductImages/Lactose-free milk.png" },
                new Product { Id = 209, Name = "Gluten-free bread", CategoryId = 14, ImagePath = "/Images/ProductImages/Gluten-free bread.png" },
                new Product { Id = 210, Name = "Gluten-free pasta", CategoryId = 14, ImagePath = "/Images/ProductImages/Gluten-free pasta.png" },
                new Product { Id = 211, Name = "Organic produce", CategoryId = 14, ImagePath = "/Images/ProductImages/Organic produce.png" },
                new Product { Id = 212, Name = "Vegan cheese", CategoryId = 14, ImagePath = "/Images/ProductImages/Vegan cheese.png" },
                new Product { Id = 213, Name = "Tofu", CategoryId = 14, ImagePath = "/Images/ProductImages/Tofu.png" },
                new Product { Id = 214, Name = "Tempeh", CategoryId = 14, ImagePath = "/Images/ProductImages/Tempeh.png" },
                new Product { Id = 215, Name = "Chia seeds", CategoryId = 14, ImagePath = "/Images/ProductImages/Chia seeds.png" },
                new Product { Id = 216, Name = "Flax seeds", CategoryId = 14, ImagePath = "/Images/ProductImages/Flax seeds.png" },

                // Baby Products (217-223)
                new Product { Id = 217, Name = "Baby formula", CategoryId = 15, ImagePath = "/Images/ProductImages/Baby formula.png" },
                new Product { Id = 218, Name = "Baby food jars", CategoryId = 15, ImagePath = "/Images/ProductImages/Baby food jars.png" },
                new Product { Id = 219, Name = "Baby cereal", CategoryId = 15, ImagePath = "/Images/ProductImages/Baby cereal.png" },
                new Product { Id = 220, Name = "Diapers", CategoryId = 15, ImagePath = "/Images/ProductImages/Diapers.png" },
                new Product { Id = 221, Name = "Baby wipes", CategoryId = 15, ImagePath = "/Images/ProductImages/Baby wipes.png" },
                new Product { Id = 222, Name = "Teething biscuits", CategoryId = 15, ImagePath = "/Images/ProductImages/Teething biscuits.png" },

                // Household Supplies (223-232)
                new Product { Id = 223, Name = "Paper towels", CategoryId = 16, IsPerishable = false, ImagePath = "/Images/ProductImages/Paper towels.png" },
                new Product { Id = 224, Name = "Toilet paper", CategoryId = 16, IsPerishable = false, ImagePath = "/Images/ProductImages/Toilet paper.png" },
                new Product { Id = 225, Name = "Facial tissues", CategoryId = 16, IsPerishable = false, ImagePath = "/Images/ProductImages/Facial tissues.png" },
                new Product { Id = 226, Name = "Aluminum foil", CategoryId = 16, IsPerishable = false, ImagePath = "/Images/ProductImages/Aluminum foil.png" },
                new Product { Id = 227, Name = "Plastic wrap", CategoryId = 16, IsPerishable = false, ImagePath = "/Images/ProductImages/Plastic wrap.png" },
                new Product { Id = 228, Name = "Sandwich bags", CategoryId = 16, IsPerishable = false, ImagePath = "/Images/ProductImages/Sandwich bags.png" },
                new Product { Id = 229, Name = "Trash bags", CategoryId = 16, IsPerishable = false, ImagePath = "/Images/ProductImages/Trash bags.png" },
                new Product { Id = 230, Name = "Dish soap", CategoryId = 16, IsPerishable = false, ImagePath = "/Images/ProductImages/Dish soap.png" },
                new Product { Id = 231, Name = "Dishwasher detergent", CategoryId = 16, IsPerishable = false, ImagePath = "/Images/ProductImages/Dishwasher detergent.png" },
                new Product { Id = 232, Name = "Laundry detergent", CategoryId = 16, IsPerishable = false, ImagePath = "/Images/ProductImages/Laundry detergent.png" },
                new Product { Id = 233, Name = "Fabric softener", CategoryId = 16, IsPerishable = false, ImagePath = "/Images/ProductImages/Fabric softener.png" },
                new Product { Id = 234, Name = "Sponges", CategoryId = 16, IsPerishable = false, ImagePath = "/Images/ProductImages/Sponges.png" },
                new Product { Id = 235, Name = "Food storage containers", CategoryId = 16, IsPerishable = false, ImagePath = "/Images/ProductImages/Food storage containers.png" },

                // Cleaning Supplies (236-246)
                new Product { Id = 236, Name = "All-purpose cleaner", CategoryId = 17, IsPerishable = false, ImagePath = "/Images/ProductImages/All-purpose cleaner.png" },
                new Product { Id = 237, Name = "Glass cleaner", CategoryId = 17, IsPerishable = false, ImagePath = "/Images/ProductImages/Glass cleaner.png" },
                new Product { Id = 238, Name = "Disinfecting wipes", CategoryId = 17, IsPerishable = false, ImagePath = "/Images/ProductImages/Disinfecting wipes.png" },
                new Product { Id = 239, Name = "Bleach", CategoryId = 17, IsPerishable = false, ImagePath = "/Images/ProductImages/Bleach.png" },
                new Product { Id = 240, Name = "Toilet bowl cleaner", CategoryId = 17, IsPerishable = false, ImagePath = "/Images/ProductImages/Toilet bowl cleaner.png" },
                new Product { Id = 241, Name = "Floor cleaner", CategoryId = 17, IsPerishable = false, ImagePath = "/Images/ProductImages/Floor cleaner.png" },
                new Product { Id = 242, Name = "Scrub brushes", CategoryId = 17, IsPerishable = false, ImagePath = "/Images/ProductImages/Scrub brushes.png" },
                new Product { Id = 243, Name = "Rubber gloves", CategoryId = 17, IsPerishable = false, ImagePath = "/Images/ProductImages/Rubber gloves.png" },
                new Product { Id = 244, Name = "Air freshener", CategoryId = 17, IsPerishable = false, ImagePath = "/Images/ProductImages/Air freshener.png" },

                // Personal Care (245-259)
                new Product { Id = 245, Name = "Shampoo", CategoryId = 18, ImagePath = "/Images/ProductImages/Shampoo.png" },
                new Product { Id = 246, Name = "Conditioner", CategoryId = 18, ImagePath = "/Images/ProductImages/Conditioner.png" },
                new Product { Id = 247, Name = "Body wash", CategoryId = 18, ImagePath = "/Images/ProductImages/Body wash.png" },
                new Product { Id = 248, Name = "Bar soap", CategoryId = 18, ImagePath = "/Images/ProductImages/Bar soap.png" },
                new Product { Id = 249, Name = "Toothpaste", CategoryId = 18, ImagePath = "/Images/ProductImages/Toothpaste.png" },
                new Product { Id = 250, Name = "Toothbrushes", CategoryId = 18, ImagePath = "/Images/ProductImages/Toothbrushes.png" },
                new Product { Id = 251, Name = "Mouthwash", CategoryId = 18, ImagePath = "/Images/ProductImages/Mouthwash.png" },
                new Product { Id = 252, Name = "Deodorant", CategoryId = 18, ImagePath = "/Images/ProductImages/Deodorant.png" },
                new Product { Id = 253, Name = "Razors", CategoryId = 18, ImagePath = "/Images/ProductImages/Razors.png" },
                new Product { Id = 254, Name = "Shaving cream", CategoryId = 18, ImagePath = "/Images/ProductImages/Shaving cream.png" },
                new Product { Id = 255, Name = "Lotion", CategoryId = 18, ImagePath = "/Images/ProductImages/Lotion.png" },
                new Product { Id = 256, Name = "Sunscreen", CategoryId = 18, ImagePath = "/Images/ProductImages/Sunscreen.png" },
                new Product { Id = 257, Name = "Lip balm", CategoryId = 18, ImagePath = "/Images/ProductImages/Lip balm.png" },
                new Product { Id = 258, Name = "Feminine hygiene products", CategoryId = 18, ImagePath = "/Images/ProductImages/Feminine hygiene products.png" },

                // Pharmacy & Wellness (259-271)
                new Product { Id = 259, Name = "Pain relievers", CategoryId = 19, ImagePath = "/Images/ProductImages/Pain relievers.png" },
                new Product { Id = 260, Name = "Cold medicine", CategoryId = 19, ImagePath = "/Images/ProductImages/Cold medicine.png" },
                new Product { Id = 261, Name = "Allergy medicine", CategoryId = 19, ImagePath = "/Images/ProductImages/Allergy medicine.png" },
                new Product { Id = 262, Name = "Cough drops", CategoryId = 19, ImagePath = "/Images/ProductImages/Cough drops.png" },
                new Product { Id = 263, Name = "Antacids", CategoryId = 19, ImagePath = "/Images/ProductImages/Antacids.png" },
                new Product { Id = 264, Name = "First aid kits", CategoryId = 19, ImagePath = "/Images/ProductImages/First aid kits.png" },
                new Product { Id = 265, Name = "Bandages", CategoryId = 19, ImagePath = "/Images/ProductImages/Bandages.png" },
                new Product { Id = 266, Name = "Hydrogen peroxide", CategoryId = 19, ImagePath = "/Images/ProductImages/Hydrogen peroxide.png" },
                new Product { Id = 267, Name = "Vitamins", CategoryId = 19, ImagePath = "/Images/ProductImages/Vitamins.png" },
                new Product { Id = 268, Name = "Multivitamins", CategoryId = 19, ImagePath = "/Images/ProductImages/Multivitamins.png" },
                new Product { Id = 269, Name = "Fish oil supplements", CategoryId = 19, ImagePath = "/Images/ProductImages/Fish oil supplements.png" },
                new Product { Id = 270, Name = "Probiotics", CategoryId = 19, ImagePath = "/Images/ProductImages/Probiotics.png" },
                new Product { Id = 271, Name = "Thermometers", CategoryId = 19, ImagePath = "/Images/ProductImages/Thermometers.png" },

                // Pet Supplies (272-279)
                new Product { Id = 272, Name = "Dog food", CategoryId = 20, ImagePath = "/Images/ProductImages/Dog food.png" },
                new Product { Id = 273, Name = "Cat food", CategoryId = 20, ImagePath = "/Images/ProductImages/Cat food.png" },
                new Product { Id = 274, Name = "Pet treats", CategoryId = 20, ImagePath = "/Images/ProductImages/Pet treats.png" },
                new Product { Id = 275, Name = "Cat litter", CategoryId = 20, ImagePath = "/Images/ProductImages/Cat litter.png" },
                new Product { Id = 276, Name = "Puppy pads", CategoryId = 20, ImagePath = "/Images/ProductImages/Puppy pads.png" },
                new Product { Id = 277, Name = "Pet toys", CategoryId = 20, ImagePath = "/Images/ProductImages/Pet toys.png" },
                new Product { Id = 278, Name = "Pet shampoo", CategoryId = 20, ImagePath = "/Images/ProductImages/Pet shampoo.png" },

                // Seasonal & Miscellaneous (279-292)
                new Product { Id = 279, Name = "Holiday candy", CategoryId = 21, ImagePath = "/Images/ProductImages/Holiday candy.png" },
                new Product { Id = 280, Name = "Gift cards", CategoryId = 21, ImagePath = "/Images/ProductImages/Gift cards.png" },
                new Product { Id = 281, Name = "Charcoal", CategoryId = 21, ImagePath = "/Images/ProductImages/Charcoal.png" },
                new Product { Id = 282, Name = "Disposable plates", CategoryId = 21, ImagePath = "/Images/ProductImages/Disposable plates.png" },
                new Product { Id = 283, Name = "Plastic utensils", CategoryId = 21, ImagePath = "/Images/ProductImages/Plastic utensils.png" },
                new Product { Id = 284, Name = "Birthday candles", CategoryId = 21, ImagePath = "/Images/ProductImages/Birthday candles.png" },
                new Product { Id = 285, Name = "Party napkins", CategoryId = 21, ImagePath = "/Images/ProductImages/Party napkins.png" },
                new Product { Id = 286, Name = "Picnic supplies", CategoryId = 21, ImagePath = "/Images/ProductImages/Picnic supplies.png" },
                new Product { Id = 287, Name = "Ice bags", CategoryId = 21, ImagePath = "/Images/ProductImages/Ice bags.png" },
                new Product { Id = 288, Name = "Fire logs", CategoryId = 21, ImagePath = "/Images/ProductImages/Fire logs.png" }
            };

            modelBuilder.Entity<Product>().HasData(products);

            // Seed shipments for every product (not just a subset) with deterministic — not purely
            // random — stock-level and expiration buckets, so the dashboard's Out of Stock, Low
            // Stock, and Expiring Soon widgets always have real, varied data rather than leaving
            // that up to chance (a prior version only seeded the first 50 of 288 products, and
            // relied on unbucketed randomness for quantities that happened to never land below the
            // low-stock threshold).
            //
            // Anchored to fixed dates (not DateTime.Now/Today) so the seed data — and therefore the
            // EF Core model snapshot — stays deterministic between builds; HasData with a
            // non-deterministic value makes EF think the model changes on every build and fails
            // migration validation. expirationAnchor is fixed close to "today" as of when this seed
            // data was authored so the Expired/Expiring Soon buckets read correctly for a near-term
            // demo; like the rest of this static seed data it will read as increasingly stale the
            // longer after that date the app is first run.
            var shipments = new List<Shipment>();
            var shipmentId = 1;
            var quantityRandom = new Random(42);
            // Separate instances so each draw sequence is independent of the others.
            var createdAtRandom = new Random(99);
            var expirationRandom = new Random(7);
            var seedAnchorDate = new DateTime(2026, 1, 1);
            var expirationAnchor = new DateTime(2026, 7, 15);
            var shipmentIndex = 0;

            for (var i = 0; i < products.Count; i++)
            {
                var product = products[i];

                // Every 10th product is out of stock, two more of every ten are low stock (below
                // Product.DefaultLowStockThreshold), and the rest are comfortably well stocked.
                int shipmentCount;
                Func<int> nextQuantity;
                var stockBucket = i % 10;
                if (stockBucket == 0)
                {
                    shipmentCount = quantityRandom.Next(1, 3);
                    nextQuantity = () => 0; // shipment record exists, but stock has been fully depleted
                }
                else if (stockBucket is 1 or 2)
                {
                    shipmentCount = 1;
                    nextQuantity = () => quantityRandom.Next(1, Product.DefaultLowStockThreshold);
                }
                else
                {
                    shipmentCount = quantityRandom.Next(2, 4);
                    nextQuantity = () => quantityRandom.Next(20, 100);
                }

                for (var s = 0; s < shipmentCount; s++)
                {
                    // Non-perishable products (cleaning/household supplies) don't get an expiration
                    // date. Perishables cycle through expired / expiring-within-the-window /
                    // expiring-soon-ish / not-expiring-soon buckets, decorrelated from the stock
                    // bucket above via a running shipment counter.
                    DateTime? expirationDate = null;
                    if (product.IsPerishable)
                    {
                        expirationDate = (shipmentIndex % 6) switch
                        {
                            0 => expirationAnchor.AddDays(-expirationRandom.Next(1, 30)),
                            1 => expirationAnchor.AddDays(expirationRandom.Next(0, 8)), // within the 7-day "expiring soon" window
                            2 => expirationAnchor.AddDays(expirationRandom.Next(8, 30)),
                            _ => expirationAnchor.AddDays(expirationRandom.Next(31, 365))
                        };
                    }

                    shipments.Add(new Shipment
                    {
                        Id = shipmentId++,
                        ProductId = product.Id,
                        ShipmentNumber = $"SHP-{product.Id:000}-{s + 1:00}",
                        ExpirationDate = expirationDate,
                        Quantity = nextQuantity(),
                        Location = quantityRandom.Next(0, 2) == 0 ? "InStorage" : "OnFloor",
                        CreatedAt = seedAnchorDate.AddDays(-createdAtRandom.Next(1, 60))
                    });

                    shipmentIndex++;
                }
            }

            modelBuilder.Entity<Shipment>().HasData(shipments);
        }
    }
}
