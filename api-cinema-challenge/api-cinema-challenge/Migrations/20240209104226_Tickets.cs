using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class Tickets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ticket",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    num_seats = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_ticket_screening_screening_id",
                        column: x => x.screening_id,
                        principalTable: "screening",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 42, 26, 137, DateTimeKind.Utc).AddTicks(5335), new DateTime(2024, 2, 9, 10, 42, 26, 137, DateTimeKind.Utc).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 42, 26, 137, DateTimeKind.Utc).AddTicks(5350), new DateTime(2024, 2, 9, 10, 42, 26, 137, DateTimeKind.Utc).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 42, 26, 137, DateTimeKind.Utc).AddTicks(5353), new DateTime(2024, 2, 9, 10, 42, 26, 137, DateTimeKind.Utc).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 42, 26, 137, DateTimeKind.Utc).AddTicks(5488), new DateTime(2024, 2, 9, 10, 42, 26, 137, DateTimeKind.Utc).AddTicks(5491) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 42, 26, 137, DateTimeKind.Utc).AddTicks(5497), new DateTime(2024, 2, 9, 10, 42, 26, 137, DateTimeKind.Utc).AddTicks(5498) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 42, 26, 137, DateTimeKind.Utc).AddTicks(5557), new DateTime(2024, 2, 9, 10, 42, 26, 137, DateTimeKind.Utc).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 42, 26, 137, DateTimeKind.Utc).AddTicks(5566), new DateTime(2024, 2, 9, 10, 42, 26, 137, DateTimeKind.Utc).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 42, 26, 137, DateTimeKind.Utc).AddTicks(5668), new DateTime(2024, 2, 9, 10, 42, 26, 137, DateTimeKind.Utc).AddTicks(5669) });

            migrationBuilder.InsertData(
                table: "ticket",
                columns: new[] { "id", "created_at", "customer_id", "num_seats", "screening_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 9, 10, 42, 26, 137, DateTimeKind.Utc).AddTicks(5768), 1, 2, 2, new DateTime(2024, 2, 9, 10, 42, 26, 137, DateTimeKind.Utc).AddTicks(5769) },
                    { 2, new DateTime(2024, 2, 9, 10, 42, 26, 137, DateTimeKind.Utc).AddTicks(5778), 2, 38, 1, new DateTime(2024, 2, 9, 10, 42, 26, 137, DateTimeKind.Utc).AddTicks(5779) }
                });

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

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3203), new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3209), new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3212), new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3249), new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3253), new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3309), new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3313), new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3316), new DateTime(2024, 2, 8, 10, 24, 6, 268, DateTimeKind.Utc).AddTicks(3317) });
        }
    }
}
