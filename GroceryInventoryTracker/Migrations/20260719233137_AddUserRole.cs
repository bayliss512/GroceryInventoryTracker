using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroceryInventoryTracker.Migrations
{
    /// <inheritdoc />
    public partial class AddUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            // Preserve existing admins (UserRole.Administrator = 2) before the old column is
            // dropped. Everyone else defaults to Guest (0), matching the new sign-up default.
            migrationBuilder.Sql("UPDATE [Users] SET [Role] = 2 WHERE [IsAdmin] = 1;");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.Sql("UPDATE [Users] SET [IsAdmin] = 1 WHERE [Role] = 2;");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");
        }
    }
}
