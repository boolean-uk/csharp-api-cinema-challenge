using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class AddSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "custommer",
                columns: table => new
                {
                    custommer_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "Date", nullable: false),
                    updated_at = table.Column<DateTime>(type: "Date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_custommer", x => x.custommer_id);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    movie_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<string>(type: "text", nullable: false),
                    runtime = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "Date", nullable: false),
                    updated_at = table.Column<DateTime>(type: "Date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.movie_id);
                });

            migrationBuilder.CreateTable(
                name: "screening",
                columns: table => new
                {
                    screening_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    screen_number = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    start_at = table.Column<DateTime>(type: "Date", nullable: false),
                    created_at = table.Column<DateTime>(type: "Date", nullable: false),
                    updated_at = table.Column<DateTime>(type: "Date", nullable: true),
                    MovieId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screening", x => x.screening_id);
                    table.ForeignKey(
                        name: "FK_screening_movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "movies",
                        principalColumn: "movie_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ticket",
                columns: table => new
                {
                    created_at = table.Column<DateTime>(type: "Date", nullable: false),
                    ScreeningId = table.Column<int>(type: "integer", nullable: false),
                    CustommerId = table.Column<int>(type: "integer", nullable: false),
                    ticket_id = table.Column<int>(type: "integer", nullable: false),
                    seat_number = table.Column<int>(type: "integer", nullable: false),
                    updated_at = table.Column<DateTime>(type: "Date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticket", x => new { x.ScreeningId, x.CustommerId, x.created_at });
                    table.ForeignKey(
                        name: "FK_ticket_custommer_CustommerId",
                        column: x => x.CustommerId,
                        principalTable: "custommer",
                        principalColumn: "custommer_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ticket_screening_ScreeningId",
                        column: x => x.ScreeningId,
                        principalTable: "screening",
                        principalColumn: "screening_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "custommer",
                columns: new[] { "custommer_id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 1, 27, 6, 10, 7, 607, DateTimeKind.Local), "QWER@hotmail.com", "Kanthee K", "111111", new DateTime(2022, 7, 28, 19, 11, 24, 622, DateTimeKind.Local) },
                    { 2, new DateTime(2019, 9, 14, 5, 35, 3, 27, DateTimeKind.Local), "1234A@hotmail.com", "Mohans M", "22222", new DateTime(2022, 12, 12, 18, 56, 13, 260, DateTimeKind.Local) },
                    { 3, new DateTime(2019, 8, 7, 6, 48, 41, 89, DateTimeKind.Local), "QDollkee@hotmail.com", "Sqlq Q", "33333", new DateTime(2022, 11, 2, 10, 12, 14, 357, DateTimeKind.Local) },
                    { 4, new DateTime(2019, 6, 30, 13, 59, 6, 252, DateTimeKind.Local), "XCXXx@hotmail.com", "Xcewwww", "44444", new DateTime(2022, 5, 17, 18, 5, 2, 886, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "movie_id", "created_at", "rating", "runtime", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2017, 8, 24, 21, 4, 53, 878, DateTimeKind.Local), "10", 160, "IRONMNAA", new DateTime(2022, 7, 23, 18, 43, 11, 249, DateTimeKind.Local) },
                    { 2, new DateTime(2004, 2, 21, 22, 24, 6, 878, DateTimeKind.Local), "2", 90, "BARbie", new DateTime(2022, 12, 26, 23, 21, 52, 422, DateTimeKind.Local) },
                    { 3, new DateTime(2003, 2, 3, 20, 8, 22, 172, DateTimeKind.Local), "5", 66, "Avatar", new DateTime(2022, 10, 12, 4, 37, 28, 471, DateTimeKind.Local) },
                    { 4, new DateTime(2006, 8, 11, 17, 35, 12, 226, DateTimeKind.Local), "9", 15, "Fight Club", new DateTime(2022, 1, 30, 23, 3, 11, 338, DateTimeKind.Local) },
                    { 5, new DateTime(2006, 12, 2, 19, 8, 51, 250, DateTimeKind.Local), "16", 200, "God Father", new DateTime(2022, 4, 21, 15, 53, 6, 540, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "screening",
                columns: new[] { "screening_id", "capacity", "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 50, new DateTime(2022, 9, 12, 12, 20, 19, 821, DateTimeKind.Local), 3, 4, new DateTime(2024, 2, 15, 16, 19, 31, 66, DateTimeKind.Local), new DateTime(2024, 1, 29, 10, 45, 47, 715, DateTimeKind.Local) },
                    { 2, 50, new DateTime(2022, 10, 10, 4, 56, 29, 935, DateTimeKind.Local), 4, 7, new DateTime(2024, 2, 26, 23, 50, 57, 848, DateTimeKind.Local), new DateTime(2024, 1, 22, 20, 26, 18, 507, DateTimeKind.Local) },
                    { 3, 50, new DateTime(2022, 1, 26, 15, 35, 2, 181, DateTimeKind.Local), 3, 8, new DateTime(2024, 2, 27, 10, 55, 25, 316, DateTimeKind.Local), new DateTime(2024, 1, 15, 15, 38, 31, 271, DateTimeKind.Local) },
                    { 4, 50, new DateTime(2022, 9, 20, 5, 3, 13, 119, DateTimeKind.Local), 3, 8, new DateTime(2024, 2, 27, 22, 21, 18, 524, DateTimeKind.Local), new DateTime(2024, 1, 16, 8, 45, 27, 413, DateTimeKind.Local) },
                    { 5, 50, new DateTime(2022, 9, 24, 12, 16, 53, 158, DateTimeKind.Local), 5, 4, new DateTime(2024, 2, 28, 2, 57, 0, 79, DateTimeKind.Local), new DateTime(2024, 1, 16, 16, 39, 31, 641, DateTimeKind.Local) },
                    { 6, 50, new DateTime(2022, 10, 9, 19, 56, 26, 588, DateTimeKind.Local), 2, 4, new DateTime(2024, 2, 28, 1, 50, 48, 318, DateTimeKind.Local), new DateTime(2024, 1, 20, 14, 32, 31, 291, DateTimeKind.Local) },
                    { 7, 50, new DateTime(2022, 6, 9, 10, 6, 12, 415, DateTimeKind.Local), 1, 1, new DateTime(2024, 2, 28, 3, 42, 56, 791, DateTimeKind.Local), new DateTime(2024, 1, 27, 4, 1, 0, 358, DateTimeKind.Local) },
                    { 8, 50, new DateTime(2022, 2, 3, 0, 44, 14, 223, DateTimeKind.Local), 3, 9, new DateTime(2024, 2, 28, 3, 44, 54, 40, DateTimeKind.Local), new DateTime(2024, 1, 17, 16, 33, 18, 782, DateTimeKind.Local) },
                    { 9, 50, new DateTime(2022, 10, 1, 22, 25, 42, 232, DateTimeKind.Local), 4, 6, new DateTime(2024, 2, 28, 3, 13, 25, 766, DateTimeKind.Local), new DateTime(2024, 1, 28, 0, 6, 46, 172, DateTimeKind.Local) },
                    { 10, 50, new DateTime(2022, 5, 22, 11, 32, 20, 895, DateTimeKind.Local), 4, 9, new DateTime(2024, 2, 28, 1, 48, 16, 446, DateTimeKind.Local), new DateTime(2024, 1, 18, 3, 56, 13, 48, DateTimeKind.Local) },
                    { 11, 50, new DateTime(2022, 5, 26, 21, 1, 43, 653, DateTimeKind.Local), 1, 3, new DateTime(2024, 2, 28, 4, 4, 35, 707, DateTimeKind.Local), new DateTime(2024, 1, 26, 10, 49, 4, 743, DateTimeKind.Local) },
                    { 12, 50, new DateTime(2022, 9, 14, 14, 3, 46, 653, DateTimeKind.Local), 3, 3, new DateTime(2024, 2, 28, 2, 21, 52, 568, DateTimeKind.Local), new DateTime(2024, 1, 23, 11, 24, 51, 706, DateTimeKind.Local) },
                    { 13, 50, new DateTime(2022, 1, 10, 15, 28, 0, 295, DateTimeKind.Local), 4, 9, new DateTime(2024, 2, 28, 2, 11, 23, 427, DateTimeKind.Local), new DateTime(2024, 1, 27, 22, 40, 33, 987, DateTimeKind.Local) },
                    { 14, 50, new DateTime(2022, 2, 23, 0, 20, 36, 260, DateTimeKind.Local), 1, 8, new DateTime(2024, 2, 28, 3, 28, 41, 743, DateTimeKind.Local), new DateTime(2024, 1, 18, 8, 15, 31, 64, DateTimeKind.Local) },
                    { 15, 50, new DateTime(2022, 5, 9, 9, 24, 41, 701, DateTimeKind.Local), 4, 6, new DateTime(2024, 2, 28, 1, 38, 2, 589, DateTimeKind.Local), new DateTime(2024, 1, 23, 4, 59, 28, 559, DateTimeKind.Local) },
                    { 16, 50, new DateTime(2022, 8, 18, 4, 28, 18, 53, DateTimeKind.Local), 5, 6, new DateTime(2024, 2, 28, 4, 50, 36, 41, DateTimeKind.Local), new DateTime(2024, 1, 17, 12, 36, 37, 507, DateTimeKind.Local) },
                    { 17, 50, new DateTime(2022, 3, 11, 12, 37, 8, 609, DateTimeKind.Local), 1, 5, new DateTime(2024, 2, 28, 6, 50, 32, 134, DateTimeKind.Local), new DateTime(2024, 1, 17, 19, 1, 2, 233, DateTimeKind.Local) },
                    { 18, 50, new DateTime(2022, 11, 6, 21, 7, 19, 971, DateTimeKind.Local), 3, 7, new DateTime(2024, 2, 28, 1, 12, 42, 422, DateTimeKind.Local), new DateTime(2024, 1, 28, 6, 57, 28, 391, DateTimeKind.Local) },
                    { 19, 50, new DateTime(2022, 7, 25, 2, 33, 15, 671, DateTimeKind.Local), 5, 6, new DateTime(2024, 2, 28, 3, 40, 2, 233, DateTimeKind.Local), new DateTime(2024, 1, 24, 15, 56, 30, 308, DateTimeKind.Local) },
                    { 20, 50, new DateTime(2022, 7, 26, 16, 22, 13, 743, DateTimeKind.Local), 3, 2, new DateTime(2024, 2, 28, 2, 18, 56, 882, DateTimeKind.Local), new DateTime(2024, 1, 18, 6, 34, 6, 522, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "ticket",
                columns: new[] { "created_at", "CustommerId", "ScreeningId", "ticket_id", "seat_number", "updated_at" },
                values: new object[,]
                {
                    { new DateTime(2022, 6, 29, 10, 7, 17, 360, DateTimeKind.Local), 4, 1, 13, 12, new DateTime(2024, 1, 18, 11, 25, 26, 294, DateTimeKind.Local) },
                    { new DateTime(2022, 3, 24, 18, 5, 52, 766, DateTimeKind.Local), 1, 3, 1, 3, new DateTime(2024, 1, 17, 7, 16, 1, 876, DateTimeKind.Local) },
                    { new DateTime(2022, 1, 10, 8, 12, 21, 580, DateTimeKind.Local), 1, 4, 17, 40, new DateTime(2024, 1, 19, 4, 23, 37, 17, DateTimeKind.Local) },
                    { new DateTime(2022, 1, 13, 14, 17, 52, 544, DateTimeKind.Local), 1, 5, 8, 9, new DateTime(2024, 1, 16, 18, 46, 36, 263, DateTimeKind.Local) },
                    { new DateTime(2022, 10, 27, 2, 41, 6, 653, DateTimeKind.Local), 4, 5, 14, 43, new DateTime(2024, 1, 16, 4, 3, 41, 416, DateTimeKind.Local) },
                    { new DateTime(2022, 6, 9, 17, 22, 12, 20, DateTimeKind.Local), 3, 6, 1, 31, new DateTime(2024, 1, 21, 15, 42, 36, 297, DateTimeKind.Local) },
                    { new DateTime(2022, 1, 9, 8, 19, 11, 997, DateTimeKind.Local), 1, 7, 3, 18, new DateTime(2024, 1, 28, 1, 24, 40, 998, DateTimeKind.Local) },
                    { new DateTime(2022, 3, 27, 15, 23, 53, 796, DateTimeKind.Local), 1, 7, 11, 32, new DateTime(2024, 1, 27, 0, 2, 14, 272, DateTimeKind.Local) },
                    { new DateTime(2022, 12, 5, 2, 50, 6, 209, DateTimeKind.Local), 2, 7, 6, 16, new DateTime(2024, 1, 28, 8, 26, 3, 32, DateTimeKind.Local) },
                    { new DateTime(2022, 7, 3, 14, 8, 25, 295, DateTimeKind.Local), 2, 9, 2, 17, new DateTime(2024, 1, 24, 17, 34, 30, 569, DateTimeKind.Local) },
                    { new DateTime(2022, 12, 30, 13, 43, 40, 599, DateTimeKind.Local), 1, 10, 7, 40, new DateTime(2024, 1, 19, 21, 21, 37, 476, DateTimeKind.Local) },
                    { new DateTime(2022, 10, 12, 20, 36, 18, 999, DateTimeKind.Local), 2, 11, 5, 2, new DateTime(2024, 1, 19, 21, 18, 45, 293, DateTimeKind.Local) },
                    { new DateTime(2022, 11, 2, 1, 9, 18, 100, DateTimeKind.Local), 4, 12, 15, 19, new DateTime(2024, 1, 26, 6, 42, 54, 649, DateTimeKind.Local) },
                    { new DateTime(2022, 8, 15, 1, 9, 5, 367, DateTimeKind.Local), 1, 15, 4, 37, new DateTime(2024, 1, 21, 1, 27, 21, 16, DateTimeKind.Local) },
                    { new DateTime(2022, 3, 6, 9, 14, 29, 922, DateTimeKind.Local), 2, 15, 9, 12, new DateTime(2024, 1, 26, 7, 23, 54, 555, DateTimeKind.Local) },
                    { new DateTime(2022, 10, 1, 18, 57, 46, 52, DateTimeKind.Local), 1, 17, 18, 44, new DateTime(2024, 1, 25, 10, 11, 3, 598, DateTimeKind.Local) },
                    { new DateTime(2022, 11, 18, 2, 15, 47, 413, DateTimeKind.Local), 2, 17, 16, 3, new DateTime(2024, 1, 16, 15, 53, 1, 381, DateTimeKind.Local) },
                    { new DateTime(2022, 8, 20, 9, 37, 40, 139, DateTimeKind.Local), 4, 17, 12, 43, new DateTime(2024, 1, 20, 17, 30, 5, 659, DateTimeKind.Local) },
                    { new DateTime(2022, 5, 21, 1, 31, 57, 781, DateTimeKind.Local), 1, 18, 19, 19, new DateTime(2024, 1, 27, 11, 23, 58, 684, DateTimeKind.Local) },
                    { new DateTime(2022, 3, 19, 0, 24, 44, 845, DateTimeKind.Local), 4, 19, 10, 10, new DateTime(2024, 1, 28, 3, 17, 53, 956, DateTimeKind.Local) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screening_MovieId",
                table: "screening",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_CustommerId",
                table: "ticket",
                column: "CustommerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ticket");

            migrationBuilder.DropTable(
                name: "custommer");

            migrationBuilder.DropTable(
                name: "screening");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
