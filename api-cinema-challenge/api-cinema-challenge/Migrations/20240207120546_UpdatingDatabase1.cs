using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingDatabase1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 6, 29, 10, 7, 17, 360, DateTimeKind.Local), 4, 1 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 18, 5, 52, 766, DateTimeKind.Local), 1, 3 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 1, 10, 8, 12, 21, 580, DateTimeKind.Local), 1, 4 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 1, 13, 14, 17, 52, 544, DateTimeKind.Local), 1, 5 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 10, 27, 2, 41, 6, 653, DateTimeKind.Local), 4, 5 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 6, 9, 17, 22, 12, 20, DateTimeKind.Local), 3, 6 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 1, 9, 8, 19, 11, 997, DateTimeKind.Local), 1, 7 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 3, 27, 15, 23, 53, 796, DateTimeKind.Local), 1, 7 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 12, 5, 2, 50, 6, 209, DateTimeKind.Local), 2, 7 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 7, 3, 14, 8, 25, 295, DateTimeKind.Local), 2, 9 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 12, 30, 13, 43, 40, 599, DateTimeKind.Local), 1, 10 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 10, 12, 20, 36, 18, 999, DateTimeKind.Local), 2, 11 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 11, 2, 1, 9, 18, 100, DateTimeKind.Local), 4, 12 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 8, 15, 1, 9, 5, 367, DateTimeKind.Local), 1, 15 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 3, 6, 9, 14, 29, 922, DateTimeKind.Local), 2, 15 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 10, 1, 18, 57, 46, 52, DateTimeKind.Local), 1, 17 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 11, 18, 2, 15, 47, 413, DateTimeKind.Local), 2, 17 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 8, 20, 9, 37, 40, 139, DateTimeKind.Local), 4, 17 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 5, 21, 1, 31, 57, 781, DateTimeKind.Local), 1, 18 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 3, 19, 0, 24, 44, 845, DateTimeKind.Local), 4, 19 });

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "movies",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "custommer",
                keyColumn: "custommer_id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2018, 3, 16, 23, 15, 17, 413, DateTimeKind.Local), new DateTime(2022, 5, 15, 11, 10, 7, 542, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "custommer",
                keyColumn: "custommer_id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 1, 2, 16, 31, 7, 758, DateTimeKind.Local), new DateTime(2022, 11, 3, 23, 5, 2, 346, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "custommer",
                keyColumn: "custommer_id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 4, 8, 22, 5, 1, 973, DateTimeKind.Local), new DateTime(2022, 9, 9, 2, 54, 55, 815, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "custommer",
                keyColumn: "custommer_id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 4, 2, 10, 57, 43, 45, DateTimeKind.Local), new DateTime(2022, 9, 10, 1, 36, 23, 821, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 1,
                columns: new[] { "created_at", "description", "updated_at" },
                values: new object[] { new DateTime(2007, 3, 23, 8, 16, 21, 953, DateTimeKind.Local), "NOOOO", new DateTime(2022, 10, 8, 15, 17, 54, 547, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 2,
                columns: new[] { "created_at", "description", "updated_at" },
                values: new object[] { new DateTime(2017, 8, 26, 23, 5, 24, 181, DateTimeKind.Local), "OOOOHH NOOOOO", new DateTime(2022, 12, 16, 9, 43, 39, 660, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 3,
                columns: new[] { "created_at", "description", "updated_at" },
                values: new object[] { new DateTime(2012, 8, 10, 16, 53, 30, 123, DateTimeKind.Local), "OOHH OOHH NOOO", new DateTime(2022, 12, 21, 2, 58, 6, 245, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 4,
                columns: new[] { "created_at", "description", "updated_at" },
                values: new object[] { new DateTime(2002, 6, 1, 19, 42, 58, 815, DateTimeKind.Local), "OOOOHH YES", new DateTime(2022, 7, 1, 11, 10, 44, 585, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 5,
                columns: new[] { "created_at", "description", "updated_at" },
                values: new object[] { new DateTime(2000, 1, 15, 1, 28, 24, 389, DateTimeKind.Local), "YEEEES", new DateTime(2022, 11, 25, 15, 24, 35, 272, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 1,
                columns: new[] { "created_at", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 10, 27, 23, 48, 41, 813, DateTimeKind.Local), 2, new DateTime(2024, 2, 21, 14, 0, 18, 444, DateTimeKind.Local), new DateTime(2024, 1, 26, 19, 48, 55, 654, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 2,
                columns: new[] { "created_at", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 10, 6, 7, 43, 29, 978, DateTimeKind.Local), 1, new DateTime(2024, 2, 22, 6, 16, 32, 146, DateTimeKind.Local), new DateTime(2024, 1, 19, 19, 49, 35, 401, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 3,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 12, 3, 13, 32, 8, 87, DateTimeKind.Local), 2, 2, new DateTime(2024, 2, 22, 22, 48, 48, 147, DateTimeKind.Local), new DateTime(2024, 1, 15, 23, 22, 34, 179, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 4,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 11, 11, 2, 18, 54, 207, DateTimeKind.Local), 5, 9, new DateTime(2024, 2, 26, 8, 18, 25, 989, DateTimeKind.Local), new DateTime(2024, 1, 26, 9, 42, 22, 231, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 5,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 7, 3, 10, 15, 51, 629, DateTimeKind.Local), 4, 3, new DateTime(2024, 2, 27, 17, 45, 55, 22, DateTimeKind.Local), new DateTime(2024, 1, 29, 15, 58, 7, 75, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 6,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 3, 19, 6, 34, 25, 61, DateTimeKind.Local), 3, 9, new DateTime(2024, 2, 27, 23, 8, 29, 907, DateTimeKind.Local), new DateTime(2024, 1, 29, 6, 30, 23, 45, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 7,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 9, 15, 9, 31, 38, 493, DateTimeKind.Local), 5, 5, new DateTime(2024, 2, 28, 2, 49, 30, 665, DateTimeKind.Local), new DateTime(2024, 1, 15, 3, 44, 20, 87, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 8,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 10, 4, 0, 56, 49, 687, DateTimeKind.Local), 1, 5, new DateTime(2024, 2, 28, 3, 48, 32, 21, DateTimeKind.Local), new DateTime(2024, 1, 19, 3, 26, 45, 571, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 9,
                columns: new[] { "created_at", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 7, 11, 37, 1, 774, DateTimeKind.Local), 5, new DateTime(2024, 2, 28, 3, 32, 44, 414, DateTimeKind.Local), new DateTime(2024, 1, 26, 22, 52, 15, 464, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 10,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 9, 7, 22, 12, 36, 301, DateTimeKind.Local), 2, 2, new DateTime(2024, 2, 28, 3, 26, 27, 337, DateTimeKind.Local), new DateTime(2024, 1, 28, 16, 12, 51, 818, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 11,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 8, 12, 0, 58, 59, 572, DateTimeKind.Local), 3, 5, new DateTime(2024, 2, 28, 2, 31, 7, 761, DateTimeKind.Local), new DateTime(2024, 1, 18, 14, 54, 18, 420, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 12,
                columns: new[] { "created_at", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 3, 1, 7, 45, 30, 305, DateTimeKind.Local), 1, new DateTime(2024, 2, 28, 3, 1, 7, 677, DateTimeKind.Local), new DateTime(2024, 1, 23, 12, 46, 25, 735, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 13,
                columns: new[] { "created_at", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 1, 21, 22, 58, 6, 529, DateTimeKind.Local), 4, new DateTime(2024, 2, 28, 1, 32, 43, 713, DateTimeKind.Local), new DateTime(2024, 1, 23, 3, 18, 29, 255, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 14,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 3, 28, 2, 8, 50, 408, DateTimeKind.Local), 2, 7, new DateTime(2024, 2, 28, 1, 36, 21, 376, DateTimeKind.Local), new DateTime(2024, 1, 19, 9, 45, 52, 43, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 15,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 9, 11, 9, 5, 36, 738, DateTimeKind.Local), 1, 5, new DateTime(2024, 2, 28, 3, 14, 18, 496, DateTimeKind.Local), new DateTime(2024, 1, 17, 1, 31, 53, 358, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 16,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 2, 4, 0, 6, 19, 685, DateTimeKind.Local), 4, 8, new DateTime(2024, 2, 28, 1, 49, 11, 339, DateTimeKind.Local), new DateTime(2024, 1, 24, 21, 44, 32, 881, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 17,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 12, 2, 19, 5, 49, 167, DateTimeKind.Local), 4, 3, new DateTime(2024, 2, 28, 0, 59, 9, 960, DateTimeKind.Local), new DateTime(2024, 1, 21, 8, 9, 0, 82, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 18,
                columns: new[] { "created_at", "MovieId", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 8, 15, 19, 25, 11, 792, DateTimeKind.Local), 2, new DateTime(2024, 2, 28, 2, 17, 23, 32, DateTimeKind.Local), new DateTime(2024, 1, 22, 9, 50, 51, 734, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 19,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 1, 19, 11, 40, 34, 848, DateTimeKind.Local), 4, 7, new DateTime(2024, 2, 28, 1, 14, 4, 67, DateTimeKind.Local), new DateTime(2024, 1, 29, 21, 21, 44, 635, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 20,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 12, 26, 16, 23, 28, 899, DateTimeKind.Local), 5, 1, new DateTime(2024, 2, 28, 4, 22, 46, 271, DateTimeKind.Local), new DateTime(2024, 1, 20, 8, 5, 18, 568, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "ticket",
                columns: new[] { "created_at", "CustommerId", "ScreeningId", "ticket_id", "seat_number", "updated_at" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 21, 16, 35, 40, 325, DateTimeKind.Local), 3, 1, 1, 35, new DateTime(2024, 1, 25, 2, 26, 44, 838, DateTimeKind.Local) },
                    { new DateTime(2022, 8, 25, 17, 57, 26, 931, DateTimeKind.Local), 3, 1, 3, 10, new DateTime(2024, 1, 29, 2, 13, 5, 369, DateTimeKind.Local) },
                    { new DateTime(2022, 11, 11, 12, 7, 34, 260, DateTimeKind.Local), 3, 1, 13, 5, new DateTime(2024, 1, 26, 23, 34, 38, 600, DateTimeKind.Local) },
                    { new DateTime(2022, 1, 23, 18, 42, 39, 711, DateTimeKind.Local), 1, 2, 8, 34, new DateTime(2024, 1, 26, 0, 56, 19, 466, DateTimeKind.Local) },
                    { new DateTime(2022, 1, 12, 23, 41, 35, 5, DateTimeKind.Local), 2, 2, 7, 23, new DateTime(2024, 1, 21, 13, 31, 49, 580, DateTimeKind.Local) },
                    { new DateTime(2022, 9, 28, 22, 2, 43, 511, DateTimeKind.Local), 3, 2, 12, 31, new DateTime(2024, 1, 20, 7, 28, 41, 325, DateTimeKind.Local) },
                    { new DateTime(2022, 5, 3, 4, 58, 30, 425, DateTimeKind.Local), 3, 3, 18, 41, new DateTime(2024, 1, 23, 20, 20, 40, 160, DateTimeKind.Local) },
                    { new DateTime(2022, 10, 29, 3, 20, 39, 201, DateTimeKind.Local), 3, 3, 5, 17, new DateTime(2024, 1, 17, 22, 47, 14, 598, DateTimeKind.Local) },
                    { new DateTime(2022, 11, 24, 3, 44, 22, 592, DateTimeKind.Local), 3, 4, 10, 36, new DateTime(2024, 1, 21, 8, 11, 0, 38, DateTimeKind.Local) },
                    { new DateTime(2022, 11, 20, 22, 53, 36, 771, DateTimeKind.Local), 2, 5, 1, 33, new DateTime(2024, 1, 29, 23, 14, 40, 203, DateTimeKind.Local) },
                    { new DateTime(2022, 9, 24, 10, 26, 35, 114, DateTimeKind.Local), 2, 9, 14, 8, new DateTime(2024, 1, 26, 12, 29, 5, 741, DateTimeKind.Local) },
                    { new DateTime(2022, 12, 6, 14, 46, 1, 359, DateTimeKind.Local), 2, 9, 11, 9, new DateTime(2024, 1, 23, 9, 27, 44, 241, DateTimeKind.Local) },
                    { new DateTime(2022, 8, 7, 1, 39, 47, 20, DateTimeKind.Local), 1, 12, 6, 2, new DateTime(2024, 1, 22, 11, 39, 0, 666, DateTimeKind.Local) },
                    { new DateTime(2022, 3, 1, 15, 6, 54, 644, DateTimeKind.Local), 1, 13, 2, 28, new DateTime(2024, 1, 18, 19, 42, 9, 581, DateTimeKind.Local) },
                    { new DateTime(2022, 11, 7, 15, 19, 17, 314, DateTimeKind.Local), 2, 14, 15, 31, new DateTime(2024, 1, 27, 21, 50, 28, 636, DateTimeKind.Local) },
                    { new DateTime(2022, 9, 16, 18, 40, 53, 197, DateTimeKind.Local), 4, 14, 19, 5, new DateTime(2024, 1, 17, 0, 24, 0, 250, DateTimeKind.Local) },
                    { new DateTime(2022, 9, 5, 11, 32, 13, 628, DateTimeKind.Local), 1, 15, 9, 10, new DateTime(2024, 1, 22, 6, 39, 32, 413, DateTimeKind.Local) },
                    { new DateTime(2022, 4, 26, 22, 48, 58, 785, DateTimeKind.Local), 1, 19, 17, 42, new DateTime(2024, 1, 20, 22, 4, 53, 465, DateTimeKind.Local) },
                    { new DateTime(2022, 9, 7, 21, 11, 6, 61, DateTimeKind.Local), 2, 19, 16, 5, new DateTime(2024, 1, 20, 21, 59, 10, 867, DateTimeKind.Local) },
                    { new DateTime(2022, 1, 16, 8, 18, 28, 213, DateTimeKind.Local), 3, 19, 4, 8, new DateTime(2024, 1, 17, 5, 21, 47, 794, DateTimeKind.Local) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 4, 21, 16, 35, 40, 325, DateTimeKind.Local), 3, 1 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 8, 25, 17, 57, 26, 931, DateTimeKind.Local), 3, 1 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 11, 11, 12, 7, 34, 260, DateTimeKind.Local), 3, 1 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 1, 23, 18, 42, 39, 711, DateTimeKind.Local), 1, 2 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 1, 12, 23, 41, 35, 5, DateTimeKind.Local), 2, 2 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 9, 28, 22, 2, 43, 511, DateTimeKind.Local), 3, 2 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 5, 3, 4, 58, 30, 425, DateTimeKind.Local), 3, 3 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 10, 29, 3, 20, 39, 201, DateTimeKind.Local), 3, 3 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 11, 24, 3, 44, 22, 592, DateTimeKind.Local), 3, 4 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 11, 20, 22, 53, 36, 771, DateTimeKind.Local), 2, 5 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 9, 24, 10, 26, 35, 114, DateTimeKind.Local), 2, 9 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 12, 6, 14, 46, 1, 359, DateTimeKind.Local), 2, 9 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 8, 7, 1, 39, 47, 20, DateTimeKind.Local), 1, 12 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 3, 1, 15, 6, 54, 644, DateTimeKind.Local), 1, 13 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 11, 7, 15, 19, 17, 314, DateTimeKind.Local), 2, 14 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 9, 16, 18, 40, 53, 197, DateTimeKind.Local), 4, 14 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 9, 5, 11, 32, 13, 628, DateTimeKind.Local), 1, 15 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 4, 26, 22, 48, 58, 785, DateTimeKind.Local), 1, 19 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 9, 7, 21, 11, 6, 61, DateTimeKind.Local), 2, 19 });

            migrationBuilder.DeleteData(
                table: "ticket",
                keyColumns: new[] { "created_at", "CustommerId", "ScreeningId" },
                keyValues: new object[] { new DateTime(2022, 1, 16, 8, 18, 28, 213, DateTimeKind.Local), 3, 19 });

            migrationBuilder.DropColumn(
                name: "description",
                table: "movies");

            migrationBuilder.UpdateData(
                table: "custommer",
                keyColumn: "custommer_id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 1, 27, 6, 10, 7, 607, DateTimeKind.Local), new DateTime(2022, 7, 28, 19, 11, 24, 622, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "custommer",
                keyColumn: "custommer_id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 9, 14, 5, 35, 3, 27, DateTimeKind.Local), new DateTime(2022, 12, 12, 18, 56, 13, 260, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "custommer",
                keyColumn: "custommer_id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 8, 7, 6, 48, 41, 89, DateTimeKind.Local), new DateTime(2022, 11, 2, 10, 12, 14, 357, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "custommer",
                keyColumn: "custommer_id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 6, 30, 13, 59, 6, 252, DateTimeKind.Local), new DateTime(2022, 5, 17, 18, 5, 2, 886, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2017, 8, 24, 21, 4, 53, 878, DateTimeKind.Local), new DateTime(2022, 7, 23, 18, 43, 11, 249, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2004, 2, 21, 22, 24, 6, 878, DateTimeKind.Local), new DateTime(2022, 12, 26, 23, 21, 52, 422, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2003, 2, 3, 20, 8, 22, 172, DateTimeKind.Local), new DateTime(2022, 10, 12, 4, 37, 28, 471, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 8, 11, 17, 35, 12, 226, DateTimeKind.Local), new DateTime(2022, 1, 30, 23, 3, 11, 338, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 12, 2, 19, 8, 51, 250, DateTimeKind.Local), new DateTime(2022, 4, 21, 15, 53, 6, 540, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 1,
                columns: new[] { "created_at", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 9, 12, 12, 20, 19, 821, DateTimeKind.Local), 4, new DateTime(2024, 2, 15, 16, 19, 31, 66, DateTimeKind.Local), new DateTime(2024, 1, 29, 10, 45, 47, 715, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 2,
                columns: new[] { "created_at", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 10, 10, 4, 56, 29, 935, DateTimeKind.Local), 7, new DateTime(2024, 2, 26, 23, 50, 57, 848, DateTimeKind.Local), new DateTime(2024, 1, 22, 20, 26, 18, 507, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 3,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 1, 26, 15, 35, 2, 181, DateTimeKind.Local), 3, 8, new DateTime(2024, 2, 27, 10, 55, 25, 316, DateTimeKind.Local), new DateTime(2024, 1, 15, 15, 38, 31, 271, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 4,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 9, 20, 5, 3, 13, 119, DateTimeKind.Local), 3, 8, new DateTime(2024, 2, 27, 22, 21, 18, 524, DateTimeKind.Local), new DateTime(2024, 1, 16, 8, 45, 27, 413, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 5,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 9, 24, 12, 16, 53, 158, DateTimeKind.Local), 5, 4, new DateTime(2024, 2, 28, 2, 57, 0, 79, DateTimeKind.Local), new DateTime(2024, 1, 16, 16, 39, 31, 641, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 6,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 10, 9, 19, 56, 26, 588, DateTimeKind.Local), 2, 4, new DateTime(2024, 2, 28, 1, 50, 48, 318, DateTimeKind.Local), new DateTime(2024, 1, 20, 14, 32, 31, 291, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 7,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 6, 9, 10, 6, 12, 415, DateTimeKind.Local), 1, 1, new DateTime(2024, 2, 28, 3, 42, 56, 791, DateTimeKind.Local), new DateTime(2024, 1, 27, 4, 1, 0, 358, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 8,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 2, 3, 0, 44, 14, 223, DateTimeKind.Local), 3, 9, new DateTime(2024, 2, 28, 3, 44, 54, 40, DateTimeKind.Local), new DateTime(2024, 1, 17, 16, 33, 18, 782, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 9,
                columns: new[] { "created_at", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 25, 42, 232, DateTimeKind.Local), 6, new DateTime(2024, 2, 28, 3, 13, 25, 766, DateTimeKind.Local), new DateTime(2024, 1, 28, 0, 6, 46, 172, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 10,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 22, 11, 32, 20, 895, DateTimeKind.Local), 4, 9, new DateTime(2024, 2, 28, 1, 48, 16, 446, DateTimeKind.Local), new DateTime(2024, 1, 18, 3, 56, 13, 48, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 11,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 21, 1, 43, 653, DateTimeKind.Local), 1, 3, new DateTime(2024, 2, 28, 4, 4, 35, 707, DateTimeKind.Local), new DateTime(2024, 1, 26, 10, 49, 4, 743, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 12,
                columns: new[] { "created_at", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 3, 46, 653, DateTimeKind.Local), 3, new DateTime(2024, 2, 28, 2, 21, 52, 568, DateTimeKind.Local), new DateTime(2024, 1, 23, 11, 24, 51, 706, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 13,
                columns: new[] { "created_at", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 28, 0, 295, DateTimeKind.Local), 9, new DateTime(2024, 2, 28, 2, 11, 23, 427, DateTimeKind.Local), new DateTime(2024, 1, 27, 22, 40, 33, 987, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 14,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 2, 23, 0, 20, 36, 260, DateTimeKind.Local), 1, 8, new DateTime(2024, 2, 28, 3, 28, 41, 743, DateTimeKind.Local), new DateTime(2024, 1, 18, 8, 15, 31, 64, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 15,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 9, 9, 24, 41, 701, DateTimeKind.Local), 4, 6, new DateTime(2024, 2, 28, 1, 38, 2, 589, DateTimeKind.Local), new DateTime(2024, 1, 23, 4, 59, 28, 559, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 16,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 8, 18, 4, 28, 18, 53, DateTimeKind.Local), 5, 6, new DateTime(2024, 2, 28, 4, 50, 36, 41, DateTimeKind.Local), new DateTime(2024, 1, 17, 12, 36, 37, 507, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 17,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 3, 11, 12, 37, 8, 609, DateTimeKind.Local), 1, 5, new DateTime(2024, 2, 28, 6, 50, 32, 134, DateTimeKind.Local), new DateTime(2024, 1, 17, 19, 1, 2, 233, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 18,
                columns: new[] { "created_at", "MovieId", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 11, 6, 21, 7, 19, 971, DateTimeKind.Local), 3, new DateTime(2024, 2, 28, 1, 12, 42, 422, DateTimeKind.Local), new DateTime(2024, 1, 28, 6, 57, 28, 391, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 19,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 7, 25, 2, 33, 15, 671, DateTimeKind.Local), 5, 6, new DateTime(2024, 2, 28, 3, 40, 2, 233, DateTimeKind.Local), new DateTime(2024, 1, 24, 15, 56, 30, 308, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "screening_id",
                keyValue: 20,
                columns: new[] { "created_at", "MovieId", "screen_number", "start_at", "updated_at" },
                values: new object[] { new DateTime(2022, 7, 26, 16, 22, 13, 743, DateTimeKind.Local), 3, 2, new DateTime(2024, 2, 28, 2, 18, 56, 882, DateTimeKind.Local), new DateTime(2024, 1, 18, 6, 34, 6, 522, DateTimeKind.Local) });

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
        }
    }
}
