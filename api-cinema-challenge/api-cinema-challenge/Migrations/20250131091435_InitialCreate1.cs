using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 2, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 3, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 2, 2, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 2, 5, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 6, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 11, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 12, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 2, 1, 11, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 2, 1, 14, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 15, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) });
        }
    }
}
