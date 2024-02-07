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
                    { 1, new DateTime(2024, 2, 7, 12, 48, 53, 781, DateTimeKind.Utc).AddTicks(8226), "JohnMiller.Eide@yahoo.com", "John Miller", "430 05 153", new DateTime(2024, 2, 7, 12, 48, 53, 781, DateTimeKind.Utc).AddTicks(8229) },
                    { 2, new DateTime(2024, 2, 7, 12, 48, 53, 783, DateTimeKind.Utc).AddTicks(9397), "DanielJohnson80@hotmail.com", "Daniel Johnson", "635 89 175", new DateTime(2024, 2, 7, 12, 48, 53, 783, DateTimeKind.Utc).AddTicks(9403) },
                    { 3, new DateTime(2024, 2, 7, 12, 48, 53, 785, DateTimeKind.Utc).AddTicks(8909), "SarahBrown.Dahl19@gmail.com", "Sarah Brown", "+47 13 96 04 58", new DateTime(2024, 2, 7, 12, 48, 53, 785, DateTimeKind.Utc).AddTicks(8912) },
                    { 4, new DateTime(2024, 2, 7, 12, 48, 53, 787, DateTimeKind.Utc).AddTicks(5730), "SarahGarcia0@hotmail.com", "Sarah Garcia", "414 13 041", new DateTime(2024, 2, 7, 12, 48, 53, 787, DateTimeKind.Utc).AddTicks(5732) },
                    { 5, new DateTime(2024, 2, 7, 12, 48, 53, 789, DateTimeKind.Utc).AddTicks(7225), "JohnSmith.Bjerke48@yahoo.com", "John Smith", "+47 80 12 86 60", new DateTime(2024, 2, 7, 12, 48, 53, 789, DateTimeKind.Utc).AddTicks(7226) },
                    { 6, new DateTime(2024, 2, 7, 12, 48, 53, 791, DateTimeKind.Utc).AddTicks(4123), "JenniferJones_Solberg@yahoo.com", "Jennifer Jones", "+47 54 27 49 92", new DateTime(2024, 2, 7, 12, 48, 53, 791, DateTimeKind.Utc).AddTicks(4126) },
                    { 7, new DateTime(2024, 2, 7, 12, 48, 53, 793, DateTimeKind.Utc).AddTicks(1675), "JenniferRodriguez_Torp@hotmail.com", "Jennifer Rodriguez", "31881134", new DateTime(2024, 2, 7, 12, 48, 53, 793, DateTimeKind.Utc).AddTicks(1675) },
                    { 8, new DateTime(2024, 2, 7, 12, 48, 53, 794, DateTimeKind.Utc).AddTicks(9990), "SarahWilson_Andresen50@yahoo.com", "Sarah Wilson", "358 91 847", new DateTime(2024, 2, 7, 12, 48, 53, 794, DateTimeKind.Utc).AddTicks(9991) },
                    { 9, new DateTime(2024, 2, 7, 12, 48, 53, 796, DateTimeKind.Utc).AddTicks(7093), "DavidMiller.Halvorsen@yahoo.com", "David Miller", "99 09 80 58", new DateTime(2024, 2, 7, 12, 48, 53, 796, DateTimeKind.Utc).AddTicks(7093) },
                    { 10, new DateTime(2024, 2, 7, 12, 48, 53, 799, DateTimeKind.Utc).AddTicks(165), "JaneDavis.Edvardsen19@gmail.com", "Jane Davis", "49 04 09 16", new DateTime(2024, 2, 7, 12, 48, 53, 799, DateTimeKind.Utc).AddTicks(168) },
                    { 11, new DateTime(2024, 2, 7, 12, 48, 53, 802, DateTimeKind.Utc).AddTicks(101), "MatthewWilliams_Evensen64@hotmail.com", "Matthew Williams", "792 83 207", new DateTime(2024, 2, 7, 12, 48, 53, 802, DateTimeKind.Utc).AddTicks(105) },
                    { 12, new DateTime(2024, 2, 7, 12, 48, 53, 804, DateTimeKind.Utc).AddTicks(7745), "DavidJones.Huseby@gmail.com", "David Jones", "54 55 84 64", new DateTime(2024, 2, 7, 12, 48, 53, 804, DateTimeKind.Utc).AddTicks(7747) },
                    { 13, new DateTime(2024, 2, 7, 12, 48, 53, 807, DateTimeKind.Utc).AddTicks(5534), "JaneWilson_Henriksen48@gmail.com", "Jane Wilson", "065 95 945", new DateTime(2024, 2, 7, 12, 48, 53, 807, DateTimeKind.Utc).AddTicks(5534) },
                    { 14, new DateTime(2024, 2, 7, 12, 48, 53, 810, DateTimeKind.Utc).AddTicks(2926), "JaneJohnson18@gmail.com", "Jane Johnson", "56 23 81 20", new DateTime(2024, 2, 7, 12, 48, 53, 810, DateTimeKind.Utc).AddTicks(2927) },
                    { 15, new DateTime(2024, 2, 7, 12, 48, 53, 812, DateTimeKind.Utc).AddTicks(9341), "JaneDavis.Kristensen35@yahoo.com", "Jane Davis", "05 63 11 22", new DateTime(2024, 2, 7, 12, 48, 53, 812, DateTimeKind.Utc).AddTicks(9342) },
                    { 16, new DateTime(2024, 2, 7, 12, 48, 53, 815, DateTimeKind.Utc).AddTicks(7882), "DavidWilliams_Ruud59@gmail.com", "David Williams", "+47 73 32 26 31", new DateTime(2024, 2, 7, 12, 48, 53, 815, DateTimeKind.Utc).AddTicks(7885) },
                    { 17, new DateTime(2024, 2, 7, 12, 48, 53, 817, DateTimeKind.Utc).AddTicks(5400), "EmilyJones55@gmail.com", "Emily Jones", "+47 36 86 05 16", new DateTime(2024, 2, 7, 12, 48, 53, 817, DateTimeKind.Utc).AddTicks(5401) },
                    { 18, new DateTime(2024, 2, 7, 12, 48, 53, 819, DateTimeKind.Utc).AddTicks(3098), "MichaelGarcia_Aas52@gmail.com", "Michael Garcia", "+47 90 95 09 72", new DateTime(2024, 2, 7, 12, 48, 53, 819, DateTimeKind.Utc).AddTicks(3099) },
                    { 19, new DateTime(2024, 2, 7, 12, 48, 53, 820, DateTimeKind.Utc).AddTicks(9573), "JessicaSmith_Sorensen34@hotmail.com", "Jessica Smith", "012 71 736", new DateTime(2024, 2, 7, 12, 48, 53, 820, DateTimeKind.Utc).AddTicks(9573) },
                    { 20, new DateTime(2024, 2, 7, 12, 48, 53, 822, DateTimeKind.Utc).AddTicks(5683), "MatthewMiller_Nielsen94@hotmail.com", "Matthew Miller", "82 69 57 92", new DateTime(2024, 2, 7, 12, 48, 53, 822, DateTimeKind.Utc).AddTicks(5685) },
                    { 21, new DateTime(2024, 2, 7, 12, 48, 53, 824, DateTimeKind.Utc).AddTicks(3312), "JessicaWilliams.Jacobsen79@hotmail.com", "Jessica Williams", "+47 33 27 61 73", new DateTime(2024, 2, 7, 12, 48, 53, 824, DateTimeKind.Utc).AddTicks(3313) },
                    { 22, new DateTime(2024, 2, 7, 12, 48, 53, 827, DateTimeKind.Utc).AddTicks(6157), "JenniferWilliams_Thoresen21@yahoo.com", "Jennifer Williams", "350 01 909", new DateTime(2024, 2, 7, 12, 48, 53, 827, DateTimeKind.Utc).AddTicks(6158) },
                    { 23, new DateTime(2024, 2, 7, 12, 48, 53, 830, DateTimeKind.Utc).AddTicks(8790), "JohnMiller.Svendsen@yahoo.com", "John Miller", "81497867", new DateTime(2024, 2, 7, 12, 48, 53, 830, DateTimeKind.Utc).AddTicks(8790) },
                    { 24, new DateTime(2024, 2, 7, 12, 48, 53, 832, DateTimeKind.Utc).AddTicks(5355), "EmilyMiller44@hotmail.com", "Emily Miller", "70 36 24 73", new DateTime(2024, 2, 7, 12, 48, 53, 832, DateTimeKind.Utc).AddTicks(5356) },
                    { 25, new DateTime(2024, 2, 7, 12, 48, 53, 834, DateTimeKind.Utc).AddTicks(1658), "JessicaWilson_Fjeld50@hotmail.com", "Jessica Wilson", "05014204", new DateTime(2024, 2, 7, 12, 48, 53, 834, DateTimeKind.Utc).AddTicks(1659) },
                    { 26, new DateTime(2024, 2, 7, 12, 48, 53, 835, DateTimeKind.Utc).AddTicks(8730), "MatthewJones.Olsen6@hotmail.com", "Matthew Jones", "+47 08 88 16 76", new DateTime(2024, 2, 7, 12, 48, 53, 835, DateTimeKind.Utc).AddTicks(8731) },
                    { 27, new DateTime(2024, 2, 7, 12, 48, 53, 837, DateTimeKind.Utc).AddTicks(5622), "EmilyJones_Skuterud@yahoo.com", "Emily Jones", "765 37 423", new DateTime(2024, 2, 7, 12, 48, 53, 837, DateTimeKind.Utc).AddTicks(5622) },
                    { 28, new DateTime(2024, 2, 7, 12, 48, 53, 839, DateTimeKind.Utc).AddTicks(2263), "JenniferRodriguez.Tangen9@hotmail.com", "Jennifer Rodriguez", "449 15 584", new DateTime(2024, 2, 7, 12, 48, 53, 839, DateTimeKind.Utc).AddTicks(2263) },
                    { 29, new DateTime(2024, 2, 7, 12, 48, 53, 840, DateTimeKind.Utc).AddTicks(8827), "DavidJohnson.Krogh@yahoo.com", "David Johnson", "+47 46 21 68 18", new DateTime(2024, 2, 7, 12, 48, 53, 840, DateTimeKind.Utc).AddTicks(8828) },
                    { 30, new DateTime(2024, 2, 7, 12, 48, 53, 842, DateTimeKind.Utc).AddTicks(5754), "SarahGarcia_Rasmussen@yahoo.com", "Sarah Garcia", "850 01 287", new DateTime(2024, 2, 7, 12, 48, 53, 842, DateTimeKind.Utc).AddTicks(5754) },
                    { 31, new DateTime(2024, 2, 7, 12, 48, 53, 844, DateTimeKind.Utc).AddTicks(2861), "DanielRodriguez84@yahoo.com", "Daniel Rodriguez", "721 99 536", new DateTime(2024, 2, 7, 12, 48, 53, 844, DateTimeKind.Utc).AddTicks(2862) },
                    { 32, new DateTime(2024, 2, 7, 12, 48, 53, 847, DateTimeKind.Utc).AddTicks(2808), "MichaelRodriguez66@gmail.com", "Michael Rodriguez", "732 95 212", new DateTime(2024, 2, 7, 12, 48, 53, 847, DateTimeKind.Utc).AddTicks(2810) },
                    { 33, new DateTime(2024, 2, 7, 12, 48, 53, 850, DateTimeKind.Utc).AddTicks(158), "MatthewJones.Moen@gmail.com", "Matthew Jones", "65283503", new DateTime(2024, 2, 7, 12, 48, 53, 850, DateTimeKind.Utc).AddTicks(159) },
                    { 34, new DateTime(2024, 2, 7, 12, 48, 53, 852, DateTimeKind.Utc).AddTicks(7220), "JessicaWilson.Bakke48@gmail.com", "Jessica Wilson", "77 65 05 05", new DateTime(2024, 2, 7, 12, 48, 53, 852, DateTimeKind.Utc).AddTicks(7220) },
                    { 35, new DateTime(2024, 2, 7, 12, 48, 53, 855, DateTimeKind.Utc).AddTicks(4275), "EmilyRodriguez_Bakke9@hotmail.com", "Emily Rodriguez", "39620700", new DateTime(2024, 2, 7, 12, 48, 53, 855, DateTimeKind.Utc).AddTicks(4276) },
                    { 36, new DateTime(2024, 2, 7, 12, 48, 53, 858, DateTimeKind.Utc).AddTicks(2210), "DanielDavis_Mathisen@hotmail.com", "Daniel Davis", "+47 93 93 46 75", new DateTime(2024, 2, 7, 12, 48, 53, 858, DateTimeKind.Utc).AddTicks(2211) },
                    { 37, new DateTime(2024, 2, 7, 12, 48, 53, 861, DateTimeKind.Utc).AddTicks(1182), "MichaelMiller_Hopland@gmail.com", "Michael Miller", "+47 06 92 14 32", new DateTime(2024, 2, 7, 12, 48, 53, 861, DateTimeKind.Utc).AddTicks(1184) },
                    { 38, new DateTime(2024, 2, 7, 12, 48, 53, 863, DateTimeKind.Utc).AddTicks(7987), "JaneWilson73@yahoo.com", "Jane Wilson", "05934205", new DateTime(2024, 2, 7, 12, 48, 53, 863, DateTimeKind.Utc).AddTicks(7989) },
                    { 39, new DateTime(2024, 2, 7, 12, 48, 53, 866, DateTimeKind.Utc).AddTicks(4862), "MichaelGarcia31@gmail.com", "Michael Garcia", "532 18 983", new DateTime(2024, 2, 7, 12, 48, 53, 866, DateTimeKind.Utc).AddTicks(4863) },
                    { 40, new DateTime(2024, 2, 7, 12, 48, 53, 869, DateTimeKind.Utc).AddTicks(2534), "DavidRodriguez56@yahoo.com", "David Rodriguez", "30 65 60 97", new DateTime(2024, 2, 7, 12, 48, 53, 869, DateTimeKind.Utc).AddTicks(2536) },
                    { 41, new DateTime(2024, 2, 7, 12, 48, 53, 871, DateTimeKind.Utc).AddTicks(9615), "EmilyBrown81@hotmail.com", "Emily Brown", "029 68 145", new DateTime(2024, 2, 7, 12, 48, 53, 871, DateTimeKind.Utc).AddTicks(9616) },
                    { 42, new DateTime(2024, 2, 7, 12, 48, 53, 874, DateTimeKind.Utc).AddTicks(1249), "DanielRodriguez_Smogeli7@hotmail.com", "Daniel Rodriguez", "962 57 565", new DateTime(2024, 2, 7, 12, 48, 53, 874, DateTimeKind.Utc).AddTicks(1252) },
                    { 43, new DateTime(2024, 2, 7, 12, 48, 53, 876, DateTimeKind.Utc).AddTicks(7640), "JohnRodriguez.Eriksen96@gmail.com", "John Rodriguez", "593 46 122", new DateTime(2024, 2, 7, 12, 48, 53, 876, DateTimeKind.Utc).AddTicks(7641) },
                    { 44, new DateTime(2024, 2, 7, 12, 48, 53, 878, DateTimeKind.Utc).AddTicks(7057), "DavidGarcia.Borge@hotmail.com", "David Garcia", "494 41 234", new DateTime(2024, 2, 7, 12, 48, 53, 878, DateTimeKind.Utc).AddTicks(7059) },
                    { 45, new DateTime(2024, 2, 7, 12, 48, 53, 880, DateTimeKind.Utc).AddTicks(3435), "JenniferJones_Ruud@yahoo.com", "Jennifer Jones", "96 85 50 12", new DateTime(2024, 2, 7, 12, 48, 53, 880, DateTimeKind.Utc).AddTicks(3437) },
                    { 46, new DateTime(2024, 2, 7, 12, 48, 53, 881, DateTimeKind.Utc).AddTicks(9475), "DanielDavis_Dahl1@yahoo.com", "Daniel Davis", "55 74 30 40", new DateTime(2024, 2, 7, 12, 48, 53, 881, DateTimeKind.Utc).AddTicks(9476) },
                    { 47, new DateTime(2024, 2, 7, 12, 48, 53, 883, DateTimeKind.Utc).AddTicks(6432), "JessicaJohnson89@yahoo.com", "Jessica Johnson", "541 75 134", new DateTime(2024, 2, 7, 12, 48, 53, 883, DateTimeKind.Utc).AddTicks(6433) },
                    { 48, new DateTime(2024, 2, 7, 12, 48, 53, 885, DateTimeKind.Utc).AddTicks(2780), "MatthewJones.Karlsen29@gmail.com", "Matthew Jones", "390 50 704", new DateTime(2024, 2, 7, 12, 48, 53, 885, DateTimeKind.Utc).AddTicks(2780) },
                    { 49, new DateTime(2024, 2, 7, 12, 48, 53, 887, DateTimeKind.Utc).AddTicks(566), "JaneWilson.Nguyen6@hotmail.com", "Jane Wilson", "47 21 90 71", new DateTime(2024, 2, 7, 12, 48, 53, 887, DateTimeKind.Utc).AddTicks(567) },
                    { 50, new DateTime(2024, 2, 7, 12, 48, 53, 888, DateTimeKind.Utc).AddTicks(7504), "MatthewJohnson.Krogh40@yahoo.com", "Matthew Johnson", "87877454", new DateTime(2024, 2, 7, 12, 48, 53, 888, DateTimeKind.Utc).AddTicks(7505) },
                    { 51, new DateTime(2024, 2, 7, 12, 48, 53, 890, DateTimeKind.Utc).AddTicks(3563), "EmilyWilliams_Vedvik@gmail.com", "Emily Williams", "+47 45 05 28 61", new DateTime(2024, 2, 7, 12, 48, 53, 890, DateTimeKind.Utc).AddTicks(3563) },
                    { 52, new DateTime(2024, 2, 7, 12, 48, 53, 892, DateTimeKind.Utc).AddTicks(9824), "EmilyGarcia57@gmail.com", "Emily Garcia", "+47 45 42 07 52", new DateTime(2024, 2, 7, 12, 48, 53, 892, DateTimeKind.Utc).AddTicks(9827) },
                    { 53, new DateTime(2024, 2, 7, 12, 48, 53, 895, DateTimeKind.Utc).AddTicks(6524), "MatthewWilson.Henriksen@yahoo.com", "Matthew Wilson", "61831953", new DateTime(2024, 2, 7, 12, 48, 53, 895, DateTimeKind.Utc).AddTicks(6526) },
                    { 54, new DateTime(2024, 2, 7, 12, 48, 53, 898, DateTimeKind.Utc).AddTicks(2602), "DanielMiller.Roed9@gmail.com", "Daniel Miller", "+47 20 17 07 77", new DateTime(2024, 2, 7, 12, 48, 53, 898, DateTimeKind.Utc).AddTicks(2604) },
                    { 55, new DateTime(2024, 2, 7, 12, 48, 53, 900, DateTimeKind.Utc).AddTicks(9330), "JessicaDavis14@yahoo.com", "Jessica Davis", "13 31 66 19", new DateTime(2024, 2, 7, 12, 48, 53, 900, DateTimeKind.Utc).AddTicks(9330) },
                    { 56, new DateTime(2024, 2, 7, 12, 48, 53, 903, DateTimeKind.Utc).AddTicks(6005), "JaneMiller.Solberg@hotmail.com", "Jane Miller", "+47 32 91 47 40", new DateTime(2024, 2, 7, 12, 48, 53, 903, DateTimeKind.Utc).AddTicks(6007) },
                    { 57, new DateTime(2024, 2, 7, 12, 48, 53, 906, DateTimeKind.Utc).AddTicks(2434), "JenniferMiller_Myhrer90@yahoo.com", "Jennifer Miller", "750 20 093", new DateTime(2024, 2, 7, 12, 48, 53, 906, DateTimeKind.Utc).AddTicks(2435) },
                    { 58, new DateTime(2024, 2, 7, 12, 48, 53, 908, DateTimeKind.Utc).AddTicks(3640), "DavidGarcia_Roed35@gmail.com", "David Garcia", "+47 34 27 42 38", new DateTime(2024, 2, 7, 12, 48, 53, 908, DateTimeKind.Utc).AddTicks(3646) },
                    { 59, new DateTime(2024, 2, 7, 12, 48, 53, 910, DateTimeKind.Utc).AddTicks(932), "EmilyJones.Evensen@gmail.com", "Emily Jones", "47 12 72 37", new DateTime(2024, 2, 7, 12, 48, 53, 910, DateTimeKind.Utc).AddTicks(933) },
                    { 60, new DateTime(2024, 2, 7, 12, 48, 53, 911, DateTimeKind.Utc).AddTicks(8324), "SarahRodriguez.Andreassen@gmail.com", "Sarah Rodriguez", "+47 73 38 31 37", new DateTime(2024, 2, 7, 12, 48, 53, 911, DateTimeKind.Utc).AddTicks(8325) },
                    { 61, new DateTime(2024, 2, 7, 12, 48, 53, 913, DateTimeKind.Utc).AddTicks(4509), "MichaelJohnson.Thoresen@hotmail.com", "Michael Johnson", "+47 90 97 77 70", new DateTime(2024, 2, 7, 12, 48, 53, 913, DateTimeKind.Utc).AddTicks(4509) },
                    { 62, new DateTime(2024, 2, 7, 12, 48, 53, 915, DateTimeKind.Utc).AddTicks(915), "SarahWilliams.Bakke30@gmail.com", "Sarah Williams", "+47 73 41 86 41", new DateTime(2024, 2, 7, 12, 48, 53, 915, DateTimeKind.Utc).AddTicks(916) },
                    { 63, new DateTime(2024, 2, 7, 12, 48, 53, 916, DateTimeKind.Utc).AddTicks(7004), "SarahJohnson_Edvardsen24@yahoo.com", "Sarah Johnson", "974 76 525", new DateTime(2024, 2, 7, 12, 48, 53, 916, DateTimeKind.Utc).AddTicks(7004) },
                    { 64, new DateTime(2024, 2, 7, 12, 48, 53, 918, DateTimeKind.Utc).AddTicks(3718), "JessicaWilson75@gmail.com", "Jessica Wilson", "+47 72 46 45 57", new DateTime(2024, 2, 7, 12, 48, 53, 918, DateTimeKind.Utc).AddTicks(3718) },
                    { 65, new DateTime(2024, 2, 7, 12, 48, 53, 920, DateTimeKind.Utc).AddTicks(1106), "DanielWilson_Skoglund8@yahoo.com", "Daniel Wilson", "61 11 96 56", new DateTime(2024, 2, 7, 12, 48, 53, 920, DateTimeKind.Utc).AddTicks(1106) },
                    { 66, new DateTime(2024, 2, 7, 12, 48, 53, 921, DateTimeKind.Utc).AddTicks(7519), "JessicaWilson_Lunde@hotmail.com", "Jessica Wilson", "+47 77 05 97 95", new DateTime(2024, 2, 7, 12, 48, 53, 921, DateTimeKind.Utc).AddTicks(7520) },
                    { 67, new DateTime(2024, 2, 7, 12, 48, 53, 924, DateTimeKind.Utc).AddTicks(9503), "JohnWilson.Svendsen@gmail.com", "John Wilson", "43 32 19 95", new DateTime(2024, 2, 7, 12, 48, 53, 924, DateTimeKind.Utc).AddTicks(9505) },
                    { 68, new DateTime(2024, 2, 7, 12, 48, 53, 927, DateTimeKind.Utc).AddTicks(9749), "SarahMiller5@hotmail.com", "Sarah Miller", "+47 90 45 51 85", new DateTime(2024, 2, 7, 12, 48, 53, 927, DateTimeKind.Utc).AddTicks(9749) },
                    { 69, new DateTime(2024, 2, 7, 12, 48, 53, 930, DateTimeKind.Utc).AddTicks(9466), "MatthewSmith_Nygard78@gmail.com", "Matthew Smith", "+47 18 55 67 51", new DateTime(2024, 2, 7, 12, 48, 53, 930, DateTimeKind.Utc).AddTicks(9467) },
                    { 70, new DateTime(2024, 2, 7, 12, 48, 53, 934, DateTimeKind.Utc).AddTicks(9412), "JessicaWilson_Odegard62@gmail.com", "Jessica Wilson", "32086390", new DateTime(2024, 2, 7, 12, 48, 53, 934, DateTimeKind.Utc).AddTicks(9413) },
                    { 71, new DateTime(2024, 2, 7, 12, 48, 53, 939, DateTimeKind.Utc).AddTicks(5562), "DanielSmith43@gmail.com", "Daniel Smith", "+47 72 87 41 75", new DateTime(2024, 2, 7, 12, 48, 53, 939, DateTimeKind.Utc).AddTicks(5563) },
                    { 72, new DateTime(2024, 2, 7, 12, 48, 53, 943, DateTimeKind.Utc).AddTicks(8704), "JenniferJohnson.Hansen85@hotmail.com", "Jennifer Johnson", "44 84 91 94", new DateTime(2024, 2, 7, 12, 48, 53, 943, DateTimeKind.Utc).AddTicks(8706) },
                    { 73, new DateTime(2024, 2, 7, 12, 48, 53, 948, DateTimeKind.Utc).AddTicks(3041), "JohnMiller43@yahoo.com", "John Miller", "914 00 216", new DateTime(2024, 2, 7, 12, 48, 53, 948, DateTimeKind.Utc).AddTicks(3043) },
                    { 74, new DateTime(2024, 2, 7, 12, 48, 53, 952, DateTimeKind.Utc).AddTicks(6145), "EmilyMiller.Glosli@yahoo.com", "Emily Miller", "+47 23 50 32 54", new DateTime(2024, 2, 7, 12, 48, 53, 952, DateTimeKind.Utc).AddTicks(6147) },
                    { 75, new DateTime(2024, 2, 7, 12, 48, 53, 956, DateTimeKind.Utc).AddTicks(9937), "JessicaWilliams_Tangen24@hotmail.com", "Jessica Williams", "38112746", new DateTime(2024, 2, 7, 12, 48, 53, 956, DateTimeKind.Utc).AddTicks(9938) },
                    { 76, new DateTime(2024, 2, 7, 12, 48, 53, 959, DateTimeKind.Utc).AddTicks(7899), "EmilyMiller16@hotmail.com", "Emily Miller", "29 40 26 28", new DateTime(2024, 2, 7, 12, 48, 53, 959, DateTimeKind.Utc).AddTicks(7900) },
                    { 77, new DateTime(2024, 2, 7, 12, 48, 53, 962, DateTimeKind.Utc).AddTicks(3701), "MatthewRodriguez.Finstad@gmail.com", "Matthew Rodriguez", "000 69 988", new DateTime(2024, 2, 7, 12, 48, 53, 962, DateTimeKind.Utc).AddTicks(3701) },
                    { 78, new DateTime(2024, 2, 7, 12, 48, 53, 964, DateTimeKind.Utc).AddTicks(9329), "DanielSmith22@gmail.com", "Daniel Smith", "08 21 85 85", new DateTime(2024, 2, 7, 12, 48, 53, 964, DateTimeKind.Utc).AddTicks(9330) },
                    { 79, new DateTime(2024, 2, 7, 12, 48, 53, 967, DateTimeKind.Utc).AddTicks(5244), "DavidRodriguez.Krogh@yahoo.com", "David Rodriguez", "+47 49 74 57 25", new DateTime(2024, 2, 7, 12, 48, 53, 967, DateTimeKind.Utc).AddTicks(5245) },
                    { 80, new DateTime(2024, 2, 7, 12, 48, 53, 970, DateTimeKind.Utc).AddTicks(5804), "MichaelBrown71@hotmail.com", "Michael Brown", "+47 92 46 88 53", new DateTime(2024, 2, 7, 12, 48, 53, 970, DateTimeKind.Utc).AddTicks(5806) },
                    { 81, new DateTime(2024, 2, 7, 12, 48, 53, 973, DateTimeKind.Utc).AddTicks(1670), "MichaelRodriguez95@yahoo.com", "Michael Rodriguez", "997 66 465", new DateTime(2024, 2, 7, 12, 48, 53, 973, DateTimeKind.Utc).AddTicks(1671) },
                    { 82, new DateTime(2024, 2, 7, 12, 48, 53, 975, DateTimeKind.Utc).AddTicks(6929), "MatthewMiller.Aasen99@gmail.com", "Matthew Miller", "32 39 56 78", new DateTime(2024, 2, 7, 12, 48, 53, 975, DateTimeKind.Utc).AddTicks(6929) },
                    { 83, new DateTime(2024, 2, 7, 12, 48, 53, 978, DateTimeKind.Utc).AddTicks(2117), "MatthewSmith75@hotmail.com", "Matthew Smith", "000 27 772", new DateTime(2024, 2, 7, 12, 48, 53, 978, DateTimeKind.Utc).AddTicks(2118) },
                    { 84, new DateTime(2024, 2, 7, 12, 48, 53, 980, DateTimeKind.Utc).AddTicks(7343), "EmilyJones20@yahoo.com", "Emily Jones", "496 53 110", new DateTime(2024, 2, 7, 12, 48, 53, 980, DateTimeKind.Utc).AddTicks(7344) },
                    { 85, new DateTime(2024, 2, 7, 12, 48, 53, 983, DateTimeKind.Utc).AddTicks(2267), "JenniferBrown.Gran72@gmail.com", "Jennifer Brown", "03 35 79 59", new DateTime(2024, 2, 7, 12, 48, 53, 983, DateTimeKind.Utc).AddTicks(2267) },
                    { 86, new DateTime(2024, 2, 7, 12, 48, 53, 986, DateTimeKind.Utc).AddTicks(6526), "JessicaJohnson_Berntsen@hotmail.com", "Jessica Johnson", "65 80 61 76", new DateTime(2024, 2, 7, 12, 48, 53, 986, DateTimeKind.Utc).AddTicks(6530) },
                    { 87, new DateTime(2024, 2, 7, 12, 48, 53, 990, DateTimeKind.Utc).AddTicks(8445), "JaneRodriguez.Gran@hotmail.com", "Jane Rodriguez", "87 44 02 95", new DateTime(2024, 2, 7, 12, 48, 53, 990, DateTimeKind.Utc).AddTicks(8447) },
                    { 88, new DateTime(2024, 2, 7, 12, 48, 53, 994, DateTimeKind.Utc).AddTicks(8690), "JenniferDavis_Ostby@hotmail.com", "Jennifer Davis", "513 33 125", new DateTime(2024, 2, 7, 12, 48, 53, 994, DateTimeKind.Utc).AddTicks(8693) },
                    { 89, new DateTime(2024, 2, 7, 12, 48, 53, 998, DateTimeKind.Utc).AddTicks(9310), "DanielJohnson_Olsen@hotmail.com", "Daniel Johnson", "60670610", new DateTime(2024, 2, 7, 12, 48, 53, 998, DateTimeKind.Utc).AddTicks(9312) },
                    { 90, new DateTime(2024, 2, 7, 12, 48, 54, 3, DateTimeKind.Utc).AddTicks(766), "DanielJohnson_Bjornstad@yahoo.com", "Daniel Johnson", "327 36 320", new DateTime(2024, 2, 7, 12, 48, 54, 3, DateTimeKind.Utc).AddTicks(769) },
                    { 91, new DateTime(2024, 2, 7, 12, 48, 54, 7, DateTimeKind.Utc).AddTicks(183), "MichaelRodriguez_Sorensen@gmail.com", "Michael Rodriguez", "+47 20 11 35 36", new DateTime(2024, 2, 7, 12, 48, 54, 7, DateTimeKind.Utc).AddTicks(186) },
                    { 92, new DateTime(2024, 2, 7, 12, 48, 54, 10, DateTimeKind.Utc).AddTicks(1924), "SarahRodriguez.Skoglund31@yahoo.com", "Sarah Rodriguez", "599 27 247", new DateTime(2024, 2, 7, 12, 48, 54, 10, DateTimeKind.Utc).AddTicks(1925) },
                    { 93, new DateTime(2024, 2, 7, 12, 48, 54, 12, DateTimeKind.Utc).AddTicks(7214), "JenniferMiller82@gmail.com", "Jennifer Miller", "90 35 09 85", new DateTime(2024, 2, 7, 12, 48, 54, 12, DateTimeKind.Utc).AddTicks(7215) },
                    { 94, new DateTime(2024, 2, 7, 12, 48, 54, 14, DateTimeKind.Utc).AddTicks(9874), "JessicaBrown56@hotmail.com", "Jessica Brown", "741 08 961", new DateTime(2024, 2, 7, 12, 48, 54, 14, DateTimeKind.Utc).AddTicks(9876) },
                    { 95, new DateTime(2024, 2, 7, 12, 48, 54, 17, DateTimeKind.Utc).AddTicks(5317), "DavidSmith_Aalerud@gmail.com", "David Smith", "+47 14 03 53 45", new DateTime(2024, 2, 7, 12, 48, 54, 17, DateTimeKind.Utc).AddTicks(5319) },
                    { 96, new DateTime(2024, 2, 7, 12, 48, 54, 19, DateTimeKind.Utc).AddTicks(9331), "MatthewWilliams_Dahl@yahoo.com", "Matthew Williams", "48 64 24 38", new DateTime(2024, 2, 7, 12, 48, 54, 19, DateTimeKind.Utc).AddTicks(9332) },
                    { 97, new DateTime(2024, 2, 7, 12, 48, 54, 22, DateTimeKind.Utc).AddTicks(2312), "JohnWilliams44@hotmail.com", "John Williams", "98089580", new DateTime(2024, 2, 7, 12, 48, 54, 22, DateTimeKind.Utc).AddTicks(2314) },
                    { 98, new DateTime(2024, 2, 7, 12, 48, 54, 24, DateTimeKind.Utc).AddTicks(5192), "JenniferRodriguez.Gran@yahoo.com", "Jennifer Rodriguez", "94 60 54 23", new DateTime(2024, 2, 7, 12, 48, 54, 24, DateTimeKind.Utc).AddTicks(5194) },
                    { 99, new DateTime(2024, 2, 7, 12, 48, 54, 26, DateTimeKind.Utc).AddTicks(7643), "MichaelDavis.Thoresen25@yahoo.com", "Michael Davis", "+47 70 94 23 78", new DateTime(2024, 2, 7, 12, 48, 54, 26, DateTimeKind.Utc).AddTicks(7644) },
                    { 100, new DateTime(2024, 2, 7, 12, 48, 54, 29, DateTimeKind.Utc).AddTicks(1443), "SarahMiller_Solli21@yahoo.com", "Sarah Miller", "998 78 746", new DateTime(2024, 2, 7, 12, 48, 54, 29, DateTimeKind.Utc).AddTicks(1444) }
                });

            migrationBuilder.InsertData(
                table: "movie",
                columns: new[] { "id", "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 7, 12, 48, 54, 31, DateTimeKind.Utc).AddTicks(3932), "Aut magnam nulla recusandae perferendis eligendi modi. Explicabo explicabo ut quam molestias ipsum cum tempore. Beatae praesentium debitis soluta officia voluptatem ea.\n\nReiciendis labore aspernatur qui id. Neque suscipit deserunt minus possimus qui hic dicta et. Sit veritatis pariatur labore perspiciatis et pariatur tenetur deleniti. Ab quasi magni nam commodi veniam consequatur esse sit fuga.", "PG", "84 minutes", "Facilis veritatis est.", new DateTime(2024, 2, 7, 12, 48, 54, 31, DateTimeKind.Utc).AddTicks(3933) },
                    { 2, new DateTime(2024, 2, 7, 12, 48, 54, 34, DateTimeKind.Utc).AddTicks(851), "Sunt dolores repellat molestiae qui. Corporis ab quam sit corrupti sit dolorem omnis earum. Sit fuga voluptatem ea optio expedita reprehenderit dolorum quos. Perferendis necessitatibus ut unde qui illo et iusto ipsum.\n\nQuia ullam amet occaecati. Rem dolor rerum nesciunt praesentium quod est. Qui voluptas excepturi qui nihil et qui odio minima consectetur.", "PG-13", "174 minutes", "Laborum quae quasi.", new DateTime(2024, 2, 7, 12, 48, 54, 34, DateTimeKind.Utc).AddTicks(854) },
                    { 3, new DateTime(2024, 2, 7, 12, 48, 54, 36, DateTimeKind.Utc).AddTicks(4780), "In mollitia asperiores at. Odit et quia deserunt qui aut sed eligendi. Facilis asperiores ea repudiandae reiciendis magnam molestiae quasi perspiciatis. Molestias veritatis voluptate voluptas voluptas nisi. Quis animi ut impedit voluptas id neque. Voluptas eveniet sint dolor nobis consequuntur reiciendis.\n\nInventore eveniet et in sint optio voluptatem saepe. Harum sint repudiandae et vel perspiciatis voluptates ab. Natus totam autem atque possimus. Numquam eius officia harum fuga unde qui. Atque ullam laborum. Nihil saepe laborum velit repudiandae iste sit.", "PG-13", "102 minutes", "Non minus aut.", new DateTime(2024, 2, 7, 12, 48, 54, 36, DateTimeKind.Utc).AddTicks(4782) },
                    { 4, new DateTime(2024, 2, 7, 12, 48, 54, 38, DateTimeKind.Utc).AddTicks(9765), "Laborum occaecati ab rerum et tenetur consequuntur suscipit perferendis. Non exercitationem soluta. Neque debitis ipsa ab. Iste sit alias aut.\n\nAt nam dignissimos. Est sit autem qui. Minima cum eum illo.", "PG-13", "139 minutes", "Nihil vel facilis.", new DateTime(2024, 2, 7, 12, 48, 54, 38, DateTimeKind.Utc).AddTicks(9768) },
                    { 5, new DateTime(2024, 2, 7, 12, 48, 54, 41, DateTimeKind.Utc).AddTicks(2870), "Est dignissimos consequuntur omnis. Quia omnis voluptates. Perspiciatis error explicabo. Veritatis provident ipsa harum.\n\nSimilique animi voluptatem autem. Aut odit aut amet velit dolore illum saepe qui dignissimos. Ut quo aut nostrum debitis ut soluta numquam facere et. Animi tenetur odio dolorem expedita ut. Ad aliquam voluptates facilis. Ea rerum enim doloremque dolor magni.", "PG", "155 minutes", "Ratione dolor et.", new DateTime(2024, 2, 7, 12, 48, 54, 41, DateTimeKind.Utc).AddTicks(2872) },
                    { 6, new DateTime(2024, 2, 7, 12, 48, 54, 43, DateTimeKind.Utc).AddTicks(6194), "Minima reprehenderit consequatur adipisci et quos voluptas qui qui. Repellat possimus sint dolores. Unde ut consequatur at. Veniam rerum tenetur sunt rem qui facilis eum eum.\n\nEum repudiandae sed voluptatem repellendus. Alias numquam qui repellat consequuntur mollitia fugit magni qui. Mollitia corporis eum consequatur vel et nisi expedita in. Quia esse tempora ratione aspernatur pariatur.", "R", "78 minutes", "Pariatur est iste.", new DateTime(2024, 2, 7, 12, 48, 54, 43, DateTimeKind.Utc).AddTicks(6195) },
                    { 7, new DateTime(2024, 2, 7, 12, 48, 54, 45, DateTimeKind.Utc).AddTicks(9470), "Aut quas nam corporis inventore qui quae placeat. Omnis sapiente qui minus voluptatem nobis voluptatibus sunt impedit. Ratione provident ipsa provident nisi aperiam est facere sed. Veritatis quisquam hic molestiae repudiandae quia hic. Libero unde facilis enim fuga qui dolores.\n\nQuam ex rem rerum quia molestias. Et iusto et. Rerum voluptatem laudantium delectus ut. Minima vitae provident quasi sint earum. Et nisi omnis doloribus in dicta odit nam consequatur. Aut corporis est quod repellat ea et eum.", "PG-13", "102 minutes", "Itaque et nihil.", new DateTime(2024, 2, 7, 12, 48, 54, 45, DateTimeKind.Utc).AddTicks(9471) },
                    { 8, new DateTime(2024, 2, 7, 12, 48, 54, 48, DateTimeKind.Utc).AddTicks(5016), "Occaecati odio voluptatem sed non eum enim qui nemo quos. Animi id nisi qui ut nesciunt error nihil eligendi. Velit dolor qui aut excepturi aliquam quae voluptates quia. Eos cupiditate voluptates nihil et totam blanditiis nihil. Ipsum ipsam reprehenderit et sunt consectetur rerum.\n\nQuia et facilis rerum sequi laudantium sapiente unde odit. Cupiditate nihil quibusdam eum illo. Aliquam sed fugiat nihil veniam velit. Rerum autem sed enim quia officia.", "G", "126 minutes", "Non vitae aut.", new DateTime(2024, 2, 7, 12, 48, 54, 48, DateTimeKind.Utc).AddTicks(5021) },
                    { 9, new DateTime(2024, 2, 7, 12, 48, 54, 50, DateTimeKind.Utc).AddTicks(8703), "Tenetur adipisci nobis. Laboriosam sunt quod explicabo. Repellendus et facere a voluptas iusto recusandae et aspernatur.\n\nOmnis vel praesentium totam ducimus aliquid rem. Accusantium est et dignissimos quod nobis cumque velit excepturi. Molestias alias architecto minima nihil ipsam provident. Blanditiis est eligendi ipsam eum et possimus. Dicta facilis libero ea asperiores aut autem. Quos dolores non culpa porro autem suscipit.", "PG-13", "165 minutes", "Tenetur natus quis.", new DateTime(2024, 2, 7, 12, 48, 54, 50, DateTimeKind.Utc).AddTicks(8705) },
                    { 10, new DateTime(2024, 2, 7, 12, 48, 54, 53, DateTimeKind.Utc).AddTicks(2766), "Perspiciatis et tempore vel autem eum. Ea iste alias sint consequuntur quasi repudiandae. Enim omnis consequuntur tempore eius maiores.\n\nCulpa a recusandae aut dolores mollitia debitis asperiores. Consequatur qui modi exercitationem esse illo odio voluptates fugit sequi. Ducimus non voluptate doloremque dignissimos rerum dolorem nisi id. Sunt doloremque tempore similique nulla et molestiae cum nesciunt. Aut tempora omnis et sit deleniti quam non esse et. Quis est consequatur quasi enim illum.", "PG-13", "104 minutes", "Qui numquam rem.", new DateTime(2024, 2, 7, 12, 48, 54, 53, DateTimeKind.Utc).AddTicks(2768) },
                    { 11, new DateTime(2024, 2, 7, 12, 48, 54, 55, DateTimeKind.Utc).AddTicks(6480), "Modi in cupiditate quaerat unde. Temporibus sit facere doloribus atque similique omnis. Est velit sed et eum sed facere cum. Amet odit sit rerum nesciunt. Minus temporibus eos est. Voluptatem et blanditiis voluptas sunt tempore vel.\n\nVitae laborum laudantium sed cupiditate. Accusamus autem assumenda velit quo consequatur et dolores recusandae. Est rem eaque optio quibusdam et sit dignissimos dolor molestiae. Accusantium quasi officia natus. Excepturi aut quidem doloribus vel. Quas vitae harum sapiente expedita dolore et pariatur nobis in.", "PG-13", "126 minutes", "Ullam porro eos.", new DateTime(2024, 2, 7, 12, 48, 54, 55, DateTimeKind.Utc).AddTicks(6482) },
                    { 12, new DateTime(2024, 2, 7, 12, 48, 54, 58, DateTimeKind.Utc).AddTicks(735), "Sed id aut earum ipsum a dolorum voluptatem quasi voluptatum. Rerum adipisci in. Sapiente beatae cumque labore porro excepturi culpa minus pariatur ipsam. Ad enim non.\n\nAd voluptatem est possimus ducimus ut tenetur aspernatur laudantium. Dolorem dolores et laudantium impedit dolor. Labore provident repellendus. Iste doloremque officiis molestias laudantium. Voluptas asperiores numquam fugiat.", "PG", "135 minutes", "Sed fugiat excepturi.", new DateTime(2024, 2, 7, 12, 48, 54, 58, DateTimeKind.Utc).AddTicks(735) },
                    { 13, new DateTime(2024, 2, 7, 12, 48, 54, 60, DateTimeKind.Utc).AddTicks(4460), "Iste et qui voluptatem officiis. Et velit commodi. Quisquam magni tenetur quia quo eum consectetur qui. Quasi aut et quia quaerat cumque quia illo occaecati ut. Cupiditate nemo fugiat blanditiis repellendus delectus ad molestias.\n\nPlaceat corporis qui impedit doloribus. Omnis minus dicta esse. Sint dolor iusto totam dolore rerum corrupti minima.", "PG-13", "89 minutes", "Ratione in aut.", new DateTime(2024, 2, 7, 12, 48, 54, 60, DateTimeKind.Utc).AddTicks(4461) },
                    { 14, new DateTime(2024, 2, 7, 12, 48, 54, 62, DateTimeKind.Utc).AddTicks(8016), "Voluptas et et eum vitae. Ut voluptas qui quia dolorem a culpa. Voluptas hic omnis earum consequuntur quaerat est.\n\nLabore saepe explicabo veniam similique error aliquid consequatur accusamus. Id aut dolores rerum saepe soluta maxime inventore quasi et. Illum et quibusdam similique est perspiciatis quam. Ad aut similique voluptatum eos consequatur. Molestias nisi eum. Ipsum et qui sed voluptatem.", "R", "120 minutes", "Quis sed architecto.", new DateTime(2024, 2, 7, 12, 48, 54, 62, DateTimeKind.Utc).AddTicks(8018) },
                    { 15, new DateTime(2024, 2, 7, 12, 48, 54, 66, DateTimeKind.Utc).AddTicks(205), "Quas cum atque sed. Ea quae velit perferendis eos laborum asperiores aspernatur. Cupiditate occaecati quia sunt.\n\nQuis eum voluptatem nam magnam tempore iure. Reiciendis est quam ipsum sint. Similique unde adipisci soluta eius maxime. Voluptas quia qui rem corporis. Modi suscipit enim nam voluptatem laudantium explicabo.", "PG-13", "78 minutes", "Culpa consequatur tempore.", new DateTime(2024, 2, 7, 12, 48, 54, 66, DateTimeKind.Utc).AddTicks(206) },
                    { 16, new DateTime(2024, 2, 7, 12, 48, 54, 68, DateTimeKind.Utc).AddTicks(4698), "Est eaque est illum repellendus nisi voluptate doloribus. Ut laboriosam laudantium. Voluptatibus temporibus asperiores ut debitis consequatur dolorum et. Ipsa in omnis cum adipisci quos. Qui voluptas rerum excepturi sed. Minima provident est sequi.\n\nQuasi sunt non. Et aliquam fugiat ratione facilis inventore quibusdam vel. Voluptas et ratione dolorem sunt est esse suscipit autem.", "PG-13", "88 minutes", "Ut voluptatem est.", new DateTime(2024, 2, 7, 12, 48, 54, 68, DateTimeKind.Utc).AddTicks(4699) },
                    { 17, new DateTime(2024, 2, 7, 12, 48, 54, 70, DateTimeKind.Utc).AddTicks(9103), "Sit doloribus ut reiciendis earum. Doloribus id aut aut nobis odit eos quia. Aut harum voluptas neque id voluptatem. Quam ut quis.\n\nUnde sapiente doloribus in fuga perspiciatis possimus non eos. Assumenda et consequatur. Nam provident aut error vitae quas iste. Pariatur esse perspiciatis et recusandae dolor est.", "PG", "75 minutes", "Eius aut exercitationem.", new DateTime(2024, 2, 7, 12, 48, 54, 70, DateTimeKind.Utc).AddTicks(9104) },
                    { 18, new DateTime(2024, 2, 7, 12, 48, 54, 73, DateTimeKind.Utc).AddTicks(3117), "Non nostrum eaque veniam dicta et perferendis aut vero et. Ad commodi qui est nam sint aut in cum nisi. Quibusdam quasi architecto est exercitationem. Nesciunt id ex voluptatem ut.\n\nPorro in est explicabo iusto. Ea inventore quam est doloremque earum. Quasi qui nulla accusantium dolore nulla aut quia aliquid.", "G", "139 minutes", "Similique incidunt nulla.", new DateTime(2024, 2, 7, 12, 48, 54, 73, DateTimeKind.Utc).AddTicks(3118) },
                    { 19, new DateTime(2024, 2, 7, 12, 48, 54, 75, DateTimeKind.Utc).AddTicks(7301), "Non nemo nihil excepturi sunt enim minima maiores. Nobis animi omnis aperiam esse asperiores deserunt sed officia voluptatum. Quisquam quo recusandae. Blanditiis rerum dicta quos aliquam facere voluptatum recusandae officiis. Ex deserunt est sit ab magnam aut.\n\nVoluptates rerum quia voluptatem temporibus sint temporibus molestiae et soluta. Modi quisquam ut odit distinctio. Aliquam soluta omnis est omnis ut voluptatum.", "PG", "85 minutes", "Aliquid tempora nisi.", new DateTime(2024, 2, 7, 12, 48, 54, 75, DateTimeKind.Utc).AddTicks(7302) },
                    { 20, new DateTime(2024, 2, 7, 12, 48, 54, 78, DateTimeKind.Utc).AddTicks(1557), "Dolores ipsa pariatur. Ex voluptatem sequi ad error numquam et. Exercitationem rerum quia nobis omnis qui dolore dolorum rerum.\n\nLaboriosam voluptates odit officia vel pariatur quae illum. Doloribus qui dolorem animi beatae rerum porro quisquam eveniet. Harum fuga atque eum mollitia quis.", "G", "96 minutes", "Praesentium cumque aliquam.", new DateTime(2024, 2, 7, 12, 48, 54, 78, DateTimeKind.Utc).AddTicks(1558) }
                });

            migrationBuilder.InsertData(
                table: "screening",
                columns: new[] { "id", "capacity", "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[,]
                {
                    { 1, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9323), 19, 3, new DateTime(2024, 2, 11, 5, 48, 54, 80, DateTimeKind.Utc).AddTicks(9329), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9328) },
                    { 2, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9345), 11, 2, new DateTime(2024, 2, 14, 6, 48, 54, 80, DateTimeKind.Utc).AddTicks(9345), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9345) },
                    { 3, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9346), 9, 4, new DateTime(2024, 2, 12, 3, 48, 54, 80, DateTimeKind.Utc).AddTicks(9347), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9347) },
                    { 4, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9348), 18, 4, new DateTime(2024, 2, 13, 5, 48, 54, 80, DateTimeKind.Utc).AddTicks(9348), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9348) },
                    { 5, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9349), 16, 1, new DateTime(2024, 2, 12, 0, 48, 54, 80, DateTimeKind.Utc).AddTicks(9350), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9349) },
                    { 6, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9352), 17, 1, new DateTime(2024, 2, 13, 1, 48, 54, 80, DateTimeKind.Utc).AddTicks(9352), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9352) },
                    { 7, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9353), 4, 1, new DateTime(2024, 2, 11, 5, 48, 54, 80, DateTimeKind.Utc).AddTicks(9354), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9353) },
                    { 8, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9355), 11, 2, new DateTime(2024, 2, 10, 22, 48, 54, 80, DateTimeKind.Utc).AddTicks(9355), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9355) },
                    { 9, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9356), 18, 2, new DateTime(2024, 2, 10, 2, 48, 54, 80, DateTimeKind.Utc).AddTicks(9357), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9356) },
                    { 10, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9358), 2, 3, new DateTime(2024, 2, 14, 0, 48, 54, 80, DateTimeKind.Utc).AddTicks(9359), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9358) },
                    { 11, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9359), 10, 3, new DateTime(2024, 2, 11, 3, 48, 54, 80, DateTimeKind.Utc).AddTicks(9360), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9360) },
                    { 12, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9361), 18, 4, new DateTime(2024, 2, 9, 7, 48, 54, 80, DateTimeKind.Utc).AddTicks(9361), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9361) },
                    { 13, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9362), 19, 2, new DateTime(2024, 2, 10, 1, 48, 54, 80, DateTimeKind.Utc).AddTicks(9362), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9362) },
                    { 14, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9363), 19, 4, new DateTime(2024, 2, 10, 3, 48, 54, 80, DateTimeKind.Utc).AddTicks(9364), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9363) },
                    { 15, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9364), 10, 4, new DateTime(2024, 2, 13, 22, 48, 54, 80, DateTimeKind.Utc).AddTicks(9365), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9364) },
                    { 16, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9381), 8, 3, new DateTime(2024, 2, 10, 0, 48, 54, 80, DateTimeKind.Utc).AddTicks(9381), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9381) },
                    { 17, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9382), 17, 3, new DateTime(2024, 2, 13, 6, 48, 54, 80, DateTimeKind.Utc).AddTicks(9382), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9382) },
                    { 18, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9391), 7, 1, new DateTime(2024, 2, 9, 22, 48, 54, 80, DateTimeKind.Utc).AddTicks(9392), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9392) },
                    { 19, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9393), 17, 2, new DateTime(2024, 2, 13, 5, 48, 54, 80, DateTimeKind.Utc).AddTicks(9393), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9393) },
                    { 20, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9394), 5, 1, new DateTime(2024, 2, 9, 0, 48, 54, 80, DateTimeKind.Utc).AddTicks(9394), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9394) },
                    { 21, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9395), 16, 1, new DateTime(2024, 2, 11, 0, 48, 54, 80, DateTimeKind.Utc).AddTicks(9395), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9395) },
                    { 22, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9396), 10, 1, new DateTime(2024, 2, 12, 2, 48, 54, 80, DateTimeKind.Utc).AddTicks(9396), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9396) },
                    { 23, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9397), 4, 1, new DateTime(2024, 2, 12, 23, 48, 54, 80, DateTimeKind.Utc).AddTicks(9398), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9397) },
                    { 24, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9398), 1, 4, new DateTime(2024, 2, 12, 22, 48, 54, 80, DateTimeKind.Utc).AddTicks(9399), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9398) },
                    { 25, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9399), 6, 4, new DateTime(2024, 2, 14, 0, 48, 54, 80, DateTimeKind.Utc).AddTicks(9400), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9400) },
                    { 26, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9400), 9, 4, new DateTime(2024, 2, 11, 2, 48, 54, 80, DateTimeKind.Utc).AddTicks(9401), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9401) },
                    { 27, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9402), 3, 2, new DateTime(2024, 2, 8, 23, 48, 54, 80, DateTimeKind.Utc).AddTicks(9402), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9402) },
                    { 28, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9403), 2, 4, new DateTime(2024, 2, 13, 4, 48, 54, 80, DateTimeKind.Utc).AddTicks(9403), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9403) },
                    { 29, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9404), 14, 1, new DateTime(2024, 2, 9, 0, 48, 54, 80, DateTimeKind.Utc).AddTicks(9404), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9404) },
                    { 30, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9405), 17, 2, new DateTime(2024, 2, 10, 22, 48, 54, 80, DateTimeKind.Utc).AddTicks(9405), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9405) },
                    { 31, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9411), 5, 2, new DateTime(2024, 2, 11, 0, 48, 54, 80, DateTimeKind.Utc).AddTicks(9412), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9411) },
                    { 32, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9412), 12, 2, new DateTime(2024, 2, 9, 3, 48, 54, 80, DateTimeKind.Utc).AddTicks(9413), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9413) },
                    { 33, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9413), 6, 4, new DateTime(2024, 2, 13, 1, 48, 54, 80, DateTimeKind.Utc).AddTicks(9414), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9414) },
                    { 34, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9416), 10, 4, new DateTime(2024, 2, 10, 5, 48, 54, 80, DateTimeKind.Utc).AddTicks(9416), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9416) },
                    { 35, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9417), 15, 1, new DateTime(2024, 2, 10, 5, 48, 54, 80, DateTimeKind.Utc).AddTicks(9418), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9417) },
                    { 36, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9418), 17, 2, new DateTime(2024, 2, 10, 22, 48, 54, 80, DateTimeKind.Utc).AddTicks(9419), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9418) },
                    { 37, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9419), 20, 1, new DateTime(2024, 2, 14, 2, 48, 54, 80, DateTimeKind.Utc).AddTicks(9420), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9420) },
                    { 38, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9420), 4, 4, new DateTime(2024, 2, 11, 22, 48, 54, 80, DateTimeKind.Utc).AddTicks(9421), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9421) },
                    { 39, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9421), 11, 3, new DateTime(2024, 2, 14, 2, 48, 54, 80, DateTimeKind.Utc).AddTicks(9422), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9422) },
                    { 40, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9423), 11, 3, new DateTime(2024, 2, 10, 2, 48, 54, 80, DateTimeKind.Utc).AddTicks(9423), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9423) },
                    { 41, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9424), 13, 3, new DateTime(2024, 2, 12, 0, 48, 54, 80, DateTimeKind.Utc).AddTicks(9424), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9424) },
                    { 42, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9425), 20, 2, new DateTime(2024, 2, 9, 23, 48, 54, 80, DateTimeKind.Utc).AddTicks(9426), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9425) },
                    { 43, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9426), 1, 1, new DateTime(2024, 2, 13, 23, 48, 54, 80, DateTimeKind.Utc).AddTicks(9427), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9426) },
                    { 44, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9427), 4, 2, new DateTime(2024, 2, 13, 1, 48, 54, 80, DateTimeKind.Utc).AddTicks(9428), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9428) },
                    { 45, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9428), 15, 4, new DateTime(2024, 2, 9, 0, 48, 54, 80, DateTimeKind.Utc).AddTicks(9429), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9429) },
                    { 46, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9430), 12, 4, new DateTime(2024, 2, 9, 3, 48, 54, 80, DateTimeKind.Utc).AddTicks(9430), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9430) },
                    { 47, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9431), 2, 3, new DateTime(2024, 2, 9, 23, 48, 54, 80, DateTimeKind.Utc).AddTicks(9431), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9431) },
                    { 48, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9432), 3, 4, new DateTime(2024, 2, 13, 22, 48, 54, 80, DateTimeKind.Utc).AddTicks(9432), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9432) },
                    { 49, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9433), 16, 3, new DateTime(2024, 2, 9, 6, 48, 54, 80, DateTimeKind.Utc).AddTicks(9433), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9433) },
                    { 50, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9434), 16, 3, new DateTime(2024, 2, 14, 1, 48, 54, 80, DateTimeKind.Utc).AddTicks(9434), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9434) },
                    { 51, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9435), 1, 4, new DateTime(2024, 2, 8, 23, 48, 54, 80, DateTimeKind.Utc).AddTicks(9436), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9435) },
                    { 52, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9436), 3, 4, new DateTime(2024, 2, 9, 6, 48, 54, 80, DateTimeKind.Utc).AddTicks(9437), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9436) },
                    { 53, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9437), 20, 1, new DateTime(2024, 2, 12, 5, 48, 54, 80, DateTimeKind.Utc).AddTicks(9438), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9438) },
                    { 54, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9438), 19, 2, new DateTime(2024, 2, 10, 4, 48, 54, 80, DateTimeKind.Utc).AddTicks(9439), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9439) },
                    { 55, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9440), 2, 2, new DateTime(2024, 2, 13, 5, 48, 54, 80, DateTimeKind.Utc).AddTicks(9440), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9440) },
                    { 56, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9441), 19, 3, new DateTime(2024, 2, 9, 22, 48, 54, 80, DateTimeKind.Utc).AddTicks(9441), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9441) },
                    { 57, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9442), 12, 3, new DateTime(2024, 2, 13, 7, 48, 54, 80, DateTimeKind.Utc).AddTicks(9442), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9442) },
                    { 58, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9443), 5, 1, new DateTime(2024, 2, 11, 5, 48, 54, 80, DateTimeKind.Utc).AddTicks(9443), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9443) },
                    { 59, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9444), 15, 4, new DateTime(2024, 2, 12, 7, 48, 54, 80, DateTimeKind.Utc).AddTicks(9444), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9444) },
                    { 60, 50, new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9445), 6, 3, new DateTime(2024, 2, 11, 4, 48, 54, 80, DateTimeKind.Utc).AddTicks(9445), new DateTime(2024, 2, 7, 12, 48, 54, 80, DateTimeKind.Utc).AddTicks(9445) }
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
