using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class newMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    runtimeMinutes = table.Column<int>(type: "integer", nullable: false),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    movieid = table.Column<int>(type: "integer", nullable: false),
                    screenNumber = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    start = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    customerid = table.Column<int>(type: "integer", nullable: false),
                    screeningid = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    numSeats = table.Column<int>(type: "integer", nullable: false),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => new { x.customerid, x.screeningid });
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "created", "email", "name", "phone", "updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1649), "roger@rogan.com", "Roger Rogan", "+44729389128", new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1649) },
                    { 2, new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1651), "chris@muse.mu", "Chris Wolstenholme", "+44729388192", new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1651) },
                    { 3, new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1653), "lisa@timber.com", "Lisa Timber", "+47123456789", new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1653) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created", "description", "rating", "runtimeMinutes", "title", "updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1672), "The greatest movie ever made.", "PG-13", 126, "Dodgeball", new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1672) },
                    { 2, new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1674), "The story of a lifetime.", "PG-13", 142, "Forrest Gump", new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1675) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "created", "movieid", "screenNumber", "start", "updated" },
                values: new object[,]
                {
                    { 1, 40, new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1686), 1, 2, new DateTime(2024, 9, 14, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1681), new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1686) },
                    { 2, 80, new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1688), 2, 4, new DateTime(2024, 9, 13, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1688), new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1689) }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "customerid", "screeningid", "created", "id", "numSeats", "updated" },
                values: new object[] { 1, 1, new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1693), 1, 2, new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1693) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "movies");

            migrationBuilder.DropTable(
                name: "screenings");

            migrationBuilder.DropTable(
                name: "tickets");
        }
    }
}
