using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class pleaseFixScreenings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customer",
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
                    table.PrimaryKey("PK_customer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "movie",
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
                    table.PrimaryKey("PK_movie", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "screening",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    screen_number = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    movie_id = table.Column<int>(type: "integer", nullable: false),
                    CustomerId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screening", x => x.id);
                    table.ForeignKey(
                        name: "FK_screening_customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customer",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_screening_movie_movie_id",
                        column: x => x.movie_id,
                        principalTable: "movie",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customer",
                columns: new[] { "id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 6, 8, 17, 22, 442, DateTimeKind.Utc).AddTicks(1058), "john@example.com", "Henrik Rosenkilde", "1234567890", new DateTime(2024, 2, 6, 8, 17, 22, 442, DateTimeKind.Utc).AddTicks(1061) },
                    { 2, new DateTime(2024, 2, 6, 8, 17, 22, 442, DateTimeKind.Utc).AddTicks(1063), "john@example.com", "Anette Mari Rosenkilde", "1234567890", new DateTime(2024, 2, 6, 8, 17, 22, 442, DateTimeKind.Utc).AddTicks(1063) }
                });

            migrationBuilder.InsertData(
                table: "movie",
                columns: new[] { "id", "created_at", "description", "rating", "runtime_mins", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 6, 8, 17, 22, 442, DateTimeKind.Utc).AddTicks(1129), "A computer hacker learns about the true nature of reality and his role in the war against its controllers.", "R", 136, "The Matrix", new DateTime(2024, 2, 6, 8, 17, 22, 442, DateTimeKind.Utc).AddTicks(1129) },
                    { 2, new DateTime(2024, 2, 6, 8, 17, 22, 442, DateTimeKind.Utc).AddTicks(1131), "A reluctant hobbit, Bilbo Baggins, sets out to the Lonely Mountain with a spirited group of dwarves to reclaim their mountain home, and the gold within it, from the dragon Smaug.", "PG-13", 169, "The Hobbit", new DateTime(2024, 2, 6, 8, 17, 22, 442, DateTimeKind.Utc).AddTicks(1131) }
                });

            migrationBuilder.InsertData(
                table: "screening",
                columns: new[] { "id", "capacity", "CustomerId", "movie_id", "screen_number", "starts_at" },
                values: new object[] { 1, 40, null, 1, 5, new DateTime(2024, 2, 6, 8, 17, 22, 442, DateTimeKind.Utc).AddTicks(1143) });

            migrationBuilder.CreateIndex(
                name: "IX_screening_CustomerId",
                table: "screening",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_screening_movie_id",
                table: "screening",
                column: "movie_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "screening");

            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "movie");
        }
    }
}
