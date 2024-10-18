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
                name: "Customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    createdat = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedat = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    runtimeMins = table.Column<int>(type: "integer", nullable: false),
                    createdat = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedat = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    movieid = table.Column<int>(type: "integer", nullable: false),
                    screennumber = table.Column<int>(type: "integer", nullable: false),
                    startsat = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    createdat = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedat = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screenings", x => x.id);
                    table.ForeignKey(
                        name: "FK_Screenings_Movies_movieid",
                        column: x => x.movieid,
                        principalTable: "Movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customerid = table.Column<int>(type: "integer", nullable: false),
                    screeningId = table.Column<int>(type: "integer", nullable: false),
                    numseats = table.Column<int>(type: "integer", nullable: false),
                    createdat = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedat = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.id);
                    table.ForeignKey(
                        name: "FK_Tickets_Customers_customerid",
                        column: x => x.customerid,
                        principalTable: "Customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Screenings_screeningId",
                        column: x => x.screeningId,
                        principalTable: "Screenings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "id", "createdat", "email", "name", "phone", "updatedat" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(8936), "John@mail.no", "John Bravo", "99887766", new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(8940) },
                    { 2, new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(8941), "Fly@mail.no", "Thomas Fly", "98765432", new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(8942) },
                    { 3, new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(8943), "Ibb@live.no", "Ibby Secka", "45094509", new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(8944) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "id", "createdat", "description", "rating", "runtimeMins", "title", "updatedat" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9249), "Leo in Hollywood", "9.3", 220, "Once Upon A Time In Hollywood", new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9250) },
                    { 2, new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9252), "Iron suit man kills enemies.", "7.3", 180, "Iron Man", new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9253) },
                    { 3, new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9254), "Man in space", "8", 90, "Interstellar", new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9255) }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "id", "capacity", "createdat", "movieid", "screennumber", "startsat", "updatedat" },
                values: new object[,]
                {
                    { 1, 50, new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9313), 1, 1, new DateTime(2024, 9, 15, 22, 29, 51, 738, DateTimeKind.Utc).AddTicks(9304), new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9314) },
                    { 2, 30, new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9317), 1, 2, new DateTime(2024, 9, 15, 23, 29, 51, 738, DateTimeKind.Utc).AddTicks(9315), new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9317) },
                    { 3, 50, new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9319), 2, 3, new DateTime(2024, 9, 15, 23, 29, 51, 738, DateTimeKind.Utc).AddTicks(9318), new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9320) },
                    { 4, 25, new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9322), 3, 4, new DateTime(2024, 9, 16, 1, 29, 51, 738, DateTimeKind.Utc).AddTicks(9321), new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9322) }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "id", "createdat", "customerid", "numseats", "screeningId", "updatedat" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9392), 1, 4, 1, new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9401) },
                    { 2, new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9402), 2, 27, 3, new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9403) },
                    { 3, new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9404), 3, 12, 2, new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9405) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_movieid",
                table: "Screenings",
                column: "movieid");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_customerid",
                table: "Tickets",
                column: "customerid");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_screeningId",
                table: "Tickets",
                column: "screeningId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Screenings");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
