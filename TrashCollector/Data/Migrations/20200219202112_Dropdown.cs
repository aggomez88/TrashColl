using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Dropdown : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62b12280-aa1f-4b87-86e3-625bf91fc01d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90c6f721-6f22-402f-9df7-69dc24466386");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b418e1fa-2e5e-479f-b521-2e77c4cd301c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a920405b-b482-4b0b-ac39-521494d5c866", "29474f1d-fb43-494e-b3fe-e4bc8e3b6803", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9cc4e988-cc6e-46b6-a5a6-268c0aca885a", "aa413505-2969-4682-90ce-158dea441447", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "38db0166-3a2b-47e8-8d25-0051cc049677", "36e83492-e85e-46e0-a6fe-90b9e4d3ad24", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38db0166-3a2b-47e8-8d25-0051cc049677");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cc4e988-cc6e-46b6-a5a6-268c0aca885a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a920405b-b482-4b0b-ac39-521494d5c866");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b418e1fa-2e5e-479f-b521-2e77c4cd301c", "ab44d752-816c-436c-967e-4d044a50a546", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "90c6f721-6f22-402f-9df7-69dc24466386", "ef5c8f73-09b9-40bd-bcf5-b25130e7bd60", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "62b12280-aa1f-4b87-86e3-625bf91fc01d", "67f18fa6-3713-425d-8fbf-a3a200a0c887", "Customer", "CUSTOMER" });
        }
    }
}
