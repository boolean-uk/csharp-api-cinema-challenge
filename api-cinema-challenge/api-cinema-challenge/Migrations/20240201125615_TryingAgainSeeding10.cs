using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class TryingAgainSeeding10 : Migration
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
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    runtime_mins = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    screen_number = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    movie_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => x.id);
                    table.ForeignKey(
                        name: "FK_screenings_movies_movie_id",
                        column: x => x.movie_id,
                        principalTable: "movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1603), "DonaldDuck@gmail.com", "Donald Duck", "(496) 262-1642", new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1656) },
                    { 2, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1683), "ElvisPresley@gmail.com", "Elvis Presley", "(200) 933-1067", new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1692) },
                    { 3, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1701), "Barack.Obama@gmail.com", "Barack Obama", "(853) 847-7386", new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1710) },
                    { 4, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1732), "OprahWinfrey@gmail.com", "Oprah Winfrey", "(609) 360-3328", new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1741) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "description", "rating", "runtime_mins", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 12, 56, 13, 60, DateTimeKind.Utc).AddTicks(9044), "It was ok, critics are indifferent.", "R", 178, "Amelie", new DateTime(2024, 2, 1, 12, 56, 13, 60, DateTimeKind.Utc).AddTicks(9261) },
                    { 2, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1509), "The greatest movie ever made.", "R", 135, "One Flew Over The Cuckoo's Nest", new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1529) },
                    { 3, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1540), "This is a cult classic.", "R", 145, "Alien - Prometheus", new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1547) },
                    { 4, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1557), "The greatest movie ever made.", "NC-17", 147, "Fantastic Mr. Fox", new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1565) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 53, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1772), 1, 26, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1757), new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1814) },
                    { 2, 34, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1865), 1, 22, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1853), new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1872) },
                    { 3, 44, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1891), 2, 32, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1882), new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1900) },
                    { 4, 60, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1917), 1, 43, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1909), new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1925) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_movie_id",
                table: "screenings",
                column: "movie_id");
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
