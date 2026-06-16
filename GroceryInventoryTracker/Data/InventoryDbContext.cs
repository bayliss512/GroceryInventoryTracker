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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(b =>
            {
                b.HasKey(p => p.Id);
                b.Property(p => p.Name).IsRequired();
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
                new Product { Id = 1, Name = "Apples", QuantityStored = 150, QuantityOnShelves = 45, CategoryId = 1, ImagePath = "/Images/ProductImages/Apples.png" },
                new Product { Id = 2, Name = "Bananas", QuantityStored = 120, QuantityOnShelves = 60, CategoryId = 1, ImagePath = "/Images/ProductImages/Bananas.png" },
                new Product { Id = 3, Name = "Oranges", QuantityStored = 100, QuantityOnShelves = 35, CategoryId = 1, ImagePath = "/Images/ProductImages/Oranges.png" },
                new Product { Id = 4, Name = "Grapes", QuantityStored = 80, QuantityOnShelves = 25, CategoryId = 1, ImagePath = "/Images/ProductImages/Grapes.png" },
                new Product { Id = 5, Name = "Strawberries", QuantityStored = 60, QuantityOnShelves = 20, CategoryId = 1, ImagePath = "/Images/ProductImages/Strawberries.png" },
                new Product { Id = 6, Name = "Blueberries", QuantityStored = 50, QuantityOnShelves = 15, CategoryId = 1, ImagePath = "/Images/ProductImages/Blueberries.png" },
                new Product { Id = 7, Name = "Lemons", QuantityStored = 70, QuantityOnShelves = 20, CategoryId = 1, ImagePath = "/Images/ProductImages/Lemons.png" },
                new Product { Id = 8, Name = "Limes", QuantityStored = 60, QuantityOnShelves = 18, CategoryId = 1, ImagePath = "/Images/ProductImages/Limes.png" },
                new Product { Id = 9, Name = "Avocados", QuantityStored = 90, QuantityOnShelves = 30, CategoryId = 1, ImagePath = "/Images/ProductImages/Avocados.png" },
                new Product { Id = 10, Name = "Tomatoes", QuantityStored = 110, QuantityOnShelves = 40, CategoryId = 1, ImagePath = "/Images/ProductImages/Tomatoes.png" },
                new Product { Id = 11, Name = "Potatoes", QuantityStored = 200, QuantityOnShelves = 70, CategoryId = 1, ImagePath = "/Images/ProductImages/Potatoes.png" },
                new Product { Id = 12, Name = "Sweet potatoes", QuantityStored = 85, QuantityOnShelves = 25, CategoryId = 1, ImagePath = "/Images/ProductImages/Sweet potatoes.png" },
                new Product { Id = 13, Name = "Onions", QuantityStored = 150, QuantityOnShelves = 50, CategoryId = 1, ImagePath = "/Images/ProductImages/Onions.png" },
                new Product { Id = 14, Name = "Garlic", QuantityStored = 40, QuantityOnShelves = 15, CategoryId = 1, ImagePath = "/Images/ProductImages/Garlic.png" },
                new Product { Id = 15, Name = "Carrots", QuantityStored = 120, QuantityOnShelves = 40, CategoryId = 1, ImagePath = "/Images/ProductImages/Carrots.png" },
                new Product { Id = 16, Name = "Celery", QuantityStored = 55, QuantityOnShelves = 18, CategoryId = 1, ImagePath = "/Images/ProductImages/Celery.png" },
                new Product { Id = 17, Name = "Bell peppers", QuantityStored = 95, QuantityOnShelves = 35, CategoryId = 1, ImagePath = "/Images/ProductImages/Bell peppers.png" },
                new Product { Id = 18, Name = "Cucumbers", QuantityStored = 75, QuantityOnShelves = 25, CategoryId = 1, ImagePath = "/Images/ProductImages/Cucumbers.png" },
                new Product { Id = 19, Name = "Broccoli", QuantityStored = 65, QuantityOnShelves = 22, CategoryId = 1, ImagePath = "/Images/ProductImages/Broccoli.png" },
                new Product { Id = 20, Name = "Cauliflower", QuantityStored = 60, QuantityOnShelves = 20, CategoryId = 1, ImagePath = "/Images/ProductImages/Cauliflower.png" },
                new Product { Id = 21, Name = "Lettuce", QuantityStored = 45, QuantityOnShelves = 18, CategoryId = 1, ImagePath = "/Images/ProductImages/Lettuce.png" },
                new Product { Id = 22, Name = "Spinach", QuantityStored = 50, QuantityOnShelves = 17, CategoryId = 1, ImagePath = "/Images/ProductImages/Spinach.png" },
                new Product { Id = 23, Name = "Kale", QuantityStored = 40, QuantityOnShelves = 14, CategoryId = 1, ImagePath = "/Images/ProductImages/Kale.png" },
                new Product { Id = 24, Name = "Cabbage", QuantityStored = 80, QuantityOnShelves = 28, CategoryId = 1, ImagePath = "/Images/ProductImages/Cabbage.png" },
                new Product { Id = 25, Name = "Mushrooms", QuantityStored = 55, QuantityOnShelves = 19, CategoryId = 1, ImagePath = "/Images/ProductImages/Mushrooms.png" },
                new Product { Id = 26, Name = "Zucchini", QuantityStored = 70, QuantityOnShelves = 24, CategoryId = 1, ImagePath = "/Images/ProductImages/Zucchini.png" },

                // Meat & Seafood (27-44)
                new Product { Id = 27, Name = "Ground beef", QuantityStored = 120, QuantityOnShelves = 35, CategoryId = 2, ImagePath = "/Images/ProductImages/Ground beef.png" },
                new Product { Id = 28, Name = "Beef steaks", QuantityStored = 85, QuantityOnShelves = 25, CategoryId = 2, ImagePath = "/Images/ProductImages/Beef steaks.png" },
                new Product { Id = 29, Name = "Pork chops", QuantityStored = 95, QuantityOnShelves = 28, CategoryId = 2, ImagePath = "/Images/ProductImages/Pork chops.png" },
                new Product { Id = 30, Name = "Pork shoulder", QuantityStored = 75, QuantityOnShelves = 22, CategoryId = 2, ImagePath = "/Images/ProductImages/Pork shoulder.png" },
                new Product { Id = 31, Name = "Bacon", QuantityStored = 105, QuantityOnShelves = 32, CategoryId = 2, ImagePath = "/Images/ProductImages/Bacon.png" },
                new Product { Id = 32, Name = "Sausage", QuantityStored = 80, QuantityOnShelves = 24, CategoryId = 2, ImagePath = "/Images/ProductImages/Sausage.png" },
                new Product { Id = 33, Name = "Chicken breasts", QuantityStored = 140, QuantityOnShelves = 42, CategoryId = 2, ImagePath = "/Images/ProductImages/Chicken breasts.png" },
                new Product { Id = 34, Name = "Chicken thighs", QuantityStored = 110, QuantityOnShelves = 33, CategoryId = 2, ImagePath = "/Images/ProductImages/Chicken thighs.png" },
                new Product { Id = 35, Name = "Whole chicken", QuantityStored = 65, QuantityOnShelves = 20, CategoryId = 2, ImagePath = "/Images/ProductImages/Whole chicken.png" },
                new Product { Id = 36, Name = "Turkey breast", QuantityStored = 90, QuantityOnShelves = 27, CategoryId = 2, ImagePath = "/Images/ProductImages/Turkey breast.png" },
                new Product { Id = 37, Name = "Deli turkey", QuantityStored = 70, QuantityOnShelves = 21, CategoryId = 2, ImagePath = "/Images/ProductImages/Deli turkey.png" },
                new Product { Id = 38, Name = "Salmon fillets", QuantityStored = 75, QuantityOnShelves = 23, CategoryId = 2, ImagePath = "/Images/ProductImages/Salmon fillets.png" },
                new Product { Id = 39, Name = "Tilapia fillets", QuantityStored = 85, QuantityOnShelves = 25, CategoryId = 2, ImagePath = "/Images/ProductImages/Tilapia fillets.png" },
                new Product { Id = 40, Name = "Shrimp", QuantityStored = 60, QuantityOnShelves = 18, CategoryId = 2, ImagePath = "/Images/ProductImages/Shrimp.png" },
                new Product { Id = 41, Name = "Cod fillets", QuantityStored = 70, QuantityOnShelves = 21, CategoryId = 2, ImagePath = "/Images/ProductImages/Cod fillets.png" },
                new Product { Id = 42, Name = "Crab meat", QuantityStored = 45, QuantityOnShelves = 14, CategoryId = 2, ImagePath = "/Images/ProductImages/Crab meat.png" },
                new Product { Id = 43, Name = "Canned tuna", QuantityStored = 200, QuantityOnShelves = 60, CategoryId = 2, ImagePath = "/Images/ProductImages/Canned tuna.png" },
                new Product { Id = 44, Name = "Canned salmon", QuantityStored = 150, QuantityOnShelves = 45, CategoryId = 2, ImagePath = "/Images/ProductImages/Canned salmon.png" },

                // Dairy & Refrigerated (45-60)
                new Product { Id = 45, Name = "Milk", QuantityStored = 180, QuantityOnShelves = 55, CategoryId = 3, ImagePath = "/Images/ProductImages/Milk.png" },
                new Product { Id = 46, Name = "Chocolate milk", QuantityStored = 90, QuantityOnShelves = 28, CategoryId = 3, ImagePath = "/Images/ProductImages/Chocolate milk.png" },
                new Product { Id = 47, Name = "Butter", QuantityStored = 120, QuantityOnShelves = 36, CategoryId = 3, ImagePath = "/Images/ProductImages/Butter.png" },
                new Product { Id = 48, Name = "Heavy cream", QuantityStored = 75, QuantityOnShelves = 23, CategoryId = 3, ImagePath = "/Images/ProductImages/Heavy cream.png" },
                new Product { Id = 49, Name = "Sour cream", QuantityStored = 85, QuantityOnShelves = 25, CategoryId = 3, ImagePath = "/Images/ProductImages/Sour cream.png" },
                new Product { Id = 50, Name = "Cottage cheese", QuantityStored = 60, QuantityOnShelves = 18, CategoryId = 3, ImagePath = "/Images/ProductImages/Cottage cheese.png" },
                new Product { Id = 51, Name = "Cream cheese", QuantityStored = 95, QuantityOnShelves = 28, CategoryId = 3, ImagePath = "/Images/ProductImages/Cream cheese.png" },
                new Product { Id = 52, Name = "Yogurt", QuantityStored = 140, QuantityOnShelves = 42, CategoryId = 3, ImagePath = "/Images/ProductImages/Yogurt.png" },
                new Product { Id = 53, Name = "Greek yogurt", QuantityStored = 110, QuantityOnShelves = 33, CategoryId = 3, ImagePath = "/Images/ProductImages/Greek yogurt.png" },
                new Product { Id = 54, Name = "Shredded cheddar cheese", QuantityStored = 100, QuantityOnShelves = 30, CategoryId = 3, ImagePath = "/Images/ProductImages/Shredded cheddar cheese.png" },
                new Product { Id = 55, Name = "Mozzarella cheese", QuantityStored = 115, QuantityOnShelves = 34, CategoryId = 3, ImagePath = "/Images/ProductImages/Mozzarella cheese.png" },
                new Product { Id = 56, Name = "Swiss cheese", QuantityStored = 80, QuantityOnShelves = 24, CategoryId = 3, ImagePath = "/Images/ProductImages/Swiss cheese.png" },
                new Product { Id = 57, Name = "American cheese", QuantityStored = 90, QuantityOnShelves = 27, CategoryId = 3, ImagePath = "/Images/ProductImages/American cheese.png" },
                new Product { Id = 58, Name = "Eggs", QuantityStored = 300, QuantityOnShelves = 90, CategoryId = 3, ImagePath = "/Images/ProductImages/Eggs.png" },
                new Product { Id = 59, Name = "Egg whites", QuantityStored = 150, QuantityOnShelves = 45, CategoryId = 3, ImagePath = "/Images/ProductImages/Egg whites.png" },
                new Product { Id = 60, Name = "Refrigerated biscuits", QuantityStored = 70, QuantityOnShelves = 21, CategoryId = 3, ImagePath = "/Images/ProductImages/Refrigerated biscuits.png" },
                new Product { Id = 61, Name = "Refrigerated cookie dough", QuantityStored = 55, QuantityOnShelves = 16, CategoryId = 3, ImagePath = "/Images/ProductImages/Refrigerated cookie dough.png" },

                // Bakery (62-75)
                new Product { Id = 62, Name = "White bread", QuantityStored = 100, QuantityOnShelves = 30, CategoryId = 4, ImagePath = "/Images/ProductImages/White bread.png" },
                new Product { Id = 63, Name = "Whole wheat bread", QuantityStored = 85, QuantityOnShelves = 25, CategoryId = 4, ImagePath = "/Images/ProductImages/Whole wheat bread.png" },
                new Product { Id = 64, Name = "Hamburger buns", QuantityStored = 110, QuantityOnShelves = 33, CategoryId = 4, ImagePath = "/Images/ProductImages/Hamburger buns.png" },
                new Product { Id = 65, Name = "Hot dog buns", QuantityStored = 100, QuantityOnShelves = 30, CategoryId = 4, ImagePath = "/Images/ProductImages/Hot dog buns.png" },
                new Product { Id = 66, Name = "Bagels", QuantityStored = 75, QuantityOnShelves = 22, CategoryId = 4, ImagePath = "/Images/ProductImages/Bagels.png" },
                new Product { Id = 67, Name = "English muffins", QuantityStored = 80, QuantityOnShelves = 24, CategoryId = 4, ImagePath = "/Images/ProductImages/English muffins.png" },
                new Product { Id = 68, Name = "Tortillas", QuantityStored = 120, QuantityOnShelves = 36, CategoryId = 4, ImagePath = "/Images/ProductImages/Tortillas.png" },
                new Product { Id = 69, Name = "Croissants", QuantityStored = 60, QuantityOnShelves = 18, CategoryId = 4, ImagePath = "/Images/ProductImages/Croissants.png" },
                new Product { Id = 70, Name = "Donuts", QuantityStored = 95, QuantityOnShelves = 28, CategoryId = 4, ImagePath = "/Images/ProductImages/Donuts.png" },
                new Product { Id = 71, Name = "Muffins", QuantityStored = 85, QuantityOnShelves = 25, CategoryId = 4, ImagePath = "/Images/ProductImages/Muffins.png" },
                new Product { Id = 72, Name = "Dinner rolls", QuantityStored = 110, QuantityOnShelves = 33, CategoryId = 4, ImagePath = "/Images/ProductImages/Dinner rolls.png" },
                new Product { Id = 73, Name = "Pita bread", QuantityStored = 70, QuantityOnShelves = 21, CategoryId = 4, ImagePath = "/Images/ProductImages/Pita bread.png" },
                new Product { Id = 74, Name = "Artisan loaves", QuantityStored = 50, QuantityOnShelves = 15, CategoryId = 4, ImagePath = "/Images/ProductImages/Artisan loaves.png" },
                new Product { Id = 75, Name = "Cakes", QuantityStored = 40, QuantityOnShelves = 12, CategoryId = 4, ImagePath = "/Images/ProductImages/Cakes.png" },
                new Product { Id = 76, Name = "Cupcakes", QuantityStored = 60, QuantityOnShelves = 18, CategoryId = 4, ImagePath = "/Images/ProductImages/Cupcakes.png" },

                // Frozen Foods (77-90)
                new Product { Id = 77, Name = "Frozen pizza", QuantityStored = 120, QuantityOnShelves = 36, CategoryId = 5, ImagePath = "/Images/ProductImages/Frozen pizza.png" },
                new Product { Id = 78, Name = "Frozen vegetables", QuantityStored = 150, QuantityOnShelves = 45, CategoryId = 5, ImagePath = "/Images/ProductImages/Frozen vegetables.png" },
                new Product { Id = 79, Name = "Frozen berries", QuantityStored = 100, QuantityOnShelves = 30, CategoryId = 5, ImagePath = "/Images/ProductImages/Frozen berries.png" },
                new Product { Id = 80, Name = "Ice cream", QuantityStored = 140, QuantityOnShelves = 42, CategoryId = 5, ImagePath = "/Images/ProductImages/Ice cream.png" },
                new Product { Id = 81, Name = "Frozen dinners", QuantityStored = 130, QuantityOnShelves = 39, CategoryId = 5, ImagePath = "/Images/ProductImages/Frozen dinners.png" },
                new Product { Id = 82, Name = "Chicken nuggets", QuantityStored = 110, QuantityOnShelves = 33, CategoryId = 5, ImagePath = "/Images/ProductImages/Chicken nuggets.png" },
                new Product { Id = 83, Name = "French fries", QuantityStored = 125, QuantityOnShelves = 37, CategoryId = 5, ImagePath = "/Images/ProductImages/French fries.png" },
                new Product { Id = 84, Name = "Frozen waffles", QuantityStored = 95, QuantityOnShelves = 28, CategoryId = 5, ImagePath = "/Images/ProductImages/Frozen waffles.png" },
                new Product { Id = 85, Name = "Frozen pancakes", QuantityStored = 90, QuantityOnShelves = 27, CategoryId = 5, ImagePath = "/Images/ProductImages/Frozen pancakes.png" },
                new Product { Id = 86, Name = "Frozen fish fillets", QuantityStored = 85, QuantityOnShelves = 25, CategoryId = 5, ImagePath = "/Images/ProductImages/Frozen fish fillets.png" },
                new Product { Id = 87, Name = "Frozen shrimp", QuantityStored = 75, QuantityOnShelves = 22, CategoryId = 5, ImagePath = "/Images/ProductImages/Frozen shrimp.png" },
                new Product { Id = 88, Name = "Frozen meatballs", QuantityStored = 100, QuantityOnShelves = 30, CategoryId = 5, ImagePath = "/Images/ProductImages/Frozen meatballs.png" },
                new Product { Id = 89, Name = "Frozen fruit", QuantityStored = 105, QuantityOnShelves = 31, CategoryId = 5, ImagePath = "/Images/ProductImages/Frozen fruit.png" },
                new Product { Id = 90, Name = "Frozen garlic bread", QuantityStored = 80, QuantityOnShelves = 24, CategoryId = 5, ImagePath = "/Images/ProductImages/Frozen garlic bread.png" },

                // Pantry Staples (91-108)
                new Product { Id = 91, Name = "White rice", QuantityStored = 180, QuantityOnShelves = 54, CategoryId = 6, ImagePath = "/Images/ProductImages/White rice.png" },
                new Product { Id = 92, Name = "Brown rice", QuantityStored = 150, QuantityOnShelves = 45, CategoryId = 6, ImagePath = "/Images/ProductImages/Brown rice.png" },
                new Product { Id = 93, Name = "Pasta", QuantityStored = 200, QuantityOnShelves = 60, CategoryId = 6, ImagePath = "/Images/ProductImages/Pasta.png" },
                new Product { Id = 94, Name = "Macaroni and cheese", QuantityStored = 120, QuantityOnShelves = 36, CategoryId = 6, ImagePath = "/Images/ProductImages/Macaroni and cheese.png" },
                new Product { Id = 95, Name = "Flour", QuantityStored = 160, QuantityOnShelves = 48, CategoryId = 6, ImagePath = "/Images/ProductImages/Flour.png" },
                new Product { Id = 96, Name = "Sugar", QuantityStored = 140, QuantityOnShelves = 42, CategoryId = 6, ImagePath = "/Images/ProductImages/Sugar.png" },
                new Product { Id = 97, Name = "Brown sugar", QuantityStored = 110, QuantityOnShelves = 33, CategoryId = 6, ImagePath = "/Images/ProductImages/Brown sugar.png" },
                new Product { Id = 98, Name = "Cornmeal", QuantityStored = 85, QuantityOnShelves = 25, CategoryId = 6, ImagePath = "/Images/ProductImages/Cornmeal.png" },
                new Product { Id = 99, Name = "Oats", QuantityStored = 120, QuantityOnShelves = 36, CategoryId = 6, ImagePath = "/Images/ProductImages/Oats.png" },
                new Product { Id = 100, Name = "Breadcrumbs", QuantityStored = 95, QuantityOnShelves = 28, CategoryId = 6, ImagePath = "/Images/ProductImages/Breadcrumbs.png" },
                new Product { Id = 101, Name = "Pancake mix", QuantityStored = 100, QuantityOnShelves = 30, CategoryId = 6, ImagePath = "/Images/ProductImages/Pancake mix.png" },
                new Product { Id = 102, Name = "Cake mix", QuantityStored = 110, QuantityOnShelves = 33, CategoryId = 6, ImagePath = "/Images/ProductImages/Cake mix.png" },
                new Product { Id = 103, Name = "Baking soda", QuantityStored = 80, QuantityOnShelves = 24, CategoryId = 6, ImagePath = "/Images/ProductImages/Baking soda.png" },
                new Product { Id = 104, Name = "Baking powder", QuantityStored = 90, QuantityOnShelves = 27, CategoryId = 6, ImagePath = "/Images/ProductImages/Baking powder.png" },
                new Product { Id = 105, Name = "Cornstarch", QuantityStored = 75, QuantityOnShelves = 22, CategoryId = 6, ImagePath = "/Images/ProductImages/Cornstarch.png" },
                new Product { Id = 106, Name = "Honey", QuantityStored = 100, QuantityOnShelves = 30, CategoryId = 6, ImagePath = "/Images/ProductImages/Honey.png" },
                new Product { Id = 107, Name = "Maple syrup", QuantityStored = 85, QuantityOnShelves = 25, CategoryId = 6, ImagePath = "/Images/ProductImages/Maple syrup.png" },

                // Canned Goods (108-130)
                new Product { Id = 108, Name = "Pinto beans", QuantityStored = 140, QuantityOnShelves = 42, CategoryId = 7, ImagePath = "/Images/ProductImages/Pinto beans.png" },
                new Product { Id = 109, Name = "Black beans", QuantityStored = 130, QuantityOnShelves = 39, CategoryId = 7, ImagePath = "/Images/ProductImages/Black beans.png" },
                new Product { Id = 110, Name = "Kidney beans", QuantityStored = 120, QuantityOnShelves = 36, CategoryId = 7, ImagePath = "/Images/ProductImages/Kidney beans.png" },
                new Product { Id = 111, Name = "Chickpeas", QuantityStored = 125, QuantityOnShelves = 37, CategoryId = 7, ImagePath = "/Images/ProductImages/Chickpeas.png" },
                new Product { Id = 112, Name = "Canned corn", QuantityStored = 150, QuantityOnShelves = 45, CategoryId = 7, ImagePath = "/Images/ProductImages/Canned corn.png" },
                new Product { Id = 113, Name = "Green beans", QuantityStored = 130, QuantityOnShelves = 39, CategoryId = 7, ImagePath = "/Images/ProductImages/Green beans.png" },
                new Product { Id = 114, Name = "Peas", QuantityStored = 125, QuantityOnShelves = 37, CategoryId = 7, ImagePath = "/Images/ProductImages/Peas.png" },
                new Product { Id = 115, Name = "Diced tomatoes", QuantityStored = 160, QuantityOnShelves = 48, CategoryId = 7, ImagePath = "/Images/ProductImages/Diced tomatoes.png" },
                new Product { Id = 116, Name = "Tomato sauce", QuantityStored = 150, QuantityOnShelves = 45, CategoryId = 7, ImagePath = "/Images/ProductImages/Tomato sauce.png" },
                new Product { Id = 117, Name = "Tomato paste", QuantityStored = 120, QuantityOnShelves = 36, CategoryId = 7, ImagePath = "/Images/ProductImages/Tomato paste.png" },
                new Product { Id = 118, Name = "Chicken noodle soup", QuantityStored = 140, QuantityOnShelves = 42, CategoryId = 7, ImagePath = "/Images/ProductImages/Chicken noodle soup.png" },
                new Product { Id = 119, Name = "Cream of mushroom soup", QuantityStored = 130, QuantityOnShelves = 39, CategoryId = 7, ImagePath = "/Images/ProductImages/Cream of mushroom soup.png" },
                new Product { Id = 120, Name = "Beef stew", QuantityStored = 110, QuantityOnShelves = 33, CategoryId = 7, ImagePath = "/Images/ProductImages/Beef stew.png" },
                new Product { Id = 121, Name = "Canned fruit", QuantityStored = 135, QuantityOnShelves = 40, CategoryId = 7, ImagePath = "/Images/ProductImages/Canned fruit.png" },
                new Product { Id = 122, Name = "Pumpkin puree", QuantityStored = 100, QuantityOnShelves = 30, CategoryId = 7, ImagePath = "/Images/ProductImages/Pumpkin puree.png" },

                // Breakfast Foods (123-131)
                new Product { Id = 123, Name = "Cold cereal", QuantityStored = 140, QuantityOnShelves = 42, CategoryId = 8, ImagePath = "/Images/ProductImages/Cold cereal.png" },
                new Product { Id = 124, Name = "Granola", QuantityStored = 110, QuantityOnShelves = 33, CategoryId = 8, ImagePath = "/Images/ProductImages/Granola.png" },
                new Product { Id = 125, Name = "Instant oatmeal", QuantityStored = 125, QuantityOnShelves = 37, CategoryId = 8, ImagePath = "/Images/ProductImages/Instant oatmeal.png" },
                new Product { Id = 126, Name = "Grits", QuantityStored = 80, QuantityOnShelves = 24, CategoryId = 8, ImagePath = "/Images/ProductImages/Grits.png" },
                new Product { Id = 127, Name = "Breakfast bars", QuantityStored = 150, QuantityOnShelves = 45, CategoryId = 8, ImagePath = "/Images/ProductImages/Breakfast bars.png" },
                new Product { Id = 128, Name = "Pop-tarts", QuantityStored = 130, QuantityOnShelves = 39, CategoryId = 8, ImagePath = "/Images/ProductImages/Pop-tarts.png" },
                new Product { Id = 129, Name = "Pancake syrup", QuantityStored = 105, QuantityOnShelves = 31, CategoryId = 8, ImagePath = "/Images/ProductImages/Pancake syrup.png" },
                new Product { Id = 130, Name = "Toaster pastries", QuantityStored = 120, QuantityOnShelves = 36, CategoryId = 8, ImagePath = "/Images/ProductImages/Toaster pastries.png" },
                new Product { Id = 131, Name = "Breakfast sausage", QuantityStored = 95, QuantityOnShelves = 28, CategoryId = 8, ImagePath = "/Images/ProductImages/Breakfast sausage.png" },
                new Product { Id = 132, Name = "Hash browns", QuantityStored = 85, QuantityOnShelves = 25, CategoryId = 8, ImagePath = "/Images/ProductImages/Hash browns.png" },

                // Snacks (133-148)
                new Product { Id = 133, Name = "Potato chips", QuantityStored = 160, QuantityOnShelves = 48, CategoryId = 9, ImagePath = "/Images/ProductImages/Potato chips.png" },
                new Product { Id = 134, Name = "Tortilla chips", QuantityStored = 150, QuantityOnShelves = 45, CategoryId = 9, ImagePath = "/Images/ProductImages/Tortilla chips.png" },
                new Product { Id = 135, Name = "Pretzels", QuantityStored = 140, QuantityOnShelves = 42, CategoryId = 9, ImagePath = "/Images/ProductImages/Pretzels.png" },
                new Product { Id = 136, Name = "Popcorn", QuantityStored = 130, QuantityOnShelves = 39, CategoryId = 9, ImagePath = "/Images/ProductImages/Popcorn.png" },
                new Product { Id = 137, Name = "Crackers", QuantityStored = 145, QuantityOnShelves = 43, CategoryId = 9, ImagePath = "/Images/ProductImages/Crackers.png" },
                new Product { Id = 138, Name = "Trail mix", QuantityStored = 120, QuantityOnShelves = 36, CategoryId = 9, ImagePath = "/Images/ProductImages/Trail mix.png" },
                new Product { Id = 139, Name = "Mixed nuts", QuantityStored = 100, QuantityOnShelves = 30, CategoryId = 9, ImagePath = "/Images/ProductImages/Mixed nuts.png" },
                new Product { Id = 140, Name = "Peanuts", QuantityStored = 110, QuantityOnShelves = 33, CategoryId = 9, ImagePath = "/Images/ProductImages/Peanuts.png" },
                new Product { Id = 141, Name = "Granola bars", QuantityStored = 155, QuantityOnShelves = 46, CategoryId = 9, ImagePath = "/Images/ProductImages/Granola bars.png" },
                new Product { Id = 142, Name = "Rice cakes", QuantityStored = 90, QuantityOnShelves = 27, CategoryId = 9, ImagePath = "/Images/ProductImages/Rice cakes.png" },
                new Product { Id = 143, Name = "Beef jerky", QuantityStored = 85, QuantityOnShelves = 25, CategoryId = 9, ImagePath = "/Images/ProductImages/Beef jerky.png" },
                new Product { Id = 144, Name = "Fruit snacks", QuantityStored = 140, QuantityOnShelves = 42, CategoryId = 9, ImagePath = "/Images/ProductImages/Fruit snacks.png" },
                new Product { Id = 145, Name = "Cookies", QuantityStored = 130, QuantityOnShelves = 39, CategoryId = 9, ImagePath = "/Images/ProductImages/Cookies.png" },
                new Product { Id = 146, Name = "Candy bars", QuantityStored = 150, QuantityOnShelves = 45, CategoryId = 9, ImagePath = "/Images/ProductImages/Candy bars.png" },

                // Beverages (147-161)
                new Product { Id = 147, Name = "Bottled water", QuantityStored = 300, QuantityOnShelves = 90, CategoryId = 10, ImagePath = "/Images/ProductImages/Bottled water.png" },
                new Product { Id = 148, Name = "Sparkling water", QuantityStored = 180, QuantityOnShelves = 54, CategoryId = 10, ImagePath = "/Images/ProductImages/Sparkling water.png" },
                new Product { Id = 149, Name = "Soda", QuantityStored = 250, QuantityOnShelves = 75, CategoryId = 10, ImagePath = "/Images/ProductImages/Soda.png" },
                new Product { Id = 150, Name = "Diet soda", QuantityStored = 220, QuantityOnShelves = 66, CategoryId = 10, ImagePath = "/Images/ProductImages/Diet soda.png" },
                new Product { Id = 151, Name = "Energy drinks", QuantityStored = 200, QuantityOnShelves = 60, CategoryId = 10, ImagePath = "/Images/ProductImages/Energy drinks.png" },
                new Product { Id = 152, Name = "Sports drinks", QuantityStored = 190, QuantityOnShelves = 57, CategoryId = 10, ImagePath = "/Images/ProductImages/Sports drinks.png" },
                new Product { Id = 153, Name = "Coffee", QuantityStored = 140, QuantityOnShelves = 42, CategoryId = 10, ImagePath = "/Images/ProductImages/Coffee.png" },
                new Product { Id = 154, Name = "Ground coffee", QuantityStored = 125, QuantityOnShelves = 37, CategoryId = 10, ImagePath = "/Images/ProductImages/Ground coffee.png" },
                new Product { Id = 155, Name = "Tea bags", QuantityStored = 150, QuantityOnShelves = 45, CategoryId = 10, ImagePath = "/Images/ProductImages/Tea bags.png" },
                new Product { Id = 156, Name = "Hot chocolate mix", QuantityStored = 110, QuantityOnShelves = 33, CategoryId = 10, ImagePath = "/Images/ProductImages/Hot chocolate mix.png" },
                new Product { Id = 157, Name = "Fruit juice", QuantityStored = 170, QuantityOnShelves = 51, CategoryId = 10, ImagePath = "/Images/ProductImages/Fruit juice.png" },
                new Product { Id = 158, Name = "Apple juice", QuantityStored = 160, QuantityOnShelves = 48, CategoryId = 10, ImagePath = "/Images/ProductImages/Apple juice.png" },
                new Product { Id = 159, Name = "Orange juice", QuantityStored = 165, QuantityOnShelves = 49, CategoryId = 10, ImagePath = "/Images/ProductImages/Orange juice.png" },
                new Product { Id = 160, Name = "Coconut water", QuantityStored = 130, QuantityOnShelves = 39, CategoryId = 10, ImagePath = "/Images/ProductImages/Coconut water.png" },

                // Condiments & Sauces (161-174)
                new Product { Id = 161, Name = "Ketchup", QuantityStored = 150, QuantityOnShelves = 45, CategoryId = 11, ImagePath = "/Images/ProductImages/Ketchup.png" },
                new Product { Id = 162, Name = "Mustard", QuantityStored = 140, QuantityOnShelves = 42, CategoryId = 11, ImagePath = "/Images/ProductImages/Mustard.png" },
                new Product { Id = 163, Name = "Mayonnaise", QuantityStored = 130, QuantityOnShelves = 39, CategoryId = 11, ImagePath = "/Images/ProductImages/Mayonnaise.png" },
                new Product { Id = 164, Name = "Barbecue sauce", QuantityStored = 120, QuantityOnShelves = 36, CategoryId = 11, ImagePath = "/Images/ProductImages/Barbecue sauce.png" },
                new Product { Id = 165, Name = "Ranch dressing", QuantityStored = 125, QuantityOnShelves = 37, CategoryId = 11, ImagePath = "/Images/ProductImages/Ranch dressing.png" },
                new Product { Id = 166, Name = "Italian dressing", QuantityStored = 115, QuantityOnShelves = 34, CategoryId = 11, ImagePath = "/Images/ProductImages/Italian dressing.png" },
                new Product { Id = 167, Name = "Soy sauce", QuantityStored = 135, QuantityOnShelves = 40, CategoryId = 11, ImagePath = "/Images/ProductImages/Soy sauce.png" },
                new Product { Id = 168, Name = "Hot sauce", QuantityStored = 110, QuantityOnShelves = 33, CategoryId = 11, ImagePath = "/Images/ProductImages/Hot sauce.png" },
                new Product { Id = 169, Name = "Salsa", QuantityStored = 145, QuantityOnShelves = 43, CategoryId = 11, ImagePath = "/Images/ProductImages/Salsa.png" },
                new Product { Id = 170, Name = "Marinara sauce", QuantityStored = 140, QuantityOnShelves = 42, CategoryId = 11, ImagePath = "/Images/ProductImages/Marinara sauce.png" },
                new Product { Id = 171, Name = "Alfredo sauce", QuantityStored = 120, QuantityOnShelves = 36, CategoryId = 11, ImagePath = "/Images/ProductImages/Alfredo sauce.png" },
                new Product { Id = 172, Name = "Worcestershire sauce", QuantityStored = 105, QuantityOnShelves = 31, CategoryId = 11, ImagePath = "/Images/ProductImages/Worcestershire sauce.png" },
                new Product { Id = 173, Name = "Relish", QuantityStored = 95, QuantityOnShelves = 28, CategoryId = 11, ImagePath = "/Images/ProductImages/Relish.png" },
                new Product { Id = 174, Name = "Vinegar", QuantityStored = 115, QuantityOnShelves = 34, CategoryId = 11, ImagePath = "/Images/ProductImages/Vinegar.png" },
                new Product { Id = 175, Name = "Olive oil", QuantityStored = 100, QuantityOnShelves = 30, CategoryId = 11, ImagePath = "/Images/ProductImages/Olive oil.png" },

                // Herbs, Spices & Seasonings (176-191)
                new Product { Id = 176, Name = "Salt", QuantityStored = 120, QuantityOnShelves = 36, CategoryId = 12, ImagePath = "/Images/ProductImages/Salt.png" },
                new Product { Id = 177, Name = "Black pepper", QuantityStored = 110, QuantityOnShelves = 33, CategoryId = 12, ImagePath = "/Images/ProductImages/Black pepper.png" },
                new Product { Id = 178, Name = "Garlic powder", QuantityStored = 100, QuantityOnShelves = 30, CategoryId = 12, ImagePath = "/Images/ProductImages/Garlic powder.png" },
                new Product { Id = 179, Name = "Onion powder", QuantityStored = 95, QuantityOnShelves = 28, CategoryId = 12, ImagePath = "/Images/ProductImages/Onion powder.png" },
                new Product { Id = 180, Name = "Paprika", QuantityStored = 85, QuantityOnShelves = 25, CategoryId = 12, ImagePath = "/Images/ProductImages/Paprika.png" },
                new Product { Id = 181, Name = "Chili powder", QuantityStored = 90, QuantityOnShelves = 27, CategoryId = 12, ImagePath = "/Images/ProductImages/Chili powder.png" },
                new Product { Id = 182, Name = "Cumin", QuantityStored = 80, QuantityOnShelves = 24, CategoryId = 12, ImagePath = "/Images/ProductImages/Cumin.png" },
                new Product { Id = 183, Name = "Oregano", QuantityStored = 85, QuantityOnShelves = 25, CategoryId = 12, ImagePath = "/Images/ProductImages/Oregano.png" },
                new Product { Id = 184, Name = "Basil", QuantityStored = 80, QuantityOnShelves = 24, CategoryId = 12, ImagePath = "/Images/ProductImages/Basil.png" },
                new Product { Id = 185, Name = "Cinnamon", QuantityStored = 100, QuantityOnShelves = 30, CategoryId = 12, ImagePath = "/Images/ProductImages/Cinnamon.png" },
                new Product { Id = 186, Name = "Nutmeg", QuantityStored = 75, QuantityOnShelves = 22, CategoryId = 12, ImagePath = "/Images/ProductImages/Nutmeg.png" },
                new Product { Id = 187, Name = "Italian seasoning", QuantityStored = 90, QuantityOnShelves = 27, CategoryId = 12, ImagePath = "/Images/ProductImages/Italian seasoning.png" },
                new Product { Id = 188, Name = "Red pepper flakes", QuantityStored = 70, QuantityOnShelves = 21, CategoryId = 12, ImagePath = "/Images/ProductImages/Red pepper flakes.png" },
                new Product { Id = 189, Name = "Taco seasoning", QuantityStored = 105, QuantityOnShelves = 31, CategoryId = 12, ImagePath = "/Images/ProductImages/Taco seasoning.png" },

                // International Foods (190-200)
                new Product { Id = 190, Name = "Rice noodles", QuantityStored = 110, QuantityOnShelves = 33, CategoryId = 13, ImagePath = "/Images/ProductImages/Rice noodles.png" },
                new Product { Id = 191, Name = "Curry paste", QuantityStored = 85, QuantityOnShelves = 25, CategoryId = 13, ImagePath = "/Images/ProductImages/Curry paste.png" },
                new Product { Id = 192, Name = "Coconut milk", QuantityStored = 120, QuantityOnShelves = 36, CategoryId = 13, ImagePath = "/Images/ProductImages/Coconut milk.png" },
                new Product { Id = 193, Name = "Ramen noodles", QuantityStored = 140, QuantityOnShelves = 42, CategoryId = 13, ImagePath = "/Images/ProductImages/Ramen noodles.png" },
                new Product { Id = 194, Name = "Sushi rice", QuantityStored = 100, QuantityOnShelves = 30, CategoryId = 13, ImagePath = "/Images/ProductImages/Sushi rice.png" },
                new Product { Id = 195, Name = "Teriyaki sauce", QuantityStored = 105, QuantityOnShelves = 31, CategoryId = 13, ImagePath = "/Images/ProductImages/Teriyaki sauce.png" },
                new Product { Id = 196, Name = "Naan", QuantityStored = 70, QuantityOnShelves = 21, CategoryId = 13, ImagePath = "/Images/ProductImages/Naan.png" },
                new Product { Id = 197, Name = "Taco shells", QuantityStored = 130, QuantityOnShelves = 39, CategoryId = 13, ImagePath = "/Images/ProductImages/Taco shells.png" },
                new Product { Id = 198, Name = "Refried beans", QuantityStored = 115, QuantityOnShelves = 34, CategoryId = 13, ImagePath = "/Images/ProductImages/Refried beans.png" },
                new Product { Id = 199, Name = "Enchilada sauce", QuantityStored = 105, QuantityOnShelves = 31, CategoryId = 13, ImagePath = "/Images/ProductImages/Enchilada sauce.png" },
                new Product { Id = 200, Name = "Kimchi", QuantityStored = 65, QuantityOnShelves = 19, CategoryId = 13, ImagePath = "/Images/ProductImages/Kimchi.png" },
                new Product { Id = 201, Name = "Miso paste", QuantityStored = 75, QuantityOnShelves = 22, CategoryId = 13, ImagePath = "/Images/ProductImages/Miso paste.png" },
                new Product { Id = 202, Name = "Gochujang", QuantityStored = 60, QuantityOnShelves = 18, CategoryId = 13, ImagePath = "/Images/ProductImages/Gochujang.png" },

                // Health & Specialty Foods (203-216)
                new Product { Id = 203, Name = "Protein powder", QuantityStored = 100, QuantityOnShelves = 30, CategoryId = 14, ImagePath = "/Images/ProductImages/Protein powder.png" },
                new Product { Id = 204, Name = "Protein bars", QuantityStored = 145, QuantityOnShelves = 43, CategoryId = 14, ImagePath = "/Images/ProductImages/Protein bars.png" },
                new Product { Id = 205, Name = "Plant-based milk", QuantityStored = 125, QuantityOnShelves = 37, CategoryId = 14, ImagePath = "/Images/ProductImages/Plant-based milk.png" },
                new Product { Id = 206, Name = "Almond milk", QuantityStored = 140, QuantityOnShelves = 42, CategoryId = 14, ImagePath = "/Images/ProductImages/Almond milk.png" },
                new Product { Id = 207, Name = "Oat milk", QuantityStored = 130, QuantityOnShelves = 39, CategoryId = 14, ImagePath = "/Images/ProductImages/Oat milk.png" },
                new Product { Id = 208, Name = "Lactose-free milk", QuantityStored = 120, QuantityOnShelves = 36, CategoryId = 14, ImagePath = "/Images/ProductImages/Lactose-free milk.png" },
                new Product { Id = 209, Name = "Gluten-free bread", QuantityStored = 95, QuantityOnShelves = 28, CategoryId = 14, ImagePath = "/Images/ProductImages/Gluten-free bread.png" },
                new Product { Id = 210, Name = "Gluten-free pasta", QuantityStored = 105, QuantityOnShelves = 31, CategoryId = 14, ImagePath = "/Images/ProductImages/Gluten-free pasta.png" },
                new Product { Id = 211, Name = "Organic produce", QuantityStored = 110, QuantityOnShelves = 33, CategoryId = 14, ImagePath = "/Images/ProductImages/Organic produce.png" },
                new Product { Id = 212, Name = "Vegan cheese", QuantityStored = 80, QuantityOnShelves = 24, CategoryId = 14, ImagePath = "/Images/ProductImages/Vegan cheese.png" },
                new Product { Id = 213, Name = "Tofu", QuantityStored = 90, QuantityOnShelves = 27, CategoryId = 14, ImagePath = "/Images/ProductImages/Tofu.png" },
                new Product { Id = 214, Name = "Tempeh", QuantityStored = 75, QuantityOnShelves = 22, CategoryId = 14, ImagePath = "/Images/ProductImages/Tempeh.png" },
                new Product { Id = 215, Name = "Chia seeds", QuantityStored = 70, QuantityOnShelves = 21, CategoryId = 14, ImagePath = "/Images/ProductImages/Chia seeds.png" },
                new Product { Id = 216, Name = "Flax seeds", QuantityStored = 65, QuantityOnShelves = 19, CategoryId = 14, ImagePath = "/Images/ProductImages/Flax seeds.png" },

                // Baby Products (217-223)
                new Product { Id = 217, Name = "Baby formula", QuantityStored = 130, QuantityOnShelves = 39, CategoryId = 15, ImagePath = "/Images/ProductImages/Baby formula.png" },
                new Product { Id = 218, Name = "Baby food jars", QuantityStored = 150, QuantityOnShelves = 45, CategoryId = 15, ImagePath = "/Images/ProductImages/Baby food jars.png" },
                new Product { Id = 219, Name = "Baby cereal", QuantityStored = 110, QuantityOnShelves = 33, CategoryId = 15, ImagePath = "/Images/ProductImages/Baby cereal.png" },
                new Product { Id = 220, Name = "Diapers", QuantityStored = 200, QuantityOnShelves = 60, CategoryId = 15, ImagePath = "/Images/ProductImages/Diapers.png" },
                new Product { Id = 221, Name = "Baby wipes", QuantityStored = 180, QuantityOnShelves = 54, CategoryId = 15, ImagePath = "/Images/ProductImages/Baby wipes.png" },
                new Product { Id = 222, Name = "Teething biscuits", QuantityStored = 85, QuantityOnShelves = 25, CategoryId = 15, ImagePath = "/Images/ProductImages/Teething biscuits.png" },

                // Household Supplies (223-232)
                new Product { Id = 223, Name = "Paper towels", QuantityStored = 180, QuantityOnShelves = 54, CategoryId = 16, ImagePath = "/Images/ProductImages/Paper towels.png" },
                new Product { Id = 224, Name = "Toilet paper", QuantityStored = 200, QuantityOnShelves = 60, CategoryId = 16, ImagePath = "/Images/ProductImages/Toilet paper.png" },
                new Product { Id = 225, Name = "Facial tissues", QuantityStored = 150, QuantityOnShelves = 45, CategoryId = 16, ImagePath = "/Images/ProductImages/Facial tissues.png" },
                new Product { Id = 226, Name = "Aluminum foil", QuantityStored = 140, QuantityOnShelves = 42, CategoryId = 16, ImagePath = "/Images/ProductImages/Aluminum foil.png" },
                new Product { Id = 227, Name = "Plastic wrap", QuantityStored = 130, QuantityOnShelves = 39, CategoryId = 16, ImagePath = "/Images/ProductImages/Plastic wrap.png" },
                new Product { Id = 228, Name = "Sandwich bags", QuantityStored = 160, QuantityOnShelves = 48, CategoryId = 16, ImagePath = "/Images/ProductImages/Sandwich bags.png" },
                new Product { Id = 229, Name = "Trash bags", QuantityStored = 170, QuantityOnShelves = 51, CategoryId = 16, ImagePath = "/Images/ProductImages/Trash bags.png" },
                new Product { Id = 230, Name = "Dish soap", QuantityStored = 125, QuantityOnShelves = 37, CategoryId = 16, ImagePath = "/Images/ProductImages/Dish soap.png" },
                new Product { Id = 231, Name = "Dishwasher detergent", QuantityStored = 135, QuantityOnShelves = 40, CategoryId = 16, ImagePath = "/Images/ProductImages/Dishwasher detergent.png" },
                new Product { Id = 232, Name = "Laundry detergent", QuantityStored = 140, QuantityOnShelves = 42, CategoryId = 16, ImagePath = "/Images/ProductImages/Laundry detergent.png" },
                new Product { Id = 233, Name = "Fabric softener", QuantityStored = 120, QuantityOnShelves = 36, CategoryId = 16, ImagePath = "/Images/ProductImages/Fabric softener.png" },
                new Product { Id = 234, Name = "Sponges", QuantityStored = 110, QuantityOnShelves = 33, CategoryId = 16, ImagePath = "/Images/ProductImages/Sponges.png" },
                new Product { Id = 235, Name = "Food storage containers", QuantityStored = 125, QuantityOnShelves = 37, CategoryId = 16, ImagePath = "/Images/ProductImages/Food storage containers.png" },

                // Cleaning Supplies (236-246)
                new Product { Id = 236, Name = "All-purpose cleaner", QuantityStored = 140, QuantityOnShelves = 42, CategoryId = 17, ImagePath = "/Images/ProductImages/All-purpose cleaner.png" },
                new Product { Id = 237, Name = "Glass cleaner", QuantityStored = 120, QuantityOnShelves = 36, CategoryId = 17, ImagePath = "/Images/ProductImages/Glass cleaner.png" },
                new Product { Id = 238, Name = "Disinfecting wipes", QuantityStored = 160, QuantityOnShelves = 48, CategoryId = 17, ImagePath = "/Images/ProductImages/Disinfecting wipes.png" },
                new Product { Id = 239, Name = "Bleach", QuantityStored = 130, QuantityOnShelves = 39, CategoryId = 17, ImagePath = "/Images/ProductImages/Bleach.png" },
                new Product { Id = 240, Name = "Toilet bowl cleaner", QuantityStored = 115, QuantityOnShelves = 34, CategoryId = 17, ImagePath = "/Images/ProductImages/Toilet bowl cleaner.png" },
                new Product { Id = 241, Name = "Floor cleaner", QuantityStored = 125, QuantityOnShelves = 37, CategoryId = 17, ImagePath = "/Images/ProductImages/Floor cleaner.png" },
                new Product { Id = 242, Name = "Scrub brushes", QuantityStored = 100, QuantityOnShelves = 30, CategoryId = 17, ImagePath = "/Images/ProductImages/Scrub brushes.png" },
                new Product { Id = 243, Name = "Rubber gloves", QuantityStored = 110, QuantityOnShelves = 33, CategoryId = 17, ImagePath = "/Images/ProductImages/Rubber gloves.png" },
                new Product { Id = 244, Name = "Air freshener", QuantityStored = 135, QuantityOnShelves = 40, CategoryId = 17, ImagePath = "/Images/ProductImages/Air freshener.png" },

                // Personal Care (245-259)
                new Product { Id = 245, Name = "Shampoo", QuantityStored = 140, QuantityOnShelves = 42, CategoryId = 18, ImagePath = "/Images/ProductImages/Shampoo.png" },
                new Product { Id = 246, Name = "Conditioner", QuantityStored = 135, QuantityOnShelves = 40, CategoryId = 18, ImagePath = "/Images/ProductImages/Conditioner.png" },
                new Product { Id = 247, Name = "Body wash", QuantityStored = 150, QuantityOnShelves = 45, CategoryId = 18, ImagePath = "/Images/ProductImages/Body wash.png" },
                new Product { Id = 248, Name = "Bar soap", QuantityStored = 160, QuantityOnShelves = 48, CategoryId = 18, ImagePath = "/Images/ProductImages/Bar soap.png" },
                new Product { Id = 249, Name = "Toothpaste", QuantityStored = 170, QuantityOnShelves = 51, CategoryId = 18, ImagePath = "/Images/ProductImages/Toothpaste.png" },
                new Product { Id = 250, Name = "Toothbrushes", QuantityStored = 150, QuantityOnShelves = 45, CategoryId = 18, ImagePath = "/Images/ProductImages/Toothbrushes.png" },
                new Product { Id = 251, Name = "Mouthwash", QuantityStored = 125, QuantityOnShelves = 37, CategoryId = 18, ImagePath = "/Images/ProductImages/Mouthwash.png" },
                new Product { Id = 252, Name = "Deodorant", QuantityStored = 155, QuantityOnShelves = 46, CategoryId = 18, ImagePath = "/Images/ProductImages/Deodorant.png" },
                new Product { Id = 253, Name = "Razors", QuantityStored = 110, QuantityOnShelves = 33, CategoryId = 18, ImagePath = "/Images/ProductImages/Razors.png" },
                new Product { Id = 254, Name = "Shaving cream", QuantityStored = 105, QuantityOnShelves = 31, CategoryId = 18, ImagePath = "/Images/ProductImages/Shaving cream.png" },
                new Product { Id = 255, Name = "Lotion", QuantityStored = 130, QuantityOnShelves = 39, CategoryId = 18, ImagePath = "/Images/ProductImages/Lotion.png" },
                new Product { Id = 256, Name = "Sunscreen", QuantityStored = 115, QuantityOnShelves = 34, CategoryId = 18, ImagePath = "/Images/ProductImages/Sunscreen.png" },
                new Product { Id = 257, Name = "Lip balm", QuantityStored = 140, QuantityOnShelves = 42, CategoryId = 18, ImagePath = "/Images/ProductImages/Lip balm.png" },
                new Product { Id = 258, Name = "Feminine hygiene products", QuantityStored = 150, QuantityOnShelves = 45, CategoryId = 18, ImagePath = "/Images/ProductImages/Feminine hygiene products.png" },

                // Pharmacy & Wellness (259-271)
                new Product { Id = 259, Name = "Pain relievers", QuantityStored = 160, QuantityOnShelves = 48, CategoryId = 19, ImagePath = "/Images/ProductImages/Pain relievers.png" },
                new Product { Id = 260, Name = "Cold medicine", QuantityStored = 140, QuantityOnShelves = 42, CategoryId = 19, ImagePath = "/Images/ProductImages/Cold medicine.png" },
                new Product { Id = 261, Name = "Allergy medicine", QuantityStored = 135, QuantityOnShelves = 40, CategoryId = 19, ImagePath = "/Images/ProductImages/Allergy medicine.png" },
                new Product { Id = 262, Name = "Cough drops", QuantityStored = 125, QuantityOnShelves = 37, CategoryId = 19, ImagePath = "/Images/ProductImages/Cough drops.png" },
                new Product { Id = 263, Name = "Antacids", QuantityStored = 120, QuantityOnShelves = 36, CategoryId = 19, ImagePath = "/Images/ProductImages/Antacids.png" },
                new Product { Id = 264, Name = "First aid kits", QuantityStored = 100, QuantityOnShelves = 30, CategoryId = 19, ImagePath = "/Images/ProductImages/First aid kits.png" },
                new Product { Id = 265, Name = "Bandages", QuantityStored = 150, QuantityOnShelves = 45, CategoryId = 19, ImagePath = "/Images/ProductImages/Bandages.png" },
                new Product { Id = 266, Name = "Hydrogen peroxide", QuantityStored = 110, QuantityOnShelves = 33, CategoryId = 19, ImagePath = "/Images/ProductImages/Hydrogen peroxide.png" },
                new Product { Id = 267, Name = "Vitamins", QuantityStored = 145, QuantityOnShelves = 43, CategoryId = 19, ImagePath = "/Images/ProductImages/Vitamins.png" },
                new Product { Id = 268, Name = "Multivitamins", QuantityStored = 140, QuantityOnShelves = 42, CategoryId = 19, ImagePath = "/Images/ProductImages/Multivitamins.png" },
                new Product { Id = 269, Name = "Fish oil supplements", QuantityStored = 120, QuantityOnShelves = 36, CategoryId = 19, ImagePath = "/Images/ProductImages/Fish oil supplements.png" },
                new Product { Id = 270, Name = "Probiotics", QuantityStored = 130, QuantityOnShelves = 39, CategoryId = 19, ImagePath = "/Images/ProductImages/Probiotics.png" },
                new Product { Id = 271, Name = "Thermometers", QuantityStored = 95, QuantityOnShelves = 28, CategoryId = 19, ImagePath = "/Images/ProductImages/Thermometers.png" },

                // Pet Supplies (272-279)
                new Product { Id = 272, Name = "Dog food", QuantityStored = 180, QuantityOnShelves = 54, CategoryId = 20, ImagePath = "/Images/ProductImages/Dog food.png" },
                new Product { Id = 273, Name = "Cat food", QuantityStored = 160, QuantityOnShelves = 48, CategoryId = 20, ImagePath = "/Images/ProductImages/Cat food.png" },
                new Product { Id = 274, Name = "Pet treats", QuantityStored = 140, QuantityOnShelves = 42, CategoryId = 20, ImagePath = "/Images/ProductImages/Pet treats.png" },
                new Product { Id = 275, Name = "Cat litter", QuantityStored = 150, QuantityOnShelves = 45, CategoryId = 20, ImagePath = "/Images/ProductImages/Cat litter.png" },
                new Product { Id = 276, Name = "Puppy pads", QuantityStored = 120, QuantityOnShelves = 36, CategoryId = 20, ImagePath = "/Images/ProductImages/Puppy pads.png" },
                new Product { Id = 277, Name = "Pet toys", QuantityStored = 130, QuantityOnShelves = 39, CategoryId = 20, ImagePath = "/Images/ProductImages/Pet toys.png" },
                new Product { Id = 278, Name = "Pet shampoo", QuantityStored = 100, QuantityOnShelves = 30, CategoryId = 20, ImagePath = "/Images/ProductImages/Pet shampoo.png" },

                // Seasonal & Miscellaneous (279-292)
                new Product { Id = 279, Name = "Holiday candy", QuantityStored = 200, QuantityOnShelves = 60, CategoryId = 21, ImagePath = "/Images/ProductImages/Holiday candy.png" },
                new Product { Id = 280, Name = "Gift cards", QuantityStored = 100, QuantityOnShelves = 30, CategoryId = 21, ImagePath = "/Images/ProductImages/Gift cards.png" },
                new Product { Id = 281, Name = "Charcoal", QuantityStored = 110, QuantityOnShelves = 33, CategoryId = 21, ImagePath = "/Images/ProductImages/Charcoal.png" },
                new Product { Id = 282, Name = "Disposable plates", QuantityStored = 140, QuantityOnShelves = 42, CategoryId = 21, ImagePath = "/Images/ProductImages/Disposable plates.png" },
                new Product { Id = 283, Name = "Plastic utensils", QuantityStored = 150, QuantityOnShelves = 45, CategoryId = 21, ImagePath = "/Images/ProductImages/Plastic utensils.png" },
                new Product { Id = 284, Name = "Birthday candles", QuantityStored = 80, QuantityOnShelves = 24, CategoryId = 21, ImagePath = "/Images/ProductImages/Birthday candles.png" },
                new Product { Id = 285, Name = "Party napkins", QuantityStored = 130, QuantityOnShelves = 39, CategoryId = 21, ImagePath = "/Images/ProductImages/Party napkins.png" },
                new Product { Id = 286, Name = "Picnic supplies", QuantityStored = 120, QuantityOnShelves = 36, CategoryId = 21, ImagePath = "/Images/ProductImages/Picnic supplies.png" },
                new Product { Id = 287, Name = "Ice bags", QuantityStored = 100, QuantityOnShelves = 30, CategoryId = 21, ImagePath = "/Images/ProductImages/Ice bags.png" },
                new Product { Id = 288, Name = "Fire logs", QuantityStored = 90, QuantityOnShelves = 27, CategoryId = 21, ImagePath = "/Images/ProductImages/Fire logs.png" }
            };

            modelBuilder.Entity<Product>().HasData(products);

            // Seed shipments - sample shipments for variety
            var shipments = new List<Shipment>();
            int shipmentId = 1;
            var random = new Random(42); // Use seed for reproducibility

            foreach (var product in products.Take(50)) // Add shipments for first 50 products
            {
                for (int i = 0; i < random.Next(2, 4); i++)
                {
                    shipments.Add(new Shipment
                    {
                        Id = shipmentId++,
                        ProductId = product.Id,
                        ShipmentNumber = $"SHP-{product.Id:000}-{i + 1:00}",
                        ExpirationDate = DateTime.Now.AddDays(random.Next(30, 365)),
                        Quantity = random.Next(10, 100)
                    });
                }
            }

            modelBuilder.Entity<Shipment>().HasData(shipments);
        }
    }
}
