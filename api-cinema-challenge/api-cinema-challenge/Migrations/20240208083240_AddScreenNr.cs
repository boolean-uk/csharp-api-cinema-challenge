using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class AddScreenNr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_name = table.Column<string>(type: "text", nullable: false),
                    customer_email = table.Column<string>(type: "text", nullable: false),
                    customer_phone = table.Column<string>(type: "text", nullable: false),
                    customer_created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    customer_updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.customer_id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    movie_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    movie_title = table.Column<string>(type: "text", nullable: false),
                    movie_rating = table.Column<string>(type: "text", nullable: false),
                    movie_description = table.Column<string>(type: "text", nullable: false),
                    movie_runtime = table.Column<int>(type: "integer", nullable: false),
                    movie_created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    movie_update_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.movie_id);
                });

            migrationBuilder.CreateTable(
                name: "Screenings",
                columns: table => new
                {
                    screening_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fk_movie_id = table.Column<int>(type: "integer", nullable: false),
                    screening_screen_number = table.Column<int>(type: "integer", nullable: false),
                    screening_capacity = table.Column<int>(type: "integer", nullable: false),
                    screening_starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    screening_created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    screening_updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screenings", x => x.screening_id);
                    table.ForeignKey(
                        name: "FK_Screenings_Movies_fk_movie_id",
                        column: x => x.fk_movie_id,
                        principalTable: "Movies",
                        principalColumn: "movie_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "customer_id", "customer_created_at", "customer_email", "customer_name", "customer_phone", "customer_updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 9, 22, 0, 0, 0, DateTimeKind.Utc), "FrankOcean@Orange.com", "Frank Ocean", "+3382798719", new DateTime(2024, 6, 9, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, new DateTime(2024, 7, 4, 22, 0, 0, 0, DateTimeKind.Utc), "Alice@Wonderland.com", "Alice Wonderland", "+44123456789", new DateTime(2024, 7, 4, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, new DateTime(2024, 8, 14, 22, 0, 0, 0, DateTimeKind.Utc), "JohnDoe@email.com", "John Doe", "+15555555555", new DateTime(2024, 8, 14, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, new DateTime(2024, 9, 24, 22, 0, 0, 0, DateTimeKind.Utc), "MiaJohnson@email.com", "Mia Johnson", "+18881234567", new DateTime(2024, 9, 24, 22, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "movie_id", "movie_created_at", "movie_description", "movie_rating", "movie_runtime", "movie_title", "movie_update_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 1, 23, 0, 0, 0, DateTimeKind.Utc), "Movie about dragons", "Excellent", 145, "How to Train your Dragon", new DateTime(2024, 3, 1, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, new DateTime(2024, 4, 14, 22, 0, 0, 0, DateTimeKind.Utc), "A magical journey in a hidden garden", "Enchanting", 110, "The Secret Garden", new DateTime(2024, 4, 14, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, new DateTime(2024, 5, 19, 22, 0, 0, 0, DateTimeKind.Utc), "A mind-bending heist in dreams", "Masterpiece", 148, "Inception", new DateTime(2024, 5, 19, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, new DateTime(2024, 6, 9, 22, 0, 0, 0, DateTimeKind.Utc), "A superhero's journey to save the world", "Epic", 152, "Wonder Woman", new DateTime(2024, 6, 9, 22, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "screening_id", "screening_capacity", "screening_created_at", "fk_movie_id", "screening_screen_number", "screening_starts_at", "screening_updated_at" },
                values: new object[,]
                {
                    { 1, 30, new DateTime(2024, 8, 14, 22, 0, 0, 0, DateTimeKind.Utc), 1, 1, new DateTime(2024, 9, 24, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 8, 14, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, 40, new DateTime(2024, 9, 4, 22, 0, 0, 0, DateTimeKind.Utc), 2, 5, new DateTime(2024, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 4, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, 25, new DateTime(2024, 10, 19, 22, 0, 0, 0, DateTimeKind.Utc), 3, 2, new DateTime(2024, 10, 31, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 10, 19, 22, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_fk_movie_id",
                table: "Screenings",
                column: "fk_movie_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Screenings");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
