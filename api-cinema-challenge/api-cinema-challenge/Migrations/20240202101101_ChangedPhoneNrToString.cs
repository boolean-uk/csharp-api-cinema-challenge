using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class ChangedPhoneNrToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "phone_nr",
                table: "customers",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "phone_nr", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7914), "070666123", new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "phone_nr", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7926), "321566322", new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "phone_nr", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7929), "325666442", new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7499), new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7504) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7514), new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7514) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7877), new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7708), new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7883), new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7708), new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7885), new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7708), new DateTime(2024, 2, 2, 10, 11, 1, 685, DateTimeKind.Utc).AddTicks(7885) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "phone_nr",
                table: "customers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "phone_nr", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7859), 70666123, new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "phone_nr", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7868), 321566322, new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "phone_nr", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7870), 325666442, new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7581), new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7588), new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7833), new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7694), new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7837), new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7694), new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "starts_at", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7839), new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7694), new DateTime(2024, 2, 2, 10, 0, 55, 963, DateTimeKind.Utc).AddTicks(7839) });
        }
    }
}
