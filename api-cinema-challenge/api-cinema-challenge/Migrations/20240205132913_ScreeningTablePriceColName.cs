using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class ScreeningTablePriceColName : Migration
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

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Screenings",
                newName: "price_per_seat");

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

            migrationBuilder.RenameColumn(
                name: "price_per_seat",
                table: "Screenings",
                newName: "price");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "CreatedAt", "MovieId", "ScreenId", "StartsAt", "UpdatedAt", "price" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), 1, 1, new DateTime(2024, 2, 5, 16, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), 100 },
                    { 2, new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), 2, 2, new DateTime(2024, 2, 5, 18, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), 100 }
                });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140) });
        }
    }
}
