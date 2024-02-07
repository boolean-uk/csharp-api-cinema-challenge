using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class Movies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 7, 13, 46, 48, DateTimeKind.Utc).AddTicks(2238), new DateTime(2024, 2, 7, 7, 13, 46, 48, DateTimeKind.Utc).AddTicks(2242) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 7, 10, 57, 368, DateTimeKind.Utc).AddTicks(8438), new DateTime(2024, 2, 7, 7, 10, 57, 368, DateTimeKind.Utc).AddTicks(8442) });
        }
    }
}
