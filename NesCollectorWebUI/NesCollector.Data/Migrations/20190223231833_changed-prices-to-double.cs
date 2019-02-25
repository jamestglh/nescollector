using Microsoft.EntityFrameworkCore.Migrations;

namespace NesCollector.Data.Migrations
{
    public partial class changedpricestodouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "0171b6db-2f6b-4b5d-b7cd-ea31c1dea88f", "453ac20c-dca6-4133-9290-e00f9d881e05" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "58f2710e-d00d-4259-a450-cfc86a61cc3c", "347e9c7f-75b4-409f-b721-191910207b25" });

            migrationBuilder.AlterColumn<double>(
                name: "LoosePrice",
                table: "Games",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "CibPrice",
                table: "Games",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1c731451-63bf-42b1-928b-0c16a7be2035", "41a80e45-349b-497d-ac34-fd0a86edc59f", "User", "USER" },
                    { "c6ab6d94-5ee1-4e95-813e-3320a5ee32bc", "1a5033b6-df7a-4925-91fd-cedad3703fcc", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1.0, 1.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1c731451-63bf-42b1-928b-0c16a7be2035", "41a80e45-349b-497d-ac34-fd0a86edc59f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c6ab6d94-5ee1-4e95-813e-3320a5ee32bc", "1a5033b6-df7a-4925-91fd-cedad3703fcc" });

            migrationBuilder.AlterColumn<int>(
                name: "LoosePrice",
                table: "Games",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "CibPrice",
                table: "Games",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "58f2710e-d00d-4259-a450-cfc86a61cc3c", "347e9c7f-75b4-409f-b721-191910207b25", "User", "USER" },
                    { "0171b6db-2f6b-4b5d-b7cd-ea31c1dea88f", "453ac20c-dca6-4133-9290-e00f9d881e05", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "CibPrice", "LoosePrice" },
                values: new object[] { 1, 1 });
        }
    }
}
