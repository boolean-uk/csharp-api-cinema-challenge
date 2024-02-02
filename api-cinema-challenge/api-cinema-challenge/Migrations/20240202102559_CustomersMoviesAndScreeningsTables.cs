using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class CustomersMoviesAndScreeningsTables : Migration
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
                    movie_rating = table.Column<string>(type: "text", nullable: false),
                    movie_description = table.Column<string>(type: "text", nullable: false),
                    runtime_in_minutes = table.Column<int>(type: "integer", nullable: false),
                    creatd_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
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
                    movie_id = table.Column<int>(type: "integer", nullable: false),
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screening", x => x.id);
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
                    { 1, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), "donaldwinslet@gov.ru", "Donald Winslet", "+46123212321", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), "katewinfrey@gov.nl", "Kate Winfrey", "+46123456789", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), "mickwinfrey@theworld.ca", "Mick Winfrey", "+46123456789", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), "katehendrix@bbc.co.uk", "Kate Hendrix", "+46888888888", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "movie",
                columns: new[] { "id", "movie_description", "creatd_at", "movie_rating", "runtime_in_minutes", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, "Two Transparent Leopards", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), "PG-3", 15, "Fifteen Microscopic Planets", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, "The Orange Houses", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), "PG-7", 30, "An army of Rose Smelling Houses", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, "Two Rose Smelling Houses", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), "PG-7", 45, "The Orange Buildings", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, "Several Bitter Flowers", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), "R", 60, "Fifteen Transparent Houses", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "screening",
                columns: new[] { "id", "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 40, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), 2, 2, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, 40, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), 3, 1, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, 40, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), 3, 2, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, 40, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), 1, 1, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) }
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
                name: "customer");

            migrationBuilder.DropTable(
                name: "screening");

            migrationBuilder.DropTable(
                name: "movie");
        }
    }
}
