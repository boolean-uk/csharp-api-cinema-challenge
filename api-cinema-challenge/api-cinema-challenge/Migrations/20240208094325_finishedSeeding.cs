using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class finishedSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 1,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2015, 7, 1, 22, 0, 0, 0, DateTimeKind.Utc), "Kate Trump@yahoo.com", "Kate Trump", "90430101", new DateTime(2015, 7, 1, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 2,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2022, 1, 7, 23, 0, 0, 0, DateTimeKind.Utc), "Donald Jagger@msn.com", "Donald Jagger", "34905742", new DateTime(2022, 1, 7, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 3,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2009, 1, 21, 23, 0, 0, 0, DateTimeKind.Utc), "Mick Winslet@outlook.com", "Mick Winslet", "22572129", new DateTime(2009, 1, 21, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 4,
                columns: new[] { "created_at", "email", "phone", "updated_at" },
                values: new object[] { new DateTime(2021, 11, 4, 23, 0, 0, 0, DateTimeKind.Utc), "Elvis Hepburn@msn.com", "60999338", new DateTime(2021, 11, 4, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 5,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2008, 5, 11, 22, 0, 0, 0, DateTimeKind.Utc), "Elvis Presley@yahoo.com", "Elvis Presley", "85949451", new DateTime(2008, 5, 11, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 6,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2012, 5, 19, 22, 0, 0, 0, DateTimeKind.Utc), "Kate Hepburn@asl.com", "Kate Hepburn", "31795515", new DateTime(2012, 5, 19, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 7,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2018, 8, 11, 22, 0, 0, 0, DateTimeKind.Utc), "Oprah Hepburn@gmail.com", "Oprah Hepburn", "16439854", new DateTime(2018, 8, 11, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 8,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2003, 3, 3, 23, 0, 0, 0, DateTimeKind.Utc), "Jimi Winslet@hotmail.com", "Jimi Winslet", "46904835", new DateTime(2003, 3, 3, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 9,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2018, 5, 31, 22, 0, 0, 0, DateTimeKind.Utc), "Mick Trump@msn.com", "Mick Trump", "85393579", new DateTime(2018, 5, 31, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 10,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2006, 7, 16, 22, 0, 0, 0, DateTimeKind.Utc), "Donald Winfrey@gmail.com", "Donald Winfrey", "18503967", new DateTime(2006, 7, 16, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 11,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2021, 8, 20, 22, 0, 0, 0, DateTimeKind.Utc), "Donald Winslet@gmail.com", "Donald Winslet", "96670993", new DateTime(2021, 8, 20, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 12,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2004, 10, 16, 22, 0, 0, 0, DateTimeKind.Utc), "Elvis Hepburn@msn.com", "Elvis Hepburn", "16969868", new DateTime(2004, 10, 16, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 13,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2016, 7, 20, 22, 0, 0, 0, DateTimeKind.Utc), "Elvis Trump@outlook.com", "Elvis Trump", "88686701", new DateTime(2016, 7, 20, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 14,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2008, 6, 30, 22, 0, 0, 0, DateTimeKind.Utc), "Kate Winslet@msn.com", "Kate Winslet", "64629183", new DateTime(2008, 6, 30, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 15,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2017, 6, 14, 22, 0, 0, 0, DateTimeKind.Utc), "Kate Windsor@gmail.com", "Kate Windsor", "83273098", new DateTime(2017, 6, 14, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 16,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2022, 3, 12, 23, 0, 0, 0, DateTimeKind.Utc), "Jimi Middleton@yahoo.com", "Jimi Middleton", "41334261", new DateTime(2022, 3, 12, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 17,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2002, 8, 16, 22, 0, 0, 0, DateTimeKind.Utc), "Donald Winslet@yahoo.com", "Donald Winslet", "63766949", new DateTime(2002, 8, 16, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 18,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2010, 4, 23, 22, 0, 0, 0, DateTimeKind.Utc), "Elvis Presley@yahoo.com", "Elvis Presley", "71758658", new DateTime(2010, 4, 23, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 19,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2023, 3, 2, 23, 0, 0, 0, DateTimeKind.Utc), "Audrey Jagger@hotmail.com", "Audrey Jagger", "26815908", new DateTime(2023, 3, 2, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 1,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2006, 4, 23, 22, 0, 0, 0, DateTimeKind.Utc), "Space Space", 205, "The Large Planets", new DateTime(2006, 4, 23, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 2,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2011, 4, 13, 22, 0, 0, 0, DateTimeKind.Utc), "Western Dwarf", "G – General Audiences", 138, "Several Transparent Flowers", new DateTime(2011, 4, 13, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 3,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2018, 4, 11, 22, 0, 0, 0, DateTimeKind.Utc), "Pirate Cyberpunk", 178, "Several Large Houses", new DateTime(2018, 4, 11, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 4,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2007, 7, 12, 22, 0, 0, 0, DateTimeKind.Utc), "Historic Romance", "PPG-13 – Parents Strongly Cautioned", 115, "A bunch of Large Houses", new DateTime(2007, 7, 12, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 5,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2006, 9, 6, 22, 0, 0, 0, DateTimeKind.Utc), "Sci-Fi Comedy", "NC-17 – Adults Only", 129, "An army of Bitter Cars", new DateTime(2006, 9, 6, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 6,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2009, 7, 11, 22, 0, 0, 0, DateTimeKind.Utc), "Adventure Comedy", "PPG-13 – Parents Strongly Cautioned", 228, "Fifteen Large Buildings", new DateTime(2009, 7, 11, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 7,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2007, 10, 19, 22, 0, 0, 0, DateTimeKind.Utc), "Space Pirate", 211, "A herd of Purple Planets", new DateTime(2007, 10, 19, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 8,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2002, 4, 1, 22, 0, 0, 0, DateTimeKind.Utc), "Historic Space", "G – General Audiences", 141, "An army of Bitter Houses", new DateTime(2002, 4, 1, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 9,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2019, 6, 25, 22, 0, 0, 0, DateTimeKind.Utc), "Cyberpunk Cyberpunk", "PG – Parental Guidance Suggested", 192, "A bunch of Rose Smelling Cars", new DateTime(2019, 6, 25, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 10,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2012, 9, 12, 22, 0, 0, 0, DateTimeKind.Utc), "Pirate Fantasy", "PG – Parental Guidance Suggested", 193, "An army of Orange Houses", new DateTime(2012, 9, 12, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 11,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2008, 1, 22, 23, 0, 0, 0, DateTimeKind.Utc), "Sci-Fi Comedy", "PG – Parental Guidance Suggested", 189, "A herd of Rose Smelling Flowers", new DateTime(2008, 1, 22, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 12,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2004, 8, 5, 22, 0, 0, 0, DateTimeKind.Utc), "Historic Sci-Fi", 183, "An army of Microscopic Houses", new DateTime(2004, 8, 5, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 13,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2008, 5, 31, 22, 0, 0, 0, DateTimeKind.Utc), "Romance Pirate", "PG – Parental Guidance Suggested", 235, "An army of Transparent Cars", new DateTime(2008, 5, 31, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 14,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2022, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "Fantasy Historic", "PPG-13 – Parents Strongly Cautioned", 80, "Fifteen Purple Leopards", new DateTime(2022, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 15,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2008, 8, 15, 22, 0, 0, 0, DateTimeKind.Utc), "Dwarf Historic", 110, "A bunch of Rose Smelling Planets", new DateTime(2008, 8, 15, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 16,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2021, 7, 31, 22, 0, 0, 0, DateTimeKind.Utc), "Sci-Fi Sci-Fi", "R – Restricted", 154, "A bunch of Purple Leopards", new DateTime(2021, 7, 31, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 17,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2020, 3, 6, 23, 0, 0, 0, DateTimeKind.Utc), "Adventure Dwarf", "PG – Parental Guidance Suggested", 82, "Fifteen Green Buildings", new DateTime(2020, 3, 6, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 18,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2009, 3, 15, 23, 0, 0, 0, DateTimeKind.Utc), "Adventure Adventure", "R – Restricted", 87, "Fifteen Transparent Flowers", new DateTime(2009, 3, 15, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 19,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2023, 2, 17, 23, 0, 0, 0, DateTimeKind.Utc), "Romance Comedy", "PPG-13 – Parents Strongly Cautioned", 176, "An army of Purple Leopards", new DateTime(2023, 2, 17, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "screening_id", "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 20, new DateTime(2002, 2, 18, 23, 0, 0, 0, DateTimeKind.Utc), 8, 2, new DateTime(2002, 2, 18, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2002, 2, 18, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, 30, new DateTime(2017, 11, 14, 23, 0, 0, 0, DateTimeKind.Utc), 14, 3, new DateTime(2017, 11, 14, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2017, 11, 14, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, 30, new DateTime(2022, 8, 23, 22, 0, 0, 0, DateTimeKind.Utc), 12, 3, new DateTime(2022, 8, 23, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 8, 23, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, 30, new DateTime(2018, 1, 10, 23, 0, 0, 0, DateTimeKind.Utc), 19, 3, new DateTime(2018, 1, 10, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2018, 1, 10, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, 20, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 19, 2, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, 40, new DateTime(2023, 11, 1, 23, 0, 0, 0, DateTimeKind.Utc), 3, 4, new DateTime(2023, 11, 1, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 11, 1, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, 20, new DateTime(2015, 5, 21, 22, 0, 0, 0, DateTimeKind.Utc), 5, 2, new DateTime(2015, 5, 21, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2015, 5, 21, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, 20, new DateTime(2016, 5, 22, 22, 0, 0, 0, DateTimeKind.Utc), 5, 2, new DateTime(2016, 5, 22, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2016, 5, 22, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 9, 20, new DateTime(2014, 1, 2, 23, 0, 0, 0, DateTimeKind.Utc), 9, 2, new DateTime(2014, 1, 2, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2014, 1, 2, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 10, 40, new DateTime(2014, 7, 12, 22, 0, 0, 0, DateTimeKind.Utc), 4, 4, new DateTime(2014, 7, 12, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2014, 7, 12, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 11, 30, new DateTime(2002, 9, 12, 22, 0, 0, 0, DateTimeKind.Utc), 17, 3, new DateTime(2002, 9, 12, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2002, 9, 12, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 12, 30, new DateTime(2009, 10, 22, 22, 0, 0, 0, DateTimeKind.Utc), 17, 3, new DateTime(2009, 10, 22, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2009, 10, 22, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 13, 30, new DateTime(2008, 9, 21, 22, 0, 0, 0, DateTimeKind.Utc), 10, 3, new DateTime(2008, 9, 21, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2008, 9, 21, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 14, 10, new DateTime(2001, 1, 8, 23, 0, 0, 0, DateTimeKind.Utc), 4, 1, new DateTime(2001, 1, 8, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2001, 1, 8, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 15, 50, new DateTime(2015, 2, 4, 23, 0, 0, 0, DateTimeKind.Utc), 18, 5, new DateTime(2015, 2, 4, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2015, 2, 4, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 16, 20, new DateTime(2007, 6, 14, 22, 0, 0, 0, DateTimeKind.Utc), 4, 2, new DateTime(2007, 6, 14, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2007, 6, 14, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 17, 40, new DateTime(2010, 10, 26, 22, 0, 0, 0, DateTimeKind.Utc), 1, 4, new DateTime(2010, 10, 26, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2010, 10, 26, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 18, 10, new DateTime(2020, 8, 5, 22, 0, 0, 0, DateTimeKind.Utc), 9, 1, new DateTime(2020, 8, 5, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2020, 8, 5, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 19, 10, new DateTime(2002, 11, 16, 23, 0, 0, 0, DateTimeKind.Utc), 18, 1, new DateTime(2002, 11, 16, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2002, 11, 16, 23, 0, 0, 0, DateTimeKind.Utc) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 19);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 1,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2017, 2, 8, 23, 0, 0, 0, DateTimeKind.Utc), "Jimi Hepburn@gmail.com", "Jimi Hepburn", "38817016", new DateTime(2017, 2, 8, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 2,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2005, 9, 19, 22, 0, 0, 0, DateTimeKind.Utc), "Kate Hepburn@gmail.com", "Kate Hepburn", "91269957", new DateTime(2005, 9, 19, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 3,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2013, 8, 5, 22, 0, 0, 0, DateTimeKind.Utc), "Donald Winfrey@asl.com", "Donald Winfrey", "76968515", new DateTime(2013, 8, 5, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 4,
                columns: new[] { "created_at", "email", "phone", "updated_at" },
                values: new object[] { new DateTime(2003, 3, 3, 23, 0, 0, 0, DateTimeKind.Utc), "Elvis Hepburn@outlook.com", "46765564", new DateTime(2003, 3, 3, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 5,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2001, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "Elvis Winslet@msn.com", "Elvis Winslet", "94747900", new DateTime(2001, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 6,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2021, 4, 24, 22, 0, 0, 0, DateTimeKind.Utc), "Oprah Hendrix@hotmail.com", "Oprah Hendrix", "87687560", new DateTime(2021, 4, 24, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 7,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2019, 3, 16, 23, 0, 0, 0, DateTimeKind.Utc), "Audrey Middleton@outlook.com", "Audrey Middleton", "82411835", new DateTime(2019, 3, 16, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 8,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2000, 6, 9, 22, 0, 0, 0, DateTimeKind.Utc), "Kate Trump@hotmail.com", "Kate Trump", "87879749", new DateTime(2000, 6, 9, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 9,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2006, 5, 6, 22, 0, 0, 0, DateTimeKind.Utc), "Jimi Windsor@outlook.com", "Jimi Windsor", "89402772", new DateTime(2006, 5, 6, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 10,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2022, 8, 19, 22, 0, 0, 0, DateTimeKind.Utc), "Donald Presley@gmail.com", "Donald Presley", "22961001", new DateTime(2022, 8, 19, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 11,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2015, 7, 22, 22, 0, 0, 0, DateTimeKind.Utc), "Audrey Winfrey@msn.com", "Audrey Winfrey", "85338748", new DateTime(2015, 7, 22, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 12,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2008, 7, 9, 22, 0, 0, 0, DateTimeKind.Utc), "Oprah Hepburn@msn.com", "Oprah Hepburn", "77616214", new DateTime(2008, 7, 9, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 13,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2001, 8, 3, 22, 0, 0, 0, DateTimeKind.Utc), "Kate Winslet@gmail.com", "Kate Winslet", "79655669", new DateTime(2001, 8, 3, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 14,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2008, 6, 7, 22, 0, 0, 0, DateTimeKind.Utc), "Donald Presley@asl.com", "Donald Presley", "35488557", new DateTime(2008, 6, 7, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 15,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2008, 9, 26, 22, 0, 0, 0, DateTimeKind.Utc), "Mick Obama@asl.com", "Mick Obama", "45191971", new DateTime(2008, 9, 26, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 16,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2012, 1, 5, 23, 0, 0, 0, DateTimeKind.Utc), "Barack Presley@hotmail.com", "Barack Presley", "75086901", new DateTime(2012, 1, 5, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 17,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2010, 2, 5, 23, 0, 0, 0, DateTimeKind.Utc), "Jimi Winslet@gmail.com", "Jimi Winslet", "50770370", new DateTime(2010, 2, 5, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 18,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2020, 2, 10, 23, 0, 0, 0, DateTimeKind.Utc), "Jimi Windsor@msn.com", "Jimi Windsor", "30368411", new DateTime(2020, 2, 10, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 19,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2008, 1, 8, 23, 0, 0, 0, DateTimeKind.Utc), "Elvis Hepburn@gmail.com", "Elvis Hepburn", "94779233", new DateTime(2008, 1, 8, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 1,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2012, 1, 1, 23, 0, 0, 0, DateTimeKind.Utc), "Sci-Fi Sci-Fi", 195, "A herd of Transparent Houses", new DateTime(2012, 1, 1, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 2,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2010, 5, 4, 22, 0, 0, 0, DateTimeKind.Utc), "Sci-Fi Dwarf", "PPG-13 – Parents Strongly Cautioned", 77, "A herd of Microscopic Houses", new DateTime(2010, 5, 4, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 3,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2016, 5, 10, 22, 0, 0, 0, DateTimeKind.Utc), "Romance Sci-Fi", 201, "A herd of Purple Planets", new DateTime(2016, 5, 10, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 4,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2017, 8, 1, 22, 0, 0, 0, DateTimeKind.Utc), "Comedy Dwarf", "NC-17 – Adults Only", 168, "A herd of Large Flowers", new DateTime(2017, 8, 1, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 5,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2021, 5, 20, 22, 0, 0, 0, DateTimeKind.Utc), "Comedy Space", "PPG-13 – Parents Strongly Cautioned", 201, "Fifteen Large Houses", new DateTime(2021, 5, 20, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 6,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 0, 0, 0, DateTimeKind.Utc), "Space Western", "G – General Audiences", 75, "An army of Green Leopards", new DateTime(2021, 6, 4, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 7,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2006, 5, 20, 22, 0, 0, 0, DateTimeKind.Utc), "Western Space", 132, "Two Bitter Buildings", new DateTime(2006, 5, 20, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 8,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2010, 2, 3, 23, 0, 0, 0, DateTimeKind.Utc), "Fantasy Pirate", "R – Restricted", 235, "A bunch of Green Buildings", new DateTime(2010, 2, 3, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 9,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2000, 8, 18, 22, 0, 0, 0, DateTimeKind.Utc), "Dwarf Cyberpunk", "R – Restricted", 204, "Two Orange Leopards", new DateTime(2000, 8, 18, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 10,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2019, 2, 24, 23, 0, 0, 0, DateTimeKind.Utc), "Sci-Fi Cyberpunk", "PPG-13 – Parents Strongly Cautioned", 124, "An army of Orange Buildings", new DateTime(2019, 2, 24, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 11,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2011, 10, 12, 22, 0, 0, 0, DateTimeKind.Utc), "Cyberpunk Pirate", "R – Restricted", 146, "A bunch of Green Planets", new DateTime(2011, 10, 12, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 12,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2022, 8, 3, 22, 0, 0, 0, DateTimeKind.Utc), "Western Comedy", 121, "The Transparent Houses", new DateTime(2022, 8, 3, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 13,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2005, 6, 10, 22, 0, 0, 0, DateTimeKind.Utc), "Fantasy Dwarf", "NC-17 – Adults Only", 179, "Several Large Leopards", new DateTime(2005, 6, 10, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 14,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2021, 3, 13, 23, 0, 0, 0, DateTimeKind.Utc), "Dwarf Historic", "NC-17 – Adults Only", 199, "Two Purple Cars", new DateTime(2021, 3, 13, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 15,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2017, 9, 10, 22, 0, 0, 0, DateTimeKind.Utc), "Dwarf Space", 195, "A bunch of Purple Buildings", new DateTime(2017, 9, 10, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 16,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2001, 11, 23, 23, 0, 0, 0, DateTimeKind.Utc), "Sci-Fi Western", "NC-17 – Adults Only", 118, "Several Green Cars", new DateTime(2001, 11, 23, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 17,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2008, 4, 7, 22, 0, 0, 0, DateTimeKind.Utc), "Cyberpunk Comedy", "PPG-13 – Parents Strongly Cautioned", 169, "The Green Houses", new DateTime(2008, 4, 7, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 18,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2008, 8, 8, 22, 0, 0, 0, DateTimeKind.Utc), "Adventure Space", "PPG-13 – Parents Strongly Cautioned", 221, "Fifteen Purple Cars", new DateTime(2008, 8, 8, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 19,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2009, 9, 4, 22, 0, 0, 0, DateTimeKind.Utc), "Historic Pirate", "R – Restricted", 168, "Two Purple Planets", new DateTime(2009, 9, 4, 22, 0, 0, 0, DateTimeKind.Utc) });
        }
    }
}
