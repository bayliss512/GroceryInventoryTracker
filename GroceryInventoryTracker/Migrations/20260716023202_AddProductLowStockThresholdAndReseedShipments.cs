using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GroceryInventoryTracker.Migrations
{
    /// <inheritdoc />
    public partial class AddProductLowStockThresholdAndReseedShipments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LowStockThreshold",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 210,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 211,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 212,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 213,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 214,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 215,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 216,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 217,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 218,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 219,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 220,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 221,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 222,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 223,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 224,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 225,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 226,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 227,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 228,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 229,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 230,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 231,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 232,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 233,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 234,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 235,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 236,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 237,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 238,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 239,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 240,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 241,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 242,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 243,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 244,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 245,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 246,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 247,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 248,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 249,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 250,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 251,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 252,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 253,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 254,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 255,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 256,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 257,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 258,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 259,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 260,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 261,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 262,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 263,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 264,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 265,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 266,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 267,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 268,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 269,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 270,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 271,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 272,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 273,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 274,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 275,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 276,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 277,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 278,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 279,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 280,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 281,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 282,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 283,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 284,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 285,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 286,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 287,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 288,
                column: "LowStockThreshold",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "Location", "Quantity" },
                values: new object[] { new DateTime(2026, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 0 });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "Location", "Quantity" },
                values: new object[] { new DateTime(2026, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 0 });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpirationDate", "Location", "Quantity" },
                values: new object[] { new DateTime(2026, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 10 });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 5, "SHP-003-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 4, 33, "SHP-004-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 4, 38, "SHP-004-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExpirationDate", "Location", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 60, "SHP-004-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 5, 40, "SHP-005-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 22, "SHP-005-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 51, "SHP-006-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 6, 27, "SHP-006-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ExpirationDate", "Location", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 85, "SHP-006-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 76, "SHP-007-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ExpirationDate", "Location", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 92, "SHP-007-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 8, 34, "SHP-008-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ExpirationDate", "Location", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 44, "SHP-008-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ExpirationDate", "Location", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 85, "SHP-008-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ExpirationDate", "Location", "Quantity" },
                values: new object[] { new DateTime(2026, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 84 });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ExpirationDate", "Quantity" },
                values: new object[] { new DateTime(2026, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ExpirationDate", "Quantity" },
                values: new object[] { new DateTime(2026, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ExpirationDate", "Quantity" },
                values: new object[] { new DateTime(2026, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 70 });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ExpirationDate", "Location", "Quantity" },
                values: new object[] { new DateTime(2027, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 39 });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ExpirationDate", "Quantity" },
                values: new object[] { new DateTime(2026, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ExpirationDate", "Location", "Quantity" },
                values: new object[] { new DateTime(2027, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 0 });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 12, "SHP-012-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 13, 1, "SHP-013-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 14, 70, "SHP-014-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 21, "SHP-014-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 14, 41, "SHP-014-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 25, "SHP-015-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 20, "SHP-015-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 55, "SHP-015-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 20, "SHP-016-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 21, "SHP-016-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 17, 72, "SHP-017-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 17, 93, "SHP-017-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 18, 50, "SHP-018-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 23, "SHP-018-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 54, "SHP-019-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 62, "SHP-019-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 92, "SHP-020-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 20, 78, "SHP-020-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 0, "SHP-021-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 0, "SHP-021-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 14, "SHP-022-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 2, "SHP-023-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 82, "SHP-024-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 24, 30, "SHP-024-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 61, "SHP-025-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 81, "SHP-025-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 77, "SHP-025-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 99, "SHP-026-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 21, "SHP-026-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 94, "SHP-026-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 41, "SHP-027-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 37, "SHP-027-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 27, "SHP-028-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 28, 29, "SHP-028-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 45, "SHP-029-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 86, "SHP-029-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 30, 87, "SHP-030-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 39, "SHP-030-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 31, 0, "SHP-031-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 31, 0, "SHP-031-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 13, "SHP-032-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 33, 4, "SHP-033-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 22, "SHP-034-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 34, 94, "SHP-034-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 30, "SHP-035-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 35, 34, "SHP-035-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 35, 64, "SHP-035-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 29, "SHP-036-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 36, 51, "SHP-036-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 36, 55, "SHP-036-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 57, "SHP-037-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 37, 95, "SHP-037-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 30, "SHP-037-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 38, 34, "SHP-038-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 77, "SHP-038-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 39, 52, "SHP-039-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 92, "SHP-039-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 91, "SHP-039-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 63, "SHP-040-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 40, 95, "SHP-040-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 0, "SHP-041-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 41, 0, "SHP-041-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 42, 10, "SHP-042-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 5, "SHP-043-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 44, 35, "SHP-044-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 44, 38, "SHP-044-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 44, 71, "SHP-044-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 84, "SHP-045-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 82, "SHP-045-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 57, "SHP-046-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 97, "SHP-046-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 67, "SHP-046-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 47, 60, "SHP-047-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 28, "SHP-047-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 47, "SHP-047-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 48, 36, "SHP-048-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 83, "SHP-048-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 35, "SHP-048-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 24, "SHP-049-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 49, 45, "SHP-049-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 41, "SHP-050-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 50, 57, "SHP-050-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 51, 0, "SHP-051-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, 13, "SHP-052-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 53, 7, "SHP-053-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, 34, "SHP-054-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 54, 67, "SHP-054-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 55, 96, "SHP-055-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 55, 57, "SHP-055-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 56, 93, "SHP-056-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 56, 91, "SHP-056-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, 66, "SHP-057-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, 91, "SHP-057-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 58, 72, "SHP-058-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2027, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 58, 43, "SHP-058-02" });

            migrationBuilder.InsertData(
                table: "Shipments",
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber", "SupplierId" },
                values: new object[,]
                {
                    { 120, new DateTime(2025, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 58, 80, "SHP-058-03", null },
                    { 121, new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 59, 72, "SHP-059-01", null },
                    { 122, new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 59, 74, "SHP-059-02", null },
                    { 123, new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 60, 47, "SHP-060-01", null },
                    { 124, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 60, 68, "SHP-060-02", null },
                    { 125, new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 61, 0, "SHP-061-01", null },
                    { 126, new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 61, 0, "SHP-061-02", null },
                    { 127, new DateTime(2025, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 62, 2, "SHP-062-01", null },
                    { 128, new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 63, 17, "SHP-063-01", null },
                    { 129, new DateTime(2025, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 64, 48, "SHP-064-01", null },
                    { 130, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 64, 66, "SHP-064-02", null },
                    { 131, new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 64, 32, "SHP-064-03", null },
                    { 132, new DateTime(2025, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 65, 28, "SHP-065-01", null },
                    { 133, new DateTime(2025, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 65, 34, "SHP-065-02", null },
                    { 134, new DateTime(2025, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 65, 35, "SHP-065-03", null },
                    { 135, new DateTime(2025, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 66, 88, "SHP-066-01", null },
                    { 136, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 66, 69, "SHP-066-02", null },
                    { 137, new DateTime(2025, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 66, 54, "SHP-066-03", null },
                    { 138, new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 67, 64, "SHP-067-01", null },
                    { 139, new DateTime(2025, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 67, 73, "SHP-067-02", null },
                    { 140, new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 67, 72, "SHP-067-03", null },
                    { 141, new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 68, 38, "SHP-068-01", null },
                    { 142, new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 68, 63, "SHP-068-02", null },
                    { 143, new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 68, 75, "SHP-068-03", null },
                    { 144, new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 69, 80, "SHP-069-01", null },
                    { 145, new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 69, 99, "SHP-069-02", null },
                    { 146, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 69, 88, "SHP-069-03", null },
                    { 147, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 70, 53, "SHP-070-01", null },
                    { 148, new DateTime(2025, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 70, 65, "SHP-070-02", null },
                    { 149, new DateTime(2025, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 71, 0, "SHP-071-01", null },
                    { 150, new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 72, 9, "SHP-072-01", null },
                    { 151, new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 73, 10, "SHP-073-01", null },
                    { 152, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 74, 27, "SHP-074-01", null },
                    { 153, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 74, 83, "SHP-074-02", null },
                    { 154, new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 75, 95, "SHP-075-01", null },
                    { 155, new DateTime(2025, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 75, 36, "SHP-075-02", null },
                    { 156, new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 75, 90, "SHP-075-03", null },
                    { 157, new DateTime(2025, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 76, 87, "SHP-076-01", null },
                    { 158, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 76, 45, "SHP-076-02", null },
                    { 159, new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 76, 28, "SHP-076-03", null },
                    { 160, new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 77, 93, "SHP-077-01", null },
                    { 161, new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 77, 32, "SHP-077-02", null },
                    { 162, new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 77, 30, "SHP-077-03", null },
                    { 163, new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 78, 20, "SHP-078-01", null },
                    { 164, new DateTime(2025, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 78, 21, "SHP-078-02", null },
                    { 165, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 79, 86, "SHP-079-01", null },
                    { 166, new DateTime(2025, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 79, 51, "SHP-079-02", null },
                    { 167, new DateTime(2025, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 79, 30, "SHP-079-03", null },
                    { 168, new DateTime(2025, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 80, 63, "SHP-080-01", null },
                    { 169, new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 80, 20, "SHP-080-02", null },
                    { 170, new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 81, 0, "SHP-081-01", null },
                    { 171, new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 82, 15, "SHP-082-01", null },
                    { 172, new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 83, 14, "SHP-083-01", null },
                    { 173, new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 84, 91, "SHP-084-01", null },
                    { 174, new DateTime(2025, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 84, 52, "SHP-084-02", null },
                    { 175, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 84, 83, "SHP-084-03", null },
                    { 176, new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 85, 84, "SHP-085-01", null },
                    { 177, new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 85, 27, "SHP-085-02", null },
                    { 178, new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 85, 94, "SHP-085-03", null },
                    { 179, new DateTime(2025, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 86, 76, "SHP-086-01", null },
                    { 180, new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 86, 84, "SHP-086-02", null },
                    { 181, new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 87, 92, "SHP-087-01", null },
                    { 182, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 87, 41, "SHP-087-02", null },
                    { 183, new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 88, 66, "SHP-088-01", null },
                    { 184, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 88, 93, "SHP-088-02", null },
                    { 185, new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 89, 47, "SHP-089-01", null },
                    { 186, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 89, 51, "SHP-089-02", null },
                    { 187, new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 89, 98, "SHP-089-03", null },
                    { 188, new DateTime(2025, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 90, 60, "SHP-090-01", null },
                    { 189, new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 90, 22, "SHP-090-02", null },
                    { 190, new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 90, 72, "SHP-090-03", null },
                    { 191, new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 91, 0, "SHP-091-01", null },
                    { 192, new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 92, 15, "SHP-092-01", null },
                    { 193, new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 93, 3, "SHP-093-01", null },
                    { 194, new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 94, 65, "SHP-094-01", null },
                    { 195, new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 94, 76, "SHP-094-02", null },
                    { 196, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 95, 58, "SHP-095-01", null },
                    { 197, new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 95, 62, "SHP-095-02", null },
                    { 198, new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 95, 42, "SHP-095-03", null },
                    { 199, new DateTime(2025, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 96, 90, "SHP-096-01", null },
                    { 200, new DateTime(2025, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 96, 45, "SHP-096-02", null },
                    { 201, new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 96, 52, "SHP-096-03", null },
                    { 202, new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 97, 24, "SHP-097-01", null },
                    { 203, new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 97, 56, "SHP-097-02", null },
                    { 204, new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 97, 82, "SHP-097-03", null },
                    { 205, new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 98, 90, "SHP-098-01", null },
                    { 206, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 98, 69, "SHP-098-02", null },
                    { 207, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 99, 81, "SHP-099-01", null },
                    { 208, new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 99, 74, "SHP-099-02", null },
                    { 209, new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 100, 31, "SHP-100-01", null },
                    { 210, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 100, 28, "SHP-100-02", null },
                    { 211, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 101, 0, "SHP-101-01", null },
                    { 212, new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 101, 0, "SHP-101-02", null },
                    { 213, new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 102, 14, "SHP-102-01", null },
                    { 214, new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 103, 12, "SHP-103-01", null },
                    { 215, new DateTime(2025, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 104, 85, "SHP-104-01", null },
                    { 216, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 104, 47, "SHP-104-02", null },
                    { 217, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 105, 52, "SHP-105-01", null },
                    { 218, new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 105, 28, "SHP-105-02", null },
                    { 219, new DateTime(2025, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 106, 50, "SHP-106-01", null },
                    { 220, new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 106, 68, "SHP-106-02", null },
                    { 221, new DateTime(2025, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 106, 92, "SHP-106-03", null },
                    { 222, new DateTime(2025, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 107, 28, "SHP-107-01", null },
                    { 223, new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 107, 36, "SHP-107-02", null },
                    { 224, new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 107, 95, "SHP-107-03", null },
                    { 225, new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 108, 77, "SHP-108-01", null },
                    { 226, new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 108, 63, "SHP-108-02", null },
                    { 227, new DateTime(2025, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 109, 32, "SHP-109-01", null },
                    { 228, new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 109, 41, "SHP-109-02", null },
                    { 229, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 109, 61, "SHP-109-03", null },
                    { 230, new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 110, 42, "SHP-110-01", null },
                    { 231, new DateTime(2025, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 110, 58, "SHP-110-02", null },
                    { 232, new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 110, 29, "SHP-110-03", null },
                    { 233, new DateTime(2025, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 111, 0, "SHP-111-01", null },
                    { 234, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 112, 14, "SHP-112-01", null },
                    { 235, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 113, 17, "SHP-113-01", null },
                    { 236, new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 114, 23, "SHP-114-01", null },
                    { 237, new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 114, 23, "SHP-114-02", null },
                    { 238, new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 115, 73, "SHP-115-01", null },
                    { 239, new DateTime(2025, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 115, 88, "SHP-115-02", null },
                    { 240, new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 115, 65, "SHP-115-03", null },
                    { 241, new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 116, 26, "SHP-116-01", null },
                    { 242, new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 116, 99, "SHP-116-02", null },
                    { 243, new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 116, 29, "SHP-116-03", null },
                    { 244, new DateTime(2025, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 117, 32, "SHP-117-01", null },
                    { 245, new DateTime(2025, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 117, 32, "SHP-117-02", null },
                    { 246, new DateTime(2025, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 118, 54, "SHP-118-01", null },
                    { 247, new DateTime(2025, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 118, 60, "SHP-118-02", null },
                    { 248, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 118, 90, "SHP-118-03", null },
                    { 249, new DateTime(2025, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 119, 58, "SHP-119-01", null },
                    { 250, new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 119, 22, "SHP-119-02", null },
                    { 251, new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 120, 66, "SHP-120-01", null },
                    { 252, new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 120, 92, "SHP-120-02", null },
                    { 253, new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 121, 0, "SHP-121-01", null },
                    { 254, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 122, 5, "SHP-122-01", null },
                    { 255, new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 123, 12, "SHP-123-01", null },
                    { 256, new DateTime(2025, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 124, 23, "SHP-124-01", null },
                    { 257, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 124, 93, "SHP-124-02", null },
                    { 258, new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 125, 84, "SHP-125-01", null },
                    { 259, new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 125, 35, "SHP-125-02", null },
                    { 260, new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 126, 53, "SHP-126-01", null },
                    { 261, new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 126, 59, "SHP-126-02", null },
                    { 262, new DateTime(2025, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 127, 98, "SHP-127-01", null },
                    { 263, new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 127, 36, "SHP-127-02", null },
                    { 264, new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 128, 23, "SHP-128-01", null },
                    { 265, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 128, 75, "SHP-128-02", null },
                    { 266, new DateTime(2025, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 129, 49, "SHP-129-01", null },
                    { 267, new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 129, 75, "SHP-129-02", null },
                    { 268, new DateTime(2025, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 130, 23, "SHP-130-01", null },
                    { 269, new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 130, 40, "SHP-130-02", null },
                    { 270, new DateTime(2025, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 130, 56, "SHP-130-03", null },
                    { 271, new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 131, 0, "SHP-131-01", null },
                    { 272, new DateTime(2025, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 131, 0, "SHP-131-02", null },
                    { 273, new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 132, 13, "SHP-132-01", null },
                    { 274, new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 133, 17, "SHP-133-01", null },
                    { 275, new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 134, 33, "SHP-134-01", null },
                    { 276, new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 134, 53, "SHP-134-02", null },
                    { 277, new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 135, 85, "SHP-135-01", null },
                    { 278, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 135, 52, "SHP-135-02", null },
                    { 279, new DateTime(2025, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 136, 20, "SHP-136-01", null },
                    { 280, new DateTime(2025, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 136, 62, "SHP-136-02", null },
                    { 281, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 136, 67, "SHP-136-03", null },
                    { 282, new DateTime(2025, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 137, 35, "SHP-137-01", null },
                    { 283, new DateTime(2025, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 137, 96, "SHP-137-02", null },
                    { 284, new DateTime(2025, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 137, 49, "SHP-137-03", null },
                    { 285, new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 138, 76, "SHP-138-01", null },
                    { 286, new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 138, 20, "SHP-138-02", null },
                    { 287, new DateTime(2025, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 139, 79, "SHP-139-01", null },
                    { 288, new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 139, 35, "SHP-139-02", null },
                    { 289, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 139, 69, "SHP-139-03", null },
                    { 290, new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 140, 96, "SHP-140-01", null },
                    { 291, new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 140, 49, "SHP-140-02", null },
                    { 292, new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 140, 33, "SHP-140-03", null },
                    { 293, new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 141, 0, "SHP-141-01", null },
                    { 294, new DateTime(2025, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 141, 0, "SHP-141-02", null },
                    { 295, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 142, 12, "SHP-142-01", null },
                    { 296, new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 143, 15, "SHP-143-01", null },
                    { 297, new DateTime(2025, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 144, 27, "SHP-144-01", null },
                    { 298, new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 144, 27, "SHP-144-02", null },
                    { 299, new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 144, 92, "SHP-144-03", null },
                    { 300, new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 145, 96, "SHP-145-01", null },
                    { 301, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 145, 73, "SHP-145-02", null },
                    { 302, new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 145, 39, "SHP-145-03", null },
                    { 303, new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 146, 26, "SHP-146-01", null },
                    { 304, new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 146, 80, "SHP-146-02", null },
                    { 305, new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 147, 96, "SHP-147-01", null },
                    { 306, new DateTime(2025, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 147, 24, "SHP-147-02", null },
                    { 307, new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 147, 29, "SHP-147-03", null },
                    { 308, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 148, 59, "SHP-148-01", null },
                    { 309, new DateTime(2025, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 148, 54, "SHP-148-02", null },
                    { 310, new DateTime(2025, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 148, 76, "SHP-148-03", null },
                    { 311, new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 149, 53, "SHP-149-01", null },
                    { 312, new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 149, 44, "SHP-149-02", null },
                    { 313, new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 150, 77, "SHP-150-01", null },
                    { 314, new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 150, 77, "SHP-150-02", null },
                    { 315, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 151, 0, "SHP-151-01", null },
                    { 316, new DateTime(2025, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 151, 0, "SHP-151-02", null },
                    { 317, new DateTime(2025, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 152, 18, "SHP-152-01", null },
                    { 318, new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 153, 9, "SHP-153-01", null },
                    { 319, new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 154, 86, "SHP-154-01", null },
                    { 320, new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 154, 27, "SHP-154-02", null },
                    { 321, new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 155, 22, "SHP-155-01", null },
                    { 322, new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 155, 98, "SHP-155-02", null },
                    { 323, new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 155, 49, "SHP-155-03", null },
                    { 324, new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 156, 61, "SHP-156-01", null },
                    { 325, new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 156, 96, "SHP-156-02", null },
                    { 326, new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 156, 28, "SHP-156-03", null },
                    { 327, new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 157, 81, "SHP-157-01", null },
                    { 328, new DateTime(2025, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 157, 79, "SHP-157-02", null },
                    { 329, new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 157, 94, "SHP-157-03", null },
                    { 330, new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 158, 60, "SHP-158-01", null },
                    { 331, new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 158, 44, "SHP-158-02", null },
                    { 332, new DateTime(2025, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 158, 49, "SHP-158-03", null },
                    { 333, new DateTime(2025, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 159, 37, "SHP-159-01", null },
                    { 334, new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 159, 73, "SHP-159-02", null },
                    { 335, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 159, 77, "SHP-159-03", null },
                    { 336, new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 160, 76, "SHP-160-01", null },
                    { 337, new DateTime(2025, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 160, 75, "SHP-160-02", null },
                    { 338, new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 160, 53, "SHP-160-03", null },
                    { 339, new DateTime(2025, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 161, 0, "SHP-161-01", null },
                    { 340, new DateTime(2025, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 162, 15, "SHP-162-01", null },
                    { 341, new DateTime(2025, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 163, 16, "SHP-163-01", null },
                    { 342, new DateTime(2025, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 164, 67, "SHP-164-01", null },
                    { 343, new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 164, 27, "SHP-164-02", null },
                    { 344, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 164, 32, "SHP-164-03", null },
                    { 345, new DateTime(2025, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 165, 62, "SHP-165-01", null },
                    { 346, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 165, 73, "SHP-165-02", null },
                    { 347, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 165, 99, "SHP-165-03", null },
                    { 348, new DateTime(2025, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 166, 44, "SHP-166-01", null },
                    { 349, new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 166, 43, "SHP-166-02", null },
                    { 350, new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 167, 50, "SHP-167-01", null },
                    { 351, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 167, 25, "SHP-167-02", null },
                    { 352, new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 168, 88, "SHP-168-01", null },
                    { 353, new DateTime(2025, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 168, 50, "SHP-168-02", null },
                    { 354, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 169, 48, "SHP-169-01", null },
                    { 355, new DateTime(2025, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 169, 23, "SHP-169-02", null },
                    { 356, new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 169, 48, "SHP-169-03", null },
                    { 357, new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 170, 34, "SHP-170-01", null },
                    { 358, new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 170, 99, "SHP-170-02", null },
                    { 359, new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 170, 75, "SHP-170-03", null },
                    { 360, new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 171, 0, "SHP-171-01", null },
                    { 361, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 172, 5, "SHP-172-01", null },
                    { 362, new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 173, 3, "SHP-173-01", null },
                    { 363, new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 174, 24, "SHP-174-01", null },
                    { 364, new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 174, 86, "SHP-174-02", null },
                    { 365, new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 175, 62, "SHP-175-01", null },
                    { 366, new DateTime(2025, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 175, 93, "SHP-175-02", null },
                    { 367, new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 175, 98, "SHP-175-03", null },
                    { 368, new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 176, 72, "SHP-176-01", null },
                    { 369, new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 176, 30, "SHP-176-02", null },
                    { 370, new DateTime(2025, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 176, 52, "SHP-176-03", null },
                    { 371, new DateTime(2025, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 177, 28, "SHP-177-01", null },
                    { 372, new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 177, 53, "SHP-177-02", null },
                    { 373, new DateTime(2025, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 177, 53, "SHP-177-03", null },
                    { 374, new DateTime(2025, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 178, 25, "SHP-178-01", null },
                    { 375, new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 178, 31, "SHP-178-02", null },
                    { 376, new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 178, 59, "SHP-178-03", null },
                    { 377, new DateTime(2025, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 179, 31, "SHP-179-01", null },
                    { 378, new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 179, 92, "SHP-179-02", null },
                    { 379, new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 179, 68, "SHP-179-03", null },
                    { 380, new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 180, 64, "SHP-180-01", null },
                    { 381, new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 180, 31, "SHP-180-02", null },
                    { 382, new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 180, 47, "SHP-180-03", null },
                    { 383, new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 181, 0, "SHP-181-01", null },
                    { 384, new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 182, 2, "SHP-182-01", null },
                    { 385, new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 183, 17, "SHP-183-01", null },
                    { 386, new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 184, 63, "SHP-184-01", null },
                    { 387, new DateTime(2025, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 184, 71, "SHP-184-02", null },
                    { 388, new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 185, 66, "SHP-185-01", null },
                    { 389, new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 185, 57, "SHP-185-02", null },
                    { 390, new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 186, 40, "SHP-186-01", null },
                    { 391, new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 186, 43, "SHP-186-02", null },
                    { 392, new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 186, 60, "SHP-186-03", null },
                    { 393, new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 187, 48, "SHP-187-01", null },
                    { 394, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 187, 43, "SHP-187-02", null },
                    { 395, new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 188, 84, "SHP-188-01", null },
                    { 396, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 188, 66, "SHP-188-02", null },
                    { 397, new DateTime(2025, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 188, 29, "SHP-188-03", null },
                    { 398, new DateTime(2025, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 189, 83, "SHP-189-01", null },
                    { 399, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 189, 95, "SHP-189-02", null },
                    { 400, new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 189, 30, "SHP-189-03", null },
                    { 401, new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 190, 30, "SHP-190-01", null },
                    { 402, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 190, 86, "SHP-190-02", null },
                    { 403, new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 190, 51, "SHP-190-03", null },
                    { 404, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 191, 0, "SHP-191-01", null },
                    { 405, new DateTime(2025, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 191, 0, "SHP-191-02", null },
                    { 406, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 192, 8, "SHP-192-01", null },
                    { 407, new DateTime(2025, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 193, 13, "SHP-193-01", null },
                    { 408, new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 194, 86, "SHP-194-01", null },
                    { 409, new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 194, 24, "SHP-194-02", null },
                    { 410, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 194, 29, "SHP-194-03", null },
                    { 411, new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 195, 49, "SHP-195-01", null },
                    { 412, new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 195, 47, "SHP-195-02", null },
                    { 413, new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 195, 54, "SHP-195-03", null },
                    { 414, new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 196, 57, "SHP-196-01", null },
                    { 415, new DateTime(2025, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 196, 65, "SHP-196-02", null },
                    { 416, new DateTime(2025, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 196, 90, "SHP-196-03", null },
                    { 417, new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 197, 47, "SHP-197-01", null },
                    { 418, new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 197, 81, "SHP-197-02", null },
                    { 419, new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 197, 78, "SHP-197-03", null },
                    { 420, new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 198, 50, "SHP-198-01", null },
                    { 421, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 198, 21, "SHP-198-02", null },
                    { 422, new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 198, 29, "SHP-198-03", null },
                    { 423, new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 199, 85, "SHP-199-01", null },
                    { 424, new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 199, 69, "SHP-199-02", null },
                    { 425, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 199, 36, "SHP-199-03", null },
                    { 426, new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 200, 57, "SHP-200-01", null },
                    { 427, new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 200, 64, "SHP-200-02", null },
                    { 428, new DateTime(2025, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 200, 64, "SHP-200-03", null },
                    { 429, new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 201, 0, "SHP-201-01", null },
                    { 430, new DateTime(2025, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 201, 0, "SHP-201-02", null },
                    { 431, new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 202, 18, "SHP-202-01", null },
                    { 432, new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 203, 12, "SHP-203-01", null },
                    { 433, new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 204, 96, "SHP-204-01", null },
                    { 434, new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 204, 51, "SHP-204-02", null },
                    { 435, new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 205, 97, "SHP-205-01", null },
                    { 436, new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 205, 37, "SHP-205-02", null },
                    { 437, new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 206, 44, "SHP-206-01", null },
                    { 438, new DateTime(2025, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 206, 94, "SHP-206-02", null },
                    { 439, new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 207, 95, "SHP-207-01", null },
                    { 440, new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 207, 74, "SHP-207-02", null },
                    { 441, new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 208, 89, "SHP-208-01", null },
                    { 442, new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 208, 36, "SHP-208-02", null },
                    { 443, new DateTime(2025, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 209, 73, "SHP-209-01", null },
                    { 444, new DateTime(2025, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 209, 83, "SHP-209-02", null },
                    { 445, new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 210, 73, "SHP-210-01", null },
                    { 446, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 210, 53, "SHP-210-02", null },
                    { 447, new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 211, 0, "SHP-211-01", null },
                    { 448, new DateTime(2025, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 211, 0, "SHP-211-02", null },
                    { 449, new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 212, 12, "SHP-212-01", null },
                    { 450, new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 213, 17, "SHP-213-01", null },
                    { 451, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 214, 33, "SHP-214-01", null },
                    { 452, new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 214, 72, "SHP-214-02", null },
                    { 453, new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 215, 92, "SHP-215-01", null },
                    { 454, new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 215, 89, "SHP-215-02", null },
                    { 455, new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 216, 62, "SHP-216-01", null },
                    { 456, new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 216, 69, "SHP-216-02", null },
                    { 457, new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 217, 56, "SHP-217-01", null },
                    { 458, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 217, 71, "SHP-217-02", null },
                    { 459, new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 218, 86, "SHP-218-01", null },
                    { 460, new DateTime(2025, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 218, 46, "SHP-218-02", null },
                    { 461, new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 219, 57, "SHP-219-01", null },
                    { 462, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 219, 87, "SHP-219-02", null },
                    { 463, new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 220, 83, "SHP-220-01", null },
                    { 464, new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 220, 37, "SHP-220-02", null },
                    { 465, new DateTime(2025, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 220, 88, "SHP-220-03", null },
                    { 466, new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 221, 0, "SHP-221-01", null },
                    { 467, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 222, 12, "SHP-222-01", null },
                    { 468, new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OnFloor", 223, 13, "SHP-223-01", null },
                    { 469, new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OnFloor", 224, 66, "SHP-224-01", null },
                    { 470, new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OnFloor", 224, 74, "SHP-224-02", null },
                    { 471, new DateTime(2025, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OnFloor", 225, 60, "SHP-225-01", null },
                    { 472, new DateTime(2025, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 225, 53, "SHP-225-02", null },
                    { 473, new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OnFloor", 225, 30, "SHP-225-03", null },
                    { 474, new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 226, 98, "SHP-226-01", null },
                    { 475, new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OnFloor", 226, 88, "SHP-226-02", null },
                    { 476, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 227, 28, "SHP-227-01", null },
                    { 477, new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 227, 31, "SHP-227-02", null },
                    { 478, new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 227, 44, "SHP-227-03", null },
                    { 479, new DateTime(2025, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 228, 99, "SHP-228-01", null },
                    { 480, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 228, 53, "SHP-228-02", null },
                    { 481, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 228, 94, "SHP-228-03", null },
                    { 482, new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 229, 63, "SHP-229-01", null },
                    { 483, new DateTime(2025, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OnFloor", 229, 86, "SHP-229-02", null },
                    { 484, new DateTime(2025, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OnFloor", 230, 64, "SHP-230-01", null },
                    { 485, new DateTime(2025, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 230, 89, "SHP-230-02", null },
                    { 486, new DateTime(2025, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 230, 96, "SHP-230-03", null },
                    { 487, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 231, 0, "SHP-231-01", null },
                    { 488, new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OnFloor", 231, 0, "SHP-231-02", null },
                    { 489, new DateTime(2025, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OnFloor", 232, 4, "SHP-232-01", null },
                    { 490, new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 233, 9, "SHP-233-01", null },
                    { 491, new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 234, 99, "SHP-234-01", null },
                    { 492, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 234, 47, "SHP-234-02", null },
                    { 493, new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 234, 30, "SHP-234-03", null },
                    { 494, new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OnFloor", 235, 33, "SHP-235-01", null },
                    { 495, new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 235, 89, "SHP-235-02", null },
                    { 496, new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 235, 66, "SHP-235-03", null },
                    { 497, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 236, 75, "SHP-236-01", null },
                    { 498, new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 236, 28, "SHP-236-02", null },
                    { 499, new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 237, 24, "SHP-237-01", null },
                    { 500, new DateTime(2025, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 237, 98, "SHP-237-02", null },
                    { 501, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 238, 35, "SHP-238-01", null },
                    { 502, new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 238, 80, "SHP-238-02", null },
                    { 503, new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OnFloor", 238, 90, "SHP-238-03", null },
                    { 504, new DateTime(2025, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OnFloor", 239, 97, "SHP-239-01", null },
                    { 505, new DateTime(2025, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 239, 45, "SHP-239-02", null },
                    { 506, new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OnFloor", 240, 36, "SHP-240-01", null },
                    { 507, new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 240, 76, "SHP-240-02", null },
                    { 508, new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 241, 0, "SHP-241-01", null },
                    { 509, new DateTime(2025, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 242, 15, "SHP-242-01", null },
                    { 510, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 243, 5, "SHP-243-01", null },
                    { 511, new DateTime(2025, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 244, 48, "SHP-244-01", null },
                    { 512, new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 244, 67, "SHP-244-02", null },
                    { 513, new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "InStorage", 244, 79, "SHP-244-03", null },
                    { 514, new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 245, 59, "SHP-245-01", null },
                    { 515, new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 245, 97, "SHP-245-02", null },
                    { 516, new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 246, 99, "SHP-246-01", null },
                    { 517, new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 246, 54, "SHP-246-02", null },
                    { 518, new DateTime(2025, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 247, 74, "SHP-247-01", null },
                    { 519, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 247, 84, "SHP-247-02", null },
                    { 520, new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 248, 57, "SHP-248-01", null },
                    { 521, new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 248, 32, "SHP-248-02", null },
                    { 522, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 249, 94, "SHP-249-01", null },
                    { 523, new DateTime(2025, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 249, 36, "SHP-249-02", null },
                    { 524, new DateTime(2025, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 249, 77, "SHP-249-03", null },
                    { 525, new DateTime(2025, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 250, 51, "SHP-250-01", null },
                    { 526, new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 250, 42, "SHP-250-02", null },
                    { 527, new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 250, 55, "SHP-250-03", null },
                    { 528, new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 251, 0, "SHP-251-01", null },
                    { 529, new DateTime(2025, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 252, 2, "SHP-252-01", null },
                    { 530, new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 253, 16, "SHP-253-01", null },
                    { 531, new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 254, 97, "SHP-254-01", null },
                    { 532, new DateTime(2025, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 254, 27, "SHP-254-02", null },
                    { 533, new DateTime(2025, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 254, 46, "SHP-254-03", null },
                    { 534, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 255, 54, "SHP-255-01", null },
                    { 535, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 255, 92, "SHP-255-02", null },
                    { 536, new DateTime(2025, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 255, 96, "SHP-255-03", null },
                    { 537, new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 256, 54, "SHP-256-01", null },
                    { 538, new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 256, 84, "SHP-256-02", null },
                    { 539, new DateTime(2025, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 257, 49, "SHP-257-01", null },
                    { 540, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 257, 30, "SHP-257-02", null },
                    { 541, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 257, 20, "SHP-257-03", null },
                    { 542, new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 258, 31, "SHP-258-01", null },
                    { 543, new DateTime(2025, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 258, 47, "SHP-258-02", null },
                    { 544, new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 259, 99, "SHP-259-01", null },
                    { 545, new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 259, 77, "SHP-259-02", null },
                    { 546, new DateTime(2025, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 260, 70, "SHP-260-01", null },
                    { 547, new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 260, 91, "SHP-260-02", null },
                    { 548, new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 261, 0, "SHP-261-01", null },
                    { 549, new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 262, 4, "SHP-262-01", null },
                    { 550, new DateTime(2025, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 263, 10, "SHP-263-01", null },
                    { 551, new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 264, 94, "SHP-264-01", null },
                    { 552, new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 264, 25, "SHP-264-02", null },
                    { 553, new DateTime(2025, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 265, 35, "SHP-265-01", null },
                    { 554, new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 265, 40, "SHP-265-02", null },
                    { 555, new DateTime(2025, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 265, 31, "SHP-265-03", null },
                    { 556, new DateTime(2025, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 266, 27, "SHP-266-01", null },
                    { 557, new DateTime(2025, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 266, 35, "SHP-266-02", null },
                    { 558, new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 267, 75, "SHP-267-01", null },
                    { 559, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 267, 65, "SHP-267-02", null },
                    { 560, new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 268, 36, "SHP-268-01", null },
                    { 561, new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 268, 44, "SHP-268-02", null },
                    { 562, new DateTime(2025, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 269, 31, "SHP-269-01", null },
                    { 563, new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 269, 97, "SHP-269-02", null },
                    { 564, new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 270, 72, "SHP-270-01", null },
                    { 565, new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 270, 37, "SHP-270-02", null },
                    { 566, new DateTime(2025, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 271, 0, "SHP-271-01", null },
                    { 567, new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 272, 14, "SHP-272-01", null },
                    { 568, new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 273, 19, "SHP-273-01", null },
                    { 569, new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 274, 25, "SHP-274-01", null },
                    { 570, new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 274, 32, "SHP-274-02", null },
                    { 571, new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 275, 23, "SHP-275-01", null },
                    { 572, new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 275, 20, "SHP-275-02", null },
                    { 573, new DateTime(2025, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 275, 81, "SHP-275-03", null },
                    { 574, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 276, 90, "SHP-276-01", null },
                    { 575, new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 276, 95, "SHP-276-02", null },
                    { 576, new DateTime(2025, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 276, 74, "SHP-276-03", null },
                    { 577, new DateTime(2025, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 277, 92, "SHP-277-01", null },
                    { 578, new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 277, 63, "SHP-277-02", null },
                    { 579, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 278, 20, "SHP-278-01", null },
                    { 580, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 278, 83, "SHP-278-02", null },
                    { 581, new DateTime(2025, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 278, 46, "SHP-278-03", null },
                    { 582, new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 279, 66, "SHP-279-01", null },
                    { 583, new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 279, 92, "SHP-279-02", null },
                    { 584, new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 279, 65, "SHP-279-03", null },
                    { 585, new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 280, 58, "SHP-280-01", null },
                    { 586, new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 280, 48, "SHP-280-02", null },
                    { 587, new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 281, 0, "SHP-281-01", null },
                    { 588, new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 282, 10, "SHP-282-01", null },
                    { 589, new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 283, 7, "SHP-283-01", null },
                    { 590, new DateTime(2025, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 284, 90, "SHP-284-01", null },
                    { 591, new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 284, 75, "SHP-284-02", null },
                    { 592, new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 285, 42, "SHP-285-01", null },
                    { 593, new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 285, 96, "SHP-285-02", null },
                    { 594, new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 285, 83, "SHP-285-03", null },
                    { 595, new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 286, 36, "SHP-286-01", null },
                    { 596, new DateTime(2025, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 286, 41, "SHP-286-02", null },
                    { 597, new DateTime(2025, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 287, 54, "SHP-287-01", null },
                    { 598, new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 287, 71, "SHP-287-02", null },
                    { 599, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 287, 82, "SHP-287-03", null },
                    { 600, new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 288, 32, "SHP-288-01", null },
                    { 601, new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 288, 92, "SHP-288-02", null },
                    { 602, new DateTime(2025, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 288, 89, "SHP-288-03", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DropColumn(
                name: "LowStockThreshold",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "Location", "Quantity" },
                values: new object[] { new DateTime(2026, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 21 });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "Location", "Quantity" },
                values: new object[] { new DateTime(2026, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 75 });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpirationDate", "Location", "Quantity" },
                values: new object[] { new DateTime(2026, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 33 });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 33, "SHP-002-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 3, 45, "SHP-003-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 3, 83, "SHP-003-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExpirationDate", "Location", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 91, "SHP-004-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 4, 13, "SHP-004-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 10, "SHP-004-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 23, "SHP-005-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 5, 66, "SHP-005-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ExpirationDate", "Location", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 68, "SHP-006-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 56, "SHP-006-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ExpirationDate", "Location", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 29, "SHP-007-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 7, 16, "SHP-007-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ExpirationDate", "Location", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 81, "SHP-008-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ExpirationDate", "Location", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 10, "SHP-008-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ExpirationDate", "Location", "Quantity" },
                values: new object[] { new DateTime(2026, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 68 });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ExpirationDate", "Quantity" },
                values: new object[] { new DateTime(2026, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ExpirationDate", "Quantity" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ExpirationDate", "Quantity" },
                values: new object[] { new DateTime(2026, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ExpirationDate", "Location", "Quantity" },
                values: new object[] { new DateTime(2026, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 76 });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ExpirationDate", "Quantity" },
                values: new object[] { new DateTime(2026, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ExpirationDate", "Location", "Quantity" },
                values: new object[] { new DateTime(2026, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 39 });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 29, "SHP-011-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 11, 78, "SHP-011-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 12, 99, "SHP-012-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 93, "SHP-012-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 13, 29, "SHP-013-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 99, "SHP-013-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 77, "SHP-014-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 85, "SHP-014-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 35, "SHP-015-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 27, "SHP-015-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 16, 94, "SHP-016-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 16, 89, "SHP-016-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 17, 74, "SHP-017-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 89, "SHP-017-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 58, "SHP-018-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 19, "SHP-018-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 46, "SHP-019-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 19, 91, "SHP-019-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 40, "SHP-019-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 77, "SHP-020-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 82, "SHP-020-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 27, "SHP-020-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 17, "SHP-021-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 21, 80, "SHP-021-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 90, "SHP-021-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 67, "SHP-022-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 82, "SHP-022-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 28, "SHP-022-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 94, "SHP-023-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 38, "SHP-023-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 52, "SHP-024-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 69, "SHP-024-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 26, "SHP-025-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 25, 44, "SHP-025-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 38, "SHP-026-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 11, "SHP-026-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 26, 90, "SHP-026-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 36, "SHP-027-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 27, 40, "SHP-027-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 28, 42, "SHP-028-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 67, "SHP-028-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 29, 22, "SHP-029-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 41, "SHP-029-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 29, 23, "SHP-029-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 26, "SHP-030-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 30, 68, "SHP-030-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 31, 48, "SHP-031-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 58, "SHP-031-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 32, 72, "SHP-032-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 32, 83, "SHP-032-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 50, "SHP-033-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 33, 13, "SHP-033-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 46, "SHP-034-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 34, 37, "SHP-034-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 18, "SHP-034-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 35, 94, "SHP-035-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 89, "SHP-035-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 55, "SHP-035-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 66, "SHP-036-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 36, 43, "SHP-036-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 68, "SHP-037-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 37, 84, "SHP-037-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 38, 81, "SHP-038-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 10, "SHP-038-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 39, 57, "SHP-039-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 39, 90, "SHP-039-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 40, 86, "SHP-040-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 18, "SHP-040-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 26, "SHP-040-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 49, "SHP-041-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 83, "SHP-041-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 92, "SHP-041-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 42, 45, "SHP-042-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 89, "SHP-042-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 59, "SHP-042-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 43, 77, "SHP-043-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 44, "SHP-043-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 34, "SHP-043-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 13, "SHP-044-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 44, 89, "SHP-044-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 84, "SHP-045-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 45, 50, "SHP-045-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 32, "SHP-045-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 51, "SHP-046-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 46, 35, "SHP-046-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 54, "SHP-047-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 47, 71, "SHP-047-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 47, 41, "SHP-047-03" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 48, 35, "SHP-048-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 22, "SHP-048-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnFloor", 49, 52, "SHP-049-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 20, "SHP-049-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ExpirationDate", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 18, "SHP-050-01" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 50, 58, "SHP-050-02" });

            migrationBuilder.UpdateData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ExpirationDate", "Location", "ProductId", "Quantity", "ShipmentNumber" },
                values: new object[] { new DateTime(2026, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "InStorage", 50, 66, "SHP-050-03" });
        }
    }
}
