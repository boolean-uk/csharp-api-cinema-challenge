using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3111), new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3117), new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3119), new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3123), new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3126), new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3127), new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3128) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3129), new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3129) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3133), new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3133), new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3136), new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3136), new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3139), new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3142), new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3142) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(5996), new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6002), new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6004), new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6009), new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6009) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6012), new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6014), new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6015), new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6018), new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6018), new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6019) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6021), new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6021), new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6023), new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6026), new DateTime(2024, 9, 12, 7, 20, 17, 979, DateTimeKind.Utc).AddTicks(6026) });
        }
    }
}
