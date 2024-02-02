using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class CreatingAllTablesAndPlusTicket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    titles = table.Column<string>(type: "text", nullable: false),
                    ratings = table.Column<string>(type: "text", nullable: false),
                    descriptions = table.Column<string>(type: "text", nullable: false),
                    runtime_in_mins = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    names = table.Column<string>(type: "text", nullable: false),
                    emails = table.Column<string>(type: "text", nullable: false),
                    phonenumbers = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "screenings",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    screen_numbers = table.Column<int>(type: "integer", nullable: false),
                    capacities = table.Column<int>(type: "integer", nullable: false),
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MovieId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => x.id);
                    table.ForeignKey(
                        name: "FK_screenings_movies_MovieId",
                        column: x => x.MovieId,
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
                    num_seats = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ScreeningId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.id);
                    table.ForeignKey(
                        name: "FK_tickets_screenings_ScreeningId",
                        column: x => x.ScreeningId,
                        principalTable: "screenings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tickets_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "descriptions", "ratings", "runtime_in_mins", "titles", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2739), "A computer hacker learns about the true nature of his reality", "R", 136, "The Matrix", new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2740) },
                    { 2, new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2741), "A thief who enters the dreams of others to steal their secrets", "PG-13", 148, "Inception", new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2742) },
                    { 3, new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2743), "Two imprisoned men bond over a number of years", "R", 142, "The Shawshank Redemption", new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2743) },
                    { 4, new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2744), "Various interconnected stories of criminals in Los Angeles", "R", 154, "Pulp Fiction", new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2745) },
                    { 5, new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2746), "The aging patriarch of an organized crime dynasty transfers control to his son", "R", 175, "The Godfather", new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2746) },
                    { 6, new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2747), "A man with a low IQ witnesses and unwittingly influences several defining historical events", "PG-13", 142, "Forrest Gump", new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2747) },
                    { 7, new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2748), "A masked vigilante battles the criminal underworld in Gotham City", "PG-13", 152, "The Dark Knight", new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2749) },
                    { 8, new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2750), "An insomniac office worker and a soapmaker form an underground fight club", "R", 139, "Fight Club", new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2750) },
                    { 9, new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2751), "A young FBI cadet must receive the help of an incarcerated and manipulative cannibal killer", "R", 118, "The Silence of the Lambs", new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2752) },
                    { 10, new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2753), "In Nazi-occupied France, a group of Jewish-American soldiers plan to assassinate Hitler", "R", 153, "Inglourious Basterds", new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2753) }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "created_at", "emails", "names", "phonenumbers", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2575), "john.doe@example.com", "John Doe", "+1234567890", new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2581) },
                    { 2, new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2582), "jane.smith@example.com", "Jane Smith", "+9876543210", new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2583) },
                    { 3, new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2584), "alice.johnson@example.com", "Alice Johnson", "+1122334455", new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2584) },
                    { 4, new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2585), "bob.anderson@example.com", "Bob Anderson", "+9988776655", new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2586) },
                    { 5, new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2587), "eva.white@example.com", "Eva White", "+6677889900", new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2587) },
                    { 6, new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2588), "david.brown@example.com", "David Brown", "+1122337788", new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2588) },
                    { 7, new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2631), "sophia.miller@example.com", "Sophia Miller", "+9988771122", new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2631) },
                    { 8, new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2632), "michael.wilson@example.com", "Michael Wilson", "+4455667788", new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2632) },
                    { 9, new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2633), "olivia.davis@example.com", "Olivia Davis", "+1122334466", new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2634) },
                    { 10, new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2635), "daniel.taylor@example.com", "Daniel Taylor", "+9988775544", new DateTime(2024, 2, 2, 10, 18, 19, 552, DateTimeKind.Utc).AddTicks(2635) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_MovieId",
                table: "screenings",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_ScreeningId",
                table: "tickets",
                column: "ScreeningId");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_UserId",
                table: "tickets",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DropTable(
                name: "screenings");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
