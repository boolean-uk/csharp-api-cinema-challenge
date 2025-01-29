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
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Rating = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    RuntimeMins = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Screenings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MovieId = table.Column<int>(type: "integer", nullable: false),
                    ScreenNumber = table.Column<int>(type: "integer", nullable: false),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    StartsAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screenings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Screenings_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    ScreeningId = table.Column<int>(type: "integer", nullable: false),
                    numSeats = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Screenings_ScreeningId",
                        column: x => x.ScreeningId,
                        principalTable: "Screenings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 29, 10, 16, 17, 526, DateTimeKind.Utc).AddTicks(5215), "chris@evans.com", "Chris Evans", "11111111", new DateTime(2025, 1, 29, 10, 16, 17, 526, DateTimeKind.Utc).AddTicks(5217) },
                    { 2, new DateTime(2025, 1, 29, 10, 16, 17, 526, DateTimeKind.Utc).AddTicks(5814), "chris@hemsworth.com", "Chris Hemsworth", "22222222", new DateTime(2025, 1, 29, 10, 16, 17, 526, DateTimeKind.Utc).AddTicks(5815) },
                    { 3, new DateTime(2025, 1, 29, 10, 16, 17, 526, DateTimeKind.Utc).AddTicks(5816), "chris@pine.com", "Chris Pine", "33333333", new DateTime(2025, 1, 29, 10, 16, 17, 526, DateTimeKind.Utc).AddTicks(5817) },
                    { 4, new DateTime(2025, 1, 29, 10, 16, 17, 526, DateTimeKind.Utc).AddTicks(5818), "chris@pratt.com", "Chris Pratt", "44444444", new DateTime(2025, 1, 29, 10, 16, 17, 526, DateTimeKind.Utc).AddTicks(5819) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedAt", "Description", "Rating", "RuntimeMins", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 29, 10, 16, 17, 526, DateTimeKind.Utc).AddTicks(9403), "WE HAVE TO GO DEEPER", "Very good", 150, "Inception", new DateTime(2025, 1, 29, 10, 16, 17, 526, DateTimeKind.Utc).AddTicks(9405) },
                    { 2, new DateTime(2025, 1, 29, 10, 16, 17, 526, DateTimeKind.Utc).AddTicks(9903), "COME ON TARS", "Very good", 150, "Interstellar", new DateTime(2025, 1, 29, 10, 16, 17, 526, DateTimeKind.Utc).AddTicks(9903) },
                    { 3, new DateTime(2025, 1, 29, 10, 16, 17, 526, DateTimeKind.Utc).AddTicks(9905), "I HAVE BECOME DEATH", "Very good", 150, "Oppenheimer", new DateTime(2025, 1, 29, 10, 16, 17, 526, DateTimeKind.Utc).AddTicks(9905) }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "Capacity", "CreatedAt", "MovieId", "ScreenNumber", "StartsAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2025, 1, 29, 10, 16, 17, 527, DateTimeKind.Utc).AddTicks(275), 1, 1, new DateTime(2010, 1, 1, 20, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 29, 10, 16, 17, 527, DateTimeKind.Utc).AddTicks(276) },
                    { 2, 0, new DateTime(2025, 1, 29, 10, 16, 17, 527, DateTimeKind.Utc).AddTicks(719), 1, 2, new DateTime(2010, 1, 1, 20, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 29, 10, 16, 17, 527, DateTimeKind.Utc).AddTicks(719) },
                    { 3, 0, new DateTime(2025, 1, 29, 10, 16, 17, 527, DateTimeKind.Utc).AddTicks(722), 2, 1, new DateTime(2014, 1, 1, 20, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 29, 10, 16, 17, 527, DateTimeKind.Utc).AddTicks(722) },
                    { 4, 0, new DateTime(2025, 1, 29, 10, 16, 17, 527, DateTimeKind.Utc).AddTicks(723), 3, 1, new DateTime(2023, 1, 1, 20, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 29, 10, 16, 17, 527, DateTimeKind.Utc).AddTicks(723) },
                    { 5, 0, new DateTime(2025, 1, 29, 10, 16, 17, 527, DateTimeKind.Utc).AddTicks(724), 3, 2, new DateTime(2023, 1, 1, 20, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 29, 10, 16, 17, 527, DateTimeKind.Utc).AddTicks(725) }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "ScreeningId", "UpdatedAt", "numSeats" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 29, 10, 16, 17, 527, DateTimeKind.Utc).AddTicks(1008), 1, 1, new DateTime(2025, 1, 29, 10, 16, 17, 527, DateTimeKind.Utc).AddTicks(1009), 1 },
                    { 2, new DateTime(2025, 1, 29, 10, 16, 17, 527, DateTimeKind.Utc).AddTicks(1284), 1, 2, new DateTime(2025, 1, 29, 10, 16, 17, 527, DateTimeKind.Utc).AddTicks(1284), 2 },
                    { 3, new DateTime(2025, 1, 29, 10, 16, 17, 527, DateTimeKind.Utc).AddTicks(1285), 1, 3, new DateTime(2025, 1, 29, 10, 16, 17, 527, DateTimeKind.Utc).AddTicks(1286), 4 },
                    { 4, new DateTime(2025, 1, 29, 10, 16, 17, 527, DateTimeKind.Utc).AddTicks(1287), 2, 1, new DateTime(2025, 1, 29, 10, 16, 17, 527, DateTimeKind.Utc).AddTicks(1287), 2 },
                    { 5, new DateTime(2025, 1, 29, 10, 16, 17, 527, DateTimeKind.Utc).AddTicks(1288), 3, 2, new DateTime(2025, 1, 29, 10, 16, 17, 527, DateTimeKind.Utc).AddTicks(1288), 1 },
                    { 6, new DateTime(2025, 1, 29, 10, 16, 17, 527, DateTimeKind.Utc).AddTicks(1289), 4, 3, new DateTime(2025, 1, 29, 10, 16, 17, 527, DateTimeKind.Utc).AddTicks(1289), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_MovieId",
                table: "Screenings",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_CustomerId",
                table: "Tickets",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ScreeningId",
                table: "Tickets",
                column: "ScreeningId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Screenings");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
