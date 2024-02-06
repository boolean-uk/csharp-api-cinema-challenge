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
                    table.PrimaryKey("PK_Customer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
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
                    table.PrimaryKey("PK_Movies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Screenings",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    screennumber = table.Column<int>(type: "integer", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    number_of_seats = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.id);
                    table.ForeignKey(
                        name: "FK_tickets_Customer_customer_id",
                        column: x => x.customer_id,
                        principalTable: "Customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tickets_Screenings_screening_id",
                        column: x => x.screening_id,
                        principalTable: "Screenings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5614), "Amail@email.no", "Jensemann", "12345678", new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5711) },
                    { 2, new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5716), "Bmail@email.no", "Kristian", "12345679", new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5720) },
                    { 3, new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5724), "Cmail@email.no", "Mahmoud", "12345670", new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5727) },
                    { 4, new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5731), "Dmail@email.no", "Aziz", "12345648", new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5734) },
                    { 5, new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5738), "Email@email.no", "Henrik", "12245678", new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5741) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "id", "created_at", "description", "rating", "runtimeMins", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5861), "Another one of these", 10, 90, "Indiana Jones", new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5865) },
                    { 2, new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5870), "Goated", 13, 2000, "Lord Of The Rings", new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5873) },
                    { 3, new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5878), "Order 66", 18, 110, "Star Wars", new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5881) },
                    { 4, new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5885), "First Rule", 16, 87, "Fight Club", new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5888) }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "id", "capacity", "created_at", "movie_id", "screennumber", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 60, new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5919), 1, 1, new DateTime(2024, 2, 7, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5915), new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5923) },
                    { 2, 90, new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5928), 2, 2, new DateTime(2024, 2, 7, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5927), new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5932) },
                    { 3, 60, new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5937), 3, 1, new DateTime(2024, 2, 8, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5936), new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5940) },
                    { 4, 90, new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5945), 4, 2, new DateTime(2024, 2, 8, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5944), new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5948) }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "created_at", "customer_id", "screening_id", "updated_at", "number_of_seats" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5971), 1, 1, new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5975), 1 },
                    { 2, new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5980), 2, 2, new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5983), 3 },
                    { 3, new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5988), 3, 3, new DateTime(2024, 2, 6, 10, 20, 1, 323, DateTimeKind.Utc).AddTicks(5991), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_movie_id",
                table: "Screenings",
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
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Screenings");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
