using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "movie",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<string>(type: "text", nullable: false),
                    runtime = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movie", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "screening",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    statsAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    screenNumber = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    movie_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screening", x => x.id);
                    table.ForeignKey(
                        name: "FK_screening_movie_movie_id",
                        column: x => x.movie_id,
                        principalTable: "movie",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customer",
                columns: new[] { "id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 7, 14, 52, 52, 448, DateTimeKind.Utc).AddTicks(4098), "DavidWilson74@yahoo.com", "David Wilson", "710.211.7464 x5831", new DateTime(2024, 2, 7, 14, 52, 52, 448, DateTimeKind.Utc).AddTicks(4100) },
                    { 2, new DateTime(2024, 2, 7, 14, 52, 52, 452, DateTimeKind.Utc).AddTicks(8545), "DanielGarcia19@hotmail.com", "Daniel Garcia", "1-578-969-4168", new DateTime(2024, 2, 7, 14, 52, 52, 452, DateTimeKind.Utc).AddTicks(8548) },
                    { 3, new DateTime(2024, 2, 7, 14, 52, 52, 456, DateTimeKind.Utc).AddTicks(6902), "EmilyJohnson24@yahoo.com", "Emily Johnson", "246.397.7688 x0560", new DateTime(2024, 2, 7, 14, 52, 52, 456, DateTimeKind.Utc).AddTicks(6906) },
                    { 4, new DateTime(2024, 2, 7, 14, 52, 52, 460, DateTimeKind.Utc).AddTicks(7834), "EmilyRodriguez.Marquardt12@yahoo.com", "Emily Rodriguez", "785-609-0856 x45051", new DateTime(2024, 2, 7, 14, 52, 52, 460, DateTimeKind.Utc).AddTicks(7839) },
                    { 5, new DateTime(2024, 2, 7, 14, 52, 52, 464, DateTimeKind.Utc).AddTicks(7105), "SarahSmith79@yahoo.com", "Sarah Smith", "1-956-855-8440 x0510", new DateTime(2024, 2, 7, 14, 52, 52, 464, DateTimeKind.Utc).AddTicks(7109) },
                    { 6, new DateTime(2024, 2, 7, 14, 52, 52, 468, DateTimeKind.Utc).AddTicks(2368), "DavidDavis47@hotmail.com", "David Davis", "(644) 419-0165 x4308", new DateTime(2024, 2, 7, 14, 52, 52, 468, DateTimeKind.Utc).AddTicks(2372) },
                    { 7, new DateTime(2024, 2, 7, 14, 52, 52, 471, DateTimeKind.Utc).AddTicks(6217), "MatthewMiller.MacGyver@gmail.com", "Matthew Miller", "(663) 308-3131 x154", new DateTime(2024, 2, 7, 14, 52, 52, 471, DateTimeKind.Utc).AddTicks(6219) },
                    { 8, new DateTime(2024, 2, 7, 14, 52, 52, 473, DateTimeKind.Utc).AddTicks(9931), "MatthewJohnson_Wolf@gmail.com", "Matthew Johnson", "(217) 805-0465 x81173", new DateTime(2024, 2, 7, 14, 52, 52, 473, DateTimeKind.Utc).AddTicks(9934) },
                    { 9, new DateTime(2024, 2, 7, 14, 52, 52, 476, DateTimeKind.Utc).AddTicks(9421), "JaneRodriguez_Wolff1@gmail.com", "Jane Rodriguez", "555.993.1288 x0139", new DateTime(2024, 2, 7, 14, 52, 52, 476, DateTimeKind.Utc).AddTicks(9423) },
                    { 10, new DateTime(2024, 2, 7, 14, 52, 52, 481, DateTimeKind.Utc).AddTicks(6227), "SarahWilson36@yahoo.com", "Sarah Wilson", "399.898.4242 x007", new DateTime(2024, 2, 7, 14, 52, 52, 481, DateTimeKind.Utc).AddTicks(6232) },
                    { 11, new DateTime(2024, 2, 7, 14, 52, 52, 484, DateTimeKind.Utc).AddTicks(712), "MatthewRodriguez.Brown@yahoo.com", "Matthew Rodriguez", "(798) 253-0559", new DateTime(2024, 2, 7, 14, 52, 52, 484, DateTimeKind.Utc).AddTicks(715) },
                    { 12, new DateTime(2024, 2, 7, 14, 52, 52, 488, DateTimeKind.Utc).AddTicks(3427), "DanielWilson.Sporer@yahoo.com", "Daniel Wilson", "1-530-538-5803", new DateTime(2024, 2, 7, 14, 52, 52, 488, DateTimeKind.Utc).AddTicks(3431) },
                    { 13, new DateTime(2024, 2, 7, 14, 52, 52, 491, DateTimeKind.Utc).AddTicks(4855), "JessicaWilson_Kovacek@yahoo.com", "Jessica Wilson", "1-917-441-6772 x60157", new DateTime(2024, 2, 7, 14, 52, 52, 491, DateTimeKind.Utc).AddTicks(4860) },
                    { 14, new DateTime(2024, 2, 7, 14, 52, 52, 493, DateTimeKind.Utc).AddTicks(9686), "JessicaDavis59@yahoo.com", "Jessica Davis", "(879) 895-3646", new DateTime(2024, 2, 7, 14, 52, 52, 493, DateTimeKind.Utc).AddTicks(9689) },
                    { 15, new DateTime(2024, 2, 7, 14, 52, 52, 496, DateTimeKind.Utc).AddTicks(5899), "MatthewJohnson_Pouros@hotmail.com", "Matthew Johnson", "(588) 677-7341", new DateTime(2024, 2, 7, 14, 52, 52, 496, DateTimeKind.Utc).AddTicks(5902) },
                    { 16, new DateTime(2024, 2, 7, 14, 52, 52, 500, DateTimeKind.Utc).AddTicks(254), "DavidBrown29@hotmail.com", "David Brown", "(825) 348-8572", new DateTime(2024, 2, 7, 14, 52, 52, 500, DateTimeKind.Utc).AddTicks(257) },
                    { 17, new DateTime(2024, 2, 7, 14, 52, 52, 504, DateTimeKind.Utc).AddTicks(2809), "DanielDavis99@hotmail.com", "Daniel Davis", "944.624.7729 x36669", new DateTime(2024, 2, 7, 14, 52, 52, 504, DateTimeKind.Utc).AddTicks(2812) },
                    { 18, new DateTime(2024, 2, 7, 14, 52, 52, 507, DateTimeKind.Utc).AddTicks(7024), "JohnDavis16@yahoo.com", "John Davis", "(266) 792-5775", new DateTime(2024, 2, 7, 14, 52, 52, 507, DateTimeKind.Utc).AddTicks(7027) },
                    { 19, new DateTime(2024, 2, 7, 14, 52, 52, 511, DateTimeKind.Utc).AddTicks(699), "JessicaWilliams_Boehm@yahoo.com", "Jessica Williams", "663.831.0035", new DateTime(2024, 2, 7, 14, 52, 52, 511, DateTimeKind.Utc).AddTicks(701) },
                    { 20, new DateTime(2024, 2, 7, 14, 52, 52, 514, DateTimeKind.Utc).AddTicks(987), "DavidJones_Hahn@hotmail.com", "David Jones", "(824) 241-9006 x235", new DateTime(2024, 2, 7, 14, 52, 52, 514, DateTimeKind.Utc).AddTicks(990) },
                    { 21, new DateTime(2024, 2, 7, 14, 52, 52, 517, DateTimeKind.Utc).AddTicks(1604), "SarahJones93@gmail.com", "Sarah Jones", "694.418.1668 x3560", new DateTime(2024, 2, 7, 14, 52, 52, 517, DateTimeKind.Utc).AddTicks(1608) },
                    { 22, new DateTime(2024, 2, 7, 14, 52, 52, 519, DateTimeKind.Utc).AddTicks(7362), "DavidGarcia40@gmail.com", "David Garcia", "673-538-8957", new DateTime(2024, 2, 7, 14, 52, 52, 519, DateTimeKind.Utc).AddTicks(7364) },
                    { 23, new DateTime(2024, 2, 7, 14, 52, 52, 523, DateTimeKind.Utc).AddTicks(5800), "JohnMiller_Von40@hotmail.com", "John Miller", "(843) 644-9635", new DateTime(2024, 2, 7, 14, 52, 52, 523, DateTimeKind.Utc).AddTicks(5804) },
                    { 24, new DateTime(2024, 2, 7, 14, 52, 52, 527, DateTimeKind.Utc).AddTicks(1923), "JenniferGarcia.Pfeffer54@yahoo.com", "Jennifer Garcia", "445-381-1628 x219", new DateTime(2024, 2, 7, 14, 52, 52, 527, DateTimeKind.Utc).AddTicks(1926) },
                    { 25, new DateTime(2024, 2, 7, 14, 52, 52, 531, DateTimeKind.Utc).AddTicks(5220), "DanielMiller.Macejkovic@yahoo.com", "Daniel Miller", "(414) 567-3699 x723", new DateTime(2024, 2, 7, 14, 52, 52, 531, DateTimeKind.Utc).AddTicks(5225) },
                    { 26, new DateTime(2024, 2, 7, 14, 52, 52, 533, DateTimeKind.Utc).AddTicks(9513), "MatthewWilson.Bahringer88@yahoo.com", "Matthew Wilson", "552-583-3493 x11949", new DateTime(2024, 2, 7, 14, 52, 52, 533, DateTimeKind.Utc).AddTicks(9516) },
                    { 27, new DateTime(2024, 2, 7, 14, 52, 52, 536, DateTimeKind.Utc).AddTicks(4100), "DanielWilson.Feest@yahoo.com", "Daniel Wilson", "1-926-813-7747 x90712", new DateTime(2024, 2, 7, 14, 52, 52, 536, DateTimeKind.Utc).AddTicks(4103) },
                    { 28, new DateTime(2024, 2, 7, 14, 52, 52, 538, DateTimeKind.Utc).AddTicks(9964), "JessicaWilson_Upton@hotmail.com", "Jessica Wilson", "994-596-6228 x059", new DateTime(2024, 2, 7, 14, 52, 52, 538, DateTimeKind.Utc).AddTicks(9967) },
                    { 29, new DateTime(2024, 2, 7, 14, 52, 52, 541, DateTimeKind.Utc).AddTicks(5186), "JenniferMiller.Abernathy@yahoo.com", "Jennifer Miller", "1-475-347-8904 x075", new DateTime(2024, 2, 7, 14, 52, 52, 541, DateTimeKind.Utc).AddTicks(5189) },
                    { 30, new DateTime(2024, 2, 7, 14, 52, 52, 543, DateTimeKind.Utc).AddTicks(9078), "JenniferRodriguez2@gmail.com", "Jennifer Rodriguez", "831.501.5629 x05684", new DateTime(2024, 2, 7, 14, 52, 52, 543, DateTimeKind.Utc).AddTicks(9082) },
                    { 31, new DateTime(2024, 2, 7, 14, 52, 52, 546, DateTimeKind.Utc).AddTicks(2368), "MichaelJones55@hotmail.com", "Michael Jones", "436-472-0757", new DateTime(2024, 2, 7, 14, 52, 52, 546, DateTimeKind.Utc).AddTicks(2371) },
                    { 32, new DateTime(2024, 2, 7, 14, 52, 52, 551, DateTimeKind.Utc).AddTicks(2219), "MatthewGarcia_Watsica84@hotmail.com", "Matthew Garcia", "1-965-790-1314 x088", new DateTime(2024, 2, 7, 14, 52, 52, 551, DateTimeKind.Utc).AddTicks(2224) },
                    { 33, new DateTime(2024, 2, 7, 14, 52, 52, 556, DateTimeKind.Utc).AddTicks(518), "JenniferWilliams_Bogisich@hotmail.com", "Jennifer Williams", "1-793-888-7617", new DateTime(2024, 2, 7, 14, 52, 52, 556, DateTimeKind.Utc).AddTicks(522) },
                    { 34, new DateTime(2024, 2, 7, 14, 52, 52, 560, DateTimeKind.Utc).AddTicks(7224), "MichaelJohnson77@yahoo.com", "Michael Johnson", "1-362-371-7336 x9367", new DateTime(2024, 2, 7, 14, 52, 52, 560, DateTimeKind.Utc).AddTicks(7228) },
                    { 35, new DateTime(2024, 2, 7, 14, 52, 52, 566, DateTimeKind.Utc).AddTicks(3005), "DanielBrown_Pollich53@gmail.com", "Daniel Brown", "(484) 988-5397", new DateTime(2024, 2, 7, 14, 52, 52, 566, DateTimeKind.Utc).AddTicks(3011) },
                    { 36, new DateTime(2024, 2, 7, 14, 52, 52, 570, DateTimeKind.Utc).AddTicks(8356), "JenniferJohnson.Orn30@hotmail.com", "Jennifer Johnson", "856.399.9240 x370", new DateTime(2024, 2, 7, 14, 52, 52, 570, DateTimeKind.Utc).AddTicks(8359) },
                    { 37, new DateTime(2024, 2, 7, 14, 52, 52, 575, DateTimeKind.Utc).AddTicks(2483), "JessicaWilson.Rowe@gmail.com", "Jessica Wilson", "696-413-2734", new DateTime(2024, 2, 7, 14, 52, 52, 575, DateTimeKind.Utc).AddTicks(2487) },
                    { 38, new DateTime(2024, 2, 7, 14, 52, 52, 580, DateTimeKind.Utc).AddTicks(3196), "JenniferWilliams.Douglas30@gmail.com", "Jennifer Williams", "553-255-1438", new DateTime(2024, 2, 7, 14, 52, 52, 580, DateTimeKind.Utc).AddTicks(3202) },
                    { 39, new DateTime(2024, 2, 7, 14, 52, 52, 583, DateTimeKind.Utc).AddTicks(3398), "JaneWilliams71@hotmail.com", "Jane Williams", "390-328-6466", new DateTime(2024, 2, 7, 14, 52, 52, 583, DateTimeKind.Utc).AddTicks(3404) },
                    { 40, new DateTime(2024, 2, 7, 14, 52, 52, 587, DateTimeKind.Utc).AddTicks(8589), "MatthewJones.Schaefer27@gmail.com", "Matthew Jones", "(312) 633-7599 x7756", new DateTime(2024, 2, 7, 14, 52, 52, 587, DateTimeKind.Utc).AddTicks(8593) },
                    { 41, new DateTime(2024, 2, 7, 14, 52, 52, 591, DateTimeKind.Utc).AddTicks(8814), "EmilyDavis_Rath88@hotmail.com", "Emily Davis", "991.417.7023 x84340", new DateTime(2024, 2, 7, 14, 52, 52, 591, DateTimeKind.Utc).AddTicks(8820) },
                    { 42, new DateTime(2024, 2, 7, 14, 52, 52, 596, DateTimeKind.Utc).AddTicks(2835), "MatthewSmith.Von@hotmail.com", "Matthew Smith", "878.237.1885 x1319", new DateTime(2024, 2, 7, 14, 52, 52, 596, DateTimeKind.Utc).AddTicks(2840) },
                    { 43, new DateTime(2024, 2, 7, 14, 52, 52, 598, DateTimeKind.Utc).AddTicks(8550), "DanielJohnson30@hotmail.com", "Daniel Johnson", "1-376-613-0439", new DateTime(2024, 2, 7, 14, 52, 52, 598, DateTimeKind.Utc).AddTicks(8554) },
                    { 44, new DateTime(2024, 2, 7, 14, 52, 52, 601, DateTimeKind.Utc).AddTicks(3280), "JaneJones_Kertzmann8@yahoo.com", "Jane Jones", "1-214-315-9886 x36844", new DateTime(2024, 2, 7, 14, 52, 52, 601, DateTimeKind.Utc).AddTicks(3287) },
                    { 45, new DateTime(2024, 2, 7, 14, 52, 52, 603, DateTimeKind.Utc).AddTicks(5717), "MichaelBrown79@yahoo.com", "Michael Brown", "946-511-5634", new DateTime(2024, 2, 7, 14, 52, 52, 603, DateTimeKind.Utc).AddTicks(5720) },
                    { 46, new DateTime(2024, 2, 7, 14, 52, 52, 606, DateTimeKind.Utc).AddTicks(7221), "DavidRodriguez.Denesik@gmail.com", "David Rodriguez", "810.493.6078", new DateTime(2024, 2, 7, 14, 52, 52, 606, DateTimeKind.Utc).AddTicks(7224) },
                    { 47, new DateTime(2024, 2, 7, 14, 52, 52, 610, DateTimeKind.Utc).AddTicks(4091), "DavidMiller82@gmail.com", "David Miller", "1-396-281-9911", new DateTime(2024, 2, 7, 14, 52, 52, 610, DateTimeKind.Utc).AddTicks(4095) },
                    { 48, new DateTime(2024, 2, 7, 14, 52, 52, 614, DateTimeKind.Utc).AddTicks(5503), "DanielDavis.Mann@gmail.com", "Daniel Davis", "425.876.2461 x911", new DateTime(2024, 2, 7, 14, 52, 52, 614, DateTimeKind.Utc).AddTicks(5504) },
                    { 49, new DateTime(2024, 2, 7, 14, 52, 52, 618, DateTimeKind.Utc).AddTicks(6398), "JohnSmith.Collier@hotmail.com", "John Smith", "419-991-2910", new DateTime(2024, 2, 7, 14, 52, 52, 618, DateTimeKind.Utc).AddTicks(6401) },
                    { 50, new DateTime(2024, 2, 7, 14, 52, 52, 622, DateTimeKind.Utc).AddTicks(7337), "DavidWilson52@yahoo.com", "David Wilson", "441-308-2759", new DateTime(2024, 2, 7, 14, 52, 52, 622, DateTimeKind.Utc).AddTicks(7339) },
                    { 51, new DateTime(2024, 2, 7, 14, 52, 52, 635, DateTimeKind.Utc).AddTicks(9865), "JenniferGarcia.Herman@yahoo.com", "Jennifer Garcia", "1-273-632-4031", new DateTime(2024, 2, 7, 14, 52, 52, 635, DateTimeKind.Utc).AddTicks(9870) },
                    { 52, new DateTime(2024, 2, 7, 14, 52, 52, 638, DateTimeKind.Utc).AddTicks(5936), "JenniferWilson43@hotmail.com", "Jennifer Wilson", "(667) 422-3309", new DateTime(2024, 2, 7, 14, 52, 52, 638, DateTimeKind.Utc).AddTicks(5938) },
                    { 53, new DateTime(2024, 2, 7, 14, 52, 52, 641, DateTimeKind.Utc).AddTicks(1531), "JaneJohnson83@hotmail.com", "Jane Johnson", "1-434-299-8569 x8069", new DateTime(2024, 2, 7, 14, 52, 52, 641, DateTimeKind.Utc).AddTicks(1534) },
                    { 54, new DateTime(2024, 2, 7, 14, 52, 52, 643, DateTimeKind.Utc).AddTicks(6763), "JaneWilliams.Gaylord47@gmail.com", "Jane Williams", "(705) 908-0438 x53567", new DateTime(2024, 2, 7, 14, 52, 52, 643, DateTimeKind.Utc).AddTicks(6766) },
                    { 55, new DateTime(2024, 2, 7, 14, 52, 52, 646, DateTimeKind.Utc).AddTicks(122), "JenniferSmith.Braun30@hotmail.com", "Jennifer Smith", "450.987.7237 x5469", new DateTime(2024, 2, 7, 14, 52, 52, 646, DateTimeKind.Utc).AddTicks(124) },
                    { 56, new DateTime(2024, 2, 7, 14, 52, 52, 649, DateTimeKind.Utc).AddTicks(3448), "EmilyJohnson73@hotmail.com", "Emily Johnson", "545.571.6034", new DateTime(2024, 2, 7, 14, 52, 52, 649, DateTimeKind.Utc).AddTicks(3452) },
                    { 57, new DateTime(2024, 2, 7, 14, 52, 52, 653, DateTimeKind.Utc).AddTicks(1372), "JessicaMiller.Hamill65@yahoo.com", "Jessica Miller", "698.457.9932 x768", new DateTime(2024, 2, 7, 14, 52, 52, 653, DateTimeKind.Utc).AddTicks(1376) },
                    { 58, new DateTime(2024, 2, 7, 14, 52, 52, 656, DateTimeKind.Utc).AddTicks(3751), "SarahMiller_Ledner@gmail.com", "Sarah Miller", "295.644.0395 x73497", new DateTime(2024, 2, 7, 14, 52, 52, 656, DateTimeKind.Utc).AddTicks(3756) },
                    { 59, new DateTime(2024, 2, 7, 14, 52, 52, 659, DateTimeKind.Utc).AddTicks(6493), "DanielJones32@gmail.com", "Daniel Jones", "1-658-632-5816", new DateTime(2024, 2, 7, 14, 52, 52, 659, DateTimeKind.Utc).AddTicks(6497) },
                    { 60, new DateTime(2024, 2, 7, 14, 52, 52, 662, DateTimeKind.Utc).AddTicks(1017), "JessicaBrown.Koepp@hotmail.com", "Jessica Brown", "1-203-707-0639", new DateTime(2024, 2, 7, 14, 52, 52, 662, DateTimeKind.Utc).AddTicks(1019) },
                    { 61, new DateTime(2024, 2, 7, 14, 52, 52, 664, DateTimeKind.Utc).AddTicks(6517), "JaneRodriguez.Braun78@yahoo.com", "Jane Rodriguez", "(845) 570-0663 x4317", new DateTime(2024, 2, 7, 14, 52, 52, 664, DateTimeKind.Utc).AddTicks(6520) },
                    { 62, new DateTime(2024, 2, 7, 14, 52, 52, 667, DateTimeKind.Utc).AddTicks(2502), "MatthewSmith_Rogahn43@hotmail.com", "Matthew Smith", "1-222-585-3356", new DateTime(2024, 2, 7, 14, 52, 52, 667, DateTimeKind.Utc).AddTicks(2505) },
                    { 63, new DateTime(2024, 2, 7, 14, 52, 52, 669, DateTimeKind.Utc).AddTicks(7149), "EmilyDavis.Kshlerin18@gmail.com", "Emily Davis", "578-909-5485 x43238", new DateTime(2024, 2, 7, 14, 52, 52, 669, DateTimeKind.Utc).AddTicks(7153) },
                    { 64, new DateTime(2024, 2, 7, 14, 52, 52, 672, DateTimeKind.Utc).AddTicks(6026), "JohnJohnson_Paucek@yahoo.com", "John Johnson", "318-569-4986", new DateTime(2024, 2, 7, 14, 52, 52, 672, DateTimeKind.Utc).AddTicks(6031) },
                    { 65, new DateTime(2024, 2, 7, 14, 52, 52, 677, DateTimeKind.Utc).AddTicks(7661), "JaneMiller68@yahoo.com", "Jane Miller", "1-799-634-4788", new DateTime(2024, 2, 7, 14, 52, 52, 677, DateTimeKind.Utc).AddTicks(7674) },
                    { 66, new DateTime(2024, 2, 7, 14, 52, 52, 682, DateTimeKind.Utc).AddTicks(6168), "JessicaRodriguez58@gmail.com", "Jessica Rodriguez", "1-542-663-4098 x44713", new DateTime(2024, 2, 7, 14, 52, 52, 682, DateTimeKind.Utc).AddTicks(6173) },
                    { 67, new DateTime(2024, 2, 7, 14, 52, 52, 687, DateTimeKind.Utc).AddTicks(418), "EmilyJones19@hotmail.com", "Emily Jones", "1-752-985-9138 x30123", new DateTime(2024, 2, 7, 14, 52, 52, 687, DateTimeKind.Utc).AddTicks(422) },
                    { 68, new DateTime(2024, 2, 7, 14, 52, 52, 692, DateTimeKind.Utc).AddTicks(5412), "DavidBrown63@hotmail.com", "David Brown", "963-455-3835 x7429", new DateTime(2024, 2, 7, 14, 52, 52, 692, DateTimeKind.Utc).AddTicks(5416) },
                    { 69, new DateTime(2024, 2, 7, 14, 52, 52, 696, DateTimeKind.Utc).AddTicks(3498), "SarahSmith.Kuphal@yahoo.com", "Sarah Smith", "1-622-618-5194 x1630", new DateTime(2024, 2, 7, 14, 52, 52, 696, DateTimeKind.Utc).AddTicks(3502) },
                    { 70, new DateTime(2024, 2, 7, 14, 52, 52, 698, DateTimeKind.Utc).AddTicks(7808), "DavidWilliams_Dooley30@hotmail.com", "David Williams", "240.862.9309 x6873", new DateTime(2024, 2, 7, 14, 52, 52, 698, DateTimeKind.Utc).AddTicks(7810) },
                    { 71, new DateTime(2024, 2, 7, 14, 52, 52, 701, DateTimeKind.Utc).AddTicks(3778), "EmilyMiller_Weimann@gmail.com", "Emily Miller", "(314) 243-6108 x748", new DateTime(2024, 2, 7, 14, 52, 52, 701, DateTimeKind.Utc).AddTicks(3786) },
                    { 72, new DateTime(2024, 2, 7, 14, 52, 52, 704, DateTimeKind.Utc).AddTicks(1220), "DanielWilson.Gutkowski@yahoo.com", "Daniel Wilson", "999.633.9547 x3057", new DateTime(2024, 2, 7, 14, 52, 52, 704, DateTimeKind.Utc).AddTicks(1224) },
                    { 73, new DateTime(2024, 2, 7, 14, 52, 52, 707, DateTimeKind.Utc).AddTicks(1554), "DanielDavis.Hermiston56@yahoo.com", "Daniel Davis", "550-575-7699 x66567", new DateTime(2024, 2, 7, 14, 52, 52, 707, DateTimeKind.Utc).AddTicks(1558) },
                    { 74, new DateTime(2024, 2, 7, 14, 52, 52, 711, DateTimeKind.Utc).AddTicks(4994), "EmilyBrown37@gmail.com", "Emily Brown", "1-667-689-9026 x9690", new DateTime(2024, 2, 7, 14, 52, 52, 711, DateTimeKind.Utc).AddTicks(4996) },
                    { 75, new DateTime(2024, 2, 7, 14, 52, 52, 714, DateTimeKind.Utc).AddTicks(868), "MatthewMiller.Prosacco@yahoo.com", "Matthew Miller", "1-650-344-8178 x47515", new DateTime(2024, 2, 7, 14, 52, 52, 714, DateTimeKind.Utc).AddTicks(871) },
                    { 76, new DateTime(2024, 2, 7, 14, 52, 52, 716, DateTimeKind.Utc).AddTicks(5016), "JessicaMiller44@hotmail.com", "Jessica Miller", "619.905.0826 x412", new DateTime(2024, 2, 7, 14, 52, 52, 716, DateTimeKind.Utc).AddTicks(5018) },
                    { 77, new DateTime(2024, 2, 7, 14, 52, 52, 719, DateTimeKind.Utc).AddTicks(9487), "DanielJohnson47@gmail.com", "Daniel Johnson", "1-403-450-9875", new DateTime(2024, 2, 7, 14, 52, 52, 719, DateTimeKind.Utc).AddTicks(9492) },
                    { 78, new DateTime(2024, 2, 7, 14, 52, 52, 724, DateTimeKind.Utc).AddTicks(3766), "EmilyRodriguez_Gutmann68@hotmail.com", "Emily Rodriguez", "441.228.0154 x845", new DateTime(2024, 2, 7, 14, 52, 52, 724, DateTimeKind.Utc).AddTicks(3771) },
                    { 79, new DateTime(2024, 2, 7, 14, 52, 52, 728, DateTimeKind.Utc).AddTicks(7705), "EmilySmith26@yahoo.com", "Emily Smith", "425-352-1176 x66132", new DateTime(2024, 2, 7, 14, 52, 52, 728, DateTimeKind.Utc).AddTicks(7709) },
                    { 80, new DateTime(2024, 2, 7, 14, 52, 52, 731, DateTimeKind.Utc).AddTicks(3711), "DanielWilson24@hotmail.com", "Daniel Wilson", "(462) 520-6083", new DateTime(2024, 2, 7, 14, 52, 52, 731, DateTimeKind.Utc).AddTicks(3714) },
                    { 81, new DateTime(2024, 2, 7, 14, 52, 52, 733, DateTimeKind.Utc).AddTicks(8212), "MichaelWilliams.Kertzmann39@gmail.com", "Michael Williams", "1-455-556-8315", new DateTime(2024, 2, 7, 14, 52, 52, 733, DateTimeKind.Utc).AddTicks(8214) },
                    { 82, new DateTime(2024, 2, 7, 14, 52, 52, 747, DateTimeKind.Utc).AddTicks(1704), "JenniferJones28@yahoo.com", "Jennifer Jones", "1-557-537-8551", new DateTime(2024, 2, 7, 14, 52, 52, 747, DateTimeKind.Utc).AddTicks(1708) },
                    { 83, new DateTime(2024, 2, 7, 14, 52, 52, 750, DateTimeKind.Utc).AddTicks(770), "MatthewWilliams.Schuppe@yahoo.com", "Matthew Williams", "374.286.6872", new DateTime(2024, 2, 7, 14, 52, 52, 750, DateTimeKind.Utc).AddTicks(773) },
                    { 84, new DateTime(2024, 2, 7, 14, 52, 52, 754, DateTimeKind.Utc).AddTicks(165), "SarahSmith.Brekke56@hotmail.com", "Sarah Smith", "911-344-5856 x5367", new DateTime(2024, 2, 7, 14, 52, 52, 754, DateTimeKind.Utc).AddTicks(168) },
                    { 85, new DateTime(2024, 2, 7, 14, 52, 52, 758, DateTimeKind.Utc).AddTicks(2475), "DanielDavis94@yahoo.com", "Daniel Davis", "288-443-1023 x0046", new DateTime(2024, 2, 7, 14, 52, 52, 758, DateTimeKind.Utc).AddTicks(2478) },
                    { 86, new DateTime(2024, 2, 7, 14, 52, 52, 761, DateTimeKind.Utc).AddTicks(4939), "MichaelJones_Rice@hotmail.com", "Michael Jones", "1-414-248-9493 x47208", new DateTime(2024, 2, 7, 14, 52, 52, 761, DateTimeKind.Utc).AddTicks(4943) },
                    { 87, new DateTime(2024, 2, 7, 14, 52, 52, 764, DateTimeKind.Utc).AddTicks(1180), "MatthewDavis_Beier44@yahoo.com", "Matthew Davis", "(490) 937-9688 x9708", new DateTime(2024, 2, 7, 14, 52, 52, 764, DateTimeKind.Utc).AddTicks(1184) },
                    { 88, new DateTime(2024, 2, 7, 14, 52, 52, 766, DateTimeKind.Utc).AddTicks(4708), "MatthewRodriguez_Marquardt53@hotmail.com", "Matthew Rodriguez", "900.761.1136 x44281", new DateTime(2024, 2, 7, 14, 52, 52, 766, DateTimeKind.Utc).AddTicks(4711) },
                    { 89, new DateTime(2024, 2, 7, 14, 52, 52, 770, DateTimeKind.Utc).AddTicks(1265), "JenniferWilliams88@yahoo.com", "Jennifer Williams", "727.297.4053 x1028", new DateTime(2024, 2, 7, 14, 52, 52, 770, DateTimeKind.Utc).AddTicks(1270) },
                    { 90, new DateTime(2024, 2, 7, 14, 52, 52, 772, DateTimeKind.Utc).AddTicks(8155), "DanielSmith17@gmail.com", "Daniel Smith", "662-974-5928 x05538", new DateTime(2024, 2, 7, 14, 52, 52, 772, DateTimeKind.Utc).AddTicks(8159) },
                    { 91, new DateTime(2024, 2, 7, 14, 52, 52, 775, DateTimeKind.Utc).AddTicks(2967), "JaneGarcia63@hotmail.com", "Jane Garcia", "639-398-5780 x5411", new DateTime(2024, 2, 7, 14, 52, 52, 775, DateTimeKind.Utc).AddTicks(2971) },
                    { 92, new DateTime(2024, 2, 7, 14, 52, 52, 778, DateTimeKind.Utc).AddTicks(3793), "DanielWilson30@hotmail.com", "Daniel Wilson", "1-246-905-3410", new DateTime(2024, 2, 7, 14, 52, 52, 778, DateTimeKind.Utc).AddTicks(3796) },
                    { 93, new DateTime(2024, 2, 7, 14, 52, 52, 781, DateTimeKind.Utc).AddTicks(2196), "JohnBrown41@gmail.com", "John Brown", "(714) 806-9705", new DateTime(2024, 2, 7, 14, 52, 52, 781, DateTimeKind.Utc).AddTicks(2199) },
                    { 94, new DateTime(2024, 2, 7, 14, 52, 52, 786, DateTimeKind.Utc).AddTicks(1349), "JenniferMiller90@yahoo.com", "Jennifer Miller", "445-223-2527", new DateTime(2024, 2, 7, 14, 52, 52, 786, DateTimeKind.Utc).AddTicks(1352) },
                    { 95, new DateTime(2024, 2, 7, 14, 52, 52, 788, DateTimeKind.Utc).AddTicks(6020), "MichaelSmith.OReilly@gmail.com", "Michael Smith", "442.262.9899 x565", new DateTime(2024, 2, 7, 14, 52, 52, 788, DateTimeKind.Utc).AddTicks(6023) },
                    { 96, new DateTime(2024, 2, 7, 14, 52, 52, 792, DateTimeKind.Utc).AddTicks(1563), "DanielMiller50@gmail.com", "Daniel Miller", "1-455-323-4200 x0839", new DateTime(2024, 2, 7, 14, 52, 52, 792, DateTimeKind.Utc).AddTicks(1566) },
                    { 97, new DateTime(2024, 2, 7, 14, 52, 52, 795, DateTimeKind.Utc).AddTicks(3733), "DanielBrown59@gmail.com", "Daniel Brown", "524-468-1999 x34454", new DateTime(2024, 2, 7, 14, 52, 52, 795, DateTimeKind.Utc).AddTicks(3736) },
                    { 98, new DateTime(2024, 2, 7, 14, 52, 52, 798, DateTimeKind.Utc).AddTicks(4670), "DavidMiller_Reichel71@gmail.com", "David Miller", "397.520.0582", new DateTime(2024, 2, 7, 14, 52, 52, 798, DateTimeKind.Utc).AddTicks(4675) },
                    { 99, new DateTime(2024, 2, 7, 14, 52, 52, 801, DateTimeKind.Utc).AddTicks(7867), "DanielJohnson46@yahoo.com", "Daniel Johnson", "480.536.5864 x5898", new DateTime(2024, 2, 7, 14, 52, 52, 801, DateTimeKind.Utc).AddTicks(7870) },
                    { 100, new DateTime(2024, 2, 7, 14, 52, 52, 805, DateTimeKind.Utc).AddTicks(4774), "EmilyDavis.Hintz@gmail.com", "Emily Davis", "1-605-568-1364", new DateTime(2024, 2, 7, 14, 52, 52, 805, DateTimeKind.Utc).AddTicks(4777) }
                });

            migrationBuilder.InsertData(
                table: "movie",
                columns: new[] { "id", "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 7, 14, 52, 52, 808, DateTimeKind.Utc).AddTicks(977), "Incidunt commodi repellendus nisi fuga placeat. Ea sequi natus. Quis ratione ut. Voluptatibus maxime aut et tempora.", "R", "120 minutes", "Ut ipsam placeat.", new DateTime(2024, 2, 7, 14, 52, 52, 808, DateTimeKind.Utc).AddTicks(984) },
                    { 2, new DateTime(2024, 2, 7, 14, 52, 52, 811, DateTimeKind.Utc).AddTicks(385), "Maiores temporibus dolor id molestiae. Voluptate eos vero et suscipit nisi sed reiciendis et nostrum. Id aut delectus sint consequatur sit quo. Sed est ut nihil fugiat enim laudantium incidunt. Dolorum id aut et quae quis. Sed dolorum ut est.\n\nEst itaque autem aut qui. Voluptatum consequatur est dolorem incidunt cumque est ea est repellendus. Doloribus illum quis ut enim et. Et soluta sunt.", "G", "126 minutes", "Reprehenderit est officia.", new DateTime(2024, 2, 7, 14, 52, 52, 811, DateTimeKind.Utc).AddTicks(388) },
                    { 3, new DateTime(2024, 2, 7, 14, 52, 52, 814, DateTimeKind.Utc).AddTicks(1787), "Quo dolores quia cumque dolor esse. Laborum necessitatibus unde enim. Quaerat eius adipisci cum iure est unde. Ducimus consequatur sit fugiat nesciunt amet est aut. Nam culpa quo. Et odio voluptas sed.\n\nEt repudiandae sed maxime aliquam enim nostrum consequuntur recusandae. Laborum officiis quae molestias aperiam id aut. Enim est perspiciatis aliquam accusamus animi commodi. Ipsum nulla est blanditiis ipsam quia.", "G", "135 minutes", "Officia non.", new DateTime(2024, 2, 7, 14, 52, 52, 814, DateTimeKind.Utc).AddTicks(1790) },
                    { 4, new DateTime(2024, 2, 7, 14, 52, 52, 816, DateTimeKind.Utc).AddTicks(9834), "Recusandae sed ut doloremque omnis id maiores sunt. Molestias voluptatem quia inventore ut et ut tempore eum. Perspiciatis cupiditate sit blanditiis veniam maiores perferendis.\n\nRatione voluptas maxime cumque. Itaque dolore enim animi beatae et exercitationem maiores sequi perspiciatis. Et temporibus ipsam aut adipisci aspernatur quia ad. Molestiae illum odit eligendi aspernatur.", "PG-13", "145 minutes", "Corporis vitae sint.", new DateTime(2024, 2, 7, 14, 52, 52, 816, DateTimeKind.Utc).AddTicks(9838) },
                    { 5, new DateTime(2024, 2, 7, 14, 52, 52, 819, DateTimeKind.Utc).AddTicks(6349), "Soluta eum dolore occaecati aut. Est sunt voluptatem blanditiis at iusto sapiente rem voluptatum ipsa. Sint deleniti maxime ut iste. Voluptatem aut ut iste cum qui facere non repellat ut.", "R", "97 minutes", "Dolore eum enim.", new DateTime(2024, 2, 7, 14, 52, 52, 819, DateTimeKind.Utc).AddTicks(6355) },
                    { 6, new DateTime(2024, 2, 7, 14, 52, 52, 821, DateTimeKind.Utc).AddTicks(9661), "Aspernatur ut ut possimus eum atque. Consequuntur ut dolor omnis qui laudantium tenetur accusantium ut. Et nihil consequatur.\n\nMolestiae dolor earum iste labore. At sapiente voluptatem sit ea dolor accusamus dolor. Illo delectus fuga vel quisquam. Laudantium corporis doloribus quisquam accusamus necessitatibus vel dolorum.", "PG-13", "170 minutes", "Alias occaecati.", new DateTime(2024, 2, 7, 14, 52, 52, 821, DateTimeKind.Utc).AddTicks(9663) },
                    { 7, new DateTime(2024, 2, 7, 14, 52, 52, 824, DateTimeKind.Utc).AddTicks(3309), "Rerum et sed est accusantium aut iure nihil sit sapiente. Explicabo maxime in molestias sapiente expedita nam. Molestias asperiores alias nulla vitae consequatur. Sed impedit aliquam. Eius ut natus mollitia sapiente quia ea esse quasi provident. Dolor eius itaque doloribus qui rerum voluptatem a hic.", "R", "114 minutes", "Totam praesentium asperiores.", new DateTime(2024, 2, 7, 14, 52, 52, 824, DateTimeKind.Utc).AddTicks(3313) },
                    { 8, new DateTime(2024, 2, 7, 14, 52, 52, 826, DateTimeKind.Utc).AddTicks(7001), "Debitis eos et iste totam velit et. Praesentium delectus illum ut deleniti qui velit ut. Culpa aliquam optio et nihil. Quia velit in mollitia exercitationem. Soluta earum amet exercitationem voluptas qui nesciunt est voluptatem. Officia quia quod.\n\nEos ab labore inventore voluptatem totam. Odio ea sed corrupti adipisci beatae. Facere aut quod ut laudantium voluptatum. Temporibus id debitis animi.", "G", "105 minutes", "Qui quam culpa.", new DateTime(2024, 2, 7, 14, 52, 52, 826, DateTimeKind.Utc).AddTicks(7003) },
                    { 9, new DateTime(2024, 2, 7, 14, 52, 52, 829, DateTimeKind.Utc).AddTicks(6549), "Recusandae eveniet natus. Necessitatibus natus sit est quo maiores. Itaque consequatur praesentium autem voluptatem repellendus quia magni tempora sit. Ipsa libero aut enim. Quae non et accusantium eaque minus est blanditiis. Illum hic illum nihil et est.", "PG", "73 minutes", "Ea laboriosam quae.", new DateTime(2024, 2, 7, 14, 52, 52, 829, DateTimeKind.Utc).AddTicks(6554) },
                    { 10, new DateTime(2024, 2, 7, 14, 52, 52, 832, DateTimeKind.Utc).AddTicks(1465), "Rerum deserunt porro ut a voluptas veritatis eos repudiandae. Eius aut laborum minus. Et qui qui sequi ut aut delectus. Enim quam laboriosam dolor. Est ea ea eum voluptas id voluptatum quasi.", "PG", "177 minutes", "Id qui at.", new DateTime(2024, 2, 7, 14, 52, 52, 832, DateTimeKind.Utc).AddTicks(1468) },
                    { 11, new DateTime(2024, 2, 7, 14, 52, 52, 834, DateTimeKind.Utc).AddTicks(7360), "Architecto maiores exercitationem et dolorem facilis sunt quae. Quod hic sunt qui laudantium sit cum ullam. Hic beatae voluptates quod rerum quam et. Odit eius maiores soluta voluptas harum aut aut. Quo velit eligendi suscipit tempora aliquam et quam nisi sed.", "G", "112 minutes", "Reprehenderit.", new DateTime(2024, 2, 7, 14, 52, 52, 834, DateTimeKind.Utc).AddTicks(7367) },
                    { 12, new DateTime(2024, 2, 7, 14, 52, 52, 837, DateTimeKind.Utc).AddTicks(522), "Porro blanditiis ea voluptas non odit quia cum omnis. Quia recusandae veniam voluptates animi est est. Vel reiciendis amet doloribus doloribus id. Tempore quam ut quia quisquam. Nihil eveniet accusantium repellendus velit. Consectetur eum distinctio animi.", "G", "176 minutes", "Qui quae laboriosam.", new DateTime(2024, 2, 7, 14, 52, 52, 837, DateTimeKind.Utc).AddTicks(525) },
                    { 13, new DateTime(2024, 2, 7, 14, 52, 52, 839, DateTimeKind.Utc).AddTicks(9548), "Excepturi vero omnis consequatur tempore molestias. Voluptatem eos quibusdam et at ex et harum. Saepe accusantium consequatur fugit impedit sequi. Deserunt qui nihil earum. Laboriosam dolorum nesciunt consequatur et corporis est dolorem earum quasi.\n\nExplicabo debitis animi excepturi quia eaque maxime placeat voluptatem. Quisquam non incidunt vitae. Architecto sed porro soluta. Quia quod sint maiores amet et quo ducimus nemo esse. Quidem aliquam reprehenderit ea quibusdam quas.", "PG", "75 minutes", "Dolore.", new DateTime(2024, 2, 7, 14, 52, 52, 839, DateTimeKind.Utc).AddTicks(9552) },
                    { 14, new DateTime(2024, 2, 7, 14, 52, 52, 842, DateTimeKind.Utc).AddTicks(2440), "Voluptate sed et magnam ea enim consequatur rerum illo quasi. Optio itaque velit omnis. Officiis reprehenderit delectus quia. Omnis enim dicta iste exercitationem consequatur distinctio inventore ea. Velit sit impedit aut voluptate sint. Consequatur eos accusantium iste magni expedita voluptatum.\n\nCumque quod nihil. Quia perspiciatis animi cumque vel voluptas exercitationem velit vero. Perferendis ut ratione eveniet velit recusandae.", "PG-13", "135 minutes", "Incidunt voluptatem.", new DateTime(2024, 2, 7, 14, 52, 52, 842, DateTimeKind.Utc).AddTicks(2442) },
                    { 15, new DateTime(2024, 2, 7, 14, 52, 52, 844, DateTimeKind.Utc).AddTicks(9365), "Molestiae et quae ipsa voluptas et velit. Numquam inventore atque debitis tempora dolores repudiandae nesciunt. Dolorem cupiditate assumenda est est odit vel quia earum. Consequatur odit totam facere impedit. A ea non non.\n\nOfficia voluptatem beatae quaerat iure corrupti et voluptatem placeat eaque. Quasi aut voluptates non expedita sit velit odit asperiores dolore. Quam nostrum hic. Et ea voluptates sequi nemo.", "PG-13", "146 minutes", "Voluptas.", new DateTime(2024, 2, 7, 14, 52, 52, 844, DateTimeKind.Utc).AddTicks(9368) },
                    { 16, new DateTime(2024, 2, 7, 14, 52, 52, 847, DateTimeKind.Utc).AddTicks(1487), "Aut dolor qui voluptatem autem quasi animi. Quia eum est aperiam vel distinctio molestias voluptatem. Quis rerum fuga asperiores. Facere cupiditate sit impedit.", "G", "158 minutes", "Sint quod.", new DateTime(2024, 2, 7, 14, 52, 52, 847, DateTimeKind.Utc).AddTicks(1490) },
                    { 17, new DateTime(2024, 2, 7, 14, 52, 52, 849, DateTimeKind.Utc).AddTicks(6515), "Dolorum eum qui. Nobis esse eligendi placeat maxime maiores ut. Voluptas sed voluptas.\n\nFugit aperiam aut error tempore illum harum natus ut amet. Beatae voluptatem nisi qui excepturi ut inventore consectetur qui ratione. Iure ea ipsa esse. Laboriosam atque voluptas magnam nam tenetur repudiandae excepturi aperiam. Quasi aut sunt dolor quas qui odit facilis labore.", "PG", "60 minutes", "Ea qui vero.", new DateTime(2024, 2, 7, 14, 52, 52, 849, DateTimeKind.Utc).AddTicks(6518) },
                    { 18, new DateTime(2024, 2, 7, 14, 52, 52, 851, DateTimeKind.Utc).AddTicks(7645), "At amet iste quo sit qui et iste. Facilis quia voluptatem vel sint rem fugit. Non dolores eligendi et aut odit. Perferendis sed ex corrupti ut et debitis. Et aut nesciunt ipsa sunt dicta perspiciatis laborum error corrupti. Deleniti error sunt dolorem praesentium est recusandae et.\n\nMolestiae eaque excepturi atque ut. Recusandae omnis qui sed in consequatur ab. Optio possimus cum aut inventore id labore. Blanditiis modi quam quibusdam. Odit quis provident corrupti. Aut eos id dolorem quae.", "G", "166 minutes", "Hic.", new DateTime(2024, 2, 7, 14, 52, 52, 851, DateTimeKind.Utc).AddTicks(7647) },
                    { 19, new DateTime(2024, 2, 7, 14, 52, 52, 853, DateTimeKind.Utc).AddTicks(9609), "Dolorem magnam beatae velit placeat et modi. Impedit excepturi eum consequuntur dolor et. Amet aliquam fuga ut ut repudiandae et repudiandae delectus.", "G", "106 minutes", "Sunt.", new DateTime(2024, 2, 7, 14, 52, 52, 853, DateTimeKind.Utc).AddTicks(9610) },
                    { 20, new DateTime(2024, 2, 7, 14, 52, 52, 856, DateTimeKind.Utc).AddTicks(2807), "Distinctio ex possimus architecto exercitationem ut ad consequuntur perspiciatis et. Molestiae omnis expedita illum tempora nisi voluptatibus officiis. Nisi voluptatem nemo nemo aliquam minus est. Est facere unde inventore. Minus eum sint ea harum quis iusto.", "PG", "119 minutes", "Pariatur sit.", new DateTime(2024, 2, 7, 14, 52, 52, 856, DateTimeKind.Utc).AddTicks(2809) }
                });

            migrationBuilder.InsertData(
                table: "screening",
                columns: new[] { "id", "capacity", "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[,]
                {
                    { 1, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8153), 1, 1, new DateTime(2024, 2, 11, 9, 52, 52, 858, DateTimeKind.Utc).AddTicks(8158), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8156) },
                    { 2, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8194), 5, 2, new DateTime(2024, 2, 9, 0, 52, 52, 858, DateTimeKind.Utc).AddTicks(8195), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8194) },
                    { 3, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8196), 1, 3, new DateTime(2024, 2, 11, 2, 52, 52, 858, DateTimeKind.Utc).AddTicks(8197), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8196) },
                    { 4, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8198), 12, 4, new DateTime(2024, 2, 12, 5, 52, 52, 858, DateTimeKind.Utc).AddTicks(8199), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8198) },
                    { 5, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8200), 6, 1, new DateTime(2024, 2, 11, 0, 52, 52, 858, DateTimeKind.Utc).AddTicks(8200), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8200) },
                    { 6, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8203), 4, 3, new DateTime(2024, 2, 9, 2, 52, 52, 858, DateTimeKind.Utc).AddTicks(8203), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8203) },
                    { 7, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8204), 15, 1, new DateTime(2024, 2, 12, 9, 52, 52, 858, DateTimeKind.Utc).AddTicks(8205), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8205) },
                    { 8, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8206), 7, 2, new DateTime(2024, 2, 9, 0, 52, 52, 858, DateTimeKind.Utc).AddTicks(8206), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8206) },
                    { 9, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8207), 8, 2, new DateTime(2024, 2, 13, 6, 52, 52, 858, DateTimeKind.Utc).AddTicks(8208), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8207) },
                    { 10, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8210), 10, 2, new DateTime(2024, 2, 11, 5, 52, 52, 858, DateTimeKind.Utc).AddTicks(8210), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8210) },
                    { 11, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8211), 14, 1, new DateTime(2024, 2, 12, 0, 52, 52, 858, DateTimeKind.Utc).AddTicks(8212), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8212) },
                    { 12, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8213), 13, 4, new DateTime(2024, 2, 9, 7, 52, 52, 858, DateTimeKind.Utc).AddTicks(8214), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8213) },
                    { 13, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8216), 9, 2, new DateTime(2024, 2, 11, 4, 52, 52, 858, DateTimeKind.Utc).AddTicks(8217), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8216) },
                    { 14, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8218), 17, 4, new DateTime(2024, 2, 9, 7, 52, 52, 858, DateTimeKind.Utc).AddTicks(8219), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8219) },
                    { 15, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8221), 1, 2, new DateTime(2024, 2, 11, 9, 52, 52, 858, DateTimeKind.Utc).AddTicks(8222), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8222) },
                    { 16, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8234), 15, 4, new DateTime(2024, 2, 14, 6, 52, 52, 858, DateTimeKind.Utc).AddTicks(8235), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8235) },
                    { 17, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8237), 17, 3, new DateTime(2024, 2, 14, 6, 52, 52, 858, DateTimeKind.Utc).AddTicks(8238), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8237) },
                    { 18, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8242), 11, 2, new DateTime(2024, 2, 12, 8, 52, 52, 858, DateTimeKind.Utc).AddTicks(8243), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8242) },
                    { 19, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8245), 4, 2, new DateTime(2024, 2, 11, 6, 52, 52, 858, DateTimeKind.Utc).AddTicks(8246), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8245) },
                    { 20, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8247), 16, 2, new DateTime(2024, 2, 10, 0, 52, 52, 858, DateTimeKind.Utc).AddTicks(8248), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8248) },
                    { 21, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8250), 17, 1, new DateTime(2024, 2, 13, 7, 52, 52, 858, DateTimeKind.Utc).AddTicks(8250), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8250) },
                    { 22, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8251), 14, 1, new DateTime(2024, 2, 10, 0, 52, 52, 858, DateTimeKind.Utc).AddTicks(8252), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8251) },
                    { 23, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8252), 10, 1, new DateTime(2024, 2, 10, 9, 52, 52, 858, DateTimeKind.Utc).AddTicks(8253), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8253) },
                    { 24, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8254), 20, 4, new DateTime(2024, 2, 13, 0, 52, 52, 858, DateTimeKind.Utc).AddTicks(8255), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8254) },
                    { 25, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8256), 8, 2, new DateTime(2024, 2, 10, 7, 52, 52, 858, DateTimeKind.Utc).AddTicks(8256), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8256) },
                    { 26, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8257), 6, 3, new DateTime(2024, 2, 9, 2, 52, 52, 858, DateTimeKind.Utc).AddTicks(8258), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8257) },
                    { 27, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8259), 2, 3, new DateTime(2024, 2, 13, 7, 52, 52, 858, DateTimeKind.Utc).AddTicks(8259), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8259) },
                    { 28, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8261), 3, 3, new DateTime(2024, 2, 11, 5, 52, 52, 858, DateTimeKind.Utc).AddTicks(8261), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8261) },
                    { 29, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8262), 11, 3, new DateTime(2024, 2, 14, 3, 52, 52, 858, DateTimeKind.Utc).AddTicks(8263), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8262) },
                    { 30, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8263), 6, 3, new DateTime(2024, 2, 13, 5, 52, 52, 858, DateTimeKind.Utc).AddTicks(8264), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8264) },
                    { 31, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8278), 3, 2, new DateTime(2024, 2, 14, 7, 52, 52, 858, DateTimeKind.Utc).AddTicks(8278), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8278) },
                    { 32, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8279), 15, 2, new DateTime(2024, 2, 12, 4, 52, 52, 858, DateTimeKind.Utc).AddTicks(8280), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8279) },
                    { 33, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8280), 7, 1, new DateTime(2024, 2, 9, 8, 52, 52, 858, DateTimeKind.Utc).AddTicks(8281), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8281) },
                    { 34, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8283), 8, 1, new DateTime(2024, 2, 10, 9, 52, 52, 858, DateTimeKind.Utc).AddTicks(8284), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8283) },
                    { 35, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8285), 18, 1, new DateTime(2024, 2, 12, 7, 52, 52, 858, DateTimeKind.Utc).AddTicks(8285), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8285) },
                    { 36, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8286), 1, 4, new DateTime(2024, 2, 11, 9, 52, 52, 858, DateTimeKind.Utc).AddTicks(8287), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8286) },
                    { 37, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8288), 11, 3, new DateTime(2024, 2, 13, 0, 52, 52, 858, DateTimeKind.Utc).AddTicks(8288), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8288) },
                    { 38, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8289), 11, 1, new DateTime(2024, 2, 13, 9, 52, 52, 858, DateTimeKind.Utc).AddTicks(8290), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8289) },
                    { 39, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8291), 16, 3, new DateTime(2024, 2, 12, 3, 52, 52, 858, DateTimeKind.Utc).AddTicks(8291), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8291) },
                    { 40, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8308), 3, 1, new DateTime(2024, 2, 13, 8, 52, 52, 858, DateTimeKind.Utc).AddTicks(8308), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8308) },
                    { 41, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8310), 14, 4, new DateTime(2024, 2, 11, 2, 52, 52, 858, DateTimeKind.Utc).AddTicks(8310), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8310) },
                    { 42, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8311), 3, 1, new DateTime(2024, 2, 10, 7, 52, 52, 858, DateTimeKind.Utc).AddTicks(8312), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8311) },
                    { 43, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8313), 15, 3, new DateTime(2024, 2, 10, 1, 52, 52, 858, DateTimeKind.Utc).AddTicks(8313), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8313) },
                    { 44, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8314), 12, 2, new DateTime(2024, 2, 13, 1, 52, 52, 858, DateTimeKind.Utc).AddTicks(8315), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8315) },
                    { 45, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8316), 15, 2, new DateTime(2024, 2, 13, 8, 52, 52, 858, DateTimeKind.Utc).AddTicks(8316), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8316) },
                    { 46, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8318), 10, 3, new DateTime(2024, 2, 11, 1, 52, 52, 858, DateTimeKind.Utc).AddTicks(8318), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8318) },
                    { 47, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8319), 20, 1, new DateTime(2024, 2, 11, 1, 52, 52, 858, DateTimeKind.Utc).AddTicks(8320), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8319) },
                    { 48, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8321), 4, 4, new DateTime(2024, 2, 9, 0, 52, 52, 858, DateTimeKind.Utc).AddTicks(8322), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8321) },
                    { 49, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8323), 20, 3, new DateTime(2024, 2, 9, 6, 52, 52, 858, DateTimeKind.Utc).AddTicks(8324), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8324) },
                    { 50, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8325), 16, 4, new DateTime(2024, 2, 9, 5, 52, 52, 858, DateTimeKind.Utc).AddTicks(8326), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8325) },
                    { 51, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8326), 15, 4, new DateTime(2024, 2, 10, 3, 52, 52, 858, DateTimeKind.Utc).AddTicks(8327), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8327) },
                    { 52, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8328), 5, 4, new DateTime(2024, 2, 14, 2, 52, 52, 858, DateTimeKind.Utc).AddTicks(8328), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8328) },
                    { 53, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8329), 11, 4, new DateTime(2024, 2, 12, 2, 52, 52, 858, DateTimeKind.Utc).AddTicks(8330), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8330) },
                    { 54, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8331), 12, 2, new DateTime(2024, 2, 10, 4, 52, 52, 858, DateTimeKind.Utc).AddTicks(8331), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8331) },
                    { 55, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8332), 10, 1, new DateTime(2024, 2, 10, 8, 52, 52, 858, DateTimeKind.Utc).AddTicks(8333), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8333) },
                    { 56, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8334), 13, 2, new DateTime(2024, 2, 11, 4, 52, 52, 858, DateTimeKind.Utc).AddTicks(8334), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8334) },
                    { 57, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8335), 17, 1, new DateTime(2024, 2, 13, 3, 52, 52, 858, DateTimeKind.Utc).AddTicks(8336), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8335) },
                    { 58, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8337), 12, 2, new DateTime(2024, 2, 13, 8, 52, 52, 858, DateTimeKind.Utc).AddTicks(8337), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8337) },
                    { 59, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8338), 20, 3, new DateTime(2024, 2, 11, 1, 52, 52, 858, DateTimeKind.Utc).AddTicks(8339), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8338) },
                    { 60, 50, new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8340), 13, 4, new DateTime(2024, 2, 11, 1, 52, 52, 858, DateTimeKind.Utc).AddTicks(8340), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8340) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screening_movie_id",
                table: "screening",
                column: "movie_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "screening");

            migrationBuilder.DropTable(
                name: "movie");
        }
    }
}
