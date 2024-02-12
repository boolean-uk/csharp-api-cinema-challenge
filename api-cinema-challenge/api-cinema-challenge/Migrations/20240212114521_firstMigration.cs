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
                name: "customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    runtime = table.Column<int>(type: "integer", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "screenings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    screenNumber = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    startsAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    movieId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_screenings_movies_movieId",
                        column: x => x.movieId,
                        principalTable: "movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ticket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    seatNumber = table.Column<int>(type: "integer", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    customerID = table.Column<int>(type: "integer", nullable: false),
                    screeningID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ticket_customer_customerID",
                        column: x => x.customerID,
                        principalTable: "customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ticket_screenings_screeningID",
                        column: x => x.screeningID,
                        principalTable: "screenings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customer",
                columns: new[] { "Id", "createdAt", "email", "name", "phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4468), "Jimi Obama@gov.ru", "Jimi Obama", "59943377", new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4468) },
                    { 2, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4470), "Barack Trump@something.com", "Barack Trump", "67137459", new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4471) },
                    { 3, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4472), "Barack Jagger@theworld.ca", "Barack Jagger", "31878797", new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4473) },
                    { 4, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4474), "Jimi Middleton@gov.nl", "Jimi Middleton", "31878797", new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4474) },
                    { 5, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4475), "Kate Hepburn@gov.us", "Kate Hepburn", "20778913", new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4476) },
                    { 6, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4477), "Jimi Jagger@nasa.org.us", "Jimi Jagger", "61428868", new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4478) },
                    { 7, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4479), "Charles Hendrix@nasa.org.us", "Charles Hendrix", "31878797", new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4479) },
                    { 8, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4480), "Elvis Obama@gov.us", "Elvis Obama", "67137459", new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4481) },
                    { 9, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4482), "Kate Presley@something.com", "Kate Presley", "31878797", new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4482) },
                    { 10, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4483), "Mick Trump@something.com", "Mick Trump", "59943377", new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4484) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "Id", "createdAt", "description", "rating", "runtime", "title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4418), "Very scary", "PG", 190, "A herd of Microscopic Flowers", new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4419) },
                    { 2, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4421), "Boooring", "NC-17", 135, "An army of Zombies", new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4422) },
                    { 3, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4423), "Lorem ipsum test ummmm", "NC-17", 190, "Two Purple Flowers", new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4423) },
                    { 4, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4424), "Very scary", "R", 135, "Several", new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4424) },
                    { 5, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4424), "Lorem ipsum test ummmm", "R", 60, "A herd of Microscopic Flowers", new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4425) },
                    { 6, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4454), "Lorem ipsum test ummmm", "PG-13", 60, "Fifteen Transparent Planets", new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4455) },
                    { 7, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4455), "Boooring", "R", 135, "An army of Zombies", new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4456) },
                    { 8, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4456), "Lorem ipsum test ummmm", "PG", 190, "A herd of Microscopic Flowers", new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4457) },
                    { 9, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4457), "Very scary", "NC-17", 190, "Two Purple Flowers", new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4458) },
                    { 10, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4459), "Very scary", "PG-13", 122, "Two Purple Flowers", new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4459) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "Id", "capacity", "createdAt", "movieId", "screenNumber", "UpdatedAt", "startsAt" },
                values: new object[,]
                {
                    { 1, 69, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4494), 8, 8, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4494), new DateTime(2024, 3, 5, 7, 56, 21, 640, DateTimeKind.Utc).AddTicks(4486) },
                    { 2, 93, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4498), 9, 8, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4498), new DateTime(2024, 2, 24, 20, 30, 21, 640, DateTimeKind.Utc).AddTicks(4497) },
                    { 3, 63, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4499), 4, 5, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4500), new DateTime(2024, 3, 1, 11, 39, 21, 640, DateTimeKind.Utc).AddTicks(4499) },
                    { 4, 56, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4501), 2, 3, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4501), new DateTime(2024, 2, 17, 13, 20, 21, 640, DateTimeKind.Utc).AddTicks(4500) },
                    { 5, 21, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4502), 3, 10, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4502), new DateTime(2024, 2, 21, 13, 36, 21, 640, DateTimeKind.Utc).AddTicks(4501) },
                    { 6, 53, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4504), 8, 4, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4504), new DateTime(2024, 3, 1, 21, 32, 21, 640, DateTimeKind.Utc).AddTicks(4503) },
                    { 7, 94, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4505), 8, 8, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4505), new DateTime(2024, 2, 22, 20, 17, 21, 640, DateTimeKind.Utc).AddTicks(4505) },
                    { 8, 56, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4506), 6, 8, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4507), new DateTime(2024, 3, 1, 11, 2, 21, 640, DateTimeKind.Utc).AddTicks(4506) },
                    { 9, 81, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4508), 6, 4, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4508), new DateTime(2024, 3, 1, 6, 54, 21, 640, DateTimeKind.Utc).AddTicks(4507) },
                    { 10, 54, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4509), 4, 2, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4509), new DateTime(2024, 2, 15, 19, 59, 21, 640, DateTimeKind.Utc).AddTicks(4509) },
                    { 11, 46, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4510), 1, 2, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4510), new DateTime(2024, 2, 21, 6, 54, 21, 640, DateTimeKind.Utc).AddTicks(4510) },
                    { 12, 45, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4511), 2, 7, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4512), new DateTime(2024, 3, 9, 8, 15, 21, 640, DateTimeKind.Utc).AddTicks(4511) },
                    { 13, 92, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4512), 9, 1, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4513), new DateTime(2024, 3, 7, 22, 45, 21, 640, DateTimeKind.Utc).AddTicks(4512) },
                    { 14, 86, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4514), 1, 8, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4514), new DateTime(2024, 2, 15, 19, 40, 21, 640, DateTimeKind.Utc).AddTicks(4513) },
                    { 15, 56, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4515), 3, 8, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4515), new DateTime(2024, 3, 8, 22, 46, 21, 640, DateTimeKind.Utc).AddTicks(4514) },
                    { 16, 24, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4516), 8, 2, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4516), new DateTime(2024, 3, 10, 6, 17, 21, 640, DateTimeKind.Utc).AddTicks(4515) },
                    { 17, 24, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4517), 4, 8, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4517), new DateTime(2024, 2, 14, 18, 21, 21, 640, DateTimeKind.Utc).AddTicks(4516) },
                    { 18, 45, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4518), 3, 3, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4519), new DateTime(2024, 2, 20, 4, 52, 21, 640, DateTimeKind.Utc).AddTicks(4518) },
                    { 19, 95, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4519), 7, 5, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4520), new DateTime(2024, 2, 21, 7, 4, 21, 640, DateTimeKind.Utc).AddTicks(4519) }
                });

            migrationBuilder.InsertData(
                table: "ticket",
                columns: new[] { "Id", "createdAt", "customerID", "screeningID", "seatNumber", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4521), 1, 11, 38, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4522) },
                    { 2, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4525), 7, 5, 38, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4525) },
                    { 3, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4526), 6, 8, 49, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4526) },
                    { 4, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4527), 8, 4, 23, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4527) },
                    { 5, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4528), 3, 11, 46, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4528) },
                    { 6, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4529), 2, 7, 18, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4530) },
                    { 7, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4530), 9, 5, 48, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4530) },
                    { 8, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4531), 3, 12, 16, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4531) },
                    { 9, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4532), 4, 18, 31, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4532) },
                    { 10, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4533), 3, 10, 36, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4533) },
                    { 11, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4534), 3, 16, 45, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4534) },
                    { 12, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4534), 4, 15, 25, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4534) },
                    { 13, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4535), 2, 5, 26, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4535) },
                    { 14, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4536), 6, 16, 46, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4536) },
                    { 15, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4536), 2, 11, 8, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4536) },
                    { 16, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4537), 7, 12, 44, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4537) },
                    { 17, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4537), 3, 17, 13, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4538) },
                    { 18, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4539), 9, 1, 20, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4539) },
                    { 19, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4539), 8, 17, 2, new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4540) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_movieId",
                table: "screenings",
                column: "movieId");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_customerID",
                table: "ticket",
                column: "customerID");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_screeningID",
                table: "ticket",
                column: "screeningID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ticket");

            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "screenings");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
