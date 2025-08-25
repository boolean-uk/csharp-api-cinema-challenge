using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class SecondImpact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "screenings",
                newName: "capacity");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "screenings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "screenings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "movies",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "movies",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "rating", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "G", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "rating", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "G", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "created_at",
                table: "screenings");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "screenings");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "movies");

            migrationBuilder.RenameColumn(
                name: "capacity",
                table: "screenings",
                newName: "Capacity");

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "rating",
                value: "Very good");

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "rating",
                value: "Very good");
        }
    }
}
