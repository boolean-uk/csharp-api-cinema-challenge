using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class AddAdditionalSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482), new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482), 2, new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482), new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482), new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Phone", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482), "alice.johnson@example.com", "Alice Johnson", "123-555-7890", new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Runtime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482), new DateTime(2024, 1, 2, 2, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedAt", "Description", "Director", "Rating", "ReleaseDate", "Runtime", "Title", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482), "A journey through space.", "Chris Nolan", "PG-13", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 2, 2, 30, 0, 0, DateTimeKind.Utc), "Space Odyssey", new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "StartsAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482), new DateTime(2024, 2, 2, 13, 8, 17, 219, DateTimeKind.Utc).AddTicks(482), new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482), new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.InsertData(
                table: "Screens",
                columns: new[] { "id", "CreatedAt", "UpdatedAt", "name" },
                values: new object[] { 2, new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482), new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482), "Screen 2" });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482), new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "CreatedAt", "ScreenId", "UpdatedAt", "rowNumber", "seatNumber" },
                values: new object[] { 2, new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482), 1, new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482), 1, 2 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482), new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "CreatedAt", "MovieId", "ScreenId", "StartsAt", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482), 2, 2, new DateTime(2024, 2, 2, 15, 8, 17, 219, DateTimeKind.Utc).AddTicks(482), new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "screeningId", "seatId", "Id", "bookingId", "createdAt", "price", "updatedAt" },
                values: new object[,]
                {
                    { 1, 2, 2, null, new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482), 12.5f, new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482) },
                    { 2, 1, 3, 2, new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482), 15f, new DateTime(2024, 2, 2, 10, 8, 17, 219, DateTimeKind.Utc).AddTicks(482) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 8, 53, 18, 887, DateTimeKind.Utc).AddTicks(5504), new DateTime(2024, 2, 2, 8, 53, 18, 887, DateTimeKind.Utc).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 8, 53, 18, 887, DateTimeKind.Utc).AddTicks(5504), new DateTime(2024, 2, 2, 8, 53, 18, 887, DateTimeKind.Utc).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 8, 53, 18, 887, DateTimeKind.Utc).AddTicks(5504), new DateTime(2024, 2, 2, 8, 53, 18, 887, DateTimeKind.Utc).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Runtime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 8, 53, 18, 887, DateTimeKind.Utc).AddTicks(5504), new DateTime(2, 1, 1, 2, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 2, 8, 53, 18, 887, DateTimeKind.Utc).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "StartsAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 8, 53, 18, 887, DateTimeKind.Utc).AddTicks(5504), new DateTime(2024, 2, 2, 11, 53, 18, 887, DateTimeKind.Utc).AddTicks(5504), new DateTime(2024, 2, 2, 8, 53, 18, 887, DateTimeKind.Utc).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 8, 53, 18, 887, DateTimeKind.Utc).AddTicks(5504), new DateTime(2024, 2, 2, 8, 53, 18, 887, DateTimeKind.Utc).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 8, 53, 18, 887, DateTimeKind.Utc).AddTicks(5504), new DateTime(2024, 2, 2, 8, 53, 18, 887, DateTimeKind.Utc).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 8, 53, 18, 887, DateTimeKind.Utc).AddTicks(5504), new DateTime(2024, 2, 2, 8, 53, 18, 887, DateTimeKind.Utc).AddTicks(5504) });
        }
    }
}
