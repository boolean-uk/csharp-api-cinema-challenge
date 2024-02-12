using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class movieId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "movie_id",
                table: "screening",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9656), new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9659), new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9661), new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "movie_id", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9686), 1, new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "movie_id", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9695), 2, new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "movie_id", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9697), 3, new DateTime(2024, 2, 12, 9, 51, 21, 481, DateTimeKind.Utc).AddTicks(9698) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_screening_movies_movie_id",
                table: "screening");

            migrationBuilder.DropIndex(
                name: "IX_screening_movie_id",
                table: "screening");

            migrationBuilder.DropColumn(
                name: "movie_id",
                table: "screening");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5207), new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5211), new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5213), new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5214) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5238), new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5241), new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5243), new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5260), new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5265), new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5267), new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5267) });
        }
    }
}
