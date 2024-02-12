using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class createdTickets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    numSeats = table.Column<int>(type: "integer", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                        name: "FK_tickets_screening_screening_id",
                        column: x => x.screening_id,
                        principalTable: "screening",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 20, 16, 48, 733, DateTimeKind.Utc).AddTicks(2374), new DateTime(2024, 2, 12, 20, 16, 48, 733, DateTimeKind.Utc).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 20, 16, 48, 733, DateTimeKind.Utc).AddTicks(2379), new DateTime(2024, 2, 12, 20, 16, 48, 733, DateTimeKind.Utc).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 20, 16, 48, 733, DateTimeKind.Utc).AddTicks(2382), new DateTime(2024, 2, 12, 20, 16, 48, 733, DateTimeKind.Utc).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 20, 16, 48, 733, DateTimeKind.Utc).AddTicks(2411), new DateTime(2024, 2, 12, 20, 16, 48, 733, DateTimeKind.Utc).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 20, 16, 48, 733, DateTimeKind.Utc).AddTicks(2416), new DateTime(2024, 2, 12, 20, 16, 48, 733, DateTimeKind.Utc).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 20, 16, 48, 733, DateTimeKind.Utc).AddTicks(2418), new DateTime(2024, 2, 12, 20, 16, 48, 733, DateTimeKind.Utc).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 20, 16, 48, 733, DateTimeKind.Utc).AddTicks(2437), new DateTime(2024, 2, 12, 20, 16, 48, 733, DateTimeKind.Utc).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 20, 16, 48, 733, DateTimeKind.Utc).AddTicks(2444), new DateTime(2024, 2, 12, 20, 16, 48, 733, DateTimeKind.Utc).AddTicks(2444) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 20, 16, 48, 733, DateTimeKind.Utc).AddTicks(2447), new DateTime(2024, 2, 12, 20, 16, 48, 733, DateTimeKind.Utc).AddTicks(2448) });

            migrationBuilder.CreateIndex(
                name: "IX_screening_movie_id",
                table: "screening",
                column: "movie_id");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_customer_id",
                table: "tickets",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_screening_id",
                table: "tickets",
                column: "screening_id");

            migrationBuilder.AddForeignKey(
                name: "FK_screening_movies_movie_id",
                table: "screening",
                column: "movie_id",
                principalTable: "movies",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_screening_movies_movie_id",
                table: "screening");

            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_screening_movie_id",
                table: "screening");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(828), new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(834), new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(837), new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(879), new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(884), new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(887), new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(908), new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(909) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(915), new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(918), new DateTime(2024, 2, 12, 14, 35, 50, 316, DateTimeKind.Utc).AddTicks(918) });
        }
    }
}
