using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class _02BasicTablesSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "starts_at",
                table: "screenings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8164), "keith.windsor@gov.ru", "Keith Windsor", "79 70 44 13", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8165) },
                    { 2, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8171), "bill.moon@bbc.co.uk", "Bill Moon", "95 57 08 94", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8171) },
                    { 3, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8174), "jimi.moon@something.com", "Jimi Moon", "49 25 63 99", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8174) },
                    { 4, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8177), "elvis.hepburn@google.com", "Elvis Hepburn", "58 09 24 68", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8177) },
                    { 5, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8180), "oprah.butler@gov.ru", "Oprah Butler", "97 82 67 94", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8181) },
                    { 6, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8184), "barack.winslet@google.com", "Barack Winslet", "72 64 60 26", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8184) },
                    { 7, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8187), "ronnie.trump@gov.us", "Ronnie Trump", "58 76 89 67", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8187) },
                    { 8, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8190), "donald.butler@gov.us", "Donald Butler", "79 50 61 18", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8190) },
                    { 9, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8193), "barack.trump@bbc.co.uk", "Barack Trump", "47 18 55 83", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8193) },
                    { 10, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8196), "ozzy.middleton@something.com", "Ozzy Middleton", "79 02 01 31", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8196) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8199), "The story of Henry Hill and his life in the mafia, covering his relationship with his wife Karen and his mob partners Jimmy Conway and Tommy DeVito.", "R", 148, "Goodfellas", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8200) },
                    { 2, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8201), "In 1980 Miami, a determined Cuban immigrant takes over a drug cartel and succumbs to greed.", "R", 170, "Scarface", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8201) },
                    { 3, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8202), "A family in 1630s New England is torn apart by the forces of witchcraft, black magic and possession.", "R", 93, "The VVitch: A New-England Folktale", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8203) },
                    { 4, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8204), "Vampire Count Orlok expresses interest in a new residence and real estate agent Hutter's wife.", "Not Rated", 94, "Nosferatu", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8204) },
                    { 5, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8205), "When a cockerel apparently flies into a chicken farm, the chickens see him as an opportunity to escape their evil owners.", "G", 84, "Chicken Run", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8205) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "created_at", "fk_movie_id", "fk_silver_screen_id", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8221), 3, 2, new DateTime(2024, 2, 8, 13, 5, 19, 789, DateTimeKind.Utc).AddTicks(8215), new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8221) },
                    { 2, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8223), 2, 2, new DateTime(2024, 2, 8, 15, 5, 19, 789, DateTimeKind.Utc).AddTicks(8222), new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8223) },
                    { 3, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8224), 1, 2, new DateTime(2024, 2, 8, 15, 5, 19, 789, DateTimeKind.Utc).AddTicks(8223), new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8224) },
                    { 4, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8225), 1, 2, new DateTime(2024, 2, 8, 13, 5, 19, 789, DateTimeKind.Utc).AddTicks(8225), new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8225) },
                    { 5, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8226), 3, 2, new DateTime(2024, 2, 8, 13, 5, 19, 789, DateTimeKind.Utc).AddTicks(8225), new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8226) }
                });

            migrationBuilder.InsertData(
                table: "silver_screens",
                columns: new[] { "id", "capacity", "created_at", "name", "updated_at" },
                values: new object[,]
                {
                    { 1, 200, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8209), "Inger Johanne", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8209) },
                    { 2, 50, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8210), "Dikken", new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8210) }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "created_at", "fk_customer_id", "fk_screening_id", "seats_bought", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8229), 6, 5, 0, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8229) },
                    { 2, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8230), 10, 1, 0, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8230) },
                    { 3, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8231), 1, 3, 0, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8231) },
                    { 4, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8232), 10, 3, 0, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8232) },
                    { 5, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8232), 7, 5, 0, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8233) },
                    { 6, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8233), 2, 3, 0, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8234) },
                    { 7, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8234), 6, 4, 0, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8234) },
                    { 8, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8235), 1, 3, 0, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8235) },
                    { 9, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8235), 9, 5, 0, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8236) },
                    { 10, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8236), 5, 5, 0, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8237) },
                    { 11, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8237), 9, 2, 0, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8237) },
                    { 12, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8238), 9, 5, 0, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8238) },
                    { 13, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8238), 8, 4, 0, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8239) },
                    { 14, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8239), 3, 5, 0, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8239) },
                    { 15, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8240), 7, 2, 0, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8240) },
                    { 16, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8240), 7, 1, 0, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8241) },
                    { 17, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8241), 1, 3, 0, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8241) },
                    { 18, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8242), 9, 1, 0, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8242) },
                    { 19, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8243), 3, 3, 0, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8243) },
                    { 20, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8243), 4, 3, 0, new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8244) }
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
                table: "customers",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: 10);

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
                table: "movies",
                keyColumn: "id",
                keyValue: 5);

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
                table: "screenings",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "silver_screens",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "silver_screens",
                keyColumn: "id",
                keyValue: 2);

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

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "starts_at",
                table: "screenings");
        }
    }
}
