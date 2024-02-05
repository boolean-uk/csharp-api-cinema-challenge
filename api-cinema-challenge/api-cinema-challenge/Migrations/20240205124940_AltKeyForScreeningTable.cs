using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class AltKeyForScreeningTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Screenings_ScreenId",
                table: "Screenings");

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Screenings_ScreenId_StartsAt",
                table: "Screenings",
                columns: new[] { "ScreenId", "StartsAt" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "CreatedAt", "MovieId", "ScreenId", "StartsAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), 1, 1, new DateTime(2024, 2, 5, 15, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222) },
                    { 2, new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), 2, 2, new DateTime(2024, 2, 5, 17, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222) }
                });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 2, 5, 12, 49, 39, 683, DateTimeKind.Utc).AddTicks(4222) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Screenings_ScreenId_StartsAt",
                table: "Screenings");

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

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_ScreenId",
                table: "Screenings",
                column: "ScreenId");
        }
    }
}
