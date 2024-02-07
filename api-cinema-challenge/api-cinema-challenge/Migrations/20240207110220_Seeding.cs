using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1001), "whyyyy@doihavetowritethis.net", "jefow", "48724242", new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1001) },
                    { 2, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1004), "whyyyy@doihavetowritethis.net", "fwjio", "48724242", new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1005) },
                    { 3, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1006), "fjiejf@fijefj.com", "jefow", "42478247", new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1006) },
                    { 4, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1007), "fjiejf@fijefj.com", "coiv", "59854853", new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1007) },
                    { 5, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1008), "whyyyy@doihavetowritethis.net", "ocvic", "42478247", new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1008) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "description", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1016), "oekroe oke oek oek eo ke", "PG-18", 183, "Wherefore", new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1016) },
                    { 2, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1019), "fijsogjoijg eofkofe koeo ke", "PG-39", 132, "Thou", new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1020) },
                    { 3, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1021), "oekroe oke oek oek eo ke", "PG-18", 68, "Why", new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1021) },
                    { 4, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1022), "fijsogjoijg eofkofe koeo ke", "PG-18", 66, "Thou", new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1022) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 62, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1027), 3, 50, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1027), new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1027) },
                    { 2, 40, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1031), 1, 84, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1031), new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1032) },
                    { 3, 94, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1033), 2, 64, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1033), new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1033) },
                    { 4, 2, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1034), 2, 28, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1034), new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1034) }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "created_at", "customer_id", "screening_id", "seat_num", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1039), 4, 1, 57, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1039) },
                    { 2, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1041), 1, 3, 21, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1041) },
                    { 3, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1042), 5, 3, 26, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1043) },
                    { 4, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1043), 1, 1, 61, new DateTime(2024, 2, 7, 11, 2, 20, 439, DateTimeKind.Utc).AddTicks(1044) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
