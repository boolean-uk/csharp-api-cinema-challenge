using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class AddTicketsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    num_seats = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => new { x.screening_id, x.customer_id });
                    table.ForeignKey(
                        name: "FK_tickets_customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tickets_screenings_screening_id",
                        column: x => x.screening_id,
                        principalTable: "screenings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1896), new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1930), new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1938), new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1958), new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "rating", "runtime_mins", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1671), "PG-13", 158, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "description", "runtime_mins", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1863), "Suitable for all ages.", 91, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "runtime_mins", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1872), 106, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1886), "This is a cult classic.", "G", 87, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 51, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1975), 2, 10, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1969), new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 50, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2005), 4, 8, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2001), new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 57, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2017), 1, 40, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2014), new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 38, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2029), 2, 36, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2025), new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2033) });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "customer_id", "screening_id", "created_at", "id", "num_seats", "updated_at" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2044), 1, 1, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2063) },
                    { 3, 3, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2082), 3, 2, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2086) },
                    { 2, 4, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2073), 2, 4, new DateTime(2024, 2, 2, 7, 56, 4, 193, DateTimeKind.Utc).AddTicks(2077) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tickets_customer_id",
                table: "tickets",
                column: "customer_id");
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
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1603), new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1683), new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1701), new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1732), new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1741) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "rating", "runtime_mins", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 56, 13, 60, DateTimeKind.Utc).AddTicks(9044), "R", 178, new DateTime(2024, 2, 1, 12, 56, 13, 60, DateTimeKind.Utc).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "description", "runtime_mins", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1509), "The greatest movie ever made.", 135, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "runtime_mins", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1540), 145, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1557), "The greatest movie ever made.", "NC-17", 147, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 53, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1772), 1, 26, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1757), new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 34, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1865), 1, 22, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1853), new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 44, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1891), 2, 32, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1882), new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[] { 60, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1917), 1, 43, new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1909), new DateTime(2024, 2, 1, 12, 56, 13, 61, DateTimeKind.Utc).AddTicks(1925) });
        }
    }
}
