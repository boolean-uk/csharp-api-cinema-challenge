using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigrationSave : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1386), new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1391) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1402), new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1407) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1411), new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1430), new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1434) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1211), "Suitable for all ages.", "NC-17", 144, new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1352), "The greatest movie ever made.", "G", 141, new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1361) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1366), "It was ok, critics are indifferent.", "NC-17", 169, new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1375), "This is a cult classic.", "NC-17", 46, new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 39, new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1446), 2, 1, new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1441), new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 47, new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1474), 4, 4, new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1470), new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 60, new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1487), 4, 1, new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1483), new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1491) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 56, new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1499), 3, 30, new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1495), new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumns: new[] { "customer_id", "id", "screening_id" },
                keyValues: new object[] { 2, 1, 2 },
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1535), new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumns: new[] { "customer_id", "id", "screening_id" },
                keyValues: new object[] { 3, 2, 3 },
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1550), new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumns: new[] { "customer_id", "id", "screening_id" },
                keyValues: new object[] { 4, 3, 4 },
                columns: new[] { "created_at", "num_seats", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1559), 2, new DateTime(2024, 2, 5, 20, 32, 28, 472, DateTimeKind.Utc).AddTicks(1563) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8012), new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8053), new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8063), new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8082), new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(7825), "It was ok, critics are indifferent.", "G", 140, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(7966), "Suitable for all ages.", "R", 53, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(7979), "This is a cult classic.", "G", 58, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(7992), "The greatest movie ever made.", "PG", 61, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 51, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8104), 4, 19, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8096), new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 46, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8147), 2, 25, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8141), new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 40, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8164), 2, 35, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8159), new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 39, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8178), 2, 7, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8174), new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumns: new[] { "customer_id", "id", "screening_id" },
                keyValues: new object[] { 2, 1, 2 },
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8191), new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumns: new[] { "customer_id", "id", "screening_id" },
                keyValues: new object[] { 3, 2, 3 },
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8249), new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumns: new[] { "customer_id", "id", "screening_id" },
                keyValues: new object[] { 4, 3, 4 },
                columns: new[] { "created_at", "num_seats", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8259), 4, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8263) });
        }
    }
}
