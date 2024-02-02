using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class CREATEALLTABLES : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "screen_name",
                table: "screenings");

            migrationBuilder.AddColumn<int>(
                name: "screen_number",
                table: "screenings",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5705), new DateTime(2024, 2, 2, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5707), new DateTime(2024, 1, 30, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 23, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5709), new DateTime(2024, 1, 25, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 18, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5711), new DateTime(2024, 1, 21, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 13, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5713), new DateTime(2024, 1, 15, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "screen_number", "start_time", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5830), 1, new DateTime(2024, 2, 2, 13, 7, 27, 644, DateTimeKind.Utc).AddTicks(5829), new DateTime(2024, 2, 2, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "screen_number", "start_time", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5833), 2, new DateTime(2024, 2, 2, 15, 7, 27, 644, DateTimeKind.Utc).AddTicks(5832), new DateTime(2024, 2, 2, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "screen_number", "start_time", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5835), 3, new DateTime(2024, 2, 2, 16, 7, 27, 644, DateTimeKind.Utc).AddTicks(5835), new DateTime(2024, 2, 2, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "screen_number", "start_time", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5837), 4, new DateTime(2024, 2, 2, 13, 7, 27, 644, DateTimeKind.Utc).AddTicks(5837), new DateTime(2024, 2, 2, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "screen_number", "start_time", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5839), 5, new DateTime(2024, 2, 2, 17, 7, 27, 644, DateTimeKind.Utc).AddTicks(5839), new DateTime(2024, 2, 2, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5291), new DateTime(2024, 2, 2, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5295) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 31, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5297), new DateTime(2024, 1, 31, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5306), new DateTime(2024, 1, 30, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 25, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5309), new DateTime(2024, 1, 27, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 23, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5311), new DateTime(2024, 1, 26, 12, 7, 27, 644, DateTimeKind.Utc).AddTicks(5312) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "screen_number",
                table: "screenings");

            migrationBuilder.AddColumn<string>(
                name: "screen_name",
                table: "screenings",
                type: "text",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "created_at", "screen_name", "start_time", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(6092), "Screen1", new DateTime(2024, 2, 2, 11, 48, 53, 198, DateTimeKind.Utc).AddTicks(6089), new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "screen_name", "start_time", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(6095), "Screen2", new DateTime(2024, 2, 2, 13, 48, 53, 198, DateTimeKind.Utc).AddTicks(6094), new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "screen_name", "start_time", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(6100), "Screen3", new DateTime(2024, 2, 2, 14, 48, 53, 198, DateTimeKind.Utc).AddTicks(6099), new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "screen_name", "start_time", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(6102), "Screen4", new DateTime(2024, 2, 2, 11, 48, 53, 198, DateTimeKind.Utc).AddTicks(6101), new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "screen_name", "start_time", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(6103), "Screen5", new DateTime(2024, 2, 2, 15, 48, 53, 198, DateTimeKind.Utc).AddTicks(6103), new DateTime(2024, 2, 2, 10, 48, 53, 198, DateTimeKind.Utc).AddTicks(6104) });

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
    }
}
