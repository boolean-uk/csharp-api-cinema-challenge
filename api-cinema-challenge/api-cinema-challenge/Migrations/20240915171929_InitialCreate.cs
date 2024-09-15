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
                    runtimeMins = table.Column<int>(type: "integer", nullable: false),
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
                    screenNumber = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
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
                    num_seats = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
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
                    { 1, new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(292), "nigel@gmail.com", "Nigel", "44647282", new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(294) },
                    { 2, new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(297), "dave@gmail.com", "Dave", "98417321", new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(297) },
                    { 3, new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(298), "julia@gmail.com", "Julia", "47543219", new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(298) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "description", "rating", "runtimeMins", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(404), "Boats", "PG-13", 240, "Titanic", new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(404) },
                    { 2, new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(407), "Scary", "PG-15", 90, "Conjuring", new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(407) },
                    { 3, new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(408), "Blue people", "PG-9", 200, "Avatar", new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(408) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "created_at", "movie_id", "screenNumber", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 100, new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(427), 3, 3, new DateTime(2024, 11, 15, 16, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(427) },
                    { 2, 250, new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(553), 2, 2, new DateTime(2024, 11, 17, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(554) },
                    { 3, 55, new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(561), 1, 1, new DateTime(2024, 11, 14, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(561) }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "created_at", "customer_id", "num_seats", "screening_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(584), 1, 5, 1, new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(584) },
                    { 2, new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(587), 2, 2, 2, new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(587) },
                    { 3, new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(588), 3, 7, 3, new DateTime(2024, 9, 15, 17, 19, 29, 540, DateTimeKind.Utc).AddTicks(588) }
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
