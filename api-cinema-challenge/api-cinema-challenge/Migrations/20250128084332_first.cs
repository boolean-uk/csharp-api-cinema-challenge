using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
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
                    Description = table.Column<string>(type: "text", nullable: false),
                    Rating = table.Column<string>(type: "text", nullable: false),
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
                    ScreenNumber = table.Column<int>(type: "integer", nullable: false),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    StartsAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MovieId = table.Column<int>(type: "integer", nullable: false)
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

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "alice.smith@example.com", "Alice Smith", "123-456-0001", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "bob.johnson@example.com", "Bob Johnson", "123-456-0002", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "charlie.williams@example.com", "Charlie Williams", "123-456-0003", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "diana.jones@example.com", "Diana Jones", "123-456-0004", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "eve.brown@example.com", "Eve Brown", "123-456-0005", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "frank.davis@example.com", "Frank Davis", "123-456-0006", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "grace.miller@example.com", "Grace Miller", "123-456-0007", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "hank.wilson@example.com", "Hank Wilson", "123-456-0008", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 9, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "ivy.moore@example.com", "Ivy Moore", "123-456-0009", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 10, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "jack.taylor@example.com", "Jack Taylor", "123-456-0010", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 11, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "alice.smith@example.com", "Alice Smith", "123-456-0011", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 12, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "bob.johnson@example.com", "Bob Johnson", "123-456-0012", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 13, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "charlie.williams@example.com", "Charlie Williams", "123-456-0013", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 14, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "diana.jones@example.com", "Diana Jones", "123-456-0014", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 15, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "eve.brown@example.com", "Eve Brown", "123-456-0015", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 16, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "frank.davis@example.com", "Frank Davis", "123-456-0016", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 17, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "grace.miller@example.com", "Grace Miller", "123-456-0017", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 18, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "hank.wilson@example.com", "Hank Wilson", "123-456-0018", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 19, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "ivy.moore@example.com", "Ivy Moore", "123-456-0019", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 20, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "jack.taylor@example.com", "Jack Taylor", "123-456-0020", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 21, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "alice.smith@example.com", "Alice Smith", "123-456-0021", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 22, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "bob.johnson@example.com", "Bob Johnson", "123-456-0022", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 23, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "charlie.williams@example.com", "Charlie Williams", "123-456-0023", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 24, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "diana.jones@example.com", "Diana Jones", "123-456-0024", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 25, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "eve.brown@example.com", "Eve Brown", "123-456-0025", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 26, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "frank.davis@example.com", "Frank Davis", "123-456-0026", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 27, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "grace.miller@example.com", "Grace Miller", "123-456-0027", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 28, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "hank.wilson@example.com", "Hank Wilson", "123-456-0028", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 29, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "ivy.moore@example.com", "Ivy Moore", "123-456-0029", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 30, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "jack.taylor@example.com", "Jack Taylor", "123-456-0030", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 31, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "alice.smith@example.com", "Alice Smith", "123-456-0031", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 32, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "bob.johnson@example.com", "Bob Johnson", "123-456-0032", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 33, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "charlie.williams@example.com", "Charlie Williams", "123-456-0033", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 34, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "diana.jones@example.com", "Diana Jones", "123-456-0034", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 35, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "eve.brown@example.com", "Eve Brown", "123-456-0035", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 36, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "frank.davis@example.com", "Frank Davis", "123-456-0036", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 37, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "grace.miller@example.com", "Grace Miller", "123-456-0037", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 38, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "hank.wilson@example.com", "Hank Wilson", "123-456-0038", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 39, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "ivy.moore@example.com", "Ivy Moore", "123-456-0039", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 40, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "jack.taylor@example.com", "Jack Taylor", "123-456-0040", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 41, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "alice.smith@example.com", "Alice Smith", "123-456-0041", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 42, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "bob.johnson@example.com", "Bob Johnson", "123-456-0042", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 43, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "charlie.williams@example.com", "Charlie Williams", "123-456-0043", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 44, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "diana.jones@example.com", "Diana Jones", "123-456-0044", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 45, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "eve.brown@example.com", "Eve Brown", "123-456-0045", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 46, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "frank.davis@example.com", "Frank Davis", "123-456-0046", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 47, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "grace.miller@example.com", "Grace Miller", "123-456-0047", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 48, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "hank.wilson@example.com", "Hank Wilson", "123-456-0048", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 49, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "ivy.moore@example.com", "Ivy Moore", "123-456-0049", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 50, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "jack.taylor@example.com", "Jack Taylor", "123-456-0050", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedAt", "Description", "Rating", "RuntimeMins", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "Description for The Great Adventure", "G", 100, "The Great Adventure", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "Description for Romance in Paris", "PG", 110, "Romance in Paris", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "Description for Space Odyssey", "PG-13", 120, "Space Odyssey", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "Description for The Last Stand", "R", 130, "The Last Stand", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "Description for Comedy Central", "NC-17", 140, "Comedy Central", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "Description for Mystery Mansion", "G", 150, "Mystery Mansion", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "Description for Fast Wheels", "PG", 160, "Fast Wheels", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "Description for Horror Nights", "PG-13", 170, "Horror Nights", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 9, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "Description for Dreams of Tomorrow", "R", 180, "Dreams of Tomorrow", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 10, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), "Description for The Epic Quest", "NC-17", 190, "The Epic Quest", new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "Capacity", "CreatedAt", "MovieId", "ScreenNumber", "StartsAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 1, 2, new DateTime(2023, 10, 2, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 2, 3, new DateTime(2023, 10, 3, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 3, 4, new DateTime(2023, 10, 4, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 4, 5, new DateTime(2023, 10, 5, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 5, 1, new DateTime(2023, 10, 6, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 6, 2, new DateTime(2023, 10, 7, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 7, 3, new DateTime(2023, 10, 8, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 8, 4, new DateTime(2023, 10, 9, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 9, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 9, 5, new DateTime(2023, 10, 10, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 10, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 10, 1, new DateTime(2023, 10, 11, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 11, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 1, 2, new DateTime(2023, 10, 12, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 12, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 2, 3, new DateTime(2023, 10, 13, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 13, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 3, 4, new DateTime(2023, 10, 14, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 14, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 4, 5, new DateTime(2023, 10, 15, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 15, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 5, 1, new DateTime(2023, 10, 16, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 16, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 6, 2, new DateTime(2023, 10, 17, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 17, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 7, 3, new DateTime(2023, 10, 18, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 18, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 8, 4, new DateTime(2023, 10, 19, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 19, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 9, 5, new DateTime(2023, 10, 20, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 20, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 10, 1, new DateTime(2023, 10, 21, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 21, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 1, 2, new DateTime(2023, 10, 22, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 22, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 2, 3, new DateTime(2023, 10, 23, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 23, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 3, 4, new DateTime(2023, 10, 24, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 24, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 4, 5, new DateTime(2023, 10, 25, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 25, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 5, 1, new DateTime(2023, 10, 26, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 26, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 6, 2, new DateTime(2023, 10, 27, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 27, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 7, 3, new DateTime(2023, 10, 28, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 28, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 8, 4, new DateTime(2023, 10, 29, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 29, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 9, 5, new DateTime(2023, 10, 30, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 30, 100, new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc), 10, 1, new DateTime(2023, 10, 31, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_MovieId",
                table: "Screenings",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Screenings");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
