using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class CreateTables : Migration
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
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    movie_id = table.Column<int>(type: "integer", nullable: false),
                    screen_name = table.Column<string>(type: "text", nullable: false),
                    start_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => x.id);
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
                    { 1, new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7254), "A short comedy movie", "Good", 77, "The Sweet Potato", new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7254) },
                    { 2, new DateTime(2024, 1, 27, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7256), "A thrilling mystery movie", "Excellent", 120, "Mystery Mansion", new DateTime(2024, 1, 29, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7257) },
                    { 3, new DateTime(2024, 1, 22, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7259), "A beautiful romantic movie", "Great", 90, "Romantic Sunset", new DateTime(2024, 1, 24, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7259) },
                    { 4, new DateTime(2024, 1, 17, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7261), "An epic science fiction movie", "Excellent", 150, "Sci-Fi Odyssey", new DateTime(2024, 1, 20, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7261) },
                    { 5, new DateTime(2024, 1, 12, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7263), "A gripping drama movie", "Good", 110, "Drama Junction", new DateTime(2024, 1, 14, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7263) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "created_at", "movie_id", "screen_name", "start_time", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7361), 1, "Screen1", new DateTime(2024, 2, 1, 16, 29, 49, 563, DateTimeKind.Utc).AddTicks(7360), new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7362) },
                    { 2, new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7366), 1, "Screen2", new DateTime(2024, 2, 1, 18, 29, 49, 563, DateTimeKind.Utc).AddTicks(7365), new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7366) },
                    { 3, new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7368), 2, "Screen3", new DateTime(2024, 2, 1, 19, 29, 49, 563, DateTimeKind.Utc).AddTicks(7367), new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7368) },
                    { 4, new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7370), 2, "Screen4", new DateTime(2024, 2, 1, 16, 29, 49, 563, DateTimeKind.Utc).AddTicks(7369), new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7370) },
                    { 5, new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7372), 3, "Screen5", new DateTime(2024, 2, 1, 20, 29, 49, 563, DateTimeKind.Utc).AddTicks(7371), new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7372) }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "created_at", "email", "name", "phone_number", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(6987), "joel@email.com", "Joel Joelsson", "0700050088", new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(6989) },
                    { 2, new DateTime(2024, 1, 30, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(6991), "alice@email.com", "Alice Johnson", "0701122334", new DateTime(2024, 1, 30, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(6998) },
                    { 3, new DateTime(2024, 1, 27, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7000), "bob@email.com", "Bob Smith", "0709876543", new DateTime(2024, 1, 29, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7000) },
                    { 4, new DateTime(2024, 1, 24, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7001), "emma@email.com", "Emma White", "0703344556", new DateTime(2024, 1, 26, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7002) },
                    { 5, new DateTime(2024, 1, 22, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7003), "david@email.com", "David Brown", "0706677889", new DateTime(2024, 1, 25, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7004) }
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
