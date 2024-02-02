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
                    runtime_mins = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "screening",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    movie_id = table.Column<int>(type: "integer", nullable: false),
                    screen_number = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screening", x => new { x.id, x.movie_id });
                    table.ForeignKey(
                        name: "FK_screening_movies_movie_id",
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
                    { 1, new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2456), "klara.andersson@telia.com", "Klara Andersson", "123854", new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2529) },
                    { 2, new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2533), "peter.andersson@telia.com", "Peter Andersson", "467215", new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2535) },
                    { 3, new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2538), "arvid.andersson@telia.com", "Arvid Andersson", "8751345", new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2540) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "description", "rating", "runtime_mins", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2648), "Adaption of the greatest book", "PG-13", 160, "Throne of Glass", new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2651) },
                    { 2, new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2655), "A girl assassin saves the city", "PG-20", 200, "Queen of Shadows", new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2657) },
                    { 3, new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2660), "Riding dragons", "PG-10", 100, "Fourth Wing", new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2662) }
                });

            migrationBuilder.InsertData(
                table: "screening",
                columns: new[] { "id", "movie_id", "capacity", "created_at", "screen_number", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 2, 40, new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2674), 5, new DateTime(2024, 1, 31, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2676) },
                    { 2, 3, 100, new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2684), 3, new DateTime(2024, 1, 31, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2686) },
                    { 3, 1, 20, new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2691), 1, new DateTime(2024, 1, 31, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 1, 14, 24, 28, 66, DateTimeKind.Utc).AddTicks(2693) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screening_movie_id",
                table: "screening",
                column: "movie_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "screening");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
