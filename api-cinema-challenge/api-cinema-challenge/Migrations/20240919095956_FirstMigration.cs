using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
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
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
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
                    ScreenNumber = table.Column<int>(type: "integer", nullable: false),
                    StartsAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screenings", x => new { x.ScreenNumber, x.StartsAt });
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NumSeats = table.Column<int>(type: "integer", nullable: false),
                    MovieId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "email", "name", "phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 14, 23, 0, 0, 0, DateTimeKind.Utc), "audrey.hepburn@example.com", "Audrey Hepburn", "+47 12345678", new DateTime(2024, 9, 11, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, new DateTime(2024, 2, 19, 23, 0, 0, 0, DateTimeKind.Utc), "donald.trump@example.com", "Donald Trump", "+47 23456789", new DateTime(2024, 9, 11, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, new DateTime(2024, 3, 24, 23, 0, 0, 0, DateTimeKind.Utc), "elvis.presley@example.com", "Elvis Presley", "+47 34567890", new DateTime(2024, 9, 11, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, new DateTime(2024, 4, 9, 22, 0, 0, 0, DateTimeKind.Utc), "barack.obama@example.com", "Barack Obama", "+47 45678901", new DateTime(2024, 9, 11, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, new DateTime(2024, 5, 4, 22, 0, 0, 0, DateTimeKind.Utc), "oprah.winfrey@example.com", "Oprah Winfrey", "+47 56789012", new DateTime(2024, 9, 11, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, new DateTime(2024, 6, 14, 22, 0, 0, 0, DateTimeKind.Utc), "jimi.hendrix@example.com", "Jimi Hendrix", "+47 67890123", new DateTime(2024, 9, 11, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, new DateTime(2024, 7, 19, 22, 0, 0, 0, DateTimeKind.Utc), "mick.jagger@example.com", "Mick Jagger", "+47 78901234", new DateTime(2024, 9, 11, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, new DateTime(2024, 8, 24, 22, 0, 0, 0, DateTimeKind.Utc), "kate.winslet@example.com", "Kate Winslet", "+47 89012345", new DateTime(2024, 9, 11, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 9, new DateTime(2024, 9, 4, 22, 0, 0, 0, DateTimeKind.Utc), "charles.windsor@example.com", "Charles Windsor", "+47 90123456", new DateTime(2024, 9, 11, 22, 0, 0, 0, DateTimeKind.Utc) },
                    { 10, new DateTime(2024, 9, 9, 22, 0, 0, 0, DateTimeKind.Utc), "kate.middleton@example.com", "Kate Middleton", "+47 01234567", new DateTime(2024, 9, 11, 22, 0, 0, 0, DateTimeKind.Utc) }
                });
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

            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
