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
                    UpdatedAt = table.Column<DateTime>(name: "Updated At", type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screenings", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    numSeats = table.Column<int>(type: "integer", nullable: false),
                    customerId = table.Column<int>(type: "integer", nullable: false),
                    screeningId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(name: "Updated At", type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "id", "CreatedAt", "Email", "Name", "Phone", "Updated A" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3574), "john.wick@hollywoodmail.com", "Felix Lothbrok", "(555) 123-7890", new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3624) },
                    { 2, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3633), "r.stone@actionstar.net", "Ragnar Schwarzenegger", "(555) 987-6543", new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3657) },
                    { 3, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3661), "stallone.sylvester@moviefan.com", "Donald Sandler", "(555) 246-8102", new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3664) },
                    { 4, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3668), "v.diesel@stuntman.com", "Neo Mathiasson", "(555) 369-1470", new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3674) },
                    { 5, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3677), "arnold@cybermail.com", "Donald Andersson", "(555) 482-9357", new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3680) },
                    { 6, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3697), "j.bourne@spyfilms.org", "Elvis Sandler", "(555) 678-9123", new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3700) },
                    { 7, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3703), "bruce.willis@explosions.net", "Mickey Sandler", "(555) 314-1592", new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3706) },
                    { 8, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3709), "n.cage@thrillride.com", "Kate Mathiasson", "(555) 753-9514", new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3727) },
                    { 9, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3730), "l.neeson@hollywoodhero.com", "Charles Obama", "(555) 806-4213", new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3733) },
                    { 10, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3737), "the.rock@adventurezone.net", "Ragnar Schwarzenegger", "(555) 467-8921", new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3742) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "id", "CreatedAt", "Description", "Rating", "RunTimeMins", "Title", "Updated A" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3758), "Cyborg assassin hunts future savior.", "R", 107, "The Terminator", new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3762) },
                    { 2, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3767), "Commandos hunted by alien warrior.", "R", 107, "Predator", new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3770) },
                    { 3, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3773), "Ex-soldier fights to rescue daughter.", "R", 90, "Commando", new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3776) },
                    { 4, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3779), "Man questions reality and identity.", "R", 113, "Total Recall", new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3781) },
                    { 5, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3784), "Prison break with unlikely alliance.", "R", 115, "The Escape Plan", new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3786) },
                    { 6, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3818), "Soldier returns to rescue POWs.", "R", 96, "Rambo: First Blood Part II", new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3822) },
                    { 7, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3825), "Boxer fights Soviet powerhouse.", "PG", 91, "Rocky IV", new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3828) },
                    { 8, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3831), "Cop battles violent crime cult.", "R", 87, "Cobra", new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3834) },
                    { 9, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3836), "Frozen cop versus unfrozen criminal.", "R", 115, "Demolition Man", new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3839) },
                    { 10, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3842), "Rescuer fights criminals on mountains.", "R", 113, "Cliffhanger", new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3845) }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "id", "Capacity", "CreatedAt", "MovieId", "ScreenNumber", "Updated At", "StartsAt" },
                values: new object[,]
                {
                    { 1, 59, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3874), 1, 1, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3878), new DateTime(2025, 4, 4, 20, 29, 28, 0, DateTimeKind.Utc) },
                    { 2, 36, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3911), 2, 2, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3913), new DateTime(2024, 11, 2, 21, 30, 22, 0, DateTimeKind.Utc) },
                    { 3, 39, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3926), 3, 3, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3929), new DateTime(2025, 1, 10, 6, 49, 20, 0, DateTimeKind.Utc) },
                    { 4, 53, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3940), 4, 4, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3942), new DateTime(2024, 11, 15, 6, 27, 34, 0, DateTimeKind.Utc) },
                    { 5, 36, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3953), 5, 5, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3956), new DateTime(2024, 11, 15, 22, 23, 51, 0, DateTimeKind.Utc) },
                    { 6, 57, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3978), 6, 6, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3981), new DateTime(2025, 4, 1, 10, 48, 52, 0, DateTimeKind.Utc) },
                    { 7, 31, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(4068), 7, 7, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(4072), new DateTime(2025, 2, 14, 11, 21, 26, 0, DateTimeKind.Utc) },
                    { 8, 59, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(4084), 8, 8, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(4087), new DateTime(2025, 3, 8, 10, 5, 2, 0, DateTimeKind.Utc) },
                    { 9, 58, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(4098), 9, 9, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(4100), new DateTime(2025, 2, 20, 13, 10, 36, 0, DateTimeKind.Utc) },
                    { 10, 55, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(4116), 10, 10, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(4118), new DateTime(2024, 10, 4, 16, 13, 33, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "CreatedAt", "customerId", "numSeats", "screeningId", "Updated At" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3887), 1, 3, 1, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3890) },
                    { 2, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3917), 2, 2, 2, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3919) },
                    { 3, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3932), 3, 1, 3, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3934) },
                    { 4, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3945), 4, 2, 4, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3948) },
                    { 5, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3966), 5, 3, 5, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3969) },
                    { 6, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3984), 6, 1, 6, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(3987) },
                    { 7, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(4075), 7, 3, 7, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(4078) },
                    { 8, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(4090), 8, 3, 8, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(4092) },
                    { 9, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(4104), 9, 1, 9, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(4107) },
                    { 10, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(4121), 10, 1, 10, new DateTime(2024, 9, 13, 9, 42, 18, 74, DateTimeKind.Utc).AddTicks(4124) }
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
                name: "tickets");
        }
    }
}
