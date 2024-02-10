using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class TICKETSANDTICKETS : Migration
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
                    title = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    runtime_mins = table.Column<int>(type: "integer", nullable: false),
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
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone_number = table.Column<string>(type: "text", nullable: false),
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
                    movie_id = table.Column<int>(type: "integer", nullable: false),
                    screen_number = table.Column<int>(type: "integer", nullable: false),
                    start_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => new { x.movie_id, x.screen_number, x.start_time });
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
                    num_of_seats = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MovieId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.id);
                    table.ForeignKey(
                        name: "FK_tickets_movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "movies",
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
                columns: new[] { "id", "created_at", "description", "rating", "runtime_mins", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 10, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8544), "A short comedy movie", "Good", 77, "The Sweet Potato", new DateTime(2024, 2, 10, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8545) },
                    { 2, new DateTime(2024, 2, 5, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8547), "A thrilling mystery movie", "Excellent", 120, "Mystery Mansion", new DateTime(2024, 2, 7, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8548) },
                    { 3, new DateTime(2024, 1, 31, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8549), "A beautiful romantic movie", "Great", 90, "Romantic Sunset", new DateTime(2024, 2, 2, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8553) },
                    { 4, new DateTime(2024, 1, 26, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8554), "An epic science fiction movie", "Excellent", 150, "Sci-Fi Odyssey", new DateTime(2024, 1, 29, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8555) },
                    { 5, new DateTime(2024, 1, 21, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8556), "A gripping drama movie", "Good", 110, "Drama Junction", new DateTime(2024, 1, 23, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8556) }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "created_at", "email", "name", "phone_number", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 10, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8224), "joel@email.com", "Joel Joelsson", "0700050088", new DateTime(2024, 2, 10, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8230) },
                    { 2, new DateTime(2024, 2, 8, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8232), "alice@email.com", "Alice Johnson", "0701122334", new DateTime(2024, 2, 8, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8238) },
                    { 3, new DateTime(2024, 2, 5, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8240), "bob@email.com", "Bob Smith", "0709876543", new DateTime(2024, 2, 7, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8240) },
                    { 4, new DateTime(2024, 2, 2, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8241), "emma@email.com", "Emma White", "0703344556", new DateTime(2024, 2, 4, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8242) },
                    { 5, new DateTime(2024, 1, 31, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8243), "david@email.com", "David Brown", "0706677889", new DateTime(2024, 2, 3, 17, 49, 59, 656, DateTimeKind.Utc).AddTicks(8244) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "movie_id", "screen_number", "start_time", "capacity", "created_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 2, 10, 18, 49, 59, 657, DateTimeKind.Utc).AddTicks(790), 100, new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(791), new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(792) },
                    { 1, 2, new DateTime(2024, 2, 10, 20, 49, 59, 657, DateTimeKind.Utc).AddTicks(793), 120, new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(794), new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(794) },
                    { 2, 3, new DateTime(2024, 2, 10, 21, 49, 59, 657, DateTimeKind.Utc).AddTicks(795), 70, new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(795), new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(796) },
                    { 2, 4, new DateTime(2024, 2, 10, 18, 49, 59, 657, DateTimeKind.Utc).AddTicks(797), 80, new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(804), new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(805) },
                    { 3, 5, new DateTime(2024, 2, 10, 22, 49, 59, 657, DateTimeKind.Utc).AddTicks(805), 83, new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(806), new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(806) }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "CreatedAt", "LastUpdatedAt", "MovieId", "num_of_seats", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(838), new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(838), 1, 2, 1 },
                    { 2, new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(840), new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(840), 2, 3, 2 },
                    { 3, new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(841), new DateTime(2024, 2, 10, 17, 49, 59, 657, DateTimeKind.Utc).AddTicks(842), 3, 5, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tickets_MovieId",
                table: "tickets",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_UserId",
                table: "tickets",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "screenings");

            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DropTable(
                name: "movies");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
