using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<string>(type: "text", nullable: false),
                    runtime_minutes = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "screenings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    screen_number = table.Column<int>(type: "integer", nullable: false),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    StartsAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MovieId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_screenings_movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "Id", "email", "name", "phone" },
                values: new object[,]
                {
                    { 1, "Trym@Berger.no", "Trym Berger", "12459732" },
                    { 2, "mogak@haugan.no", "Monika Synnove", "56753212" }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "Id", "description", "rating", "title", "runtime_minutes" },
                values: new object[,]
                {
                    { 1, "Howl's Moving Castle is a 2004 Japanese animated fantasy film written and directed by Hayao Miyazaki", "Very good", "Howl's Moving Castle", 119 },
                    { 2, "A 1989 Japanese animated fantasy film written, produced, and directed by Hayao Miyazaki, based on Eiko Kadono's 1985 novel Kiki's Delivery Service.", "Very good", "Kiki's Delivery Service", 102 }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "Id", "Capacity", "MovieId", "screen_number", "StartsAt" },
                values: new object[,]
                {
                    { 1, 200, 1, 1, new DateTime(2025, 9, 12, 12, 30, 0, 0, DateTimeKind.Utc) },
                    { 2, 130, 2, 2, new DateTime(2025, 9, 13, 18, 30, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_MovieId",
                table: "screenings",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "screenings");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
