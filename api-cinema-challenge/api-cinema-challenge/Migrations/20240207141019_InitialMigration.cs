using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
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
                    name = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    title = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    runtime_mins = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    screen_number = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    movie_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screenings", x => x.id);
                    table.ForeignKey(
                        name: "FK_Screenings_Movies_movie_id",
                        column: x => x.movie_id,
                        principalTable: "Movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "id", "name", "phone", "created_at", "updated_at" },
                values: new object[,]
                {
                    { 1, "Bill Crosby", "78707870", new DateTime(2024, 2, 7, 14, 10, 19, 225, DateTimeKind.Utc).AddTicks(2315), new DateTime(2024, 2, 7, 14, 10, 19, 225, DateTimeKind.Utc).AddTicks(2316) },
                    { 2, "Neil Young", "78707870", new DateTime(2024, 2, 7, 14, 10, 19, 225, DateTimeKind.Utc).AddTicks(2317), new DateTime(2024, 2, 7, 14, 10, 19, 225, DateTimeKind.Utc).AddTicks(2317) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "id", "created_at", "description", "rating", "runtime_mins", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 7, 14, 10, 19, 225, DateTimeKind.Utc).AddTicks(2301), "One of the movies of all time", "PG-13", 2000, "Great Movie 4", new DateTime(2024, 2, 7, 14, 10, 19, 225, DateTimeKind.Utc).AddTicks(2304) },
                    { 2, new DateTime(2024, 2, 7, 14, 10, 19, 225, DateTimeKind.Utc).AddTicks(2304), "One more of the movies of all time", "PG-13", 200, "Great Movie 5", new DateTime(2024, 2, 7, 14, 10, 19, 225, DateTimeKind.Utc).AddTicks(2305) }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "id", "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 190, new DateTime(2024, 2, 7, 14, 10, 19, 225, DateTimeKind.Utc).AddTicks(2310), 1, 1, new DateTime(2024, 2, 7, 14, 10, 19, 225, DateTimeKind.Utc).AddTicks(2311), new DateTime(2024, 2, 7, 14, 10, 19, 225, DateTimeKind.Utc).AddTicks(2311) },
                    { 2, 140, new DateTime(2024, 2, 7, 14, 10, 19, 225, DateTimeKind.Utc).AddTicks(2312), 2, 3, new DateTime(2024, 2, 7, 14, 10, 19, 225, DateTimeKind.Utc).AddTicks(2313), new DateTime(2024, 2, 7, 14, 10, 19, 225, DateTimeKind.Utc).AddTicks(2313) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_movie_id",
                table: "Screenings",
                column: "movie_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Screenings");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
