using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class CREATETABLES : Migration
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
                name: "Screening",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ScreenNumber = table.Column<int>(type: "integer", nullable: false),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    StartsAt = table.Column<string>(type: "text", nullable: false),
                    MovieId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screening", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Screening_movies_MovieId",
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
                    { 1, new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(949), "A computer hacker learns about the true nature of his reality", "R", 136, "The Matrix", new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(950) },
                    { 2, new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(951), "A thief who enters the dreams of others to steal their secrets", "PG-13", 148, "Inception", new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(952) },
                    { 3, new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(953), "Two imprisoned men bond over a number of years", "R", 142, "The Shawshank Redemption", new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(953) },
                    { 4, new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(955), "Various interconnected stories of criminals in Los Angeles", "R", 154, "Pulp Fiction", new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(955) },
                    { 5, new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(956), "The aging patriarch of an organized crime dynasty transfers control to his son", "R", 175, "The Godfather", new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(956) },
                    { 6, new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(958), "A man with a low IQ witnesses and unwittingly influences several defining historical events", "PG-13", 142, "Forrest Gump", new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(958) },
                    { 7, new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(959), "A masked vigilante battles the criminal underworld in Gotham City", "PG-13", 152, "The Dark Knight", new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(960) },
                    { 8, new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(961), "An insomniac office worker and a soapmaker form an underground fight club", "R", 139, "Fight Club", new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(961) },
                    { 9, new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(962), "A young FBI cadet must receive the help of an incarcerated and manipulative cannibal killer", "R", 118, "The Silence of the Lambs", new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(963) },
                    { 10, new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(964), "In Nazi-occupied France, a group of Jewish-American soldiers plan to assassinate Hitler", "R", 153, "Inglourious Basterds", new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(964) }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "created_at", "emails", "names", "phonenumbers", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(822), "john.doe@example.com", "John Doe", "+1234567890", new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(825) },
                    { 2, new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(827), "jane.smith@example.com", "Jane Smith", "+9876543210", new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(827) },
                    { 3, new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(829), "alice.johnson@example.com", "Alice Johnson", "+1122334455", new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(829) },
                    { 4, new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(830), "bob.anderson@example.com", "Bob Anderson", "+9988776655", new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(831) },
                    { 5, new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(832), "eva.white@example.com", "Eva White", "+6677889900", new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(832) },
                    { 6, new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(833), "david.brown@example.com", "David Brown", "+1122337788", new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(834) },
                    { 7, new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(835), "sophia.miller@example.com", "Sophia Miller", "+9988771122", new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(835) },
                    { 8, new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(836), "michael.wilson@example.com", "Michael Wilson", "+4455667788", new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(836) },
                    { 9, new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(837), "olivia.davis@example.com", "Olivia Davis", "+1122334466", new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(838) },
                    { 10, new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(839), "daniel.taylor@example.com", "Daniel Taylor", "+9988775544", new DateTime(2024, 2, 1, 13, 45, 23, 621, DateTimeKind.Utc).AddTicks(839) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Screening_MovieId",
                table: "Screening",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Screening");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
