using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<int>(type: "integer", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.customer_id);
                });

            migrationBuilder.CreateTable(
                name: "movie",
                columns: table => new
                {
                    movie_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    runtime_mins = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movie", x => x.movie_id);
                });

            migrationBuilder.CreateTable(
                name: "screenings",
                columns: table => new
                {
                    screening_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    screen_number = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    movie_id = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => x.screening_id);
                    table.ForeignKey(
                        name: "FK_screenings_movie_movie_id",
                        column: x => x.movie_id,
                        principalTable: "movie",
                        principalColumn: "movie_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    ticket_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    numSeats = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.ticket_id);
                    table.ForeignKey(
                        name: "FK_tickets_Customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "Customers",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tickets_screenings_screening_id",
                        column: x => x.screening_id,
                        principalTable: "screenings",
                        principalColumn: "screening_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "customer_id", "CreatedAt", "email", "name", "phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(5796), "oprah winslet@nasa.org.us", "Oprah Winslet", "38597758", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(5997) },
                    { 2, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7059), "donald hendrix@nasa.org.us", "Donald Hendrix", "31294393", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7060) },
                    { 3, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7077), "oprah winfrey@gov.ru", "Oprah Winfrey", "12461023", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7077) },
                    { 4, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7079), "kate windsor@nasa.org.us", "Kate Windsor", "60877520", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7080) },
                    { 5, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7081), "kate trump@gov.gr", "Kate Trump", "28214601", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7082) },
                    { 6, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7087), "donald winslet@theworld.ca", "Donald Winslet", "99090594", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7087) },
                    { 7, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7089), "jimi winslet@google.com", "Jimi Winslet", "51342584", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7090) },
                    { 8, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7092), "kate presley@google.com", "Kate Presley", "24606771", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7093) },
                    { 9, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7094), "audrey winslet@tesla.com", "Audrey Winslet", "35122566", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7094) },
                    { 10, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7096), "barack jagger@bbc.co.uk", "Barack Jagger", "30581375", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7096) },
                    { 11, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7098), "jimi trump@gov.nl", "Jimi Trump", "29071711", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7098) },
                    { 12, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7107), "mick jagger@something.com", "Mick Jagger", "71722749", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7108) },
                    { 13, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7109), "barack middleton@gov.gr", "Barack Middleton", "28169066", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7109) },
                    { 14, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7111), "mick hepburn@gov.nl", "Mick Hepburn", "46074000", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7111) },
                    { 15, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7113), "barack winslet@tesla.com", "Barack Winslet", "66728315", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7113) },
                    { 16, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7114), "jimi middleton@theworld.ca", "Jimi Middleton", "29909156", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7114) },
                    { 17, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7115), "donald hepburn@gov.nl", "Donald Hepburn", "24603305", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7116) },
                    { 18, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7117), "kate jagger@google.com", "Kate Jagger", "90412194", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7118) },
                    { 19, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7119), "kate winfrey@gov.us", "Kate Winfrey", "58591549", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7119) },
                    { 20, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7120), "audrey windsor@gov.nl", "Audrey Windsor", "61422617", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7120) },
                    { 21, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7122), "charles jagger@google.com", "Charles Jagger", "39291620", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7122) },
                    { 22, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7123), "jimi obama@gov.us", "Jimi Obama", "41054703", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7123) },
                    { 23, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7124), "barack jagger@theworld.ca", "Barack Jagger", "81454823", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7125) },
                    { 24, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7126), "oprah winfrey@bbc.co.uk", "Oprah Winfrey", "84236288", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7126) },
                    { 25, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7127), "donald obama@tesla.com", "Donald Obama", "11106320", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7128) },
                    { 26, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7129), "charles winfrey@something.com", "Charles Winfrey", "98425086", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7129) },
                    { 27, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7130), "mick winfrey@bbc.co.uk", "Mick Winfrey", "70070854", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7130) },
                    { 28, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7131), "kate presley@nasa.org.us", "Kate Presley", "88125635", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7132) },
                    { 29, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7133), "oprah winslet@gov.ru", "Oprah Winslet", "55589125", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7133) },
                    { 30, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7134), "audrey windsor@something.com", "Audrey Windsor", "87967846", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7134) },
                    { 31, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7135), "elvis middleton@gov.ru", "Elvis Middleton", "77889124", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7136) },
                    { 32, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7137), "charles hepburn@bbc.co.uk", "Charles Hepburn", "41980562", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7137) },
                    { 33, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7138), "mick windsor@tesla.com", "Mick Windsor", "46573335", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7138) },
                    { 34, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7147), "audrey winfrey@tesla.com", "Audrey Winfrey", "14297485", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7148) },
                    { 35, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7149), "donald jagger@something.com", "Donald Jagger", "76653793", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7149) },
                    { 36, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7151), "oprah winfrey@theworld.ca", "Oprah Winfrey", "27250815", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7151) },
                    { 37, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7152), "charles jagger@tesla.com", "Charles Jagger", "22683147", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7152) },
                    { 38, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7153), "elvis winslet@bbc.co.uk", "Elvis Winslet", "61709303", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7153) },
                    { 39, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7154), "mick jagger@tesla.com", "Mick Jagger", "38151327", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7155) },
                    { 40, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7156), "audrey windsor@something.com", "Audrey Windsor", "27011355", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7156) },
                    { 41, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7157), "kate winfrey@theworld.ca", "Kate Winfrey", "37145318", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7157) },
                    { 42, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7158), "audrey winfrey@something.com", "Audrey Winfrey", "38519203", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7159) },
                    { 43, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7160), "charles middleton@gov.us", "Charles Middleton", "77133526", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7160) },
                    { 44, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7161), "donald hepburn@nasa.org.us", "Donald Hepburn", "48194121", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7162) },
                    { 45, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7163), "barack presley@nasa.org.us", "Barack Presley", "18488203", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7163) },
                    { 46, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7164), "charles trump@theworld.ca", "Charles Trump", "13162166", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7165) },
                    { 47, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7166), "jimi hepburn@google.com", "Jimi Hepburn", "23226421", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7166) },
                    { 48, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7167), "audrey jagger@gov.gr", "Audrey Jagger", "61420949", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7167) },
                    { 49, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7168), "kate obama@gov.us", "Kate Obama", "59125783", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7168) }
                });

            migrationBuilder.InsertData(
                table: "movie",
                columns: new[] { "movie_id", "CreatedAt", "description", "rating", "runtime_mins", "title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7525), "Very funny", "years 11+", 146, "Several Rose Smelling Buildings", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(7643) },
                    { 2, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(8153), "Very funny", "years 16+", 91, "Fifteen Microscopic Leopards", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(8153) },
                    { 3, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(8157), "Very funny", "years 6+", 90, "Fifteen Microscopic Leopards", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(8157) },
                    { 4, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(8159), "Very funny", "All", 137, "Two Transparent Cars", new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(8159) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "screening_id", "capacity", "CreatedAt", "movie_id", "screen_number", "starts_at", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 89, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(8777), 3, 1, new DateTime(2025, 7, 3, 9, 55, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(8892) },
                    { 2, 88, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9799), 2, 0, new DateTime(2025, 8, 1, 11, 30, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9800) },
                    { 3, 34, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9802), 3, 2, new DateTime(2025, 6, 22, 13, 40, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9802) },
                    { 4, 55, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9803), 2, 0, new DateTime(2025, 5, 14, 16, 45, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9803) },
                    { 5, 61, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9804), 3, 1, new DateTime(2025, 6, 7, 4, 25, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9804) },
                    { 6, 84, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9807), 2, 2, new DateTime(2025, 7, 3, 9, 55, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9807) },
                    { 7, 78, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9808), 1, 4, new DateTime(2025, 7, 3, 9, 55, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9808) },
                    { 8, 56, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9809), 2, 0, new DateTime(2025, 7, 3, 9, 55, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9809) },
                    { 9, 50, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9810), 1, 2, new DateTime(2025, 3, 25, 15, 50, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9810) },
                    { 10, 63, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9811), 4, 3, new DateTime(2025, 5, 1, 8, 10, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9812) },
                    { 11, 70, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9812), 1, 4, new DateTime(2025, 2, 3, 7, 45, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9813) },
                    { 12, 62, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9813), 4, 1, new DateTime(2025, 2, 3, 7, 45, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9813) },
                    { 13, 43, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9814), 4, 4, new DateTime(2025, 5, 14, 16, 45, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9814) },
                    { 14, 26, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9815), 3, 4, new DateTime(2025, 2, 3, 7, 45, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9815) },
                    { 15, 66, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9816), 1, 1, new DateTime(2025, 5, 14, 16, 45, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9816) },
                    { 16, 66, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9823), 2, 2, new DateTime(2025, 2, 3, 7, 45, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9823) },
                    { 17, 86, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9824), 2, 4, new DateTime(2025, 6, 7, 4, 25, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9824) },
                    { 18, 54, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9826), 4, 4, new DateTime(2025, 2, 21, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9826) },
                    { 19, 65, new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9826), 1, 1, new DateTime(2025, 7, 3, 9, 55, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 26, 10, 6, 24, 726, DateTimeKind.Utc).AddTicks(9827) }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "ticket_id", "CreatedAt", "customer_id", "screening_id", "UpdatedAt", "numSeats" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 51, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 62, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 66, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 68, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 71, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 72, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 73, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 74, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 76, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 77, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 78, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 79, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 80, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 81, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 82, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 83, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 84, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 85, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 86, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 87, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 88, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 89, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 90, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 91, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 92, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 93, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 94, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 95, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 96, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 97, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 98, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 101, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 102, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 103, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 104, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 105, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 106, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 107, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 108, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 109, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 110, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 111, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 112, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 113, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 114, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 115, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 116, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 117, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 118, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 119, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 120, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 121, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 122, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 123, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 124, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 125, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 126, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 127, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 128, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 129, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 130, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 131, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 132, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 133, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 134, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 135, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 136, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 137, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 138, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 139, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 140, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 141, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 142, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 143, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 144, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 145, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 146, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 147, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 148, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 149, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 150, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 151, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 152, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 153, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 154, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 155, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 156, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 157, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 158, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 159, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 160, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 161, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 162, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 163, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 164, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 165, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 166, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 167, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 168, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 169, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 170, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 171, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 172, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 173, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 174, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 175, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 176, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 177, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 178, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 179, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 180, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 181, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 182, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 183, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 184, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 185, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 186, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 187, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 188, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 189, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 190, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 191, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 192, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 193, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 194, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 195, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 196, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 197, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 198, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 199, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_movie_id",
                table: "screenings",
                column: "movie_id");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_customer_id",
                table: "tickets",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_screening_id",
                table: "tickets",
                column: "screening_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "screenings");

            migrationBuilder.DropTable(
                name: "movie");
        }
    }
}
