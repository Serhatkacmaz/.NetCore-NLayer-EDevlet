using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDevlet.Repository.Migrations
{
    public partial class ver1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sector = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeNumber = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CreatedDate", "EmployeeNumber", "Location", "Name", "Sector", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2022, 4, 29, 22, 13, 26, 294, DateTimeKind.Local).AddTicks(431), 0, null, "Kordsa", "Tekstil", null });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CreatedDate", "EmployeeNumber", "Location", "Name", "Sector", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2022, 4, 29, 22, 13, 26, 294, DateTimeKind.Local).AddTicks(443), 0, null, "Türk Hava Yolları", "Havacılık", null });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CreatedDate", "EmployeeNumber", "Location", "Name", "Sector", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2022, 4, 29, 22, 13, 26, 294, DateTimeKind.Local).AddTicks(444), 0, null, "Turkcell", "Telekomünikasyon", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
