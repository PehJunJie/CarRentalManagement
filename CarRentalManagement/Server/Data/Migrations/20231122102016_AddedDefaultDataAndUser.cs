using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "62556bc3-4dcf-4814-9a48-930028d06d58", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEPflpP40wE7Wcke08+jOAWBKutWc3okJBRY6X1umt2SDJh0rIOh9mTKoQdy8WKcRjQ==", null, false, "8e5e0c3e-169b-42b8-8edb-d5492f69634d", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 18, 20, 16, 155, DateTimeKind.Local).AddTicks(7989), new DateTime(2023, 11, 22, 18, 20, 16, 155, DateTimeKind.Local).AddTicks(8004), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 18, 20, 16, 155, DateTimeKind.Local).AddTicks(8007), new DateTime(2023, 11, 22, 18, 20, 16, 155, DateTimeKind.Local).AddTicks(8008), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 18, 20, 16, 155, DateTimeKind.Local).AddTicks(8443), new DateTime(2023, 11, 22, 18, 20, 16, 155, DateTimeKind.Local).AddTicks(8444), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 18, 20, 16, 155, DateTimeKind.Local).AddTicks(8446), new DateTime(2023, 11, 22, 18, 20, 16, 155, DateTimeKind.Local).AddTicks(8446), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 18, 20, 16, 155, DateTimeKind.Local).AddTicks(8688), new DateTime(2023, 11, 22, 18, 20, 16, 155, DateTimeKind.Local).AddTicks(8689), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 18, 20, 16, 155, DateTimeKind.Local).AddTicks(8691), new DateTime(2023, 11, 22, 18, 20, 16, 155, DateTimeKind.Local).AddTicks(8692), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 22, 18, 20, 16, 155, DateTimeKind.Local).AddTicks(8693), new DateTime(2023, 11, 22, 18, 20, 16, 155, DateTimeKind.Local).AddTicks(8694), "Pirus", "System" },
                    { 4, "System", new DateTime(2023, 11, 22, 18, 20, 16, 155, DateTimeKind.Local).AddTicks(8696), new DateTime(2023, 11, 22, 18, 20, 16, 155, DateTimeKind.Local).AddTicks(8696), "Rav4", "System" }
                });

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
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
