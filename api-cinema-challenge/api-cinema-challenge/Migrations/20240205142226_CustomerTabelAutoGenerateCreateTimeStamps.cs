﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class CustomerTabelAutoGenerateCreateTimeStamps : Migration
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Customers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "CreatedAt", "MovieId", "ScreenId", "StartsAt", "UpdatedAt", "price_per_seat" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), 1, 1, new DateTime(2024, 2, 5, 17, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), 100 },
                    { 2, new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), 2, 2, new DateTime(2024, 2, 5, 19, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), 100 }
                });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278), new DateTime(2024, 2, 5, 14, 22, 26, 214, DateTimeKind.Utc).AddTicks(9278) });
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Customers",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "CreatedAt", "MovieId", "ScreenId", "StartsAt", "UpdatedAt", "price_per_seat" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), 1, 1, new DateTime(2024, 2, 5, 16, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), 100 },
                    { 2, new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), 2, 2, new DateTime(2024, 2, 5, 18, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), 100 }
                });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumns: new[] { "screeningId", "seatId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246), new DateTime(2024, 2, 5, 13, 37, 29, 689, DateTimeKind.Utc).AddTicks(9246) });
        }
    }
}
