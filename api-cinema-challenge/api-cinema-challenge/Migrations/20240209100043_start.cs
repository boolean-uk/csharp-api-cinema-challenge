using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class start : Migration
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
                    phone = table.Column<string>(type: "text", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    rutimeMins = table.Column<int>(type: "integer", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "screening",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    screenNumber = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    startsAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screening", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5207), "First.Name@email.provider", "First Name", "+01 012 34 567", new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5208) },
                    { 2, new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5211), "Second.Name@email.provider", "Second Name", "+01 112 34 567", new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5212) },
                    { 3, new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5213), "Third.Name@email.provider", "Third Name", "+01 122 34 567", new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5214) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "createdAt", "description", "rutimeMins", "title", "updatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5238), "description", 1, "title", new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5239) },
                    { 2, new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5241), "Another description", 1, "title1", new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5241) },
                    { 3, new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5243), "Yet another description", 1, "title2", new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5243) }
                });

            migrationBuilder.InsertData(
                table: "screening",
                columns: new[] { "id", "capacity", "createdAt", "screenNumber", "startsAt", "updatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5260), 1, new DateTime(2024, 2, 9, 20, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5260) },
                    { 2, 1, new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5265), 1, new DateTime(2024, 2, 11, 20, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5265) },
                    { 3, 1, new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5267), 1, new DateTime(2024, 2, 15, 20, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5267) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "movies");

            migrationBuilder.DropTable(
                name: "screening");
        }
    }
}
