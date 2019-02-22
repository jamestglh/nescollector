using Microsoft.EntityFrameworkCore.Migrations;

namespace NesCollector.Data.Migrations
{
    public partial class changedrolenames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1b31f98b-3006-424f-9e56-909b8438a4d8", "3c882ff1-86f0-4f27-94f1-dcc955a5d669" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f6667f72-b09e-49db-b740-ab2ad275dee6", "68534c21-d307-4d3e-9a35-39d49ad0f32e" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e931f40-18ff-439a-8d7e-f5296aba26dc", "9eb94db2-749d-400a-bd50-e811b84655a4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3e7119b4-b4df-4239-b06c-0b9f962c962c", "0e614230-3636-4bfd-a1df-56a6f46cd7ce", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "3e7119b4-b4df-4239-b06c-0b9f962c962c", "0e614230-3636-4bfd-a1df-56a6f46cd7ce" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "8e931f40-18ff-439a-8d7e-f5296aba26dc", "9eb94db2-749d-400a-bd50-e811b84655a4" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f6667f72-b09e-49db-b740-ab2ad275dee6", "68534c21-d307-4d3e-9a35-39d49ad0f32e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1b31f98b-3006-424f-9e56-909b8438a4d8", "3c882ff1-86f0-4f27-94f1-dcc955a5d669", "SuperUser", "SUPERUSER" });
        }
    }
}
