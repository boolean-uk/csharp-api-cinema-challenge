using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class addedSeedingToTickets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 48, 23, 132, DateTimeKind.Utc).AddTicks(9366), new DateTime(2024, 2, 5, 12, 48, 23, 132, DateTimeKind.Utc).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 48, 23, 132, DateTimeKind.Utc).AddTicks(9380), new DateTime(2024, 2, 5, 12, 48, 23, 132, DateTimeKind.Utc).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 48, 23, 132, DateTimeKind.Utc).AddTicks(9382), new DateTime(2024, 2, 5, 12, 48, 23, 132, DateTimeKind.Utc).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 48, 23, 132, DateTimeKind.Utc).AddTicks(8968), new DateTime(2024, 2, 5, 12, 48, 23, 132, DateTimeKind.Utc).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 48, 23, 132, DateTimeKind.Utc).AddTicks(8982), new DateTime(2024, 2, 5, 12, 48, 23, 132, DateTimeKind.Utc).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 48, 23, 132, DateTimeKind.Utc).AddTicks(9319), new DateTime(2024, 2, 5, 14, 48, 23, 132, DateTimeKind.Utc).AddTicks(9122), new DateTime(2024, 2, 5, 12, 48, 23, 132, DateTimeKind.Utc).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 48, 23, 132, DateTimeKind.Utc).AddTicks(9330), new DateTime(2024, 2, 5, 12, 48, 23, 132, DateTimeKind.Utc).AddTicks(9122), new DateTime(2024, 2, 5, 12, 48, 23, 132, DateTimeKind.Utc).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 48, 23, 132, DateTimeKind.Utc).AddTicks(9332), new DateTime(2024, 2, 5, 12, 48, 23, 132, DateTimeKind.Utc).AddTicks(9122), new DateTime(2024, 2, 5, 12, 48, 23, 132, DateTimeKind.Utc).AddTicks(9332) });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "CreatedAt", "customer_id", "screening_id", "seat_nr", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 2, 5, 12, 48, 23, 132, DateTimeKind.Utc).AddTicks(9415), 1, 2, 0, new DateTime(2024, 2, 5, 12, 48, 23, 132, DateTimeKind.Utc).AddTicks(9417) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5358), new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5376), new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5378), new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(4992), new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5000), new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5327), new DateTime(2024, 2, 5, 14, 38, 20, 625, DateTimeKind.Utc).AddTicks(5193), new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5331), new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5193), new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5333), new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5193), new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5333) });
        }
    }
}
