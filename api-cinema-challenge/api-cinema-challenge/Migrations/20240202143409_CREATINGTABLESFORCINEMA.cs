using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class CREATINGTABLESFORCINEMA : Migration
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
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    screen_number = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    start_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    movie_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => x.id);
                    table.ForeignKey(
                        name: "FK_screenings_movies_movie_id",
                        column: x => x.movie_id,
                        principalTable: "movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    seat_number = table.Column<int>(type: "integer", nullable: false),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    screening_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.id);
                    table.ForeignKey(
                        name: "FK_tickets_customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tickets_screenings_screening_id",
                        column: x => x.screening_id,
                        principalTable: "screenings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 2, 14, 34, 7, 924, DateTimeKind.Utc).AddTicks(2550), "chris@muse.mu", "Chris Wolstenholme", "+44729388192", new DateTime(2024, 2, 2, 14, 34, 7, 924, DateTimeKind.Utc).AddTicks(2550) },
                    { 2, new DateTime(2024, 2, 2, 14, 34, 7, 924, DateTimeKind.Utc).AddTicks(2550), "max.peter@gmail.com", "Max Peter", "+49123456789", new DateTime(2024, 2, 2, 14, 34, 7, 924, DateTimeKind.Utc).AddTicks(2550) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "description", "rating", "run_time_minutes", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 2, 14, 34, 7, 924, DateTimeKind.Utc).AddTicks(2550), "The greatest movie ever made.", "PG-13", 126, "Dodgeball", new DateTime(2024, 2, 2, 14, 34, 7, 924, DateTimeKind.Utc).AddTicks(2550) },
                    { 2, new DateTime(2024, 2, 2, 14, 34, 7, 924, DateTimeKind.Utc).AddTicks(2550), "The greatest movie ever made.", "R", 126, "The Matrix", new DateTime(2024, 2, 2, 14, 34, 7, 924, DateTimeKind.Utc).AddTicks(2550) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "created_at", "movie_id", "screen_number", "start_time", "updated_at" },
                values: new object[,]
                {
                    { 1, 100, new DateTime(2024, 2, 2, 14, 34, 7, 924, DateTimeKind.Utc).AddTicks(2550), 1, 1, new DateTime(2024, 2, 2, 14, 34, 7, 924, DateTimeKind.Utc).AddTicks(2550), new DateTime(2024, 2, 2, 14, 34, 7, 924, DateTimeKind.Utc).AddTicks(2550) },
                    { 2, 100, new DateTime(2024, 2, 2, 14, 34, 7, 924, DateTimeKind.Utc).AddTicks(2550), 2, 2, new DateTime(2024, 2, 2, 14, 34, 7, 924, DateTimeKind.Utc).AddTicks(2550), new DateTime(2024, 2, 2, 14, 34, 7, 924, DateTimeKind.Utc).AddTicks(2550) },
                    { 3, 40, new DateTime(2024, 2, 2, 14, 34, 7, 924, DateTimeKind.Utc).AddTicks(2550), 1, 3, new DateTime(2024, 2, 2, 14, 34, 7, 924, DateTimeKind.Utc).AddTicks(2550), new DateTime(2024, 2, 2, 14, 34, 7, 924, DateTimeKind.Utc).AddTicks(2550) }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "created_at", "customer_id", "screening_id", "seat_number", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 2, 14, 34, 7, 924, DateTimeKind.Utc).AddTicks(2550), 1, 1, 1, new DateTime(2024, 2, 2, 14, 34, 7, 924, DateTimeKind.Utc).AddTicks(2550) },
                    { 2, new DateTime(2024, 2, 2, 14, 34, 7, 924, DateTimeKind.Utc).AddTicks(2550), 2, 2, 2, new DateTime(2024, 2, 2, 14, 34, 7, 924, DateTimeKind.Utc).AddTicks(2550) },
                    { 3, new DateTime(2024, 2, 2, 14, 34, 7, 924, DateTimeKind.Utc).AddTicks(2550), 1, 3, 3, new DateTime(2024, 2, 2, 14, 34, 7, 924, DateTimeKind.Utc).AddTicks(2550) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_movie_id",
                table: "screenings",
                column: "movie_id");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_customer_id",
                table: "tickets",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_screening_id",
                table: "tickets",
                column: "screening_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "screenings");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
