using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class AddedAndSeededTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    runtime = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    screen_nr = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    movies_id = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => x.id);
                    table.ForeignKey(
                        name: "FK_screenings_movies_movies_id",
                        column: x => x.movies_id,
                        principalTable: "movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone_nr = table.Column<int>(type: "integer", nullable: false),
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.id);
                    table.ForeignKey(
                        name: "FK_customers_screenings_screening_id",
                        column: x => x.screening_id,
                        principalTable: "screenings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "CreatedAt", "description", "rating", "runtime", "title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 12, 55, 6, 161, DateTimeKind.Utc).AddTicks(7935), "Amazing but imaginary Hank Williams movie", "PG-16", 114, "So Lonesome I Could Cry", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 2, 1, 12, 55, 6, 161, DateTimeKind.Utc).AddTicks(7944), "Western B-Movie", "PG-16", 120, "Texas Cowboy Rides Again", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "CreatedAt", "movies_id", "screen_nr", "starts_at", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 64, new DateTime(2024, 2, 1, 12, 55, 6, 161, DateTimeKind.Utc).AddTicks(8717), 1, 1, new DateTime(2024, 2, 1, 12, 55, 6, 161, DateTimeKind.Utc).AddTicks(8383), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 64, new DateTime(2024, 2, 1, 12, 55, 6, 161, DateTimeKind.Utc).AddTicks(8723), 1, 2, new DateTime(2024, 2, 1, 12, 55, 6, 161, DateTimeKind.Utc).AddTicks(8383), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 32, new DateTime(2024, 2, 1, 12, 55, 6, 161, DateTimeKind.Utc).AddTicks(8726), 2, 3, new DateTime(2024, 2, 1, 12, 55, 6, 161, DateTimeKind.Utc).AddTicks(8383), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "CreatedAt", "email", "name", "phone_nr", "screening_id", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 12, 55, 6, 161, DateTimeKind.Utc).AddTicks(8962), "Victor@Adamson.se", "Victor Adamson", 70666123, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 2, 1, 12, 55, 6, 161, DateTimeKind.Utc).AddTicks(8970), "Phill@Collins.com", "Phill Collins", 321566322, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_customers_screening_id",
                table: "customers",
                column: "screening_id");

            migrationBuilder.CreateIndex(
                name: "IX_screenings_movies_id",
                table: "screenings",
                column: "movies_id");
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
