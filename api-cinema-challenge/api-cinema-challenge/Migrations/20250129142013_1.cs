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
                    { 1, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(3699), "chris@evans.com", "Chris Evans", "11111111", new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(3702) },
                    { 2, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(4171), "chris@hemsworth.com", "Chris Hemsworth", "22222222", new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(4171) },
                    { 3, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(4172), "chris@pine.com", "Chris Pine", "33333333", new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(4172) },
                    { 4, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(4173), "chris@pratt.com", "Chris Pratt", "44444444", new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(4174) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedAt", "Description", "Rating", "RuntimeMins", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(7611), "WE HAVE TO GO DEEPER", "Very good", 150, "Inception", new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(7611) },
                    { 2, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8105), "COME ON TARS", "Very good", 150, "Interstellar", new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8105) },
                    { 3, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8107), "I HAVE BECOME DEATH", "Very good", 150, "Oppenheimer", new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8107) }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "Capacity", "CreatedAt", "MovieId", "ScreenNumber", "StartsAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 40, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8450), 1, 1, new DateTime(2010, 1, 1, 20, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8451) },
                    { 2, 40, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8923), 1, 2, new DateTime(2010, 1, 1, 20, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8924) },
                    { 3, 30, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8925), 2, 1, new DateTime(2014, 1, 1, 20, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8926) },
                    { 4, 70, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8928), 3, 1, new DateTime(2023, 1, 1, 20, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8928) },
                    { 5, 80, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8929), 3, 2, new DateTime(2023, 1, 1, 20, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(8929) }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "ScreeningId", "UpdatedAt", "numSeats" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9189), 1, 1, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9189), 1 },
                    { 2, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9448), 1, 2, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9448), 2 },
                    { 3, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9450), 1, 3, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9450), 4 },
                    { 4, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9451), 2, 1, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9451), 2 },
                    { 5, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9452), 3, 2, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9452), 1 },
                    { 6, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9453), 4, 3, new DateTime(2025, 1, 29, 14, 20, 12, 801, DateTimeKind.Utc).AddTicks(9453), 2 }
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
