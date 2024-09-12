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
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screenings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7159), "anderh2@gmail.com", "Anders Hagen Ottersland", "1234", new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7159) },
                    { 2, new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7161), "Nigel@teacher.com", "Nigel Teacher", "90909090", new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7161) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedAt", "Description", "Rating", "RuntimeMins", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7151), "Magic staffs goes boom", "PG-13", 123, "Harry Potter", new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7151) },
                    { 2, new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7154), "Swords, Wizards and fun", "PG-16", 205, "Lord Of The Rings", new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7154) },
                    { 3, new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7155), "Singing", "PG-All", 89, "Frozen", new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7155) }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "Capacity", "CreatedAt", "ScreenNumber", "StartsAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 50, new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7165), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7165) },
                    { 2, 100, new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7168), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 11, 26, 5, 201, DateTimeKind.Utc).AddTicks(7168) }
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
        }
    }
}
