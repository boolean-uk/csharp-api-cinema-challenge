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
                    MovieId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ScreenNumber = table.Column<int>(type: "integer", nullable: false),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    StartsAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedA = table.Column<DateTime>(name: "Updated A", type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screenings", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "id", "CreatedAt", "Email", "Name", "Phone", "Updated A" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(1886), "john.wick@hollywoodmail.com", "Ragnar Sandler", "(555) 123-7890", new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2003) },
                    { 2, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2030), "r.stone@actionstar.net", "Elvis Lothbrok", "(555) 987-6543", new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2042) },
                    { 3, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2078), "stallone.sylvester@moviefan.com", "Oprah Mouse", "(555) 246-8102", new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2081) },
                    { 4, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2085), "v.diesel@stuntman.com", "Kate Schwarzenegger", "(555) 369-1470", new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2088) },
                    { 5, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2092), "arnold@cybermail.com", "Elvis Mouse", "(555) 482-9357", new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2095) },
                    { 6, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2100), "j.bourne@spyfilms.org", "Donald Sandler", "(555) 678-9123", new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2102) },
                    { 7, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2106), "bruce.willis@explosions.net", "Felix Mathiasson", "(555) 314-1592", new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2109) },
                    { 8, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2118), "n.cage@thrillride.com", "Charles Xavier", "(555) 753-9514", new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2129) },
                    { 9, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2177), "l.neeson@hollywoodhero.com", "Donald Schwarzenegger", "(555) 806-4213", new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2181) },
                    { 10, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2186), "the.rock@adventurezone.net", "Neo Mouse", "(555) 467-8921", new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2190) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "id", "CreatedAt", "Description", "Rating", "RunTimeMins", "Title", "Updated A" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2199), "Cyborg assassin hunts future savior.", "R", 107, "The Terminator", new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2204) },
                    { 2, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2211), "Commandos hunted by alien warrior.", "R", 107, "Predator", new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2214) },
                    { 3, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2218), "Ex-soldier fights to rescue daughter.", "R", 90, "Commando", new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2221) },
                    { 4, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2225), "Man questions reality and identity.", "R", 113, "Total Recall", new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2227) },
                    { 5, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2231), "Prison break with unlikely alliance.", "R", 115, "The Escape Plan", new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2265) },
                    { 6, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2273), "Soldier returns to rescue POWs.", "R", 96, "Rambo: First Blood Part II", new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2277) },
                    { 7, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2280), "Boxer fights Soviet powerhouse.", "PG", 91, "Rocky IV", new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2283) },
                    { 8, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2287), "Cop battles violent crime cult.", "R", 87, "Cobra", new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2290) },
                    { 9, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2293), "Frozen cop versus unfrozen criminal.", "R", 115, "Demolition Man", new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2296) },
                    { 10, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2300), "Rescuer fights criminals on mountains.", "R", 113, "Cliffhanger", new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2304) }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "MovieId", "Capacity", "CreatedAt", "id", "ScreenNumber", "Updated A", "StartsAt" },
                values: new object[,]
                {
                    { 1, 43, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2355), 1, 1, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2359), new DateTime(2025, 3, 21, 9, 21, 38, 0, DateTimeKind.Utc) },
                    { 2, 43, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2370), 2, 2, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2373), new DateTime(2025, 3, 2, 22, 32, 47, 0, DateTimeKind.Utc) },
                    { 3, 50, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2380), 3, 3, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2383), new DateTime(2025, 1, 10, 6, 32, 5, 0, DateTimeKind.Utc) },
                    { 4, 46, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2395), 4, 4, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2398), new DateTime(2024, 10, 10, 13, 27, 18, 0, DateTimeKind.Utc) },
                    { 5, 47, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2404), 5, 5, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2407), new DateTime(2025, 3, 15, 16, 32, 3, 0, DateTimeKind.Utc) },
                    { 6, 42, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2420), 6, 6, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2423), new DateTime(2024, 11, 17, 0, 34, 1, 0, DateTimeKind.Utc) },
                    { 7, 44, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2430), 7, 7, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2433), new DateTime(2025, 3, 25, 20, 33, 43, 0, DateTimeKind.Utc) },
                    { 8, 35, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2442), 8, 8, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2445), new DateTime(2025, 4, 15, 20, 55, 31, 0, DateTimeKind.Utc) },
                    { 9, 37, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2451), 9, 9, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2454), new DateTime(2024, 10, 28, 16, 45, 27, 0, DateTimeKind.Utc) },
                    { 10, 24, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2461), 10, 10, new DateTime(2024, 9, 12, 9, 36, 55, 26, DateTimeKind.Utc).AddTicks(2464), new DateTime(2025, 3, 24, 23, 5, 56, 0, DateTimeKind.Utc) }
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
