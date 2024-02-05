using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class addedPKToTicket : Migration
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
                    seat_nr = table.Column<int>(type: "integer", nullable: false),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.id);
                });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5358), new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5376), new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5378), new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(4992), new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5000), new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5327), new DateTime(2024, 2, 5, 14, 38, 20, 625, DateTimeKind.Utc).AddTicks(5193), new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5331), new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5193), new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5333), new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5193), new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5333) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7531), new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7539), new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7558), new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7100), new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7110), new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7484), new DateTime(2024, 2, 5, 12, 6, 4, 560, DateTimeKind.Utc).AddTicks(7315), new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7486) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7494), new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7315), new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7496), new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7315), new DateTime(2024, 2, 5, 10, 6, 4, 560, DateTimeKind.Utc).AddTicks(7496) });
        }
    }
}
