using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "rating",
                table: "movies",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 18, 44, 31, 719, DateTimeKind.Utc).AddTicks(1603), new DateTime(2024, 9, 16, 18, 44, 31, 719, DateTimeKind.Utc).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 18, 44, 31, 719, DateTimeKind.Utc).AddTicks(1607), new DateTime(2024, 9, 16, 18, 44, 31, 719, DateTimeKind.Utc).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 18, 44, 31, 719, DateTimeKind.Utc).AddTicks(1610), new DateTime(2024, 9, 16, 18, 44, 31, 719, DateTimeKind.Utc).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "rating", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 18, 44, 31, 719, DateTimeKind.Utc).AddTicks(1723), "R", new DateTime(2024, 9, 16, 18, 44, 31, 719, DateTimeKind.Utc).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "rating", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 18, 44, 31, 719, DateTimeKind.Utc).AddTicks(1727), "G", new DateTime(2024, 9, 16, 18, 44, 31, 719, DateTimeKind.Utc).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "rating", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 18, 44, 31, 719, DateTimeKind.Utc).AddTicks(1729), "PG-13", new DateTime(2024, 9, 16, 18, 44, 31, 719, DateTimeKind.Utc).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 18, 44, 31, 719, DateTimeKind.Utc).AddTicks(1754), new DateTime(2024, 9, 16, 18, 44, 31, 719, DateTimeKind.Utc).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 18, 44, 31, 719, DateTimeKind.Utc).AddTicks(1757), new DateTime(2024, 9, 16, 18, 44, 31, 719, DateTimeKind.Utc).AddTicks(1758) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 18, 44, 31, 719, DateTimeKind.Utc).AddTicks(1759), new DateTime(2024, 9, 16, 18, 44, 31, 719, DateTimeKind.Utc).AddTicks(1760) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "rating",
                table: "movies",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

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
                columns: new[] { "createdAt", "rating", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(803), 4, new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "rating", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(805), 10, new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "rating", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(807), 4, new DateTime(2024, 9, 16, 13, 50, 1, 624, DateTimeKind.Utc).AddTicks(807) });

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
        }
    }
}
