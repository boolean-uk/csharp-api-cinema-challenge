using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class OnASeaOfBlood : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3637), new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3644), new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3646), new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3647) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3333), new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3341), new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3603), new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3475), new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3610), new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3475), new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3612), new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3475), new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3613) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 37, 50, 955, DateTimeKind.Utc).AddTicks(3889), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 37, 50, 955, DateTimeKind.Utc).AddTicks(3891), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 37, 50, 955, DateTimeKind.Utc).AddTicks(3893), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 37, 50, 955, DateTimeKind.Utc).AddTicks(3562), new DateTime(2024, 2, 1, 13, 37, 50, 955, DateTimeKind.Utc).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 37, 50, 955, DateTimeKind.Utc).AddTicks(3569), new DateTime(2024, 2, 1, 13, 37, 50, 955, DateTimeKind.Utc).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 37, 50, 955, DateTimeKind.Utc).AddTicks(3851), new DateTime(2024, 2, 1, 13, 37, 50, 955, DateTimeKind.Utc).AddTicks(3711), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 37, 50, 955, DateTimeKind.Utc).AddTicks(3857), new DateTime(2024, 2, 1, 13, 37, 50, 955, DateTimeKind.Utc).AddTicks(3711), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 37, 50, 955, DateTimeKind.Utc).AddTicks(3859), new DateTime(2024, 2, 1, 13, 37, 50, 955, DateTimeKind.Utc).AddTicks(3711), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
