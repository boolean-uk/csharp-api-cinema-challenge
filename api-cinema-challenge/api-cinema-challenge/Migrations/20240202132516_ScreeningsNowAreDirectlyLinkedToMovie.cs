using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class ScreeningsNowAreDirectlyLinkedToMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 13, 25, 16, 584, DateTimeKind.Utc).AddTicks(9732), new DateTime(2024, 2, 2, 13, 25, 16, 584, DateTimeKind.Utc).AddTicks(9734) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 13, 25, 16, 584, DateTimeKind.Utc).AddTicks(9744), new DateTime(2024, 2, 2, 13, 25, 16, 584, DateTimeKind.Utc).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 13, 25, 16, 584, DateTimeKind.Utc).AddTicks(9746), new DateTime(2024, 2, 2, 13, 25, 16, 584, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 13, 25, 16, 584, DateTimeKind.Utc).AddTicks(9405), new DateTime(2024, 2, 2, 13, 25, 16, 584, DateTimeKind.Utc).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 13, 25, 16, 584, DateTimeKind.Utc).AddTicks(9413), new DateTime(2024, 2, 2, 13, 25, 16, 584, DateTimeKind.Utc).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 13, 25, 16, 584, DateTimeKind.Utc).AddTicks(9700), new DateTime(2024, 2, 2, 13, 25, 16, 584, DateTimeKind.Utc).AddTicks(9562), new DateTime(2024, 2, 2, 13, 25, 16, 584, DateTimeKind.Utc).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 13, 25, 16, 584, DateTimeKind.Utc).AddTicks(9709), new DateTime(2024, 2, 2, 13, 25, 16, 584, DateTimeKind.Utc).AddTicks(9562), new DateTime(2024, 2, 2, 13, 25, 16, 584, DateTimeKind.Utc).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 13, 25, 16, 584, DateTimeKind.Utc).AddTicks(9711), new DateTime(2024, 2, 2, 13, 25, 16, 584, DateTimeKind.Utc).AddTicks(9562), new DateTime(2024, 2, 2, 13, 25, 16, 584, DateTimeKind.Utc).AddTicks(9711) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7914), new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7926), new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7929), new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7499), new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7504) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7514), new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7514) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7877), new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7708), new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7883), new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7708), new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7885), new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7708), new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7885) });
        }
    }
}
