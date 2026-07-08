using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroceryInventoryTracker.Migrations
{
    /// <inheritdoc />
    public partial class RemoveQuantityColumnsFromProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantityOnSalesFloor",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "QuantityStored",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuantityStored",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuantityOnSalesFloor",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
