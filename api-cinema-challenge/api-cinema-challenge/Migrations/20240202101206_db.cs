using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class db : Migration
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
                    phone = table.Column<int>(type: "integer", nullable: false),
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
                name: "ticket",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    num_seats = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticket", x => x.id);
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
                    table.ForeignKey(
                        name: "FK_screening_movie_movie_id",
                        column: x => x.movie_id,
                        principalTable: "movie",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "customer_ticket",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    ticket_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_ticket", x => new { x.customer_id, x.ticket_id });
                    table.ForeignKey(
                        name: "FK_customer_ticket_customer_customer_id",
                        column: x => x.customer_id,
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_customer_ticket_ticket_ticket_id",
                        column: x => x.ticket_id,
                        principalTable: "ticket",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "screening_ticket",
                columns: table => new
                {
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    ticket_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screening_ticket", x => new { x.ticket_id, x.screening_id });
                    table.ForeignKey(
                        name: "FK_screening_ticket_screening_screening_id",
                        column: x => x.screening_id,
                        principalTable: "screening",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_screening_ticket_ticket_ticket_id",
                        column: x => x.ticket_id,
                        principalTable: "ticket",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customer",
                columns: new[] { "id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3647), "audrey@gov.ru", "Audrey", 555123456, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3651) },
                    { 2, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3654), "donald@tesla.com", "Donald", 555123456, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3654) },
                    { 3, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3656), "elvis@gov.nl", "Elvis", 555123456, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3657) },
                    { 4, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3658), "barack@tesla.com", "Barack", 555123456, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3658) },
                    { 5, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3659), "oprah@gov.us", "Oprah", 555123456, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3660) },
                    { 6, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3662), "jimi@bbc.co.uk", "Jimi", 555123456, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3662) },
                    { 7, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3664), "mick@nasa.org.us", "Mick", 555123456, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3664) },
                    { 8, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3665), "kate@gov.us", "Kate", 555123456, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3670) },
                    { 9, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3671), "charles@gov.ru", "Charles", 555123456, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3672) },
                    { 10, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3674), "kate@theworld.ca", "Kate", 555123456, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3674) }
                });

            migrationBuilder.InsertData(
                table: "movie",
                columns: new[] { "id", "created_at", "description", "rating", "runtime_mins", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3678), "Oprah", "PG-99", 120, "Titanic", new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3679) },
                    { 2, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3681), "Kate", "PG-13", 120, "The Godfather", new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3681) },
                    { 3, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3682), "Mick", "PG-99", 120, "Forrest Gump", new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3682) },
                    { 4, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3683), "Kate", "PG-99", 120, "Forrest Gump", new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3683) },
                    { 5, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3684), "Audrey", "PG-7", 120, "Titanic", new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3685) },
                    { 6, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3687), "Kate", "PG-18", 120, "Inception", new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3687) },
                    { 7, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3694), "Kate", "PG-18", 120, "Pulp Fiction", new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3694) },
                    { 8, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3695), "Oprah", "PG-18", 120, "The Dark Knight", new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3695) },
                    { 9, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3696), "Oprah", "PG-18", 120, "The Godfather", new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3696) },
                    { 10, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3698), "Elvis", "PG-18", 120, "Inception", new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3698) }
                });

            migrationBuilder.InsertData(
                table: "ticket",
                columns: new[] { "id", "created_at", "num_seats", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3726), 2, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3726) },
                    { 2, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3728), 2, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3728) },
                    { 3, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3728), 2, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3729) },
                    { 4, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3729), 2, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3729) },
                    { 5, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3730), 2, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3730) },
                    { 6, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3731), 2, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3732) },
                    { 7, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3732), 2, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3732) },
                    { 8, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3733), 2, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3733) },
                    { 9, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3733), 2, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3733) },
                    { 10, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3734), 2, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3735) }
                });

            migrationBuilder.InsertData(
                table: "customer_ticket",
                columns: new[] { "customer_id", "ticket_id" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 }
                });

            migrationBuilder.InsertData(
                table: "screening",
                columns: new[] { "id", "capacity", "created_at", "movie_id", "starts_at", "updated_at", "screen_number" },
                values: new object[,]
                {
                    { 1, 30, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3709), 3, new DateTime(2024, 2, 3, 0, 12, 5, 513, DateTimeKind.Utc).AddTicks(3701), new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3710), 1 },
                    { 2, 30, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3712), 6, new DateTime(2024, 2, 2, 17, 12, 5, 513, DateTimeKind.Utc).AddTicks(3712), new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3713), 2 },
                    { 3, 30, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3714), 6, new DateTime(2024, 2, 2, 15, 12, 5, 513, DateTimeKind.Utc).AddTicks(3713), new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3714), 3 },
                    { 4, 30, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3715), 6, new DateTime(2024, 2, 2, 23, 12, 5, 513, DateTimeKind.Utc).AddTicks(3715), new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3715), 4 },
                    { 5, 30, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3716), 9, new DateTime(2024, 2, 2, 14, 12, 5, 513, DateTimeKind.Utc).AddTicks(3716), new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3717), 5 },
                    { 6, 30, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3719), 5, new DateTime(2024, 2, 3, 8, 12, 5, 513, DateTimeKind.Utc).AddTicks(3718), new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3719), 6 },
                    { 7, 30, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3720), 10, new DateTime(2024, 2, 2, 23, 12, 5, 513, DateTimeKind.Utc).AddTicks(3719), new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3720), 7 },
                    { 8, 30, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3721), 10, new DateTime(2024, 2, 2, 20, 12, 5, 513, DateTimeKind.Utc).AddTicks(3721), new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3721), 8 },
                    { 9, 30, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3722), 4, new DateTime(2024, 2, 2, 21, 12, 5, 513, DateTimeKind.Utc).AddTicks(3722), new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3722), 9 },
                    { 10, 30, new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3724), 2, new DateTime(2024, 2, 2, 21, 12, 5, 513, DateTimeKind.Utc).AddTicks(3724), new DateTime(2024, 2, 2, 10, 12, 5, 513, DateTimeKind.Utc).AddTicks(3724), 10 }
                });

            migrationBuilder.InsertData(
                table: "screening_ticket",
                columns: new[] { "screening_id", "ticket_id" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_customer_ticket_ticket_id",
                table: "customer_ticket",
                column: "ticket_id");

            migrationBuilder.CreateIndex(
                name: "IX_screening_movie_id",
                table: "screening",
                column: "movie_id");

            migrationBuilder.CreateIndex(
                name: "IX_screening_ticket_screening_id",
                table: "screening_ticket",
                column: "screening_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customer_ticket");

            migrationBuilder.DropTable(
                name: "screening_ticket");

            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "screening");

            migrationBuilder.DropTable(
                name: "ticket");

            migrationBuilder.DropTable(
                name: "movie");
        }
    }
}
