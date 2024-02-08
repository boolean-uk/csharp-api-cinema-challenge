using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingDatabase : Migration
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
                    description = table.Column<string>(type: "text", nullable: false),
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
                    ticket_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                    { 1, new DateTime(2018, 5, 29, 2, 26, 51, 867, DateTimeKind.Local), "QWER@hotmail.com", "Kanthee K", "111111", new DateTime(2022, 8, 5, 7, 41, 6, 783, DateTimeKind.Local) },
                    { 2, new DateTime(2018, 5, 20, 17, 2, 54, 601, DateTimeKind.Local), "1234A@hotmail.com", "Mohans M", "22222", new DateTime(2022, 7, 10, 8, 21, 1, 46, DateTimeKind.Local) },
                    { 3, new DateTime(2018, 8, 20, 5, 11, 28, 736, DateTimeKind.Local), "QDollkee@hotmail.com", "Sqlq Q", "33333", new DateTime(2022, 3, 31, 6, 33, 6, 491, DateTimeKind.Local) },
                    { 4, new DateTime(2019, 9, 29, 23, 44, 39, 557, DateTimeKind.Local), "XCXXx@hotmail.com", "Xcewwww", "44444", new DateTime(2022, 12, 26, 6, 48, 20, 576, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "movie_id", "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2014, 2, 2, 11, 23, 13, 222, DateTimeKind.Local), "NOOOO", "10", 160, "IRONMNAA", new DateTime(2022, 2, 21, 13, 5, 41, 672, DateTimeKind.Local) },
                    { 2, new DateTime(2003, 2, 18, 19, 36, 28, 900, DateTimeKind.Local), "OOOOHH NOOOOO", "2", 90, "BARbie", new DateTime(2022, 2, 16, 0, 13, 30, 102, DateTimeKind.Local) },
                    { 3, new DateTime(2011, 6, 1, 16, 5, 20, 774, DateTimeKind.Local), "OOHH OOHH NOOO", "5", 66, "Avatar", new DateTime(2022, 11, 4, 3, 7, 49, 265, DateTimeKind.Local) },
                    { 4, new DateTime(2011, 9, 24, 17, 32, 12, 424, DateTimeKind.Local), "OOOOHH YES", "9", 15, "Fight Club", new DateTime(2022, 2, 16, 1, 39, 15, 823, DateTimeKind.Local) },
                    { 5, new DateTime(2005, 9, 17, 5, 5, 28, 676, DateTimeKind.Local), "YEEEES", "16", 200, "God Father", new DateTime(2022, 8, 23, 21, 46, 32, 920, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "screening",
                columns: new[] { "screening_id", "capacity", "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 50, new DateTime(2022, 6, 24, 17, 35, 10, 567, DateTimeKind.Local), 5, 7, new DateTime(2024, 2, 19, 10, 37, 58, 223, DateTimeKind.Local), new DateTime(2024, 1, 24, 15, 5, 46, 131, DateTimeKind.Local) },
                    { 2, 50, new DateTime(2022, 1, 24, 3, 48, 9, 628, DateTimeKind.Local), 3, 5, new DateTime(2024, 2, 20, 12, 2, 51, 642, DateTimeKind.Local), new DateTime(2024, 1, 19, 17, 41, 23, 334, DateTimeKind.Local) },
                    { 3, 50, new DateTime(2022, 2, 3, 21, 9, 38, 975, DateTimeKind.Local), 3, 4, new DateTime(2024, 2, 22, 13, 13, 59, 706, DateTimeKind.Local), new DateTime(2024, 1, 26, 0, 54, 2, 167, DateTimeKind.Local) },
                    { 4, 50, new DateTime(2022, 4, 6, 15, 9, 24, 542, DateTimeKind.Local), 3, 9, new DateTime(2024, 2, 26, 13, 14, 22, 901, DateTimeKind.Local), new DateTime(2024, 1, 21, 7, 14, 9, 997, DateTimeKind.Local) },
                    { 5, 50, new DateTime(2022, 9, 4, 19, 45, 43, 309, DateTimeKind.Local), 5, 8, new DateTime(2024, 2, 27, 13, 2, 9, 581, DateTimeKind.Local), new DateTime(2024, 1, 20, 4, 33, 36, 48, DateTimeKind.Local) },
                    { 6, 50, new DateTime(2022, 5, 4, 23, 54, 40, 189, DateTimeKind.Local), 2, 1, new DateTime(2024, 2, 27, 19, 41, 17, 832, DateTimeKind.Local), new DateTime(2024, 1, 23, 9, 53, 50, 591, DateTimeKind.Local) },
                    { 7, 50, new DateTime(2022, 5, 20, 13, 4, 24, 833, DateTimeKind.Local), 4, 5, new DateTime(2024, 2, 27, 23, 38, 22, 688, DateTimeKind.Local), new DateTime(2024, 1, 21, 1, 38, 22, 389, DateTimeKind.Local) },
                    { 8, 50, new DateTime(2022, 1, 8, 8, 35, 53, 536, DateTimeKind.Local), 3, 7, new DateTime(2024, 2, 28, 0, 52, 32, 563, DateTimeKind.Local), new DateTime(2024, 1, 29, 8, 49, 36, 187, DateTimeKind.Local) },
                    { 9, 50, new DateTime(2022, 4, 8, 18, 13, 46, 349, DateTimeKind.Local), 1, 5, new DateTime(2024, 2, 28, 3, 25, 36, 6, DateTimeKind.Local), new DateTime(2024, 1, 24, 22, 44, 11, 984, DateTimeKind.Local) },
                    { 10, 50, new DateTime(2022, 11, 1, 21, 23, 10, 222, DateTimeKind.Local), 3, 1, new DateTime(2024, 2, 28, 1, 27, 22, 96, DateTimeKind.Local), new DateTime(2024, 1, 29, 0, 9, 20, 17, DateTimeKind.Local) },
                    { 11, 50, new DateTime(2022, 11, 4, 6, 26, 43, 536, DateTimeKind.Local), 1, 8, new DateTime(2024, 2, 28, 3, 32, 38, 88, DateTimeKind.Local), new DateTime(2024, 1, 29, 2, 16, 43, 563, DateTimeKind.Local) },
                    { 12, 50, new DateTime(2022, 4, 4, 5, 9, 48, 807, DateTimeKind.Local), 1, 5, new DateTime(2024, 2, 28, 5, 32, 30, 790, DateTimeKind.Local), new DateTime(2024, 1, 20, 4, 6, 59, 875, DateTimeKind.Local) },
                    { 13, 50, new DateTime(2022, 7, 29, 0, 24, 17, 6, DateTimeKind.Local), 1, 5, new DateTime(2024, 2, 28, 4, 54, 52, 717, DateTimeKind.Local), new DateTime(2024, 1, 17, 12, 20, 17, 501, DateTimeKind.Local) },
                    { 14, 50, new DateTime(2022, 1, 1, 0, 26, 47, 102, DateTimeKind.Local), 3, 5, new DateTime(2024, 2, 28, 5, 18, 40, 175, DateTimeKind.Local), new DateTime(2024, 1, 26, 15, 25, 1, 255, DateTimeKind.Local) },
                    { 15, 50, new DateTime(2022, 8, 1, 12, 28, 34, 659, DateTimeKind.Local), 4, 1, new DateTime(2024, 2, 28, 1, 1, 13, 888, DateTimeKind.Local), new DateTime(2024, 1, 16, 4, 33, 58, 465, DateTimeKind.Local) },
                    { 16, 50, new DateTime(2022, 5, 17, 18, 1, 27, 115, DateTimeKind.Local), 4, 8, new DateTime(2024, 2, 28, 1, 14, 19, 36, DateTimeKind.Local), new DateTime(2024, 1, 24, 16, 58, 44, 227, DateTimeKind.Local) },
                    { 17, 50, new DateTime(2022, 2, 26, 23, 57, 55, 478, DateTimeKind.Local), 3, 4, new DateTime(2024, 2, 28, 1, 20, 1, 120, DateTimeKind.Local), new DateTime(2024, 1, 19, 10, 41, 31, 351, DateTimeKind.Local) },
                    { 18, 50, new DateTime(2022, 7, 10, 20, 1, 26, 316, DateTimeKind.Local), 5, 6, new DateTime(2024, 2, 28, 3, 35, 23, 529, DateTimeKind.Local), new DateTime(2024, 1, 24, 20, 46, 57, 429, DateTimeKind.Local) },
                    { 19, 50, new DateTime(2022, 5, 21, 12, 58, 16, 355, DateTimeKind.Local), 1, 9, new DateTime(2024, 2, 28, 4, 36, 36, 298, DateTimeKind.Local), new DateTime(2024, 1, 28, 0, 55, 2, 755, DateTimeKind.Local) },
                    { 20, 50, new DateTime(2022, 6, 1, 21, 37, 5, 928, DateTimeKind.Local), 4, 6, new DateTime(2024, 2, 28, 1, 50, 37, 995, DateTimeKind.Local), new DateTime(2024, 1, 18, 9, 45, 7, 575, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "ticket",
                columns: new[] { "created_at", "CustommerId", "ScreeningId", "ticket_id", "seat_number", "updated_at" },
                values: new object[,]
                {
                    { new DateTime(2022, 3, 11, 0, 24, 37, 713, DateTimeKind.Local), 2, 1, 2, 6, new DateTime(2024, 1, 26, 14, 1, 16, 139, DateTimeKind.Local) },
                    { new DateTime(2022, 2, 17, 10, 1, 1, 911, DateTimeKind.Local), 4, 1, 11, 23, new DateTime(2024, 1, 20, 16, 28, 46, 608, DateTimeKind.Local) },
                    { new DateTime(2022, 7, 25, 10, 7, 4, 660, DateTimeKind.Local), 4, 2, 12, 4, new DateTime(2024, 1, 20, 16, 18, 26, 389, DateTimeKind.Local) },
                    { new DateTime(2022, 3, 15, 6, 26, 4, 640, DateTimeKind.Local), 1, 3, 18, 14, new DateTime(2024, 1, 28, 0, 24, 0, 441, DateTimeKind.Local) },
                    { new DateTime(2022, 5, 12, 8, 47, 0, 952, DateTimeKind.Local), 2, 3, 15, 3, new DateTime(2024, 1, 23, 13, 0, 7, 160, DateTimeKind.Local) },
                    { new DateTime(2022, 4, 8, 7, 0, 9, 679, DateTimeKind.Local), 3, 3, 10, 0, new DateTime(2024, 1, 27, 6, 49, 53, 487, DateTimeKind.Local) },
                    { new DateTime(2022, 12, 18, 0, 35, 47, 315, DateTimeKind.Local), 1, 4, 3, 1, new DateTime(2024, 1, 22, 22, 49, 5, 785, DateTimeKind.Local) },
                    { new DateTime(2022, 1, 4, 5, 57, 43, 658, DateTimeKind.Local), 2, 4, 6, 10, new DateTime(2024, 1, 18, 12, 41, 19, 949, DateTimeKind.Local) },
                    { new DateTime(2022, 12, 16, 16, 22, 21, 938, DateTimeKind.Local), 3, 4, 14, 49, new DateTime(2024, 1, 23, 8, 24, 54, 574, DateTimeKind.Local) },
                    { new DateTime(2022, 10, 22, 14, 21, 48, 447, DateTimeKind.Local), 3, 5, 5, 4, new DateTime(2024, 1, 18, 17, 25, 47, 828, DateTimeKind.Local) },
                    { new DateTime(2022, 1, 20, 5, 27, 24, 269, DateTimeKind.Local), 4, 5, 8, 49, new DateTime(2024, 1, 18, 0, 28, 18, 670, DateTimeKind.Local) },
                    { new DateTime(2022, 1, 21, 20, 17, 55, 156, DateTimeKind.Local), 4, 5, 7, 23, new DateTime(2024, 1, 22, 12, 23, 27, 115, DateTimeKind.Local) },
                    { new DateTime(2022, 4, 19, 0, 40, 7, 402, DateTimeKind.Local), 3, 7, 13, 47, new DateTime(2024, 1, 20, 17, 27, 39, 152, DateTimeKind.Local) },
                    { new DateTime(2022, 7, 24, 20, 57, 8, 846, DateTimeKind.Local), 1, 9, 16, 3, new DateTime(2024, 1, 17, 18, 47, 37, 67, DateTimeKind.Local) },
                    { new DateTime(2022, 1, 22, 15, 40, 38, 923, DateTimeKind.Local), 4, 9, 9, 47, new DateTime(2024, 1, 25, 10, 44, 46, 317, DateTimeKind.Local) },
                    { new DateTime(2022, 12, 6, 12, 32, 37, 128, DateTimeKind.Local), 1, 10, 17, 27, new DateTime(2024, 1, 15, 23, 8, 31, 404, DateTimeKind.Local) },
                    { new DateTime(2022, 10, 6, 17, 27, 29, 334, DateTimeKind.Local), 2, 10, 1, 48, new DateTime(2024, 1, 16, 23, 1, 44, 445, DateTimeKind.Local) },
                    { new DateTime(2022, 4, 5, 0, 13, 27, 957, DateTimeKind.Local), 1, 16, 4, 43, new DateTime(2024, 1, 29, 13, 2, 52, 379, DateTimeKind.Local) },
                    { new DateTime(2022, 6, 16, 12, 19, 19, 673, DateTimeKind.Local), 3, 18, 1, 23, new DateTime(2024, 1, 26, 19, 46, 39, 467, DateTimeKind.Local) },
                    { new DateTime(2022, 11, 26, 15, 29, 43, 211, DateTimeKind.Local), 4, 18, 19, 1, new DateTime(2024, 1, 16, 0, 11, 52, 607, DateTimeKind.Local) }
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
