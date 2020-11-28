using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Books365.Migrations
{
    public partial class StartMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ISBN = table.Column<int>(maxLength: 30, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Year = table.Column<int>(maxLength: 4, nullable: false),
                    Author = table.Column<string>(maxLength: 50, nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ISBN);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Message = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ReadingStatuses",
                columns: table => new
                {
                    UserEmail = table.Column<string>(maxLength: 50, nullable: true),
                    BookISBN = table.Column<int>(maxLength: 30, nullable: false),
                    PagesWritten = table.Column<int>(nullable: false),
                    StartOfReading = table.Column<DateTime>(nullable: false),
                    Rating = table.Column<double>(maxLength: 3, nullable: false),
                    BookStatus = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    Password = table.Column<string>(maxLength: 30, nullable: true),
                    SecretPin = table.Column<int>(maxLength: 4, nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Email);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "ReadingStatuses");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
