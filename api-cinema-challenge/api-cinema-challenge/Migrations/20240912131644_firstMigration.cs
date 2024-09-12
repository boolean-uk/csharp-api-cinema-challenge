using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedA = table.Column<DateTime>(name: "Updated A", type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Rating = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    RunTimeMins = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedA = table.Column<DateTime>(name: "Updated A", type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Screenings",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MovieId = table.Column<int>(type: "integer", nullable: false),
                    ScreenNumber = table.Column<int>(type: "integer", nullable: false),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    StartsAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedA = table.Column<DateTime>(name: "Updated A", type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screenings", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "id", "CreatedAt", "Email", "Name", "Phone", "Updated A" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4180), "john.wick@hollywoodmail.com", "Arnold Obama", "(555) 123-7890", new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4222) },
                    { 2, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4228), "r.stone@actionstar.net", "Oprah Schwarzenegger", "(555) 987-6543", new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4231) },
                    { 3, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4234), "stallone.sylvester@moviefan.com", "Arnold Obama", "(555) 246-8102", new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4237) },
                    { 4, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4239), "v.diesel@stuntman.com", "Mickey Xavier", "(555) 369-1470", new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4241) },
                    { 5, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4244), "arnold@cybermail.com", "Felix Presley", "(555) 482-9357", new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4246) },
                    { 6, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4250), "j.bourne@spyfilms.org", "Oprah Schwarzenegger", "(555) 678-9123", new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4252) },
                    { 7, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4255), "bruce.willis@explosions.net", "Adam Lothbrok", "(555) 314-1592", new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4257) },
                    { 8, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4260), "n.cage@thrillride.com", "Felix Mouse", "(555) 753-9514", new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4262) },
                    { 9, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4265), "l.neeson@hollywoodhero.com", "Felix Xavier", "(555) 806-4213", new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4267) },
                    { 10, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4270), "the.rock@adventurezone.net", "Adam Winslow", "(555) 467-8921", new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4273) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "id", "CreatedAt", "Description", "Rating", "RunTimeMins", "Title", "Updated A" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4283), "Cyborg assassin hunts future savior.", "R", 107, "The Terminator", new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4286) },
                    { 2, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4291), "Commandos hunted by alien warrior.", "R", 107, "Predator", new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4294) },
                    { 3, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4371), "Ex-soldier fights to rescue daughter.", "R", 90, "Commando", new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4374) },
                    { 4, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4377), "Man questions reality and identity.", "R", 113, "Total Recall", new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4379) },
                    { 5, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4382), "Prison break with unlikely alliance.", "R", 115, "The Escape Plan", new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4384) },
                    { 6, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4388), "Soldier returns to rescue POWs.", "R", 96, "Rambo: First Blood Part II", new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4390) },
                    { 7, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4393), "Boxer fights Soviet powerhouse.", "PG", 91, "Rocky IV", new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4395) },
                    { 8, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4397), "Cop battles violent crime cult.", "R", 87, "Cobra", new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4399) },
                    { 9, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4402), "Frozen cop versus unfrozen criminal.", "R", 115, "Demolition Man", new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4404) },
                    { 10, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4407), "Rescuer fights criminals on mountains.", "R", 113, "Cliffhanger", new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4409) }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "id", "Capacity", "CreatedAt", "MovieId", "ScreenNumber", "Updated A", "StartsAt" },
                values: new object[,]
                {
                    { 1, 24, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4453), 1, 1, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4457), new DateTime(2025, 2, 12, 18, 33, 55, 0, DateTimeKind.Utc) },
                    { 2, 35, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4466), 2, 2, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4468), new DateTime(2024, 10, 6, 7, 37, 14, 0, DateTimeKind.Utc) },
                    { 3, 51, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4474), 3, 3, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4476), new DateTime(2024, 11, 4, 7, 7, 21, 0, DateTimeKind.Utc) },
                    { 4, 39, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4482), 4, 4, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4484), new DateTime(2025, 2, 18, 3, 18, 50, 0, DateTimeKind.Utc) },
                    { 5, 38, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4492), 5, 5, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4494), new DateTime(2024, 12, 1, 5, 12, 0, 0, DateTimeKind.Utc) },
                    { 6, 52, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4500), 6, 6, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4502), new DateTime(2025, 1, 26, 3, 15, 53, 0, DateTimeKind.Utc) },
                    { 7, 43, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4508), 7, 7, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4510), new DateTime(2024, 10, 30, 15, 5, 49, 0, DateTimeKind.Utc) },
                    { 8, 22, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4514), 8, 8, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4517), new DateTime(2024, 12, 10, 10, 48, 56, 0, DateTimeKind.Utc) },
                    { 9, 23, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4523), 9, 9, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4525), new DateTime(2025, 3, 27, 0, 44, 50, 0, DateTimeKind.Utc) },
                    { 10, 39, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4531), 10, 10, new DateTime(2024, 9, 12, 13, 16, 41, 952, DateTimeKind.Utc).AddTicks(4533), new DateTime(2025, 4, 14, 16, 46, 2, 0, DateTimeKind.Utc) }
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
