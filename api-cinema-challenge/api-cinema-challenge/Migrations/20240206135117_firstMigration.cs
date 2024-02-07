using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
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
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    created_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    title = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    run_time = table.Column<int>(type: "integer", nullable: false),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "screening",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    screen_number = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    movie_id = table.Column<int>(type: "integer", nullable: false),
                    start_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screening", x => x.id);
                    table.ForeignKey(
                        name: "FK_screening_movies_movie_id",
                        column: x => x.movie_id,
                        principalTable: "movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "created_time", "email", "name", "phone", "updated_time" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(8919), "audrey.jagger@bbc.co.uk", "Audrey Jagger", "+692771967", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(8922) },
                    { 2, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9002), "elvis.middleton@gov.us", "Elvis Middleton", "+863938371", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9002) },
                    { 3, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9059), "mick.trump@something.com", "Mick Trump", "+388798298", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9059) },
                    { 4, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9062), "jimi.jagger@gov.gr", "Jimi Jagger", "+602945908", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9063) },
                    { 5, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9065), "barack.middleton@nasa.org.us", "Barack Middleton", "+185613372", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9065) },
                    { 6, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9071), "charles.winfrey@gov.gr", "Charles Winfrey", "+299349731", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9071) },
                    { 7, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9074), "barack.obama@gov.nl", "Barack Obama", "+754759525", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9074) },
                    { 8, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9076), "oprah.windsor@nasa.org.us", "Oprah Windsor", "+913569142", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9076) },
                    { 9, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9078), "kate.hepburn@gov.ru", "Kate Hepburn", "+452324554", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9079) },
                    { 10, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9082), "barack.middleton@nasa.org.us", "Barack Middleton", "+168476193", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9082) },
                    { 11, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9085), "charles.windsor@gov.us", "Charles Windsor", "+755027665", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9085) },
                    { 12, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9087), "mick.presley@something.com", "Mick Presley", "+259514417", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9088) },
                    { 13, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9090), "jimi.presley@gov.nl", "Jimi Presley", "+908093651", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9090) },
                    { 14, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9092), "charles.presley@google.com", "Charles Presley", "+713158961", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9092) },
                    { 15, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9094), "oprah.presley@gov.gr", "Oprah Presley", "+387421965", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9094) },
                    { 16, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9096), "elvis.presley@tesla.com", "Elvis Presley", "+365284974", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9096) },
                    { 17, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9098), "barack.presley@gov.us", "Barack Presley", "+825227757", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9099) },
                    { 18, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9137), "charles.hendrix@theworld.ca", "Charles Hendrix", "+852702624", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9137) },
                    { 19, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9140), "charles.winfrey@gov.nl", "Charles Winfrey", "+815415773", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9140) },
                    { 20, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9142), "kate.presley@tesla.com", "Kate Presley", "+727212533", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9142) },
                    { 21, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9144), "donald.hepburn@tesla.com", "Donald Hepburn", "+315682851", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9145) },
                    { 22, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9147), "jimi.winfrey@nasa.org.us", "Jimi Winfrey", "+664005935", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9147) },
                    { 23, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9149), "donald.middleton@gov.us", "Donald Middleton", "+841131403", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9149) },
                    { 24, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9152), "audrey.hendrix@theworld.ca", "Audrey Hendrix", "+760983225", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9152) },
                    { 25, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9154), "charles.winfrey@theworld.ca", "Charles Winfrey", "+143818058", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9154) },
                    { 26, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9156), "audrey.winfrey@gov.nl", "Audrey Winfrey", "+773687622", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9156) },
                    { 27, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9158), "charles.presley@bbc.co.uk", "Charles Presley", "+503869596", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9158) },
                    { 28, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9160), "oprah.windsor@gov.us", "Oprah Windsor", "+515741737", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9160) },
                    { 29, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9162), "charles.middleton@gov.gr", "Charles Middleton", "+110460764", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9162) },
                    { 30, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9165), "audrey.jagger@gov.nl", "Audrey Jagger", "+811395062", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9165) },
                    { 31, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9167), "audrey.hendrix@something.com", "Audrey Hendrix", "+787177426", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9167) },
                    { 32, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9169), "kate.windsor@gov.ru", "Kate Windsor", "+754354717", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9170) },
                    { 33, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9171), "donald.trump@gov.nl", "Donald Trump", "+654739485", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9171) },
                    { 34, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9175), "barack.windsor@gov.us", "Barack Windsor", "+105874406", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9175) },
                    { 35, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9178), "oprah.windsor@gov.gr", "Oprah Windsor", "+525356900", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9178) },
                    { 36, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9180), "donald.hepburn@gov.ru", "Donald Hepburn", "+160084351", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9180) },
                    { 37, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9182), "barack.presley@gov.ru", "Barack Presley", "+276038001", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9183) },
                    { 38, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9185), "audrey.winslet@something.com", "Audrey Winslet", "+637793559", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9185) },
                    { 39, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9214), "kate.hendrix@gov.us", "Kate Hendrix", "+263518933", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9215) },
                    { 40, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9217), "kate.windsor@gov.nl", "Kate Windsor", "+979585033", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9217) },
                    { 41, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9219), "kate.hepburn@something.com", "Kate Hepburn", "+403115577", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9219) },
                    { 42, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9221), "kate.hendrix@gov.us", "Kate Hendrix", "+169653013", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9222) },
                    { 43, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9223), "kate.windsor@gov.ru", "Kate Windsor", "+310479187", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9224) },
                    { 44, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9225), "kate.trump@nasa.org.us", "Kate Trump", "+285540247", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9226) },
                    { 45, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9228), "mick.presley@gov.us", "Mick Presley", "+103014729", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9228) },
                    { 46, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9230), "oprah.winfrey@gov.ru", "Oprah Winfrey", "+981342712", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9230) },
                    { 47, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9231), "oprah.winslet@gov.nl", "Oprah Winslet", "+567506657", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9232) },
                    { 48, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9234), "elvis.jagger@google.com", "Elvis Jagger", "+774708490", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9234) },
                    { 49, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9236), "kate.presley@theworld.ca", "Kate Presley", "+843491191", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9236) },
                    { 50, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9238), "charles.obama@gov.nl", "Charles Obama", "+251586054", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9238) },
                    { 51, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9240), "kate.hendrix@gov.ru", "Kate Hendrix", "+592878781", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9240) },
                    { 52, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9242), "jimi.hendrix@something.com", "Jimi Hendrix", "+714881700", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9242) },
                    { 53, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9244), "oprah.hendrix@gov.gr", "Oprah Hendrix", "+811211551", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9245) },
                    { 54, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9246), "barack.jagger@nasa.org.us", "Barack Jagger", "+343801524", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9246) },
                    { 55, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9248), "jimi.obama@theworld.ca", "Jimi Obama", "+652617114", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9248) },
                    { 56, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9250), "mick.trump@tesla.com", "Mick Trump", "+120924932", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9250) },
                    { 57, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9252), "charles.winfrey@something.com", "Charles Winfrey", "+997441554", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9252) },
                    { 58, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9254), "kate.winslet@gov.nl", "Kate Winslet", "+155530609", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9255) },
                    { 59, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9257), "donald.winfrey@gov.nl", "Donald Winfrey", "+484956352", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9257) },
                    { 60, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9258), "elvis.jagger@nasa.org.us", "Elvis Jagger", "+737738012", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9259) },
                    { 61, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9260), "mick.windsor@gov.us", "Mick Windsor", "+584896347", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9261) },
                    { 62, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9262), "audrey.hepburn@tesla.com", "Audrey Hepburn", "+242782249", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9263) },
                    { 63, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9310), "elvis.jagger@gov.nl", "Elvis Jagger", "+104324788", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9310) },
                    { 64, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9313), "barack.windsor@bbc.co.uk", "Barack Windsor", "+259890403", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9313) },
                    { 65, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9315), "kate.winslet@something.com", "Kate Winslet", "+906091485", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9315) },
                    { 66, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9319), "mick.hepburn@gov.gr", "Mick Hepburn", "+430503131", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9319) },
                    { 67, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9321), "kate.hendrix@theworld.ca", "Kate Hendrix", "+234882172", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9322) },
                    { 68, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9324), "audrey.windsor@google.com", "Audrey Windsor", "+687532360", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9324) },
                    { 69, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9326), "donald.middleton@gov.nl", "Donald Middleton", "+432317731", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9326) },
                    { 70, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9328), "elvis.windsor@gov.nl", "Elvis Windsor", "+452593768", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9328) },
                    { 71, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9330), "kate.jagger@gov.us", "Kate Jagger", "+644667606", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9330) },
                    { 72, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9332), "barack.presley@tesla.com", "Barack Presley", "+457575345", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9332) },
                    { 73, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9334), "barack.hendrix@gov.nl", "Barack Hendrix", "+585825042", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9334) },
                    { 74, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9336), "elvis.obama@gov.ru", "Elvis Obama", "+321779318", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9336) },
                    { 75, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9338), "barack.hendrix@gov.ru", "Barack Hendrix", "+224782085", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9339) },
                    { 76, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9341), "kate.presley@gov.nl", "Kate Presley", "+484639769", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9341) },
                    { 77, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9342), "oprah.jagger@google.com", "Oprah Jagger", "+938944646", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9343) },
                    { 78, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9344), "barack.winfrey@something.com", "Barack Winfrey", "+217659368", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9345) },
                    { 79, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9347), "kate.presley@tesla.com", "Kate Presley", "+797734061", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9347) },
                    { 80, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9349), "oprah.winslet@tesla.com", "Oprah Winslet", "+269263770", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9349) },
                    { 81, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9351), "audrey.obama@google.com", "Audrey Obama", "+102434369", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9351) },
                    { 82, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9353), "elvis.presley@nasa.org.us", "Elvis Presley", "+273432467", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9353) },
                    { 83, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9395), "jimi.winfrey@gov.us", "Jimi Winfrey", "+218487992", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9395) },
                    { 84, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9397), "audrey.hendrix@gov.nl", "Audrey Hendrix", "+578579866", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9398) },
                    { 85, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9400), "audrey.windsor@bbc.co.uk", "Audrey Windsor", "+419051879", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9400) },
                    { 86, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9402), "kate.windsor@bbc.co.uk", "Kate Windsor", "+599289330", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9402) },
                    { 87, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9404), "elvis.jagger@bbc.co.uk", "Elvis Jagger", "+634415371", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9405) },
                    { 88, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9407), "oprah.trump@bbc.co.uk", "Oprah Trump", "+964139272", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9407) },
                    { 89, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9409), "elvis.windsor@something.com", "Elvis Windsor", "+701022225", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9409) },
                    { 90, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9411), "kate.hepburn@theworld.ca", "Kate Hepburn", "+560802872", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9411) },
                    { 91, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9413), "kate.winslet@something.com", "Kate Winslet", "+276193260", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9413) },
                    { 92, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9415), "elvis.hepburn@gov.us", "Elvis Hepburn", "+293225200", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9415) },
                    { 93, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9417), "elvis.jagger@gov.ru", "Elvis Jagger", "+153536425", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9417) },
                    { 94, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9419), "kate.trump@nasa.org.us", "Kate Trump", "+430604868", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9419) },
                    { 95, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9421), "barack.trump@gov.us", "Barack Trump", "+103544852", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9421) },
                    { 96, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9423), "oprah.jagger@gov.gr", "Oprah Jagger", "+214431924", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9423) },
                    { 97, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9425), "mick.trump@nasa.org.us", "Mick Trump", "+829811770", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9426) },
                    { 98, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9427), "elvis.windsor@something.com", "Elvis Windsor", "+164993401", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9428) },
                    { 99, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9430), "audrey.winslet@bbc.co.uk", "Audrey Winslet", "+235030171", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9430) },
                    { 100, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9432), "kate.middleton@tesla.com", "Kate Middleton", "+796035847", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9432) },
                    { 101, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9434), "elvis.hepburn@tesla.com", "Elvis Hepburn", "+134204740", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9434) },
                    { 102, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9436), "elvis.winslet@something.com", "Elvis Winslet", "+869411830", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9436) },
                    { 103, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9438), "jimi.middleton@something.com", "Jimi Middleton", "+261487677", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9438) },
                    { 104, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9440), "donald.winslet@gov.us", "Donald Winslet", "+914993866", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9440) },
                    { 105, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9442), "jimi.winslet@something.com", "Jimi Winslet", "+902940416", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9442) },
                    { 106, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9490), "elvis.hendrix@google.com", "Elvis Hendrix", "+441169026", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9490) },
                    { 107, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9493), "donald.windsor@gov.nl", "Donald Windsor", "+351687802", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9493) },
                    { 108, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9495), "donald.winslet@theworld.ca", "Donald Winslet", "+280562275", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9495) },
                    { 109, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9497), "elvis.obama@gov.us", "Elvis Obama", "+599682884", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9498) },
                    { 110, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9500), "charles.presley@nasa.org.us", "Charles Presley", "+441324729", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9500) },
                    { 111, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9502), "barack.hendrix@tesla.com", "Barack Hendrix", "+448091164", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9502) },
                    { 112, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9504), "charles.hepburn@nasa.org.us", "Charles Hepburn", "+992481202", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9505) },
                    { 113, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9507), "kate.presley@tesla.com", "Kate Presley", "+854240419", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9507) },
                    { 114, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9509), "barack.winfrey@gov.us", "Barack Winfrey", "+944450186", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9509) },
                    { 115, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9511), "jimi.trump@theworld.ca", "Jimi Trump", "+697582900", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9511) },
                    { 116, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9513), "donald.presley@bbc.co.uk", "Donald Presley", "+391328093", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9513) },
                    { 117, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9515), "kate.trump@tesla.com", "Kate Trump", "+955709936", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9515) },
                    { 118, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9517), "jimi.middleton@gov.gr", "Jimi Middleton", "+660139446", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9517) },
                    { 119, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9519), "kate.obama@gov.ru", "Kate Obama", "+386348042", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9519) },
                    { 120, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9521), "barack.obama@theworld.ca", "Barack Obama", "+145500682", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9522) },
                    { 121, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9523), "charles.windsor@tesla.com", "Charles Windsor", "+374954826", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9523) },
                    { 122, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9525), "elvis.windsor@tesla.com", "Elvis Windsor", "+854321647", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9525) },
                    { 123, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9527), "oprah.winfrey@theworld.ca", "Oprah Winfrey", "+292884890", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9528) },
                    { 124, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9529), "oprah.jagger@gov.ru", "Oprah Jagger", "+118873385", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9529) },
                    { 125, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9531), "kate.hendrix@theworld.ca", "Kate Hendrix", "+516464425", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9531) },
                    { 126, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9533), "audrey.obama@gov.nl", "Audrey Obama", "+321002320", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9534) },
                    { 127, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9535), "charles.winfrey@gov.nl", "Charles Winfrey", "+524507759", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9536) },
                    { 128, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9537), "kate.winfrey@tesla.com", "Kate Winfrey", "+502766500", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9538) },
                    { 129, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9585), "audrey.trump@gov.nl", "Audrey Trump", "+398046203", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9585) },
                    { 130, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9588), "jimi.trump@nasa.org.us", "Jimi Trump", "+288018652", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9589) },
                    { 131, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9591), "charles.hendrix@google.com", "Charles Hendrix", "+363659131", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9592) },
                    { 132, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9594), "donald.jagger@gov.ru", "Donald Jagger", "+513140704", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9594) },
                    { 133, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9596), "elvis.obama@gov.ru", "Elvis Obama", "+236105140", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9596) },
                    { 134, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9598), "kate.hepburn@google.com", "Kate Hepburn", "+572891815", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9598) },
                    { 135, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9600), "donald.presley@bbc.co.uk", "Donald Presley", "+467761615", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9600) },
                    { 136, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9602), "mick.hepburn@theworld.ca", "Mick Hepburn", "+866784901", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9602) },
                    { 137, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9604), "jimi.hendrix@gov.ru", "Jimi Hendrix", "+276318108", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9604) },
                    { 138, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9607), "mick.winslet@gov.nl", "Mick Winslet", "+863999340", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9607) },
                    { 139, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9609), "barack.middleton@bbc.co.uk", "Barack Middleton", "+379777710", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9609) },
                    { 140, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9611), "oprah.trump@theworld.ca", "Oprah Trump", "+990807750", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9611) },
                    { 141, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9613), "donald.jagger@gov.gr", "Donald Jagger", "+646669884", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9613) },
                    { 142, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9615), "mick.winslet@gov.ru", "Mick Winslet", "+600801075", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9615) },
                    { 143, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9617), "charles.presley@gov.gr", "Charles Presley", "+479925367", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9617) },
                    { 144, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9619), "kate.trump@google.com", "Kate Trump", "+209186405", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9619) },
                    { 145, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9621), "kate.winslet@gov.nl", "Kate Winslet", "+206324237", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9621) },
                    { 146, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9623), "audrey.windsor@gov.gr", "Audrey Windsor", "+569095605", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9623) },
                    { 147, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9649), "mick.presley@gov.us", "Mick Presley", "+787719605", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9649) },
                    { 148, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9651), "charles.presley@gov.us", "Charles Presley", "+630336773", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9652) },
                    { 149, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9654), "jimi.presley@gov.ru", "Jimi Presley", "+482599932", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9654) },
                    { 150, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9656), "elvis.windsor@gov.gr", "Elvis Windsor", "+443669898", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9656) },
                    { 151, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9658), "audrey.obama@nasa.org.us", "Audrey Obama", "+322615543", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9658) },
                    { 152, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9660), "donald.obama@nasa.org.us", "Donald Obama", "+998243553", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9660) },
                    { 153, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9663), "audrey.jagger@something.com", "Audrey Jagger", "+789755885", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9663) },
                    { 154, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9665), "donald.winslet@gov.us", "Donald Winslet", "+326400143", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9665) },
                    { 155, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9667), "charles.hepburn@tesla.com", "Charles Hepburn", "+159966194", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9667) },
                    { 156, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9669), "donald.middleton@google.com", "Donald Middleton", "+787031558", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9669) },
                    { 157, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9671), "mick.obama@gov.gr", "Mick Obama", "+477589369", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9671) },
                    { 158, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9673), "donald.middleton@tesla.com", "Donald Middleton", "+944405692", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9673) },
                    { 159, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9675), "barack.windsor@google.com", "Barack Windsor", "+779490601", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9676) },
                    { 160, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9677), "donald.middleton@something.com", "Donald Middleton", "+361784253", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9678) },
                    { 161, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9680), "audrey.jagger@google.com", "Audrey Jagger", "+889291638", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9680) },
                    { 162, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9682), "oprah.hepburn@gov.gr", "Oprah Hepburn", "+440197931", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9682) },
                    { 163, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9684), "kate.jagger@gov.gr", "Kate Jagger", "+492183281", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9684) },
                    { 164, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9686), "mick.winslet@theworld.ca", "Mick Winslet", "+694928235", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9686) },
                    { 165, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9688), "audrey.presley@gov.gr", "Audrey Presley", "+861707403", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9688) },
                    { 166, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9690), "jimi.presley@nasa.org.us", "Jimi Presley", "+450295476", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9690) },
                    { 167, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9692), "kate.winslet@tesla.com", "Kate Winslet", "+381842701", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9692) },
                    { 168, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9694), "elvis.trump@gov.gr", "Elvis Trump", "+501927604", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9694) },
                    { 169, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9696), "charles.winslet@gov.nl", "Charles Winslet", "+505912986", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9696) },
                    { 170, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9736), "kate.windsor@theworld.ca", "Kate Windsor", "+652695365", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9736) },
                    { 171, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9739), "kate.hendrix@google.com", "Kate Hendrix", "+102354248", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9739) },
                    { 172, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9741), "jimi.winslet@gov.gr", "Jimi Winslet", "+365582884", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9741) },
                    { 173, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9743), "charles.hendrix@tesla.com", "Charles Hendrix", "+364220720", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9744) },
                    { 174, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9745), "donald.winslet@gov.nl", "Donald Winslet", "+197343372", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9746) },
                    { 175, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9748), "jimi.middleton@google.com", "Jimi Middleton", "+868245031", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9748) },
                    { 176, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9750), "kate.jagger@something.com", "Kate Jagger", "+653867271", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9750) },
                    { 177, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9752), "oprah.hepburn@nasa.org.us", "Oprah Hepburn", "+995278636", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9752) },
                    { 178, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9754), "oprah.middleton@something.com", "Oprah Middleton", "+314531370", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9754) },
                    { 179, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9756), "mick.middleton@nasa.org.us", "Mick Middleton", "+445849128", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9756) },
                    { 180, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9758), "kate.middleton@nasa.org.us", "Kate Middleton", "+751473930", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9759) },
                    { 181, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9761), "mick.hepburn@tesla.com", "Mick Hepburn", "+366771798", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9761) },
                    { 182, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9763), "charles.hendrix@google.com", "Charles Hendrix", "+390032890", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9763) },
                    { 183, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9765), "audrey.presley@theworld.ca", "Audrey Presley", "+998293097", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9765) },
                    { 184, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9767), "kate.jagger@gov.nl", "Kate Jagger", "+524082422", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9767) },
                    { 185, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9769), "jimi.middleton@something.com", "Jimi Middleton", "+733594834", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9769) },
                    { 186, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9771), "barack.jagger@something.com", "Barack Jagger", "+702377440", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9771) },
                    { 187, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9773), "charles.hepburn@bbc.co.uk", "Charles Hepburn", "+726999586", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9774) },
                    { 188, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9775), "audrey.hepburn@nasa.org.us", "Audrey Hepburn", "+534659564", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9776) },
                    { 189, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9777), "charles.winfrey@bbc.co.uk", "Charles Winfrey", "+421791704", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9778) },
                    { 190, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9779), "oprah.winslet@gov.nl", "Oprah Winslet", "+538121538", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9779) },
                    { 191, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9781), "kate.middleton@gov.nl", "Kate Middleton", "+607941081", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9782) },
                    { 192, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9832), "donald.trump@bbc.co.uk", "Donald Trump", "+591971267", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9832) },
                    { 193, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9835), "charles.obama@tesla.com", "Charles Obama", "+829154487", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9835) },
                    { 194, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9837), "oprah.middleton@gov.ru", "Oprah Middleton", "+767763461", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9837) },
                    { 195, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9839), "barack.winfrey@gov.us", "Barack Winfrey", "+845083578", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9839) },
                    { 196, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9841), "elvis.obama@google.com", "Elvis Obama", "+159429518", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9842) },
                    { 197, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9843), "mick.windsor@gov.us", "Mick Windsor", "+211009178", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9844) },
                    { 198, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9845), "mick.winslet@gov.ru", "Mick Winslet", "+663542468", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9846) },
                    { 199, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9847), "jimi.windsor@gov.nl", "Jimi Windsor", "+207303823", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9848) },
                    { 200, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9849), "charles.hendrix@gov.ru", "Charles Hendrix", "+893157014", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9850) },
                    { 201, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9851), "jimi.trump@bbc.co.uk", "Jimi Trump", "+602190156", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9852) },
                    { 202, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9854), "charles.hepburn@something.com", "Charles Hepburn", "+866924693", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9854) },
                    { 203, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9856), "kate.hendrix@something.com", "Kate Hendrix", "+466236303", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9856) },
                    { 204, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9858), "charles.trump@nasa.org.us", "Charles Trump", "+984503288", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9858) },
                    { 205, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9860), "barack.trump@tesla.com", "Barack Trump", "+415124922", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9860) },
                    { 206, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9862), "kate.windsor@theworld.ca", "Kate Windsor", "+544684964", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9862) },
                    { 207, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9864), "kate.presley@gov.nl", "Kate Presley", "+710949220", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9864) },
                    { 208, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9866), "barack.hendrix@gov.gr", "Barack Hendrix", "+581621050", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9866) },
                    { 209, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9868), "audrey.hendrix@nasa.org.us", "Audrey Hendrix", "+479321038", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9868) },
                    { 210, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9870), "jimi.hepburn@nasa.org.us", "Jimi Hepburn", "+177337026", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9870) },
                    { 211, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9872), "audrey.trump@google.com", "Audrey Trump", "+108829781", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9872) },
                    { 212, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9874), "audrey.middleton@nasa.org.us", "Audrey Middleton", "+939524261", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9874) },
                    { 213, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9876), "audrey.hepburn@bbc.co.uk", "Audrey Hepburn", "+352735276", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9876) },
                    { 214, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9878), "barack.winfrey@gov.us", "Barack Winfrey", "+840365701", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9878) },
                    { 215, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9927), "audrey.trump@bbc.co.uk", "Audrey Trump", "+416577127", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9927) },
                    { 216, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9929), "barack.hepburn@theworld.ca", "Barack Hepburn", "+326299643", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9930) },
                    { 217, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9932), "oprah.jagger@tesla.com", "Oprah Jagger", "+696892248", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9932) },
                    { 218, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9934), "barack.hendrix@bbc.co.uk", "Barack Hendrix", "+410454017", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9934) },
                    { 219, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9936), "jimi.middleton@google.com", "Jimi Middleton", "+365708721", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9936) },
                    { 220, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9938), "donald.winfrey@gov.gr", "Donald Winfrey", "+760940077", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9938) },
                    { 221, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9940), "barack.windsor@nasa.org.us", "Barack Windsor", "+635069718", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9941) },
                    { 222, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9943), "audrey.obama@gov.ru", "Audrey Obama", "+940007611", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9943) },
                    { 223, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9945), "kate.jagger@gov.nl", "Kate Jagger", "+394884088", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9945) },
                    { 224, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9947), "jimi.windsor@gov.ru", "Jimi Windsor", "+915266059", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9947) },
                    { 225, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9949), "kate.trump@google.com", "Kate Trump", "+462062621", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9949) },
                    { 226, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9951), "jimi.trump@gov.us", "Jimi Trump", "+180066496", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9951) },
                    { 227, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9953), "oprah.hepburn@tesla.com", "Oprah Hepburn", "+283894595", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9953) },
                    { 228, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9955), "oprah.hepburn@theworld.ca", "Oprah Hepburn", "+324585166", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9955) },
                    { 229, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9957), "audrey.obama@something.com", "Audrey Obama", "+474325580", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9957) },
                    { 230, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9959), "oprah.windsor@google.com", "Oprah Windsor", "+961062224", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9959) },
                    { 231, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9961), "audrey.winslet@something.com", "Audrey Winslet", "+352220344", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9961) },
                    { 232, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9963), "mick.windsor@nasa.org.us", "Mick Windsor", "+152831443", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9963) },
                    { 233, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9965), "oprah.winslet@theworld.ca", "Oprah Winslet", "+158050700", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9965) },
                    { 234, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9967), "oprah.windsor@gov.gr", "Oprah Windsor", "+221021483", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9967) },
                    { 235, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9969), "jimi.winfrey@gov.ru", "Jimi Winfrey", "+134431373", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9970) },
                    { 236, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9971), "audrey.middleton@theworld.ca", "Audrey Middleton", "+899836482", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9972) },
                    { 237, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9974), "donald.trump@something.com", "Donald Trump", "+694471781", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9974) },
                    { 238, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9996), "audrey.trump@nasa.org.us", "Audrey Trump", "+308477936", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9997) },
                    { 239, new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9999), "audrey.presley@gov.us", "Audrey Presley", "+885558912", new DateTime(2024, 2, 6, 13, 51, 17, 257, DateTimeKind.Utc).AddTicks(9999) },
                    { 240, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(2), "oprah.windsor@gov.ru", "Oprah Windsor", "+856217764", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(2) },
                    { 241, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(4), "jimi.winslet@something.com", "Jimi Winslet", "+721377205", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(4) },
                    { 242, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(6), "jimi.obama@google.com", "Jimi Obama", "+575039522", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(6) },
                    { 243, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(8), "kate.hendrix@google.com", "Kate Hendrix", "+725946204", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(8) },
                    { 244, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(10), "kate.trump@gov.nl", "Kate Trump", "+619274550", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(11) },
                    { 245, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(12), "elvis.hendrix@bbc.co.uk", "Elvis Hendrix", "+818933472", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(13) },
                    { 246, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(14), "audrey.winslet@gov.us", "Audrey Winslet", "+723154432", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(15) },
                    { 247, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(17), "kate.trump@tesla.com", "Kate Trump", "+549899079", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(17) },
                    { 248, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(19), "kate.presley@gov.gr", "Kate Presley", "+726454722", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(19) },
                    { 249, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(21), "audrey.obama@nasa.org.us", "Audrey Obama", "+150101020", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(21) },
                    { 250, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(23), "oprah.obama@nasa.org.us", "Oprah Obama", "+701333285", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(23) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created", "description", "rating", "run_time", "title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(25), "Description of the movie.", "PG", 124, "Two Large Flowers", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(26) },
                    { 2, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(50), "Description of the movie.", "PG", 157, "Several Purple Leopards", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(50) },
                    { 3, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(54), "Description of the movie.", "PG", 120, "Fifteen Rose Smelling Planets", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(54) },
                    { 4, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(57), "Description of the movie.", "PG", 156, "The Orange Flowers", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(57) },
                    { 5, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(60), "Description of the movie.", "PG", 167, "An army of Rose Smelling Leopards", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(61) },
                    { 6, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(67), "Description of the movie.", "PG", 134, "A bunch of Microscopic Buildings", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(67) },
                    { 7, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(70), "Description of the movie.", "PG", 120, "The Large Cars", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(71) },
                    { 8, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(94), "Description of the movie.", "PG", 98, "The Green Leopards", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(94) },
                    { 9, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(97), "Description of the movie.", "PG", 136, "A bunch of Purple Flowers", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(97) },
                    { 10, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(102), "Description of the movie.", "PG", 108, "A bunch of Purple Buildings", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(103) },
                    { 11, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(106), "Description of the movie.", "PG", 112, "Fifteen Green Flowers", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(106) },
                    { 12, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(109), "Description of the movie.", "PG", 110, "An army of Rose Smelling Cars", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(109) },
                    { 13, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(112), "Description of the movie.", "PG", 100, "An army of Transparent Houses", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(112) },
                    { 14, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(117), "Description of the movie.", "PG", 133, "Several Orange Leopards", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(117) },
                    { 15, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(119), "Description of the movie.", "PG", 179, "The Microscopic Planets", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(120) },
                    { 16, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(122), "Description of the movie.", "PG", 108, "Fifteen Microscopic Flowers", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(123) },
                    { 17, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(125), "Description of the movie.", "PG", 174, "A bunch of Transparent Flowers", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(125) },
                    { 18, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(130), "Description of the movie.", "PG", 91, "A bunch of Large Flowers", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(130) },
                    { 19, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(134), "Description of the movie.", "PG", 127, "An army of Transparent Buildings", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(134) },
                    { 20, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(137), "Description of the movie.", "PG", 132, "Several Orange Planets", new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(137) }
                });

            migrationBuilder.InsertData(
                table: "screening",
                columns: new[] { "id", "capacity", "created_time", "movie_id", "screen_number", "start_time", "updated_time" },
                values: new object[,]
                {
                    { 1, 93, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(140), 11, 9, new DateTime(2024, 2, 21, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(143), new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(140) },
                    { 2, 244, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(150), 11, 1, new DateTime(2024, 2, 11, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(151), new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(150) },
                    { 3, 214, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(152), 9, 3, new DateTime(2024, 2, 19, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(153), new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(152) },
                    { 4, 228, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(153), 13, 3, new DateTime(2024, 2, 8, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(154), new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(153) },
                    { 5, 117, new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(154), 2, 6, new DateTime(2024, 2, 28, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(155), new DateTime(2024, 2, 6, 13, 51, 17, 258, DateTimeKind.Utc).AddTicks(155) }
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
                name: "customers");

            migrationBuilder.DropTable(
                name: "screening");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
