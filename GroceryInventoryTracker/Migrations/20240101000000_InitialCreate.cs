using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GroceryInventoryTracker.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantityStored = table.Column<int>(type: "int", nullable: false),
                    QuantityOnSalesFloor = table.Column<int>(type: "int", nullable: false),
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
                    Quantity = table.Column<int>(type: "int", nullable: false)
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
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Produce" },
                    { 2, "Dairy" },
                    { 3, "Bakery" },
                    { 4, "Meat" },
                    { 5, "Dry Goods" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ImagePath", "Name", "QuantityOnSalesFloor", "QuantityStored" },
                values: new object[,]
                {
                    { 1, 1, "https://images.unsplash.com/photo-1560806e614-56f27138e5de?w=400&h=400&fit=crop", "Apples", 45, 150 },
                    { 2, 1, "https://images.unsplash.com/photo-1571019614242-c5c5dee9f50b?w=400&h=400&fit=crop", "Bananas", 60, 120 },
                    { 3, 2, "https://images.unsplash.com/photo-1550583724-b2692b25a968?w=400&h=400&fit=crop", "Milk", 20, 80 },
                    { 4, 3, "https://images.unsplash.com/photo-1509440159596-0249088772ff?w=400&h=400&fit=crop", "Bread", 25, 50 },
                    { 5, 2, "https://images.unsplash.com/photo-1585590954945-f8e1ef4f1f4e?w=400&h=400&fit=crop", "Eggs", 40, 200 },
                    { 6, 5, "https://images.unsplash.com/photo-1586190936819-754668823f66?w=400&h=400&fit=crop", "Rice", 30, 100 },
                    { 7, 4, "https://images.unsplash.com/photo-1598103442097-8b74394b95c6?w=400&h=400&fit=crop", "Chicken Breast", 15, 75 },
                    { 8, 5, "https://images.unsplash.com/photo-1621996346565-e3dbc646d9a9?w=400&h=400&fit=crop", "Pasta", 35, 90 }
                });

            migrationBuilder.InsertData(
                table: "Shipments",
                columns: new[] { "Id", "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25, "1001" },
                    { 2, new DateTime(2026, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 60, "1002" },
                    { 3, new DateTime(2026, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 50, "2001" },
                    { 4, new DateTime(2026, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 70, "2002" },
                    { 5, new DateTime(2026, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 40, "3001" },
                    { 6, new DateTime(2026, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 40, "3002" },
                    { 7, new DateTime(2026, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20, "4001" },
                    { 8, new DateTime(2026, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 30, "4002" },
                    { 9, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 100, "5001" },
                    { 10, new DateTime(2026, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 100, "5002" },
                    { 11, new DateTime(2027, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 50, "6001" },
                    { 12, new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 50, "6002" },
                    { 13, new DateTime(2026, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 40, "7001" },
                    { 14, new DateTime(2026, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 35, "7002" },
                    { 15, new DateTime(2027, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 50, "8001" },
                    { 16, new DateTime(2027, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 40, "8002" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_ProductId",
                table: "Shipments",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shipments");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
