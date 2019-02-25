using Microsoft.EntityFrameworkCore.Migrations;

namespace NesCollector.Data.Migrations
{
    public partial class changedpricestodouble2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1c731451-63bf-42b1-928b-0c16a7be2035", "41a80e45-349b-497d-ac34-fd0a86edc59f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c6ab6d94-5ee1-4e95-813e-3320a5ee32bc", "1a5033b6-df7a-4925-91fd-cedad3703fcc" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a4fd0570-99bc-450c-a2b8-dd831c3315ea", "05e3474b-41d8-4518-bed2-a243d5b5f2b7", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09bb03f8-4c45-41fc-a148-0fc57431ce73", "a4cd79fd-8a33-46fa-aa82-3af75f8effdb", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "09bb03f8-4c45-41fc-a148-0fc57431ce73", "a4cd79fd-8a33-46fa-aa82-3af75f8effdb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "a4fd0570-99bc-450c-a2b8-dd831c3315ea", "05e3474b-41d8-4518-bed2-a243d5b5f2b7" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c731451-63bf-42b1-928b-0c16a7be2035", "41a80e45-349b-497d-ac34-fd0a86edc59f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c6ab6d94-5ee1-4e95-813e-3320a5ee32bc", "1a5033b6-df7a-4925-91fd-cedad3703fcc", "Admin", "ADMIN" });
        }
    }
}
