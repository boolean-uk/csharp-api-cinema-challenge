using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class CreateTablesRemovedPKFromScreenings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    runtime_mins = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "screenings",
                columns: table => new
                {
                    movie_id = table.Column<int>(type: "integer", nullable: false),
                    screen_number = table.Column<int>(type: "integer", nullable: false),
                    start_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => new { x.movie_id, x.screen_number, x.start_time });
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone_number = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "description", "rating", "runtime_mins", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 5, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(254), "A short comedy movie", "Good", 77, "The Sweet Potato", new DateTime(2024, 2, 5, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(254) },
                    { 2, new DateTime(2024, 1, 31, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(256), "A thrilling mystery movie", "Excellent", 120, "Mystery Mansion", new DateTime(2024, 2, 2, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(257) },
                    { 3, new DateTime(2024, 1, 26, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(258), "A beautiful romantic movie", "Great", 90, "Romantic Sunset", new DateTime(2024, 1, 28, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(258) },
                    { 4, new DateTime(2024, 1, 21, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(260), "An epic science fiction movie", "Excellent", 150, "Sci-Fi Odyssey", new DateTime(2024, 1, 24, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(260) },
                    { 5, new DateTime(2024, 1, 16, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(261), "A gripping drama movie", "Good", 110, "Drama Junction", new DateTime(2024, 1, 18, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(262) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "movie_id", "screen_number", "start_time", "capacity", "created_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 2, 5, 12, 30, 49, 300, DateTimeKind.Utc).AddTicks(1387), 100, new DateTime(2024, 2, 5, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(1389), new DateTime(2024, 2, 5, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(1389) },
                    { 1, 2, new DateTime(2024, 2, 5, 14, 30, 49, 300, DateTimeKind.Utc).AddTicks(1391), 120, new DateTime(2024, 2, 5, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(1391), new DateTime(2024, 2, 5, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(1392) },
                    { 2, 3, new DateTime(2024, 2, 5, 15, 30, 49, 300, DateTimeKind.Utc).AddTicks(1393), 70, new DateTime(2024, 2, 5, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(1393), new DateTime(2024, 2, 5, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(1394) },
                    { 2, 4, new DateTime(2024, 2, 5, 12, 30, 49, 300, DateTimeKind.Utc).AddTicks(1395), 80, new DateTime(2024, 2, 5, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(1395), new DateTime(2024, 2, 5, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(1395) },
                    { 3, 5, new DateTime(2024, 2, 5, 16, 30, 49, 300, DateTimeKind.Utc).AddTicks(1396), 83, new DateTime(2024, 2, 5, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(1397), new DateTime(2024, 2, 5, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(1397) }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "created_at", "email", "name", "phone_number", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 5, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(62), "joel@email.com", "Joel Joelsson", "0700050088", new DateTime(2024, 2, 5, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(64) },
                    { 2, new DateTime(2024, 2, 3, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(67), "alice@email.com", "Alice Johnson", "0701122334", new DateTime(2024, 2, 3, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(73) },
                    { 3, new DateTime(2024, 1, 31, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(74), "bob@email.com", "Bob Smith", "0709876543", new DateTime(2024, 2, 2, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(75) },
                    { 4, new DateTime(2024, 1, 28, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(76), "emma@email.com", "Emma White", "0703344556", new DateTime(2024, 1, 30, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(76) },
                    { 5, new DateTime(2024, 1, 26, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(78), "david@email.com", "David Brown", "0706677889", new DateTime(2024, 1, 29, 11, 30, 49, 300, DateTimeKind.Utc).AddTicks(78) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movies");

            migrationBuilder.DropTable(
                name: "screenings");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
