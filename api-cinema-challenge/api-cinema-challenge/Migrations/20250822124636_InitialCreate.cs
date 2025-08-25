using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_name = table.Column<string>(type: "text", nullable: false),
                    customer_email = table.Column<string>(type: "text", nullable: false),
                    customer_phone = table.Column<string>(type: "text", nullable: false),
                    customer_createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    customer_updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.customer_id);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    movie_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    movie_title = table.Column<string>(type: "text", nullable: false),
                    movie_rating = table.Column<string>(type: "text", nullable: false),
                    movie_description = table.Column<string>(type: "text", nullable: false),
                    movie_runtimeMins = table.Column<int>(type: "integer", nullable: false),
                    movie_createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    movie_updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.movie_id);
                });

            migrationBuilder.CreateTable(
                name: "screenings",
                columns: table => new
                {
                    screening_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    movie_id = table.Column<int>(type: "integer", nullable: false),
                    screening_screenNumber = table.Column<int>(type: "integer", nullable: false),
                    screening_capacity = table.Column<int>(type: "integer", nullable: false),
                    screening_startsAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    screening_createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    screening_updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => x.screening_id);
                    table.ForeignKey(
                        name: "FK_screenings_movies_movie_id",
                        column: x => x.movie_id,
                        principalTable: "movies",
                        principalColumn: "movie_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "customer_id", "customer_createdAt", "customer_email", "customer_name", "customer_phone", "customer_updatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 15, 10, 0, 0, 0, DateTimeKind.Utc), "john.doe@email.com", "John Doe", "+4792763498", new DateTime(2025, 8, 15, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, new DateTime(2025, 8, 15, 10, 0, 0, 0, DateTimeKind.Utc), "jane.doe@email.com", "Jane Doe", "+4743761209", new DateTime(2025, 8, 15, 10, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "movie_id", "movie_createdAt", "movie_description", "movie_rating", "movie_runtimeMins", "movie_title", "movie_updatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 15, 10, 0, 0, 0, DateTimeKind.Utc), "The film stars Leonardo DiCaprio as a professional thief who steals information by infiltrating the subconscious of his targets. He is offered a chance to have his criminal history erased as payment for the implantation of another person's idea into a target's subconscious.", "PG-13", 148, "Inception", new DateTime(2025, 8, 15, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, new DateTime(2025, 8, 15, 10, 0, 0, 0, DateTimeKind.Utc), "\"The Godfather\" is based on Mario Puzo's novel of the same name. The film chronicles the life of the Corleone family, a powerful Italian-American mafia clan in New York City, focusing on the patriarch, Don Vito Corleone, and his youngest son, Michael Corleone.", "R", 175, "The Godfather", new DateTime(2025, 8, 15, 10, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "screening_id", "screening_capacity", "screening_createdAt", "movie_id", "screening_screenNumber", "screening_startsAt", "screening_updatedAt" },
                values: new object[,]
                {
                    { 1, 100, new DateTime(2025, 8, 15, 10, 0, 0, 0, DateTimeKind.Utc), 1, 5, new DateTime(2025, 10, 1, 11, 3, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 15, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, 150, new DateTime(2025, 8, 15, 10, 0, 0, 0, DateTimeKind.Utc), 2, 3, new DateTime(2025, 10, 1, 12, 3, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 15, 10, 0, 0, 0, DateTimeKind.Utc) }
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
