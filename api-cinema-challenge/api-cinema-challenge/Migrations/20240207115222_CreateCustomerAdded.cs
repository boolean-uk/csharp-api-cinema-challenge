using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class CreateCustomerAdded : Migration
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
                    decription = table.Column<string>(type: "text", nullable: false),
                    runtime_mins = table.Column<int>(type: "integer", nullable: false),
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
                    movie_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    { 1, new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), "onilmobil@gmail.com", "Oneal", "94557112", new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) },
                    { 2, new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), "fedme@hotmail.com", "Orjan", "55678946", new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) },
                    { 3, new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), "nitterISkjegget@online.no", "Reidar", "12345678", new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "decription", "rating", "runtime_mins", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), "Greatest superhero movie ever.", "PG-13", 152, "The Dark Knight", new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) },
                    { 2, new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), "Bon giourno.", "R", 153, "Inglourious Basterds", new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) },
                    { 3, new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), "I AM the Senate", "PG", 140, "Star Wars: Revenge of the Sith", new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 200, new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), 1, 1, new DateTime(2024, 2, 8, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) },
                    { 2, 150, new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), 2, 2, new DateTime(2024, 2, 9, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) },
                    { 3, 75, new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), 3, 3, new DateTime(2024, 2, 10, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "created_at", "customer_id", "num_seats", "screening_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), 1, 3, 1, new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) },
                    { 2, new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), 2, 1, 2, new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) },
                    { 3, new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), 3, 3, 3, new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) }
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
