using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class RefactoryOfCoreScreeningsNowPartOfMovieEndpoints : Migration
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
                    movie_rating = table.Column<string>(type: "text", nullable: false),
                    movie_description = table.Column<string>(type: "text", nullable: false),
                    runtime_in_minutes = table.Column<int>(type: "integer", nullable: false),
                    creatd_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
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
                    screen_number = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screening", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "customer",
                columns: new[] { "id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), "katepresley@bbc.co.uk", "Kate Presley", "+46888888888", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), "donaldhepburn@something.com", "Donald Hepburn", "+46123456789", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), "kateobama@nasa.org.us", "Kate Obama", "+46987654321", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), "katehendrix@theworld.ca", "Kate Hendrix", "+46987654321", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "movie",
                columns: new[] { "id", "movie_description", "creatd_at", "movie_rating", "runtime_in_minutes", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, "Fifteen Purple Buildings", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), "R", 15, "Two Transparent Planets", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, "A herd of Green Cars", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), "PG-3", 30, "Fifteen Green Houses", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, "An army of Large Flowers", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), "NC-17", 45, "Fifteen Large Cars", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, "A bunch of Purple Houses", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), "PG-13", 60, "A herd of Orange Houses", new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "screening",
                columns: new[] { "id", "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 40, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), 0, 2, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, 40, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), 2, 1, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, 40, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), 0, 2, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, 40, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), 2, 1, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "movie");

            migrationBuilder.DropTable(
                name: "screening");
        }
    }
}
