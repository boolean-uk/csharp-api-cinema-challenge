using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class _06Checkifitsupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4889), "ginger.hendrix@gov.us", "Ginger Hendrix", "64 68 94 16", new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4902), "oprah.trump@tesla.com", "Oprah Trump", "92 98 63 32", new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4902) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4907), "audrey.hepburn@something.com", "Audrey Hepburn", "40 09 67 48", new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4915), "keith.may@tesla.com", "Keith May", "43 46 49 19", new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4920), "roger.moon@gov.gr", "Roger Moon", "73 76 80 91", new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4927), "charlie.watts@gov.nl", "Charlie Watts", "95 67 88 43", new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4936), "donald.iommi@bbc.co.uk", "Donald Iommi", "41 99 23 26", new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4936) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4943), "tony.obama@gov.us", "Tony Obama", "67 19 79 17", new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4948), "brian.dio@gov.us", "Brian Dio", "43 55 14 61", new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4948) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4954), "bill.may@gov.us", "Bill May", "86 60 40 71", new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4960), new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4963), new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4965), new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4967), new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4968), new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "capacity", "created_at", "fk_movie_id", "starts_at", "updated_at" },
                values: new object[] { 186, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4987), 4, new DateTime(2024, 2, 11, 3, 40, 55, 146, DateTimeKind.Utc).AddTicks(4980), new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "capacity", "created_at", "fk_movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 67, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4992), 5, 1, new DateTime(2024, 2, 11, 3, 40, 55, 146, DateTimeKind.Utc).AddTicks(4991), new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "capacity", "created_at", "fk_movie_id", "starts_at", "updated_at" },
                values: new object[] { 173, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4993), 5, new DateTime(2024, 2, 11, 2, 40, 55, 146, DateTimeKind.Utc).AddTicks(4993), new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "capacity", "created_at", "fk_movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 201, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4995), 1, 2, new DateTime(2024, 2, 11, 2, 40, 55, 146, DateTimeKind.Utc).AddTicks(4994), new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "capacity", "created_at", "fk_movie_id", "starts_at", "updated_at" },
                values: new object[] { 65, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5026), 1, new DateTime(2024, 2, 11, 3, 40, 55, 146, DateTimeKind.Utc).AddTicks(5025), new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5042), 2, 1, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5047), 4, 5, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5048), 6, 1, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5049), 6, 1, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5049) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5050), 10, 2, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5052), 5, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5053), 5, 1, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5054), 8, 4, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5055), 1, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5055) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5057), 5, 4, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5058), 5, 2, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5059), 5, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5060), 4, 2, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "created_at", "fk_customer_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5061), 8, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5062), 3, 3, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "created_at", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5063), 4, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5064), 6, 4, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5065), 1, 3, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "created_at", "fk_customer_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5066), 10, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5067), 3, 2, new DateTime(2024, 2, 10, 22, 40, 55, 146, DateTimeKind.Utc).AddTicks(5067) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3904), "mick.baker@theworld.ca", "Mick Baker", "81 96 00 67", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3906) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3913), "kate.winslet@gov.gr", "Kate Winslet", "43 48 09 95", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3918), "geezer.ward@theworld.ca", "Geezer Ward", "94 64 22 91", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3918) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3922), "kate.dio@gov.nl", "Kate Dio", "43 79 01 38", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3923) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3927), "jimi.trump@gov.gr", "Jimi Trump", "90 99 19 52", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3933), "ronnie.jagger@gov.gr", "Ronnie Jagger", "76 27 10 36", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3937), "roger.winslet@bbc.co.uk", "Roger Winslet", "82 15 13 30", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3941), "geezer.winfrey@gov.us", "Geezer Winfrey", "45 24 88 28", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3945), "mick.may@google.com", "Mick May", "94 79 08 01", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3950), "audrey.iommi@bbc.co.uk", "Audrey Iommi", "77 75 91 68", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3956), new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3958), new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3958) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3959), new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3961), new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3963), new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3963) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "capacity", "created_at", "fk_movie_id", "starts_at", "updated_at" },
                values: new object[] { 119, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3977), 1, new DateTime(2024, 2, 9, 18, 4, 58, 915, DateTimeKind.Utc).AddTicks(3970), new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3977) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "capacity", "created_at", "fk_movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 195, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3979), 3, 2, new DateTime(2024, 2, 9, 18, 4, 58, 915, DateTimeKind.Utc).AddTicks(3979), new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "capacity", "created_at", "fk_movie_id", "starts_at", "updated_at" },
                values: new object[] { 176, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3980), 1, new DateTime(2024, 2, 9, 17, 4, 58, 915, DateTimeKind.Utc).AddTicks(3980), new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3981) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "capacity", "created_at", "fk_movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 112, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3981), 4, 3, new DateTime(2024, 2, 9, 18, 4, 58, 915, DateTimeKind.Utc).AddTicks(3981), new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "capacity", "created_at", "fk_movie_id", "starts_at", "updated_at" },
                values: new object[] { 50, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3983), 3, new DateTime(2024, 2, 9, 19, 4, 58, 915, DateTimeKind.Utc).AddTicks(3982), new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3987), 8, 5, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3989), 10, 4, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3990), 1, 3, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3991), 1, 3, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3992), 4, 3, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3993), 3, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3994), 2, 2, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3995), 4, 3, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3996), 3, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3997), 2, 5, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3998), 2, 5, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3998), 4, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3999), 1, 5, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3999) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "created_at", "fk_customer_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4000), 5, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4001), 10, 2, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "created_at", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4029), 1, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4030), 1, 5, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4032), 7, 4, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "created_at", "fk_customer_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4032), 6, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4033), 2, 5, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4033) });
        }
    }
}
