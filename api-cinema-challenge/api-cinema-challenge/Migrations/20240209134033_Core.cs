using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class Core : Migration
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

            migrationBuilder.CreateTable(
                name: "ticket",
                columns: table => new
                {
                    ticket_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ticket_num_seats = table.Column<int>(type: "integer", nullable: false),
                    screening_created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    screening_updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    screening_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticket", x => x.ticket_id);
                    table.ForeignKey(
                        name: "FK_ticket_customer_customer_id",
                        column: x => x.customer_id,
                        principalTable: "customer",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ticket_screening_screening_id",
                        column: x => x.screening_id,
                        principalTable: "screening",
                        principalColumn: "screening_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customer",
                columns: new[] { "customer_id", "customer_created_date", "customer_email", "customer_name", "customer_phone", "customer_updated_date" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3915), "ola@nordmann.no", "Ola Nordmann", "+123456789", new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3916) },
                    { 2, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3918), "kari@nordmann.no", "Kari Nordmann", "+987654321", new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3918) }
                });

            migrationBuilder.InsertData(
                table: "movie",
                columns: new[] { "movie_id", "movie_created_date", "movie_description", "movie_rating", "movie_runtime", "movie_title", "movie_updated_date" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3944), "You won't believe what happens", "PG-13", 120, "Titanic", new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3945) },
                    { 2, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3946), "With a pencil", "M-17", 90, "John Wick", new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3946) },
                    { 3, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3947), "He's beginning to believe", "PG-13", 120, "Matrix", new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3947) }
                });

            migrationBuilder.InsertData(
                table: "screening",
                columns: new[] { "screening_id", "screening_capacity", "screening_created_date", "movie_id", "screening_screennumber", "screening_start_date", "screening_updated_date" },
                values: new object[,]
                {
                    { 1, 50, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3959), 1, 2, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3959), new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3960) },
                    { 2, 25, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3966), 2, 4, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3966), new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3967) },
                    { 3, 50, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3968), 3, 2, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3967), new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3968) },
                    { 4, 25, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3969), 1, 4, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3969), new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3969) },
                    { 5, 50, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3970), 2, 2, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3970), new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3970) },
                    { 6, 25, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3971), 3, 4, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3971), new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3971) },
                    { 7, 50, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3972), 1, 2, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3972), new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3972) },
                    { 8, 25, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3973), 2, 4, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3973), new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3973) },
                    { 9, 50, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3974), 3, 2, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3974), new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3974) },
                    { 10, 25, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3975), 1, 4, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3975), new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3975) },
                    { 11, 50, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3976), 2, 2, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3976), new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3977) },
                    { 12, 25, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3977), 3, 4, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3977), new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3978) }
                });

            migrationBuilder.InsertData(
                table: "ticket",
                columns: new[] { "ticket_id", "screening_created_date", "customer_id", "ticket_num_seats", "screening_id", "screening_updated_date" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3998), 1, 2, 4, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3998) },
                    { 2, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3999), 2, 2, 4, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3999) },
                    { 3, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(4000), 1, 2, 9, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(4000) },
                    { 4, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(4001), 2, 2, 9, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(4001) },
                    { 5, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(4002), 1, 1, 11, new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(4002) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screening_movie_id",
                table: "screening",
                column: "movie_id");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_customer_id",
                table: "ticket",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_screening_id",
                table: "ticket",
                column: "screening_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ticket");

            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "screening");

            migrationBuilder.DropTable(
                name: "movie");
        }
    }
}
