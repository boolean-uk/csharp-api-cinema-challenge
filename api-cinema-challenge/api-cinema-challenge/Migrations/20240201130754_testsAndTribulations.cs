using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class testsAndTribulations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 2, 1, 13, 7, 54, 436, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 2, 1, 13, 7, 54, 436, DateTimeKind.Utc).AddTicks(8535));

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "CreatedAt", "email", "name", "phone_nr", "screening_id", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 2, 1, 13, 7, 54, 436, DateTimeKind.Utc).AddTicks(8537), "Real@Email.mars", "Person Humansson", 325666442, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 2, 1, 13, 7, 54, 436, DateTimeKind.Utc).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 2, 1, 13, 7, 54, 436, DateTimeKind.Utc).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "starts_at" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 7, 54, 436, DateTimeKind.Utc).AddTicks(8507), new DateTime(2024, 2, 1, 13, 7, 54, 436, DateTimeKind.Utc).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "starts_at" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 7, 54, 436, DateTimeKind.Utc).AddTicks(8513), new DateTime(2024, 2, 1, 13, 7, 54, 436, DateTimeKind.Utc).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "starts_at" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 7, 54, 436, DateTimeKind.Utc).AddTicks(8514), new DateTime(2024, 2, 1, 13, 7, 54, 436, DateTimeKind.Utc).AddTicks(8389) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 2, 1, 12, 55, 6, 161, DateTimeKind.Utc).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 2, 1, 12, 55, 6, 161, DateTimeKind.Utc).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 2, 1, 12, 55, 6, 161, DateTimeKind.Utc).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 2, 1, 12, 55, 6, 161, DateTimeKind.Utc).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "starts_at" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 55, 6, 161, DateTimeKind.Utc).AddTicks(8717), new DateTime(2024, 2, 1, 12, 55, 6, 161, DateTimeKind.Utc).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "starts_at" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 55, 6, 161, DateTimeKind.Utc).AddTicks(8723), new DateTime(2024, 2, 1, 12, 55, 6, 161, DateTimeKind.Utc).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "starts_at" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 55, 6, 161, DateTimeKind.Utc).AddTicks(8726), new DateTime(2024, 2, 1, 12, 55, 6, 161, DateTimeKind.Utc).AddTicks(8383) });
        }
    }
}
