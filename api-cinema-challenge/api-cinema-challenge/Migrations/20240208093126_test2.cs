using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "rating",
                table: "Movies",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "customer_id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2015, 8, 23, 22, 0, 0, 0, DateTimeKind.Utc), "Charles Trump@asl.com", "Charles Trump", "82458330", new DateTime(2015, 8, 23, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, new DateTime(2011, 7, 10, 22, 0, 0, 0, DateTimeKind.Utc), "Kate Presley@hotmail.com", "Kate Presley", "26653569", new DateTime(2011, 7, 10, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, new DateTime(2008, 3, 4, 23, 0, 0, 0, DateTimeKind.Utc), "Charles Hepburn@asl.com", "Charles Hepburn", "96970046", new DateTime(2008, 3, 4, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, new DateTime(2022, 4, 15, 22, 0, 0, 0, DateTimeKind.Utc), "Charles Winslet@gmail.com", "Charles Winslet", "78707434", new DateTime(2022, 4, 15, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, new DateTime(2008, 10, 7, 22, 0, 0, 0, DateTimeKind.Utc), "Jimi Windsor@asl.com", "Jimi Windsor", "64367524", new DateTime(2008, 10, 7, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, new DateTime(2020, 8, 7, 22, 0, 0, 0, DateTimeKind.Utc), "Oprah Presley@gmail.com", "Oprah Presley", "92635246", new DateTime(2020, 8, 7, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, new DateTime(2011, 4, 17, 22, 0, 0, 0, DateTimeKind.Utc), "Mick Windsor@msn.com", "Mick Windsor", "25644374", new DateTime(2011, 4, 17, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, new DateTime(2015, 10, 22, 22, 0, 0, 0, DateTimeKind.Utc), "Kate Trump@outlook.com", "Kate Trump", "98949102", new DateTime(2015, 10, 22, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 9, new DateTime(2021, 10, 22, 22, 0, 0, 0, DateTimeKind.Utc), "Jimi Winfrey@hotmail.com", "Jimi Winfrey", "61947005", new DateTime(2021, 10, 22, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 10, new DateTime(2004, 3, 6, 23, 0, 0, 0, DateTimeKind.Utc), "Kate Jagger@hotmail.com", "Kate Jagger", "99142990", new DateTime(2004, 3, 6, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 11, new DateTime(2007, 4, 2, 22, 0, 0, 0, DateTimeKind.Utc), "Audrey Trump@outlook.com", "Audrey Trump", "45845845", new DateTime(2007, 4, 2, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 12, new DateTime(2014, 8, 10, 22, 0, 0, 0, DateTimeKind.Utc), "Barack Windsor@gmail.com", "Barack Windsor", "59452889", new DateTime(2014, 8, 10, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 13, new DateTime(2002, 2, 8, 23, 0, 0, 0, DateTimeKind.Utc), "Donald Hepburn@hotmail.com", "Donald Hepburn", "90120086", new DateTime(2002, 2, 8, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 14, new DateTime(2015, 8, 26, 22, 0, 0, 0, DateTimeKind.Utc), "Kate Middleton@hotmail.com", "Kate Middleton", "87363691", new DateTime(2015, 8, 26, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 15, new DateTime(2019, 5, 21, 22, 0, 0, 0, DateTimeKind.Utc), "Mick Middleton@yahoo.com", "Mick Middleton", "74615988", new DateTime(2019, 5, 21, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 16, new DateTime(2021, 3, 14, 23, 0, 0, 0, DateTimeKind.Utc), "Barack Hendrix@msn.com", "Barack Hendrix", "32871995", new DateTime(2021, 3, 14, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 17, new DateTime(2012, 10, 2, 22, 0, 0, 0, DateTimeKind.Utc), "Jimi Winfrey@yahoo.com", "Jimi Winfrey", "30012285", new DateTime(2012, 10, 2, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 18, new DateTime(2017, 5, 5, 22, 0, 0, 0, DateTimeKind.Utc), "Donald Obama@outlook.com", "Donald Obama", "75351887", new DateTime(2017, 5, 5, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 19, new DateTime(2013, 7, 7, 22, 0, 0, 0, DateTimeKind.Utc), "Charles Hepburn@msn.com", "Charles Hepburn", "83885458", new DateTime(2013, 7, 7, 22, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "movie_id", "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 15, 22, 0, 0, 0, DateTimeKind.Utc), "", "", 159, "An army of Orange Planets", new DateTime(2020, 5, 15, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, new DateTime(2014, 5, 6, 22, 0, 0, 0, DateTimeKind.Utc), "", "", 172, "The Bitter Cars", new DateTime(2014, 5, 6, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, new DateTime(2019, 2, 8, 23, 0, 0, 0, DateTimeKind.Utc), "", "", 114, "Two Purple Flowers", new DateTime(2019, 2, 8, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, new DateTime(2003, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), "", "", 239, "The Green Cars", new DateTime(2003, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, new DateTime(2002, 10, 7, 22, 0, 0, 0, DateTimeKind.Utc), "", "", 238, "A bunch of Microscopic Leopards", new DateTime(2002, 10, 7, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, new DateTime(2008, 2, 12, 23, 0, 0, 0, DateTimeKind.Utc), "", "", 124, "Fifteen Bitter Flowers", new DateTime(2008, 2, 12, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, new DateTime(2013, 7, 15, 22, 0, 0, 0, DateTimeKind.Utc), "", "", 234, "Two Purple Leopards", new DateTime(2013, 7, 15, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, new DateTime(2002, 1, 16, 23, 0, 0, 0, DateTimeKind.Utc), "", "", 148, "A bunch of Purple Houses", new DateTime(2002, 1, 16, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 9, new DateTime(2005, 10, 7, 22, 0, 0, 0, DateTimeKind.Utc), "", "", 117, "A bunch of Purple Flowers", new DateTime(2005, 10, 7, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 10, new DateTime(2021, 5, 8, 22, 0, 0, 0, DateTimeKind.Utc), "", "", 190, "A herd of Transparent Cars", new DateTime(2021, 5, 8, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 11, new DateTime(2017, 7, 4, 22, 0, 0, 0, DateTimeKind.Utc), "", "", 123, "A herd of Purple Leopards", new DateTime(2017, 7, 4, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 12, new DateTime(2007, 2, 14, 23, 0, 0, 0, DateTimeKind.Utc), "", "", 173, "Several Bitter Buildings", new DateTime(2007, 2, 14, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 13, new DateTime(2014, 8, 7, 22, 0, 0, 0, DateTimeKind.Utc), "", "", 151, "Fifteen Microscopic Planets", new DateTime(2014, 8, 7, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 14, new DateTime(2011, 6, 16, 22, 0, 0, 0, DateTimeKind.Utc), "", "", 60, "An army of Transparent Leopards", new DateTime(2011, 6, 16, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 15, new DateTime(2008, 8, 19, 22, 0, 0, 0, DateTimeKind.Utc), "", "", 70, "An army of Purple Leopards", new DateTime(2008, 8, 19, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 16, new DateTime(2007, 4, 5, 22, 0, 0, 0, DateTimeKind.Utc), "", "", 198, "Two Large Buildings", new DateTime(2007, 4, 5, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 17, new DateTime(2006, 5, 7, 22, 0, 0, 0, DateTimeKind.Utc), "", "", 117, "Several Transparent Flowers", new DateTime(2006, 5, 7, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 18, new DateTime(2021, 3, 24, 23, 0, 0, 0, DateTimeKind.Utc), "", "", 162, "Fifteen Orange Planets", new DateTime(2021, 3, 24, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 19, new DateTime(2021, 8, 18, 22, 0, 0, 0, DateTimeKind.Utc), "", "", 127, "The Large Planets", new DateTime(2021, 8, 18, 22, 0, 0, 0, DateTimeKind.Utc) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 19);

            migrationBuilder.DropColumn(
                name: "rating",
                table: "Movies");
        }
    }
}
