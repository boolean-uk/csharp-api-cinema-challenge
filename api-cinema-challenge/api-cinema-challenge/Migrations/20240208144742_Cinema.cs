using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class Cinema : Migration
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
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    date_updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    runtime_mins = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "screening",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    movie_id = table.Column<int>(type: "integer", nullable: false),
                    screen_num = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    date_updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screening", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ticket",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    num_seats = table.Column<int>(type: "integer", nullable: false),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    date_updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticket", x => x.id);
                    table.ForeignKey(
                        name: "FK_ticket_customer_customer_id",
                        column: x => x.customer_id,
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "id", "description", "rating", "runtime_mins", "title" },
                values: new object[,]
                {
                    { 1, "A movie about Green", "5/10", 86, "Two Cars" },
                    { 2, "A movie about Rose Smelling", "4/10", 235, "Fifteen Flowers" },
                    { 3, "A movie about Bitter", "6/10", 184, "Two Flowers" },
                    { 4, "A movie about Transparent", "2/10", 259, "The Flowers" },
                    { 5, "A movie about Bitter", "6/10", 389, "An army of Leopards" },
                    { 6, "A movie about Green", "4/10", 213, "The Houses" },
                    { 7, "A movie about Bitter", "4/10", 142, "A bunch of Flowers" },
                    { 8, "A movie about Microscopic", "4/10", 182, "A bunch of Leopards" },
                    { 9, "A movie about Purple", "2/10", 398, "The Cars" },
                    { 10, "A movie about Bitter", "9/10", 263, "A herd of Cars" }
                });

            migrationBuilder.InsertData(
                table: "customer",
                columns: new[] { "id", "email", "name", "phone", "date_created", "date_updated" },
                values: new object[,]
                {
                    { 1, "Elvis@something.com", "Audrey Jagger", "78484604", new DateTime(2024, 2, 8, 14, 47, 42, 27, DateTimeKind.Utc).AddTicks(3660), new DateTime(2024, 2, 8, 14, 47, 42, 27, DateTimeKind.Utc).AddTicks(3660) },
                    { 2, "Barack@gov.nl", "Mick Hendrix", "50708225", new DateTime(2024, 2, 8, 14, 47, 42, 27, DateTimeKind.Utc).AddTicks(3696), new DateTime(2024, 2, 8, 14, 47, 42, 27, DateTimeKind.Utc).AddTicks(3696) },
                    { 3, "Jimi@bbc.co.uk", "Kate Hepburn", "75726237", new DateTime(2024, 2, 8, 14, 47, 42, 27, DateTimeKind.Utc).AddTicks(3699), new DateTime(2024, 2, 8, 14, 47, 42, 27, DateTimeKind.Utc).AddTicks(3699) },
                    { 4, "Kate@gov.nl", "Barack Obama", "92733906", new DateTime(2024, 2, 8, 14, 47, 42, 27, DateTimeKind.Utc).AddTicks(3700), new DateTime(2024, 2, 8, 14, 47, 42, 27, DateTimeKind.Utc).AddTicks(3700) },
                    { 5, "Oprah@something.com", "Mick Hepburn", "78780329", new DateTime(2024, 2, 8, 14, 47, 42, 27, DateTimeKind.Utc).AddTicks(3702), new DateTime(2024, 2, 8, 14, 47, 42, 27, DateTimeKind.Utc).AddTicks(3702) },
                    { 6, "Charles@google.com", "Mick Middleton", "86741622", new DateTime(2024, 2, 8, 14, 47, 42, 27, DateTimeKind.Utc).AddTicks(3704), new DateTime(2024, 2, 8, 14, 47, 42, 27, DateTimeKind.Utc).AddTicks(3704) },
                    { 7, "Donald@nasa.org.us", "Donald Jagger", "68075963", new DateTime(2024, 2, 8, 14, 47, 42, 27, DateTimeKind.Utc).AddTicks(3732), new DateTime(2024, 2, 8, 14, 47, 42, 27, DateTimeKind.Utc).AddTicks(3732) },
                    { 8, "Donald@something.com", "Mick Winslet", "72819482", new DateTime(2024, 2, 8, 14, 47, 42, 27, DateTimeKind.Utc).AddTicks(3734), new DateTime(2024, 2, 8, 14, 47, 42, 27, DateTimeKind.Utc).AddTicks(3734) },
                    { 9, "Audrey@theworld.ca", "Donald Winfrey", "26431278", new DateTime(2024, 2, 8, 14, 47, 42, 27, DateTimeKind.Utc).AddTicks(3735), new DateTime(2024, 2, 8, 14, 47, 42, 27, DateTimeKind.Utc).AddTicks(3735) },
                    { 10, "Kate@nasa.org.us", "Oprah Presley", "67346101", new DateTime(2024, 2, 8, 14, 47, 42, 27, DateTimeKind.Utc).AddTicks(3737), new DateTime(2024, 2, 8, 14, 47, 42, 27, DateTimeKind.Utc).AddTicks(3737) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ticket_customer_id",
                table: "ticket",
                column: "customer_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "screening");

            migrationBuilder.DropTable(
                name: "ticket");

            migrationBuilder.DropTable(
                name: "customer");
        }
    }
}
