using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class CurrentMigrationCompletingCore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7859), new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7868), new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7870), new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7581), new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7588), new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7833), new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7694), new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7837), new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7694), new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7839), new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7694), new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7839) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
