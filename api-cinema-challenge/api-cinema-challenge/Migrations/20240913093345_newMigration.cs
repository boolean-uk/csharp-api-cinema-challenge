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
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    numSeats = table.Column<int>(type: "integer", nullable: false),
                    customerid = table.Column<int>(type: "integer", nullable: false),
                    screeningid = table.Column<int>(type: "integer", nullable: false),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "created", "email", "name", "phone", "updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 13, 9, 33, 45, 233, DateTimeKind.Utc).AddTicks(1502), "roger@rogan.com", "Roger Rogan", "+44729389128", new DateTime(2024, 9, 13, 9, 33, 45, 233, DateTimeKind.Utc).AddTicks(1503) },
                    { 2, new DateTime(2024, 9, 13, 9, 33, 45, 233, DateTimeKind.Utc).AddTicks(1505), "chris@muse.mu", "Chris Wolstenholme", "+44729388192", new DateTime(2024, 9, 13, 9, 33, 45, 233, DateTimeKind.Utc).AddTicks(1506) },
                    { 3, new DateTime(2024, 9, 13, 9, 33, 45, 233, DateTimeKind.Utc).AddTicks(1508), "lisa@timber.com", "Lisa Timber", "+47123456789", new DateTime(2024, 9, 13, 9, 33, 45, 233, DateTimeKind.Utc).AddTicks(1509) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created", "description", "rating", "runtimeMinutes", "title", "updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 13, 9, 33, 45, 233, DateTimeKind.Utc).AddTicks(1556), "The greatest movie ever made.", "PG-13", 126, "Dodgeball", new DateTime(2024, 9, 13, 9, 33, 45, 233, DateTimeKind.Utc).AddTicks(1557) },
                    { 2, new DateTime(2024, 9, 13, 9, 33, 45, 233, DateTimeKind.Utc).AddTicks(1559), "The story of a lifetime.", "PG-13", 142, "Forrest Gump", new DateTime(2024, 9, 13, 9, 33, 45, 233, DateTimeKind.Utc).AddTicks(1560) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "created", "movieid", "screenNumber", "start", "updated" },
                values: new object[,]
                {
                    { 1, 40, new DateTime(2024, 9, 13, 9, 33, 45, 233, DateTimeKind.Utc).AddTicks(1599), 1, 2, new DateTime(2024, 9, 15, 9, 33, 45, 233, DateTimeKind.Utc).AddTicks(1589), new DateTime(2024, 9, 13, 9, 33, 45, 233, DateTimeKind.Utc).AddTicks(1600) },
                    { 2, 80, new DateTime(2024, 9, 13, 9, 33, 45, 233, DateTimeKind.Utc).AddTicks(1604), 2, 4, new DateTime(2024, 9, 14, 9, 33, 45, 233, DateTimeKind.Utc).AddTicks(1602), new DateTime(2024, 9, 13, 9, 33, 45, 233, DateTimeKind.Utc).AddTicks(1604) }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "created", "customerid", "numSeats", "screeningid", "updated" },
                values: new object[] { 1, new DateTime(2024, 9, 13, 9, 33, 45, 233, DateTimeKind.Utc).AddTicks(1617), 1, 2, 1, new DateTime(2024, 9, 13, 9, 33, 45, 233, DateTimeKind.Utc).AddTicks(1618) });
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
