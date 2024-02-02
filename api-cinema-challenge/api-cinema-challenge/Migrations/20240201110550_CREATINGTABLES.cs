using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class CREATINGTABLES : Migration
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
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    rating = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    run_time_minutes = table.Column<int>(type: "integer", nullable: false),
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
                    id = table.Column<int>(type: "integer", nullable: false),
                    screen_number = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    start_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    movie_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => new { x.id, x.movie_id, x.screen_number, x.capacity, x.start_time, x.created_at, x.updated_at });
                    table.ForeignKey(
                        name: "FK_screenings_movies_movie_id",
                        column: x => x.movie_id,
                        principalTable: "movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 11, 5, 49, 831, DateTimeKind.Utc).AddTicks(5020), "chris@muse.mu", "Chris Wolstenholme", "+44729388192", new DateTime(2024, 2, 1, 11, 5, 49, 831, DateTimeKind.Utc).AddTicks(5020) },
                    { 2, new DateTime(2024, 2, 1, 11, 5, 49, 831, DateTimeKind.Utc).AddTicks(5020), "max.peter@gmail.com", "Max Peter", "+49123456789", new DateTime(2024, 2, 1, 11, 5, 49, 831, DateTimeKind.Utc).AddTicks(5020) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "description", "rating", "run_time_minutes", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 11, 5, 49, 831, DateTimeKind.Utc).AddTicks(5020), "The greatest movie ever made.", "PG-13", 126, "Dodgeball", new DateTime(2024, 2, 1, 11, 5, 49, 831, DateTimeKind.Utc).AddTicks(5020) },
                    { 2, new DateTime(2024, 2, 1, 11, 5, 49, 831, DateTimeKind.Utc).AddTicks(5020), "The greatest movie ever made.", "R", 126, "The Matrix", new DateTime(2024, 2, 1, 11, 5, 49, 831, DateTimeKind.Utc).AddTicks(5020) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "capacity", "created_at", "id", "movie_id", "screen_number", "start_time", "updated_at" },
                values: new object[,]
                {
                    { 100, new DateTime(2024, 2, 1, 11, 5, 49, 831, DateTimeKind.Utc).AddTicks(5020), 1, 1, 1, new DateTime(2024, 2, 1, 11, 5, 49, 831, DateTimeKind.Utc).AddTicks(5020), new DateTime(2024, 2, 1, 11, 5, 49, 831, DateTimeKind.Utc).AddTicks(5020) },
                    { 100, new DateTime(2024, 2, 1, 11, 5, 49, 831, DateTimeKind.Utc).AddTicks(5020), 2, 2, 2, new DateTime(2024, 2, 1, 11, 5, 49, 831, DateTimeKind.Utc).AddTicks(5020), new DateTime(2024, 2, 1, 11, 5, 49, 831, DateTimeKind.Utc).AddTicks(5020) },
                    { 40, new DateTime(2024, 2, 1, 11, 5, 49, 831, DateTimeKind.Utc).AddTicks(5020), 3, 1, 3, new DateTime(2024, 2, 1, 11, 5, 49, 831, DateTimeKind.Utc).AddTicks(5020), new DateTime(2024, 2, 1, 11, 5, 49, 831, DateTimeKind.Utc).AddTicks(5020) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_movie_id",
                table: "screenings",
                column: "movie_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "screenings");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
