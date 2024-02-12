using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class AddTicket : Migration
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
                    num_seats = table.Column<int>(type: "integer", nullable: false),
                    sceening_id = table.Column<int>(type: "integer", nullable: false),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticket", x => x.id);
                    table.ForeignKey(
                        name: "FK_ticket_Customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "Customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ticket_Screenings_sceening_id",
                        column: x => x.sceening_id,
                        principalTable: "Screenings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 10, 16, 854, DateTimeKind.Utc).AddTicks(8741), new DateTime(2024, 2, 12, 9, 10, 16, 854, DateTimeKind.Utc).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 10, 16, 854, DateTimeKind.Utc).AddTicks(8742), new DateTime(2024, 2, 12, 9, 10, 16, 854, DateTimeKind.Utc).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 10, 16, 854, DateTimeKind.Utc).AddTicks(8728), new DateTime(2024, 2, 12, 9, 10, 16, 854, DateTimeKind.Utc).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 10, 16, 854, DateTimeKind.Utc).AddTicks(8732), new DateTime(2024, 2, 12, 9, 10, 16, 854, DateTimeKind.Utc).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 10, 16, 854, DateTimeKind.Utc).AddTicks(8735), new DateTime(2024, 2, 12, 9, 10, 16, 854, DateTimeKind.Utc).AddTicks(8736), new DateTime(2024, 2, 12, 9, 10, 16, 854, DateTimeKind.Utc).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 10, 16, 854, DateTimeKind.Utc).AddTicks(8738), new DateTime(2024, 2, 12, 9, 10, 16, 854, DateTimeKind.Utc).AddTicks(8738), new DateTime(2024, 2, 12, 9, 10, 16, 854, DateTimeKind.Utc).AddTicks(8739) });

            migrationBuilder.CreateIndex(
                name: "IX_ticket_customer_id",
                table: "ticket",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_sceening_id",
                table: "ticket",
                column: "sceening_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ticket");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 10, 58, 264, DateTimeKind.Utc).AddTicks(3313), new DateTime(2024, 2, 8, 14, 10, 58, 264, DateTimeKind.Utc).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 10, 58, 264, DateTimeKind.Utc).AddTicks(3314), new DateTime(2024, 2, 8, 14, 10, 58, 264, DateTimeKind.Utc).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 10, 58, 264, DateTimeKind.Utc).AddTicks(3296), new DateTime(2024, 2, 8, 14, 10, 58, 264, DateTimeKind.Utc).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 10, 58, 264, DateTimeKind.Utc).AddTicks(3303), new DateTime(2024, 2, 8, 14, 10, 58, 264, DateTimeKind.Utc).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 10, 58, 264, DateTimeKind.Utc).AddTicks(3306), new DateTime(2024, 2, 8, 14, 10, 58, 264, DateTimeKind.Utc).AddTicks(3307), new DateTime(2024, 2, 8, 14, 10, 58, 264, DateTimeKind.Utc).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 10, 58, 264, DateTimeKind.Utc).AddTicks(3309), new DateTime(2024, 2, 8, 14, 10, 58, 264, DateTimeKind.Utc).AddTicks(3310), new DateTime(2024, 2, 8, 14, 10, 58, 264, DateTimeKind.Utc).AddTicks(3311) });
        }
    }
}
