using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabaseSeedingFunction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ScreeningId",
                table: "ticket_seat",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 1, 78 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 1, 1102 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 3, 1102 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 5, 81 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 5, 1032 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 6, 924 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 6, 1103 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 7, 79 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 7, 81 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 7, 922 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 8, 77 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 8, 346 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 9, 80 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 10, 80 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 10, 1031 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 11, 923 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 13, 347 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 14, 348 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 16, 77 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 16, 926 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 17, 78 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 17, 1031 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 20, 85 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 22, 77 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 22, 83 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 22, 84 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 24, 925 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 26, 78 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 28, 78 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 28, 79 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 29, 82 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 29, 83 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 30, 77 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 1, 30, 922 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 2, 31, 721 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 2, 31, 725 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 2, 31, 1124 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 2, 31, 1125 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 2, 32, 32 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 2, 33, 1124 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 2, 33, 1126 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 2, 34, 723 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 2, 35, 32 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 2, 35, 33 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 2, 35, 724 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 2, 37, 721 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 2, 38, 722 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 2, 39, 722 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 2, 41, 34 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 2, 41, 35 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 2, 43, 32 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 2, 43, 722 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 44, 378 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 44, 1076 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 46, 280 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 46, 545 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 46, 1079 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 47, 281 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 47, 287 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 47, 1071 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 48, 277 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 48, 380 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 48, 390 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 48, 545 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 48, 550 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 48, 567 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 48, 1044 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 48, 1075 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 48, 1099 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 49, 574 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 50, 273 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 50, 552 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 50, 1075 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 50, 1100 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 51, 275 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 51, 380 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 51, 555 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 51, 1084 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 51, 1085 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 53, 1089 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 55, 378 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 55, 574 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 55, 1073 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 56, 271 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 56, 1090 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 57, 567 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 57, 570 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 57, 1097 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 58, 285 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 58, 378 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 58, 384 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 58, 1077 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 59, 272 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 59, 279 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 59, 545 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 59, 1079 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 59, 1088 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 59, 1092 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 60, 1091 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 61, 1044 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 62, 576 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 63, 377 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 63, 384 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 63, 577 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 63, 1099 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 64, 283 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 64, 380 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 64, 386 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 65, 557 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 67, 561 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 68, 284 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 68, 1098 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 70, 554 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 71, 270 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 72, 396 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 72, 565 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 73, 575 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 74, 1099 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 75, 554 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 75, 563 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 75, 1042 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 77, 1073 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 77, 1087 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 78, 283 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 78, 378 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 78, 392 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 79, 283 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 79, 390 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 80, 572 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 80, 1074 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 81, 270 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 81, 285 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 81, 1077 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 82, 381 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 82, 393 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 82, 1082 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 82, 1095 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 83, 389 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 83, 557 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 83, 1076 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 83, 1081 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 84, 386 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 84, 566 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 85, 383 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 85, 557 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 85, 565 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 86, 277 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 86, 280 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 86, 568 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 87, 279 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 87, 382 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 87, 557 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 88, 574 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 89, 385 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 89, 560 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 89, 563 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 89, 1074 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 89, 1078 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 89, 1080 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 90, 390 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 90, 562 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 90, 1097 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 91, 547 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 92, 377 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 92, 1043 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 93, 380 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 94, 377 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 94, 551 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 94, 570 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 94, 1098 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 95, 381 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 95, 1072 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 96, 388 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 96, 546 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 96, 571 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 97, 282 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 97, 1082 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 97, 1095 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 98, 394 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 98, 562 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 98, 578 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 98, 1073 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 98, 1088 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 99, 271 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 99, 377 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 99, 394 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 99, 1084 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 100, 1083 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 100, 1084 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 101, 376 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 101, 379 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 101, 1075 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 102, 576 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 102, 1071 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 102, 1094 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 102, 1101 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 103, 1094 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 104, 1088 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 105, 561 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 105, 576 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 106, 1071 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 106, 1093 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 107, 569 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 108, 270 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 108, 388 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 108, 393 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 108, 568 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 108, 1092 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 110, 554 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 111, 393 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 111, 562 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 112, 383 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 112, 1087 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 113, 1073 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 114, 552 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 116, 1083 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 118, 286 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 118, 1070 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 119, 389 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 119, 558 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 120, 568 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 121, 569 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 122, 383 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 122, 559 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 124, 281 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 125, 563 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 126, 271 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 126, 384 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 126, 552 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 126, 1088 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 127, 284 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 127, 390 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 127, 564 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 128, 283 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 128, 1081 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 129, 565 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 130, 394 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 130, 1045 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 130, 1094 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 131, 573 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 131, 1083 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 132, 1075 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 133, 550 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 133, 562 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 133, 577 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 134, 287 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 135, 274 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 135, 386 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 135, 395 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 136, 391 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 136, 1091 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 137, 566 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 137, 1097 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 138, 547 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 138, 567 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 138, 1070 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 139, 386 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 139, 550 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 140, 379 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 140, 381 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 140, 558 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 140, 1072 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 140, 1083 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 140, 1086 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 142, 570 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 143, 273 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 143, 384 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 143, 569 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 143, 1071 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 143, 1093 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 145, 1072 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 145, 1084 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 146, 280 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 146, 395 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 146, 1078 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 146, 1087 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 147, 556 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 149, 277 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 149, 284 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 149, 379 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 150, 387 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 150, 558 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 150, 573 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 151, 1081 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 152, 278 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 152, 1074 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 153, 1097 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 154, 563 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 154, 1090 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 155, 1070 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 155, 1096 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 155, 1098 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 156, 548 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 157, 286 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 157, 379 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 157, 561 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 159, 284 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 159, 552 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 159, 576 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 159, 1092 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 161, 273 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 161, 278 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 161, 1086 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 162, 276 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 162, 1098 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 163, 282 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 163, 288 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 163, 381 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 164, 286 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 164, 549 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 164, 570 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 167, 568 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 168, 277 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 168, 393 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 168, 553 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 3, 169, 287 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 4, 170, 350 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 4, 173, 239 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 4, 173, 540 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 4, 174, 239 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 4, 174, 240 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 4, 174, 754 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 4, 177, 349 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 4, 177, 755 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 4, 178, 2 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 4, 178, 239 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 4, 178, 539 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 4, 178, 753 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 4, 178, 754 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 4, 179, 754 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 4, 180, 121 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 4, 181, 239 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 183, 363 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 183, 468 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 184, 466 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 184, 476 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 185, 372 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 185, 469 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 186, 352 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 186, 366 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 186, 474 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 189, 465 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 189, 935 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 190, 372 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 190, 929 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 192, 365 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 193, 361 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 195, 939 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 196, 939 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 196, 940 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 197, 363 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 197, 366 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 197, 372 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 197, 465 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 197, 936 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 198, 470 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 199, 934 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 199, 945 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 200, 369 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 202, 934 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 203, 375 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 204, 360 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 205, 361 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 206, 928 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 207, 467 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 207, 473 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 207, 941 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 208, 360 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 208, 365 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 208, 367 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 209, 353 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 209, 932 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 210, 928 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 211, 356 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 211, 370 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 211, 938 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 212, 351 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 213, 354 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 213, 363 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 213, 367 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 214, 373 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 214, 472 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 216, 932 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 217, 475 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 219, 930 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 220, 371 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 220, 469 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 220, 942 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 221, 367 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 221, 928 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 222, 372 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 223, 942 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 225, 352 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 225, 471 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 225, 941 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 227, 353 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 227, 935 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 227, 937 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 227, 938 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 227, 946 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 228, 929 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 229, 928 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 231, 369 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 232, 931 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 236, 354 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 236, 369 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 237, 466 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 238, 931 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 239, 370 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 239, 371 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 239, 944 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 241, 944 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 242, 355 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 242, 931 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 243, 470 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 243, 474 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 243, 937 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 243, 946 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 244, 929 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 246, 360 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 246, 469 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 246, 929 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 246, 941 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 248, 470 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 250, 933 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 251, 357 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 252, 368 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 252, 474 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 253, 473 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 255, 934 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 255, 938 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 256, 362 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 257, 368 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 261, 361 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 262, 364 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 264, 930 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 264, 931 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 267, 356 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 267, 358 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 267, 359 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 267, 365 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 267, 933 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 268, 366 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 268, 947 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 270, 474 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 271, 354 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 272, 355 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 272, 361 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 272, 366 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 276, 353 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 276, 468 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 277, 360 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 277, 472 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 278, 359 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 278, 927 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 278, 937 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 279, 370 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 279, 470 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 279, 938 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 280, 365 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 280, 941 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 281, 477 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 284, 353 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 286, 932 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 288, 472 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 289, 942 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 291, 468 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 292, 472 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 293, 369 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 294, 370 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 294, 374 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 294, 932 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 297, 368 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 297, 471 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 297, 943 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 298, 359 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 298, 465 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 300, 933 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 5, 301, 944 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 6, 303, 328 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 6, 317, 331 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 6, 318, 625 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 6, 320, 327 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 6, 320, 328 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 6, 320, 330 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 6, 322, 328 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 6, 323, 326 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 6, 325, 326 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 6, 326, 329 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 6, 327, 625 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 6, 329, 326 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 6, 330, 332 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 6, 336, 326 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 6, 338, 334 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 6, 339, 325 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 6, 339, 328 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 6, 341, 329 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 6, 342, 333 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 6, 344, 624 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 6, 345, 626 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 6, 347, 330 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 351, 443 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 352, 444 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 352, 460 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 352, 542 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 352, 1037 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 352, 1038 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 353, 463 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 353, 1038 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 354, 1038 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 355, 1036 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 355, 1039 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 356, 443 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 356, 458 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 356, 1040 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 356, 1041 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 359, 442 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 360, 444 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 360, 445 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 360, 1036 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 361, 444 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 361, 1037 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 362, 459 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 362, 543 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 362, 544 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 364, 446 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 364, 462 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 365, 446 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 365, 1034 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 366, 442 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 366, 464 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 368, 443 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 368, 460 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 369, 461 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 369, 541 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 369, 1033 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 369, 1037 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 369, 1039 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 370, 446 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 370, 541 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 371, 1036 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 373, 447 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 374, 458 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 374, 1037 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 376, 1035 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 376, 1038 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 377, 541 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 378, 459 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 378, 1036 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 7, 379, 1033 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 380, 453 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 381, 453 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 381, 797 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 381, 964 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 381, 1199 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 382, 849 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 383, 452 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 383, 966 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 384, 449 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 384, 455 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 384, 793 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 385, 793 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 385, 962 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 385, 1194 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 385, 1195 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 386, 448 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 387, 796 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 387, 964 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 388, 849 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 389, 449 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 389, 1192 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 389, 1203 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 390, 963 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 390, 1192 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 391, 448 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 392, 800 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 392, 961 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 393, 798 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 393, 802 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 393, 1197 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 396, 965 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 396, 1193 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 398, 1196 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 399, 1192 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 399, 1200 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 402, 1199 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 403, 960 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 404, 456 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 404, 799 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 406, 803 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 406, 967 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 406, 1193 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 407, 450 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 407, 1197 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 407, 1198 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 408, 795 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 408, 1200 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 409, 968 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 410, 794 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 412, 451 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 412, 793 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 412, 1192 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 413, 797 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 413, 1196 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 414, 450 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 414, 452 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 414, 1196 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 415, 965 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 417, 796 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 418, 457 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 418, 962 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 418, 1197 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 419, 453 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 420, 799 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 420, 1196 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 421, 1200 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 422, 450 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 422, 848 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 423, 794 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 423, 798 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 424, 798 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 424, 1202 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 425, 448 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 425, 802 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 427, 454 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 427, 799 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 428, 800 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 429, 850 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 429, 1195 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 429, 1200 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 430, 456 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 431, 454 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 431, 793 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 431, 1199 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 433, 451 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 433, 797 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 433, 962 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 434, 804 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 434, 963 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 435, 450 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 435, 451 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 435, 801 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 435, 964 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 437, 448 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 437, 456 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 437, 798 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 437, 802 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 437, 1194 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 438, 794 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 440, 965 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 441, 1197 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 442, 1193 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 8, 443, 1201 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 444, 901 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 444, 1185 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 445, 900 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 445, 1188 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 447, 581 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 447, 595 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 448, 900 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 448, 918 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 448, 1190 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 450, 581 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 450, 586 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 450, 902 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 450, 919 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 453, 588 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 453, 919 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 454, 601 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 455, 586 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 455, 587 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 455, 590 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 455, 908 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 455, 1183 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 456, 607 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 457, 588 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 458, 591 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 458, 1181 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 460, 585 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 462, 915 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 463, 913 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 465, 600 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 467, 602 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 467, 896 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 467, 920 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 469, 583 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 469, 1180 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 470, 584 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 472, 920 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 472, 1181 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 473, 596 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 473, 604 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 473, 605 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 475, 584 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 475, 1184 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 476, 918 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 478, 608 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 478, 916 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 478, 1183 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 480, 899 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 481, 600 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 481, 1188 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 482, 920 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 483, 1184 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 484, 584 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 484, 586 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 484, 606 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 484, 917 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 485, 591 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 485, 599 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 485, 907 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 486, 597 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 487, 904 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 487, 1189 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 490, 585 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 490, 1189 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 491, 591 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 492, 587 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 492, 590 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 492, 898 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 494, 1181 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 495, 910 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 495, 1178 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 496, 912 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 496, 1182 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 496, 1184 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 497, 580 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 497, 593 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 497, 1185 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 498, 598 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 498, 913 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 498, 915 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 500, 580 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 500, 896 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 500, 903 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 500, 910 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 502, 910 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 502, 1182 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 503, 595 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 503, 598 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 503, 913 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 504, 607 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 504, 1182 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 505, 896 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 506, 607 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 507, 602 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 507, 899 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 508, 914 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 508, 918 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 510, 897 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 511, 916 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 511, 1187 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 512, 1179 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 513, 901 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 515, 1188 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 516, 603 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 517, 911 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 518, 598 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 518, 907 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 519, 906 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 520, 601 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 520, 914 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 521, 579 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 521, 582 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 521, 604 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 521, 898 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 522, 908 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 523, 921 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 523, 1178 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 523, 1179 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 524, 597 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 524, 917 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 525, 909 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 526, 899 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 527, 590 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 527, 595 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 528, 588 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 528, 1189 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 529, 581 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 529, 605 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 529, 906 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 530, 916 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 530, 1185 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 531, 602 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 531, 909 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 532, 581 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 532, 1183 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 533, 914 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 533, 918 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 533, 1184 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 534, 594 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 534, 896 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 534, 917 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 535, 911 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 535, 916 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 536, 595 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 536, 603 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 536, 899 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 538, 583 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 538, 607 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 540, 900 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 541, 905 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 543, 587 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 544, 583 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 546, 606 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 546, 909 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 546, 1178 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 547, 600 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 547, 1185 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 548, 594 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 548, 1178 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 549, 1181 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 549, 1191 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 550, 587 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 550, 591 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 552, 1190 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 553, 579 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 553, 592 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 554, 902 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 555, 919 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 556, 901 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 556, 902 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 557, 909 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 558, 579 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 558, 589 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 559, 593 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 559, 606 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 559, 1186 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 9, 559, 1188 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 560, 313 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 560, 1050 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 560, 1052 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 560, 1060 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 560, 1069 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 561, 291 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 561, 310 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 561, 1064 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 564, 294 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 564, 717 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 565, 527 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 565, 699 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 566, 1054 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 568, 312 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 568, 704 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 568, 1053 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 569, 4 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 569, 533 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 569, 699 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 570, 312 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 570, 530 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 571, 419 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 571, 527 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 573, 3 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 575, 291 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 575, 700 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 576, 524 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 578, 421 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 578, 520 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 578, 1065 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 579, 318 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 579, 418 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 580, 703 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 580, 1055 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 581, 5 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 581, 305 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 582, 308 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 582, 315 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 582, 717 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 583, 521 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 584, 709 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 584, 712 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 585, 707 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 587, 513 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 587, 711 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 587, 1050 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 588, 519 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 588, 700 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 589, 707 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 590, 4 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 590, 313 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 590, 417 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 590, 418 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 590, 421 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 590, 715 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 590, 718 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 591, 529 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 592, 291 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 592, 1059 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 593, 299 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 593, 314 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 593, 320 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 593, 422 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 594, 422 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 594, 1058 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 595, 305 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 595, 512 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 595, 523 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 595, 524 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 596, 300 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 596, 302 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 596, 705 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 596, 1066 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 597, 304 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 598, 297 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 598, 523 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 598, 1057 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 599, 299 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 599, 302 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 599, 319 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 599, 513 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 599, 528 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 599, 708 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 599, 711 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 600, 1053 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 601, 298 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 602, 720 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 602, 1059 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 602, 1065 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 603, 526 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 603, 531 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 603, 703 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 603, 1062 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 605, 420 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 606, 525 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 606, 1056 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 607, 289 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 607, 424 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 607, 1062 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 607, 1065 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 610, 514 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 611, 5 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 611, 301 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 611, 718 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 611, 1060 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 612, 308 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 612, 702 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 612, 710 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 613, 297 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 613, 531 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 614, 3 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 614, 1051 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 615, 294 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 615, 307 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 615, 422 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 616, 519 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 616, 522 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 616, 1053 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 617, 422 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 617, 1058 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 618, 297 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 619, 306 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 619, 528 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 619, 710 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 619, 1051 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 620, 308 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 621, 517 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 621, 713 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 622, 301 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 622, 305 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 622, 317 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 623, 293 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 623, 1067 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 625, 512 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 626, 516 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 627, 703 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 628, 308 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 628, 417 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 628, 529 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 629, 5 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 629, 302 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 629, 716 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 629, 1055 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 630, 8 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 630, 290 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 630, 512 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 630, 515 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 630, 707 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 631, 7 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 631, 512 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 631, 701 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 631, 1057 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 631, 1061 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 632, 525 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 633, 289 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 633, 1060 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 634, 418 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 634, 1062 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 635, 520 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 635, 719 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 636, 319 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 636, 1054 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 637, 296 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 637, 317 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 637, 526 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 637, 1053 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 638, 518 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 638, 713 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 640, 1058 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 640, 1061 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 641, 524 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 642, 514 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 642, 521 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 643, 718 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 643, 1060 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 644, 315 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 645, 297 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 646, 309 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 647, 292 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 647, 417 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 648, 10 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 648, 304 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 648, 311 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 648, 516 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 648, 527 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 648, 704 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 648, 707 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 649, 516 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 649, 1061 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 650, 4 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 651, 523 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 651, 1050 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 652, 301 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 653, 290 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 653, 299 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 653, 305 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 653, 1063 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 654, 423 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 654, 1052 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 655, 698 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 655, 703 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 656, 1055 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 656, 1056 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 657, 4 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 657, 704 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 658, 300 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 659, 524 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 659, 1066 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 660, 298 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 661, 6 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 661, 306 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 661, 518 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 661, 700 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 661, 1056 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 661, 1068 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 662, 518 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 662, 520 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 662, 1051 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 662, 1057 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 663, 303 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 663, 315 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 663, 316 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 663, 518 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 663, 529 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 663, 704 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 663, 715 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 664, 291 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 664, 311 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 665, 710 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 667, 295 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 667, 711 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 667, 1063 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 669, 525 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 669, 1061 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 670, 296 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 671, 311 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 672, 515 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 672, 700 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 673, 304 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 674, 302 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 674, 718 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 674, 1054 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 675, 299 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 675, 1056 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 676, 706 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 676, 1058 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 677, 301 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 678, 316 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 678, 712 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 678, 1065 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 679, 9 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 679, 311 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 679, 532 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 680, 313 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 10, 680, 714 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 681, 322 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 681, 644 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 681, 1046 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 682, 645 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 682, 649 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 683, 322 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 683, 324 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 683, 646 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 683, 894 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 684, 891 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 684, 948 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 684, 1046 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 685, 644 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 685, 895 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 685, 1046 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 686, 647 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 687, 321 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 688, 323 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 688, 892 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 688, 1047 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 689, 644 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 689, 647 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 689, 948 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 690, 680 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 690, 949 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 690, 1048 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 690, 1049 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 691, 648 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 691, 892 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 691, 893 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 691, 1046 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 692, 321 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 692, 644 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 692, 647 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 693, 322 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 693, 679 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 693, 681 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 11, 693, 948 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 694, 145 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 694, 882 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 695, 142 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 695, 843 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 696, 493 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 696, 838 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 697, 90 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 697, 122 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 697, 841 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 698, 96 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 698, 493 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 699, 125 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 699, 885 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 700, 134 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 700, 152 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 700, 155 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 700, 490 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 700, 684 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 700, 833 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 701, 104 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 701, 154 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 701, 885 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 702, 101 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 702, 833 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 702, 887 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 703, 127 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 703, 689 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 703, 835 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 704, 97 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 704, 152 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 705, 95 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 705, 143 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 706, 99 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 706, 490 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 707, 91 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 707, 492 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 707, 840 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 707, 843 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 708, 883 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 708, 888 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 709, 99 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 709, 133 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 709, 693 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 710, 93 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 710, 123 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 710, 495 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 710, 879 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 711, 102 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 711, 123 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 711, 129 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 711, 695 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 712, 145 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 713, 494 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 713, 694 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 713, 843 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 714, 88 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 714, 92 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 714, 95 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 714, 691 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 714, 831 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 715, 885 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 716, 124 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 716, 134 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 716, 886 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 717, 125 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 717, 826 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 717, 836 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 717, 841 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 718, 101 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 718, 838 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 718, 880 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 718, 882 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 719, 838 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 719, 889 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 721, 143 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 721, 822 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 721, 836 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 722, 126 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 722, 127 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 722, 488 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 723, 127 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 723, 686 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 723, 888 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 724, 103 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 724, 146 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 724, 686 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 724, 692 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 724, 696 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 724, 822 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 725, 694 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 725, 835 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 726, 126 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 726, 133 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 727, 94 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 727, 154 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 728, 844 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 729, 495 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 729, 688 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 730, 148 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 730, 692 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 730, 828 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 730, 881 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 731, 90 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 731, 102 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 731, 105 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 731, 693 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 731, 832 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 731, 883 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 731, 884 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 732, 691 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 732, 845 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 733, 153 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 733, 846 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 733, 881 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 734, 147 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 734, 157 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 734, 493 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 734, 839 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 734, 840 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 735, 94 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 735, 97 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 735, 99 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 735, 147 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 735, 832 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 736, 122 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 736, 843 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 736, 882 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 737, 97 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 737, 102 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 737, 826 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 738, 133 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 738, 150 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 738, 491 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 738, 825 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 738, 829 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 738, 839 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 738, 847 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 738, 884 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 738, 887 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 739, 123 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 739, 124 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 739, 148 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 739, 149 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 739, 155 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 740, 822 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 740, 823 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 740, 832 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 740, 837 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 740, 886 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 741, 489 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 741, 827 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 741, 845 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 742, 126 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 742, 129 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 742, 684 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 743, 92 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 744, 148 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 744, 150 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 745, 155 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 746, 142 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 746, 696 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 747, 844 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 747, 879 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 748, 93 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 748, 151 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 748, 153 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 748, 492 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 748, 691 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 748, 883 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 749, 93 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 749, 490 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 749, 492 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 749, 824 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 749, 829 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 749, 833 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 750, 129 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 750, 497 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 751, 90 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 751, 141 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 751, 838 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 752, 682 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 753, 136 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 753, 882 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 754, 90 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 754, 155 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 754, 497 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 754, 831 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 755, 834 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 756, 131 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 756, 683 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 756, 823 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 756, 890 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 757, 91 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 757, 130 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 757, 140 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 757, 685 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 757, 697 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 758, 102 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 758, 128 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 758, 147 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 758, 844 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 758, 880 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 758, 887 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 760, 100 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 760, 696 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 761, 145 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 761, 146 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 761, 687 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 762, 154 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 762, 887 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 763, 142 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 763, 694 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 763, 829 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 763, 831 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 764, 492 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 765, 98 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 765, 101 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 765, 130 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 766, 489 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 767, 124 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 768, 125 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 768, 142 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 768, 152 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 769, 132 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 769, 149 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 769, 151 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 770, 690 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 770, 880 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 771, 488 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 771, 837 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 772, 97 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 772, 693 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 772, 833 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 773, 122 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 773, 496 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 773, 823 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 773, 842 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 774, 129 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 775, 693 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 775, 836 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 776, 94 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 776, 144 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 776, 153 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 776, 498 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 777, 130 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 777, 149 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 777, 684 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 777, 880 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 778, 683 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 778, 888 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 779, 99 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 779, 682 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 779, 830 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 779, 845 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 781, 834 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 781, 884 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 782, 156 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 783, 123 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 783, 150 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 783, 883 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 785, 88 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 785, 146 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 785, 829 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 786, 89 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 786, 122 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 786, 146 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 787, 88 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 787, 154 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 788, 135 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 788, 141 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 788, 842 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 789, 837 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 789, 839 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 789, 842 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 790, 488 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 790, 489 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 790, 828 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 793, 88 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 793, 144 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 793, 828 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 794, 133 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 794, 879 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 795, 95 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 795, 683 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 795, 835 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 796, 823 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 796, 845 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 797, 490 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 797, 690 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 797, 831 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 798, 127 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 798, 687 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 12, 798, 836 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 799, 159 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 799, 509 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 799, 616 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 799, 1108 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 799, 1116 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 800, 158 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 800, 611 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 801, 172 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 801, 226 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 801, 510 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 801, 616 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 801, 628 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 801, 1114 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 802, 161 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 802, 163 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 802, 170 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 802, 507 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 802, 1165 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 804, 175 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 805, 630 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 805, 640 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 805, 1113 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 805, 1114 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 806, 229 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 806, 1115 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 807, 160 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 807, 611 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 807, 1107 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 807, 1116 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 808, 171 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 808, 507 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 808, 641 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 809, 162 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 809, 164 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 809, 175 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 809, 511 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 810, 168 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 810, 635 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 810, 1117 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 811, 1110 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 811, 1120 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 812, 228 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 812, 610 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 812, 616 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 812, 623 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 812, 639 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 812, 1166 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 812, 1169 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 813, 1108 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 813, 1121 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 813, 1175 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 814, 643 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 815, 160 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 815, 173 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 815, 231 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 815, 619 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 815, 1118 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 815, 1121 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 815, 1165 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 816, 1114 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 816, 1115 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 817, 169 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 817, 1172 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 818, 165 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 818, 619 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 819, 177 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 820, 177 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 820, 503 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 820, 1111 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 821, 619 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 821, 632 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 821, 1109 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 822, 638 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 823, 166 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 823, 1105 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 824, 507 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 825, 232 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 825, 509 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 825, 1106 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 825, 1112 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 827, 1104 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 827, 1119 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 828, 172 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 829, 500 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 829, 627 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 829, 629 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 830, 612 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 830, 619 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 830, 620 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 831, 229 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 831, 510 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 833, 228 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 834, 1111 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 835, 642 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 835, 1115 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 836, 501 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 836, 627 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 837, 628 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 838, 163 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 838, 500 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 838, 1115 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 839, 505 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 839, 638 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 839, 1165 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 840, 229 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 840, 1176 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 841, 231 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 841, 628 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 841, 1112 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 842, 617 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 842, 1120 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 842, 1164 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 842, 1170 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 843, 167 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 843, 168 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 843, 175 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 843, 229 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 843, 1114 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 844, 173 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 845, 173 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 845, 233 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 845, 503 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 845, 1119 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 846, 609 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 846, 1173 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 847, 618 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 847, 1176 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 848, 614 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 849, 225 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 849, 641 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 849, 1123 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 849, 1167 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 849, 1168 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 850, 176 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 850, 1106 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 850, 1171 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 851, 166 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 851, 231 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 851, 504 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 851, 634 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 851, 1105 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 852, 168 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 852, 234 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 852, 613 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 852, 639 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 852, 1118 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 852, 1175 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 853, 164 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 853, 178 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 853, 233 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 853, 636 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 853, 1174 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 854, 627 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 854, 1173 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 855, 1118 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 857, 613 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 858, 166 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 858, 235 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 858, 633 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 858, 1177 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 859, 227 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 859, 502 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 859, 613 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 859, 630 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 859, 637 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 860, 163 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 860, 505 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 860, 616 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 860, 1166 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 861, 164 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 862, 621 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 862, 631 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 862, 1112 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 863, 159 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 863, 178 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 863, 1175 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 864, 232 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 864, 636 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 865, 230 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 865, 233 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 866, 165 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 866, 174 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 866, 179 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 866, 611 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 866, 622 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 866, 1166 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 867, 1122 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 868, 614 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 868, 630 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 868, 1173 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 869, 162 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 869, 621 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 869, 627 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 869, 631 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 870, 168 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 870, 1107 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 871, 162 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 872, 233 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 872, 614 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 872, 638 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 872, 1176 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 873, 1117 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 874, 169 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 874, 617 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 875, 1119 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 875, 1174 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 876, 161 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 876, 162 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 876, 634 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 876, 1111 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 876, 1122 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 877, 159 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 877, 507 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 877, 620 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 877, 1106 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 878, 508 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 879, 171 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 879, 630 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 879, 1113 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 879, 1167 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 880, 163 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 880, 172 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 880, 505 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 880, 510 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 881, 510 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 882, 502 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 882, 1113 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 883, 159 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 883, 167 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 884, 634 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 884, 1122 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 884, 1165 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 885, 167 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 885, 177 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 885, 505 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 886, 615 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 887, 231 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 887, 232 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 888, 1110 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 889, 160 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 889, 170 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 889, 1166 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 890, 611 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 891, 499 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 891, 506 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 13, 891, 634 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 905, 851 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 905, 856 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 910, 858 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 912, 855 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 912, 862 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 912, 868 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 917, 855 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 925, 860 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 926, 855 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 926, 857 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 926, 859 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 926, 865 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 928, 861 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 932, 861 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 932, 864 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 933, 864 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 934, 856 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 935, 867 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 938, 854 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 939, 858 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 940, 861 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 941, 869 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 946, 871 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 952, 853 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 963, 857 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 964, 867 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 965, 852 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 967, 857 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 967, 870 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 969, 863 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 970, 852 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 970, 863 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 979, 870 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 984, 857 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 986, 866 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 14, 988, 859 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 990, 817 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 991, 820 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 991, 1151 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 993, 805 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 993, 807 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 994, 652 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 998, 658 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 998, 811 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 998, 1154 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 999, 480 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 999, 650 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 999, 816 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 999, 1162 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1000, 650 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1000, 808 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1000, 812 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1000, 1153 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1001, 653 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1001, 820 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1001, 1142 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1002, 478 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1002, 479 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1002, 658 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1003, 814 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1003, 1145 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1004, 652 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1004, 818 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1004, 1148 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1005, 537 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1007, 1151 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1008, 534 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1008, 660 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1008, 820 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1008, 1147 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1008, 1155 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1008, 1157 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1009, 535 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1009, 1147 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1009, 1160 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1009, 1161 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1010, 659 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1010, 818 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1011, 1158 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1012, 478 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1012, 486 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1012, 653 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1012, 806 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1012, 811 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1013, 483 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1013, 485 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1013, 650 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1013, 656 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1014, 486 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1014, 1151 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1014, 1158 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1015, 811 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1015, 1154 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1015, 1161 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1016, 810 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1017, 480 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1018, 536 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1018, 661 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1018, 1144 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1020, 484 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1020, 1160 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1021, 808 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1022, 805 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1023, 486 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1023, 654 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1023, 817 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1023, 1142 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1023, 1161 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1024, 659 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1025, 536 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1026, 481 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1026, 652 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1026, 818 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1028, 813 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1028, 1149 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1029, 485 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1029, 657 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1029, 805 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1031, 657 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1031, 814 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1031, 821 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1031, 1155 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1031, 1159 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1032, 806 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1032, 814 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1033, 658 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1033, 1152 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1034, 482 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1034, 653 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1034, 1156 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1035, 1156 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1036, 654 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1037, 536 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1038, 651 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1038, 1143 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1038, 1155 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1039, 812 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1039, 818 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1040, 813 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1041, 659 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1041, 1149 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1042, 810 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1043, 1150 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1043, 1158 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1044, 1144 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1044, 1147 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1044, 1150 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1045, 534 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1045, 814 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1045, 1157 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1046, 817 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1047, 1142 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1048, 813 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1049, 535 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1049, 1142 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1049, 1154 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1050, 1143 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1050, 1150 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1050, 1156 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1051, 661 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1052, 480 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1052, 1146 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1053, 655 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1053, 809 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1054, 1160 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1055, 1156 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1056, 652 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1057, 534 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1057, 659 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1059, 651 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1059, 656 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1059, 819 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1059, 1153 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1060, 655 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1060, 1143 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1060, 1155 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1061, 815 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1061, 817 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1061, 1147 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1062, 1145 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1063, 487 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1063, 650 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1063, 1145 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1063, 1149 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1064, 809 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1064, 812 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1065, 534 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1065, 535 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1065, 660 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1065, 816 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1066, 479 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1066, 480 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1066, 651 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1067, 654 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1069, 479 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1069, 812 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1070, 538 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1070, 655 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1070, 808 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1071, 486 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1071, 654 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1071, 1151 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1071, 1163 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1072, 481 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1072, 536 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1072, 655 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1073, 537 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1073, 805 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1073, 1158 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1074, 662 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1074, 811 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 15, 1074, 1144 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1075, 236 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1075, 737 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1075, 743 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1076, 219 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1076, 433 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1077, 139 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1077, 216 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1077, 222 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1077, 339 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1077, 438 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1077, 1128 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1078, 68 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1078, 438 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1079, 67 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1079, 343 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1080, 222 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1080, 342 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1080, 1127 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1081, 65 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1081, 70 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1081, 73 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1081, 223 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1081, 342 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1081, 428 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1081, 726 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1081, 745 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1081, 750 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1082, 72 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1082, 335 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1082, 733 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1082, 1128 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1083, 65 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1083, 342 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1083, 428 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1083, 1135 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1084, 73 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1084, 432 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1085, 69 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1085, 216 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1085, 336 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1085, 434 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1085, 437 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1085, 438 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1085, 1130 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1085, 1133 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1086, 728 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1086, 743 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1086, 751 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1087, 336 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1087, 428 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1087, 727 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1088, 336 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1088, 437 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1088, 740 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1088, 744 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1088, 1129 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1089, 71 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1089, 430 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1089, 728 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1089, 730 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1089, 1131 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1089, 1133 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1090, 64 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1090, 740 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1090, 750 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1091, 73 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1091, 223 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1091, 727 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1091, 735 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1092, 70 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1092, 72 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1092, 222 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1092, 425 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1092, 743 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1093, 74 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1093, 137 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1093, 237 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1093, 338 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1093, 344 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1093, 425 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1093, 428 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1093, 429 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1093, 729 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1093, 736 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1093, 744 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1093, 1134 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1094, 72 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1094, 76 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1094, 220 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1094, 339 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1094, 735 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1094, 1138 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1095, 69 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1095, 86 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1095, 740 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1096, 69 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1096, 335 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1097, 343 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1097, 1132 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1098, 436 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1098, 1130 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1099, 342 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1099, 431 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1099, 739 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1100, 751 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1101, 74 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1101, 425 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1101, 1132 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1101, 1140 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1102, 75 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1102, 338 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1102, 341 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1102, 441 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1102, 726 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1102, 733 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1102, 1129 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1103, 138 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1103, 341 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1103, 439 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1103, 1127 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1103, 1132 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1104, 67 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1104, 68 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1104, 221 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1104, 224 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1104, 338 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1104, 427 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1104, 727 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1104, 1139 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1105, 65 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1105, 236 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1105, 728 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1106, 742 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1107, 220 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1107, 338 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1107, 341 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1107, 1136 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1108, 72 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1108, 744 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1109, 65 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1109, 236 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1109, 431 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1109, 433 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1109, 727 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1109, 730 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1109, 1137 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1109, 1141 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1110, 220 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1110, 221 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1110, 336 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1111, 214 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1111, 344 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1111, 425 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1111, 427 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1111, 431 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1111, 746 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1111, 1136 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1111, 1139 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1112, 68 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1112, 221 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1112, 337 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1112, 435 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1112, 740 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1112, 1140 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1113, 68 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1113, 215 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1113, 217 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1113, 340 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1113, 427 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1113, 435 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1114, 74 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1114, 218 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1114, 221 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1114, 238 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1114, 337 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1114, 726 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1114, 743 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1114, 1130 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1115, 87 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1115, 435 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1115, 746 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1115, 1128 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1116, 74 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1116, 216 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1116, 426 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1116, 729 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1117, 430 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1117, 747 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1117, 1134 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1117, 1137 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1118, 748 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1118, 751 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1119, 67 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1119, 220 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1119, 335 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1119, 741 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1120, 66 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1120, 236 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1120, 440 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1120, 751 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1120, 1127 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1121, 86 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1121, 344 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1121, 729 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1122, 218 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1122, 736 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1123, 70 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1123, 340 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1123, 728 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1123, 741 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1123, 745 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1123, 1133 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1124, 340 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1124, 731 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1124, 732 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1124, 741 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1124, 1129 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1125, 433 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1125, 745 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1125, 749 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1126, 70 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1126, 345 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1126, 730 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1126, 731 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1126, 747 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1126, 749 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1126, 752 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1127, 215 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1127, 218 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1127, 219 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1127, 734 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1127, 738 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1127, 745 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 16, 1127, 1130 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1130, 404 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1132, 405 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1132, 413 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1132, 415 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1132, 957 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1133, 955 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1134, 673 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1135, 666 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1135, 952 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1138, 666 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1138, 954 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1139, 405 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1139, 951 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1140, 410 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1140, 958 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1141, 406 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1141, 415 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1142, 403 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1143, 664 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1143, 956 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1144, 397 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1144, 664 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1144, 950 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1145, 412 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1145, 664 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1145, 950 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1145, 956 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1146, 401 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1148, 407 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1150, 677 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1150, 951 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1150, 955 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1151, 397 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1151, 663 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1152, 407 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1152, 671 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1152, 678 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1153, 404 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1155, 672 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1156, 665 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1157, 399 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1158, 675 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1159, 411 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1159, 665 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1160, 668 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1160, 669 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1160, 675 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1162, 666 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1162, 670 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1163, 404 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1163, 414 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1165, 415 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1165, 669 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1165, 671 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1166, 667 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1166, 673 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1168, 413 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1170, 672 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1170, 952 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1171, 398 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1172, 664 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1173, 403 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1174, 953 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1175, 401 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1175, 414 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1176, 665 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1176, 669 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1176, 954 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1176, 956 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1178, 397 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1178, 415 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1180, 405 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1180, 408 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1180, 676 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1180, 952 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1180, 957 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1181, 411 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1182, 400 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1182, 409 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1183, 398 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1183, 957 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1185, 413 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1185, 665 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1185, 675 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1185, 955 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1186, 955 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1188, 401 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1188, 402 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1188, 674 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1188, 952 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1189, 668 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1190, 416 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1190, 956 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1190, 957 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1191, 670 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1191, 673 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1192, 413 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1192, 674 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1193, 668 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1193, 959 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1194, 409 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1195, 401 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 17, 1196, 411 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1197, 1011 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1198, 22 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1198, 52 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1198, 114 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1198, 874 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1198, 982 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1198, 1001 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1199, 876 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1199, 1001 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1199, 1007 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1200, 49 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1200, 59 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1200, 120 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1201, 873 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1201, 990 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1202, 995 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1203, 54 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1203, 1006 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1204, 11 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1204, 63 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1205, 13 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1205, 40 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1205, 46 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1205, 111 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1205, 877 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1205, 986 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1206, 11 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1206, 16 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1206, 18 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1206, 20 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1207, 14 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1207, 118 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1208, 52 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1208, 970 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1209, 36 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1209, 994 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1209, 1022 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1209, 1024 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1210, 37 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1210, 873 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1210, 998 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1210, 1003 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1211, 47 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1211, 999 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1212, 38 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1213, 29 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1215, 13 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1215, 107 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1216, 17 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1216, 37 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1217, 45 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1217, 60 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1217, 974 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1217, 987 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1218, 46 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1218, 116 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1218, 1021 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1222, 985 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1222, 989 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1222, 1024 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1223, 29 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1223, 872 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1223, 975 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1224, 54 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1224, 978 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1224, 1008 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1225, 19 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1225, 43 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1225, 52 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1225, 878 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1225, 986 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1226, 18 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1226, 39 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1226, 47 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1226, 978 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1226, 990 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1226, 999 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1227, 1030 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1228, 985 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1228, 1008 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1229, 20 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1229, 874 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1229, 982 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1229, 1017 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1230, 14 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1230, 24 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1230, 25 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1230, 46 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1230, 60 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1231, 1029 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1232, 28 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1232, 106 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1232, 994 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1232, 1020 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1232, 1026 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1233, 62 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1233, 106 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1234, 108 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1235, 42 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1236, 40 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1236, 116 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1236, 983 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1237, 24 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1237, 49 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1237, 55 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1238, 56 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1238, 971 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1238, 1027 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1239, 21 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1239, 118 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1239, 991 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1239, 1027 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1240, 55 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1240, 58 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1240, 976 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1241, 1006 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1242, 39 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1242, 40 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1242, 109 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1243, 57 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1244, 15 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1244, 22 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1244, 115 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1244, 987 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1245, 30 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1247, 17 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1247, 25 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1247, 59 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1247, 980 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1247, 1023 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1248, 973 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1248, 1013 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1248, 1016 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1249, 19 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1249, 40 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1249, 54 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1249, 987 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1250, 1017 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1251, 42 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1251, 873 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1251, 972 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1251, 974 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1252, 42 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1252, 107 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1252, 874 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1252, 971 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1253, 23 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1253, 993 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1254, 12 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1254, 20 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1254, 987 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1254, 988 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1254, 996 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1254, 1016 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1254, 1028 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1255, 16 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1256, 58 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1256, 875 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1256, 991 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1256, 1024 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1257, 43 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1259, 24 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1259, 28 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1259, 56 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1259, 59 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1260, 27 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1260, 995 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1260, 1013 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1261, 26 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1262, 13 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1262, 55 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1262, 110 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1262, 978 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1262, 1005 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1262, 1020 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1263, 36 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1263, 41 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1263, 110 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1263, 970 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1263, 993 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1263, 999 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1263, 1029 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1264, 24 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1264, 39 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1264, 969 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1264, 991 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1265, 977 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1265, 1008 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1266, 983 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1267, 59 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1267, 970 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1268, 48 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1268, 119 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1268, 1003 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1269, 13 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1269, 106 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1269, 1008 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1270, 875 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1272, 51 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1273, 22 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1273, 110 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1273, 976 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1273, 986 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1274, 26 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1274, 119 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1274, 1012 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1275, 20 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1275, 1022 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1276, 61 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1276, 1006 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1276, 1007 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1276, 1025 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1277, 57 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1277, 118 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1278, 106 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1279, 36 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1279, 874 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1279, 981 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1279, 985 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1279, 1013 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1281, 60 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1281, 113 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1281, 1020 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1282, 37 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1282, 54 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1282, 988 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1282, 1019 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1283, 983 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1283, 1009 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1283, 1014 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1284, 981 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1284, 994 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1284, 1000 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1284, 1020 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1285, 113 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1285, 117 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1285, 974 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1286, 47 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1286, 110 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1286, 990 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1287, 980 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1287, 984 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1287, 1022 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1287, 1025 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1288, 11 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1288, 989 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1288, 1006 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1288, 1013 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1289, 112 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1290, 16 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1290, 116 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1290, 1002 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1291, 42 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1292, 11 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1292, 985 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1292, 1002 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1292, 1017 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1292, 1027 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1293, 18 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1293, 107 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1293, 992 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1294, 28 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1294, 875 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1294, 1015 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1295, 56 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1295, 975 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1295, 1017 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1296, 48 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1296, 115 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1296, 977 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1296, 979 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1297, 997 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1297, 999 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1298, 31 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1298, 50 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1298, 107 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1298, 986 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1298, 1011 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1298, 1018 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1299, 57 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1299, 994 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1299, 1004 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1299, 1010 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1300, 36 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1300, 109 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1300, 993 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1301, 113 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1301, 977 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1302, 17 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1302, 44 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1303, 108 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1303, 977 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1303, 990 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1303, 1009 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1305, 109 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1305, 983 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1305, 1007 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1306, 53 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1306, 988 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1306, 1002 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1306, 1024 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1307, 57 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1307, 60 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 18, 1307, 1011 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1308, 208 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1308, 769 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1309, 202 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1309, 259 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1310, 190 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1310, 789 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1311, 189 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1311, 190 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1311, 770 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1311, 774 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1312, 184 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1312, 251 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1312, 769 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1313, 189 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1313, 248 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1313, 768 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1313, 784 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1313, 785 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1314, 186 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1314, 204 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1314, 268 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1314, 774 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1315, 761 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1316, 790 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1317, 782 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1319, 191 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1319, 212 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1321, 213 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1321, 267 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1321, 756 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1322, 788 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1323, 249 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1323, 767 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1324, 250 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1325, 246 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1326, 757 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1326, 782 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1327, 199 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1327, 251 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1328, 266 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1328, 267 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1330, 188 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1330, 252 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1330, 266 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1333, 262 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1334, 764 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1335, 182 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1335, 186 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1335, 269 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1335, 773 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1336, 202 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1336, 261 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1336, 759 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1336, 761 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1336, 782 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1337, 774 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1337, 777 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1338, 185 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1338, 263 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1338, 768 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1339, 187 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1339, 202 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1340, 260 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1343, 773 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1344, 191 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1344, 243 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1344, 256 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1345, 181 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1345, 200 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1345, 209 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1345, 760 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1346, 193 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1346, 199 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1347, 184 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1347, 268 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1347, 765 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1348, 206 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1348, 762 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1349, 186 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1350, 185 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1350, 210 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1350, 262 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1350, 777 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1351, 180 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1351, 184 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1351, 763 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1351, 770 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1352, 247 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1352, 250 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1352, 786 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1353, 248 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1353, 260 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1354, 267 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1354, 779 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1355, 188 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1355, 257 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1355, 765 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1356, 253 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1356, 764 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1357, 195 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1357, 262 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1357, 762 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1358, 193 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1358, 206 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1358, 242 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1360, 190 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1360, 241 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1360, 243 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1360, 245 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1360, 257 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1360, 258 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1360, 761 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1361, 206 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1361, 782 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1362, 181 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1362, 185 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1363, 212 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1364, 770 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1365, 195 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1365, 786 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1367, 264 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1367, 774 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1368, 197 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1368, 777 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1369, 209 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1369, 785 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1370, 247 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1371, 208 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1371, 210 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1371, 211 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1372, 199 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1372, 759 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1373, 257 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1374, 188 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1374, 265 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1377, 252 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1377, 786 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1377, 792 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1378, 192 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1378, 199 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1378, 207 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1378, 208 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1378, 211 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1378, 791 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1380, 258 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1381, 253 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1381, 758 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1381, 765 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1382, 207 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1382, 256 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1383, 265 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1384, 184 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1385, 197 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1385, 784 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1385, 788 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1388, 267 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1390, 250 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1392, 198 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1392, 249 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1393, 253 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1393, 762 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1394, 202 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1394, 775 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1395, 197 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1395, 200 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1395, 203 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1396, 208 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1396, 210 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1397, 771 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1397, 786 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1398, 185 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1399, 247 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1399, 771 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1400, 197 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1400, 245 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1401, 767 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1402, 191 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1402, 776 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1403, 198 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1404, 190 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1404, 764 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1405, 268 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1405, 758 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1405, 775 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1406, 778 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1407, 759 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1408, 252 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1408, 762 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1408, 772 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1408, 788 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1409, 249 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1409, 259 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1409, 260 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1410, 181 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1410, 763 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1411, 241 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1413, 761 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1415, 241 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1418, 256 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1419, 778 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1420, 201 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1420, 209 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1421, 195 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1422, 252 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1423, 789 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1424, 198 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1424, 249 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1424, 268 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1424, 783 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1425, 189 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1425, 212 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1425, 780 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1426, 266 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1426, 760 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1427, 183 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1427, 205 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1427, 266 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1431, 189 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1431, 781 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1432, 776 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1432, 777 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1433, 180 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1433, 196 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1433, 207 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1433, 256 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1433, 789 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1434, 198 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1434, 242 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1434, 244 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1434, 763 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1435, 765 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1436, 186 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1436, 207 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1436, 211 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1436, 776 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1437, 254 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1437, 779 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1437, 787 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1438, 766 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1438, 771 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1439, 255 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1439, 772 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1440, 776 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1441, 183 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1441, 261 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1442, 245 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1443, 247 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1443, 265 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1443, 771 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1443, 778 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1444, 255 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1444, 770 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1445, 764 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1447, 211 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ticket_seat",
                keyColumns: new[] { "display_id", "seat_id", "ticket_id" },
                keyValues: new object[] { 19, 1448, 194 },
                column: "ScreeningId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_ticket_seat_ScreeningId",
                table: "ticket_seat",
                column: "ScreeningId");

            migrationBuilder.AddForeignKey(
                name: "FK_ticket_seat_screenings_ScreeningId",
                table: "ticket_seat",
                column: "ScreeningId",
                principalTable: "screenings",
                principalColumn: "screening_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ticket_seat_screenings_ScreeningId",
                table: "ticket_seat");

            migrationBuilder.DropIndex(
                name: "IX_ticket_seat_ScreeningId",
                table: "ticket_seat");

            migrationBuilder.DropColumn(
                name: "ScreeningId",
                table: "ticket_seat");
        }
    }
}
