using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class SetUp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customer",
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
                    table.PrimaryKey("PK_customer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "movie",
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
                    table.PrimaryKey("PK_movie", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "screening",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    movie_id = table.Column<int>(type: "integer", nullable: false),
                    screenNumber = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screening", x => x.id);
                    table.ForeignKey(
                        name: "FK_screening_movie_movie_id",
                        column: x => x.movie_id,
                        principalTable: "movie",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customer",
                columns: new[] { "id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3203), "GWD@GWD.com", "GWD", "+4712345678", new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3205) },
                    { 2, new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3209), "Per@Per.com", "Per", "+4787654321", new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3210) },
                    { 3, new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3212), "Carl@Carl.com", "Carl", "+4712344321", new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3212) }
                });

            migrationBuilder.InsertData(
                table: "movie",
                columns: new[] { "id", "created_at", "description", "rating", "runtime_mins", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3249), "Post war Japan is at its lowest point when a new crisis emerges in the form of a giant monster, baptized in the horrific power of the atomic bomb.", "PG-13", 124, "Godzilla minus one", new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3249) },
                    { 2, new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3253), "A high-octane action thriller which outlines the emotional journey of a man who is set to rectify the wrongs in the society.", "PG-15", 169, "Jawan", new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3253) }
                });

            migrationBuilder.InsertData(
                table: "screening",
                columns: new[] { "id", "capacity", "created_at", "movie_id", "screenNumber", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 40, new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3309), 2, 5, new DateTime(2024, 2, 14, 18, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3310) },
                    { 2, 80, new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3313), 1, 1, new DateTime(2024, 2, 14, 18, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3314) },
                    { 3, 40, new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3316), 1, 5, new DateTime(2024, 2, 14, 21, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3317) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screening_movie_id",
                table: "screening",
                column: "movie_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "screening");

            migrationBuilder.DropTable(
                name: "movie");
        }
    }
}
