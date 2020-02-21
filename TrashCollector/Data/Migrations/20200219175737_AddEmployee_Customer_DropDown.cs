using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class AddEmployee_Customer_DropDown : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40fb715b-575e-4d53-bb5a-6aabc705e7d1");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "40fb715b-575e-4d53-bb5a-6aabc705e7d1", "e8806cf3-e3b4-42ff-9e38-9db035a0f409", "Admin", "ADMIN" });
        }
    }
}
