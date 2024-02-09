using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class Pgsql : Migration
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
                    rating = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    runtime_mins = table.Column<double>(type: "double precision", nullable: false),
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
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fk_movie_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => x.id);
                    table.ForeignKey(
                        name: "FK_screenings_movies_fk_movie_id",
                        column: x => x.fk_movie_id,
                        principalTable: "movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    fk_customer_id = table.Column<int>(type: "integer", nullable: false),
                    fk_screening_id = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    num_seats = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => new { x.fk_screening_id, x.fk_customer_id });
                    table.ForeignKey(
                        name: "FK_tickets_customers_fk_customer_id",
                        column: x => x.fk_customer_id,
                        principalTable: "customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tickets_screenings_fk_screening_id",
                        column: x => x.fk_screening_id,
                        principalTable: "screenings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { 1, new DateTime(2024, 2, 9, 9, 11, 3, 314, DateTimeKind.Utc).AddTicks(5045), "Oscar@Olsson.com", "Oscar Olsson", "09876543", new DateTime(2024, 2, 9, 9, 11, 3, 314, DateTimeKind.Utc).AddTicks(5055) });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "description", "rating", "runtime_mins", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 9, 9, 11, 3, 314, DateTimeKind.Utc).AddTicks(5261), "Horror movie by famous programmer Steven", 3, 124.0, "Empty Relations", new DateTime(2024, 2, 9, 9, 11, 3, 314, DateTimeKind.Utc).AddTicks(5261) },
                    { 2, new DateTime(2024, 2, 9, 9, 11, 3, 314, DateTimeKind.Utc).AddTicks(5291), "Follow up from Steven", 5, 124.0, "Empty Relations 2", new DateTime(2024, 2, 9, 9, 11, 3, 314, DateTimeKind.Utc).AddTicks(5292) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "created_at", "fk_movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 1, 320, new DateTime(2024, 2, 9, 9, 11, 3, 314, DateTimeKind.Utc).AddTicks(5296), 1, 2, new DateTime(2024, 4, 10, 8, 10, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 9, 9, 11, 3, 314, DateTimeKind.Utc).AddTicks(5296) });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "fk_customer_id", "fk_screening_id", "created_at", "num_seats", "updated_at" },
                values: new object[] { 1, 1, new DateTime(2024, 2, 9, 9, 11, 3, 314, DateTimeKind.Utc).AddTicks(5341), 3, new DateTime(2024, 2, 9, 9, 11, 3, 314, DateTimeKind.Utc).AddTicks(5342) });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_fk_movie_id",
                table: "screenings",
                column: "fk_movie_id");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_fk_customer_id",
                table: "tickets",
                column: "fk_customer_id");
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
