using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<string>(type: "text", nullable: false),
                    descrpition = table.Column<string>(type: "text", nullable: false),
                    runTimeMins = table.Column<int>(type: "integer", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    screennumber = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    startsAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    movie_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => x.id);
                    table.ForeignKey(
                        name: "FK_screenings_movies_movie_id",
                        column: x => x.movie_id,
                        principalTable: "movies",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    screening_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.id);
                    table.ForeignKey(
                        name: "FK_customers_screenings_screening_id",
                        column: x => x.screening_id,
                        principalTable: "screenings",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "createdAt", "descrpition", "rating", "runTimeMins", "title", "updatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 17, 21, 6, 33, 93, DateTimeKind.Utc).AddTicks(2069), "Typical Bollywood", "6", 184, "Bodyguard", new DateTime(2024, 9, 17, 21, 6, 33, 93, DateTimeKind.Utc).AddTicks(2071) },
                    { 2, new DateTime(2024, 9, 17, 21, 6, 33, 93, DateTimeKind.Utc).AddTicks(2076), "Love story", "5", 200, "DDLJ", new DateTime(2024, 9, 17, 21, 6, 33, 93, DateTimeKind.Utc).AddTicks(2077) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "createdAt", "movie_id", "screennumber", "startsAt", "updatedAt" },
                values: new object[,]
                {
                    { 1, 50, new DateTime(2024, 9, 17, 21, 6, 33, 93, DateTimeKind.Utc).AddTicks(2127), 1, 1, new DateTime(2024, 9, 17, 21, 6, 33, 93, DateTimeKind.Utc).AddTicks(2125), new DateTime(2024, 9, 17, 21, 6, 33, 93, DateTimeKind.Utc).AddTicks(2128) },
                    { 2, 100, new DateTime(2024, 9, 17, 21, 6, 33, 93, DateTimeKind.Utc).AddTicks(2140), 2, 2, new DateTime(2024, 9, 17, 21, 6, 33, 93, DateTimeKind.Utc).AddTicks(2139), new DateTime(2024, 9, 17, 21, 6, 33, 93, DateTimeKind.Utc).AddTicks(2141) }
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "email", "name", "phone", "screening_id", "createdAt", "updatedAt" },
                values: new object[,]
                {
                    { 1, "aliali@live.no", "Ali Haider Khan", "112", 1, new DateTime(2024, 9, 17, 21, 6, 33, 93, DateTimeKind.Utc).AddTicks(1765), new DateTime(2024, 9, 17, 21, 6, 33, 93, DateTimeKind.Utc).AddTicks(1770) },
                    { 2, "messi786@live.com", "Lionel Messi", "1881", 2, new DateTime(2024, 9, 17, 21, 6, 33, 93, DateTimeKind.Utc).AddTicks(1785), new DateTime(2024, 9, 17, 21, 6, 33, 93, DateTimeKind.Utc).AddTicks(1786) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_customers_screening_id",
                table: "customers",
                column: "screening_id");

            migrationBuilder.CreateIndex(
                name: "IX_screenings_movie_id",
                table: "screenings",
                column: "movie_id");
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
