using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class _07TicketTestingNumSeats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5702), "ozzy.middleton@gov.gr", "Ozzy Middleton", "87 54 74 95", new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5731), "ozzy.winfrey@gov.gr", "Ozzy Winfrey", "54 71 23 38", new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5736), "ronnie.dio@something.com", "Ronnie Dio", "87 89 94 48", new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5739), "bill.trump@gov.ru", "Bill Trump", "98 27 15 35", new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5742), "tony.watts@google.com", "Tony Watts", "59 42 03 42", new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5746), "barack.presley@bbc.co.uk", "Barack Presley", "77 43 19 91", new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5750), "mick.watts@gov.ru", "Mick Watts", "41 76 26 88", new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5753), "roger.ward@bbc.co.uk", "Roger Ward", "44 02 29 77", new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5756), "keith.presley@theworld.ca", "Keith Presley", "43 50 34 55", new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5760), "ginger.jagger@tesla.com", "Ginger Jagger", "97 29 39 14", new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5764), new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5767), new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5768), new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5770), new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5771), new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "capacity", "created_at", "fk_movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 65, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5797), 3, 2, new DateTime(2024, 2, 12, 14, 22, 31, 684, DateTimeKind.Utc).AddTicks(5789), new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "capacity", "created_at", "fk_movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 148, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5799), 4, 1, new DateTime(2024, 2, 12, 14, 22, 31, 684, DateTimeKind.Utc).AddTicks(5799), new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "capacity", "created_at", "starts_at", "updated_at" },
                values: new object[] { 148, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5801), new DateTime(2024, 2, 12, 13, 22, 31, 684, DateTimeKind.Utc).AddTicks(5800), new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "capacity", "created_at", "fk_movie_id", "starts_at", "updated_at" },
                values: new object[] { 84, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5802), 3, new DateTime(2024, 2, 12, 14, 22, 31, 684, DateTimeKind.Utc).AddTicks(5801), new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "capacity", "created_at", "fk_movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 178, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5803), 1, 3, new DateTime(2024, 2, 12, 14, 22, 31, 684, DateTimeKind.Utc).AddTicks(5802), new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5808), 3, 3, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5809), 7, 6, 3, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5810), 7, 5, 3, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5811), 9, 3, 1, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5812), 7, 7, 3, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5813), 6, 5, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5814), 8, 6, 4, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5815), 4, 2, 3, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5815), 2, 5, 1, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5816), 9, 7, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5817), 6, 2, 2, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5818), 10, 6, 2, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5818), 8, 1, 2, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5819), 9, 3, 4, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5820), 2, 2, 1, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5820), 3, 5, 3, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5821), 3, 7, 1, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5822), 5, 4, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5823), 5, 4, 2, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5823), 7, 1, 3, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5824) });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[,]
                {
                    { 21, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5824), 5, 2, 5, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5824) },
                    { 22, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5825), 10, 1, 3, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5825) },
                    { 23, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5825), 2, 2, 3, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5826) },
                    { 24, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5826), 10, 6, 2, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5826) },
                    { 25, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5826), 5, 3, 2, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5827) },
                    { 26, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5827), 10, 4, 5, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5827) },
                    { 27, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5828), 9, 1, 3, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5828) },
                    { 28, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5828), 10, 3, 3, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5828) },
                    { 29, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5829), 6, 6, 3, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5829) },
                    { 30, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5829), 10, 7, 3, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5830) },
                    { 31, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5830), 10, 3, 4, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5830) },
                    { 32, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5831), 1, 2, 4, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5831) },
                    { 33, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5831), 9, 6, 4, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5832) },
                    { 34, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5833), 2, 2, 5, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5833) },
                    { 35, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5834), 6, 7, 4, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5834) },
                    { 36, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5834), 1, 3, 3, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5835) },
                    { 37, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5835), 10, 4, 4, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5835) },
                    { 38, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5836), 5, 6, 2, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5836) },
                    { 39, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5836), 5, 4, 1, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5837) },
                    { 40, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5837), 4, 5, 5, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5837) },
                    { 41, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5838), 8, 2, 2, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5838) },
                    { 42, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5838), 10, 2, 5, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5839) },
                    { 43, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5839), 2, 3, 1, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5839) },
                    { 44, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5840), 3, 5, 5, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5840) },
                    { 45, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5840), 1, 1, 2, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5840) },
                    { 46, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5841), 1, 6, 2, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5841) },
                    { 47, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5841), 10, 4, 2, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5842) },
                    { 48, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5842), 3, 1, 5, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5842) },
                    { 49, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5843), 6, 1, 2, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5843) },
                    { 50, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5843), 9, 1, 2, new DateTime(2024, 2, 12, 9, 22, 31, 684, DateTimeKind.Utc).AddTicks(5844) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5318), "kate.trump@google.com", "Kate Trump", "67 45 42 48", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5327), "ronnie.dio@gov.ru", "Ronnie Dio", "40 73 81 67", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5331), "mick.hendrix@something.com", "Mick Hendrix", "81 30 29 31", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5335), "jimi.butler@theworld.ca", "Jimi Butler", "82 38 31 32", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5339), "ronnie.may@google.com", "Ronnie May", "88 73 84 61", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5343), "roger.butler@something.com", "Roger Butler", "43 05 97 35", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5346), "ozzy.daltrey@gov.ru", "Ozzy Daltrey", "43 53 73 12", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5349), "elvis.trump@nasa.org.us", "Elvis Trump", "88 51 61 55", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5378), "charlie.presley@google.com", "Charlie Presley", "77 98 15 47", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5382), "bill.baker@bbc.co.uk", "Bill Baker", "87 47 39 38", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5386), new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5387) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5389), new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5390), new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5391), new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5392), new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "capacity", "created_at", "fk_movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 108, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5416), 4, 1, new DateTime(2024, 2, 12, 13, 18, 51, 477, DateTimeKind.Utc).AddTicks(5410), new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5417) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "capacity", "created_at", "fk_movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 210, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5419), 1, 2, new DateTime(2024, 2, 12, 12, 18, 51, 477, DateTimeKind.Utc).AddTicks(5419), new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "capacity", "created_at", "starts_at", "updated_at" },
                values: new object[] { 207, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5420), new DateTime(2024, 2, 12, 12, 18, 51, 477, DateTimeKind.Utc).AddTicks(5420), new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "capacity", "created_at", "fk_movie_id", "starts_at", "updated_at" },
                values: new object[] { 211, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5421), 2, new DateTime(2024, 2, 12, 13, 18, 51, 477, DateTimeKind.Utc).AddTicks(5421), new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5421) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "capacity", "created_at", "fk_movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 105, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5422), 3, 2, new DateTime(2024, 2, 12, 14, 18, 51, 477, DateTimeKind.Utc).AddTicks(5422), new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5426), 0, 5, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5427), 9, 0, 4, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5428) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5428), 4, 0, 2, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5428) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5429), 5, 0, 5, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5429) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5429), 8, 0, 1, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5431), 4, 0, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5431) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5431), 4, 0, 3, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5432) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5432), 2, 0, 4, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5432) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5433), 4, 0, 4, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5434), 10, 0, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5434), 9, 0, 1, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5435), 3, 0, 1, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5435), 9, 0, 1, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5436), 10, 0, 1, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5437), 4, 0, 2, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5437), 1, 0, 1, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5438), 6, 0, 4, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5439), 3, 0, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5440), 9, 0, 3, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5440), 5, 0, 2, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5441) });
        }
    }
}
