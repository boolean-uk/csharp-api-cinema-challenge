using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class testuuuddsdd : Migration
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
                    email_adr = table.Column<string>(type: "text", nullable: false),
                    phone_nr = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    movie_tite = table.Column<string>(type: "text", nullable: false),
                    movie_rating = table.Column<string>(type: "text", nullable: false),
                    movie_description = table.Column<string>(type: "text", nullable: false),
                    movie_runtimeMins = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.movie_id);
                });

            migrationBuilder.CreateTable(
                name: "screenings",
                columns: table => new
                {
                    screen_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    screen_number = table.Column<int>(type: "integer", nullable: false),
                    screen_capacity = table.Column<int>(type: "integer", nullable: false),
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fk_movie_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => x.screen_id);
                    table.ForeignKey(
                        name: "FK_screenings_movies_fk_movie_id",
                        column: x => x.fk_movie_id,
                        principalTable: "movies",
                        principalColumn: "movie_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    ticket_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    seat_number = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.ticket_id);
                    table.ForeignKey(
                        name: "FK_tickets_screenings_screening_id",
                        column: x => x.screening_id,
                        principalTable: "screenings",
                        principalColumn: "screen_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "customer_id", "created_at", "customer_name", "email_adr", "phone_nr", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(382), "John Doe", "john@example.com", "1234567890", new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(385) },
                    { 2, new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(389), "Jane Smith", "jane@example.com", "9876543210", new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(389) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "movie_id", "created_at", "movie_description", "movie_rating", "movie_runtimeMins", "movie_tite", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(435), "Description of Movie 1", "PG", 120, "Movie 1", new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(436) },
                    { 2, new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(439), "Description of Movie 2", "PG-13", 150, "Movie 2", new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(440) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "screen_id", "created_at", "fk_movie_id", "screen_capacity", "screen_number", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(470), 1, 100, 1, new DateTime(2024, 2, 9, 14, 24, 34, 247, DateTimeKind.Utc).AddTicks(463), new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(470) },
                    { 2, new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(475), 2, 120, 2, new DateTime(2024, 2, 9, 15, 24, 34, 247, DateTimeKind.Utc).AddTicks(474), new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(476) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_fk_movie_id",
                table: "screenings",
                column: "fk_movie_id");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_screening_id",
                table: "tickets",
                column: "screening_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DropTable(
                name: "screenings");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
