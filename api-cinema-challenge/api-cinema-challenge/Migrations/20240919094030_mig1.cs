using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
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
                    { 1, new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2086), "John@mail.no", "John Bravo", "99887766", new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2091) },
                    { 2, new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2098), "Fly@mail.no", "Thomas Fly", "98765432", new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2100) },
                    { 3, new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2106), "Ibb@live.no", "Ibby Secka", "45094509", new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2107) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "id", "createdat", "description", "rating", "runtimeMins", "title", "updatedat" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2505), "Leo in Hollywood", "9.3", 220, "Once Upon A Time In Hollywood", new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2507) },
                    { 2, new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2514), "Iron suit man kills enemies.", "7.3", 180, "Iron Man", new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2516) },
                    { 3, new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2521), "Man in space", "8", 90, "Interstellar", new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2522) }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "id", "capacity", "createdat", "movieid", "screennumber", "startsat", "updatedat" },
                values: new object[,]
                {
                    { 1, 50, new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2601), 1, 1, new DateTime(2024, 9, 19, 13, 40, 29, 356, DateTimeKind.Utc).AddTicks(2579), new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2603) },
                    { 2, 30, new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2612), 1, 2, new DateTime(2024, 9, 19, 14, 40, 29, 356, DateTimeKind.Utc).AddTicks(2608), new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2614) },
                    { 3, 50, new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2621), 2, 3, new DateTime(2024, 9, 19, 14, 40, 29, 356, DateTimeKind.Utc).AddTicks(2618), new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2623) },
                    { 4, 25, new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2631), 3, 4, new DateTime(2024, 9, 19, 16, 40, 29, 356, DateTimeKind.Utc).AddTicks(2628), new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2632) }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "id", "createdat", "customerid", "numseats", "screeningId", "updatedat" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2709), 1, 4, 1, new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2711) },
                    { 2, new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2717), 2, 27, 3, new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2719) },
                    { 3, new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2724), 3, 12, 2, new DateTime(2024, 9, 19, 9, 40, 29, 356, DateTimeKind.Utc).AddTicks(2725) }
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
