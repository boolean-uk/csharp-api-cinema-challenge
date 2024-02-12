using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class _07TicketTesting : Migration
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
                    title = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    runtime = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fk_screening_id = table.Column<int>(type: "integer", nullable: false),
                    fk_customer_id = table.Column<int>(type: "integer", nullable: false),
                    number_of_seats = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "screenings",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
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
                    table.PrimaryKey("PK_screenings", x => x.id);
                    table.ForeignKey(
                        name: "FK_screenings_movies_fk_movie_id",
                        column: x => x.fk_movie_id,
                        principalTable: "movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5318), "kate.trump@google.com", "Kate Trump", "67 45 42 48", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5320) },
                    { 2, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5327), "ronnie.dio@gov.ru", "Ronnie Dio", "40 73 81 67", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5327) },
                    { 3, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5331), "mick.hendrix@something.com", "Mick Hendrix", "81 30 29 31", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5332) },
                    { 4, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5335), "jimi.butler@theworld.ca", "Jimi Butler", "82 38 31 32", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5335) },
                    { 5, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5339), "ronnie.may@google.com", "Ronnie May", "88 73 84 61", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5339) },
                    { 6, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5343), "roger.butler@something.com", "Roger Butler", "43 05 97 35", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5343) },
                    { 7, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5346), "ozzy.daltrey@gov.ru", "Ozzy Daltrey", "43 53 73 12", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5346) },
                    { 8, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5349), "elvis.trump@nasa.org.us", "Elvis Trump", "88 51 61 55", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5349) },
                    { 9, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5378), "charlie.presley@google.com", "Charlie Presley", "77 98 15 47", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5378) },
                    { 10, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5382), "bill.baker@bbc.co.uk", "Bill Baker", "87 47 39 38", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5382) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5386), "The story of Henry Hill and his life in the mafia, covering his relationship with his wife Karen and his mob partners Jimmy Conway and Tommy DeVito.", "R", 148, "Goodfellas", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5387) },
                    { 2, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5389), "In 1980 Miami, a determined Cuban immigrant takes over a drug cartel and succumbs to greed.", "R", 170, "Scarface", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5389) },
                    { 3, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5390), "A family in 1630s New England is torn apart by the forces of witchcraft, black magic and possession.", "R", 93, "The VVitch: A New-England Folktale", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5390) },
                    { 4, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5391), "Vampire Count Orlok expresses interest in a new residence and real estate agent Hutter's wife.", "Not Rated", 94, "Nosferatu", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5392) },
                    { 5, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5392), "When a cockerel apparently flies into a chicken farm, the chickens see him as an opportunity to escape their evil owners.", "G", 84, "Chicken Run", new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5393) }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5426), 5, 0, 5, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5426) },
                    { 2, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5427), 9, 0, 4, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5428) },
                    { 3, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5428), 4, 0, 2, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5428) },
                    { 4, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5429), 5, 0, 5, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5429) },
                    { 5, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5429), 8, 0, 1, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5430) },
                    { 6, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5431), 4, 0, 5, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5431) },
                    { 7, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5431), 4, 0, 3, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5432) },
                    { 8, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5432), 2, 0, 4, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5432) },
                    { 9, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5433), 4, 0, 4, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5433) },
                    { 10, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5434), 10, 0, 1, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5434) },
                    { 11, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5434), 9, 0, 1, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5435) },
                    { 12, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5435), 3, 0, 1, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5435) },
                    { 13, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5435), 9, 0, 1, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5436) },
                    { 14, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5436), 10, 0, 1, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5436) },
                    { 15, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5437), 4, 0, 2, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5437) },
                    { 16, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5437), 1, 0, 1, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5437) },
                    { 17, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5438), 6, 0, 4, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5438) },
                    { 18, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5439), 3, 0, 2, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5439) },
                    { 19, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5440), 9, 0, 3, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5440) },
                    { 20, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5440), 5, 0, 2, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5441) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "created_at", "fk_movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 108, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5416), 4, 1, new DateTime(2024, 2, 12, 13, 18, 51, 477, DateTimeKind.Utc).AddTicks(5410), new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5417) },
                    { 2, 210, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5419), 1, 2, new DateTime(2024, 2, 12, 12, 18, 51, 477, DateTimeKind.Utc).AddTicks(5419), new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5419) },
                    { 3, 207, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5420), 4, 3, new DateTime(2024, 2, 12, 12, 18, 51, 477, DateTimeKind.Utc).AddTicks(5420), new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5420) },
                    { 4, 211, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5421), 2, 3, new DateTime(2024, 2, 12, 13, 18, 51, 477, DateTimeKind.Utc).AddTicks(5421), new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5421) },
                    { 5, 105, new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5422), 3, 2, new DateTime(2024, 2, 12, 14, 18, 51, 477, DateTimeKind.Utc).AddTicks(5422), new DateTime(2024, 2, 12, 9, 18, 51, 477, DateTimeKind.Utc).AddTicks(5422) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_fk_movie_id",
                table: "screenings",
                column: "fk_movie_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "screenings");

            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
