using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class testsAndTribulations2ElectricBoogaloo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 2, 1, 13, 37, 50, 955, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 2, 1, 13, 37, 50, 955, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 2, 1, 13, 37, 50, 955, DateTimeKind.Utc).AddTicks(3893));

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
                columns: new[] { "CreatedAt", "starts_at" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 37, 50, 955, DateTimeKind.Utc).AddTicks(3851), new DateTime(2024, 2, 1, 13, 37, 50, 955, DateTimeKind.Utc).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "starts_at" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 37, 50, 955, DateTimeKind.Utc).AddTicks(3857), new DateTime(2024, 2, 1, 13, 37, 50, 955, DateTimeKind.Utc).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "starts_at" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 37, 50, 955, DateTimeKind.Utc).AddTicks(3859), new DateTime(2024, 2, 1, 13, 37, 50, 955, DateTimeKind.Utc).AddTicks(3711) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 2, 1, 13, 7, 54, 436, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 2, 1, 13, 7, 54, 436, DateTimeKind.Utc).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 2, 1, 13, 7, 54, 436, DateTimeKind.Utc).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 7, 54, 436, DateTimeKind.Utc).AddTicks(8273), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 7, 54, 436, DateTimeKind.Utc).AddTicks(8279), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "starts_at" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 7, 54, 436, DateTimeKind.Utc).AddTicks(8507), new DateTime(2024, 2, 1, 13, 7, 54, 436, DateTimeKind.Utc).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "starts_at" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 7, 54, 436, DateTimeKind.Utc).AddTicks(8513), new DateTime(2024, 2, 1, 13, 7, 54, 436, DateTimeKind.Utc).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "starts_at" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 7, 54, 436, DateTimeKind.Utc).AddTicks(8514), new DateTime(2024, 2, 1, 13, 7, 54, 436, DateTimeKind.Utc).AddTicks(8389) });
        }
    }
}
