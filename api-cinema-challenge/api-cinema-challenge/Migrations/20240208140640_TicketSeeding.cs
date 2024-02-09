using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class TicketSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 1,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2016, 9, 10, 22, 0, 0, 0, DateTimeKind.Utc), "Jimi Winslet@outlook.com", "Jimi Winslet", "92608184", new DateTime(2016, 9, 10, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 2,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2003, 2, 9, 23, 0, 0, 0, DateTimeKind.Utc), "Barack Obama@asl.com", "Barack Obama", "75962934", new DateTime(2003, 2, 9, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 3,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2021, 4, 12, 22, 0, 0, 0, DateTimeKind.Utc), "Jimi Winfrey@outlook.com", "Jimi Winfrey", "48766899", new DateTime(2021, 4, 12, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 4,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2020, 10, 5, 22, 0, 0, 0, DateTimeKind.Utc), "Mick Obama@outlook.com", "Mick Obama", "62589317", new DateTime(2020, 10, 5, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 5,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2016, 9, 12, 22, 0, 0, 0, DateTimeKind.Utc), "Elvis Middleton@msn.com", "Elvis Middleton", "23409554", new DateTime(2016, 9, 12, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 6,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2012, 11, 9, 23, 0, 0, 0, DateTimeKind.Utc), "Charles Presley@msn.com", "Charles Presley", "85379417", new DateTime(2012, 11, 9, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 7,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2020, 7, 6, 22, 0, 0, 0, DateTimeKind.Utc), "Oprah Winslet@gmail.com", "Oprah Winslet", "18048221", new DateTime(2020, 7, 6, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 8,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 17, 22, 0, 0, 0, DateTimeKind.Utc), "Elvis Trump@hotmail.com", "Elvis Trump", "95755317", new DateTime(2023, 7, 17, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 9,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2005, 7, 10, 22, 0, 0, 0, DateTimeKind.Utc), "Elvis Windsor@gmail.com", "Elvis Windsor", "34593056", new DateTime(2005, 7, 10, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 10,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2018, 11, 15, 23, 0, 0, 0, DateTimeKind.Utc), "Audrey Windsor@msn.com", "Audrey Windsor", "55121647", new DateTime(2018, 11, 15, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 11,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2010, 10, 25, 22, 0, 0, 0, DateTimeKind.Utc), "Charles Winslet@yahoo.com", "Charles Winslet", "58673911", new DateTime(2010, 10, 25, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 12,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2018, 1, 25, 23, 0, 0, 0, DateTimeKind.Utc), "Jimi Middleton@outlook.com", "Jimi Middleton", "60476092", new DateTime(2018, 1, 25, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 13,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2021, 7, 26, 22, 0, 0, 0, DateTimeKind.Utc), "Kate Winslet@gmail.com", "Kate Winslet", "37456154", new DateTime(2021, 7, 26, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 14,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2000, 10, 17, 22, 0, 0, 0, DateTimeKind.Utc), "Jimi Hepburn@yahoo.com", "Jimi Hepburn", "54177614", new DateTime(2000, 10, 17, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 15,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2021, 9, 24, 22, 0, 0, 0, DateTimeKind.Utc), "Oprah Hendrix@yahoo.com", "Oprah Hendrix", "68586001", new DateTime(2021, 9, 24, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 16,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2010, 8, 6, 22, 0, 0, 0, DateTimeKind.Utc), "Donald Jagger@yahoo.com", "Donald Jagger", "92225976", new DateTime(2010, 8, 6, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 17,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2022, 11, 26, 23, 0, 0, 0, DateTimeKind.Utc), "Donald Trump@gmail.com", "Donald Trump", "36737951", new DateTime(2022, 11, 26, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 18,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2005, 10, 8, 22, 0, 0, 0, DateTimeKind.Utc), "Barack Jagger@asl.com", "Barack Jagger", "78634060", new DateTime(2005, 10, 8, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 19,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2017, 7, 26, 22, 0, 0, 0, DateTimeKind.Utc), "Kate Obama@msn.com", "Kate Obama", "43737730", new DateTime(2017, 7, 26, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 1,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2016, 1, 20, 23, 0, 0, 0, DateTimeKind.Utc), "Dwarf Sci-Fi", 183, "A bunch of Orange Leopards", new DateTime(2016, 1, 20, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 2,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2001, 9, 15, 22, 0, 0, 0, DateTimeKind.Utc), "Romance Sci-Fi", "G – General Audiences", 81, "A herd of Large Planets", new DateTime(2001, 9, 15, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 3,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2000, 7, 31, 22, 0, 0, 0, DateTimeKind.Utc), "Pirate Cyberpunk", "NC-17 – Adults Only", 122, "Fifteen Purple Flowers", new DateTime(2000, 7, 31, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 4,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2005, 7, 6, 22, 0, 0, 0, DateTimeKind.Utc), "Fantasy Fantasy", 166, "A herd of Microscopic Flowers", new DateTime(2005, 7, 6, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 5,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2018, 2, 19, 23, 0, 0, 0, DateTimeKind.Utc), "Romance Western", "NC-17 – Adults Only", 85, "A herd of Orange Planets", new DateTime(2018, 2, 19, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 6,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2021, 2, 16, 23, 0, 0, 0, DateTimeKind.Utc), "Adventure Comedy", "PG – Parental Guidance Suggested", 155, "A herd of Green Leopards", new DateTime(2021, 2, 16, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 7,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2009, 5, 1, 22, 0, 0, 0, DateTimeKind.Utc), "Sci-Fi Dwarf", 129, "The Green Cars", new DateTime(2009, 5, 1, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 8,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2007, 4, 17, 22, 0, 0, 0, DateTimeKind.Utc), "Cyberpunk Adventure", "R – Restricted", 235, "Two Large Houses", new DateTime(2007, 4, 17, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 9,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2000, 8, 12, 22, 0, 0, 0, DateTimeKind.Utc), "Adventure Fantasy", "NC-17 – Adults Only", 186, "The Purple Leopards", new DateTime(2000, 8, 12, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 10,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2013, 4, 10, 22, 0, 0, 0, DateTimeKind.Utc), "Space Romance", 168, "Fifteen Bitter Flowers", new DateTime(2013, 4, 10, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 11,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2012, 11, 7, 23, 0, 0, 0, DateTimeKind.Utc), "Space Historic", "PG – Parental Guidance Suggested", 90, "Two Orange Houses", new DateTime(2012, 11, 7, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 12,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 0, 0, 0, DateTimeKind.Utc), "Space Adventure", 64, "An army of Large Cars", new DateTime(2022, 4, 8, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 13,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2017, 11, 4, 23, 0, 0, 0, DateTimeKind.Utc), "Adventure Sci-Fi", "G – General Audiences", 73, "Several Microscopic Flowers", new DateTime(2017, 11, 4, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 14,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2005, 9, 14, 22, 0, 0, 0, DateTimeKind.Utc), "Space Dwarf", "PG – Parental Guidance Suggested", 68, "A herd of Orange Buildings", new DateTime(2005, 9, 14, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 15,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2012, 10, 2, 22, 0, 0, 0, DateTimeKind.Utc), "Western Fantasy", "PG – Parental Guidance Suggested", 181, "Fifteen Rose Smelling Planets", new DateTime(2012, 10, 2, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 16,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2007, 5, 23, 22, 0, 0, 0, DateTimeKind.Utc), "Historic Space", "R – Restricted", 188, "The Orange Houses", new DateTime(2007, 5, 23, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 17,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2020, 8, 19, 22, 0, 0, 0, DateTimeKind.Utc), "Cyberpunk Romance", "R – Restricted", 205, "A bunch of Rose Smelling Flowers", new DateTime(2020, 8, 19, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 18,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2000, 3, 25, 23, 0, 0, 0, DateTimeKind.Utc), "Sci-Fi Sci-Fi", 155, "The Purple Houses", new DateTime(2000, 3, 25, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 19,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2020, 1, 5, 23, 0, 0, 0, DateTimeKind.Utc), "Adventure Comedy", 202, "An army of Rose Smelling Planets", new DateTime(2020, 1, 5, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 1,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 40, new DateTime(2019, 5, 16, 22, 0, 0, 0, DateTimeKind.Utc), 6, 4, new DateTime(2019, 5, 16, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2019, 5, 16, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 2,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 30, new DateTime(2007, 3, 14, 23, 0, 0, 0, DateTimeKind.Utc), 17, 3, new DateTime(2007, 3, 14, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2007, 3, 14, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 3,
                columns: new[] { "created_at", "movie_id", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2019, 6, 15, 22, 0, 0, 0, DateTimeKind.Utc), 7, new DateTime(2019, 6, 15, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2019, 6, 15, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 4,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 10, new DateTime(2004, 1, 2, 23, 0, 0, 0, DateTimeKind.Utc), 12, 1, new DateTime(2004, 1, 2, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2004, 1, 2, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 5,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 50, new DateTime(2005, 4, 13, 22, 0, 0, 0, DateTimeKind.Utc), 2, 5, new DateTime(2005, 4, 13, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2005, 4, 13, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 6,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 30, new DateTime(2014, 10, 26, 23, 0, 0, 0, DateTimeKind.Utc), 15, 3, new DateTime(2014, 10, 26, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2014, 10, 26, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 7,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 10, new DateTime(2023, 5, 25, 22, 0, 0, 0, DateTimeKind.Utc), 19, 1, new DateTime(2023, 5, 25, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 5, 25, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 8,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 30, new DateTime(2000, 4, 21, 22, 0, 0, 0, DateTimeKind.Utc), 3, 3, new DateTime(2000, 4, 21, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2000, 4, 21, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 9,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 10, new DateTime(2002, 10, 14, 22, 0, 0, 0, DateTimeKind.Utc), 19, 1, new DateTime(2002, 10, 14, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2002, 10, 14, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 10,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 10, new DateTime(2002, 10, 11, 22, 0, 0, 0, DateTimeKind.Utc), 2, 1, new DateTime(2002, 10, 11, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2002, 10, 11, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 11,
                columns: new[] { "created_at", "movie_id", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2012, 6, 25, 22, 0, 0, 0, DateTimeKind.Utc), 15, new DateTime(2012, 6, 25, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2012, 6, 25, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 12,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 10, new DateTime(2022, 9, 12, 22, 0, 0, 0, DateTimeKind.Utc), 2, 1, new DateTime(2022, 9, 12, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 9, 12, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 13,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 10, new DateTime(2014, 3, 31, 22, 0, 0, 0, DateTimeKind.Utc), 9, 1, new DateTime(2014, 3, 31, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2014, 3, 31, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 14,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 20, new DateTime(2015, 4, 16, 22, 0, 0, 0, DateTimeKind.Utc), 18, 2, new DateTime(2015, 4, 16, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2015, 4, 16, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 15,
                columns: new[] { "capacity", "created_at", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 40, new DateTime(2000, 2, 26, 23, 0, 0, 0, DateTimeKind.Utc), 4, new DateTime(2000, 2, 26, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2000, 2, 26, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 16,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 30, new DateTime(2011, 4, 15, 22, 0, 0, 0, DateTimeKind.Utc), 17, 3, new DateTime(2011, 4, 15, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2011, 4, 15, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 17,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 10, new DateTime(2022, 1, 23, 23, 0, 0, 0, DateTimeKind.Utc), 6, 1, new DateTime(2022, 1, 23, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 1, 23, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 18,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 10, new DateTime(2008, 3, 14, 23, 0, 0, 0, DateTimeKind.Utc), 7, 1, new DateTime(2008, 3, 14, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2008, 3, 14, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 19,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 30, new DateTime(2007, 4, 12, 22, 0, 0, 0, DateTimeKind.Utc), 1, 3, new DateTime(2007, 4, 12, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2007, 4, 12, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "ticket_id", "created_at", "customer_id", "num_seats", "screening_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2008, 9, 8, 22, 0, 0, 0, DateTimeKind.Utc), 2, 1, 10, new DateTime(2008, 9, 8, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, new DateTime(2017, 11, 20, 23, 0, 0, 0, DateTimeKind.Utc), 11, 1, 11, new DateTime(2017, 11, 20, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, new DateTime(2006, 5, 25, 22, 0, 0, 0, DateTimeKind.Utc), 18, 4, 7, new DateTime(2006, 5, 25, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, new DateTime(2009, 8, 2, 22, 0, 0, 0, DateTimeKind.Utc), 12, 4, 2, new DateTime(2009, 8, 2, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, new DateTime(2004, 10, 24, 22, 0, 0, 0, DateTimeKind.Utc), 19, 3, 4, new DateTime(2004, 10, 24, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, new DateTime(2012, 6, 24, 22, 0, 0, 0, DateTimeKind.Utc), 18, 2, 3, new DateTime(2012, 6, 24, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, new DateTime(2022, 10, 24, 22, 0, 0, 0, DateTimeKind.Utc), 5, 3, 16, new DateTime(2022, 10, 24, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, new DateTime(2008, 6, 13, 22, 0, 0, 0, DateTimeKind.Utc), 12, 3, 6, new DateTime(2008, 6, 13, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 9, new DateTime(2022, 9, 13, 22, 0, 0, 0, DateTimeKind.Utc), 19, 5, 3, new DateTime(2022, 9, 13, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 10, new DateTime(2009, 5, 1, 22, 0, 0, 0, DateTimeKind.Utc), 19, 3, 3, new DateTime(2009, 5, 1, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 11, new DateTime(2015, 11, 17, 23, 0, 0, 0, DateTimeKind.Utc), 15, 5, 19, new DateTime(2015, 11, 17, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 12, new DateTime(2002, 10, 21, 22, 0, 0, 0, DateTimeKind.Utc), 2, 2, 11, new DateTime(2002, 10, 21, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 13, new DateTime(2008, 10, 22, 22, 0, 0, 0, DateTimeKind.Utc), 2, 1, 11, new DateTime(2008, 10, 22, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 14, new DateTime(2017, 3, 14, 23, 0, 0, 0, DateTimeKind.Utc), 8, 2, 7, new DateTime(2017, 3, 14, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 15, new DateTime(2018, 7, 7, 22, 0, 0, 0, DateTimeKind.Utc), 18, 4, 5, new DateTime(2018, 7, 7, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 16, new DateTime(2023, 3, 6, 23, 0, 0, 0, DateTimeKind.Utc), 3, 4, 11, new DateTime(2023, 3, 6, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 17, new DateTime(2015, 9, 21, 22, 0, 0, 0, DateTimeKind.Utc), 15, 5, 16, new DateTime(2015, 9, 21, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 18, new DateTime(2017, 10, 14, 22, 0, 0, 0, DateTimeKind.Utc), 15, 4, 11, new DateTime(2017, 10, 14, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 19, new DateTime(2001, 3, 9, 23, 0, 0, 0, DateTimeKind.Utc), 2, 3, 5, new DateTime(2001, 3, 9, 23, 0, 0, 0, DateTimeKind.Utc) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ticket_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ticket_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ticket_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ticket_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ticket_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ticket_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ticket_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ticket_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ticket_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ticket_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ticket_id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ticket_id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ticket_id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ticket_id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ticket_id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ticket_id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ticket_id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ticket_id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ticket_id",
                keyValue: 19);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 1,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2004, 1, 14, 23, 0, 0, 0, DateTimeKind.Utc), "Donald Obama@yahoo.com", "Donald Obama", "78140934", new DateTime(2004, 1, 14, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 2,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2020, 8, 17, 22, 0, 0, 0, DateTimeKind.Utc), "Mick Windsor@outlook.com", "Mick Windsor", "77108007", new DateTime(2020, 8, 17, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 3,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2022, 9, 8, 22, 0, 0, 0, DateTimeKind.Utc), "Barack Middleton@outlook.com", "Barack Middleton", "44325461", new DateTime(2022, 9, 8, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 4,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2021, 6, 22, 22, 0, 0, 0, DateTimeKind.Utc), "Mick Winfrey@yahoo.com", "Mick Winfrey", "89199963", new DateTime(2021, 6, 22, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 5,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2005, 8, 19, 22, 0, 0, 0, DateTimeKind.Utc), "Elvis Winfrey@hotmail.com", "Elvis Winfrey", "23698703", new DateTime(2005, 8, 19, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 6,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2017, 2, 6, 23, 0, 0, 0, DateTimeKind.Utc), "Kate Middleton@yahoo.com", "Kate Middleton", "76381647", new DateTime(2017, 2, 6, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 7,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2001, 6, 4, 22, 0, 0, 0, DateTimeKind.Utc), "Oprah Jagger@hotmail.com", "Oprah Jagger", "76134587", new DateTime(2001, 6, 4, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 8,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2017, 4, 5, 22, 0, 0, 0, DateTimeKind.Utc), "Donald Hendrix@asl.com", "Donald Hendrix", "36815159", new DateTime(2017, 4, 5, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 9,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2016, 7, 18, 22, 0, 0, 0, DateTimeKind.Utc), "Donald Obama@hotmail.com", "Donald Obama", "44663568", new DateTime(2016, 7, 18, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 10,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2011, 8, 6, 22, 0, 0, 0, DateTimeKind.Utc), "Elvis Jagger@asl.com", "Elvis Jagger", "34572850", new DateTime(2011, 8, 6, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 11,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2018, 7, 24, 22, 0, 0, 0, DateTimeKind.Utc), "Charles Hendrix@asl.com", "Charles Hendrix", "49637891", new DateTime(2018, 7, 24, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 12,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 0, 0, 0, DateTimeKind.Utc), "Kate Winslet@gmail.com", "Kate Winslet", "55029807", new DateTime(2020, 9, 7, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 13,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2018, 8, 31, 22, 0, 0, 0, DateTimeKind.Utc), "Elvis Winfrey@asl.com", "Elvis Winfrey", "90178260", new DateTime(2018, 8, 31, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 14,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2019, 1, 23, 23, 0, 0, 0, DateTimeKind.Utc), "Kate Winfrey@hotmail.com", "Kate Winfrey", "11834504", new DateTime(2019, 1, 23, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 15,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2002, 6, 7, 22, 0, 0, 0, DateTimeKind.Utc), "Kate Obama@asl.com", "Kate Obama", "91524447", new DateTime(2002, 6, 7, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 16,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2008, 11, 22, 23, 0, 0, 0, DateTimeKind.Utc), "Charles Winfrey@asl.com", "Charles Winfrey", "73869839", new DateTime(2008, 11, 22, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 17,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2009, 8, 31, 22, 0, 0, 0, DateTimeKind.Utc), "Jimi Presley@outlook.com", "Jimi Presley", "21788825", new DateTime(2009, 8, 31, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 18,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2014, 4, 30, 22, 0, 0, 0, DateTimeKind.Utc), "Elvis Middleton@outlook.com", "Elvis Middleton", "15368048", new DateTime(2014, 4, 30, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 19,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2006, 2, 13, 23, 0, 0, 0, DateTimeKind.Utc), "Barack Middleton@asl.com", "Barack Middleton", "44187057", new DateTime(2006, 2, 13, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 1,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2015, 11, 11, 23, 0, 0, 0, DateTimeKind.Utc), "Comedy Western", 176, "A herd of Microscopic Planets", new DateTime(2015, 11, 11, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 2,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2009, 10, 3, 22, 0, 0, 0, DateTimeKind.Utc), "Fantasy Historic", "PPG-13 – Parents Strongly Cautioned", 71, "A bunch of Green Buildings", new DateTime(2009, 10, 3, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 3,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2014, 6, 21, 22, 0, 0, 0, DateTimeKind.Utc), "Sci-Fi Western", "R – Restricted", 224, "A bunch of Large Buildings", new DateTime(2014, 6, 21, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 4,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2008, 5, 17, 22, 0, 0, 0, DateTimeKind.Utc), "Sci-Fi Sci-Fi", 177, "A herd of Purple Flowers", new DateTime(2008, 5, 17, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 5,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2012, 9, 12, 22, 0, 0, 0, DateTimeKind.Utc), "Historic Space", "R – Restricted", 71, "Several Purple Buildings", new DateTime(2012, 9, 12, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 6,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2010, 10, 24, 22, 0, 0, 0, DateTimeKind.Utc), "Fantasy Fantasy", "R – Restricted", 70, "Two Transparent Leopards", new DateTime(2010, 10, 24, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 7,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2010, 11, 4, 23, 0, 0, 0, DateTimeKind.Utc), "Sci-Fi Sci-Fi", 155, "A herd of Microscopic Planets", new DateTime(2010, 11, 4, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 8,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2021, 4, 23, 22, 0, 0, 0, DateTimeKind.Utc), "Cyberpunk Sci-Fi", "G – General Audiences", 115, "A herd of Orange Planets", new DateTime(2021, 4, 23, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 9,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2000, 1, 25, 23, 0, 0, 0, DateTimeKind.Utc), "Comedy Pirate", "G – General Audiences", 226, "An army of Transparent Houses", new DateTime(2000, 1, 25, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 10,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2018, 1, 25, 23, 0, 0, 0, DateTimeKind.Utc), "Romance Sci-Fi", 145, "A herd of Orange Cars", new DateTime(2018, 1, 25, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 11,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2022, 10, 26, 22, 0, 0, 0, DateTimeKind.Utc), "Comedy Romance", "R – Restricted", 93, "Two Large Buildings", new DateTime(2022, 10, 26, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 12,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2006, 10, 2, 22, 0, 0, 0, DateTimeKind.Utc), "Dwarf Cyberpunk", 65, "An army of Orange Cars", new DateTime(2006, 10, 2, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 13,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 0, 0, 0, DateTimeKind.Utc), "Space Space", "PG – Parental Guidance Suggested", 127, "A herd of Green Flowers", new DateTime(2023, 8, 31, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 14,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 0, 0, 0, DateTimeKind.Utc), "Romance Historic", "G – General Audiences", 121, "Several Transparent Flowers", new DateTime(2023, 7, 16, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 15,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2018, 8, 15, 22, 0, 0, 0, DateTimeKind.Utc), "Space Comedy", "PPG-13 – Parents Strongly Cautioned", 206, "An army of Orange Planets", new DateTime(2018, 8, 15, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 16,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2003, 2, 6, 23, 0, 0, 0, DateTimeKind.Utc), "Adventure Sci-Fi", "PPG-13 – Parents Strongly Cautioned", 141, "The Rose Smelling Cars", new DateTime(2003, 2, 6, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 17,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2016, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "Adventure Western", "PG – Parental Guidance Suggested", 134, "Fifteen Purple Leopards", new DateTime(2016, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 18,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2011, 8, 5, 22, 0, 0, 0, DateTimeKind.Utc), "Fantasy Pirate", 141, "Several Rose Smelling Buildings", new DateTime(2011, 8, 5, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 19,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 0, 0, 0, DateTimeKind.Utc), "Comedy Pirate", 71, "The Orange Flowers", new DateTime(2023, 8, 22, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 1,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 50, new DateTime(2023, 2, 4, 23, 0, 0, 0, DateTimeKind.Utc), 9, 5, new DateTime(2023, 2, 4, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 2, 4, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 2,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 50, new DateTime(2005, 4, 9, 22, 0, 0, 0, DateTimeKind.Utc), 2, 5, new DateTime(2005, 4, 9, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2005, 4, 9, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 3,
                columns: new[] { "created_at", "movie_id", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2009, 10, 10, 22, 0, 0, 0, DateTimeKind.Utc), 19, new DateTime(2009, 10, 10, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2009, 10, 10, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 4,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 50, new DateTime(2009, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, 5, new DateTime(2009, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2009, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 5,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 10, new DateTime(2018, 11, 17, 23, 0, 0, 0, DateTimeKind.Utc), 5, 1, new DateTime(2018, 11, 17, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2018, 11, 17, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 6,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 10, new DateTime(2020, 2, 10, 23, 0, 0, 0, DateTimeKind.Utc), 13, 1, new DateTime(2020, 2, 10, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2020, 2, 10, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 7,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 20, new DateTime(2001, 10, 7, 22, 0, 0, 0, DateTimeKind.Utc), 6, 2, new DateTime(2001, 10, 7, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2001, 10, 7, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 8,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 40, new DateTime(2008, 8, 1, 22, 0, 0, 0, DateTimeKind.Utc), 11, 4, new DateTime(2008, 8, 1, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2008, 8, 1, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 9,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 50, new DateTime(2001, 6, 19, 22, 0, 0, 0, DateTimeKind.Utc), 5, 5, new DateTime(2001, 6, 19, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2001, 6, 19, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 10,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 20, new DateTime(2023, 3, 19, 23, 0, 0, 0, DateTimeKind.Utc), 1, 2, new DateTime(2023, 3, 19, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 3, 19, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 11,
                columns: new[] { "created_at", "movie_id", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2008, 1, 5, 23, 0, 0, 0, DateTimeKind.Utc), 11, new DateTime(2008, 1, 5, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2008, 1, 5, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 12,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 20, new DateTime(2001, 10, 2, 22, 0, 0, 0, DateTimeKind.Utc), 19, 2, new DateTime(2001, 10, 2, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2001, 10, 2, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 13,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 20, new DateTime(2006, 11, 26, 23, 0, 0, 0, DateTimeKind.Utc), 1, 2, new DateTime(2006, 11, 26, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2006, 11, 26, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 14,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 50, new DateTime(2003, 11, 8, 23, 0, 0, 0, DateTimeKind.Utc), 5, 5, new DateTime(2003, 11, 8, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2003, 11, 8, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 15,
                columns: new[] { "capacity", "created_at", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 30, new DateTime(2018, 7, 16, 22, 0, 0, 0, DateTimeKind.Utc), 3, new DateTime(2018, 7, 16, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2018, 7, 16, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 16,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 10, new DateTime(2002, 11, 26, 23, 0, 0, 0, DateTimeKind.Utc), 12, 1, new DateTime(2002, 11, 26, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2002, 11, 26, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 17,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 20, new DateTime(2006, 4, 6, 22, 0, 0, 0, DateTimeKind.Utc), 15, 2, new DateTime(2006, 4, 6, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2006, 4, 6, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 18,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 50, new DateTime(2005, 3, 13, 23, 0, 0, 0, DateTimeKind.Utc), 17, 5, new DateTime(2005, 3, 13, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2005, 3, 13, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 19,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 50, new DateTime(2012, 7, 22, 22, 0, 0, 0, DateTimeKind.Utc), 6, 5, new DateTime(2012, 7, 22, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2012, 7, 22, 22, 0, 0, 0, DateTimeKind.Utc) });
        }
    }
}
