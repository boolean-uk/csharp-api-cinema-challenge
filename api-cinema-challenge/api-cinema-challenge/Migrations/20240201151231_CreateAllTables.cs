using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class CreateAllTables : Migration
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

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "descriptions", "ratings", "runtime_in_mins", "titles", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8679), "A computer hacker learns about the true nature of his reality", "R", 136, "The Matrix", new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8680) },
                    { 2, new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8681), "A thief who enters the dreams of others to steal their secrets", "PG-13", 148, "Inception", new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8682) },
                    { 3, new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8683), "Two imprisoned men bond over a number of years", "R", 142, "The Shawshank Redemption", new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8683) },
                    { 4, new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8685), "Various interconnected stories of criminals in Los Angeles", "R", 154, "Pulp Fiction", new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8685) },
                    { 5, new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8686), "The aging patriarch of an organized crime dynasty transfers control to his son", "R", 175, "The Godfather", new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8687) },
                    { 6, new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8688), "A man with a low IQ witnesses and unwittingly influences several defining historical events", "PG-13", 142, "Forrest Gump", new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8688) },
                    { 7, new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8689), "A masked vigilante battles the criminal underworld in Gotham City", "PG-13", 152, "The Dark Knight", new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8690) },
                    { 8, new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8691), "An insomniac office worker and a soapmaker form an underground fight club", "R", 139, "Fight Club", new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8691) },
                    { 9, new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8692), "A young FBI cadet must receive the help of an incarcerated and manipulative cannibal killer", "R", 118, "The Silence of the Lambs", new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8693) },
                    { 10, new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8694), "In Nazi-occupied France, a group of Jewish-American soldiers plan to assassinate Hitler", "R", 153, "Inglourious Basterds", new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8695) }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "created_at", "emails", "names", "phonenumbers", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8465), "john.doe@example.com", "John Doe", "+1234567890", new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8471) },
                    { 2, new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8475), "jane.smith@example.com", "Jane Smith", "+9876543210", new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8476) },
                    { 3, new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8477), "alice.johnson@example.com", "Alice Johnson", "+1122334455", new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8477) },
                    { 4, new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8478), "bob.anderson@example.com", "Bob Anderson", "+9988776655", new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8479) },
                    { 5, new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8480), "eva.white@example.com", "Eva White", "+6677889900", new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8480) },
                    { 6, new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8481), "david.brown@example.com", "David Brown", "+1122337788", new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8482) },
                    { 7, new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8483), "sophia.miller@example.com", "Sophia Miller", "+9988771122", new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8483) },
                    { 8, new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8484), "michael.wilson@example.com", "Michael Wilson", "+4455667788", new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8484) },
                    { 9, new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8485), "olivia.davis@example.com", "Olivia Davis", "+1122334466", new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8486) },
                    { 10, new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8487), "daniel.taylor@example.com", "Daniel Taylor", "+9988775544", new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8487) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_MovieId",
                table: "screenings",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "screenings");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
