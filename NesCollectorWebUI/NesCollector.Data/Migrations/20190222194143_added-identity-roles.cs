using Microsoft.EntityFrameworkCore.Migrations;

namespace NesCollector.Data.Migrations
{
    public partial class addedidentityroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f6667f72-b09e-49db-b740-ab2ad275dee6", "68534c21-d307-4d3e-9a35-39d49ad0f32e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1b31f98b-3006-424f-9e56-909b8438a4d8", "3c882ff1-86f0-4f27-94f1-dcc955a5d669", "SuperUser", "SUPERUSER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1b31f98b-3006-424f-9e56-909b8438a4d8", "3c882ff1-86f0-4f27-94f1-dcc955a5d669" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f6667f72-b09e-49db-b740-ab2ad275dee6", "68534c21-d307-4d3e-9a35-39d49ad0f32e" });
        }
    }
}
