using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    runtime_mins = table.Column<int>(type: "integer", nullable: false),
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
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MovieId = table.Column<int>(type: "integer", nullable: false),
                    screen_number = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    ScreeningId = table.Column<int>(type: "integer", nullable: false),
                    CustomerId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.id);
                    table.ForeignKey(
                        name: "FK_tickets_customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tickets_screenings_ScreeningId",
                        column: x => x.ScreeningId,
                        principalTable: "screenings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), "john.doe@example.com", "John Doe", "123-456-7890", new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) },
                    { 2, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), "jane.smith@example.com", "Jane Smith", "098-765-4321", new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) },
                    { 3, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), "emily.davis@example.com", "Emily Davis", "555-123-4567", new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) },
                    { 4, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), "michael.brown@example.com", "Michael Brown", "444-567-8901", new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) },
                    { 5, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), "sarah.johnson@example.com", "Sarah Johnson", "222-345-6789", new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "description", "rating", "runtime_mins", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), "A thief who steals corporate secrets through the use of dream-sharing technology is tasked with planting an idea into the mind of a C.E.O.", "PG-13", 148, "Inception", new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) },
                    { 2, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), "When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", "PG-13", 152, "The Dark Knight", new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) },
                    { 3, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", "PG-13", 169, "Interstellar", new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) },
                    { 4, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "R", 142, "The Shawshank Redemption", new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) },
                    { 5, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), "Allied soldiers from Belgium, the British Empire, and France are surrounded by the German Army and evacuated during a fierce battle in World War II.", "PG-13", 106, "Dunkirk", new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "created_at", "MovieId", "screen_number", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 100, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), 1, 1, new DateTime(2025, 1, 31, 11, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) },
                    { 2, 80, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), 4, 2, new DateTime(2025, 1, 31, 12, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) },
                    { 3, 120, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), 5, 3, new DateTime(2025, 2, 1, 11, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) },
                    { 4, 90, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), 3, 1, new DateTime(2025, 2, 1, 14, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) },
                    { 5, 110, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), 3, 2, new DateTime(2025, 1, 31, 15, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "created_at", "CustomerId", "num_seats", "ScreeningId", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), 1, 2, 1, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) },
                    { 2, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), 2, 1, 2, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) },
                    { 3, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), 3, 4, 3, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) },
                    { 4, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), 4, 3, 4, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) },
                    { 5, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532), 5, 2, 5, new DateTime(2025, 1, 31, 9, 12, 55, 569, DateTimeKind.Utc).AddTicks(532) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_MovieId",
                table: "screenings",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_CustomerId",
                table: "tickets",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_ScreeningId",
                table: "tickets",
                column: "ScreeningId");
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
