using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroceryInventoryTracker.Migrations
{
    /// <inheritdoc />
    public partial class AddLocationToShipments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "InStorage");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Shipments");
        }
    }
}
