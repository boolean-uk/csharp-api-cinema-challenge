using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class changedForExtension : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_screening_movies_movie_id",
                table: "screening");

            migrationBuilder.DropIndex(
                name: "IX_screening_movie_id",
                table: "screening");

            migrationBuilder.AddColumn<string>(
                name: "rating",
                table: "movies",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(828), new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(834), new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(837), new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "rating", "rutimeMins", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(879), "PG-13", 124, new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "rating", "rutimeMins", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(884), "PG-14", 60, new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "rating", "rutimeMins", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(887), "PG-18", 460, new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(908), new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(909) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(915), new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(918), new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(918) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rating",
                table: "movies");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9594), new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9606), new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9607), new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "rutimeMins", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9656), 1, new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "rutimeMins", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9659), 1, new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "rutimeMins", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9661), 1, new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9686), new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9695), new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9697), new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9698) });

            migrationBuilder.CreateIndex(
                name: "IX_screening_movie_id",
                table: "screening",
                column: "movie_id");

            migrationBuilder.AddForeignKey(
                name: "FK_screening_movies_movie_id",
                table: "screening",
                column: "movie_id",
                principalTable: "movies",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
