using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class migrationTry2 : Migration
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
                    { 1, new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4720), "anderh2@gmail.com", "Anders Hagen Ottersland", "1234", new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4720) },
                    { 2, new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4721), "Nigel@teacher.com", "Nigel Teacher", "90909090", new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4721) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedAt", "Description", "Rating", "RuntimeMins", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4696), "Magic staffs goes boom", "PG-13", 123, "Harry Potter", new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4696) },
                    { 2, new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4699), "Swords, Wizards and fun", "PG-16", 205, "Lord Of The Rings", new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4699) },
                    { 3, new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4700), "Singing", "PG-All", 89, "Frozen", new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4700) }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "Capacity", "CreatedAt", "MovieId", "ScreenNumber", "StartsAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 50, new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4726), 1, 1, new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4723), new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4726) },
                    { 2, 100, new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4728), 2, 2, new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4727), new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4728) }
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
