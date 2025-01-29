using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class finalmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
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
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Screen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ScreenNumber = table.Column<int>(type: "integer", nullable: false),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScreenMovie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AvailableSeats = table.Column<int>(type: "integer", nullable: false),
                    ScreenId = table.Column<int>(type: "integer", nullable: false),
                    MovieId = table.Column<int>(type: "integer", nullable: false),
                    StartsAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScreenMovie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScreenMovie_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScreenMovie_Screen_ScreenId",
                        column: x => x.ScreenId,
                        principalTable: "Screen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NumSeats = table.Column<int>(type: "integer", nullable: false),
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    ScreenMovieId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_Customer_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_ScreenMovie_ScreenMovieId",
                        column: x => x.ScreenMovieId,
                        principalTable: "ScreenMovie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 29, 15, 37, 13, 889, DateTimeKind.Utc).AddTicks(8545), "John.Doe@gmail.com", "John Doe", "12345678", new DateTime(2025, 1, 29, 15, 37, 13, 891, DateTimeKind.Utc).AddTicks(5055) },
                    { 2, new DateTime(2025, 1, 29, 15, 37, 13, 891, DateTimeKind.Utc).AddTicks(5204), "Jane.Doe@gmail.com", "Jane Doe", "90123456", new DateTime(2025, 1, 29, 15, 37, 13, 891, DateTimeKind.Utc).AddTicks(5208) }
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "CreatedAt", "Description", "Rating", "RuntimeMins", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 29, 15, 37, 13, 891, DateTimeKind.Utc).AddTicks(9182), "A good movie about boats", "pg-13", 120, "Titanic", new DateTime(2025, 1, 29, 15, 37, 13, 891, DateTimeKind.Utc).AddTicks(9313) },
                    { 2, new DateTime(2025, 1, 29, 15, 37, 13, 891, DateTimeKind.Utc).AddTicks(9381), "A good movie about pills", "pg-13", 132, "The Matrix", new DateTime(2025, 1, 29, 15, 37, 13, 891, DateTimeKind.Utc).AddTicks(9383) }
                });

            migrationBuilder.InsertData(
                table: "Screen",
                columns: new[] { "Id", "Capacity", "CreatedAt", "ScreenNumber", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 90, new DateTime(2025, 1, 29, 15, 37, 13, 891, DateTimeKind.Utc).AddTicks(9742), 1, new DateTime(2025, 1, 29, 15, 37, 13, 891, DateTimeKind.Utc).AddTicks(9810) },
                    { 2, 90, new DateTime(2025, 1, 29, 15, 37, 13, 891, DateTimeKind.Utc).AddTicks(9873), 2, new DateTime(2025, 1, 29, 15, 37, 13, 891, DateTimeKind.Utc).AddTicks(9875) }
                });

            migrationBuilder.InsertData(
                table: "ScreenMovie",
                columns: new[] { "Id", "AvailableSeats", "CreatedAt", "MovieId", "ScreenId", "StartsAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 90, new DateTime(2025, 1, 29, 15, 37, 13, 892, DateTimeKind.Utc).AddTicks(279), 1, 1, new DateTime(2025, 1, 29, 15, 37, 13, 892, DateTimeKind.Utc).AddTicks(218), new DateTime(2025, 1, 29, 15, 37, 13, 892, DateTimeKind.Utc).AddTicks(340) },
                    { 2, 90, new DateTime(2025, 1, 29, 15, 37, 13, 892, DateTimeKind.Utc).AddTicks(411), 2, 2, new DateTime(2025, 1, 29, 15, 37, 13, 892, DateTimeKind.Utc).AddTicks(409), new DateTime(2025, 1, 29, 15, 37, 13, 892, DateTimeKind.Utc).AddTicks(413) }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "CreatedAt", "NumSeats", "PersonId", "ScreenMovieId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 29, 15, 37, 13, 892, DateTimeKind.Utc).AddTicks(687), 0, 1, 1, new DateTime(2025, 1, 29, 15, 37, 13, 892, DateTimeKind.Utc).AddTicks(754) },
                    { 2, new DateTime(2025, 1, 29, 15, 37, 13, 892, DateTimeKind.Utc).AddTicks(818), 0, 2, 2, new DateTime(2025, 1, 29, 15, 37, 13, 892, DateTimeKind.Utc).AddTicks(820) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScreenMovie_MovieId",
                table: "ScreenMovie",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_ScreenMovie_ScreenId",
                table: "ScreenMovie",
                column: "ScreenId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_PersonId",
                table: "Ticket",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ScreenMovieId",
                table: "Ticket",
                column: "ScreenMovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "ScreenMovie");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Screen");
        }
    }
}
