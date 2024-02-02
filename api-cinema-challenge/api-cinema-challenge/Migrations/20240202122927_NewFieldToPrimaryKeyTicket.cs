using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class NewFieldToPrimaryKeyTicket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tickets",
                table: "tickets");

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumns: new[] { "customer_id", "screening_id" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumns: new[] { "customer_id", "screening_id" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumns: new[] { "customer_id", "screening_id" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.AddPrimaryKey(
                name: "PK_tickets",
                table: "tickets",
                columns: new[] { "id", "screening_id", "customer_id" });

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
                columns: new[] { "created_at", "rating", "runtime_mins", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(7825), "G", 140, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "runtime_mins", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(7966), 53, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "rating", "runtime_mins", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(7979), "G", 58, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(7985) });

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
                columns: new[] { "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8104), 4, 19, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8096), new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8123) });

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
                columns: new[] { "capacity", "created_at", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 39, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8178), 7, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8174), new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8183) });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "customer_id", "id", "screening_id", "created_at", "num_seats", "updated_at" },
                values: new object[,]
                {
                    { 2, 1, 2, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8191), 1, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8229) },
                    { 3, 2, 3, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8249), 3, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8253) },
                    { 4, 3, 4, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8259), 4, new DateTime(2024, 2, 2, 12, 29, 26, 505, DateTimeKind.Utc).AddTicks(8263) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tickets_screening_id",
                table: "tickets",
                column: "screening_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tickets",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_tickets_screening_id",
                table: "tickets");

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumns: new[] { "customer_id", "id", "screening_id" },
                keyValues: new object[] { 2, 1, 2 });

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumns: new[] { "customer_id", "id", "screening_id" },
                keyValues: new object[] { 3, 2, 3 });

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumns: new[] { "customer_id", "id", "screening_id" },
                keyValues: new object[] { 4, 3, 4 });

            migrationBuilder.AddPrimaryKey(
                name: "PK_tickets",
                table: "tickets",
                columns: new[] { "screening_id", "customer_id" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1896), new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1930), new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1938), new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1958), new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "rating", "runtime_mins", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1671), "PG-13", 158, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "runtime_mins", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1863), 91, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "rating", "runtime_mins", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1872), "R", 106, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1886), "This is a cult classic.", "G", 87, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1975), 2, 10, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1969), new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 50, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2005), 4, 8, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2001), new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 57, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2017), 1, 40, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2014), new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "capacity", "created_at", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 38, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2029), 36, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2025), new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2033) });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "customer_id", "screening_id", "created_at", "id", "num_seats", "updated_at" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2044), 1, 1, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2063) },
                    { 3, 3, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2082), 3, 2, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2086) },
                    { 2, 4, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2073), 2, 4, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2077) }
                });
        }
    }
}
