using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Data.Migrations
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
                    created_at = table.Column<DateTime>(type: "date", nullable: false),
                    updated_at = table.Column<DateTime>(type: "date", nullable: true)
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
                    description = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<int>(type: "integer", nullable: false),
                    runtime_mins = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "date", nullable: false),
                    updated_at = table.Column<DateTime>(type: "date", nullable: true)
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
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    starts_at = table.Column<DateTime>(type: "date", nullable: false),
                    created_at = table.Column<DateTime>(type: "date", nullable: false),
                    updated_at = table.Column<DateTime>(type: "date", nullable: true)
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
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    num_seats = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "date", nullable: false),
                    updated_at = table.Column<DateTime>(type: "date", nullable: true)
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
                    { 1, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(6863), "David@email.com", "David", "49820343", null },
                    { 2, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(6894), "David@email.com", "David", "64796567", null },
                    { 3, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(6899), "Frank@email.com", "Frank", "49097539", null },
                    { 4, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(6903), "Piotr@email.com", "Piotr", "96052298", null },
                    { 5, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(6907), "Frank@email.com", "Frank", "69340308", null },
                    { 6, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(6916), "Frank@email.com", "Frank", "36100292", null },
                    { 7, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(6920), "Frank@email.com", "Frank", "71598014", null },
                    { 8, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(6923), "Ruben@email.com", "Ruben", "38517879", null },
                    { 9, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(6926), "Elisabeth@email.com", "Elisabeth", "93274298", null },
                    { 10, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(6931), "Frank@email.com", "Frank", "32836683", null },
                    { 11, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(6964), "David@email.com", "David", "60434274", null }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "description", "rating", "runtime_mins", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(7125), "A movie about a Swan that is quite Amazing", 1, 211, "The Amazing Swan", null },
                    { 2, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(7244), "A movie about a Policeman that is quite Mad", 1, 170, "The Mad Policeman", null },
                    { 3, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(7249), "A movie about a Piper that is quite Seethrough", 1, 76, "The Seethrough Piper", null },
                    { 4, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(7253), "A movie about a Policeman that is quite Purple", 0, 61, "The Purple Policeman", null },
                    { 5, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(7257), "A movie about a Computer that is quite Seethrough", 0, 183, "The Seethrough Computer", null },
                    { 6, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(7262), "A movie about a Piper that is quite Round", 2, 92, "The Round Piper", null },
                    { 7, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(7266), "A movie about a Swan that is quite Slow", 0, 256, "The Slow Swan", null },
                    { 8, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(7269), "A movie about a Swan that is quite Purple", 2, 210, "The Purple Swan", null },
                    { 9, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(7272), "A movie about a Policeman that is quite Round", 1, 184, "The Round Policeman", null },
                    { 10, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(7277), "A movie about a Leopard that is quite Round", 2, 189, "The Round Leopard", null },
                    { 11, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(7280), "A movie about a Computer that is quite Amazing", 3, 239, "The Amazing Computer", null },
                    { 12, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(7284), "A movie about a Swan that is quite Seethrough", 2, 78, "The Seethrough Swan", null },
                    { 13, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(7287), "A movie about a Piper that is quite Fast", 3, 112, "The Fast Piper", null },
                    { 14, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(7291), "A movie about a Leopard that is quite Slow", 3, 78, "The Slow Leopard", null }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "created_at", "movie_id", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { 2, 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { 3, 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { 4, 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { 5, 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { 6, 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), null }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "created_at", "customer_id", "num_seats", "screening_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(7395), 1, 4, 3, null },
                    { 2, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(7400), 3, 2, 4, null },
                    { 3, new DateTime(2024, 2, 6, 14, 31, 30, 152, DateTimeKind.Local).AddTicks(7402), 2, 1, 1, null }
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
