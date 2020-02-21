using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class newUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b418cf8-d4bb-4207-8279-3e940d6339b6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "399cdeef-3f29-4b54-957f-9bdb60181de0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d501d74-ce38-499f-aa2f-d81115935274");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7ab737aa-1d9b-44c4-b299-e515002526ce", "3eb4529d-c4c5-4dd2-bbf3-9b43513f651d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ad7f34f-0082-4f4f-98ba-1ae0196227da", "8b380882-649d-4afb-b94c-41efbd4e4544", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d30f47f5-d205-4bef-a327-e49b548f5314", "5a5ae22a-a165-456e-a2cb-fa25554d6621", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ab737aa-1d9b-44c4-b299-e515002526ce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ad7f34f-0082-4f4f-98ba-1ae0196227da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d30f47f5-d205-4bef-a327-e49b548f5314");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2b418cf8-d4bb-4207-8279-3e940d6339b6", "785bda71-e211-4e64-9443-05472186c3b9", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "399cdeef-3f29-4b54-957f-9bdb60181de0", "9be3bac4-ffc9-4e59-abf9-738825fb0866", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d501d74-ce38-499f-aa2f-d81115935274", "36004d22-594a-44b6-a498-c939e8f3c8a2", "Customer", "CUSTOMER" });
        }
    }
}
