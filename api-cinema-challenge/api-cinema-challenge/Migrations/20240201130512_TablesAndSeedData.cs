using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

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
                    MovieId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screenings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Phone", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2023, 3, 14, 11, 1, 56, 633, DateTimeKind.Utc), "Chris@muse.mu", "Chris Wolstenholme", "+44729388192", new DateTime(2023, 3, 14, 11, 1, 56, 633, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedAt", "Description", "Rating", "RuntimeMins", "Title", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2023, 3, 14, 11, 1, 56, 633, DateTimeKind.Utc), "The greatest movie ever made.", "PG-13", 126, "Dodgeball", new DateTime(2023, 3, 14, 11, 1, 56, 633, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "Capacity", "CreatedAt", "MovieId", "ScreenNumber", "StartsAt", "UpdatedAt" },
                values: new object[] { 1, 40, new DateTime(2023, 3, 14, 11, 1, 56, 633, DateTimeKind.Utc), null, 5, new DateTime(2023, 3, 14, 14, 1, 56, 633, DateTimeKind.Utc), new DateTime(2023, 3, 14, 11, 1, 56, 633, DateTimeKind.Utc) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Screenings");
        }
    }
}
