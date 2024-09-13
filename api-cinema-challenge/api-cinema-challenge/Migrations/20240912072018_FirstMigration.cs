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
                name: "customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone_number = table.Column<string>(type: "text", nullable: false),
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
                    duration_minutes = table.Column<int>(type: "integer", nullable: false),
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
                    movie_id = table.Column<int>(type: "integer", nullable: false),
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    seat_number = table.Column<int>(type: "integer", nullable: false),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "created_at", "email", "name", "phone_number", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(5996), "anne@anne.com", "Anne Anneson", "47473828", new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(5997) },
                    { 2, new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6002), "bent@bentson.com", "Bent Bentson", "33929274", new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6003) },
                    { 3, new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6004), "carl@carlson.com", "Carl Carlson", "98472288", new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6005) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "description", "duration_minutes", "rating", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6009), "You're a wizard Harry", 190, "Pg-13", "Harry Potter and The Philosphers Stone", new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6009) },
                    { 2, new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6012), "You're still a wizard Harry", 200, "Pg-13", "Harry Potter and The Chamber of Secrets", new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6012) },
                    { 3, new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6014), "You're a still still a wizard Harry", 170, "Pg-13", "Harry Potter and The Prizoner of Azkaban", new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6014) },
                    { 4, new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6015), "You're a still still still a wizard Harry", 170, "Pg-13", "Harry Potter and The Half Blood Prince", new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6016) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 100, new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6018), 1, 1, new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6018), new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6019) },
                    { 2, 200, new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6021), 2, 2, new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6021), new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6022) }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "created_at", "customer_id", "seat_number", "screening_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6023), 1, 2, 1, new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6024) },
                    { 2, new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6026), 2, 4, 2, new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6026) }
                });
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
