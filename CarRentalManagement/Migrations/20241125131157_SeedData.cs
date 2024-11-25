using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 25, 21, 11, 56, 700, DateTimeKind.Local).AddTicks(4940), new DateTime(2024, 11, 25, 21, 11, 56, 700, DateTimeKind.Local).AddTicks(4963), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 25, 21, 11, 56, 700, DateTimeKind.Local).AddTicks(4967), new DateTime(2024, 11, 25, 21, 11, 56, 700, DateTimeKind.Local).AddTicks(4968), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 25, 21, 11, 56, 700, DateTimeKind.Local).AddTicks(5290), new DateTime(2024, 11, 25, 21, 11, 56, 700, DateTimeKind.Local).AddTicks(5291), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 25, 21, 11, 56, 700, DateTimeKind.Local).AddTicks(5294), new DateTime(2024, 11, 25, 21, 11, 56, 700, DateTimeKind.Local).AddTicks(5295), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 25, 21, 11, 56, 700, DateTimeKind.Local).AddTicks(5414), new DateTime(2024, 11, 25, 21, 11, 56, 700, DateTimeKind.Local).AddTicks(5415), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 25, 21, 11, 56, 700, DateTimeKind.Local).AddTicks(5418), new DateTime(2024, 11, 25, 21, 11, 56, 700, DateTimeKind.Local).AddTicks(5419), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 25, 21, 11, 56, 700, DateTimeKind.Local).AddTicks(5421), new DateTime(2024, 11, 25, 21, 11, 56, 700, DateTimeKind.Local).AddTicks(5422), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 25, 21, 11, 56, 700, DateTimeKind.Local).AddTicks(5424), new DateTime(2024, 11, 25, 21, 11, 56, 700, DateTimeKind.Local).AddTicks(5425), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
