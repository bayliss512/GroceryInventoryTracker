using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroceryInventoryTracker.Migrations
{
    /// <inheritdoc />
    public partial class AddUserDarkModePreference : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "DarkModeEnabled",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DarkModeEnabled",
                table: "Users");
        }
    }
}
