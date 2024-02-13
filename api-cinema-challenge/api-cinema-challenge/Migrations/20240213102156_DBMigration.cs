using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class DBMigration : Migration
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

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NumSeats = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6606), "tom.hanks@example.com", "Tom Hanks", "123-456-7890", new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6608) },
                    { 2, new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6609), "leo.dicaprio@example.com", "Leonardo DiCaprio", "123-456-7891", new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6610) },
                    { 3, new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6611), "scarlett.johansson@example.com", "Scarlett Johansson", "123-456-7892", new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6611) },
                    { 4, new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6612), "brad.pitt@example.com", "Brad Pitt", "123-456-7893", new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6612) },
                    { 5, new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6613), "angelina.jolie@example.com", "Angelina Jolie", "123-456-7894", new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6614) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedAt", "Description", "Rating", "RuntimeMins", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6703), "The story of a man with a low IQ who accomplished great things in his life.", "PG-13", 142, "Forrest Gump", new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6704) },
                    { 2, new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6705), "A love story between Jack and Rose aboard the ill-fated Titanic.", "PG-13", 195, "Titanic", new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6705) },
                    { 3, new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6707), "A team of superheroes including Iron Man, Captain America, and Thor, come together to save the world.", "PG-13", 143, "The Avengers", new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6707) },
                    { 4, new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6708), "An insomniac office worker and a devil-may-care soapmaker form an underground fight club that evolves into something much, much more.", "R", 139, "Fight Club", new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6708) },
                    { 5, new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6709), "A bored married couple is surprised to learn that they are both assassins hired by competing agencies to kill each other.", "PG-13", 120, "Mr. & Mrs. Smith", new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6710) }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "Capacity", "CreatedAt", "ScreenNumber", "StartsAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 2, 13, 11, 21, 53, 200, DateTimeKind.Utc).AddTicks(6724), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 120, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 2, 13, 12, 21, 53, 200, DateTimeKind.Utc).AddTicks(6730), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 80, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2024, 2, 13, 13, 21, 53, 200, DateTimeKind.Utc).AddTicks(6731), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 90, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2024, 2, 13, 14, 21, 53, 200, DateTimeKind.Utc).AddTicks(6732), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 110, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2024, 2, 13, 15, 21, 53, 200, DateTimeKind.Utc).AddTicks(6733), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "CreatedAt", "NumSeats", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6747), 10, new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6747) },
                    { 2, new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6748), 20, new DateTime(2024, 2, 13, 10, 21, 53, 200, DateTimeKind.Utc).AddTicks(6748) }
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
