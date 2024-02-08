using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_name = table.Column<string>(type: "text", nullable: false),
                    customer_email = table.Column<string>(type: "text", nullable: false),
                    customer_phone = table.Column<string>(type: "text", nullable: false),
                    customer_created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    customer_updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.customer_id);
                });

            migrationBuilder.CreateTable(
                name: "movie",
                columns: table => new
                {
                    movie_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    movie_title = table.Column<string>(type: "text", nullable: false),
                    movie_rating = table.Column<string>(type: "text", nullable: false),
                    movie_description = table.Column<string>(type: "text", nullable: false),
                    movie_runtime = table.Column<int>(type: "integer", nullable: false),
                    movie_created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    movie_updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movie", x => x.movie_id);
                });

            migrationBuilder.CreateTable(
                name: "screening",
                columns: table => new
                {
                    screening_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    screening_screennumber = table.Column<int>(type: "integer", nullable: false),
                    screening_capacity = table.Column<int>(type: "integer", nullable: false),
                    screening_start_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    screening_created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    screening_updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    movie_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screening", x => x.screening_id);
                    table.ForeignKey(
                        name: "FK_screening_movie_movie_id",
                        column: x => x.movie_id,
                        principalTable: "movie",
                        principalColumn: "movie_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customer",
                columns: new[] { "customer_id", "customer_created_date", "customer_email", "customer_name", "customer_phone", "customer_updated_date" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4261), "ola@nordmann.no", "Ola Nordmann", "+123456789", new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4264) },
                    { 2, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4268), "kari@nordmann.no", "Kari Nordmann", "+987654321", new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4269) }
                });

            migrationBuilder.InsertData(
                table: "movie",
                columns: new[] { "movie_id", "movie_created_date", "movie_description", "movie_rating", "movie_runtime", "movie_title", "movie_updated_date" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4326), "You won't believe what happens", "PG-13", 120, "Titanic", new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4327) },
                    { 2, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4330), "With a pencil", "M-17", 90, "John Wick", new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4331) },
                    { 3, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4333), "He's beggining to believe", "PG-13", 120, "Matrix", new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4334) }
                });

            migrationBuilder.InsertData(
                table: "screening",
                columns: new[] { "screening_id", "screening_capacity", "screening_created_date", "movie_id", "screening_screennumber", "screening_start_date", "screening_updated_date" },
                values: new object[,]
                {
                    { 1, 50, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4362), 1, 2, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4361), new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4363) },
                    { 2, 25, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4368), 2, 4, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4368), new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4369) },
                    { 3, 50, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4372), 3, 2, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4371), new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4373) },
                    { 4, 25, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4376), 1, 4, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4375), new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4377) },
                    { 5, 50, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4380), 2, 2, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4379), new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4381) },
                    { 6, 25, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4383), 3, 4, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4382), new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4384) },
                    { 7, 50, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4388), 1, 2, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4388), new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4389) },
                    { 8, 25, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4393), 2, 4, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4392), new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4393) },
                    { 9, 50, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4396), 3, 2, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4395), new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4397) },
                    { 10, 25, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4399), 1, 4, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4398), new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4400) },
                    { 11, 50, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4402), 2, 2, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4402), new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4403) },
                    { 12, 25, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4405), 3, 4, new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4405), new DateTime(2024, 2, 8, 12, 8, 30, 189, DateTimeKind.Utc).AddTicks(4406) }
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
