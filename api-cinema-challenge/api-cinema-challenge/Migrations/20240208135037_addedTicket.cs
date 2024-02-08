using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class addedTicket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    ticket_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    num_seats = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.ticket_id);
                    table.ForeignKey(
                        name: "FK_Ticket_Customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "Customers",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_Screenings_screening_id",
                        column: x => x.screening_id,
                        principalTable: "Screenings",
                        principalColumn: "screening_id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2010, 11, 4, 23, 0, 0, 0, DateTimeKind.Utc), "Sci-Fi Sci-Fi", "NC-17 – Adults Only", 155, "A herd of Microscopic Planets", new DateTime(2010, 11, 4, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 8,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2021, 4, 23, 22, 0, 0, 0, DateTimeKind.Utc), "Cyberpunk Sci-Fi", 115, "A herd of Orange Planets", new DateTime(2021, 4, 23, 22, 0, 0, 0, DateTimeKind.Utc) });

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
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2018, 1, 25, 23, 0, 0, 0, DateTimeKind.Utc), "Romance Sci-Fi", "NC-17 – Adults Only", 145, "A herd of Orange Cars", new DateTime(2018, 1, 25, 23, 0, 0, 0, DateTimeKind.Utc) });

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
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2006, 10, 2, 22, 0, 0, 0, DateTimeKind.Utc), "Dwarf Cyberpunk", "G – General Audiences", 65, "An army of Orange Cars", new DateTime(2006, 10, 2, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 13,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 0, 0, 0, DateTimeKind.Utc), "Space Space", 127, "A herd of Green Flowers", new DateTime(2023, 8, 31, 22, 0, 0, 0, DateTimeKind.Utc) });

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
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2016, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "Adventure Western", 134, "Fifteen Purple Leopards", new DateTime(2016, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 18,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2011, 8, 5, 22, 0, 0, 0, DateTimeKind.Utc), "Fantasy Pirate", "PPG-13 – Parents Strongly Cautioned", 141, "Several Rose Smelling Buildings", new DateTime(2011, 8, 5, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 19,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 0, 0, 0, DateTimeKind.Utc), "Comedy Pirate", "G – General Audiences", 71, "The Orange Flowers", new DateTime(2023, 8, 22, 22, 0, 0, 0, DateTimeKind.Utc) });

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
                columns: new[] { "created_at", "movie_id", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2001, 10, 7, 22, 0, 0, 0, DateTimeKind.Utc), 6, new DateTime(2001, 10, 7, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2001, 10, 7, 22, 0, 0, 0, DateTimeKind.Utc) });

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
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 20, new DateTime(2008, 1, 5, 23, 0, 0, 0, DateTimeKind.Utc), 11, 2, new DateTime(2008, 1, 5, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2008, 1, 5, 23, 0, 0, 0, DateTimeKind.Utc) });

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
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 30, new DateTime(2018, 7, 16, 22, 0, 0, 0, DateTimeKind.Utc), 19, 3, new DateTime(2018, 7, 16, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2018, 7, 16, 22, 0, 0, 0, DateTimeKind.Utc) });

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

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_customer_id",
                table: "Ticket",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_screening_id",
                table: "Ticket",
                column: "screening_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

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
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2021, 11, 4, 23, 0, 0, 0, DateTimeKind.Utc), "Elvis Hepburn@msn.com", "Elvis Hepburn", "60999338", new DateTime(2021, 11, 4, 23, 0, 0, 0, DateTimeKind.Utc) });

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
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2018, 4, 11, 22, 0, 0, 0, DateTimeKind.Utc), "Pirate Cyberpunk", "PPG-13 – Parents Strongly Cautioned", 178, "Several Large Houses", new DateTime(2018, 4, 11, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 4,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2007, 7, 12, 22, 0, 0, 0, DateTimeKind.Utc), "Historic Romance", 115, "A bunch of Large Houses", new DateTime(2007, 7, 12, 22, 0, 0, 0, DateTimeKind.Utc) });

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
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2007, 10, 19, 22, 0, 0, 0, DateTimeKind.Utc), "Space Pirate", "PPG-13 – Parents Strongly Cautioned", 211, "A herd of Purple Planets", new DateTime(2007, 10, 19, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 8,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2002, 4, 1, 22, 0, 0, 0, DateTimeKind.Utc), "Historic Space", 141, "An army of Bitter Houses", new DateTime(2002, 4, 1, 22, 0, 0, 0, DateTimeKind.Utc) });

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
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2004, 8, 5, 22, 0, 0, 0, DateTimeKind.Utc), "Historic Sci-Fi", "PG – Parental Guidance Suggested", 183, "An army of Microscopic Houses", new DateTime(2004, 8, 5, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movie_id",
                keyValue: 13,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2008, 5, 31, 22, 0, 0, 0, DateTimeKind.Utc), "Romance Pirate", 235, "An army of Transparent Cars", new DateTime(2008, 5, 31, 22, 0, 0, 0, DateTimeKind.Utc) });

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
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2008, 8, 15, 22, 0, 0, 0, DateTimeKind.Utc), "Dwarf Historic", "G – General Audiences", 110, "A bunch of Rose Smelling Planets", new DateTime(2008, 8, 15, 22, 0, 0, 0, DateTimeKind.Utc) });

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
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2020, 3, 6, 23, 0, 0, 0, DateTimeKind.Utc), "Adventure Dwarf", 82, "Fifteen Green Buildings", new DateTime(2020, 3, 6, 23, 0, 0, 0, DateTimeKind.Utc) });

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

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 1,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 20, new DateTime(2002, 2, 18, 23, 0, 0, 0, DateTimeKind.Utc), 8, 2, new DateTime(2002, 2, 18, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2002, 2, 18, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 2,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 30, new DateTime(2017, 11, 14, 23, 0, 0, 0, DateTimeKind.Utc), 14, 3, new DateTime(2017, 11, 14, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2017, 11, 14, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 3,
                columns: new[] { "created_at", "movie_id", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2022, 8, 23, 22, 0, 0, 0, DateTimeKind.Utc), 12, new DateTime(2022, 8, 23, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 8, 23, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 4,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 30, new DateTime(2018, 1, 10, 23, 0, 0, 0, DateTimeKind.Utc), 19, 3, new DateTime(2018, 1, 10, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2018, 1, 10, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 5,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 20, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 19, 2, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 6,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 40, new DateTime(2023, 11, 1, 23, 0, 0, 0, DateTimeKind.Utc), 3, 4, new DateTime(2023, 11, 1, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 11, 1, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 7,
                columns: new[] { "created_at", "movie_id", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2015, 5, 21, 22, 0, 0, 0, DateTimeKind.Utc), 5, new DateTime(2015, 5, 21, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2015, 5, 21, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 8,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 20, new DateTime(2016, 5, 22, 22, 0, 0, 0, DateTimeKind.Utc), 5, 2, new DateTime(2016, 5, 22, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2016, 5, 22, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 9,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 20, new DateTime(2014, 1, 2, 23, 0, 0, 0, DateTimeKind.Utc), 9, 2, new DateTime(2014, 1, 2, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2014, 1, 2, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 10,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 40, new DateTime(2014, 7, 12, 22, 0, 0, 0, DateTimeKind.Utc), 4, 4, new DateTime(2014, 7, 12, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2014, 7, 12, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 11,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 30, new DateTime(2002, 9, 12, 22, 0, 0, 0, DateTimeKind.Utc), 17, 3, new DateTime(2002, 9, 12, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2002, 9, 12, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 12,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 30, new DateTime(2009, 10, 22, 22, 0, 0, 0, DateTimeKind.Utc), 17, 3, new DateTime(2009, 10, 22, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2009, 10, 22, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 13,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 30, new DateTime(2008, 9, 21, 22, 0, 0, 0, DateTimeKind.Utc), 10, 3, new DateTime(2008, 9, 21, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2008, 9, 21, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 14,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 10, new DateTime(2001, 1, 8, 23, 0, 0, 0, DateTimeKind.Utc), 4, 1, new DateTime(2001, 1, 8, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2001, 1, 8, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 15,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 50, new DateTime(2015, 2, 4, 23, 0, 0, 0, DateTimeKind.Utc), 18, 5, new DateTime(2015, 2, 4, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2015, 2, 4, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 16,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 20, new DateTime(2007, 6, 14, 22, 0, 0, 0, DateTimeKind.Utc), 4, 2, new DateTime(2007, 6, 14, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2007, 6, 14, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 17,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 40, new DateTime(2010, 10, 26, 22, 0, 0, 0, DateTimeKind.Utc), 1, 4, new DateTime(2010, 10, 26, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2010, 10, 26, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 18,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 10, new DateTime(2020, 8, 5, 22, 0, 0, 0, DateTimeKind.Utc), 9, 1, new DateTime(2020, 8, 5, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2020, 8, 5, 22, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "screening_id",
                keyValue: 19,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 10, new DateTime(2002, 11, 16, 23, 0, 0, 0, DateTimeKind.Utc), 18, 1, new DateTime(2002, 11, 16, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2002, 11, 16, 23, 0, 0, 0, DateTimeKind.Utc) });
        }
    }
}
