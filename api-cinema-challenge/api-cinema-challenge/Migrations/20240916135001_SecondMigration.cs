using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_moives",
                table: "moives");

            migrationBuilder.RenameTable(
                name: "moives",
                newName: "movies");

            migrationBuilder.AddColumn<DateTime>(
                name: "createdAt",
                table: "screenings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updatedAt",
                table: "screenings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "createdAt",
                table: "customers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updatedAt",
                table: "customers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "createdAt",
                table: "movies",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updatedAt",
                table: "movies",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_movies",
                table: "movies",
                column: "id");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(711), new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(713) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(714), new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(716), new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(803), new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(805), new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(807), new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(821), new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(823), new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(825), new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(825) });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_movieId",
                table: "screenings",
                column: "movieId");

            migrationBuilder.AddForeignKey(
                name: "FK_screenings_movies_movieId",
                table: "screenings",
                column: "movieId",
                principalTable: "movies",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_screenings_movies_movieId",
                table: "screenings");

            migrationBuilder.DropIndex(
                name: "IX_screenings_movieId",
                table: "screenings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_movies",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "screenings");

            migrationBuilder.DropColumn(
                name: "updatedAt",
                table: "screenings");

            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "updatedAt",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "updatedAt",
                table: "movies");

            migrationBuilder.RenameTable(
                name: "movies",
                newName: "moives");

            migrationBuilder.AddPrimaryKey(
                name: "PK_moives",
                table: "moives",
                column: "id");
        }
    }
}
