using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
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
                    runtimeMins = table.Column<int>(type: "integer", nullable: false),
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
                    screenNumber = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
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
                name: "customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ScreeningId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.id);
                    table.ForeignKey(
                        name: "FK_customers_screenings_ScreeningId",
                        column: x => x.ScreeningId,
                        principalTable: "screenings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "createdAt", "description", "rating", "runtimeMins", "title", "updatedAt" },
                values: new object[] { 1, new DateTime(2024, 9, 13, 8, 43, 25, 430, DateTimeKind.Utc).AddTicks(5417), "The greates movie ever made.", "PG-13", 126, "Dodgeball", new DateTime(2024, 9, 13, 8, 43, 25, 430, DateTimeKind.Utc).AddTicks(5418) });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "createdAt", "MovieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 1, 40, new DateTime(2024, 9, 13, 8, 43, 25, 430, DateTimeKind.Utc).AddTicks(5423), 1, 5, new DateTime(2024, 9, 13, 8, 43, 25, 430, DateTimeKind.Utc).AddTicks(5423), new DateTime(2024, 9, 13, 8, 43, 25, 430, DateTimeKind.Utc).AddTicks(5424) });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "createdAt", "email", "name", "phone", "ScreeningId", "updatedAt" },
                values: new object[] { 1, new DateTime(2024, 9, 13, 8, 43, 25, 430, DateTimeKind.Utc).AddTicks(5427), "Chris@muse.mu", "Chris Wolstenholme", "+44729388192", 1, new DateTime(2024, 9, 13, 8, 43, 25, 430, DateTimeKind.Utc).AddTicks(5428) });

            migrationBuilder.CreateIndex(
                name: "IX_customers_ScreeningId",
                table: "customers",
                column: "ScreeningId");

            migrationBuilder.CreateIndex(
                name: "IX_screenings_MovieId",
                table: "screenings",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "screenings");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
