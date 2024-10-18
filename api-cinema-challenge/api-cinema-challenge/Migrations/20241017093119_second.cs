using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4205), new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4208), new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4210), new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4320), new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4323), new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4324), new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdat", "startsat", "updatedat" },
                values: new object[] { new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4343), new DateTime(2024, 10, 17, 13, 31, 18, 591, DateTimeKind.Utc).AddTicks(4337), new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdat", "startsat", "updatedat" },
                values: new object[] { new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4346), new DateTime(2024, 10, 17, 14, 31, 18, 591, DateTimeKind.Utc).AddTicks(4345), new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdat", "startsat", "updatedat" },
                values: new object[] { new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4348), new DateTime(2024, 10, 17, 14, 31, 18, 591, DateTimeKind.Utc).AddTicks(4347), new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4348) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdat", "startsat", "updatedat" },
                values: new object[] { new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4350), new DateTime(2024, 10, 17, 16, 31, 18, 591, DateTimeKind.Utc).AddTicks(4349), new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4364), new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4366), new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4368), new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4368) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(8936), new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(8941), new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(8943), new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9249), new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9252), new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9254), new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdat", "startsat", "updatedat" },
                values: new object[] { new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9313), new DateTime(2024, 9, 15, 22, 29, 51, 738, DateTimeKind.Utc).AddTicks(9304), new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdat", "startsat", "updatedat" },
                values: new object[] { new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9317), new DateTime(2024, 9, 15, 23, 29, 51, 738, DateTimeKind.Utc).AddTicks(9315), new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9317) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdat", "startsat", "updatedat" },
                values: new object[] { new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9319), new DateTime(2024, 9, 15, 23, 29, 51, 738, DateTimeKind.Utc).AddTicks(9318), new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdat", "startsat", "updatedat" },
                values: new object[] { new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9322), new DateTime(2024, 9, 16, 1, 29, 51, 738, DateTimeKind.Utc).AddTicks(9321), new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9392), new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9402), new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9404), new DateTime(2024, 9, 15, 18, 29, 51, 738, DateTimeKind.Utc).AddTicks(9405) });
        }
    }
}
