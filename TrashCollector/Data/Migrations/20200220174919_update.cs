using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "4465de13-c800-45b1-815c-83e793109b68", "96f18cdb-4815-4e35-a467-c0da1fbaaa26", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9f439cc0-8fac-462b-b8b8-67d3d17b0e86", "81049187-2b24-48fc-b85f-55e6fbe7c368", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b0a5db8-f9d5-49a8-8ecd-b4d9bd2186c4", "4ad4520f-86e7-4749-bfea-ada95843001c", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4465de13-c800-45b1-815c-83e793109b68");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b0a5db8-f9d5-49a8-8ecd-b4d9bd2186c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f439cc0-8fac-462b-b8b8-67d3d17b0e86");

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
    }
}
