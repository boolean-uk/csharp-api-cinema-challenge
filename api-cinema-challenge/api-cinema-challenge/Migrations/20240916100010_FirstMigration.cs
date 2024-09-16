using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "moives",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    runtimeMins = table.Column<int>(type: "integer", nullable: false),
                    rating = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_moives", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "screenings",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    movieId = table.Column<int>(type: "integer", nullable: false),
                    screenNumber = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    startsAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "email", "name", "phone" },
                values: new object[,]
                {
                    { 1, "bjorg@bjorg.no", "Bjorg", "45215121" },
                    { 2, "ali@ali.org", "Ali", "77887788" },
                    { 3, "kaja@kaja.plazk", "Kaja", "33343334" }
                });

            migrationBuilder.InsertData(
                table: "moives",
                columns: new[] { "id", "description", "rating", "runtimeMins", "title" },
                values: new object[,]
                {
                    { 1, "Widely recognized as the worst movie ever made", 4, 87, "Stop or my mom will shoot" },
                    { 2, "Romeo and Juliet, but better", 10, 126, "Ronja Rövardotter" },
                    { 3, "Bob Hoskins called it his biggest regret", 4, 104, "Super Mario Bros." }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "movieId", "screenNumber", "startsAt" },
                values: new object[,]
                {
                    { 1, 20, 1, 2, new DateTime(2024, 9, 18, 14, 15, 0, 0, DateTimeKind.Utc) },
                    { 2, 15, 1, 3, new DateTime(2024, 9, 19, 15, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, 300, 2, 1, new DateTime(2024, 9, 28, 20, 30, 0, 0, DateTimeKind.Utc) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "moives");

            migrationBuilder.DropTable(
                name: "screenings");
        }
    }
}
