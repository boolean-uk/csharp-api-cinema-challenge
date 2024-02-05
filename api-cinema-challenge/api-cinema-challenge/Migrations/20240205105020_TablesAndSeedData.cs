using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class TablesAndSeedData : Migration
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
                    Director = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Rating = table.Column<string>(type: "text", nullable: false),
                    Runtime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Screens",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screens", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Screenings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MovieId = table.Column<int>(type: "integer", nullable: false),
                    ScreenId = table.Column<int>(type: "integer", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Screenings_Screens_ScreenId",
                        column: x => x.ScreenId,
                        principalTable: "Screens",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ScreenId = table.Column<int>(type: "integer", nullable: false),
                    seatNumber = table.Column<int>(type: "integer", nullable: false),
                    rowNumber = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seats_Screens_ScreenId",
                        column: x => x.ScreenId,
                        principalTable: "Screens",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    screeningId = table.Column<int>(type: "integer", nullable: false),
                    seatId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    bookingId = table.Column<int>(type: "integer", nullable: true),
                    price = table.Column<float>(type: "real", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => new { x.screeningId, x.seatId });
                    table.UniqueConstraint("AK_Tickets_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Bookings_bookingId",
                        column: x => x.bookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tickets_Screenings_screeningId",
                        column: x => x.screeningId,
                        principalTable: "Screenings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Seats_seatId",
                        column: x => x.seatId,
                        principalTable: "Seats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), "john.doe@example.com", "John Doe", "123-456-7890", new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) },
                    { 2, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), "jane.smith@example.com", "Jane Smith", "098-765-4321", new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) },
                    { 3, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), "alice.johnson@example.com", "Alice Johnson", "123-555-7890", new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedAt", "Description", "Director", "Rating", "ReleaseDate", "Runtime", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), "An epic adventure.", "Alice Jones", "PG", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 2, 2, 0, 0, 0, DateTimeKind.Utc), "The Great Adventure", new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) },
                    { 2, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), "A journey through space.", "Chris Nolan", "PG-13", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 2, 2, 30, 0, 0, DateTimeKind.Utc), "Space Odyssey", new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) }
                });

            migrationBuilder.InsertData(
                table: "Screens",
                columns: new[] { "id", "CreatedAt", "UpdatedAt", "name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), "Screen 1" },
                    { 2, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), "Screen 2" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), 1, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) },
                    { 2, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), 2, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "CreatedAt", "MovieId", "ScreenId", "StartsAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), 1, 1, new DateTime(2024, 2, 5, 13, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) },
                    { 2, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), 2, 2, new DateTime(2024, 2, 5, 15, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "CreatedAt", "ScreenId", "UpdatedAt", "rowNumber", "seatNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), 1, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), 1, 1 },
                    { 2, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), 1, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), 1, 2 },
                    { 3, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), 1, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), 2, 3 },
                    { 4, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), 1, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), 2, 4 },
                    { 5, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), 2, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), 1, 1 },
                    { 6, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), 2, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), 1, 2 },
                    { 7, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), 2, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), 2, 3 },
                    { 8, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), 2, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "screeningId", "seatId", "Id", "bookingId", "createdAt", "price", "updatedAt" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), 12.5f, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) },
                    { 1, 2, 2, null, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), 12.5f, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) },
                    { 2, 1, 3, 2, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353), 15f, new DateTime(2024, 2, 5, 10, 50, 20, 189, DateTimeKind.Utc).AddTicks(5353) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_MovieId",
                table: "Screenings",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_ScreenId",
                table: "Screenings",
                column: "ScreenId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_ScreenId",
                table: "Seats",
                column: "ScreenId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_bookingId",
                table: "Tickets",
                column: "bookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_seatId",
                table: "Tickets",
                column: "seatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Screenings");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Screens");
        }
    }
}
