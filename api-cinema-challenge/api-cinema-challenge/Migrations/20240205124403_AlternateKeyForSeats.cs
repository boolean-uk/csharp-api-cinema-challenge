using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class AlternateKeyForSeats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Seats_ScreenId",
                table: "Seats");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Seats_ScreenId_seatNumber",
                table: "Seats",
                columns: new[] { "ScreenId", "seatNumber" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "StartsAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 15, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "StartsAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 17, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 2, 5, 12, 44, 2, 871, DateTimeKind.Utc).AddTicks(1821) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Seats_ScreenId_seatNumber",
                table: "Seats");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "StartsAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 13, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "StartsAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 15, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.CreateIndex(
                name: "IX_Seats_ScreenId",
                table: "Seats",
                column: "ScreenId");
        }
    }
}
