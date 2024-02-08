using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class _03MoreLikeSpec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "seats_bought",
                table: "tickets",
                newName: "number_of_seats");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1047), "oprah.trump@bbc.co.uk", "Oprah Trump", "61 12 16 23", new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1056), "charles.watts@theworld.ca", "Charles Watts", "60 76 76 89", new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1060), "brian.moon@nasa.org.us", "Brian Moon", "91 13 96 54", new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1064), "kate.daltrey@something.com", "Kate Daltrey", "95 81 62 72", new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1068), "ozzy.winfrey@gov.us", "Ozzy Winfrey", "92 28 29 67", new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1072), "charles.ward@gov.ru", "Charles Ward", "71 41 38 71", new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1072) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1076), "ginger.jagger@gov.us", "Ginger Jagger", "58 68 75 53", new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1081), "roger.may@gov.ru", "Roger May", "42 82 95 44", new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1084), "keith.iommi@gov.ru", "Keith Iommi", "57 32 65 99", new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1084) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1088), "charlie.presley@gov.us", "Charlie Presley", "56 02 21 57", new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1094), new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1096), new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1096) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1097), new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1099), new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1100), new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "fk_movie_id", "fk_silver_screen_id", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1119), 5, 1, new DateTime(2024, 2, 8, 15, 42, 13, 115, DateTimeKind.Utc).AddTicks(1112), new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "fk_movie_id", "fk_silver_screen_id", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1121), 3, 1, new DateTime(2024, 2, 8, 15, 42, 13, 115, DateTimeKind.Utc).AddTicks(1121), new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "fk_movie_id", "fk_silver_screen_id", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1122), 5, 1, new DateTime(2024, 2, 8, 13, 42, 13, 115, DateTimeKind.Utc).AddTicks(1122), new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "fk_movie_id", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1124), 2, new DateTime(2024, 2, 8, 14, 42, 13, 115, DateTimeKind.Utc).AddTicks(1123), new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "fk_movie_id", "fk_silver_screen_id", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1124), 4, 1, new DateTime(2024, 2, 8, 15, 42, 13, 115, DateTimeKind.Utc).AddTicks(1124), new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "silver_screens",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1105), new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "silver_screens",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1107), new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1128), 3, 2, new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1130), 4, new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1130), new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1131), 3, 1, new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1132), 3, 3, new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1133), 9, 1, new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1134), 2, 5, new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "fk_customer_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1135), 6, new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1135), 3, 3, new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "fk_customer_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1137), 7, new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "fk_customer_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1137), 10, new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1138) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1138), 5, 2, new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1138) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1138), 7, 5, new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1139), 6, 2, new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1140), 6, 3, new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1140), 1, 2, new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1141), 7, 2, new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1142), 4, 4, new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1143), 10, 1, new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "created_at", "fk_customer_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1143), 5, new DateTime(2024, 2, 8, 10, 42, 13, 115, DateTimeKind.Utc).AddTicks(1144) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "number_of_seats",
                table: "tickets",
                newName: "seats_bought");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8164), "keith.windsor@gov.ru", "Keith Windsor", "79 70 44 13", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8165) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8171), "bill.moon@bbc.co.uk", "Bill Moon", "95 57 08 94", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8174), "jimi.moon@something.com", "Jimi Moon", "49 25 63 99", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8177), "elvis.hepburn@google.com", "Elvis Hepburn", "58 09 24 68", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8180), "oprah.butler@gov.ru", "Oprah Butler", "97 82 67 94", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8184), "barack.winslet@google.com", "Barack Winslet", "72 64 60 26", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8184) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8187), "ronnie.trump@gov.us", "Ronnie Trump", "58 76 89 67", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8187) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8190), "donald.butler@gov.us", "Donald Butler", "79 50 61 18", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8193), "barack.trump@bbc.co.uk", "Barack Trump", "47 18 55 83", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8193) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8196), "ozzy.middleton@something.com", "Ozzy Middleton", "79 02 01 31", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8199), new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8201), new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8202), new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8203) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8204), new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8204) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8205), new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8205) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "fk_movie_id", "fk_silver_screen_id", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8221), 3, 2, new DateTime(2024, 2, 8, 13, 5, 19, 789, DateTimeKind.Utc).AddTicks(8215), new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "fk_movie_id", "fk_silver_screen_id", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8223), 2, 2, new DateTime(2024, 2, 8, 15, 5, 19, 789, DateTimeKind.Utc).AddTicks(8222), new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8223) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "fk_movie_id", "fk_silver_screen_id", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8224), 1, 2, new DateTime(2024, 2, 8, 15, 5, 19, 789, DateTimeKind.Utc).AddTicks(8223), new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "fk_movie_id", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8225), 1, new DateTime(2024, 2, 8, 13, 5, 19, 789, DateTimeKind.Utc).AddTicks(8225), new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "fk_movie_id", "fk_silver_screen_id", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8226), 3, 2, new DateTime(2024, 2, 8, 13, 5, 19, 789, DateTimeKind.Utc).AddTicks(8225), new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "silver_screens",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8209), new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8209) });

            migrationBuilder.UpdateData(
                table: "silver_screens",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8210), new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8229), 6, 5, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8230), 1, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8231), new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8232), 10, 3, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8232), 7, 5, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8233), 2, 3, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8234) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8234), 6, 4, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8234) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "fk_customer_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8235), 1, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8235), 9, 5, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "fk_customer_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8236), 5, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8237) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "fk_customer_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8237), 9, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8237) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8238), 9, 5, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8238), 8, 4, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8239), 3, 5, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8240), 7, 2, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8240), 7, 1, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8241), 1, 3, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8242), 9, 1, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "created_at", "fk_customer_id", "fk_screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8243), 3, 3, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "created_at", "fk_customer_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8243), 4, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8244) });
        }
    }
}
