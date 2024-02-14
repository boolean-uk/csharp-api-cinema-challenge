using Microsoft.EntityFrameworkCore.Migrations;

using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class closetoending : Migration
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
                    { 1, "didyouknowme@wordpress.com", "Hannibal Lecter", "78179895", new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9931), new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9949) },
                    { 2, "itswednesdaymydudes@gmail.co.us", "Gandalf", "43090294", new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9951), new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9951) },
                    { 3, "haveiseenyoubefore@hotmail.com", "Anakin Skywalker", "54738184", new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9952), new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9953) },
                    { 4, "haveiseenyoubefore@hotmail.com", "John Doe", "67348999", new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9953), new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9954) },
                    { 5, "didyouseeme@microsoft.com", "John Doe", "74179110", new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9954), new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9955) },
                    { 6, "idontknowyou@yahoo.com", "Monkey D Luffy", "17122970", new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9956), new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9957) },
                    { 7, "idontknowyou@yahoo.com", "Roronoa Zoro", "43910689", new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9958), new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9958) },
                    { 8, "didyouseeme@microsoft.com", "Roronoa Zoro", "41109882", new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9958), new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9959) },
                    { 9, "haveiseenyoubefore@hotmail.com", "Monkey D Luffy", "78700616", new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9959), new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9960) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "description", "rating", "runtime_mins", "title", "created_at", "updated_at" },
                values: new object[,]
                {
                    { 1, "description", "NC-17", 129, "Monster INC", new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9961), new DateTime(2024, 2, 15, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9963) },
                    { 2, "description", "PG-13", 107, "The Equalizer 2", new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9971), new DateTime(2024, 2, 15, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9971) },
                    { 3, "description", "R", 151, "Lord of the rings: Two towers", new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9972), new DateTime(2024, 2, 15, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9973) },
                    { 4, "description", "R", 108, "103 Mercies", new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9973), new DateTime(2024, 2, 15, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9974) },
                    { 5, "description", "PG", 113, "The Equalizer 2", new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9974), new DateTime(2024, 2, 15, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9975) },
                    { 6, "description", "R", 107, "John wick 4", new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9976), new DateTime(2024, 2, 15, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9977) },
                    { 7, "description", "R", 98, "Revenge of the sith", new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9977), new DateTime(2024, 2, 15, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9978) },
                    { 8, "description", "PG-13", 179, "The hobbit", new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9978), new DateTime(2024, 2, 15, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9979) },
                    { 9, "description", "NC-17", 108, "John wick 4", new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9979), new DateTime(2024, 2, 15, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9979) }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "fk_movie_id", "capacity", "created_at", "screen_number", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 4, 99, new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9982), 6, new DateTime(2024, 2, 17, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9983), new DateTime(2024, 2, 15, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9984) },
                    { 2, 4, 57, new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9985), 3, new DateTime(2024, 2, 20, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9986), new DateTime(2024, 2, 15, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9986) },
                    { 3, 3, 54, new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9987), 7, new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9987), new DateTime(2024, 2, 15, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9988) },
                    { 4, 2, 98, new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9988), 5, new DateTime(2024, 2, 22, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9988), new DateTime(2024, 2, 15, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9989) },
                    { 5, 5, 98, new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9989), 7, new DateTime(2024, 2, 21, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9989), new DateTime(2024, 2, 15, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9990) },
                    { 6, 6, 60, new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9991), 3, new DateTime(2024, 2, 16, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9991), new DateTime(2024, 2, 15, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9992) },
                    { 7, 7, 84, new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9992), 5, new DateTime(2024, 2, 22, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9992), new DateTime(2024, 2, 15, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9993) },
                    { 8, 6, 93, new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9993), 7, new DateTime(2024, 2, 18, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9994), new DateTime(2024, 2, 15, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9994) },
                    { 9, 8, 61, new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9994), 3, new DateTime(2024, 2, 18, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9995), new DateTime(2024, 2, 15, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9995) },
                    { 10, 8, 57, new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9996), 2, new DateTime(2024, 2, 16, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9996), new DateTime(2024, 2, 15, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9997) },
                    { 11, 3, 88, new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9997), 5, new DateTime(2024, 2, 22, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9997), new DateTime(2024, 2, 15, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9998) },
                    { 12, 4, 65, new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9998), 1, new DateTime(2024, 2, 23, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9998), new DateTime(2024, 2, 15, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9999) },
                    { 13, 5, 83, new DateTime(2024, 2, 14, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9999), 3, new DateTime(2024, 2, 21, 9, 20, 31, 796, DateTimeKind.Utc).AddTicks(9999), new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc) },
                    { 14, 8, 88, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc), 6, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc), new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(1) },
                    { 15, 6, 63, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(1), 3, new DateTime(2024, 2, 18, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(1), new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(2) },
                    { 16, 6, 67, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(2), 5, new DateTime(2024, 2, 23, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(2), new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(3) },
                    { 17, 6, 57, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(3), 4, new DateTime(2024, 2, 20, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(3), new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(4) },
                    { 18, 2, 87, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(5), 5, new DateTime(2024, 2, 17, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(5), new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(5) },
                    { 19, 5, 59, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(6), 6, new DateTime(2024, 2, 16, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(6), new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(6) }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "created_at", "fk_customer_id", "num_seats", "fk_screening_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(7), 2, 4, 9, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(9) },
                    { 2, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(10), 4, 3, 10, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(11) },
                    { 3, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(11), 1, 5, 16, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(12) },
                    { 4, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(12), 2, 2, 8, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(13) },
                    { 5, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(13), 2, 4, 6, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(13) },
                    { 6, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(14), 7, 5, 8, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(15) },
                    { 7, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(15), 1, 3, 2, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(16) },
                    { 8, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(16), 1, 4, 8, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(17) },
                    { 9, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(17), 1, 3, 13, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(17) },
                    { 10, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(18), 2, 4, 19, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(19) },
                    { 11, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(19), 5, 3, 15, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(19) },
                    { 12, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(20), 4, 1, 12, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(20) },
                    { 13, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(20), 2, 1, 14, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(21) },
                    { 14, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(21), 2, 1, 12, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(21) },
                    { 15, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(22), 9, 4, 18, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(22) },
                    { 16, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(22), 9, 3, 11, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(23) },
                    { 17, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(23), 3, 1, 19, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(23) },
                    { 18, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(24), 7, 4, 5, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(25) },
                    { 19, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(25), 3, 4, 8, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(25) },
                    { 20, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(26), 4, 5, 17, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(26) },
                    { 21, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(26), 5, 1, 13, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(27) },
                    { 22, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(27), 9, 2, 12, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(28) },
                    { 23, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(28), 8, 2, 13, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(29) },
                    { 24, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(29), 2, 3, 13, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(29) },
                    { 25, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(29), 4, 3, 3, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(30) },
                    { 26, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(30), 4, 3, 5, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(31) },
                    { 27, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(31), 8, 3, 3, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(31) },
                    { 28, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(32), 4, 3, 5, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(32) },
                    { 29, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(32), 4, 5, 19, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(33) },
                    { 30, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(33), 7, 4, 7, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(33) },
                    { 31, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(34), 3, 3, 1, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(34) },
                    { 32, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(34), 3, 3, 3, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(35) },
                    { 33, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(35), 4, 4, 19, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(35) },
                    { 34, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(36), 6, 3, 5, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(37) },
                    { 35, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(37), 3, 4, 5, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(37) },
                    { 36, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(71), 2, 5, 16, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(72) },
                    { 37, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(72), 1, 5, 13, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(73) },
                    { 38, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(73), 4, 5, 10, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(74) },
                    { 39, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(74), 3, 1, 3, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(74) },
                    { 40, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(75), 3, 1, 14, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(75) },
                    { 41, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(76), 3, 1, 12, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(76) },
                    { 42, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(76), 8, 1, 10, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(77) },
                    { 43, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(77), 3, 3, 5, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(78) },
                    { 44, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(78), 3, 4, 13, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(78) },
                    { 45, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(79), 6, 2, 7, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(79) },
                    { 46, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(79), 3, 4, 18, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(80) },
                    { 47, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(80), 3, 5, 8, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(80) },
                    { 48, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(81), 3, 4, 5, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(81) },
                    { 49, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(81), 4, 1, 12, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(82) },
                    { 50, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(82), 9, 3, 6, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(83) },
                    { 51, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(83), 1, 2, 13, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(83) },
                    { 52, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(84), 5, 5, 9, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(84) },
                    { 53, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(84), 8, 5, 18, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(85) },
                    { 54, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(85), 6, 3, 1, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(85) },
                    { 55, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(86), 6, 3, 14, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(86) },
                    { 56, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(86), 7, 5, 11, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(87) },
                    { 57, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(87), 7, 3, 18, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(87) },
                    { 58, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(88), 4, 2, 14, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(88) },
                    { 59, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(88), 8, 5, 13, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(89) },
                    { 60, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(89), 9, 3, 6, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(89) },
                    { 61, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(90), 1, 3, 16, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(90) },
                    { 62, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(90), 2, 1, 3, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(91) },
                    { 63, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(91), 2, 4, 15, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(91) },
                    { 64, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(92), 1, 4, 19, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(92) },
                    { 65, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(92), 2, 5, 16, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(93) },
                    { 66, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(94), 1, 3, 6, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(95) },
                    { 67, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(95), 5, 1, 18, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(95) },
                    { 68, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(96), 6, 5, 11, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(96) },
                    { 69, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(96), 4, 1, 17, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(97) },
                    { 70, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(97), 8, 1, 10, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(97) },
                    { 71, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(98), 2, 3, 16, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(98) },
                    { 72, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(98), 5, 4, 14, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(99) },
                    { 73, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(99), 8, 3, 19, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(99) },
                    { 74, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(100), 2, 5, 15, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(100) },
                    { 75, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(100), 9, 4, 11, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(101) },
                    { 76, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(101), 7, 2, 1, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(101) },
                    { 77, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(102), 8, 5, 15, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(102) },
                    { 78, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(102), 5, 2, 12, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(103) },
                    { 79, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(103), 5, 1, 10, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(103) },
                    { 80, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(104), 3, 1, 6, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(104) },
                    { 81, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(104), 2, 4, 5, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(105) },
                    { 82, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(105), 1, 5, 9, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(106) },
                    { 83, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(106), 6, 5, 16, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(106) },
                    { 84, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(107), 1, 3, 5, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(107) },
                    { 85, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(107), 1, 1, 6, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(108) },
                    { 86, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(108), 9, 1, 3, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(108) },
                    { 87, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(109), 9, 3, 1, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(109) },
                    { 88, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(109), 9, 1, 7, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(110) },
                    { 89, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(110), 5, 2, 19, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(110) },
                    { 90, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(111), 4, 4, 4, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(111) },
                    { 91, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(111), 3, 4, 9, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(112) },
                    { 92, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(112), 7, 1, 11, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(112) },
                    { 93, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(113), 9, 2, 2, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(113) },
                    { 94, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(113), 7, 3, 12, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(114) },
                    { 95, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(114), 8, 2, 6, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(114) },
                    { 96, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(115), 5, 1, 12, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(115) },
                    { 97, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(116), 7, 5, 1, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(116) },
                    { 98, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(116), 6, 2, 19, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(117) },
                    { 99, new DateTime(2024, 2, 14, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(117), 2, 1, 9, new DateTime(2024, 2, 15, 9, 20, 31, 797, DateTimeKind.Utc).AddTicks(117) }
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
