using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
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
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    runtimemins = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<string>(type: "text", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    screennumber = table.Column<int>(type: "integer", nullable: false),
                    startsAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
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
                    ScreeningId = table.Column<int>(type: "integer", nullable: false),
                    CustomerID = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    numseats = table.Column<int>(type: "integer", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => new { x.ScreeningId, x.CustomerID });
                    table.ForeignKey(
                        name: "FK_tickets_customers_CustomerID",
                        column: x => x.CustomerID,
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
                columns: new[] { "id", "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3568), "john.doe@example.com", "John Doe", "555-123-4567", new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3568) },
                    { 2, new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3570), "jane.smith@example.com", "Jane Smith", "555-234-5678", new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3571) },
                    { 3, new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3572), "michael.johnson@example.com", "Michael Johnson", "555-345-6789", new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3573) },
                    { 4, new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3574), "emily.davis@example.com", "Emily Davis", "555-456-7890", new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3574) },
                    { 5, new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3575), "david.wilson@example.com", "David Wilson", "555-567-8901", new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3575) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "createdAt", "description", "rating", "runtimemins", "title", "updatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3556), "A skilled thief, Dom Cobb, who can infiltrate and steal information from dreams, is tasked with planting an idea into a target's subconscious. As the mission becomes more dangerous, Cobb confronts his own troubled past.", "PG-13", 148, "Inception", new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3557) },
                    { 2, new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3560), "Batman faces his greatest challenge yet as the Joker wreaks havoc on Gotham City. As chaos ensues, Bruce Wayne must grapple with the cost of being a hero and the line between good and evil.", "PG-13", 152, "The Dark Knight", new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3560) },
                    { 3, new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3562), "In a future where Earth is on the brink of collapse, a team of astronauts travels through a wormhole in search of a new home for humanity. The film explores themes of time, space, and love as a survival force.", "PG-13", 169, "Interstellar", new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3562) },
                    { 4, new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3563), "A hacker, Neo, discovers that reality as he knows it is a simulation controlled by machines. He joins a group of rebels to fight against the machines and free humanity from their virtual prison.", "R", 136, "The Matrix", new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3564) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "createdAt", "MovieId", "screennumber", "startsAt", "updatedAt" },
                values: new object[,]
                {
                    { 1, 100, new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3585), 1, 0, new DateTime(2024, 9, 13, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3580), new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3594) },
                    { 2, 120, new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3597), 2, 0, new DateTime(2024, 9, 14, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3596), new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3597) }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "CustomerID", "ScreeningId", "createdAt", "id", "numseats", "updatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3599), 1, 1, new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3600) },
                    { 2, 1, new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3602), 2, 1, new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3602) },
                    { 5, 1, new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3606), 5, 1, new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3606) },
                    { 3, 2, new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3603), 3, 1, new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3604) },
                    { 4, 2, new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3605), 4, 1, new DateTime(2024, 9, 12, 9, 30, 18, 958, DateTimeKind.Utc).AddTicks(3605) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_MovieId",
                table: "screenings",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_CustomerID",
                table: "tickets",
                column: "CustomerID");
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
