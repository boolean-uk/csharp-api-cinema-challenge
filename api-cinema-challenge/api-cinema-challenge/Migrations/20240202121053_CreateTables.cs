using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class CreateTables : Migration
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

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    num_seats = table.Column<int>(type: "integer", nullable: false),
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    customer_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.id);
                    table.ForeignKey(
                        name: "FK_tickets_customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tickets_screenings_screening_id",
                        column: x => x.screening_id,
                        principalTable: "screenings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 2, 12, 10, 52, 732, DateTimeKind.Utc).AddTicks(7593), "klara.andersson@telia.com", "Klara Andersson", "123854", new DateTime(2024, 2, 2, 12, 10, 52, 732, DateTimeKind.Utc).AddTicks(7840) },
                    { 2, new DateTime(2024, 2, 2, 12, 10, 52, 732, DateTimeKind.Utc).AddTicks(7846), "peter.andersson@telia.com", "Peter Andersson", "467215", new DateTime(2024, 2, 2, 12, 10, 52, 732, DateTimeKind.Utc).AddTicks(7849) },
                    { 3, new DateTime(2024, 2, 2, 12, 10, 52, 732, DateTimeKind.Utc).AddTicks(7852), "arvid.andersson@telia.com", "Arvid Andersson", "8751345", new DateTime(2024, 2, 2, 12, 10, 52, 732, DateTimeKind.Utc).AddTicks(7854) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "description", "rating", "runtime_mins", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 2, 12, 10, 52, 732, DateTimeKind.Utc).AddTicks(8176), "Adaption of the greatest book", "PG-13", 160, "Throne of Glass", new DateTime(2024, 2, 2, 12, 10, 52, 732, DateTimeKind.Utc).AddTicks(8180) },
                    { 2, new DateTime(2024, 2, 2, 12, 10, 52, 732, DateTimeKind.Utc).AddTicks(8193), "A girl assassin saves the city", "PG-20", 200, "Queen of Shadows", new DateTime(2024, 2, 2, 12, 10, 52, 732, DateTimeKind.Utc).AddTicks(8196) },
                    { 3, new DateTime(2024, 2, 2, 12, 10, 52, 732, DateTimeKind.Utc).AddTicks(8199), "Riding dragons", "PG-10", 100, "Fourth Wing", new DateTime(2024, 2, 2, 12, 10, 52, 732, DateTimeKind.Utc).AddTicks(8202) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 40, new DateTime(2024, 2, 2, 12, 10, 52, 732, DateTimeKind.Utc).AddTicks(8223), 2, 5, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 2, 12, 10, 52, 732, DateTimeKind.Utc).AddTicks(8226) },
                    { 2, 100, new DateTime(2024, 2, 2, 12, 10, 52, 732, DateTimeKind.Utc).AddTicks(8238), 3, 3, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 2, 12, 10, 52, 732, DateTimeKind.Utc).AddTicks(8241) },
                    { 3, 20, new DateTime(2024, 2, 2, 12, 10, 52, 732, DateTimeKind.Utc).AddTicks(8246), 1, 1, new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 2, 12, 10, 52, 732, DateTimeKind.Utc).AddTicks(8248) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_movie_id",
                table: "screenings",
                column: "movie_id");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_customer_id",
                table: "tickets",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_screening_id",
                table: "tickets",
                column: "screening_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "screenings");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
