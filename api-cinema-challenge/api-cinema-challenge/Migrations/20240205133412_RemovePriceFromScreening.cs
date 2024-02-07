using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class RemovePriceFromScreening : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "price_per_seat",
                table: "Screenings");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103) });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "CreatedAt", "MovieId", "ScreenId", "StartsAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), 1, 1, new DateTime(2024, 2, 5, 16, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103) },
                    { 2, new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), 2, 2, new DateTime(2024, 2, 5, 18, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103) }
                });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 2, 5, 13, 34, 11, 620, DateTimeKind.Utc).AddTicks(5103) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<int>(
                name: "price_per_seat",
                table: "Screenings",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "CreatedAt", "MovieId", "ScreenId", "StartsAt", "UpdatedAt", "price_per_seat" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), 1, 1, new DateTime(2024, 2, 5, 16, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), 100 },
                    { 2, new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), 2, 2, new DateTime(2024, 2, 5, 18, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), 100 }
                });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759), new DateTime(2024, 2, 5, 13, 29, 12, 412, DateTimeKind.Utc).AddTicks(5759) });
        }
    }
}
