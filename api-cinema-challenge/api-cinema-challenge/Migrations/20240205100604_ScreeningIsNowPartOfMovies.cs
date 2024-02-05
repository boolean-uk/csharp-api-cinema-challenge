using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class ScreeningIsNowPartOfMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7531), new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7539), new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7558), new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7100), new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7110), new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7484), new DateTime(2024, 2, 5, 12, 6, 4, 560, DateTimeKind.Utc).AddTicks(7315), new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7486) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7494), new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7315), new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7496), new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7315), new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7496) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
