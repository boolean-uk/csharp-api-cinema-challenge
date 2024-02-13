using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone_number = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    runtime_mins = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Screenings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    screen_number = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fk_movie_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screenings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Screenings_Movies_fk_movie_id",
                        column: x => x.fk_movie_id,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    num_seats = table.Column<int>(type: "integer", nullable: false),
                    fk_screening_id = table.Column<int>(type: "integer", nullable: false),
                    fk_customer_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Customers_fk_customer_id",
                        column: x => x.fk_customer_id,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Screenings_fk_screening_id",
                        column: x => x.fk_screening_id,
                        principalTable: "Screenings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "email", "name", "phone_number", "created_at", "updated_at" },
                values: new object[,]
                {
                    { 1, "itswednesdaymydudes@gmail.co.us", "John Doe", "67844848", new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9549), new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9567) },
                    { 2, "youknowme@gmail.com", "Roronoa Zoro", "65896276", new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9569), new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9570) },
                    { 3, "idontknowyou@yahoo.com", "Gandalf", "89049816", new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9570), new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9571) },
                    { 4, "didyouknowme@wordpress.com", "Bilbo Baggins", "23719643", new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9571), new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9618) },
                    { 5, "didyouknowme@wordpress.com", "Anakin Skywalker", "48270312", new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9618), new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9619) },
                    { 6, "didyouknowme@wordpress.com", "Bilbo Baggins", "82374055", new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9620), new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9621) },
                    { 7, "haveiseenyoubefore@hotmail.com", "Gandalf", "39733149", new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9621), new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9622) },
                    { 8, "idontknowyou@yahoo.com", "Hannibal Lecter", "14189990", new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9622), new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9623) },
                    { 9, "imlost@geoguesser.com", "Hannibal Lecter", "56874053", new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9623), new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9624) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "description", "rating", "runtime_mins", "title", "created_at", "updated_at" },
                values: new object[,]
                {
                    { 1, "description", "PG-13", 117, "I have no ideas left", new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9626), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9627) },
                    { 2, "description", "G", 122, "John wick 4", new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9634), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9635) },
                    { 3, "description", "NC-17", 78, "Revenge of the sith", new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9635), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9636) },
                    { 4, "description", "PG-13", 105, "The hobbit", new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9637), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9637) },
                    { 5, "description", "G", 114, "The hobbit", new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9637), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9638) },
                    { 6, "description", "R", 106, "The hobbit", new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9639), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9639) },
                    { 7, "description", "PG", 160, "The Equalizer 2", new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9640), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9640) },
                    { 8, "description", "R", 109, "Lord of the rings: Two towers", new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9641), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9641) },
                    { 9, "description", "PG-13", 83, "Monster INC", new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9642), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9642) }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "fk_movie_id", "capacity", "created_at", "screen_number", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 1, 91, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9643), 5, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9644), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9646) },
                    { 2, 5, 56, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9647), 4, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9647), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9648) },
                    { 3, 5, 80, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9648), 4, new DateTime(2024, 2, 16, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9648), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9649) },
                    { 4, 1, 71, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9649), 6, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9650), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9650) },
                    { 5, 8, 88, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9650), 7, new DateTime(2024, 2, 19, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9651), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9651) },
                    { 6, 1, 61, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9652), 1, new DateTime(2024, 2, 15, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9652), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9653) },
                    { 7, 7, 61, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9653), 3, new DateTime(2024, 2, 19, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9654), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9654) },
                    { 8, 7, 86, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9654), 5, new DateTime(2024, 2, 19, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9655), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9655) },
                    { 9, 6, 62, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9655), 7, new DateTime(2024, 2, 20, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9656), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9656) },
                    { 10, 3, 73, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9657), 1, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9657), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9657) },
                    { 11, 7, 77, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9658), 6, new DateTime(2024, 2, 15, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9658), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9659) },
                    { 12, 6, 53, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9659), 5, new DateTime(2024, 2, 18, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9659), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9660) },
                    { 13, 9, 50, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9660), 3, new DateTime(2024, 2, 21, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9660), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9661) },
                    { 14, 1, 52, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9661), 1, new DateTime(2024, 2, 16, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9661), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9662) },
                    { 15, 5, 99, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9662), 6, new DateTime(2024, 2, 18, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9662), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9663) },
                    { 16, 8, 91, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9663), 2, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9663), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9664) },
                    { 17, 6, 52, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9664), 6, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9664), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9665) },
                    { 18, 4, 99, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9666), 3, new DateTime(2024, 2, 17, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9666), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9666) },
                    { 19, 3, 97, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9667), 6, new DateTime(2024, 2, 17, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9667), new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9667) }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "created_at", "fk_customer_id", "num_seats", "fk_screening_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9668), 5, 5, 1, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9670) },
                    { 2, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9671), 6, 5, 2, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9672) },
                    { 3, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9672), 6, 3, 13, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9673) },
                    { 4, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9673), 6, 4, 13, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9673) },
                    { 5, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9674), 4, 5, 7, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9674) },
                    { 6, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9675), 3, 1, 16, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9676) },
                    { 7, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9676), 2, 2, 2, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9676) },
                    { 8, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9677), 7, 5, 9, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9677) },
                    { 9, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9677), 2, 2, 1, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9678) },
                    { 10, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9679), 3, 4, 10, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9679) },
                    { 11, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9679), 1, 5, 9, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9680) },
                    { 12, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9680), 1, 5, 2, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9681) },
                    { 13, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9681), 8, 1, 7, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9681) },
                    { 14, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9682), 6, 4, 13, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9682) },
                    { 15, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9682), 8, 1, 12, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9683) },
                    { 16, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9683), 6, 1, 3, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9683) },
                    { 17, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9684), 8, 3, 11, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9684) },
                    { 18, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9685), 9, 3, 7, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9685) },
                    { 19, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9686), 9, 4, 16, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9686) },
                    { 20, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9686), 3, 4, 18, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9687) },
                    { 21, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9687), 2, 1, 19, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9687) },
                    { 22, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9688), 8, 2, 16, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9688) },
                    { 23, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9688), 7, 1, 11, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9689) },
                    { 24, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9689), 7, 2, 7, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9689) },
                    { 25, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9690), 1, 2, 7, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9690) },
                    { 26, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9690), 6, 4, 6, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9691) },
                    { 27, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9691), 1, 4, 13, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9691) },
                    { 28, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9692), 9, 5, 9, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9692) },
                    { 29, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9692), 1, 1, 18, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9693) },
                    { 30, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9693), 2, 1, 3, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9693) },
                    { 31, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9694), 5, 4, 6, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9694) },
                    { 32, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9694), 3, 1, 7, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9695) },
                    { 33, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9695), 7, 4, 1, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9696) },
                    { 34, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9696), 4, 4, 16, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9697) },
                    { 35, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9697), 7, 3, 15, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9698) },
                    { 36, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9698), 5, 1, 15, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9698) },
                    { 37, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9699), 9, 5, 11, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9699) },
                    { 38, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9699), 8, 5, 12, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9700) },
                    { 39, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9700), 5, 4, 11, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9700) },
                    { 40, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9701), 7, 3, 15, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9701) },
                    { 41, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9701), 8, 2, 5, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9702) },
                    { 42, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9702), 9, 2, 9, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9702) },
                    { 43, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9703), 2, 2, 4, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9703) },
                    { 44, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9703), 8, 4, 8, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9704) },
                    { 45, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9704), 2, 4, 12, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9704) },
                    { 46, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9705), 6, 3, 7, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9705) },
                    { 47, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9705), 3, 2, 16, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9706) },
                    { 48, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9706), 4, 1, 12, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9706) },
                    { 49, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9741), 4, 1, 15, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9742) },
                    { 50, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9742), 5, 3, 12, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9742) },
                    { 51, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9743), 2, 5, 17, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9743) },
                    { 52, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9744), 7, 1, 7, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9744) },
                    { 53, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9744), 5, 4, 13, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9745) },
                    { 54, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9745), 3, 3, 11, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9746) },
                    { 55, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9746), 8, 3, 2, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9746) },
                    { 56, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9747), 3, 3, 16, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9747) },
                    { 57, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9747), 5, 4, 13, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9748) },
                    { 58, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9748), 3, 2, 7, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9748) },
                    { 59, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9749), 1, 3, 13, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9749) },
                    { 60, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9749), 4, 2, 3, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9750) },
                    { 61, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9750), 8, 4, 1, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9751) },
                    { 62, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9751), 7, 3, 3, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9751) },
                    { 63, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9752), 6, 1, 9, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9752) },
                    { 64, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9752), 4, 1, 14, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9753) },
                    { 65, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9753), 7, 1, 9, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9753) },
                    { 66, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9754), 9, 5, 1, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9755) },
                    { 67, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9755), 2, 1, 16, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9755) },
                    { 68, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9756), 8, 3, 11, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9756) },
                    { 69, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9756), 7, 1, 6, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9757) },
                    { 70, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9757), 8, 2, 17, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9758) },
                    { 71, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9758), 6, 3, 8, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9758) },
                    { 72, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9759), 5, 2, 18, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9759) },
                    { 73, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9759), 5, 1, 11, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9760) },
                    { 74, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9760), 6, 1, 12, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9760) },
                    { 75, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9761), 6, 4, 10, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9761) },
                    { 76, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9761), 1, 1, 7, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9762) },
                    { 77, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9762), 3, 1, 19, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9762) },
                    { 78, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9763), 8, 3, 2, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9763) },
                    { 79, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9763), 4, 5, 7, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9764) },
                    { 80, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9764), 4, 2, 17, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9764) },
                    { 81, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9765), 7, 2, 12, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9765) },
                    { 82, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9765), 1, 4, 2, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9766) },
                    { 83, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9766), 8, 3, 15, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9766) },
                    { 84, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9767), 4, 3, 9, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9767) },
                    { 85, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9767), 7, 5, 11, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9768) },
                    { 86, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9768), 8, 4, 14, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9769) },
                    { 87, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9769), 1, 5, 15, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9769) },
                    { 88, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9770), 1, 1, 7, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9770) },
                    { 89, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9770), 3, 1, 7, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9771) },
                    { 90, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9771), 8, 5, 14, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9771) },
                    { 91, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9772), 9, 2, 10, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9772) },
                    { 92, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9772), 3, 1, 18, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9773) },
                    { 93, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9773), 8, 5, 10, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9773) },
                    { 94, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9774), 9, 4, 4, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9774) },
                    { 95, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9774), 4, 5, 11, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9775) },
                    { 96, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9775), 9, 1, 1, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9775) },
                    { 97, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9776), 7, 5, 7, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9776) },
                    { 98, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9776), 2, 4, 5, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9777) },
                    { 99, new DateTime(2024, 2, 13, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9777), 1, 5, 5, new DateTime(2024, 2, 14, 10, 45, 36, 543, DateTimeKind.Utc).AddTicks(9777) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_fk_movie_id",
                table: "Screenings",
                column: "fk_movie_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_fk_customer_id",
                table: "Tickets",
                column: "fk_customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_fk_screening_id",
                table: "Tickets",
                column: "fk_screening_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Screenings");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
