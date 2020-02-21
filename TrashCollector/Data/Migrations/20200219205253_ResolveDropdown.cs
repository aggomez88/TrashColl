using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class ResolveDropdown : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "8505f5a9-abf0-4d4d-8423-bf92ffb802fe", "9f52c44b-f3e1-451a-a8a7-076aef64dd92", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e8237574-69ea-4317-be8b-d251dd888c7a", "51fa9c11-642f-4f9d-8c2f-006325a2cbf5", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c82d670f-aa37-474d-95ab-7b817d065772", "2ea6b700-68a2-42e3-8697-f13c7f455878", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8505f5a9-abf0-4d4d-8423-bf92ffb802fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c82d670f-aa37-474d-95ab-7b817d065772");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8237574-69ea-4317-be8b-d251dd888c7a");

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
    }
}
