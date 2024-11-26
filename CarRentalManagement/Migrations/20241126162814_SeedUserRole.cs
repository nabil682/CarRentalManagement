using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "5bc44c7a-a080-4da3-beb2-3ea5009df6e0", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAENKKXUACOYndWMOD+sSAi568mgv6HLz1uhIsQtt7y4F2UbEXQr7VLNUf/6ZPl3lUNQ==", null, false, "2e42983e-29f9-4d84-a772-6e0f76ab4102", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 28, 13, 803, DateTimeKind.Local).AddTicks(5163), new DateTime(2024, 11, 27, 0, 28, 13, 803, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 28, 13, 803, DateTimeKind.Local).AddTicks(5174), new DateTime(2024, 11, 27, 0, 28, 13, 803, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 28, 13, 803, DateTimeKind.Local).AddTicks(5311), new DateTime(2024, 11, 27, 0, 28, 13, 803, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 28, 13, 803, DateTimeKind.Local).AddTicks(5313), new DateTime(2024, 11, 27, 0, 28, 13, 803, DateTimeKind.Local).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 28, 13, 803, DateTimeKind.Local).AddTicks(5381), new DateTime(2024, 11, 27, 0, 28, 13, 803, DateTimeKind.Local).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 28, 13, 803, DateTimeKind.Local).AddTicks(5383), new DateTime(2024, 11, 27, 0, 28, 13, 803, DateTimeKind.Local).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 28, 13, 803, DateTimeKind.Local).AddTicks(5385), new DateTime(2024, 11, 27, 0, 28, 13, 803, DateTimeKind.Local).AddTicks(5385) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 28, 13, 803, DateTimeKind.Local).AddTicks(5386), new DateTime(2024, 11, 27, 0, 28, 13, 803, DateTimeKind.Local).AddTicks(5387) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 21, 33, 47, 383, DateTimeKind.Local).AddTicks(1569), new DateTime(2024, 11, 25, 21, 33, 47, 383, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 21, 33, 47, 383, DateTimeKind.Local).AddTicks(1583), new DateTime(2024, 11, 25, 21, 33, 47, 383, DateTimeKind.Local).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 21, 33, 47, 383, DateTimeKind.Local).AddTicks(1731), new DateTime(2024, 11, 25, 21, 33, 47, 383, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 21, 33, 47, 383, DateTimeKind.Local).AddTicks(1732), new DateTime(2024, 11, 25, 21, 33, 47, 383, DateTimeKind.Local).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 21, 33, 47, 383, DateTimeKind.Local).AddTicks(1790), new DateTime(2024, 11, 25, 21, 33, 47, 383, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 21, 33, 47, 383, DateTimeKind.Local).AddTicks(1792), new DateTime(2024, 11, 25, 21, 33, 47, 383, DateTimeKind.Local).AddTicks(1793) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 21, 33, 47, 383, DateTimeKind.Local).AddTicks(1794), new DateTime(2024, 11, 25, 21, 33, 47, 383, DateTimeKind.Local).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 21, 33, 47, 383, DateTimeKind.Local).AddTicks(1795), new DateTime(2024, 11, 25, 21, 33, 47, 383, DateTimeKind.Local).AddTicks(1795) });
        }
    }
}
