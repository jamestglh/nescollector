using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NesCollector.Data.Migrations
{
    public partial class addinggameconsoletable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "3e7119b4-b4df-4239-b06c-0b9f962c962c", "0e614230-3636-4bfd-a1df-56a6f46cd7ce" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "8e931f40-18ff-439a-8d7e-f5296aba26dc", "9eb94db2-749d-400a-bd50-e811b84655a4" });

            migrationBuilder.CreateTable(
                name: "GameConsoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameConsoles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e43e7c9-58f4-417e-aa63-7b01b8fa922e", "01f3e45a-c25b-4a7d-afc5-25f31f672bc9", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "17b1f205-e21d-42e9-bef0-7d9298af38d2", "827de1ab-0b6a-4f84-93b9-ab4a05c1da91", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "GameConsoles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "NES" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameConsoles");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "17b1f205-e21d-42e9-bef0-7d9298af38d2", "827de1ab-0b6a-4f84-93b9-ab4a05c1da91" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7e43e7c9-58f4-417e-aa63-7b01b8fa922e", "01f3e45a-c25b-4a7d-afc5-25f31f672bc9" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e931f40-18ff-439a-8d7e-f5296aba26dc", "9eb94db2-749d-400a-bd50-e811b84655a4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3e7119b4-b4df-4239-b06c-0b9f962c962c", "0e614230-3636-4bfd-a1df-56a6f46cd7ce", "Admin", "ADMIN" });
        }
    }
}
