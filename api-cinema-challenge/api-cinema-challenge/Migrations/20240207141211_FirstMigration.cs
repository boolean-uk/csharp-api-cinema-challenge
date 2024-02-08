using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    phone_number = table.Column<string>(type: "text", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: true),
                    rating = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    runtime = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "screenings",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    screen_number = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    available_seats = table.Column<int>(type: "integer", nullable: false),
                    movie_id = table.Column<int>(type: "integer", nullable: false),
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => x.id);
                    table.ForeignKey(
                        name: "FK_screenings_movies_movie_id",
                        column: x => x.movie_id,
                        principalTable: "movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    number_of_seats = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.id);
                    table.ForeignKey(
                        name: "FK_tickets_customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tickets_screenings_screening_id",
                        column: x => x.screening_id,
                        principalTable: "screenings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "created_at", "email", "name", "phone_number", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8626), "MahmouydAziz@email.com", "Mahmouyd Aziz", "47833504", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8626) },
                    { 2, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8647), "AzizyMahmoud@email.com", "Azizy Mahmoud", "46036315", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8647) },
                    { 3, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8649), "RobbyAziz@email.com", "Robby Aziz", "41448912", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8649) },
                    { 4, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8650), "RobbyMahmoud@email.com", "Robby Mahmoud", "15718906", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8650) },
                    { 5, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8651), "BobbyChad@email.com", "Bobby Chad", "57225799", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8651) },
                    { 6, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8654), "GeorgyDob@email.com", "Georgy Dob", "84332798", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8654) },
                    { 7, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8656), "HenrickyDob@email.com", "Henricky Dob", "76853871", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8656) },
                    { 8, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8657), "JensyHenrick@email.com", "Jensy Henrick", "82229931", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8657) },
                    { 9, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8658), "AzizyKris@email.com", "Azizy Kris", "29780677", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8659) },
                    { 10, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8660), "HenrickyKris@email.com", "Henricky Kris", "60388849", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8661) },
                    { 11, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8662), "RobbyRob@email.com", "Robby Rob", "27819644", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8662) },
                    { 12, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8706), "RobbyBob@email.com", "Robby Bob", "19579260", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8706) },
                    { 13, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8708), "KrissyBob@email.com", "Krissy Bob", "96962158", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8708) },
                    { 14, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8709), "MahmouydKris@email.com", "Mahmouyd Kris", "97023583", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8710) },
                    { 15, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8711), "JensyKris@email.com", "Jensy Kris", "92647454", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8711) },
                    { 16, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8712), "JensyDob@email.com", "Jensy Dob", "98217197", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8713) },
                    { 17, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8714), "AzizyBob@email.com", "Azizy Bob", "86015611", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8714) },
                    { 18, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8716), "AzizyBob@email.com", "Azizy Bob", "45180001", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8717) },
                    { 19, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8718), "GeorgyHenrick@email.com", "Georgy Henrick", "84700209", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8718) },
                    { 20, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8719), "GeorgyChad@email.com", "Georgy Chad", "15773476", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8719) },
                    { 21, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8720), "ChadyAziz@email.com", "Chady Aziz", "36494512", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8721) },
                    { 22, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8722), "DobbyAziz@email.com", "Dobby Aziz", "78587889", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8722) },
                    { 23, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8723), "RobbyHenrick@email.com", "Robby Henrick", "83179238", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8723) },
                    { 24, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8724), "BobbyMahmoud@email.com", "Bobby Mahmoud", "92917293", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8724) },
                    { 25, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8725), "RobbyBob@email.com", "Robby Bob", "65899120", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8725) },
                    { 26, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8726), "RobbyHenrick@email.com", "Robby Henrick", "84031018", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8726) },
                    { 27, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8727), "MahmouydBob@email.com", "Mahmouyd Bob", "67539880", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8728) },
                    { 28, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8729), "DobbyChad@email.com", "Dobby Chad", "44084854", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8729) },
                    { 29, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8730), "AzizyDob@email.com", "Azizy Dob", "25921043", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8730) },
                    { 30, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8731), "HenrickyAziz@email.com", "Henricky Aziz", "28467336", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8731) },
                    { 31, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8732), "JensyKris@email.com", "Jensy Kris", "16499324", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8733) },
                    { 32, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8734), "KrissyAziz@email.com", "Krissy Aziz", "95289021", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8734) },
                    { 33, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8735), "JensyAziz@email.com", "Jensy Aziz", "27333211", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8735) },
                    { 34, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8737), "DobbyRob@email.com", "Dobby Rob", "89723877", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8737) },
                    { 35, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8738), "JensyMahmoud@email.com", "Jensy Mahmoud", "76906661", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8738) },
                    { 36, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8739), "BobbyGeorge@email.com", "Bobby George", "64807483", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8739) },
                    { 37, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8740), "GeorgyKris@email.com", "Georgy Kris", "56804946", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8740) },
                    { 38, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8741), "JensyJens@email.com", "Jensy Jens", "44774550", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8742) },
                    { 39, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8742), "MahmouydRob@email.com", "Mahmouyd Rob", "48216847", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8743) },
                    { 40, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8744), "RobbyGeorge@email.com", "Robby George", "77253455", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8744) },
                    { 41, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8773), "JensyDob@email.com", "Jensy Dob", "50704203", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8773) },
                    { 42, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8775), "ChadyDob@email.com", "Chady Dob", "34975330", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8775) },
                    { 43, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8776), "BobbyGeorge@email.com", "Bobby George", "33133161", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8777) },
                    { 44, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8778), "HenrickyChad@email.com", "Henricky Chad", "55433565", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8778) },
                    { 45, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8779), "KrissyChad@email.com", "Krissy Chad", "66404427", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8780) },
                    { 46, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8781), "DobbyGeorge@email.com", "Dobby George", "78962465", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8781) },
                    { 47, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8782), "GeorgyChad@email.com", "Georgy Chad", "60650161", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8782) },
                    { 48, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8783), "JensyHenrick@email.com", "Jensy Henrick", "91663019", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8784) },
                    { 49, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8785), "GeorgyBob@email.com", "Georgy Bob", "53262143", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8785) },
                    { 50, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8786), "JensyDob@email.com", "Jensy Dob", "78286855", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8786) },
                    { 51, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8787), "BobbyHenrick@email.com", "Bobby Henrick", "12821257", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8787) },
                    { 52, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8788), "JensyAziz@email.com", "Jensy Aziz", "79655370", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8789) },
                    { 53, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8789), "KrissyGeorge@email.com", "Krissy George", "50890930", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8790) },
                    { 54, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8791), "MahmouydGeorge@email.com", "Mahmouyd George", "57783853", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8791) },
                    { 55, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8792), "GeorgyChad@email.com", "Georgy Chad", "59330767", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8792) },
                    { 56, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8793), "HenrickyGeorge@email.com", "Henricky George", "70628869", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8793) },
                    { 57, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8794), "MahmouydJens@email.com", "Mahmouyd Jens", "29149435", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8795) },
                    { 58, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8795), "GeorgyGeorge@email.com", "Georgy George", "20072822", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8796) },
                    { 59, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8797), "GeorgyMahmoud@email.com", "Georgy Mahmoud", "25474933", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8797) },
                    { 60, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8798), "ChadyHenrick@email.com", "Chady Henrick", "12991133", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8798) },
                    { 61, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8799), "AzizyRob@email.com", "Azizy Rob", "38561380", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8799) },
                    { 62, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8800), "JensyGeorge@email.com", "Jensy George", "20098462", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8800) },
                    { 63, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8801), "GeorgyRob@email.com", "Georgy Rob", "92376312", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8802) },
                    { 64, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8803), "ChadyAziz@email.com", "Chady Aziz", "60814376", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8803) },
                    { 65, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8804), "JensyJens@email.com", "Jensy Jens", "10920059", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8804) },
                    { 66, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8806), "DobbyAziz@email.com", "Dobby Aziz", "29015721", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8806) },
                    { 67, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8807), "ChadyMahmoud@email.com", "Chady Mahmoud", "63567618", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8807) },
                    { 68, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8808), "GeorgyAziz@email.com", "Georgy Aziz", "57857798", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8808) },
                    { 69, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8829), "KrissyDob@email.com", "Krissy Dob", "68860032", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8829) },
                    { 70, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8830), "GeorgyRob@email.com", "Georgy Rob", "89668800", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8830) },
                    { 71, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8831), "JensyJens@email.com", "Jensy Jens", "60758338", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8832) },
                    { 72, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8833), "ChadyAziz@email.com", "Chady Aziz", "16624251", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8833) },
                    { 73, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8834), "RobbyDob@email.com", "Robby Dob", "39188013", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8834) },
                    { 74, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8835), "RobbyMahmoud@email.com", "Robby Mahmoud", "60632821", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8836) },
                    { 75, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8837), "ChadyJens@email.com", "Chady Jens", "84833274", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8837) },
                    { 76, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8838), "BobbyAziz@email.com", "Bobby Aziz", "18764068", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8838) },
                    { 77, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8839), "DobbyGeorge@email.com", "Dobby George", "57737866", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8839) },
                    { 78, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8840), "GeorgyDob@email.com", "Georgy Dob", "96720533", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8840) },
                    { 79, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8841), "ChadyGeorge@email.com", "Chady George", "32749253", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8842) },
                    { 80, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8843), "ChadyJens@email.com", "Chady Jens", "28676877", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8843) },
                    { 81, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8844), "GeorgyMahmoud@email.com", "Georgy Mahmoud", "74428570", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8844) },
                    { 82, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8845), "MahmouydHenrick@email.com", "Mahmouyd Henrick", "91443059", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8845) },
                    { 83, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8846), "DobbyAziz@email.com", "Dobby Aziz", "35737710", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8846) },
                    { 84, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8847), "BobbyAziz@email.com", "Bobby Aziz", "40865646", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8847) },
                    { 85, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8848), "AzizyChad@email.com", "Azizy Chad", "20787941", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8849) },
                    { 86, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8850), "KrissyAziz@email.com", "Krissy Aziz", "11728856", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8850) },
                    { 87, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8851), "GeorgyBob@email.com", "Georgy Bob", "90040278", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8851) },
                    { 88, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8852), "KrissyMahmoud@email.com", "Krissy Mahmoud", "10759144", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8852) },
                    { 89, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8853), "MahmouydJens@email.com", "Mahmouyd Jens", "13075838", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8853) },
                    { 90, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8854), "AzizyKris@email.com", "Azizy Kris", "97681287", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8854) },
                    { 91, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8855), "BobbyDob@email.com", "Bobby Dob", "13470976", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8855) },
                    { 92, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8857), "AzizyAziz@email.com", "Azizy Aziz", "30902845", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8857) },
                    { 93, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8858), "DobbyKris@email.com", "Dobby Kris", "21129578", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8858) },
                    { 94, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8859), "KrissyKris@email.com", "Krissy Kris", "81651029", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8859) },
                    { 95, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8860), "MahmouydAziz@email.com", "Mahmouyd Aziz", "50867508", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8861) },
                    { 96, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8861), "RobbyJens@email.com", "Robby Jens", "46317031", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8862) },
                    { 97, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8863), "GeorgyRob@email.com", "Georgy Rob", "69135873", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8863) },
                    { 98, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8864), "MahmouydMahmoud@email.com", "Mahmouyd Mahmoud", "46137022", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8864) },
                    { 99, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8865), "AzizyDob@email.com", "Azizy Dob", "79070534", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8865) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8403), "This is the best movie ever made", "R-Rated", 214, "A lot of Orange Fathers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8406) },
                    { 2, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8418), "This one is a funny one", "PG", 100, "The Humongous Dogs", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8418) },
                    { 3, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8420), "This one is not very good", "NC-17", 120, "A lot of Crazy Fathers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8420) },
                    { 4, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8422), "This one is a funny one", "PG", 130, "Two Orange Mothers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8422) },
                    { 5, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8424), "This is the best movie ever made", "NC-17", 214, "Two Disgusting Clowns", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8424) },
                    { 6, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8427), "Boring movie", "R-Rated", 95, "A lot of Crazy Clowns", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8427) },
                    { 7, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8429), "Boring movie", "NC-17", 110, "Two Exciting Fathers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8429) },
                    { 8, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8430), "This one is a funny one", "R-Rated", 103, "Thousand Foul Cats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8430) },
                    { 9, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8432), "This one is not very good", "R-Rated", 110, "The Exciting Cats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8432) },
                    { 10, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8434), "This one is very scary", "PG-13", 214, "One Crazy Babies", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8434) },
                    { 11, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8436), "This is the best movie ever made", "R-Rated", 103, "Two Humongous Fathers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8436) },
                    { 12, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8438), "This one is very scary", "R-Rated", 90, "Thousand Exciting Humans", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8438) },
                    { 13, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8439), "This one is not very good", "R-Rated", 214, "One Crazy Rats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8439) },
                    { 14, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8440), "This one is not very good", "PG", 140, "Thousand Disgusting Cats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8441) },
                    { 15, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8442), "This is the best movie ever made", "NC-17", 214, "One Disurbing Rats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8442) },
                    { 16, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8444), "Very exciting movie", "PG-13", 103, "Thousand Exciting Fathers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8444) },
                    { 17, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8467), "This one is a funny one", "NC-17", 95, "Thousand Disgusting Mothers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8467) },
                    { 18, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8469), "This one is very scary", "PG", 90, "A lot of Crazy Dogs", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8470) },
                    { 19, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8471), "Very exciting movie", "PG", 140, "One Foul Cats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8472) },
                    { 20, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8473), "Boring movie", "R-Rated", 130, "Two Exciting Humans", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8473) },
                    { 21, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8474), "This is the best movie ever made", "NC-17", 214, "Hundred Crazy Fathers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8474) },
                    { 22, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8476), "This one is a funny one", "R-Rated", 120, "One Crazy Rats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8476) },
                    { 23, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8477), "This one is a funny one", "PG", 90, "Two Disurbing Babies", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8477) },
                    { 24, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8479), "Very exciting movie", "PG-13", 110, "Hundred Exciting Rats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8479) },
                    { 25, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8480), "This is the best movie ever made", "NC-17", 214, "Two Crazy Humans", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8481) },
                    { 26, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8482), "Very exciting movie", "R-Rated", 130, "One Crazy Mothers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8482) },
                    { 27, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8483), "This one is a funny one", "NC-17", 130, "Two Disgusting Clowns", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8483) },
                    { 28, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8485), "This is the best movie ever made", "NC-17", 214, "The Crazy Rats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8485) },
                    { 29, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8486), "This one is very scary", "PG", 95, "Two Disgusting Rats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8486) },
                    { 30, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8487), "This one is not very good", "NC-17", 154, "Hundred Exciting Humans", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8488) },
                    { 31, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8489), "This is the best movie ever made", "NC-17", 90, "One Exciting Mothers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8489) },
                    { 32, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8490), "This one is not very good", "R-Rated", 214, "A lot of Crazy Mothers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8491) },
                    { 33, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8492), "This one is a funny one", "PG-13", 214, "A lot of Foul Fathers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8493) },
                    { 34, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8494), "This one is a funny one", "PG", 110, "One Orange Clowns", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8495) },
                    { 35, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8496), "Boring movie", "PG", 110, "A lot of Foul Cats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8496) },
                    { 36, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8497), "This one is very scary", "PG", 140, "A lot of Foul Babies", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8498) },
                    { 37, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8499), "This one is very scary", "PG", 154, "The Exciting Dogs", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8499) },
                    { 38, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8501), "This one is very scary", "R-Rated", 110, "Hundred Crazy Humans", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8501) },
                    { 39, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8502), "This one is not very good", "PG-13", 95, "The Crazy Rats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8502) },
                    { 40, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8503), "This one is very scary", "PG-13", 103, "Hundred Crazy Humans", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8504) },
                    { 41, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8505), "This is the best movie ever made", "R-Rated", 214, "The Exciting Fathers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8505) },
                    { 42, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8506), "Very exciting movie", "R-Rated", 95, "Thousand Humongous Rats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8506) },
                    { 43, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8508), "This one is not very good", "PG-13", 90, "The Crazy Humans", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8508) },
                    { 44, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8509), "This one is a funny one", "R-Rated", 130, "One Foul Clowns", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8510) },
                    { 45, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8511), "This one is a funny one", "R-Rated", 90, "One Disgusting Fathers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8511) },
                    { 46, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8512), "This one is very scary", "PG", 90, "Thousand Foul Cats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8512) },
                    { 47, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8514), "This is the best movie ever made", "NC-17", 130, "Hundred Disgusting Humans", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8514) },
                    { 48, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8515), "This one is not very good", "NC-17", 100, "The Humongous Dogs", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8515) },
                    { 49, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8536), "This one is not very good", "R-Rated", 110, "One Crazy Clowns", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8537) },
                    { 50, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8538), "This one is very scary", "NC-17", 154, "Hundred Disurbing Mothers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8538) },
                    { 51, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8540), "This one is very scary", "PG", 130, "One Crazy Rats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8540) },
                    { 52, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8541), "This one is not very good", "PG-13", 100, "Hundred Humongous Cats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8542) },
                    { 53, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8543), "Boring movie", "PG", 90, "One Exciting Cats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8543) },
                    { 54, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8544), "Boring movie", "R-Rated", 130, "A lot of Crazy Babies", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8545) },
                    { 55, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8546), "Very exciting movie", "PG-13", 100, "Hundred Orange Humans", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8546) },
                    { 56, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8547), "This one is a funny one", "NC-17", 154, "Two Crazy Clowns", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8547) },
                    { 57, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8549), "This is the best movie ever made", "PG", 120, "Two Exciting Cats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8549) },
                    { 58, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8550), "Boring movie", "PG", 140, "One Foul Rats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8550) },
                    { 59, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8552), "Boring movie", "PG", 90, "Two Humongous Cats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8552) },
                    { 60, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8553), "This one is very scary", "PG", 100, "Two Orange Mothers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8553) },
                    { 61, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8555), "This is the best movie ever made", "NC-17", 100, "Thousand Disgusting Mothers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8555) },
                    { 62, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8556), "This one is a funny one", "PG-13", 100, "Thousand Crazy Humans", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8556) },
                    { 63, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8557), "This one is a funny one", "PG-13", 120, "The Crazy Dogs", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8558) },
                    { 64, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8559), "Very exciting movie", "R-Rated", 90, "Hundred Disgusting Clowns", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8559) },
                    { 65, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8560), "This one is a funny one", "PG", 100, "One Disurbing Clowns", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8560) },
                    { 66, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8563), "This is the best movie ever made", "PG", 110, "One Disurbing Mothers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8563) },
                    { 67, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8564), "Boring movie", "NC-17", 103, "One Humongous Fathers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8564) },
                    { 68, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8566), "This one is not very good", "PG-13", 110, "The Crazy Fathers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8566) },
                    { 69, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8567), "This one is a funny one", "NC-17", 100, "Two Disurbing Mothers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8567) },
                    { 70, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8568), "This one is very scary", "R-Rated", 110, "Hundred Orange Rats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8568) },
                    { 71, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8570), "This is the best movie ever made", "PG", 100, "One Foul Humans", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8570) },
                    { 72, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8571), "Boring movie", "PG-13", 130, "One Crazy Humans", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8571) },
                    { 73, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8572), "This is the best movie ever made", "PG", 103, "A lot of Orange Humans", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8573) },
                    { 74, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8574), "This one is not very good", "NC-17", 130, "The Humongous Babies", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8574) },
                    { 75, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8575), "This is the best movie ever made", "R-Rated", 110, "The Disurbing Mothers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8575) },
                    { 76, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8577), "This one is not very good", "R-Rated", 214, "A lot of Disurbing Humans", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8577) },
                    { 77, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8578), "This is the best movie ever made", "PG", 100, "The Orange Cats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8578) },
                    { 78, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8580), "This one is very scary", "PG-13", 130, "One Disgusting Cats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8580) },
                    { 79, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8581), "Very exciting movie", "R-Rated", 154, "One Disgusting Fathers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8581) },
                    { 80, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8594), "Very exciting movie", "NC-17", 100, "Thousand Disurbing Clowns", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8595) },
                    { 81, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8596), "Boring movie", "PG-13", 214, "Hundred Humongous Dogs", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8597) },
                    { 82, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8598), "Boring movie", "NC-17", 214, "A lot of Crazy Humans", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8598) },
                    { 83, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8599), "This one is a funny one", "R-Rated", 154, "The Crazy Mothers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8600) },
                    { 84, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8601), "This one is very scary", "PG-13", 130, "Hundred Disurbing Rats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8601) },
                    { 85, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8603), "Very exciting movie", "PG", 95, "A lot of Foul Humans", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8603) },
                    { 86, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8604), "Very exciting movie", "R-Rated", 100, "Thousand Exciting Rats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8604) },
                    { 87, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8606), "This is the best movie ever made", "R-Rated", 154, "One Orange Humans", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8606) },
                    { 88, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8607), "Very exciting movie", "NC-17", 110, "The Crazy Cats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8607) },
                    { 89, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8609), "This one is not very good", "R-Rated", 120, "A lot of Humongous Clowns", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8609) },
                    { 90, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8610), "Boring movie", "PG-13", 90, "A lot of Foul Humans", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8610) },
                    { 91, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8612), "This one is a funny one", "PG-13", 90, "The Humongous Rats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8612) },
                    { 92, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8613), "Boring movie", "PG", 110, "A lot of Crazy Humans", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8613) },
                    { 93, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8614), "This one is a funny one", "R-Rated", 103, "Thousand Disgusting Dogs", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8615) },
                    { 94, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8616), "This is the best movie ever made", "PG-13", 120, "Thousand Crazy Fathers", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8616) },
                    { 95, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8617), "This one is very scary", "R-Rated", 214, "Two Exciting Cats", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8618) },
                    { 96, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8619), "This one is very scary", "PG", 130, "Two Foul Clowns", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8619) },
                    { 97, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8620), "This one is a funny one", "R-Rated", 90, "A lot of Disurbing Humans", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8621) },
                    { 98, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8622), "Very exciting movie", "R-Rated", 130, "Thousand Humongous Babies", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8622) },
                    { 99, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8623), "This one is very scary", "PG", 130, "Two Crazy Babies", new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8623) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "available_seats", "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 30, 30, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8887), 22, 9, new DateTime(2024, 2, 16, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8889), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8887) },
                    { 2, 86, 90, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8898), 25, 3, new DateTime(2024, 2, 9, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8899), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8898) },
                    { 3, 50, 50, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8900), 87, 5, new DateTime(2024, 2, 13, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8901), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8900) },
                    { 4, 70, 70, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8901), 55, 3, new DateTime(2024, 2, 8, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8902), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8902) },
                    { 5, 100, 100, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8903), 74, 1, new DateTime(2024, 2, 13, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8904), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8903) },
                    { 6, 80, 80, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8905), 13, 1, new DateTime(2024, 2, 10, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8906), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8905) },
                    { 7, 85, 90, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8907), 62, 9, new DateTime(2024, 2, 11, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8908), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8907) },
                    { 8, 54, 60, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8908), 23, 5, new DateTime(2024, 2, 16, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8909), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8909) },
                    { 9, 90, 90, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8910), 31, 5, new DateTime(2024, 2, 9, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8911), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8910) },
                    { 10, 50, 50, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8912), 48, 5, new DateTime(2024, 2, 12, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8913), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8912) },
                    { 11, 87, 90, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8913), 80, 7, new DateTime(2024, 2, 14, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8914), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8914) },
                    { 12, 46, 50, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8915), 70, 9, new DateTime(2024, 2, 16, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8915), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8915) },
                    { 13, 100, 100, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8916), 55, 7, new DateTime(2024, 2, 13, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8917), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8916) },
                    { 14, 30, 30, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8917), 3, 5, new DateTime(2024, 2, 11, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8918), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8918) },
                    { 15, 87, 90, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8919), 53, 3, new DateTime(2024, 2, 13, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8919), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8919) },
                    { 16, 30, 30, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8920), 35, 8, new DateTime(2024, 2, 15, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8920) },
                    { 17, 52, 60, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8921), 72, 3, new DateTime(2024, 2, 11, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8922), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8921) },
                    { 18, 50, 50, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8923), 45, 6, new DateTime(2024, 2, 13, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8924), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8924) },
                    { 19, 62, 70, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8925), 24, 7, new DateTime(2024, 2, 13, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8925), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8925) },
                    { 20, 100, 100, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8926), 6, 7, new DateTime(2024, 2, 9, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8927), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8926) },
                    { 21, 57, 60, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8927), 4, 6, new DateTime(2024, 2, 9, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8928), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8927) },
                    { 22, 30, 30, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8929), 31, 7, new DateTime(2024, 2, 16, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8929), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8929) },
                    { 23, 22, 30, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8930), 63, 7, new DateTime(2024, 2, 8, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8931), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8930) },
                    { 24, 78, 80, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8931), 53, 6, new DateTime(2024, 2, 9, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8932), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8931) },
                    { 25, 8, 10, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8932), 66, 7, new DateTime(2024, 2, 9, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8933), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8933) },
                    { 26, 76, 80, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8934), 86, 5, new DateTime(2024, 2, 12, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8934), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8934) },
                    { 27, 72, 80, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8935), 26, 7, new DateTime(2024, 2, 13, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8936), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8935) },
                    { 28, 87, 90, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8936), 38, 3, new DateTime(2024, 2, 13, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8937), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8937) },
                    { 29, 28, 30, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8938), 27, 8, new DateTime(2024, 2, 12, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8938), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8938) },
                    { 30, 9, 10, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8939), 80, 3, new DateTime(2024, 2, 10, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8940), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8939) },
                    { 31, 24, 30, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8940), 73, 1, new DateTime(2024, 2, 16, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8941), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8940) },
                    { 32, 10, 10, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8941), 88, 5, new DateTime(2024, 2, 13, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8942), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8942) },
                    { 33, 59, 60, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8943), 35, 1, new DateTime(2024, 2, 12, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8943), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8943) },
                    { 34, 85, 90, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8945), 68, 8, new DateTime(2024, 2, 15, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8945), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8945) },
                    { 35, 80, 80, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8946), 86, 5, new DateTime(2024, 2, 15, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8947), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8946) },
                    { 36, 88, 90, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8947), 97, 7, new DateTime(2024, 2, 15, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8948), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8948) },
                    { 37, 89, 90, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8949), 47, 9, new DateTime(2024, 2, 15, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8949), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8949) },
                    { 38, 100, 100, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8950), 94, 6, new DateTime(2024, 2, 10, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8951), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8950) },
                    { 39, 22, 30, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8951), 2, 6, new DateTime(2024, 2, 14, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8952), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8952) },
                    { 40, 60, 70, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8953), 45, 9, new DateTime(2024, 2, 9, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8953), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8953) },
                    { 41, 76, 80, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8954), 21, 4, new DateTime(2024, 2, 10, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8955), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8954) },
                    { 42, 64, 70, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8955), 89, 6, new DateTime(2024, 2, 10, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8956), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8955) },
                    { 43, 50, 50, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8957), 23, 7, new DateTime(2024, 2, 8, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8957), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8957) },
                    { 44, 30, 30, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8958), 10, 2, new DateTime(2024, 2, 8, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8959), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8958) },
                    { 45, 63, 70, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8959), 59, 6, new DateTime(2024, 2, 14, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8960), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8959) },
                    { 46, 29, 30, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8961), 84, 5, new DateTime(2024, 2, 13, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8961), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8961) },
                    { 47, 30, 30, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8962), 55, 3, new DateTime(2024, 2, 8, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8963), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8962) },
                    { 48, 68, 70, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8963), 18, 9, new DateTime(2024, 2, 12, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8964), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8963) },
                    { 49, 47, 50, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8964), 28, 7, new DateTime(2024, 2, 9, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8965), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8965) },
                    { 50, 96, 100, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8966), 45, 9, new DateTime(2024, 2, 13, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8966), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8966) },
                    { 51, 6, 10, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8967), 20, 7, new DateTime(2024, 2, 9, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8968), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8967) },
                    { 52, 10, 10, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8968), 81, 7, new DateTime(2024, 2, 16, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8969), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8968) },
                    { 53, 30, 30, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8970), 96, 4, new DateTime(2024, 2, 13, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8970), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8970) },
                    { 54, 24, 30, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8971), 4, 3, new DateTime(2024, 2, 10, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8972), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8971) },
                    { 55, 79, 80, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8972), 80, 7, new DateTime(2024, 2, 10, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8973), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8972) },
                    { 56, 48, 50, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8974), 46, 5, new DateTime(2024, 2, 10, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8974), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8974) },
                    { 57, 63, 70, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8975), 72, 3, new DateTime(2024, 2, 15, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8975), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8975) },
                    { 58, 89, 90, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8976), 66, 1, new DateTime(2024, 2, 11, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8977), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8976) },
                    { 59, 46, 50, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8977), 19, 6, new DateTime(2024, 2, 11, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8978), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8978) },
                    { 60, 70, 70, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8979), 70, 3, new DateTime(2024, 2, 15, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8979), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8979) },
                    { 61, 60, 60, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8980), 80, 7, new DateTime(2024, 2, 9, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8981), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8980) },
                    { 62, 48, 50, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8981), 15, 2, new DateTime(2024, 2, 13, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8982), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8981) },
                    { 63, 30, 30, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8982), 29, 1, new DateTime(2024, 2, 14, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8983), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8983) },
                    { 64, 65, 70, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8984), 57, 5, new DateTime(2024, 2, 16, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9003), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(8984) },
                    { 65, 78, 80, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9004), 53, 1, new DateTime(2024, 2, 16, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9006), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9005) },
                    { 66, 59, 60, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9007), 56, 3, new DateTime(2024, 2, 11, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9008), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9007) },
                    { 67, 46, 50, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9008), 88, 9, new DateTime(2024, 2, 10, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9009), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9009) },
                    { 68, 94, 100, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9010), 43, 9, new DateTime(2024, 2, 14, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9011), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9010) },
                    { 69, 76, 80, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9012), 15, 2, new DateTime(2024, 2, 15, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9013), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9012) },
                    { 70, 50, 50, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9013), 18, 7, new DateTime(2024, 2, 15, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9014), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9014) },
                    { 71, 49, 50, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9015), 40, 4, new DateTime(2024, 2, 13, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9016), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9015) },
                    { 72, 29, 30, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9016), 20, 3, new DateTime(2024, 2, 15, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9017), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9016) },
                    { 73, 70, 70, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9018), 12, 3, new DateTime(2024, 2, 13, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9018), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9018) },
                    { 74, 8, 10, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9019), 30, 9, new DateTime(2024, 2, 16, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9020), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9019) },
                    { 75, 80, 80, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9020), 2, 4, new DateTime(2024, 2, 9, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9021), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9020) },
                    { 76, 45, 50, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9021), 25, 5, new DateTime(2024, 2, 10, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9022), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9022) },
                    { 77, 63, 70, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9023), 78, 4, new DateTime(2024, 2, 10, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9023), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9023) },
                    { 78, 70, 70, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9024), 81, 8, new DateTime(2024, 2, 9, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9025), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9024) },
                    { 79, 46, 50, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9025), 91, 5, new DateTime(2024, 2, 13, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9026), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9025) },
                    { 80, 30, 30, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9027), 7, 8, new DateTime(2024, 2, 14, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9027), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9027) },
                    { 81, 73, 80, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9028), 4, 3, new DateTime(2024, 2, 12, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9029), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9028) },
                    { 82, 2, 10, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9029), 74, 1, new DateTime(2024, 2, 9, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9030), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9029) },
                    { 83, 67, 70, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9030), 59, 7, new DateTime(2024, 2, 12, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9031), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9031) },
                    { 84, 8, 10, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9032), 10, 7, new DateTime(2024, 2, 15, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9032), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9032) },
                    { 85, 56, 60, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9033), 80, 4, new DateTime(2024, 2, 16, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9034), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9033) },
                    { 86, 86, 90, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9034), 54, 2, new DateTime(2024, 2, 8, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9035), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9035) },
                    { 87, 69, 70, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9036), 41, 7, new DateTime(2024, 2, 8, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9036), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9036) },
                    { 88, 94, 100, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9037), 60, 7, new DateTime(2024, 2, 8, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9038), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9037) },
                    { 89, 70, 70, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9038), 95, 6, new DateTime(2024, 2, 14, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9039), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9038) },
                    { 90, 6, 10, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9039), 62, 7, new DateTime(2024, 2, 9, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9040), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9040) },
                    { 91, 60, 60, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9041), 86, 7, new DateTime(2024, 2, 8, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9041), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9041) },
                    { 92, 7, 10, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9042), 81, 2, new DateTime(2024, 2, 13, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9043), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9042) },
                    { 93, 70, 70, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9043), 10, 6, new DateTime(2024, 2, 12, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9044), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9044) },
                    { 94, 10, 10, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9045), 8, 6, new DateTime(2024, 2, 13, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9046), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9045) },
                    { 95, 100, 100, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9046), 55, 6, new DateTime(2024, 2, 10, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9047), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9046) },
                    { 96, 25, 30, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9047), 14, 1, new DateTime(2024, 2, 9, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9048), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9048) },
                    { 97, 73, 80, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9049), 2, 6, new DateTime(2024, 2, 15, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9049), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9049) },
                    { 98, 8, 10, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9050), 46, 1, new DateTime(2024, 2, 15, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9051), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9050) },
                    { 99, 70, 70, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9051), 93, 1, new DateTime(2024, 2, 8, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9052), new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9052) }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9058), 29, 2, 41, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9059) },
                    { 2, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9079), 1, 3, 54, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9079) },
                    { 3, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9087), 95, 4, 42, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9087) },
                    { 4, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9093), 95, 1, 30, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9094) },
                    { 5, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9098), 82, 4, 19, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9098) },
                    { 6, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9103), 67, 3, 64, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9103) },
                    { 7, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9112), 82, 3, 28, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9112) },
                    { 8, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9116), 73, 2, 85, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9117) },
                    { 9, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9128), 28, 2, 68, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9128) },
                    { 10, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9138), 34, 2, 59, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9138) },
                    { 11, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9147), 15, 1, 58, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9147) },
                    { 12, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9155), 78, 1, 72, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9155) },
                    { 13, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9165), 94, 1, 46, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9165) },
                    { 14, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9172), 72, 4, 45, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9172) },
                    { 15, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9178), 63, 1, 40, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9178) },
                    { 16, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9206), 69, 3, 81, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9206) },
                    { 17, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9218), 4, 4, 82, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9218) },
                    { 18, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9230), 68, 2, 64, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9230) },
                    { 19, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9239), 90, 4, 2, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9239) },
                    { 20, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9240), 97, 3, 77, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9241) },
                    { 21, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9251), 76, 1, 48, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9251) },
                    { 22, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9258), 90, 2, 98, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9259) },
                    { 23, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9271), 87, 2, 97, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9272) },
                    { 24, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9285), 10, 4, 8, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9285) },
                    { 25, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9287), 3, 2, 85, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9287) },
                    { 26, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9299), 42, 1, 71, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9299) },
                    { 27, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9308), 12, 2, 62, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9309) },
                    { 28, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9317), 56, 1, 37, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9317) },
                    { 29, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9323), 49, 3, 27, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9323) },
                    { 30, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9327), 53, 2, 40, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9328) },
                    { 31, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9333), 40, 4, 88, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9334) },
                    { 32, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9345), 48, 4, 67, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9346) },
                    { 33, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9355), 71, 2, 86, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9355) },
                    { 34, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9367), 23, 2, 86, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9368) },
                    { 35, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9379), 66, 2, 8, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9380) },
                    { 36, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9382), 32, 4, 81, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9382) },
                    { 37, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9393), 23, 4, 68, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9393) },
                    { 38, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9402), 59, 4, 51, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9402) },
                    { 39, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9410), 34, 2, 34, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9410) },
                    { 40, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9415), 83, 2, 15, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9415) },
                    { 41, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9418), 30, 3, 31, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9418) },
                    { 42, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9423), 93, 3, 92, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9423) },
                    { 43, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9435), 66, 2, 7, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9436) },
                    { 44, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9438), 22, 2, 56, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9438) },
                    { 45, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9446), 75, 4, 12, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9446) },
                    { 46, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9448), 91, 2, 7, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9449) },
                    { 47, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9450), 70, 1, 15, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9451) },
                    { 48, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9454), 51, 3, 39, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9454) },
                    { 49, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9460), 25, 3, 27, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9460) },
                    { 50, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9464), 90, 4, 26, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9464) },
                    { 51, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9468), 44, 2, 27, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9469) },
                    { 52, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9473), 9, 1, 7, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9473) },
                    { 53, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9475), 51, 3, 96, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9475) },
                    { 54, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9488), 11, 3, 57, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9488) },
                    { 55, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9516), 73, 2, 84, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9516) },
                    { 56, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9527), 92, 4, 50, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9528) },
                    { 57, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9535), 66, 4, 17, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9535) },
                    { 58, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9538), 50, 3, 40, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9538) },
                    { 59, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9544), 20, 4, 97, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9544) },
                    { 60, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9557), 23, 2, 36, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9557) },
                    { 61, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9563), 45, 1, 33, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9563) },
                    { 62, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9568), 91, 2, 25, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9568) },
                    { 63, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9572), 11, 1, 97, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9572) },
                    { 64, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9585), 51, 2, 24, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9585) },
                    { 65, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9589), 4, 2, 29, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9590) },
                    { 66, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9595), 32, 2, 39, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9595) },
                    { 67, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9601), 56, 4, 79, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9601) },
                    { 68, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9611), 19, 3, 34, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9612) },
                    { 69, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9617), 25, 2, 74, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9617) },
                    { 70, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9627), 49, 1, 48, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9627) },
                    { 71, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9634), 42, 4, 40, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9634) },
                    { 72, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9640), 43, 4, 17, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9641) },
                    { 73, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9644), 81, 1, 87, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9644) },
                    { 74, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9655), 75, 2, 42, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9656) },
                    { 75, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9662), 3, 2, 96, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9662) },
                    { 76, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9675), 25, 3, 39, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9675) },
                    { 77, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9681), 21, 4, 82, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9681) },
                    { 78, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9692), 89, 4, 57, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9692) },
                    { 79, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9700), 81, 4, 69, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9701) },
                    { 80, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9710), 60, 4, 23, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9710) },
                    { 81, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9714), 94, 2, 76, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9714) },
                    { 82, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9724), 14, 4, 23, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9725) },
                    { 83, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9728), 67, 3, 11, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9729) },
                    { 84, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9731), 75, 4, 90, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9731) },
                    { 85, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9743), 53, 2, 41, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9743) },
                    { 86, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9749), 44, 3, 31, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9749) },
                    { 87, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9754), 98, 3, 54, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9754) },
                    { 88, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9777), 22, 1, 55, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9777) },
                    { 89, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9786), 35, 2, 65, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9786) },
                    { 90, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9796), 69, 1, 66, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9796) },
                    { 91, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9806), 45, 2, 59, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9806) },
                    { 92, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9955), 45, 3, 76, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9955) },
                    { 93, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9967), 62, 3, 21, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9967) },
                    { 94, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9971), 25, 3, 49, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9971) },
                    { 95, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9979), 11, 4, 77, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9979) },
                    { 96, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9991), 90, 4, 19, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9991) },
                    { 97, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9995), 42, 2, 88, new DateTime(2024, 2, 7, 14, 12, 11, 405, DateTimeKind.Utc).AddTicks(9995) },
                    { 98, new DateTime(2024, 2, 7, 14, 12, 11, 406, DateTimeKind.Utc).AddTicks(8), 45, 3, 45, new DateTime(2024, 2, 7, 14, 12, 11, 406, DateTimeKind.Utc).AddTicks(8) },
                    { 99, new DateTime(2024, 2, 7, 14, 12, 11, 406, DateTimeKind.Utc).AddTicks(15), 33, 3, 83, new DateTime(2024, 2, 7, 14, 12, 11, 406, DateTimeKind.Utc).AddTicks(15) }
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
                name: "tickets");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "screenings");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
