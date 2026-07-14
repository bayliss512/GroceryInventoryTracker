using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GroceryInventoryTracker.Migrations
{
    /// <inheritdoc />
    public partial class AddSuppliers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconSvg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shipments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ShipmentNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shipments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shipments_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Produce" },
                    { 2, "Meat & Seafood" },
                    { 3, "Dairy & Refrigerated" },
                    { 4, "Bakery" },
                    { 5, "Frozen Foods" },
                    { 6, "Pantry Staples" },
                    { 7, "Canned Goods" },
                    { 8, "Breakfast Foods" },
                    { 9, "Snacks" },
                    { 10, "Beverages" },
                    { 11, "Condiments & Sauces" },
                    { 12, "Herbs, Spices & Seasonings" },
                    { 13, "International Foods" },
                    { 14, "Health & Specialty Foods" },
                    { 15, "Baby Products" },
                    { 16, "Household Supplies" },
                    { 17, "Cleaning Supplies" },
                    { 18, "Personal Care" },
                    { 19, "Pharmacy & Wellness" },
                    { 20, "Pet Supplies" },
                    { 21, "Seasonal & Miscellaneous" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ImagePath", "Name" },
                values: new object[,]
                {
                    { 1, 1, "/Images/ProductImages/Apples.png", "Apples" },
                    { 2, 1, "/Images/ProductImages/Bananas.png", "Bananas" },
                    { 3, 1, "/Images/ProductImages/Oranges.png", "Oranges" },
                    { 4, 1, "/Images/ProductImages/Grapes.png", "Grapes" },
                    { 5, 1, "/Images/ProductImages/Strawberries.png", "Strawberries" },
                    { 6, 1, "/Images/ProductImages/Blueberries.png", "Blueberries" },
                    { 7, 1, "/Images/ProductImages/Lemons.png", "Lemons" },
                    { 8, 1, "/Images/ProductImages/Limes.png", "Limes" },
                    { 9, 1, "/Images/ProductImages/Avocados.png", "Avocados" },
                    { 10, 1, "/Images/ProductImages/Tomatoes.png", "Tomatoes" },
                    { 11, 1, "/Images/ProductImages/Potatoes.png", "Potatoes" },
                    { 12, 1, "/Images/ProductImages/Sweet potatoes.png", "Sweet potatoes" },
                    { 13, 1, "/Images/ProductImages/Onions.png", "Onions" },
                    { 14, 1, "/Images/ProductImages/Garlic.png", "Garlic" },
                    { 15, 1, "/Images/ProductImages/Carrots.png", "Carrots" },
                    { 16, 1, "/Images/ProductImages/Celery.png", "Celery" },
                    { 17, 1, "/Images/ProductImages/Bell peppers.png", "Bell peppers" },
                    { 18, 1, "/Images/ProductImages/Cucumbers.png", "Cucumbers" },
                    { 19, 1, "/Images/ProductImages/Broccoli.png", "Broccoli" },
                    { 20, 1, "/Images/ProductImages/Cauliflower.png", "Cauliflower" },
                    { 21, 1, "/Images/ProductImages/Lettuce.png", "Lettuce" },
                    { 22, 1, "/Images/ProductImages/Spinach.png", "Spinach" },
                    { 23, 1, "/Images/ProductImages/Kale.png", "Kale" },
                    { 24, 1, "/Images/ProductImages/Cabbage.png", "Cabbage" },
                    { 25, 1, "/Images/ProductImages/Mushrooms.png", "Mushrooms" },
                    { 26, 1, "/Images/ProductImages/Zucchini.png", "Zucchini" },
                    { 27, 2, "/Images/ProductImages/Ground beef.png", "Ground beef" },
                    { 28, 2, "/Images/ProductImages/Beef steaks.png", "Beef steaks" },
                    { 29, 2, "/Images/ProductImages/Pork chops.png", "Pork chops" },
                    { 30, 2, "/Images/ProductImages/Pork shoulder.png", "Pork shoulder" },
                    { 31, 2, "/Images/ProductImages/Bacon.png", "Bacon" },
                    { 32, 2, "/Images/ProductImages/Sausage.png", "Sausage" },
                    { 33, 2, "/Images/ProductImages/Chicken breasts.png", "Chicken breasts" },
                    { 34, 2, "/Images/ProductImages/Chicken thighs.png", "Chicken thighs" },
                    { 35, 2, "/Images/ProductImages/Whole chicken.png", "Whole chicken" },
                    { 36, 2, "/Images/ProductImages/Turkey breast.png", "Turkey breast" },
                    { 37, 2, "/Images/ProductImages/Deli turkey.png", "Deli turkey" },
                    { 38, 2, "/Images/ProductImages/Salmon fillets.png", "Salmon fillets" },
                    { 39, 2, "/Images/ProductImages/Tilapia fillets.png", "Tilapia fillets" },
                    { 40, 2, "/Images/ProductImages/Shrimp.png", "Shrimp" },
                    { 41, 2, "/Images/ProductImages/Cod fillets.png", "Cod fillets" },
                    { 42, 2, "/Images/ProductImages/Crab meat.png", "Crab meat" },
                    { 43, 2, "/Images/ProductImages/Canned tuna.png", "Canned tuna" },
                    { 44, 2, "/Images/ProductImages/Canned salmon.png", "Canned salmon" },
                    { 45, 3, "/Images/ProductImages/Milk.png", "Milk" },
                    { 46, 3, "/Images/ProductImages/Chocolate milk.png", "Chocolate milk" },
                    { 47, 3, "/Images/ProductImages/Butter.png", "Butter" },
                    { 48, 3, "/Images/ProductImages/Heavy cream.png", "Heavy cream" },
                    { 49, 3, "/Images/ProductImages/Sour cream.png", "Sour cream" },
                    { 50, 3, "/Images/ProductImages/Cottage cheese.png", "Cottage cheese" },
                    { 51, 3, "/Images/ProductImages/Cream cheese.png", "Cream cheese" },
                    { 52, 3, "/Images/ProductImages/Yogurt.png", "Yogurt" },
                    { 53, 3, "/Images/ProductImages/Greek yogurt.png", "Greek yogurt" },
                    { 54, 3, "/Images/ProductImages/Shredded cheddar cheese.png", "Shredded cheddar cheese" },
                    { 55, 3, "/Images/ProductImages/Mozzarella cheese.png", "Mozzarella cheese" },
                    { 56, 3, "/Images/ProductImages/Swiss cheese.png", "Swiss cheese" },
                    { 57, 3, "/Images/ProductImages/American cheese.png", "American cheese" },
                    { 58, 3, "/Images/ProductImages/Eggs.png", "Eggs" },
                    { 59, 3, "/Images/ProductImages/Egg whites.png", "Egg whites" },
                    { 60, 3, "/Images/ProductImages/Refrigerated biscuits.png", "Refrigerated biscuits" },
                    { 61, 3, "/Images/ProductImages/Refrigerated cookie dough.png", "Refrigerated cookie dough" },
                    { 62, 4, "/Images/ProductImages/White bread.png", "White bread" },
                    { 63, 4, "/Images/ProductImages/Whole wheat bread.png", "Whole wheat bread" },
                    { 64, 4, "/Images/ProductImages/Hamburger buns.png", "Hamburger buns" },
                    { 65, 4, "/Images/ProductImages/Hot dog buns.png", "Hot dog buns" },
                    { 66, 4, "/Images/ProductImages/Bagels.png", "Bagels" },
                    { 67, 4, "/Images/ProductImages/English muffins.png", "English muffins" },
                    { 68, 4, "/Images/ProductImages/Tortillas.png", "Tortillas" },
                    { 69, 4, "/Images/ProductImages/Croissants.png", "Croissants" },
                    { 70, 4, "/Images/ProductImages/Donuts.png", "Donuts" },
                    { 71, 4, "/Images/ProductImages/Muffins.png", "Muffins" },
                    { 72, 4, "/Images/ProductImages/Dinner rolls.png", "Dinner rolls" },
                    { 73, 4, "/Images/ProductImages/Pita bread.png", "Pita bread" },
                    { 74, 4, "/Images/ProductImages/Artisan loaves.png", "Artisan loaves" },
                    { 75, 4, "/Images/ProductImages/Cakes.png", "Cakes" },
                    { 76, 4, "/Images/ProductImages/Cupcakes.png", "Cupcakes" },
                    { 77, 5, "/Images/ProductImages/Frozen pizza.png", "Frozen pizza" },
                    { 78, 5, "/Images/ProductImages/Frozen vegetables.png", "Frozen vegetables" },
                    { 79, 5, "/Images/ProductImages/Frozen berries.png", "Frozen berries" },
                    { 80, 5, "/Images/ProductImages/Ice cream.png", "Ice cream" },
                    { 81, 5, "/Images/ProductImages/Frozen dinners.png", "Frozen dinners" },
                    { 82, 5, "/Images/ProductImages/Chicken nuggets.png", "Chicken nuggets" },
                    { 83, 5, "/Images/ProductImages/French fries.png", "French fries" },
                    { 84, 5, "/Images/ProductImages/Frozen waffles.png", "Frozen waffles" },
                    { 85, 5, "/Images/ProductImages/Frozen pancakes.png", "Frozen pancakes" },
                    { 86, 5, "/Images/ProductImages/Frozen fish fillets.png", "Frozen fish fillets" },
                    { 87, 5, "/Images/ProductImages/Frozen shrimp.png", "Frozen shrimp" },
                    { 88, 5, "/Images/ProductImages/Frozen meatballs.png", "Frozen meatballs" },
                    { 89, 5, "/Images/ProductImages/Frozen fruit.png", "Frozen fruit" },
                    { 90, 5, "/Images/ProductImages/Frozen garlic bread.png", "Frozen garlic bread" },
                    { 91, 6, "/Images/ProductImages/White rice.png", "White rice" },
                    { 92, 6, "/Images/ProductImages/Brown rice.png", "Brown rice" },
                    { 93, 6, "/Images/ProductImages/Pasta.png", "Pasta" },
                    { 94, 6, "/Images/ProductImages/Macaroni and cheese.png", "Macaroni and cheese" },
                    { 95, 6, "/Images/ProductImages/Flour.png", "Flour" },
                    { 96, 6, "/Images/ProductImages/Sugar.png", "Sugar" },
                    { 97, 6, "/Images/ProductImages/Brown sugar.png", "Brown sugar" },
                    { 98, 6, "/Images/ProductImages/Cornmeal.png", "Cornmeal" },
                    { 99, 6, "/Images/ProductImages/Oats.png", "Oats" },
                    { 100, 6, "/Images/ProductImages/Breadcrumbs.png", "Breadcrumbs" },
                    { 101, 6, "/Images/ProductImages/Pancake mix.png", "Pancake mix" },
                    { 102, 6, "/Images/ProductImages/Cake mix.png", "Cake mix" },
                    { 103, 6, "/Images/ProductImages/Baking soda.png", "Baking soda" },
                    { 104, 6, "/Images/ProductImages/Baking powder.png", "Baking powder" },
                    { 105, 6, "/Images/ProductImages/Cornstarch.png", "Cornstarch" },
                    { 106, 6, "/Images/ProductImages/Honey.png", "Honey" },
                    { 107, 6, "/Images/ProductImages/Maple syrup.png", "Maple syrup" },
                    { 108, 7, "/Images/ProductImages/Pinto beans.png", "Pinto beans" },
                    { 109, 7, "/Images/ProductImages/Black beans.png", "Black beans" },
                    { 110, 7, "/Images/ProductImages/Kidney beans.png", "Kidney beans" },
                    { 111, 7, "/Images/ProductImages/Chickpeas.png", "Chickpeas" },
                    { 112, 7, "/Images/ProductImages/Canned corn.png", "Canned corn" },
                    { 113, 7, "/Images/ProductImages/Green beans.png", "Green beans" },
                    { 114, 7, "/Images/ProductImages/Peas.png", "Peas" },
                    { 115, 7, "/Images/ProductImages/Diced tomatoes.png", "Diced tomatoes" },
                    { 116, 7, "/Images/ProductImages/Tomato sauce.png", "Tomato sauce" },
                    { 117, 7, "/Images/ProductImages/Tomato paste.png", "Tomato paste" },
                    { 118, 7, "/Images/ProductImages/Chicken noodle soup.png", "Chicken noodle soup" },
                    { 119, 7, "/Images/ProductImages/Cream of mushroom soup.png", "Cream of mushroom soup" },
                    { 120, 7, "/Images/ProductImages/Beef stew.png", "Beef stew" },
                    { 121, 7, "/Images/ProductImages/Canned fruit.png", "Canned fruit" },
                    { 122, 7, "/Images/ProductImages/Pumpkin puree.png", "Pumpkin puree" },
                    { 123, 8, "/Images/ProductImages/Cold cereal.png", "Cold cereal" },
                    { 124, 8, "/Images/ProductImages/Granola.png", "Granola" },
                    { 125, 8, "/Images/ProductImages/Instant oatmeal.png", "Instant oatmeal" },
                    { 126, 8, "/Images/ProductImages/Grits.png", "Grits" },
                    { 127, 8, "/Images/ProductImages/Breakfast bars.png", "Breakfast bars" },
                    { 128, 8, "/Images/ProductImages/Pop-tarts.png", "Pop-tarts" },
                    { 129, 8, "/Images/ProductImages/Pancake syrup.png", "Pancake syrup" },
                    { 130, 8, "/Images/ProductImages/Toaster pastries.png", "Toaster pastries" },
                    { 131, 8, "/Images/ProductImages/Breakfast sausage.png", "Breakfast sausage" },
                    { 132, 8, "/Images/ProductImages/Hash browns.png", "Hash browns" },
                    { 133, 9, "/Images/ProductImages/Potato chips.png", "Potato chips" },
                    { 134, 9, "/Images/ProductImages/Tortilla chips.png", "Tortilla chips" },
                    { 135, 9, "/Images/ProductImages/Pretzels.png", "Pretzels" },
                    { 136, 9, "/Images/ProductImages/Popcorn.png", "Popcorn" },
                    { 137, 9, "/Images/ProductImages/Crackers.png", "Crackers" },
                    { 138, 9, "/Images/ProductImages/Trail mix.png", "Trail mix" },
                    { 139, 9, "/Images/ProductImages/Mixed nuts.png", "Mixed nuts" },
                    { 140, 9, "/Images/ProductImages/Peanuts.png", "Peanuts" },
                    { 141, 9, "/Images/ProductImages/Granola bars.png", "Granola bars" },
                    { 142, 9, "/Images/ProductImages/Rice cakes.png", "Rice cakes" },
                    { 143, 9, "/Images/ProductImages/Beef jerky.png", "Beef jerky" },
                    { 144, 9, "/Images/ProductImages/Fruit snacks.png", "Fruit snacks" },
                    { 145, 9, "/Images/ProductImages/Cookies.png", "Cookies" },
                    { 146, 9, "/Images/ProductImages/Candy bars.png", "Candy bars" },
                    { 147, 10, "/Images/ProductImages/Bottled water.png", "Bottled water" },
                    { 148, 10, "/Images/ProductImages/Sparkling water.png", "Sparkling water" },
                    { 149, 10, "/Images/ProductImages/Soda.png", "Soda" },
                    { 150, 10, "/Images/ProductImages/Diet soda.png", "Diet soda" },
                    { 151, 10, "/Images/ProductImages/Energy drinks.png", "Energy drinks" },
                    { 152, 10, "/Images/ProductImages/Sports drinks.png", "Sports drinks" },
                    { 153, 10, "/Images/ProductImages/Coffee.png", "Coffee" },
                    { 154, 10, "/Images/ProductImages/Ground coffee.png", "Ground coffee" },
                    { 155, 10, "/Images/ProductImages/Tea bags.png", "Tea bags" },
                    { 156, 10, "/Images/ProductImages/Hot chocolate mix.png", "Hot chocolate mix" },
                    { 157, 10, "/Images/ProductImages/Fruit juice.png", "Fruit juice" },
                    { 158, 10, "/Images/ProductImages/Apple juice.png", "Apple juice" },
                    { 159, 10, "/Images/ProductImages/Orange juice.png", "Orange juice" },
                    { 160, 10, "/Images/ProductImages/Coconut water.png", "Coconut water" },
                    { 161, 11, "/Images/ProductImages/Ketchup.png", "Ketchup" },
                    { 162, 11, "/Images/ProductImages/Mustard.png", "Mustard" },
                    { 163, 11, "/Images/ProductImages/Mayonnaise.png", "Mayonnaise" },
                    { 164, 11, "/Images/ProductImages/Barbecue sauce.png", "Barbecue sauce" },
                    { 165, 11, "/Images/ProductImages/Ranch dressing.png", "Ranch dressing" },
                    { 166, 11, "/Images/ProductImages/Italian dressing.png", "Italian dressing" },
                    { 167, 11, "/Images/ProductImages/Soy sauce.png", "Soy sauce" },
                    { 168, 11, "/Images/ProductImages/Hot sauce.png", "Hot sauce" },
                    { 169, 11, "/Images/ProductImages/Salsa.png", "Salsa" },
                    { 170, 11, "/Images/ProductImages/Marinara sauce.png", "Marinara sauce" },
                    { 171, 11, "/Images/ProductImages/Alfredo sauce.png", "Alfredo sauce" },
                    { 172, 11, "/Images/ProductImages/Worcestershire sauce.png", "Worcestershire sauce" },
                    { 173, 11, "/Images/ProductImages/Relish.png", "Relish" },
                    { 174, 11, "/Images/ProductImages/Vinegar.png", "Vinegar" },
                    { 175, 11, "/Images/ProductImages/Olive oil.png", "Olive oil" },
                    { 176, 12, "/Images/ProductImages/Salt.png", "Salt" },
                    { 177, 12, "/Images/ProductImages/Black pepper.png", "Black pepper" },
                    { 178, 12, "/Images/ProductImages/Garlic powder.png", "Garlic powder" },
                    { 179, 12, "/Images/ProductImages/Onion powder.png", "Onion powder" },
                    { 180, 12, "/Images/ProductImages/Paprika.png", "Paprika" },
                    { 181, 12, "/Images/ProductImages/Chili powder.png", "Chili powder" },
                    { 182, 12, "/Images/ProductImages/Cumin.png", "Cumin" },
                    { 183, 12, "/Images/ProductImages/Oregano.png", "Oregano" },
                    { 184, 12, "/Images/ProductImages/Basil.png", "Basil" },
                    { 185, 12, "/Images/ProductImages/Cinnamon.png", "Cinnamon" },
                    { 186, 12, "/Images/ProductImages/Nutmeg.png", "Nutmeg" },
                    { 187, 12, "/Images/ProductImages/Italian seasoning.png", "Italian seasoning" },
                    { 188, 12, "/Images/ProductImages/Red pepper flakes.png", "Red pepper flakes" },
                    { 189, 12, "/Images/ProductImages/Taco seasoning.png", "Taco seasoning" },
                    { 190, 13, "/Images/ProductImages/Rice noodles.png", "Rice noodles" },
                    { 191, 13, "/Images/ProductImages/Curry paste.png", "Curry paste" },
                    { 192, 13, "/Images/ProductImages/Coconut milk.png", "Coconut milk" },
                    { 193, 13, "/Images/ProductImages/Ramen noodles.png", "Ramen noodles" },
                    { 194, 13, "/Images/ProductImages/Sushi rice.png", "Sushi rice" },
                    { 195, 13, "/Images/ProductImages/Teriyaki sauce.png", "Teriyaki sauce" },
                    { 196, 13, "/Images/ProductImages/Naan.png", "Naan" },
                    { 197, 13, "/Images/ProductImages/Taco shells.png", "Taco shells" },
                    { 198, 13, "/Images/ProductImages/Refried beans.png", "Refried beans" },
                    { 199, 13, "/Images/ProductImages/Enchilada sauce.png", "Enchilada sauce" },
                    { 200, 13, "/Images/ProductImages/Kimchi.png", "Kimchi" },
                    { 201, 13, "/Images/ProductImages/Miso paste.png", "Miso paste" },
                    { 202, 13, "/Images/ProductImages/Gochujang.png", "Gochujang" },
                    { 203, 14, "/Images/ProductImages/Protein powder.png", "Protein powder" },
                    { 204, 14, "/Images/ProductImages/Protein bars.png", "Protein bars" },
                    { 205, 14, "/Images/ProductImages/Plant-based milk.png", "Plant-based milk" },
                    { 206, 14, "/Images/ProductImages/Almond milk.png", "Almond milk" },
                    { 207, 14, "/Images/ProductImages/Oat milk.png", "Oat milk" },
                    { 208, 14, "/Images/ProductImages/Lactose-free milk.png", "Lactose-free milk" },
                    { 209, 14, "/Images/ProductImages/Gluten-free bread.png", "Gluten-free bread" },
                    { 210, 14, "/Images/ProductImages/Gluten-free pasta.png", "Gluten-free pasta" },
                    { 211, 14, "/Images/ProductImages/Organic produce.png", "Organic produce" },
                    { 212, 14, "/Images/ProductImages/Vegan cheese.png", "Vegan cheese" },
                    { 213, 14, "/Images/ProductImages/Tofu.png", "Tofu" },
                    { 214, 14, "/Images/ProductImages/Tempeh.png", "Tempeh" },
                    { 215, 14, "/Images/ProductImages/Chia seeds.png", "Chia seeds" },
                    { 216, 14, "/Images/ProductImages/Flax seeds.png", "Flax seeds" },
                    { 217, 15, "/Images/ProductImages/Baby formula.png", "Baby formula" },
                    { 218, 15, "/Images/ProductImages/Baby food jars.png", "Baby food jars" },
                    { 219, 15, "/Images/ProductImages/Baby cereal.png", "Baby cereal" },
                    { 220, 15, "/Images/ProductImages/Diapers.png", "Diapers" },
                    { 221, 15, "/Images/ProductImages/Baby wipes.png", "Baby wipes" },
                    { 222, 15, "/Images/ProductImages/Teething biscuits.png", "Teething biscuits" },
                    { 223, 16, "/Images/ProductImages/Paper towels.png", "Paper towels" },
                    { 224, 16, "/Images/ProductImages/Toilet paper.png", "Toilet paper" },
                    { 225, 16, "/Images/ProductImages/Facial tissues.png", "Facial tissues" },
                    { 226, 16, "/Images/ProductImages/Aluminum foil.png", "Aluminum foil" },
                    { 227, 16, "/Images/ProductImages/Plastic wrap.png", "Plastic wrap" },
                    { 228, 16, "/Images/ProductImages/Sandwich bags.png", "Sandwich bags" },
                    { 229, 16, "/Images/ProductImages/Trash bags.png", "Trash bags" },
                    { 230, 16, "/Images/ProductImages/Dish soap.png", "Dish soap" },
                    { 231, 16, "/Images/ProductImages/Dishwasher detergent.png", "Dishwasher detergent" },
                    { 232, 16, "/Images/ProductImages/Laundry detergent.png", "Laundry detergent" },
                    { 233, 16, "/Images/ProductImages/Fabric softener.png", "Fabric softener" },
                    { 234, 16, "/Images/ProductImages/Sponges.png", "Sponges" },
                    { 235, 16, "/Images/ProductImages/Food storage containers.png", "Food storage containers" },
                    { 236, 17, "/Images/ProductImages/All-purpose cleaner.png", "All-purpose cleaner" },
                    { 237, 17, "/Images/ProductImages/Glass cleaner.png", "Glass cleaner" },
                    { 238, 17, "/Images/ProductImages/Disinfecting wipes.png", "Disinfecting wipes" },
                    { 239, 17, "/Images/ProductImages/Bleach.png", "Bleach" },
                    { 240, 17, "/Images/ProductImages/Toilet bowl cleaner.png", "Toilet bowl cleaner" },
                    { 241, 17, "/Images/ProductImages/Floor cleaner.png", "Floor cleaner" },
                    { 242, 17, "/Images/ProductImages/Scrub brushes.png", "Scrub brushes" },
                    { 243, 17, "/Images/ProductImages/Rubber gloves.png", "Rubber gloves" },
                    { 244, 17, "/Images/ProductImages/Air freshener.png", "Air freshener" },
                    { 245, 18, "/Images/ProductImages/Shampoo.png", "Shampoo" },
                    { 246, 18, "/Images/ProductImages/Conditioner.png", "Conditioner" },
                    { 247, 18, "/Images/ProductImages/Body wash.png", "Body wash" },
                    { 248, 18, "/Images/ProductImages/Bar soap.png", "Bar soap" },
                    { 249, 18, "/Images/ProductImages/Toothpaste.png", "Toothpaste" },
                    { 250, 18, "/Images/ProductImages/Toothbrushes.png", "Toothbrushes" },
                    { 251, 18, "/Images/ProductImages/Mouthwash.png", "Mouthwash" },
                    { 252, 18, "/Images/ProductImages/Deodorant.png", "Deodorant" },
                    { 253, 18, "/Images/ProductImages/Razors.png", "Razors" },
                    { 254, 18, "/Images/ProductImages/Shaving cream.png", "Shaving cream" },
                    { 255, 18, "/Images/ProductImages/Lotion.png", "Lotion" },
                    { 256, 18, "/Images/ProductImages/Sunscreen.png", "Sunscreen" },
                    { 257, 18, "/Images/ProductImages/Lip balm.png", "Lip balm" },
                    { 258, 18, "/Images/ProductImages/Feminine hygiene products.png", "Feminine hygiene products" },
                    { 259, 19, "/Images/ProductImages/Pain relievers.png", "Pain relievers" },
                    { 260, 19, "/Images/ProductImages/Cold medicine.png", "Cold medicine" },
                    { 261, 19, "/Images/ProductImages/Allergy medicine.png", "Allergy medicine" },
                    { 262, 19, "/Images/ProductImages/Cough drops.png", "Cough drops" },
                    { 263, 19, "/Images/ProductImages/Antacids.png", "Antacids" },
                    { 264, 19, "/Images/ProductImages/First aid kits.png", "First aid kits" },
                    { 265, 19, "/Images/ProductImages/Bandages.png", "Bandages" },
                    { 266, 19, "/Images/ProductImages/Hydrogen peroxide.png", "Hydrogen peroxide" },
                    { 267, 19, "/Images/ProductImages/Vitamins.png", "Vitamins" },
                    { 268, 19, "/Images/ProductImages/Multivitamins.png", "Multivitamins" },
                    { 269, 19, "/Images/ProductImages/Fish oil supplements.png", "Fish oil supplements" },
                    { 270, 19, "/Images/ProductImages/Probiotics.png", "Probiotics" },
                    { 271, 19, "/Images/ProductImages/Thermometers.png", "Thermometers" },
                    { 272, 20, "/Images/ProductImages/Dog food.png", "Dog food" },
                    { 273, 20, "/Images/ProductImages/Cat food.png", "Cat food" },
                    { 274, 20, "/Images/ProductImages/Pet treats.png", "Pet treats" },
                    { 275, 20, "/Images/ProductImages/Cat litter.png", "Cat litter" },
                    { 276, 20, "/Images/ProductImages/Puppy pads.png", "Puppy pads" },
                    { 277, 20, "/Images/ProductImages/Pet toys.png", "Pet toys" },
                    { 278, 20, "/Images/ProductImages/Pet shampoo.png", "Pet shampoo" },
                    { 279, 21, "/Images/ProductImages/Holiday candy.png", "Holiday candy" },
                    { 280, 21, "/Images/ProductImages/Gift cards.png", "Gift cards" },
                    { 281, 21, "/Images/ProductImages/Charcoal.png", "Charcoal" },
                    { 282, 21, "/Images/ProductImages/Disposable plates.png", "Disposable plates" },
                    { 283, 21, "/Images/ProductImages/Plastic utensils.png", "Plastic utensils" },
                    { 284, 21, "/Images/ProductImages/Birthday candles.png", "Birthday candles" },
                    { 285, 21, "/Images/ProductImages/Party napkins.png", "Party napkins" },
                    { 286, 21, "/Images/ProductImages/Picnic supplies.png", "Picnic supplies" },
                    { 287, 21, "/Images/ProductImages/Ice bags.png", "Ice bags" },
                    { 288, 21, "/Images/ProductImages/Fire logs.png", "Fire logs" }
                });

            migrationBuilder.InsertData(
                table: "Shipments",
                columns: new[] { "Id", "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber", "SupplierId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 1, 21, "SHP-001-01", null },
                    { 2, new DateTime(2026, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 1, 75, "SHP-001-02", null },
                    { 3, new DateTime(2026, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 2, 33, "SHP-002-01", null },
                    { 4, new DateTime(2026, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 2, 33, "SHP-002-02", null },
                    { 5, new DateTime(2026, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 3, 45, "SHP-003-01", null },
                    { 6, new DateTime(2026, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 3, 83, "SHP-003-02", null },
                    { 7, new DateTime(2026, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 4, 91, "SHP-004-01", null },
                    { 8, new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 4, 13, "SHP-004-02", null },
                    { 9, new DateTime(2026, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 4, 10, "SHP-004-03", null },
                    { 10, new DateTime(2026, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 5, 23, "SHP-005-01", null },
                    { 11, new DateTime(2026, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 5, 66, "SHP-005-02", null },
                    { 12, new DateTime(2026, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 6, 68, "SHP-006-01", null },
                    { 13, new DateTime(2026, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 6, 56, "SHP-006-02", null },
                    { 14, new DateTime(2026, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 7, 29, "SHP-007-01", null },
                    { 15, new DateTime(2026, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 7, 16, "SHP-007-02", null },
                    { 16, new DateTime(2026, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 8, 81, "SHP-008-01", null },
                    { 17, new DateTime(2026, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 8, 10, "SHP-008-02", null },
                    { 18, new DateTime(2026, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 9, 68, "SHP-009-01", null },
                    { 19, new DateTime(2026, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 9, 51, "SHP-009-02", null },
                    { 20, new DateTime(2026, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 9, 43, "SHP-009-03", null },
                    { 21, new DateTime(2026, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 10, 46, "SHP-010-01", null },
                    { 22, new DateTime(2026, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 10, 76, "SHP-010-02", null },
                    { 23, new DateTime(2026, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 10, 39, "SHP-010-03", null },
                    { 24, new DateTime(2026, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 11, 39, "SHP-011-01", null },
                    { 25, new DateTime(2026, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 11, 29, "SHP-011-02", null },
                    { 26, new DateTime(2026, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 11, 78, "SHP-011-03", null },
                    { 27, new DateTime(2026, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 12, 99, "SHP-012-01", null },
                    { 28, new DateTime(2026, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 12, 93, "SHP-012-02", null },
                    { 29, new DateTime(2026, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 13, 29, "SHP-013-01", null },
                    { 30, new DateTime(2026, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 13, 99, "SHP-013-02", null },
                    { 31, new DateTime(2026, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 14, 77, "SHP-014-01", null },
                    { 32, new DateTime(2026, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 14, 85, "SHP-014-02", null },
                    { 33, new DateTime(2026, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 15, 35, "SHP-015-01", null },
                    { 34, new DateTime(2026, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 15, 27, "SHP-015-02", null },
                    { 35, new DateTime(2026, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 16, 94, "SHP-016-01", null },
                    { 36, new DateTime(2026, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 16, 89, "SHP-016-02", null },
                    { 37, new DateTime(2026, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 17, 74, "SHP-017-01", null },
                    { 38, new DateTime(2026, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 17, 89, "SHP-017-02", null },
                    { 39, new DateTime(2026, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 18, 58, "SHP-018-01", null },
                    { 40, new DateTime(2026, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 18, 19, "SHP-018-02", null },
                    { 41, new DateTime(2026, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 19, 46, "SHP-019-01", null },
                    { 42, new DateTime(2026, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 19, 91, "SHP-019-02", null },
                    { 43, new DateTime(2026, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 19, 40, "SHP-019-03", null },
                    { 44, new DateTime(2026, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 20, 77, "SHP-020-01", null },
                    { 45, new DateTime(2026, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 20, 82, "SHP-020-02", null },
                    { 46, new DateTime(2026, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 20, 27, "SHP-020-03", null },
                    { 47, new DateTime(2026, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 21, 17, "SHP-021-01", null },
                    { 48, new DateTime(2026, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 21, 80, "SHP-021-02", null },
                    { 49, new DateTime(2026, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 21, 90, "SHP-021-03", null },
                    { 50, new DateTime(2026, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 22, 67, "SHP-022-01", null },
                    { 51, new DateTime(2026, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 22, 82, "SHP-022-02", null },
                    { 52, new DateTime(2026, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 22, 28, "SHP-022-03", null },
                    { 53, new DateTime(2026, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 23, 94, "SHP-023-01", null },
                    { 54, new DateTime(2026, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 23, 38, "SHP-023-02", null },
                    { 55, new DateTime(2026, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 24, 52, "SHP-024-01", null },
                    { 56, new DateTime(2026, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 24, 69, "SHP-024-02", null },
                    { 57, new DateTime(2026, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 25, 26, "SHP-025-01", null },
                    { 58, new DateTime(2026, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 25, 44, "SHP-025-02", null },
                    { 59, new DateTime(2026, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 26, 38, "SHP-026-01", null },
                    { 60, new DateTime(2026, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 26, 11, "SHP-026-02", null },
                    { 61, new DateTime(2026, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 26, 90, "SHP-026-03", null },
                    { 62, new DateTime(2026, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 27, 36, "SHP-027-01", null },
                    { 63, new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 27, 40, "SHP-027-02", null },
                    { 64, new DateTime(2026, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 28, 42, "SHP-028-01", null },
                    { 65, new DateTime(2026, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 28, 67, "SHP-028-02", null },
                    { 66, new DateTime(2026, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 29, 22, "SHP-029-01", null },
                    { 67, new DateTime(2026, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 29, 41, "SHP-029-02", null },
                    { 68, new DateTime(2026, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 29, 23, "SHP-029-03", null },
                    { 69, new DateTime(2026, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 30, 26, "SHP-030-01", null },
                    { 70, new DateTime(2026, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 30, 68, "SHP-030-02", null },
                    { 71, new DateTime(2026, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 31, 48, "SHP-031-01", null },
                    { 72, new DateTime(2026, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 31, 58, "SHP-031-02", null },
                    { 73, new DateTime(2026, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 32, 72, "SHP-032-01", null },
                    { 74, new DateTime(2026, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 32, 83, "SHP-032-02", null },
                    { 75, new DateTime(2026, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 33, 50, "SHP-033-01", null },
                    { 76, new DateTime(2026, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 33, 13, "SHP-033-02", null },
                    { 77, new DateTime(2026, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 34, 46, "SHP-034-01", null },
                    { 78, new DateTime(2026, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 34, 37, "SHP-034-02", null },
                    { 79, new DateTime(2026, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 34, 18, "SHP-034-03", null },
                    { 80, new DateTime(2026, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 35, 94, "SHP-035-01", null },
                    { 81, new DateTime(2026, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 35, 89, "SHP-035-02", null },
                    { 82, new DateTime(2026, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 35, 55, "SHP-035-03", null },
                    { 83, new DateTime(2026, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 36, 66, "SHP-036-01", null },
                    { 84, new DateTime(2026, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 36, 43, "SHP-036-02", null },
                    { 85, new DateTime(2026, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 37, 68, "SHP-037-01", null },
                    { 86, new DateTime(2026, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 37, 84, "SHP-037-02", null },
                    { 87, new DateTime(2026, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 38, 81, "SHP-038-01", null },
                    { 88, new DateTime(2026, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 38, 10, "SHP-038-02", null },
                    { 89, new DateTime(2026, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 39, 57, "SHP-039-01", null },
                    { 90, new DateTime(2026, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 39, 90, "SHP-039-02", null },
                    { 91, new DateTime(2026, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 40, 86, "SHP-040-01", null },
                    { 92, new DateTime(2026, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 40, 18, "SHP-040-02", null },
                    { 93, new DateTime(2026, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 40, 26, "SHP-040-03", null },
                    { 94, new DateTime(2026, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 41, 49, "SHP-041-01", null },
                    { 95, new DateTime(2026, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 41, 83, "SHP-041-02", null },
                    { 96, new DateTime(2026, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 41, 92, "SHP-041-03", null },
                    { 97, new DateTime(2026, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 42, 45, "SHP-042-01", null },
                    { 98, new DateTime(2026, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 42, 89, "SHP-042-02", null },
                    { 99, new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 42, 59, "SHP-042-03", null },
                    { 100, new DateTime(2026, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 43, 77, "SHP-043-01", null },
                    { 101, new DateTime(2026, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 43, 44, "SHP-043-02", null },
                    { 102, new DateTime(2026, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 43, 34, "SHP-043-03", null },
                    { 103, new DateTime(2026, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 44, 13, "SHP-044-01", null },
                    { 104, new DateTime(2026, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 44, 89, "SHP-044-02", null },
                    { 105, new DateTime(2026, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 45, 84, "SHP-045-01", null },
                    { 106, new DateTime(2026, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 45, 50, "SHP-045-02", null },
                    { 107, new DateTime(2026, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 45, 32, "SHP-045-03", null },
                    { 108, new DateTime(2026, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 46, 51, "SHP-046-01", null },
                    { 109, new DateTime(2026, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 46, 35, "SHP-046-02", null },
                    { 110, new DateTime(2026, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 47, 54, "SHP-047-01", null },
                    { 111, new DateTime(2026, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 47, 71, "SHP-047-02", null },
                    { 112, new DateTime(2026, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 47, 41, "SHP-047-03", null },
                    { 113, new DateTime(2026, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 48, 35, "SHP-048-01", null },
                    { 114, new DateTime(2026, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 48, 22, "SHP-048-02", null },
                    { 115, new DateTime(2026, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 49, 52, "SHP-049-01", null },
                    { 116, new DateTime(2026, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 49, 20, "SHP-049-02", null },
                    { 117, new DateTime(2026, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 50, 18, "SHP-050-01", null },
                    { 118, new DateTime(2026, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 50, 58, "SHP-050-02", null },
                    { 119, new DateTime(2026, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 50, 66, "SHP-050-03", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_ProductId",
                table: "Shipments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_SupplierId",
                table: "Shipments",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shipments");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
