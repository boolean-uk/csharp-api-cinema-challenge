using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class CREATENEWTABLES : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "capacity",
                table: "screenings",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(5922), new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 28, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(5925), new DateTime(2024, 1, 30, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 23, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(5928), new DateTime(2024, 1, 25, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 18, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(5931), new DateTime(2024, 1, 21, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(5933), new DateTime(2024, 1, 15, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "capacity", "created_at", "start_time", "updated_at" },
                values: new object[] { 100, new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(6092), new DateTime(2024, 2, 2, 11, 48, 53, 198, DateTimeKind.Utc).AddTicks(6089), new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "capacity", "created_at", "start_time", "updated_at" },
                values: new object[] { 120, new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(6095), new DateTime(2024, 2, 2, 13, 48, 53, 198, DateTimeKind.Utc).AddTicks(6094), new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "capacity", "created_at", "start_time", "updated_at" },
                values: new object[] { 70, new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(6100), new DateTime(2024, 2, 2, 14, 48, 53, 198, DateTimeKind.Utc).AddTicks(6099), new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "capacity", "created_at", "start_time", "updated_at" },
                values: new object[] { 80, new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(6102), new DateTime(2024, 2, 2, 11, 48, 53, 198, DateTimeKind.Utc).AddTicks(6101), new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "capacity", "created_at", "start_time", "updated_at" },
                values: new object[] { 83, new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(6103), new DateTime(2024, 2, 2, 15, 48, 53, 198, DateTimeKind.Utc).AddTicks(6103), new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(5506), new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(5508) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 31, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(5510), new DateTime(2024, 1, 31, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(5516) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 28, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(5517), new DateTime(2024, 1, 30, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 25, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(5520), new DateTime(2024, 1, 27, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 23, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(5522), new DateTime(2024, 1, 26, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(5522) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "capacity",
                table: "screenings");

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7254), new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 27, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7256), new DateTime(2024, 1, 29, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 22, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7259), new DateTime(2024, 1, 24, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 17, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7261), new DateTime(2024, 1, 20, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 12, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7263), new DateTime(2024, 1, 14, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "start_time", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7361), new DateTime(2024, 2, 1, 16, 29, 49, 563, DateTimeKind.Utc).AddTicks(7360), new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "start_time", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7366), new DateTime(2024, 2, 1, 18, 29, 49, 563, DateTimeKind.Utc).AddTicks(7365), new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "start_time", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7368), new DateTime(2024, 2, 1, 19, 29, 49, 563, DateTimeKind.Utc).AddTicks(7367), new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "start_time", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7370), new DateTime(2024, 2, 1, 16, 29, 49, 563, DateTimeKind.Utc).AddTicks(7369), new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "start_time", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7372), new DateTime(2024, 2, 1, 20, 29, 49, 563, DateTimeKind.Utc).AddTicks(7371), new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(6987), new DateTime(2024, 2, 1, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(6991), new DateTime(2024, 1, 30, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 27, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7000), new DateTime(2024, 1, 29, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 24, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7001), new DateTime(2024, 1, 26, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7002) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 22, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7003), new DateTime(2024, 1, 25, 15, 29, 49, 563, DateTimeKind.Utc).AddTicks(7004) });
        }
    }
}
