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
                    starts_at = table.Column<DateTime>(type: "date", nullable: false)
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
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    num_seats = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "date", nullable: false),
                    updated_at = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => new { x.customer_id, x.screening_id });
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
                    { 1, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5088), "David@email.com", "David", "60728988", null },
                    { 2, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5120), "Frank@email.com", "Frank", "77744006", null },
                    { 3, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5125), "Frank@email.com", "Frank", "58548887", null },
                    { 4, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5129), "Ruben@email.com", "Ruben", "28438558", null },
                    { 5, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5134), "David@email.com", "David", "32090007", null },
                    { 6, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5140), "Frank@email.com", "Frank", "56613342", null },
                    { 7, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5145), "Piotr@email.com", "Piotr", "32297558", null },
                    { 8, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5149), "Ruben@email.com", "Ruben", "83332048", null },
                    { 9, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5153), "David@email.com", "David", "55505102", null },
                    { 10, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5158), "Piotr@email.com", "Piotr", "24937168", null },
                    { 11, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5162), "Frank@email.com", "Frank", "64015786", null }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "description", "rating", "runtime_mins", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5220), "A movie about a Policeman that is quite Seethrough", 1, 81, "The Seethrough Policeman", null },
                    { 2, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5351), "A movie about a Leopard that is quite Fast", 3, 166, "The Fast Leopard", null },
                    { 3, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5356), "A movie about a Piper that is quite Amazing", 0, 42, "The Amazing Piper", null },
                    { 4, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5361), "A movie about a Piper that is quite Purple", 3, 195, "The Purple Piper", null },
                    { 5, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5366), "A movie about a Swan that is quite Amazing", 3, 208, "The Amazing Swan", null },
                    { 6, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5370), "A movie about a Phone that is quite Fast", 0, 175, "The Fast Phone", null },
                    { 7, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5375), "A movie about a Piper that is quite Mad", 0, 60, "The Mad Piper", null },
                    { 8, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5379), "A movie about a Leopard that is quite Purple", 3, 85, "The Purple Leopard", null },
                    { 9, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5383), "A movie about a Swan that is quite Round", 0, 89, "The Round Swan", null },
                    { 10, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5388), "A movie about a Leopard that is quite Slow", 2, 87, "The Slow Leopard", null },
                    { 11, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5393), "A movie about a Piper that is quite Amazing", 1, 153, "The Amazing Piper", null },
                    { 12, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5397), "A movie about a Phone that is quite Amazing", 2, 99, "The Amazing Phone", null },
                    { 13, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5401), "A movie about a Swan that is quite Fast", 1, 192, "The Fast Swan", null },
                    { 14, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5435), "A movie about a Swan that is quite Fast", 1, 208, "The Fast Swan", null }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "movie_id", "starts_at" },
                values: new object[,]
                {
                    { 1, 3, 7, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, 1, 10, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, 2, 4, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, 2, 3, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, 2, 2, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6, 1, 1, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "customer_id", "screening_id", "created_at", "num_seats", "updated_at" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5550), 4, null },
                    { 2, 1, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5555), 1, null },
                    { 3, 4, new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5553), 2, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_movie_id",
                table: "screenings",
                column: "movie_id");

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
