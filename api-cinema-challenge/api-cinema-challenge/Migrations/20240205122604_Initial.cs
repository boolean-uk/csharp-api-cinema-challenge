using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.customer_id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    movie_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    runtimeMins = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.movie_id);
                });

            migrationBuilder.CreateTable(
                name: "Screenings",
                columns: table => new
                {
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    movie_id = table.Column<int>(type: "integer", nullable: false),
                    screennumber = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screenings", x => new { x.screening_id, x.movie_id });
                    table.ForeignKey(
                        name: "FK_Screenings_Movies_movie_id",
                        column: x => x.movie_id,
                        principalTable: "Movies",
                        principalColumn: "movie_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "customer_id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8112), "Amail@email.no", "Jensemann", "12345678", new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8203) },
                    { 2, new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8210), "Bmail@email.no", "Kristian", "12345679", new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8215) },
                    { 3, new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8220), "Cmail@email.no", "Mahmoud", "12345670", new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8223) },
                    { 4, new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8226), "Dmail@email.no", "Aziz", "12345648", new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8229) },
                    { 5, new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8233), "Email@email.no", "Henrik", "12245678", new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8236) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "movie_id", "created_at", "description", "rating", "runtimeMins", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8388), "Another one of these", 10, 90, "Indiana Jones", new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8392) },
                    { 2, new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8397), "Goated", 13, 2000, "Lord Of The Rings", new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8401) },
                    { 3, new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8405), "Order 66", 18, 110, "Star Wars", new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8408) },
                    { 4, new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8412), ".....", 16, 87, "Fight Club", new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8415) }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "screening_id", "movie_id", "capacity", "created_at", "screennumber", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 1, 60, new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8440), 1, new DateTime(2024, 2, 6, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8436), new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8443) },
                    { 2, 2, 90, new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8449), 2, new DateTime(2024, 2, 6, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8448), new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8451) },
                    { 3, 3, 60, new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8456), 1, new DateTime(2024, 2, 7, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8455), new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8459) },
                    { 4, 4, 90, new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8463), 2, new DateTime(2024, 2, 7, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8462), new DateTime(2024, 2, 5, 12, 26, 2, 862, DateTimeKind.Utc).AddTicks(8466) }
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
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Screenings");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
