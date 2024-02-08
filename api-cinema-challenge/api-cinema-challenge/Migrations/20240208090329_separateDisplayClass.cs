using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class separateDisplayClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "capacity",
                table: "screenings");

            migrationBuilder.RenameColumn(
                name: "screen_numbers",
                table: "screenings",
                newName: "display_id");

            migrationBuilder.CreateTable(
                name: "displays",
                columns: table => new
                {
                    display_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    screen_number = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_displays", x => x.display_id);
                });

            migrationBuilder.InsertData(
                table: "displays",
                columns: new[] { "display_id", "capacity", "created_at", "screen_number", "updated_at" },
                values: new object[,]
                {
                    { 1, 15, new DateTime(1989, 3, 28, 1, 4, 24, 0, DateTimeKind.Utc), 1, new DateTime(1989, 3, 28, 1, 4, 24, 0, DateTimeKind.Utc) },
                    { 2, 25, new DateTime(1959, 7, 7, 8, 20, 55, 0, DateTimeKind.Utc), 2, new DateTime(1959, 7, 7, 8, 20, 55, 0, DateTimeKind.Utc) },
                    { 3, 73, new DateTime(1992, 7, 15, 17, 7, 33, 0, DateTimeKind.Utc), 3, new DateTime(1992, 7, 15, 17, 7, 33, 0, DateTimeKind.Utc) },
                    { 4, 32, new DateTime(2000, 10, 3, 0, 9, 48, 0, DateTimeKind.Utc), 4, new DateTime(2000, 10, 3, 0, 9, 48, 0, DateTimeKind.Utc) },
                    { 5, 24, new DateTime(2004, 11, 5, 5, 12, 45, 0, DateTimeKind.Utc), 5, new DateTime(2004, 11, 5, 5, 12, 45, 0, DateTimeKind.Utc) },
                    { 6, 73, new DateTime(1963, 2, 24, 13, 54, 17, 0, DateTimeKind.Utc), 6, new DateTime(1963, 2, 24, 13, 54, 17, 0, DateTimeKind.Utc) },
                    { 7, 22, new DateTime(1963, 8, 13, 11, 32, 9, 0, DateTimeKind.Utc), 7, new DateTime(1963, 8, 13, 11, 32, 9, 0, DateTimeKind.Utc) },
                    { 8, 92, new DateTime(2007, 6, 4, 12, 30, 30, 0, DateTimeKind.Utc), 8, new DateTime(2007, 6, 4, 12, 30, 30, 0, DateTimeKind.Utc) },
                    { 9, 8, new DateTime(2008, 4, 10, 2, 14, 35, 0, DateTimeKind.Utc), 9, new DateTime(2008, 4, 10, 2, 14, 35, 0, DateTimeKind.Utc) },
                    { 10, 62, new DateTime(1929, 8, 2, 3, 13, 9, 0, DateTimeKind.Utc), 10, new DateTime(1929, 8, 2, 3, 13, 9, 0, DateTimeKind.Utc) },
                    { 11, 52, new DateTime(1930, 3, 11, 11, 50, 10, 0, DateTimeKind.Utc), 11, new DateTime(1930, 3, 11, 11, 50, 10, 0, DateTimeKind.Utc) },
                    { 12, 38, new DateTime(1910, 3, 20, 5, 12, 25, 0, DateTimeKind.Utc), 12, new DateTime(1910, 3, 20, 5, 12, 25, 0, DateTimeKind.Utc) },
                    { 13, 42, new DateTime(1912, 4, 10, 22, 8, 41, 0, DateTimeKind.Utc), 13, new DateTime(1912, 4, 10, 22, 8, 41, 0, DateTimeKind.Utc) },
                    { 14, 29, new DateTime(1985, 4, 12, 15, 20, 50, 0, DateTimeKind.Utc), 14, new DateTime(1985, 4, 12, 15, 20, 50, 0, DateTimeKind.Utc) },
                    { 15, 62, new DateTime(1949, 5, 27, 5, 17, 11, 0, DateTimeKind.Utc), 15, new DateTime(1949, 5, 27, 5, 17, 11, 0, DateTimeKind.Utc) },
                    { 16, 23, new DateTime(1926, 5, 14, 6, 12, 15, 0, DateTimeKind.Utc), 16, new DateTime(1926, 5, 14, 6, 12, 15, 0, DateTimeKind.Utc) },
                    { 17, 67, new DateTime(1998, 5, 18, 22, 26, 18, 0, DateTimeKind.Utc), 17, new DateTime(1998, 5, 18, 22, 26, 18, 0, DateTimeKind.Utc) },
                    { 18, 52, new DateTime(2002, 7, 5, 22, 59, 53, 0, DateTimeKind.Utc), 18, new DateTime(2002, 7, 5, 22, 59, 53, 0, DateTimeKind.Utc) },
                    { 19, 72, new DateTime(1930, 4, 17, 9, 27, 55, 0, DateTimeKind.Utc), 19, new DateTime(1930, 4, 17, 9, 27, 55, 0, DateTimeKind.Utc) },
                    { 20, 79, new DateTime(1991, 7, 26, 12, 4, 25, 0, DateTimeKind.Utc), 20, new DateTime(1991, 7, 26, 12, 4, 25, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 1,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1929, 10, 26, 12, 0, 50, 0, DateTimeKind.Utc), new DateTime(1929, 11, 24, 16, 0, 50, 0, DateTimeKind.Utc), new DateTime(1929, 10, 26, 12, 0, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 2,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(2019, 10, 4, 1, 7, 45, 0, DateTimeKind.Utc), new DateTime(2019, 10, 9, 6, 7, 45, 0, DateTimeKind.Utc), new DateTime(2019, 10, 4, 1, 7, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 3,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1904, 9, 25, 2, 49, 42, 0, DateTimeKind.Utc), new DateTime(1904, 10, 19, 4, 49, 42, 0, DateTimeKind.Utc), new DateTime(1904, 9, 25, 2, 49, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 4,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1986, 6, 13, 0, 59, 57, 0, DateTimeKind.Utc), new DateTime(1986, 7, 7, 2, 59, 57, 0, DateTimeKind.Utc), new DateTime(1986, 6, 13, 0, 59, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 5,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1974, 10, 26, 13, 33, 35, 0, DateTimeKind.Utc), new DateTime(1974, 11, 22, 16, 33, 35, 0, DateTimeKind.Utc), new DateTime(1974, 10, 26, 13, 33, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 6,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1941, 3, 9, 5, 41, 34, 0, DateTimeKind.Utc), new DateTime(1941, 3, 12, 11, 41, 34, 0, DateTimeKind.Utc), new DateTime(1941, 3, 9, 5, 41, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 7,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1949, 4, 18, 7, 58, 9, 0, DateTimeKind.Utc), new DateTime(1949, 4, 19, 16, 58, 9, 0, DateTimeKind.Utc), new DateTime(1949, 4, 18, 7, 58, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 8,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1995, 2, 6, 19, 19, 42, 0, DateTimeKind.Utc), new DateTime(1995, 2, 11, 23, 19, 42, 0, DateTimeKind.Utc), new DateTime(1995, 2, 6, 19, 19, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 9,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1905, 8, 23, 5, 49, 35, 0, DateTimeKind.Utc), new DateTime(1905, 9, 21, 9, 49, 35, 0, DateTimeKind.Utc), new DateTime(1905, 8, 23, 5, 49, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 10,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(2023, 3, 25, 22, 54, 9, 0, DateTimeKind.Utc), new DateTime(2023, 4, 19, 6, 54, 9, 0, DateTimeKind.Utc), new DateTime(2023, 3, 25, 22, 54, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 11,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(2016, 5, 8, 12, 43, 51, 0, DateTimeKind.Utc), new DateTime(2016, 5, 28, 16, 43, 51, 0, DateTimeKind.Utc), new DateTime(2016, 5, 8, 12, 43, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 12,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1953, 10, 2, 6, 41, 30, 0, DateTimeKind.Utc), new DateTime(1953, 10, 25, 7, 41, 30, 0, DateTimeKind.Utc), new DateTime(1953, 10, 2, 6, 41, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 13,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1910, 5, 15, 6, 16, 48, 0, DateTimeKind.Utc), new DateTime(1910, 6, 3, 1, 16, 48, 0, DateTimeKind.Utc), new DateTime(1910, 5, 15, 6, 16, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 14,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1995, 9, 15, 4, 29, 54, 0, DateTimeKind.Utc), new DateTime(1995, 9, 30, 7, 29, 54, 0, DateTimeKind.Utc), new DateTime(1995, 9, 15, 4, 29, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 15,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1999, 2, 13, 17, 13, 28, 0, DateTimeKind.Utc), new DateTime(1999, 3, 12, 9, 13, 28, 0, DateTimeKind.Utc), new DateTime(1999, 2, 13, 17, 13, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 16,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1987, 6, 12, 10, 22, 33, 0, DateTimeKind.Utc), new DateTime(1987, 6, 17, 14, 22, 33, 0, DateTimeKind.Utc), new DateTime(1987, 6, 12, 10, 22, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 17,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(2010, 3, 13, 8, 23, 29, 0, DateTimeKind.Utc), new DateTime(2010, 4, 6, 6, 23, 29, 0, DateTimeKind.Utc), new DateTime(2010, 3, 13, 8, 23, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 18,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1980, 9, 27, 6, 6, 27, 0, DateTimeKind.Utc), new DateTime(1980, 10, 12, 2, 6, 27, 0, DateTimeKind.Utc), new DateTime(1980, 9, 27, 6, 6, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 19,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1907, 8, 27, 1, 10, 7, 0, DateTimeKind.Utc), new DateTime(1907, 9, 12, 1, 10, 7, 0, DateTimeKind.Utc), new DateTime(1907, 8, 27, 1, 10, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 20,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1979, 9, 26, 8, 44, 36, 0, DateTimeKind.Utc), new DateTime(1979, 10, 10, 15, 44, 36, 0, DateTimeKind.Utc), new DateTime(1979, 9, 26, 8, 44, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 21,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1951, 8, 17, 14, 34, 13, 0, DateTimeKind.Utc), new DateTime(1951, 9, 6, 2, 34, 13, 0, DateTimeKind.Utc), new DateTime(1951, 8, 17, 14, 34, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 22,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1911, 8, 28, 22, 22, 2, 0, DateTimeKind.Utc), new DateTime(1911, 9, 9, 10, 22, 2, 0, DateTimeKind.Utc), new DateTime(1911, 8, 28, 22, 22, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 23,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1942, 5, 11, 0, 32, 42, 0, DateTimeKind.Utc), new DateTime(1942, 5, 22, 9, 32, 42, 0, DateTimeKind.Utc), new DateTime(1942, 5, 11, 0, 32, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 24,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(2020, 6, 1, 23, 39, 31, 0, DateTimeKind.Utc), new DateTime(2020, 6, 15, 21, 39, 31, 0, DateTimeKind.Utc), new DateTime(2020, 6, 1, 23, 39, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 25,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1965, 7, 9, 6, 48, 38, 0, DateTimeKind.Utc), new DateTime(1965, 7, 11, 15, 48, 38, 0, DateTimeKind.Utc), new DateTime(1965, 7, 9, 6, 48, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 26,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1978, 6, 14, 20, 55, 41, 0, DateTimeKind.Utc), new DateTime(1978, 6, 20, 23, 55, 41, 0, DateTimeKind.Utc), new DateTime(1978, 6, 14, 20, 55, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 27,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(2010, 1, 6, 17, 10, 27, 0, DateTimeKind.Utc), new DateTime(2010, 1, 13, 20, 10, 27, 0, DateTimeKind.Utc), new DateTime(2010, 1, 6, 17, 10, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 28,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1955, 2, 10, 21, 43, 45, 0, DateTimeKind.Utc), new DateTime(1955, 3, 9, 21, 43, 45, 0, DateTimeKind.Utc), new DateTime(1955, 2, 10, 21, 43, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 29,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1991, 7, 6, 5, 23, 13, 0, DateTimeKind.Utc), new DateTime(1991, 7, 29, 15, 23, 13, 0, DateTimeKind.Utc), new DateTime(1991, 7, 6, 5, 23, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 30,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1972, 5, 2, 2, 3, 56, 0, DateTimeKind.Utc), new DateTime(1972, 5, 23, 20, 3, 56, 0, DateTimeKind.Utc), new DateTime(1972, 5, 2, 2, 3, 56, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 31,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(2016, 10, 24, 8, 19, 51, 0, DateTimeKind.Utc), new DateTime(2016, 11, 21, 17, 19, 51, 0, DateTimeKind.Utc), new DateTime(2016, 10, 24, 8, 19, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 32,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1967, 6, 15, 16, 9, 28, 0, DateTimeKind.Utc), new DateTime(1967, 6, 24, 10, 9, 28, 0, DateTimeKind.Utc), new DateTime(1967, 6, 15, 16, 9, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 33,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1961, 3, 10, 13, 31, 32, 0, DateTimeKind.Utc), new DateTime(1961, 3, 10, 18, 31, 32, 0, DateTimeKind.Utc), new DateTime(1961, 3, 10, 13, 31, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 34,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1921, 7, 26, 12, 32, 12, 0, DateTimeKind.Utc), new DateTime(1921, 7, 27, 23, 32, 12, 0, DateTimeKind.Utc), new DateTime(1921, 7, 26, 12, 32, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 35,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1952, 5, 4, 6, 15, 29, 0, DateTimeKind.Utc), new DateTime(1952, 5, 20, 7, 15, 29, 0, DateTimeKind.Utc), new DateTime(1952, 5, 4, 6, 15, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 36,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1978, 9, 1, 6, 47, 21, 0, DateTimeKind.Utc), new DateTime(1978, 9, 20, 6, 47, 21, 0, DateTimeKind.Utc), new DateTime(1978, 9, 1, 6, 47, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 37,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1977, 2, 23, 11, 21, 13, 0, DateTimeKind.Utc), new DateTime(1977, 3, 3, 0, 21, 13, 0, DateTimeKind.Utc), new DateTime(1977, 2, 23, 11, 21, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 38,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1929, 1, 13, 17, 43, 8, 0, DateTimeKind.Utc), new DateTime(1929, 1, 22, 21, 43, 8, 0, DateTimeKind.Utc), new DateTime(1929, 1, 13, 17, 43, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 39,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(2011, 1, 26, 12, 54, 26, 0, DateTimeKind.Utc), new DateTime(2011, 1, 26, 20, 54, 26, 0, DateTimeKind.Utc), new DateTime(2011, 1, 26, 12, 54, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 40,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1901, 5, 8, 15, 56, 54, 0, DateTimeKind.Utc), new DateTime(1901, 5, 24, 7, 56, 54, 0, DateTimeKind.Utc), new DateTime(1901, 5, 8, 15, 56, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 41,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1988, 4, 7, 0, 4, 21, 0, DateTimeKind.Utc), new DateTime(1988, 4, 18, 17, 4, 21, 0, DateTimeKind.Utc), new DateTime(1988, 4, 7, 0, 4, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 42,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1958, 3, 13, 23, 55, 26, 0, DateTimeKind.Utc), new DateTime(1958, 4, 12, 11, 55, 26, 0, DateTimeKind.Utc), new DateTime(1958, 3, 13, 23, 55, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 43,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1992, 8, 8, 16, 17, 31, 0, DateTimeKind.Utc), new DateTime(1992, 8, 10, 13, 17, 31, 0, DateTimeKind.Utc), new DateTime(1992, 8, 8, 16, 17, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 44,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1994, 8, 20, 23, 22, 13, 0, DateTimeKind.Utc), new DateTime(1994, 9, 5, 2, 22, 13, 0, DateTimeKind.Utc), new DateTime(1994, 8, 20, 23, 22, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 45,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1973, 2, 26, 13, 14, 23, 0, DateTimeKind.Utc), new DateTime(1973, 3, 20, 21, 14, 23, 0, DateTimeKind.Utc), new DateTime(1973, 2, 26, 13, 14, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 46,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1909, 11, 5, 21, 46, 5, 0, DateTimeKind.Utc), new DateTime(1909, 11, 9, 19, 46, 5, 0, DateTimeKind.Utc), new DateTime(1909, 11, 5, 21, 46, 5, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 47,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(2022, 3, 27, 2, 15, 29, 0, DateTimeKind.Utc), new DateTime(2022, 4, 25, 22, 15, 29, 0, DateTimeKind.Utc), new DateTime(2022, 3, 27, 2, 15, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 48,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1985, 11, 3, 11, 46, 11, 0, DateTimeKind.Utc), new DateTime(1985, 11, 27, 12, 46, 11, 0, DateTimeKind.Utc), new DateTime(1985, 11, 3, 11, 46, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 49,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1920, 4, 3, 17, 52, 13, 0, DateTimeKind.Utc), new DateTime(1920, 4, 18, 9, 52, 13, 0, DateTimeKind.Utc), new DateTime(1920, 4, 3, 17, 52, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 50,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1925, 8, 26, 0, 25, 57, 0, DateTimeKind.Utc), new DateTime(1925, 9, 24, 8, 25, 57, 0, DateTimeKind.Utc), new DateTime(1925, 8, 26, 0, 25, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 51,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1956, 10, 28, 1, 52, 55, 0, DateTimeKind.Utc), new DateTime(1956, 11, 17, 4, 52, 55, 0, DateTimeKind.Utc), new DateTime(1956, 10, 28, 1, 52, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 52,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1933, 10, 27, 4, 42, 2, 0, DateTimeKind.Utc), new DateTime(1933, 11, 23, 13, 42, 2, 0, DateTimeKind.Utc), new DateTime(1933, 10, 27, 4, 42, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 53,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1969, 8, 13, 5, 18, 27, 0, DateTimeKind.Utc), new DateTime(1969, 9, 10, 6, 18, 27, 0, DateTimeKind.Utc), new DateTime(1969, 8, 13, 5, 18, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 54,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1913, 2, 10, 16, 23, 53, 0, DateTimeKind.Utc), new DateTime(1913, 2, 11, 8, 23, 53, 0, DateTimeKind.Utc), new DateTime(1913, 2, 10, 16, 23, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 55,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1934, 4, 4, 22, 39, 2, 0, DateTimeKind.Utc), new DateTime(1934, 4, 17, 21, 39, 2, 0, DateTimeKind.Utc), new DateTime(1934, 4, 4, 22, 39, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 56,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1922, 11, 24, 0, 37, 20, 0, DateTimeKind.Utc), new DateTime(1922, 12, 16, 5, 37, 20, 0, DateTimeKind.Utc), new DateTime(1922, 11, 24, 0, 37, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 57,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1959, 7, 2, 4, 10, 54, 0, DateTimeKind.Utc), new DateTime(1959, 7, 14, 1, 10, 54, 0, DateTimeKind.Utc), new DateTime(1959, 7, 2, 4, 10, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 58,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1930, 1, 18, 1, 10, 12, 0, DateTimeKind.Utc), new DateTime(1930, 1, 26, 20, 10, 12, 0, DateTimeKind.Utc), new DateTime(1930, 1, 18, 1, 10, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 59,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1996, 1, 12, 10, 52, 17, 0, DateTimeKind.Utc), new DateTime(1996, 1, 18, 1, 52, 17, 0, DateTimeKind.Utc), new DateTime(1996, 1, 12, 10, 52, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 60,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1974, 9, 15, 2, 46, 31, 0, DateTimeKind.Utc), new DateTime(1974, 10, 14, 22, 46, 31, 0, DateTimeKind.Utc), new DateTime(1974, 9, 15, 2, 46, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 61,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(2001, 4, 6, 21, 58, 44, 0, DateTimeKind.Utc), new DateTime(2001, 4, 19, 12, 58, 44, 0, DateTimeKind.Utc), new DateTime(2001, 4, 6, 21, 58, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 62,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1926, 7, 2, 2, 43, 40, 0, DateTimeKind.Utc), new DateTime(1926, 7, 19, 16, 43, 40, 0, DateTimeKind.Utc), new DateTime(1926, 7, 2, 2, 43, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 63,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1950, 11, 27, 10, 26, 22, 0, DateTimeKind.Utc), new DateTime(1950, 12, 23, 14, 26, 22, 0, DateTimeKind.Utc), new DateTime(1950, 11, 27, 10, 26, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 64,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1933, 3, 5, 21, 9, 39, 0, DateTimeKind.Utc), new DateTime(1933, 3, 31, 20, 9, 39, 0, DateTimeKind.Utc), new DateTime(1933, 3, 5, 21, 9, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 65,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1976, 9, 3, 12, 24, 51, 0, DateTimeKind.Utc), new DateTime(1976, 9, 29, 13, 24, 51, 0, DateTimeKind.Utc), new DateTime(1976, 9, 3, 12, 24, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 66,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(2004, 5, 24, 12, 21, 49, 0, DateTimeKind.Utc), new DateTime(2004, 5, 28, 13, 21, 49, 0, DateTimeKind.Utc), new DateTime(2004, 5, 24, 12, 21, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 67,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1987, 5, 1, 21, 49, 37, 0, DateTimeKind.Utc), new DateTime(1987, 5, 25, 0, 49, 37, 0, DateTimeKind.Utc), new DateTime(1987, 5, 1, 21, 49, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 68,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1918, 8, 8, 17, 1, 55, 0, DateTimeKind.Utc), new DateTime(1918, 9, 3, 12, 1, 55, 0, DateTimeKind.Utc), new DateTime(1918, 8, 8, 17, 1, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 69,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1940, 2, 10, 3, 49, 32, 0, DateTimeKind.Utc), new DateTime(1940, 3, 2, 15, 49, 32, 0, DateTimeKind.Utc), new DateTime(1940, 2, 10, 3, 49, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 70,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1944, 10, 6, 13, 16, 13, 0, DateTimeKind.Utc), new DateTime(1944, 10, 20, 1, 16, 13, 0, DateTimeKind.Utc), new DateTime(1944, 10, 6, 13, 16, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 71,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1980, 8, 5, 4, 15, 20, 0, DateTimeKind.Utc), new DateTime(1980, 9, 2, 22, 15, 20, 0, DateTimeKind.Utc), new DateTime(1980, 8, 5, 4, 15, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 72,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(2005, 10, 17, 3, 44, 4, 0, DateTimeKind.Utc), new DateTime(2005, 11, 14, 5, 44, 4, 0, DateTimeKind.Utc), new DateTime(2005, 10, 17, 3, 44, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 73,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1942, 5, 12, 13, 45, 28, 0, DateTimeKind.Utc), new DateTime(1942, 5, 16, 3, 45, 28, 0, DateTimeKind.Utc), new DateTime(1942, 5, 12, 13, 45, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 74,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1945, 10, 21, 3, 12, 14, 0, DateTimeKind.Utc), new DateTime(1945, 11, 2, 19, 12, 14, 0, DateTimeKind.Utc), new DateTime(1945, 10, 21, 3, 12, 14, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 75,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1966, 8, 16, 6, 8, 27, 0, DateTimeKind.Utc), new DateTime(1966, 8, 31, 20, 8, 27, 0, DateTimeKind.Utc), new DateTime(1966, 8, 16, 6, 8, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 76,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1976, 2, 3, 19, 13, 7, 0, DateTimeKind.Utc), new DateTime(1976, 2, 20, 23, 13, 7, 0, DateTimeKind.Utc), new DateTime(1976, 2, 3, 19, 13, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 77,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1956, 11, 12, 22, 53, 7, 0, DateTimeKind.Utc), new DateTime(1956, 12, 9, 3, 53, 7, 0, DateTimeKind.Utc), new DateTime(1956, 11, 12, 22, 53, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 78,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1941, 3, 12, 5, 46, 25, 0, DateTimeKind.Utc), new DateTime(1941, 3, 25, 19, 46, 25, 0, DateTimeKind.Utc), new DateTime(1941, 3, 12, 5, 46, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 79,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1916, 10, 5, 17, 10, 23, 0, DateTimeKind.Utc), new DateTime(1916, 10, 29, 16, 10, 23, 0, DateTimeKind.Utc), new DateTime(1916, 10, 5, 17, 10, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 80,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1962, 6, 14, 22, 38, 33, 0, DateTimeKind.Utc), new DateTime(1962, 6, 18, 4, 38, 33, 0, DateTimeKind.Utc), new DateTime(1962, 6, 14, 22, 38, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 81,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1997, 7, 22, 3, 30, 35, 0, DateTimeKind.Utc), new DateTime(1997, 8, 13, 17, 30, 35, 0, DateTimeKind.Utc), new DateTime(1997, 7, 22, 3, 30, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 82,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(2022, 6, 5, 6, 5, 46, 0, DateTimeKind.Utc), new DateTime(2022, 6, 18, 23, 5, 46, 0, DateTimeKind.Utc), new DateTime(2022, 6, 5, 6, 5, 46, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 83,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1907, 5, 28, 14, 48, 59, 0, DateTimeKind.Utc), new DateTime(1907, 6, 20, 5, 48, 59, 0, DateTimeKind.Utc), new DateTime(1907, 5, 28, 14, 48, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 84,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(2002, 4, 26, 3, 8, 18, 0, DateTimeKind.Utc), new DateTime(2002, 4, 28, 23, 8, 18, 0, DateTimeKind.Utc), new DateTime(2002, 4, 26, 3, 8, 18, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 85,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1936, 10, 28, 16, 17, 43, 0, DateTimeKind.Utc), new DateTime(1936, 11, 22, 1, 17, 43, 0, DateTimeKind.Utc), new DateTime(1936, 10, 28, 16, 17, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 86,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1979, 6, 10, 20, 9, 20, 0, DateTimeKind.Utc), new DateTime(1979, 6, 21, 5, 9, 20, 0, DateTimeKind.Utc), new DateTime(1979, 6, 10, 20, 9, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 87,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1943, 3, 20, 20, 16, 14, 0, DateTimeKind.Utc), new DateTime(1943, 4, 11, 6, 16, 14, 0, DateTimeKind.Utc), new DateTime(1943, 3, 20, 20, 16, 14, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 88,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1930, 10, 21, 9, 38, 44, 0, DateTimeKind.Utc), new DateTime(1930, 11, 2, 11, 38, 44, 0, DateTimeKind.Utc), new DateTime(1930, 10, 21, 9, 38, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 89,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1950, 10, 20, 11, 6, 21, 0, DateTimeKind.Utc), new DateTime(1950, 11, 15, 1, 6, 21, 0, DateTimeKind.Utc), new DateTime(1950, 10, 20, 11, 6, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 90,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1977, 8, 12, 10, 49, 37, 0, DateTimeKind.Utc), new DateTime(1977, 8, 21, 18, 49, 37, 0, DateTimeKind.Utc), new DateTime(1977, 8, 12, 10, 49, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 91,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1975, 4, 7, 10, 37, 33, 0, DateTimeKind.Utc), new DateTime(1975, 5, 6, 19, 37, 33, 0, DateTimeKind.Utc), new DateTime(1975, 4, 7, 10, 37, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 92,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1953, 3, 8, 15, 14, 36, 0, DateTimeKind.Utc), new DateTime(1953, 3, 22, 9, 14, 36, 0, DateTimeKind.Utc), new DateTime(1953, 3, 8, 15, 14, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 93,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1937, 11, 1, 16, 52, 16, 0, DateTimeKind.Utc), new DateTime(1937, 11, 20, 11, 52, 16, 0, DateTimeKind.Utc), new DateTime(1937, 11, 1, 16, 52, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 94,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1970, 11, 7, 5, 17, 23, 0, DateTimeKind.Utc), new DateTime(1970, 11, 20, 1, 17, 23, 0, DateTimeKind.Utc), new DateTime(1970, 11, 7, 5, 17, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 95,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1903, 2, 13, 23, 13, 30, 0, DateTimeKind.Utc), new DateTime(1903, 2, 19, 10, 13, 30, 0, DateTimeKind.Utc), new DateTime(1903, 2, 13, 23, 13, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 96,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(2016, 11, 11, 1, 13, 59, 0, DateTimeKind.Utc), new DateTime(2016, 12, 1, 20, 13, 59, 0, DateTimeKind.Utc), new DateTime(2016, 11, 11, 1, 13, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 97,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 7, 4, 56, 25, 0, DateTimeKind.Utc), new DateTime(2024, 10, 3, 4, 56, 25, 0, DateTimeKind.Utc), new DateTime(2024, 9, 7, 4, 56, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 98,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1958, 9, 19, 1, 11, 7, 0, DateTimeKind.Utc), new DateTime(1958, 10, 2, 14, 11, 7, 0, DateTimeKind.Utc), new DateTime(1958, 9, 19, 1, 11, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 99,
                columns: new[] { "created_at", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1940, 11, 22, 3, 52, 53, 0, DateTimeKind.Utc), new DateTime(1940, 12, 7, 3, 52, 53, 0, DateTimeKind.Utc), new DateTime(1940, 11, 22, 3, 52, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1945, 5, 28, 20, 23, 29, 0, DateTimeKind.Utc), new DateTime(1945, 5, 28, 20, 23, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1913, 6, 28, 18, 42, 19, 0, DateTimeKind.Utc), new DateTime(1913, 6, 28, 18, 42, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1926, 3, 22, 0, 41, 3, 0, DateTimeKind.Utc), new DateTime(1926, 3, 22, 0, 41, 3, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 5, 28, 19, 44, 30, 0, DateTimeKind.Utc), new DateTime(1902, 5, 28, 19, 44, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1990, 11, 27, 7, 38, 17, 0, DateTimeKind.Utc), new DateTime(1990, 11, 27, 7, 38, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1990, 9, 2, 11, 42, 50, 0, DateTimeKind.Utc), new DateTime(1990, 9, 2, 11, 42, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 2, 12, 18, 3, 28, 0, DateTimeKind.Utc), new DateTime(2023, 2, 12, 18, 3, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1952, 8, 2, 8, 51, 57, 0, DateTimeKind.Utc), new DateTime(1952, 8, 2, 8, 51, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1943, 4, 7, 17, 6, 29, 0, DateTimeKind.Utc), new DateTime(1943, 4, 7, 17, 6, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2013, 7, 18, 11, 7, 26, 0, DateTimeKind.Utc), new DateTime(2013, 7, 18, 11, 7, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1965, 9, 24, 17, 2, 54, 0, DateTimeKind.Utc), new DateTime(1965, 9, 24, 17, 2, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1934, 9, 15, 22, 2, 33, 0, DateTimeKind.Utc), new DateTime(1934, 9, 15, 22, 2, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 4, 10, 12, 23, 2, 0, DateTimeKind.Utc), new DateTime(1979, 4, 10, 12, 23, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1953, 5, 3, 0, 56, 20, 0, DateTimeKind.Utc), new DateTime(1953, 5, 3, 0, 56, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1903, 1, 20, 13, 34, 8, 0, DateTimeKind.Utc), new DateTime(1903, 1, 20, 13, 34, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1923, 6, 1, 23, 13, 15, 0, DateTimeKind.Utc), new DateTime(1923, 6, 1, 23, 13, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1980, 8, 19, 3, 3, 6, 0, DateTimeKind.Utc), new DateTime(1980, 8, 19, 3, 3, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1951, 5, 7, 16, 4, 49, 0, DateTimeKind.Utc), new DateTime(1951, 5, 7, 16, 4, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1919, 5, 5, 14, 2, 44, 0, DateTimeKind.Utc), new DateTime(1919, 5, 5, 14, 2, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1939, 6, 25, 11, 40, 1, 0, DateTimeKind.Utc), new DateTime(1939, 6, 25, 11, 40, 1, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1926, 9, 5, 9, 43, 32, 0, DateTimeKind.Utc), new DateTime(1926, 9, 5, 9, 43, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1966, 8, 2, 1, 51, 40, 0, DateTimeKind.Utc), new DateTime(1966, 8, 2, 1, 51, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1944, 4, 10, 23, 35, 30, 0, DateTimeKind.Utc), new DateTime(1944, 4, 10, 23, 35, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 25,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1909, 4, 27, 20, 22, 10, 0, DateTimeKind.Utc), new DateTime(1909, 4, 27, 20, 22, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 26,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 13, 6, 39, 41, 0, DateTimeKind.Utc), new DateTime(2023, 7, 13, 6, 39, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 27,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1947, 2, 2, 15, 56, 18, 0, DateTimeKind.Utc), new DateTime(1947, 2, 2, 15, 56, 18, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 28,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2018, 1, 21, 16, 9, 25, 0, DateTimeKind.Utc), new DateTime(2018, 1, 21, 16, 9, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 29,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1995, 2, 15, 11, 13, 45, 0, DateTimeKind.Utc), new DateTime(1995, 2, 15, 11, 13, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 30,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 4, 27, 8, 23, 19, 0, DateTimeKind.Utc), new DateTime(1950, 4, 27, 8, 23, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 31,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1908, 5, 11, 23, 23, 7, 0, DateTimeKind.Utc), new DateTime(1908, 5, 11, 23, 23, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 32,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1909, 3, 28, 8, 40, 41, 0, DateTimeKind.Utc), new DateTime(1909, 3, 28, 8, 40, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 33,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 8, 10, 0, 2, 33, 0, DateTimeKind.Utc), new DateTime(1979, 8, 10, 0, 2, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 34,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1997, 5, 6, 12, 5, 17, 0, DateTimeKind.Utc), new DateTime(1997, 5, 6, 12, 5, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 35,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1981, 6, 11, 16, 51, 19, 0, DateTimeKind.Utc), new DateTime(1981, 6, 11, 16, 51, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 36,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1992, 1, 23, 17, 34, 34, 0, DateTimeKind.Utc), new DateTime(1992, 1, 23, 17, 34, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 37,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2018, 11, 18, 14, 36, 53, 0, DateTimeKind.Utc), new DateTime(2018, 11, 18, 14, 36, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 38,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1951, 5, 12, 19, 50, 30, 0, DateTimeKind.Utc), new DateTime(1951, 5, 12, 19, 50, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 39,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1951, 5, 9, 9, 34, 59, 0, DateTimeKind.Utc), new DateTime(1951, 5, 9, 9, 34, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 40,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1914, 7, 8, 1, 19, 53, 0, DateTimeKind.Utc), new DateTime(1914, 7, 8, 1, 19, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 41,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1992, 5, 12, 16, 37, 38, 0, DateTimeKind.Utc), new DateTime(1992, 5, 12, 16, 37, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 42,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2013, 11, 5, 18, 4, 4, 0, DateTimeKind.Utc), new DateTime(2013, 11, 5, 18, 4, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 43,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2014, 3, 22, 7, 6, 41, 0, DateTimeKind.Utc), new DateTime(2014, 3, 22, 7, 6, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 44,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2008, 10, 19, 20, 16, 28, 0, DateTimeKind.Utc), new DateTime(2008, 10, 19, 20, 16, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 45,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1901, 4, 13, 19, 34, 0, 0, DateTimeKind.Utc), new DateTime(1901, 4, 13, 19, 34, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 46,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1935, 10, 18, 17, 51, 12, 0, DateTimeKind.Utc), new DateTime(1935, 10, 18, 17, 51, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 47,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1959, 9, 22, 18, 55, 54, 0, DateTimeKind.Utc), new DateTime(1959, 9, 22, 18, 55, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 48,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1944, 8, 10, 5, 28, 23, 0, DateTimeKind.Utc), new DateTime(1944, 8, 10, 5, 28, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 49,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1924, 10, 13, 13, 12, 30, 0, DateTimeKind.Utc), new DateTime(1924, 10, 13, 13, 12, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 50,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1924, 10, 4, 22, 38, 16, 0, DateTimeKind.Utc), new DateTime(1924, 10, 4, 22, 38, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 51,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1921, 2, 10, 3, 28, 11, 0, DateTimeKind.Utc), new DateTime(1921, 2, 10, 3, 28, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 52,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1955, 2, 10, 13, 49, 21, 0, DateTimeKind.Utc), new DateTime(1955, 2, 10, 13, 49, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 53,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2014, 2, 26, 18, 29, 37, 0, DateTimeKind.Utc), new DateTime(2014, 2, 26, 18, 29, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 54,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1916, 9, 25, 1, 35, 45, 0, DateTimeKind.Utc), new DateTime(1916, 9, 25, 1, 35, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 55,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1967, 8, 19, 2, 32, 57, 0, DateTimeKind.Utc), new DateTime(1967, 8, 19, 2, 32, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 56,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1908, 7, 3, 12, 35, 48, 0, DateTimeKind.Utc), new DateTime(1908, 7, 3, 12, 35, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 57,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1968, 3, 5, 3, 45, 18, 0, DateTimeKind.Utc), new DateTime(1968, 3, 5, 3, 45, 18, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 58,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1905, 7, 1, 2, 40, 6, 0, DateTimeKind.Utc), new DateTime(1905, 7, 1, 2, 40, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 59,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1975, 5, 12, 12, 47, 49, 0, DateTimeKind.Utc), new DateTime(1975, 5, 12, 12, 47, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 60,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1948, 2, 15, 14, 35, 45, 0, DateTimeKind.Utc), new DateTime(1948, 2, 15, 14, 35, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 61,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 4, 18, 8, 29, 16, 0, DateTimeKind.Utc), new DateTime(1964, 4, 18, 8, 29, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 62,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1932, 5, 15, 2, 13, 16, 0, DateTimeKind.Utc), new DateTime(1932, 5, 15, 2, 13, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 63,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1956, 1, 2, 13, 1, 57, 0, DateTimeKind.Utc), new DateTime(1956, 1, 2, 13, 1, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 64,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1993, 5, 2, 13, 30, 6, 0, DateTimeKind.Utc), new DateTime(1993, 5, 2, 13, 30, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 65,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1970, 7, 22, 6, 6, 28, 0, DateTimeKind.Utc), new DateTime(1970, 7, 22, 6, 6, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 66,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1933, 11, 18, 9, 36, 24, 0, DateTimeKind.Utc), new DateTime(1933, 11, 18, 9, 36, 24, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 67,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1983, 8, 4, 17, 49, 15, 0, DateTimeKind.Utc), new DateTime(1983, 8, 4, 17, 49, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 68,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1974, 6, 6, 3, 2, 46, 0, DateTimeKind.Utc), new DateTime(1974, 6, 6, 3, 2, 46, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 69,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1995, 10, 3, 13, 50, 8, 0, DateTimeKind.Utc), new DateTime(1995, 10, 3, 13, 50, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 70,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1988, 11, 24, 12, 47, 55, 0, DateTimeKind.Utc), new DateTime(1988, 11, 24, 12, 47, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 71,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 1, 9, 0, 48, 15, 0, DateTimeKind.Utc), new DateTime(1964, 1, 9, 0, 48, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 72,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 1, 12, 15, 54, 19, 0, DateTimeKind.Utc), new DateTime(1979, 1, 12, 15, 54, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 73,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 1, 18, 18, 57, 58, 0, DateTimeKind.Utc), new DateTime(2002, 1, 18, 18, 57, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 74,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2011, 5, 15, 23, 29, 17, 0, DateTimeKind.Utc), new DateTime(2011, 5, 15, 23, 29, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 75,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1948, 8, 4, 11, 41, 38, 0, DateTimeKind.Utc), new DateTime(1948, 8, 4, 11, 41, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 76,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1971, 2, 26, 5, 12, 48, 0, DateTimeKind.Utc), new DateTime(1971, 2, 26, 5, 12, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 77,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 7, 20, 22, 29, 59, 0, DateTimeKind.Utc), new DateTime(2019, 7, 20, 22, 29, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 78,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1945, 2, 26, 18, 45, 48, 0, DateTimeKind.Utc), new DateTime(1945, 2, 26, 18, 45, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 79,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 11, 1, 20, 38, 21, 0, DateTimeKind.Utc), new DateTime(1962, 11, 1, 20, 38, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 80,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1946, 7, 15, 0, 37, 6, 0, DateTimeKind.Utc), new DateTime(1946, 7, 15, 0, 37, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 81,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1914, 2, 10, 18, 4, 45, 0, DateTimeKind.Utc), new DateTime(1914, 2, 10, 18, 4, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 82,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1952, 7, 23, 19, 49, 22, 0, DateTimeKind.Utc), new DateTime(1952, 7, 23, 19, 49, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 83,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1931, 11, 27, 13, 35, 22, 0, DateTimeKind.Utc), new DateTime(1931, 11, 27, 13, 35, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 84,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1945, 8, 27, 7, 58, 45, 0, DateTimeKind.Utc), new DateTime(1945, 8, 27, 7, 58, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 85,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 8, 15, 13, 49, 39, 0, DateTimeKind.Utc), new DateTime(1977, 8, 15, 13, 49, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 86,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1934, 11, 27, 14, 49, 20, 0, DateTimeKind.Utc), new DateTime(1934, 11, 27, 14, 49, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 87,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1978, 7, 2, 3, 19, 8, 0, DateTimeKind.Utc), new DateTime(1978, 7, 2, 3, 19, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 88,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 3, 15, 35, 41, 0, DateTimeKind.Utc), new DateTime(2023, 8, 3, 15, 35, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 89,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1948, 10, 27, 3, 38, 59, 0, DateTimeKind.Utc), new DateTime(1948, 10, 27, 3, 38, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 90,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1917, 9, 5, 14, 8, 20, 0, DateTimeKind.Utc), new DateTime(1917, 9, 5, 14, 8, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 91,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1930, 10, 22, 3, 31, 52, 0, DateTimeKind.Utc), new DateTime(1930, 10, 22, 3, 31, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 92,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1953, 8, 4, 14, 54, 59, 0, DateTimeKind.Utc), new DateTime(1953, 8, 4, 14, 54, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 93,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1939, 3, 9, 19, 19, 17, 0, DateTimeKind.Utc), new DateTime(1939, 3, 9, 19, 19, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 94,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1982, 11, 4, 19, 9, 59, 0, DateTimeKind.Utc), new DateTime(1982, 11, 4, 19, 9, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 95,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1987, 2, 9, 22, 27, 0, 0, DateTimeKind.Utc), new DateTime(1987, 2, 9, 22, 27, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 96,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1919, 1, 14, 16, 54, 26, 0, DateTimeKind.Utc), new DateTime(1919, 1, 14, 16, 54, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 97,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1944, 10, 5, 5, 11, 55, 0, DateTimeKind.Utc), new DateTime(1944, 10, 5, 5, 11, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 98,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1971, 9, 27, 23, 49, 25, 0, DateTimeKind.Utc), new DateTime(1971, 9, 27, 23, 49, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 99,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1984, 4, 14, 21, 55, 8, 0, DateTimeKind.Utc), new DateTime(1984, 4, 14, 21, 55, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 100,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 5, 21, 18, 27, 22, 0, DateTimeKind.Utc), new DateTime(1925, 5, 21, 18, 27, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 101,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1970, 6, 6, 2, 27, 51, 0, DateTimeKind.Utc), new DateTime(1970, 6, 6, 2, 27, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 102,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 7, 9, 20, 26, 29, 0, DateTimeKind.Utc), new DateTime(1962, 7, 9, 20, 26, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 103,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1913, 5, 23, 4, 13, 22, 0, DateTimeKind.Utc), new DateTime(1913, 5, 23, 4, 13, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 104,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1904, 9, 10, 21, 16, 7, 0, DateTimeKind.Utc), new DateTime(1904, 9, 10, 21, 16, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 105,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 4, 4, 8, 28, 27, 0, DateTimeKind.Utc), new DateTime(1964, 4, 4, 8, 28, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 106,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1989, 7, 11, 18, 39, 42, 0, DateTimeKind.Utc), new DateTime(1989, 7, 11, 18, 39, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 107,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1990, 6, 10, 1, 27, 11, 0, DateTimeKind.Utc), new DateTime(1990, 6, 10, 1, 27, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 108,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1912, 9, 26, 23, 45, 29, 0, DateTimeKind.Utc), new DateTime(1912, 9, 26, 23, 45, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 109,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1941, 1, 6, 8, 44, 43, 0, DateTimeKind.Utc), new DateTime(1941, 1, 6, 8, 44, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 110,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1904, 8, 7, 2, 34, 9, 0, DateTimeKind.Utc), new DateTime(1904, 8, 7, 2, 34, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 111,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1992, 2, 5, 20, 8, 52, 0, DateTimeKind.Utc), new DateTime(1992, 2, 5, 20, 8, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 112,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1914, 4, 22, 2, 28, 45, 0, DateTimeKind.Utc), new DateTime(1914, 4, 22, 2, 28, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 113,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1903, 11, 8, 3, 45, 26, 0, DateTimeKind.Utc), new DateTime(1903, 11, 8, 3, 45, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 114,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1926, 6, 15, 14, 59, 28, 0, DateTimeKind.Utc), new DateTime(1926, 6, 15, 14, 59, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 115,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1929, 4, 24, 15, 43, 58, 0, DateTimeKind.Utc), new DateTime(1929, 4, 24, 15, 43, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 116,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1960, 8, 26, 3, 19, 16, 0, DateTimeKind.Utc), new DateTime(1960, 8, 26, 3, 19, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 117,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 3, 19, 0, 51, 24, 0, DateTimeKind.Utc), new DateTime(1902, 3, 19, 0, 51, 24, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 118,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1988, 3, 15, 11, 18, 45, 0, DateTimeKind.Utc), new DateTime(1988, 3, 15, 11, 18, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 119,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1954, 11, 26, 18, 51, 2, 0, DateTimeKind.Utc), new DateTime(1954, 11, 26, 18, 51, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 120,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1978, 2, 6, 16, 36, 47, 0, DateTimeKind.Utc), new DateTime(1978, 2, 6, 16, 36, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 121,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 6, 18, 19, 35, 49, 0, DateTimeKind.Utc), new DateTime(1902, 6, 18, 19, 35, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 122,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 10, 19, 0, 6, 29, 0, DateTimeKind.Utc), new DateTime(2006, 10, 19, 0, 6, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 123,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1996, 3, 20, 2, 54, 44, 0, DateTimeKind.Utc), new DateTime(1996, 3, 20, 2, 54, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 124,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2017, 9, 2, 1, 11, 49, 0, DateTimeKind.Utc), new DateTime(2017, 9, 2, 1, 11, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 125,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1904, 8, 22, 20, 31, 12, 0, DateTimeKind.Utc), new DateTime(1904, 8, 22, 20, 31, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 126,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1910, 4, 19, 21, 59, 21, 0, DateTimeKind.Utc), new DateTime(1910, 4, 19, 21, 59, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 127,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2000, 11, 19, 16, 36, 26, 0, DateTimeKind.Utc), new DateTime(2000, 11, 19, 16, 36, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 128,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1912, 5, 23, 10, 59, 39, 0, DateTimeKind.Utc), new DateTime(1912, 5, 23, 10, 59, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 129,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1943, 6, 7, 10, 43, 49, 0, DateTimeKind.Utc), new DateTime(1943, 6, 7, 10, 43, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 130,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1991, 11, 9, 18, 45, 52, 0, DateTimeKind.Utc), new DateTime(1991, 11, 9, 18, 45, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 131,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1903, 1, 10, 10, 54, 44, 0, DateTimeKind.Utc), new DateTime(1903, 1, 10, 10, 54, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 132,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2004, 10, 7, 7, 18, 59, 0, DateTimeKind.Utc), new DateTime(2004, 10, 7, 7, 18, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 133,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1906, 3, 6, 14, 57, 45, 0, DateTimeKind.Utc), new DateTime(1906, 3, 6, 14, 57, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 134,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1900, 7, 21, 2, 29, 1, 0, DateTimeKind.Utc), new DateTime(1900, 7, 21, 2, 29, 1, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 135,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 18, 20, 9, 1, 0, DateTimeKind.Utc), new DateTime(2023, 8, 18, 20, 9, 1, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 136,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1905, 1, 5, 19, 39, 35, 0, DateTimeKind.Utc), new DateTime(1905, 1, 5, 19, 39, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 137,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1909, 8, 15, 1, 35, 6, 0, DateTimeKind.Utc), new DateTime(1909, 8, 15, 1, 35, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 138,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1954, 1, 6, 5, 22, 29, 0, DateTimeKind.Utc), new DateTime(1954, 1, 6, 5, 22, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 139,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1978, 2, 1, 13, 46, 7, 0, DateTimeKind.Utc), new DateTime(1978, 2, 1, 13, 46, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 140,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1916, 11, 15, 7, 27, 15, 0, DateTimeKind.Utc), new DateTime(1916, 11, 15, 7, 27, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 141,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1912, 11, 21, 4, 16, 17, 0, DateTimeKind.Utc), new DateTime(1912, 11, 21, 4, 16, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 142,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2004, 4, 17, 14, 31, 16, 0, DateTimeKind.Utc), new DateTime(2004, 4, 17, 14, 31, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 143,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 11, 2, 14, 40, 27, 0, DateTimeKind.Utc), new DateTime(1925, 11, 2, 14, 40, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 144,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2001, 9, 8, 3, 12, 1, 0, DateTimeKind.Utc), new DateTime(2001, 9, 8, 3, 12, 1, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 145,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1899, 6, 7, 0, 38, 43, 0, DateTimeKind.Utc), new DateTime(1899, 6, 7, 0, 38, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 146,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1909, 9, 7, 6, 56, 35, 0, DateTimeKind.Utc), new DateTime(1909, 9, 7, 6, 56, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 147,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1945, 3, 22, 21, 23, 6, 0, DateTimeKind.Utc), new DateTime(1945, 3, 22, 21, 23, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 148,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2011, 1, 17, 17, 20, 48, 0, DateTimeKind.Utc), new DateTime(2011, 1, 17, 17, 20, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 149,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1910, 6, 7, 1, 30, 41, 0, DateTimeKind.Utc), new DateTime(1910, 6, 7, 1, 30, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 150,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 11, 23, 16, 11, 45, 0, DateTimeKind.Utc), new DateTime(2022, 11, 23, 16, 11, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 151,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1905, 9, 18, 20, 29, 45, 0, DateTimeKind.Utc), new DateTime(1905, 9, 18, 20, 29, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 152,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1905, 11, 1, 10, 14, 26, 0, DateTimeKind.Utc), new DateTime(1905, 11, 1, 10, 14, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 153,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1986, 10, 11, 4, 15, 9, 0, DateTimeKind.Utc), new DateTime(1986, 10, 11, 4, 15, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 154,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1953, 4, 5, 10, 55, 6, 0, DateTimeKind.Utc), new DateTime(1953, 4, 5, 10, 55, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 155,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1960, 1, 7, 12, 17, 59, 0, DateTimeKind.Utc), new DateTime(1960, 1, 7, 12, 17, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 156,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1999, 8, 2, 0, 50, 34, 0, DateTimeKind.Utc), new DateTime(1999, 8, 2, 0, 50, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 157,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1957, 1, 16, 19, 40, 23, 0, DateTimeKind.Utc), new DateTime(1957, 1, 16, 19, 40, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 158,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1999, 8, 9, 19, 21, 36, 0, DateTimeKind.Utc), new DateTime(1999, 8, 9, 19, 21, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 159,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1938, 9, 20, 15, 15, 54, 0, DateTimeKind.Utc), new DateTime(1938, 9, 20, 15, 15, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 160,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1973, 7, 25, 12, 22, 26, 0, DateTimeKind.Utc), new DateTime(1973, 7, 25, 12, 22, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 161,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 6, 18, 0, 38, 33, 0, DateTimeKind.Utc), new DateTime(1964, 6, 18, 0, 38, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 162,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1946, 8, 2, 19, 41, 13, 0, DateTimeKind.Utc), new DateTime(1946, 8, 2, 19, 41, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 163,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1974, 7, 18, 18, 37, 16, 0, DateTimeKind.Utc), new DateTime(1974, 7, 18, 18, 37, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 164,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2003, 8, 20, 15, 12, 29, 0, DateTimeKind.Utc), new DateTime(2003, 8, 20, 15, 12, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 165,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1933, 2, 12, 3, 24, 12, 0, DateTimeKind.Utc), new DateTime(1933, 2, 12, 3, 24, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 166,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1985, 11, 19, 2, 18, 8, 0, DateTimeKind.Utc), new DateTime(1985, 11, 19, 2, 18, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 167,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1994, 9, 1, 17, 25, 39, 0, DateTimeKind.Utc), new DateTime(1994, 9, 1, 17, 25, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 168,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1966, 6, 4, 11, 1, 39, 0, DateTimeKind.Utc), new DateTime(1966, 6, 4, 11, 1, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 169,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1934, 10, 1, 14, 41, 40, 0, DateTimeKind.Utc), new DateTime(1934, 10, 1, 14, 41, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 170,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1992, 10, 10, 3, 44, 28, 0, DateTimeKind.Utc), new DateTime(1992, 10, 10, 3, 44, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 171,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1917, 3, 8, 20, 6, 44, 0, DateTimeKind.Utc), new DateTime(1917, 3, 8, 20, 6, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 172,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1967, 6, 9, 11, 0, 50, 0, DateTimeKind.Utc), new DateTime(1967, 6, 9, 11, 0, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 173,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1931, 2, 8, 0, 5, 40, 0, DateTimeKind.Utc), new DateTime(1931, 2, 8, 0, 5, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 174,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1945, 9, 5, 17, 51, 35, 0, DateTimeKind.Utc), new DateTime(1945, 9, 5, 17, 51, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 175,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1923, 1, 8, 23, 21, 25, 0, DateTimeKind.Utc), new DateTime(1923, 1, 8, 23, 21, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 176,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2000, 7, 1, 12, 33, 11, 0, DateTimeKind.Utc), new DateTime(2000, 7, 1, 12, 33, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 177,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1946, 8, 12, 8, 56, 31, 0, DateTimeKind.Utc), new DateTime(1946, 8, 12, 8, 56, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 178,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1944, 9, 23, 3, 20, 34, 0, DateTimeKind.Utc), new DateTime(1944, 9, 23, 3, 20, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 179,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1951, 8, 23, 15, 46, 57, 0, DateTimeKind.Utc), new DateTime(1951, 8, 23, 15, 46, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 180,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1939, 5, 11, 16, 39, 2, 0, DateTimeKind.Utc), new DateTime(1939, 5, 11, 16, 39, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 181,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1957, 7, 4, 20, 40, 23, 0, DateTimeKind.Utc), new DateTime(1957, 7, 4, 20, 40, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 182,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2001, 9, 16, 1, 39, 24, 0, DateTimeKind.Utc), new DateTime(2001, 9, 16, 1, 39, 24, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 183,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1932, 1, 24, 14, 22, 3, 0, DateTimeKind.Utc), new DateTime(1932, 1, 24, 14, 22, 3, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 184,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1997, 1, 21, 16, 34, 38, 0, DateTimeKind.Utc), new DateTime(1997, 1, 21, 16, 34, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 185,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 2, 24, 1, 12, 9, 0, DateTimeKind.Utc), new DateTime(1977, 2, 24, 1, 12, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 186,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2003, 8, 2, 8, 53, 22, 0, DateTimeKind.Utc), new DateTime(2003, 8, 2, 8, 53, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 187,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1947, 6, 4, 9, 20, 36, 0, DateTimeKind.Utc), new DateTime(1947, 6, 4, 9, 20, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 188,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1903, 4, 2, 9, 22, 46, 0, DateTimeKind.Utc), new DateTime(1903, 4, 2, 9, 22, 46, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 189,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1910, 8, 1, 7, 54, 36, 0, DateTimeKind.Utc), new DateTime(1910, 8, 1, 7, 54, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 190,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1936, 9, 28, 11, 14, 30, 0, DateTimeKind.Utc), new DateTime(1936, 9, 28, 11, 14, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 191,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1969, 9, 15, 9, 13, 57, 0, DateTimeKind.Utc), new DateTime(1969, 9, 15, 9, 13, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 192,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1943, 10, 4, 11, 13, 53, 0, DateTimeKind.Utc), new DateTime(1943, 10, 4, 11, 13, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 193,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2015, 5, 20, 2, 39, 13, 0, DateTimeKind.Utc), new DateTime(2015, 5, 20, 2, 39, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 194,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1973, 3, 23, 1, 58, 29, 0, DateTimeKind.Utc), new DateTime(1973, 3, 23, 1, 58, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 195,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1914, 6, 22, 10, 4, 6, 0, DateTimeKind.Utc), new DateTime(1914, 6, 22, 10, 4, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 196,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1946, 10, 8, 15, 51, 36, 0, DateTimeKind.Utc), new DateTime(1946, 10, 8, 15, 51, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 197,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1908, 8, 4, 2, 1, 28, 0, DateTimeKind.Utc), new DateTime(1908, 8, 4, 2, 1, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 198,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1982, 7, 14, 3, 22, 32, 0, DateTimeKind.Utc), new DateTime(1982, 7, 14, 3, 22, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 199,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2014, 3, 4, 18, 53, 0, 0, DateTimeKind.Utc), new DateTime(2014, 3, 4, 18, 53, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 200,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1988, 6, 22, 0, 15, 42, 0, DateTimeKind.Utc), new DateTime(1988, 6, 22, 0, 15, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 201,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1920, 11, 24, 23, 5, 18, 0, DateTimeKind.Utc), new DateTime(1920, 11, 24, 23, 5, 18, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 202,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1978, 4, 15, 2, 2, 59, 0, DateTimeKind.Utc), new DateTime(1978, 4, 15, 2, 2, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 203,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1910, 6, 6, 7, 24, 21, 0, DateTimeKind.Utc), new DateTime(1910, 6, 6, 7, 24, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 204,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 11, 5, 5, 30, 53, 0, DateTimeKind.Utc), new DateTime(2024, 11, 5, 5, 30, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 205,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 1, 5, 55, 21, 0, DateTimeKind.Utc), new DateTime(2023, 7, 1, 5, 55, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 206,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2004, 1, 12, 9, 54, 5, 0, DateTimeKind.Utc), new DateTime(2004, 1, 12, 9, 54, 5, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 207,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 8, 15, 4, 30, 4, 0, DateTimeKind.Utc), new DateTime(1979, 8, 15, 4, 30, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 208,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1901, 10, 5, 3, 40, 23, 0, DateTimeKind.Utc), new DateTime(1901, 10, 5, 3, 40, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 209,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1999, 5, 3, 9, 2, 16, 0, DateTimeKind.Utc), new DateTime(1999, 5, 3, 9, 2, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 210,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1968, 11, 12, 22, 0, 29, 0, DateTimeKind.Utc), new DateTime(1968, 11, 12, 22, 0, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 211,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1935, 5, 11, 3, 14, 59, 0, DateTimeKind.Utc), new DateTime(1935, 5, 11, 3, 14, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 212,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1973, 8, 17, 2, 40, 44, 0, DateTimeKind.Utc), new DateTime(1973, 8, 17, 2, 40, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 213,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2003, 9, 14, 1, 13, 40, 0, DateTimeKind.Utc), new DateTime(2003, 9, 14, 1, 13, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 214,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1991, 10, 27, 15, 26, 31, 0, DateTimeKind.Utc), new DateTime(1991, 10, 27, 15, 26, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 215,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1931, 5, 1, 3, 51, 58, 0, DateTimeKind.Utc), new DateTime(1931, 5, 1, 3, 51, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 216,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1983, 8, 19, 0, 53, 7, 0, DateTimeKind.Utc), new DateTime(1983, 8, 19, 0, 53, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 217,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1987, 10, 17, 3, 32, 59, 0, DateTimeKind.Utc), new DateTime(1987, 10, 17, 3, 32, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 218,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1998, 8, 20, 8, 34, 13, 0, DateTimeKind.Utc), new DateTime(1998, 8, 20, 8, 34, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 219,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1998, 6, 20, 18, 12, 9, 0, DateTimeKind.Utc), new DateTime(1998, 6, 20, 18, 12, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 220,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1969, 8, 27, 20, 53, 48, 0, DateTimeKind.Utc), new DateTime(1969, 8, 27, 20, 53, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 221,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2021, 6, 23, 14, 26, 58, 0, DateTimeKind.Utc), new DateTime(2021, 6, 23, 14, 26, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 222,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1906, 9, 26, 8, 21, 21, 0, DateTimeKind.Utc), new DateTime(1906, 9, 26, 8, 21, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 223,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1907, 7, 9, 22, 50, 45, 0, DateTimeKind.Utc), new DateTime(1907, 7, 9, 22, 50, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 224,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 11, 24, 18, 20, 22, 0, DateTimeKind.Utc), new DateTime(2002, 11, 24, 18, 20, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 225,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1932, 11, 14, 12, 28, 13, 0, DateTimeKind.Utc), new DateTime(1932, 11, 14, 12, 28, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 226,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1922, 10, 28, 18, 11, 5, 0, DateTimeKind.Utc), new DateTime(1922, 10, 28, 18, 11, 5, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 227,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1919, 3, 8, 17, 17, 46, 0, DateTimeKind.Utc), new DateTime(1919, 3, 8, 17, 17, 46, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 228,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1935, 5, 4, 8, 40, 38, 0, DateTimeKind.Utc), new DateTime(1935, 5, 4, 8, 40, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 229,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 7, 24, 4, 1, 58, 0, DateTimeKind.Utc), new DateTime(2006, 7, 24, 4, 1, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 230,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 3, 4, 10, 20, 31, 0, DateTimeKind.Utc), new DateTime(2019, 3, 4, 10, 20, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 231,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1960, 7, 10, 16, 9, 30, 0, DateTimeKind.Utc), new DateTime(1960, 7, 10, 16, 9, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 232,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1946, 4, 11, 5, 45, 39, 0, DateTimeKind.Utc), new DateTime(1946, 4, 11, 5, 45, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 233,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1960, 2, 18, 1, 29, 53, 0, DateTimeKind.Utc), new DateTime(1960, 2, 18, 1, 29, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 234,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1929, 10, 7, 20, 39, 50, 0, DateTimeKind.Utc), new DateTime(1929, 10, 7, 20, 39, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 235,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1947, 1, 24, 23, 49, 59, 0, DateTimeKind.Utc), new DateTime(1947, 1, 24, 23, 49, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 236,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2021, 8, 24, 17, 14, 43, 0, DateTimeKind.Utc), new DateTime(2021, 8, 24, 17, 14, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 237,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1953, 7, 9, 14, 58, 23, 0, DateTimeKind.Utc), new DateTime(1953, 7, 9, 14, 58, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 238,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1930, 8, 25, 4, 41, 55, 0, DateTimeKind.Utc), new DateTime(1930, 8, 25, 4, 41, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 239,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1942, 10, 20, 5, 12, 26, 0, DateTimeKind.Utc), new DateTime(1942, 10, 20, 5, 12, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 240,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1934, 8, 26, 11, 18, 8, 0, DateTimeKind.Utc), new DateTime(1934, 8, 26, 11, 18, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 241,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1983, 5, 13, 9, 14, 2, 0, DateTimeKind.Utc), new DateTime(1983, 5, 13, 9, 14, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 242,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2000, 9, 25, 21, 38, 53, 0, DateTimeKind.Utc), new DateTime(2000, 9, 25, 21, 38, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 243,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1973, 7, 27, 20, 35, 1, 0, DateTimeKind.Utc), new DateTime(1973, 7, 27, 20, 35, 1, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 244,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 3, 9, 21, 38, 57, 0, DateTimeKind.Utc), new DateTime(2023, 3, 9, 21, 38, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 245,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1934, 9, 15, 9, 27, 35, 0, DateTimeKind.Utc), new DateTime(1934, 9, 15, 9, 27, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 246,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2001, 11, 8, 3, 56, 35, 0, DateTimeKind.Utc), new DateTime(2001, 11, 8, 3, 56, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 247,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2016, 10, 12, 19, 22, 55, 0, DateTimeKind.Utc), new DateTime(2016, 10, 12, 19, 22, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 248,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1905, 5, 7, 19, 37, 34, 0, DateTimeKind.Utc), new DateTime(1905, 5, 7, 19, 37, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 249,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1961, 5, 2, 21, 29, 5, 0, DateTimeKind.Utc), new DateTime(1961, 5, 2, 21, 29, 5, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 250,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2003, 9, 22, 12, 5, 29, 0, DateTimeKind.Utc), new DateTime(2003, 9, 22, 12, 5, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 251,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1963, 5, 9, 6, 5, 41, 0, DateTimeKind.Utc), new DateTime(1963, 5, 9, 6, 5, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 252,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1976, 5, 19, 8, 54, 43, 0, DateTimeKind.Utc), new DateTime(1976, 5, 19, 8, 54, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 253,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1976, 2, 24, 9, 51, 11, 0, DateTimeKind.Utc), new DateTime(1976, 2, 24, 9, 51, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 254,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1990, 6, 4, 22, 54, 0, 0, DateTimeKind.Utc), new DateTime(1990, 6, 4, 22, 54, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 255,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1968, 11, 13, 4, 18, 11, 0, DateTimeKind.Utc), new DateTime(1968, 11, 13, 4, 18, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 256,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2003, 5, 22, 21, 17, 58, 0, DateTimeKind.Utc), new DateTime(2003, 5, 22, 21, 17, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 257,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 9, 10, 12, 11, 11, 0, DateTimeKind.Utc), new DateTime(1977, 9, 10, 12, 11, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 258,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2012, 2, 15, 7, 16, 19, 0, DateTimeKind.Utc), new DateTime(2012, 2, 15, 7, 16, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 259,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1929, 5, 26, 13, 46, 36, 0, DateTimeKind.Utc), new DateTime(1929, 5, 26, 13, 46, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 260,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1945, 7, 14, 7, 42, 10, 0, DateTimeKind.Utc), new DateTime(1945, 7, 14, 7, 42, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 261,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1927, 5, 4, 11, 31, 28, 0, DateTimeKind.Utc), new DateTime(1927, 5, 4, 11, 31, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 262,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 8, 25, 21, 45, 4, 0, DateTimeKind.Utc), new DateTime(2019, 8, 25, 21, 45, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 263,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2004, 3, 9, 22, 2, 45, 0, DateTimeKind.Utc), new DateTime(2004, 3, 9, 22, 2, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 264,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1959, 3, 19, 3, 55, 51, 0, DateTimeKind.Utc), new DateTime(1959, 3, 19, 3, 55, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 265,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1934, 3, 19, 3, 31, 43, 0, DateTimeKind.Utc), new DateTime(1934, 3, 19, 3, 31, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 266,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1958, 4, 3, 4, 18, 44, 0, DateTimeKind.Utc), new DateTime(1958, 4, 3, 4, 18, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 267,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1905, 5, 18, 1, 21, 32, 0, DateTimeKind.Utc), new DateTime(1905, 5, 18, 1, 21, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 268,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1954, 5, 20, 19, 44, 34, 0, DateTimeKind.Utc), new DateTime(1954, 5, 20, 19, 44, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 269,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1938, 5, 15, 17, 48, 28, 0, DateTimeKind.Utc), new DateTime(1938, 5, 15, 17, 48, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 270,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1963, 1, 15, 6, 11, 15, 0, DateTimeKind.Utc), new DateTime(1963, 1, 15, 6, 11, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 271,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 9, 6, 3, 24, 25, 0, DateTimeKind.Utc), new DateTime(2002, 9, 6, 3, 24, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 272,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 8, 25, 13, 52, 37, 0, DateTimeKind.Utc), new DateTime(2024, 8, 25, 13, 52, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 273,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1912, 5, 25, 2, 41, 33, 0, DateTimeKind.Utc), new DateTime(1912, 5, 25, 2, 41, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 274,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1919, 6, 15, 2, 50, 4, 0, DateTimeKind.Utc), new DateTime(1919, 6, 15, 2, 50, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 275,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1921, 9, 15, 14, 40, 13, 0, DateTimeKind.Utc), new DateTime(1921, 9, 15, 14, 40, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 276,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1926, 9, 7, 9, 13, 34, 0, DateTimeKind.Utc), new DateTime(1926, 9, 7, 9, 13, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 277,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1943, 4, 28, 6, 50, 5, 0, DateTimeKind.Utc), new DateTime(1943, 4, 28, 6, 50, 5, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 278,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1985, 9, 17, 21, 37, 22, 0, DateTimeKind.Utc), new DateTime(1985, 9, 17, 21, 37, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 279,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1974, 5, 12, 23, 5, 44, 0, DateTimeKind.Utc), new DateTime(1974, 5, 12, 23, 5, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 280,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1991, 9, 27, 2, 58, 39, 0, DateTimeKind.Utc), new DateTime(1991, 9, 27, 2, 58, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 281,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2012, 5, 28, 16, 19, 4, 0, DateTimeKind.Utc), new DateTime(2012, 5, 28, 16, 19, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 282,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1949, 9, 6, 7, 45, 24, 0, DateTimeKind.Utc), new DateTime(1949, 9, 6, 7, 45, 24, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 283,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1971, 10, 18, 10, 23, 4, 0, DateTimeKind.Utc), new DateTime(1971, 10, 18, 10, 23, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 284,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 4, 4, 3, 59, 16, 0, DateTimeKind.Utc), new DateTime(1962, 4, 4, 3, 59, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 285,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 3, 20, 11, 38, 29, 0, DateTimeKind.Utc), new DateTime(2002, 3, 20, 11, 38, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 286,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1975, 3, 10, 7, 22, 26, 0, DateTimeKind.Utc), new DateTime(1975, 3, 10, 7, 22, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 287,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1911, 1, 13, 11, 30, 53, 0, DateTimeKind.Utc), new DateTime(1911, 1, 13, 11, 30, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 288,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1919, 4, 19, 23, 23, 12, 0, DateTimeKind.Utc), new DateTime(1919, 4, 19, 23, 23, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 289,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1913, 4, 10, 21, 36, 41, 0, DateTimeKind.Utc), new DateTime(1913, 4, 10, 21, 36, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 290,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1968, 9, 12, 17, 50, 4, 0, DateTimeKind.Utc), new DateTime(1968, 9, 12, 17, 50, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 291,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1946, 11, 3, 17, 41, 30, 0, DateTimeKind.Utc), new DateTime(1946, 11, 3, 17, 41, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 292,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1908, 4, 15, 4, 20, 22, 0, DateTimeKind.Utc), new DateTime(1908, 4, 15, 4, 20, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 293,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 1, 22, 5, 58, 42, 0, DateTimeKind.Utc), new DateTime(1977, 1, 22, 5, 58, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 294,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1976, 10, 25, 11, 21, 21, 0, DateTimeKind.Utc), new DateTime(1976, 10, 25, 11, 21, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 295,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1917, 8, 18, 15, 44, 37, 0, DateTimeKind.Utc), new DateTime(1917, 8, 18, 15, 44, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 296,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1904, 5, 5, 8, 6, 34, 0, DateTimeKind.Utc), new DateTime(1904, 5, 5, 8, 6, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 297,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1998, 5, 17, 3, 54, 6, 0, DateTimeKind.Utc), new DateTime(1998, 5, 17, 3, 54, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 298,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1986, 11, 27, 23, 15, 35, 0, DateTimeKind.Utc), new DateTime(1986, 11, 27, 23, 15, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 299,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2013, 4, 22, 16, 5, 0, 0, DateTimeKind.Utc), new DateTime(2013, 4, 22, 16, 5, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 300,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1924, 10, 17, 17, 33, 58, 0, DateTimeKind.Utc), new DateTime(1924, 10, 17, 17, 33, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 301,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2008, 5, 15, 21, 7, 56, 0, DateTimeKind.Utc), new DateTime(2008, 5, 15, 21, 7, 56, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 302,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1923, 3, 26, 5, 25, 31, 0, DateTimeKind.Utc), new DateTime(1923, 3, 26, 5, 25, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 303,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1912, 6, 26, 18, 47, 23, 0, DateTimeKind.Utc), new DateTime(1912, 6, 26, 18, 47, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 304,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1948, 3, 14, 1, 43, 24, 0, DateTimeKind.Utc), new DateTime(1948, 3, 14, 1, 43, 24, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 305,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 4, 9, 3, 9, 12, 0, DateTimeKind.Utc), new DateTime(2006, 4, 9, 3, 9, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 306,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 1, 25, 14, 16, 27, 0, DateTimeKind.Utc), new DateTime(2023, 1, 25, 14, 16, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 307,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1971, 9, 24, 0, 45, 59, 0, DateTimeKind.Utc), new DateTime(1971, 9, 24, 0, 45, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 308,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1986, 8, 26, 5, 34, 37, 0, DateTimeKind.Utc), new DateTime(1986, 8, 26, 5, 34, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 309,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1909, 6, 3, 4, 20, 22, 0, DateTimeKind.Utc), new DateTime(1909, 6, 3, 4, 20, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 310,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 10, 21, 2, 2, 45, 0, DateTimeKind.Utc), new DateTime(1962, 10, 21, 2, 2, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 311,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 1, 4, 16, 13, 22, 0, DateTimeKind.Utc), new DateTime(1979, 1, 4, 16, 13, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 312,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1978, 6, 6, 10, 10, 59, 0, DateTimeKind.Utc), new DateTime(1978, 6, 6, 10, 10, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 313,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1969, 5, 13, 11, 20, 1, 0, DateTimeKind.Utc), new DateTime(1969, 5, 13, 11, 20, 1, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 314,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 7, 23, 16, 3, 41, 0, DateTimeKind.Utc), new DateTime(1962, 7, 23, 16, 3, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 315,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1911, 9, 20, 12, 6, 26, 0, DateTimeKind.Utc), new DateTime(1911, 9, 20, 12, 6, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 316,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1992, 6, 22, 1, 22, 43, 0, DateTimeKind.Utc), new DateTime(1992, 6, 22, 1, 22, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 317,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2010, 1, 14, 12, 36, 4, 0, DateTimeKind.Utc), new DateTime(2010, 1, 14, 12, 36, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 318,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1953, 8, 8, 2, 36, 57, 0, DateTimeKind.Utc), new DateTime(1953, 8, 8, 2, 36, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 319,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2017, 1, 14, 16, 36, 25, 0, DateTimeKind.Utc), new DateTime(2017, 1, 14, 16, 36, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 320,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2020, 11, 28, 9, 34, 24, 0, DateTimeKind.Utc), new DateTime(2020, 11, 28, 9, 34, 24, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 321,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1984, 2, 11, 17, 42, 42, 0, DateTimeKind.Utc), new DateTime(1984, 2, 11, 17, 42, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 322,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 6, 1, 17, 34, 19, 0, DateTimeKind.Utc), new DateTime(1925, 6, 1, 17, 34, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 323,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1965, 11, 28, 17, 14, 25, 0, DateTimeKind.Utc), new DateTime(1965, 11, 28, 17, 14, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 324,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1951, 11, 6, 17, 35, 4, 0, DateTimeKind.Utc), new DateTime(1951, 11, 6, 17, 35, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 325,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2020, 1, 24, 8, 6, 23, 0, DateTimeKind.Utc), new DateTime(2020, 1, 24, 8, 6, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 326,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1992, 6, 13, 1, 50, 29, 0, DateTimeKind.Utc), new DateTime(1992, 6, 13, 1, 50, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 327,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1985, 8, 26, 13, 54, 7, 0, DateTimeKind.Utc), new DateTime(1985, 8, 26, 13, 54, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 328,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2018, 3, 13, 3, 10, 36, 0, DateTimeKind.Utc), new DateTime(2018, 3, 13, 3, 10, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 329,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1952, 3, 21, 13, 59, 35, 0, DateTimeKind.Utc), new DateTime(1952, 3, 21, 13, 59, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 330,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 11, 15, 7, 46, 40, 0, DateTimeKind.Utc), new DateTime(1925, 11, 15, 7, 46, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 331,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 10, 11, 14, 58, 6, 0, DateTimeKind.Utc), new DateTime(2006, 10, 11, 14, 58, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 332,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2009, 6, 5, 12, 1, 32, 0, DateTimeKind.Utc), new DateTime(2009, 6, 5, 12, 1, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 333,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1961, 10, 3, 1, 47, 21, 0, DateTimeKind.Utc), new DateTime(1961, 10, 3, 1, 47, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 334,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1974, 9, 25, 5, 54, 51, 0, DateTimeKind.Utc), new DateTime(1974, 9, 25, 5, 54, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 335,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1981, 3, 14, 20, 51, 53, 0, DateTimeKind.Utc), new DateTime(1981, 3, 14, 20, 51, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 336,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2020, 5, 26, 5, 42, 1, 0, DateTimeKind.Utc), new DateTime(2020, 5, 26, 5, 42, 1, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 337,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1991, 4, 8, 8, 16, 42, 0, DateTimeKind.Utc), new DateTime(1991, 4, 8, 8, 16, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 338,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1956, 11, 7, 4, 3, 8, 0, DateTimeKind.Utc), new DateTime(1956, 11, 7, 4, 3, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 339,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1961, 2, 5, 4, 42, 58, 0, DateTimeKind.Utc), new DateTime(1961, 2, 5, 4, 42, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 340,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2001, 7, 28, 12, 58, 47, 0, DateTimeKind.Utc), new DateTime(2001, 7, 28, 12, 58, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 341,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1976, 1, 17, 6, 32, 39, 0, DateTimeKind.Utc), new DateTime(1976, 1, 17, 6, 32, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 342,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 3, 5, 1, 20, 28, 0, DateTimeKind.Utc), new DateTime(1977, 3, 5, 1, 20, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 343,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1911, 3, 15, 3, 46, 58, 0, DateTimeKind.Utc), new DateTime(1911, 3, 15, 3, 46, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 344,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 6, 4, 8, 21, 43, 0, DateTimeKind.Utc), new DateTime(1977, 6, 4, 8, 21, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 345,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1992, 9, 19, 22, 26, 5, 0, DateTimeKind.Utc), new DateTime(1992, 9, 19, 22, 26, 5, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 346,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1903, 3, 10, 11, 44, 15, 0, DateTimeKind.Utc), new DateTime(1903, 3, 10, 11, 44, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 347,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1912, 3, 11, 13, 34, 48, 0, DateTimeKind.Utc), new DateTime(1912, 3, 11, 13, 34, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 348,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 5, 23, 16, 3, 28, 0, DateTimeKind.Utc), new DateTime(2024, 5, 23, 16, 3, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 349,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1955, 8, 24, 23, 54, 30, 0, DateTimeKind.Utc), new DateTime(1955, 8, 24, 23, 54, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 350,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1980, 4, 19, 21, 31, 45, 0, DateTimeKind.Utc), new DateTime(1980, 4, 19, 21, 31, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 351,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 8, 23, 1, 1, 7, 0, DateTimeKind.Utc), new DateTime(2024, 8, 23, 1, 1, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 352,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1912, 8, 15, 6, 2, 34, 0, DateTimeKind.Utc), new DateTime(1912, 8, 15, 6, 2, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 353,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1973, 1, 25, 7, 20, 55, 0, DateTimeKind.Utc), new DateTime(1973, 1, 25, 7, 20, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 354,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2013, 1, 21, 4, 29, 46, 0, DateTimeKind.Utc), new DateTime(2013, 1, 21, 4, 29, 46, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 355,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1929, 1, 9, 20, 49, 27, 0, DateTimeKind.Utc), new DateTime(1929, 1, 9, 20, 49, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 356,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1972, 3, 20, 15, 34, 53, 0, DateTimeKind.Utc), new DateTime(1972, 3, 20, 15, 34, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 357,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 11, 12, 16, 34, 25, 0, DateTimeKind.Utc), new DateTime(2023, 11, 12, 16, 34, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 358,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2021, 3, 18, 6, 23, 51, 0, DateTimeKind.Utc), new DateTime(2021, 3, 18, 6, 23, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 359,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 4, 27, 17, 58, 27, 0, DateTimeKind.Utc), new DateTime(1977, 4, 27, 17, 58, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 360,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1901, 9, 6, 0, 48, 58, 0, DateTimeKind.Utc), new DateTime(1901, 9, 6, 0, 48, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 361,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2004, 3, 23, 0, 40, 49, 0, DateTimeKind.Utc), new DateTime(2004, 3, 23, 0, 40, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 362,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2010, 11, 14, 23, 20, 23, 0, DateTimeKind.Utc), new DateTime(2010, 11, 14, 23, 20, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 363,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 3, 14, 7, 12, 18, 0, DateTimeKind.Utc), new DateTime(1964, 3, 14, 7, 12, 18, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 364,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1919, 11, 19, 10, 13, 29, 0, DateTimeKind.Utc), new DateTime(1919, 11, 19, 10, 13, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 365,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 10, 8, 5, 36, 45, 0, DateTimeKind.Utc), new DateTime(1964, 10, 8, 5, 36, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 366,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1985, 11, 5, 10, 50, 18, 0, DateTimeKind.Utc), new DateTime(1985, 11, 5, 10, 50, 18, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 367,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1975, 11, 15, 19, 22, 25, 0, DateTimeKind.Utc), new DateTime(1975, 11, 15, 19, 22, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 368,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1947, 7, 28, 13, 13, 44, 0, DateTimeKind.Utc), new DateTime(1947, 7, 28, 13, 13, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 369,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2021, 9, 17, 21, 51, 48, 0, DateTimeKind.Utc), new DateTime(2021, 9, 17, 21, 51, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 370,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1940, 5, 2, 7, 31, 49, 0, DateTimeKind.Utc), new DateTime(1940, 5, 2, 7, 31, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 371,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1969, 8, 11, 17, 18, 23, 0, DateTimeKind.Utc), new DateTime(1969, 8, 11, 17, 18, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 372,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1929, 2, 12, 4, 41, 17, 0, DateTimeKind.Utc), new DateTime(1929, 2, 12, 4, 41, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 373,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1998, 5, 17, 5, 2, 35, 0, DateTimeKind.Utc), new DateTime(1998, 5, 17, 5, 2, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 374,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 11, 18, 12, 15, 52, 0, DateTimeKind.Utc), new DateTime(1964, 11, 18, 12, 15, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 375,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1917, 9, 3, 7, 5, 26, 0, DateTimeKind.Utc), new DateTime(1917, 9, 3, 7, 5, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 376,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1929, 4, 12, 16, 14, 43, 0, DateTimeKind.Utc), new DateTime(1929, 4, 12, 16, 14, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 377,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1906, 8, 9, 14, 17, 7, 0, DateTimeKind.Utc), new DateTime(1906, 8, 9, 14, 17, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 378,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1941, 9, 2, 7, 6, 29, 0, DateTimeKind.Utc), new DateTime(1941, 9, 2, 7, 6, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 379,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1924, 2, 11, 11, 47, 32, 0, DateTimeKind.Utc), new DateTime(1924, 2, 11, 11, 47, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 380,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1923, 1, 12, 11, 33, 30, 0, DateTimeKind.Utc), new DateTime(1923, 1, 12, 11, 33, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 381,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1934, 11, 1, 22, 56, 23, 0, DateTimeKind.Utc), new DateTime(1934, 11, 1, 22, 56, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 382,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2009, 2, 4, 21, 9, 21, 0, DateTimeKind.Utc), new DateTime(2009, 2, 4, 21, 9, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 383,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1932, 11, 20, 12, 10, 27, 0, DateTimeKind.Utc), new DateTime(1932, 11, 20, 12, 10, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 384,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2001, 10, 20, 14, 7, 58, 0, DateTimeKind.Utc), new DateTime(2001, 10, 20, 14, 7, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 385,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1907, 9, 14, 20, 28, 11, 0, DateTimeKind.Utc), new DateTime(1907, 9, 14, 20, 28, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 386,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1938, 7, 4, 19, 17, 22, 0, DateTimeKind.Utc), new DateTime(1938, 7, 4, 19, 17, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 387,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1913, 5, 24, 15, 26, 59, 0, DateTimeKind.Utc), new DateTime(1913, 5, 24, 15, 26, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 388,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1941, 4, 28, 0, 11, 51, 0, DateTimeKind.Utc), new DateTime(1941, 4, 28, 0, 11, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 389,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 8, 25, 22, 40, 42, 0, DateTimeKind.Utc), new DateTime(2006, 8, 25, 22, 40, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 390,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 8, 23, 0, 52, 8, 0, DateTimeKind.Utc), new DateTime(2002, 8, 23, 0, 52, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 391,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2011, 1, 18, 22, 33, 34, 0, DateTimeKind.Utc), new DateTime(2011, 1, 18, 22, 33, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 392,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1927, 6, 18, 7, 22, 47, 0, DateTimeKind.Utc), new DateTime(1927, 6, 18, 7, 22, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 393,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1974, 2, 12, 16, 16, 47, 0, DateTimeKind.Utc), new DateTime(1974, 2, 12, 16, 16, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 394,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1899, 1, 17, 15, 0, 46, 0, DateTimeKind.Utc), new DateTime(1899, 1, 17, 15, 0, 46, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 395,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1939, 5, 25, 9, 58, 37, 0, DateTimeKind.Utc), new DateTime(1939, 5, 25, 9, 58, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 396,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1969, 1, 15, 17, 45, 26, 0, DateTimeKind.Utc), new DateTime(1969, 1, 15, 17, 45, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 397,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1944, 5, 22, 9, 46, 42, 0, DateTimeKind.Utc), new DateTime(1944, 5, 22, 9, 46, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 398,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 6, 9, 1, 20, 31, 0, DateTimeKind.Utc), new DateTime(1925, 6, 9, 1, 20, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 399,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1938, 2, 12, 0, 1, 48, 0, DateTimeKind.Utc), new DateTime(1938, 2, 12, 0, 1, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 400,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1967, 3, 28, 20, 37, 11, 0, DateTimeKind.Utc), new DateTime(1967, 3, 28, 20, 37, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 401,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1986, 10, 14, 0, 44, 17, 0, DateTimeKind.Utc), new DateTime(1986, 10, 14, 0, 44, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 402,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1933, 10, 12, 22, 19, 52, 0, DateTimeKind.Utc), new DateTime(1933, 10, 12, 22, 19, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 403,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1901, 7, 9, 21, 25, 28, 0, DateTimeKind.Utc), new DateTime(1901, 7, 9, 21, 25, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 404,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1955, 3, 1, 8, 5, 50, 0, DateTimeKind.Utc), new DateTime(1955, 3, 1, 8, 5, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 405,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1923, 7, 2, 16, 10, 30, 0, DateTimeKind.Utc), new DateTime(1923, 7, 2, 16, 10, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 406,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1954, 6, 22, 13, 41, 57, 0, DateTimeKind.Utc), new DateTime(1954, 6, 22, 13, 41, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 407,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 3, 23, 0, 47, 27, 0, DateTimeKind.Utc), new DateTime(1925, 3, 23, 0, 47, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 408,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1912, 4, 23, 12, 59, 23, 0, DateTimeKind.Utc), new DateTime(1912, 4, 23, 12, 59, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 409,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1963, 8, 24, 12, 24, 22, 0, DateTimeKind.Utc), new DateTime(1963, 8, 24, 12, 24, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 410,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1920, 4, 21, 15, 49, 11, 0, DateTimeKind.Utc), new DateTime(1920, 4, 21, 15, 49, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 411,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1926, 7, 21, 21, 30, 49, 0, DateTimeKind.Utc), new DateTime(1926, 7, 21, 21, 30, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 412,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1910, 6, 27, 8, 40, 13, 0, DateTimeKind.Utc), new DateTime(1910, 6, 27, 8, 40, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 413,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1985, 5, 13, 13, 15, 43, 0, DateTimeKind.Utc), new DateTime(1985, 5, 13, 13, 15, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 414,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 8, 16, 16, 11, 30, 0, DateTimeKind.Utc), new DateTime(1902, 8, 16, 16, 11, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 415,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1982, 11, 3, 9, 23, 21, 0, DateTimeKind.Utc), new DateTime(1982, 11, 3, 9, 23, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 416,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1926, 7, 11, 14, 48, 12, 0, DateTimeKind.Utc), new DateTime(1926, 7, 11, 14, 48, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 417,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1990, 3, 24, 23, 26, 32, 0, DateTimeKind.Utc), new DateTime(1990, 3, 24, 23, 26, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 418,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1956, 2, 28, 14, 49, 59, 0, DateTimeKind.Utc), new DateTime(1956, 2, 28, 14, 49, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 419,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2015, 7, 3, 23, 36, 9, 0, DateTimeKind.Utc), new DateTime(2015, 7, 3, 23, 36, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 420,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 7, 12, 5, 13, 34, 0, DateTimeKind.Utc), new DateTime(1979, 7, 12, 5, 13, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 421,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1990, 8, 2, 13, 7, 6, 0, DateTimeKind.Utc), new DateTime(1990, 8, 2, 13, 7, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 422,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 2, 18, 5, 50, 1, 0, DateTimeKind.Utc), new DateTime(2006, 2, 18, 5, 50, 1, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 423,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2009, 1, 7, 0, 12, 1, 0, DateTimeKind.Utc), new DateTime(2009, 1, 7, 0, 12, 1, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 424,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 1, 3, 2, 28, 47, 0, DateTimeKind.Utc), new DateTime(1964, 1, 3, 2, 28, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 425,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1933, 3, 27, 5, 57, 15, 0, DateTimeKind.Utc), new DateTime(1933, 3, 27, 5, 57, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 426,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2001, 6, 28, 6, 14, 44, 0, DateTimeKind.Utc), new DateTime(2001, 6, 28, 6, 14, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 427,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1957, 10, 2, 21, 45, 44, 0, DateTimeKind.Utc), new DateTime(1957, 10, 2, 21, 45, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 428,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1944, 8, 22, 1, 6, 33, 0, DateTimeKind.Utc), new DateTime(1944, 8, 22, 1, 6, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 429,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2015, 7, 10, 9, 41, 10, 0, DateTimeKind.Utc), new DateTime(2015, 7, 10, 9, 41, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 430,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1957, 7, 7, 6, 18, 53, 0, DateTimeKind.Utc), new DateTime(1957, 7, 7, 6, 18, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 431,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1917, 7, 4, 8, 25, 19, 0, DateTimeKind.Utc), new DateTime(1917, 7, 4, 8, 25, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 432,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1904, 7, 23, 11, 33, 20, 0, DateTimeKind.Utc), new DateTime(1904, 7, 23, 11, 33, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 433,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 8, 9, 8, 44, 47, 0, DateTimeKind.Utc), new DateTime(2022, 8, 9, 8, 44, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 434,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1900, 3, 4, 9, 17, 20, 0, DateTimeKind.Utc), new DateTime(1900, 3, 4, 9, 17, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 435,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2014, 5, 24, 19, 48, 37, 0, DateTimeKind.Utc), new DateTime(2014, 5, 24, 19, 48, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 436,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 3, 17, 3, 43, 7, 0, DateTimeKind.Utc), new DateTime(1962, 3, 17, 3, 43, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 437,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1973, 1, 8, 10, 59, 30, 0, DateTimeKind.Utc), new DateTime(1973, 1, 8, 10, 59, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 438,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1991, 5, 2, 23, 24, 2, 0, DateTimeKind.Utc), new DateTime(1991, 5, 2, 23, 24, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 439,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2007, 2, 25, 10, 15, 3, 0, DateTimeKind.Utc), new DateTime(2007, 2, 25, 10, 15, 3, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 440,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1996, 9, 10, 19, 26, 59, 0, DateTimeKind.Utc), new DateTime(1996, 9, 10, 19, 26, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 441,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1960, 3, 23, 4, 59, 22, 0, DateTimeKind.Utc), new DateTime(1960, 3, 23, 4, 59, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 442,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1994, 10, 26, 4, 46, 44, 0, DateTimeKind.Utc), new DateTime(1994, 10, 26, 4, 46, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 443,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 7, 7, 14, 39, 51, 0, DateTimeKind.Utc), new DateTime(1964, 7, 7, 14, 39, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 444,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1932, 11, 1, 18, 57, 42, 0, DateTimeKind.Utc), new DateTime(1932, 11, 1, 18, 57, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 445,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1992, 1, 26, 12, 22, 58, 0, DateTimeKind.Utc), new DateTime(1992, 1, 26, 12, 22, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 446,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1997, 9, 16, 6, 57, 45, 0, DateTimeKind.Utc), new DateTime(1997, 9, 16, 6, 57, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 447,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1987, 7, 13, 16, 13, 34, 0, DateTimeKind.Utc), new DateTime(1987, 7, 13, 16, 13, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 448,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1915, 8, 10, 3, 54, 41, 0, DateTimeKind.Utc), new DateTime(1915, 8, 10, 3, 54, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 449,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2003, 2, 3, 11, 31, 30, 0, DateTimeKind.Utc), new DateTime(2003, 2, 3, 11, 31, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 450,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2020, 8, 8, 2, 26, 54, 0, DateTimeKind.Utc), new DateTime(2020, 8, 8, 2, 26, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 451,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1954, 3, 13, 22, 24, 58, 0, DateTimeKind.Utc), new DateTime(1954, 3, 13, 22, 24, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 452,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1920, 3, 18, 11, 54, 6, 0, DateTimeKind.Utc), new DateTime(1920, 3, 18, 11, 54, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 453,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1949, 7, 20, 10, 38, 17, 0, DateTimeKind.Utc), new DateTime(1949, 7, 20, 10, 38, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 454,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1945, 7, 5, 5, 41, 12, 0, DateTimeKind.Utc), new DateTime(1945, 7, 5, 5, 41, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 455,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2007, 4, 8, 1, 18, 14, 0, DateTimeKind.Utc), new DateTime(2007, 4, 8, 1, 18, 14, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 456,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1959, 7, 3, 12, 15, 58, 0, DateTimeKind.Utc), new DateTime(1959, 7, 3, 12, 15, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 457,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1913, 3, 8, 8, 57, 39, 0, DateTimeKind.Utc), new DateTime(1913, 3, 8, 8, 57, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 458,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1905, 4, 8, 23, 4, 57, 0, DateTimeKind.Utc), new DateTime(1905, 4, 8, 23, 4, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 459,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 6, 2, 23, 43, 50, 0, DateTimeKind.Utc), new DateTime(2002, 6, 2, 23, 43, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 460,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1994, 3, 16, 6, 4, 5, 0, DateTimeKind.Utc), new DateTime(1994, 3, 16, 6, 4, 5, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 461,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1988, 2, 27, 9, 59, 17, 0, DateTimeKind.Utc), new DateTime(1988, 2, 27, 9, 59, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 462,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1898, 10, 10, 17, 19, 27, 0, DateTimeKind.Utc), new DateTime(1898, 10, 10, 17, 19, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 463,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1900, 1, 18, 11, 10, 19, 0, DateTimeKind.Utc), new DateTime(1900, 1, 18, 11, 10, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 464,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2016, 10, 7, 7, 13, 47, 0, DateTimeKind.Utc), new DateTime(2016, 10, 7, 7, 13, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 465,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1921, 6, 25, 6, 46, 2, 0, DateTimeKind.Utc), new DateTime(1921, 6, 25, 6, 46, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 466,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 10, 4, 4, 38, 50, 0, DateTimeKind.Utc), new DateTime(1950, 10, 4, 4, 38, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 467,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1988, 8, 11, 23, 59, 11, 0, DateTimeKind.Utc), new DateTime(1988, 8, 11, 23, 59, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 468,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 2, 6, 14, 58, 42, 0, DateTimeKind.Utc), new DateTime(1977, 2, 6, 14, 58, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 469,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1922, 3, 1, 5, 19, 12, 0, DateTimeKind.Utc), new DateTime(1922, 3, 1, 5, 19, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 470,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 5, 26, 3, 12, 29, 0, DateTimeKind.Utc), new DateTime(2006, 5, 26, 3, 12, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 471,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1949, 9, 3, 6, 18, 27, 0, DateTimeKind.Utc), new DateTime(1949, 9, 3, 6, 18, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 472,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1940, 10, 11, 19, 46, 29, 0, DateTimeKind.Utc), new DateTime(1940, 10, 11, 19, 46, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 473,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2020, 11, 25, 1, 40, 7, 0, DateTimeKind.Utc), new DateTime(2020, 11, 25, 1, 40, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 474,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1974, 7, 15, 4, 4, 30, 0, DateTimeKind.Utc), new DateTime(1974, 7, 15, 4, 4, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 475,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1899, 2, 16, 21, 18, 13, 0, DateTimeKind.Utc), new DateTime(1899, 2, 16, 21, 18, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 476,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2016, 7, 14, 20, 34, 14, 0, DateTimeKind.Utc), new DateTime(2016, 7, 14, 20, 34, 14, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 477,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1910, 4, 23, 17, 16, 7, 0, DateTimeKind.Utc), new DateTime(1910, 4, 23, 17, 16, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 478,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1939, 5, 14, 12, 16, 22, 0, DateTimeKind.Utc), new DateTime(1939, 5, 14, 12, 16, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 479,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1939, 9, 21, 18, 33, 37, 0, DateTimeKind.Utc), new DateTime(1939, 9, 21, 18, 33, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 480,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 3, 19, 14, 16, 7, 0, DateTimeKind.Utc), new DateTime(2022, 3, 19, 14, 16, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 481,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2014, 5, 15, 3, 52, 12, 0, DateTimeKind.Utc), new DateTime(2014, 5, 15, 3, 52, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 482,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1900, 2, 11, 15, 57, 19, 0, DateTimeKind.Utc), new DateTime(1900, 2, 11, 15, 57, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 483,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1938, 10, 9, 9, 50, 40, 0, DateTimeKind.Utc), new DateTime(1938, 10, 9, 9, 50, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 484,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1901, 6, 26, 4, 34, 30, 0, DateTimeKind.Utc), new DateTime(1901, 6, 26, 4, 34, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 485,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1961, 2, 1, 20, 53, 20, 0, DateTimeKind.Utc), new DateTime(1961, 2, 1, 20, 53, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 486,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1970, 6, 2, 16, 48, 50, 0, DateTimeKind.Utc), new DateTime(1970, 6, 2, 16, 48, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 487,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1973, 2, 15, 6, 31, 10, 0, DateTimeKind.Utc), new DateTime(1973, 2, 15, 6, 31, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 488,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 24, 9, 28, 41, 0, DateTimeKind.Utc), new DateTime(2023, 8, 24, 9, 28, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 489,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1938, 7, 11, 23, 33, 48, 0, DateTimeKind.Utc), new DateTime(1938, 7, 11, 23, 33, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 490,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1926, 9, 24, 0, 38, 43, 0, DateTimeKind.Utc), new DateTime(1926, 9, 24, 0, 38, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 491,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1924, 2, 6, 1, 3, 26, 0, DateTimeKind.Utc), new DateTime(1924, 2, 6, 1, 3, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 492,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1931, 8, 2, 10, 47, 39, 0, DateTimeKind.Utc), new DateTime(1931, 8, 2, 10, 47, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 493,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1918, 9, 27, 17, 11, 52, 0, DateTimeKind.Utc), new DateTime(1918, 9, 27, 17, 11, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 494,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1980, 2, 20, 7, 31, 18, 0, DateTimeKind.Utc), new DateTime(1980, 2, 20, 7, 31, 18, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 495,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2018, 7, 27, 6, 26, 4, 0, DateTimeKind.Utc), new DateTime(2018, 7, 27, 6, 26, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 496,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1898, 7, 15, 19, 3, 21, 0, DateTimeKind.Utc), new DateTime(1898, 7, 15, 19, 3, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 497,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 11, 18, 9, 8, 49, 0, DateTimeKind.Utc), new DateTime(2019, 11, 18, 9, 8, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 498,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 10, 23, 17, 50, 48, 0, DateTimeKind.Utc), new DateTime(1977, 10, 23, 17, 50, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 499,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 6, 16, 23, 22, 32, 0, DateTimeKind.Utc), new DateTime(2006, 6, 16, 23, 22, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 500,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 10, 18, 21, 6, 29, 0, DateTimeKind.Utc), new DateTime(1902, 10, 18, 21, 6, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 501,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1959, 11, 6, 23, 26, 13, 0, DateTimeKind.Utc), new DateTime(1959, 11, 6, 23, 26, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 502,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1914, 5, 20, 14, 46, 15, 0, DateTimeKind.Utc), new DateTime(1914, 5, 20, 14, 46, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 503,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1928, 3, 28, 20, 41, 39, 0, DateTimeKind.Utc), new DateTime(1928, 3, 28, 20, 41, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 504,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 3, 21, 3, 24, 57, 0, DateTimeKind.Utc), new DateTime(1962, 3, 21, 3, 24, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 505,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 1, 6, 23, 45, 10, 0, DateTimeKind.Utc), new DateTime(1962, 1, 6, 23, 45, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 506,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1990, 1, 24, 3, 55, 8, 0, DateTimeKind.Utc), new DateTime(1990, 1, 24, 3, 55, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 507,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1976, 8, 12, 13, 35, 28, 0, DateTimeKind.Utc), new DateTime(1976, 8, 12, 13, 35, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 508,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1911, 3, 20, 7, 43, 8, 0, DateTimeKind.Utc), new DateTime(1911, 3, 20, 7, 43, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 509,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1971, 2, 6, 23, 24, 52, 0, DateTimeKind.Utc), new DateTime(1971, 2, 6, 23, 24, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 510,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1992, 4, 17, 5, 28, 24, 0, DateTimeKind.Utc), new DateTime(1992, 4, 17, 5, 28, 24, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 511,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 2, 18, 12, 52, 44, 0, DateTimeKind.Utc), new DateTime(1902, 2, 18, 12, 52, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 512,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1951, 1, 9, 19, 14, 3, 0, DateTimeKind.Utc), new DateTime(1951, 1, 9, 19, 14, 3, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 513,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1928, 11, 18, 6, 2, 9, 0, DateTimeKind.Utc), new DateTime(1928, 11, 18, 6, 2, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 514,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1928, 3, 10, 1, 24, 34, 0, DateTimeKind.Utc), new DateTime(1928, 3, 10, 1, 24, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 515,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 19, 22, 24, 35, 0, DateTimeKind.Utc), new DateTime(2023, 9, 19, 22, 24, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 516,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1968, 5, 5, 0, 31, 26, 0, DateTimeKind.Utc), new DateTime(1968, 5, 5, 0, 31, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 517,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2007, 7, 11, 23, 53, 38, 0, DateTimeKind.Utc), new DateTime(2007, 7, 11, 23, 53, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 518,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2003, 9, 27, 3, 43, 27, 0, DateTimeKind.Utc), new DateTime(2003, 9, 27, 3, 43, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 519,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1929, 6, 9, 10, 0, 16, 0, DateTimeKind.Utc), new DateTime(1929, 6, 9, 10, 0, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 520,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1908, 11, 21, 0, 31, 6, 0, DateTimeKind.Utc), new DateTime(1908, 11, 21, 0, 31, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 521,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1909, 6, 19, 17, 16, 52, 0, DateTimeKind.Utc), new DateTime(1909, 6, 19, 17, 16, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 522,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2012, 3, 12, 4, 23, 26, 0, DateTimeKind.Utc), new DateTime(2012, 3, 12, 4, 23, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 523,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1994, 3, 9, 16, 13, 39, 0, DateTimeKind.Utc), new DateTime(1994, 3, 9, 16, 13, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 524,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 10, 1, 4, 42, 55, 0, DateTimeKind.Utc), new DateTime(1979, 10, 1, 4, 42, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 525,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1935, 2, 11, 21, 56, 33, 0, DateTimeKind.Utc), new DateTime(1935, 2, 11, 21, 56, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 526,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1988, 10, 2, 6, 53, 25, 0, DateTimeKind.Utc), new DateTime(1988, 10, 2, 6, 53, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 527,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 2, 14, 1, 13, 30, 0, DateTimeKind.Utc), new DateTime(2022, 2, 14, 1, 13, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 528,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 1, 3, 20, 40, 44, 0, DateTimeKind.Utc), new DateTime(1902, 1, 3, 20, 40, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 529,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2021, 5, 21, 1, 22, 39, 0, DateTimeKind.Utc), new DateTime(2021, 5, 21, 1, 22, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 530,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1908, 10, 22, 17, 25, 9, 0, DateTimeKind.Utc), new DateTime(1908, 10, 22, 17, 25, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 531,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 1, 9, 20, 28, 33, 0, DateTimeKind.Utc), new DateTime(1962, 1, 9, 20, 28, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 532,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1946, 6, 11, 21, 42, 6, 0, DateTimeKind.Utc), new DateTime(1946, 6, 11, 21, 42, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 533,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1922, 7, 18, 12, 9, 37, 0, DateTimeKind.Utc), new DateTime(1922, 7, 18, 12, 9, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 534,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2004, 5, 13, 14, 54, 31, 0, DateTimeKind.Utc), new DateTime(2004, 5, 13, 14, 54, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 535,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2000, 8, 13, 9, 12, 59, 0, DateTimeKind.Utc), new DateTime(2000, 8, 13, 9, 12, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 536,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1981, 3, 20, 7, 33, 12, 0, DateTimeKind.Utc), new DateTime(1981, 3, 20, 7, 33, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 537,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 2, 17, 12, 28, 11, 0, DateTimeKind.Utc), new DateTime(1925, 2, 17, 12, 28, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 538,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1944, 1, 20, 15, 53, 48, 0, DateTimeKind.Utc), new DateTime(1944, 1, 20, 15, 53, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 539,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 7, 21, 3, 54, 58, 0, DateTimeKind.Utc), new DateTime(1902, 7, 21, 3, 54, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 540,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1987, 10, 4, 18, 3, 49, 0, DateTimeKind.Utc), new DateTime(1987, 10, 4, 18, 3, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 541,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1910, 11, 8, 9, 13, 27, 0, DateTimeKind.Utc), new DateTime(1910, 11, 8, 9, 13, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 542,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1951, 10, 1, 10, 18, 59, 0, DateTimeKind.Utc), new DateTime(1951, 10, 1, 10, 18, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 543,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1901, 4, 28, 6, 15, 48, 0, DateTimeKind.Utc), new DateTime(1901, 4, 28, 6, 15, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 544,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2003, 2, 22, 15, 21, 38, 0, DateTimeKind.Utc), new DateTime(2003, 2, 22, 15, 21, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 545,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1928, 6, 10, 17, 36, 40, 0, DateTimeKind.Utc), new DateTime(1928, 6, 10, 17, 36, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 546,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1909, 6, 4, 18, 25, 29, 0, DateTimeKind.Utc), new DateTime(1909, 6, 4, 18, 25, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 547,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2013, 11, 25, 5, 12, 0, 0, DateTimeKind.Utc), new DateTime(2013, 11, 25, 5, 12, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 548,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1997, 7, 7, 18, 6, 35, 0, DateTimeKind.Utc), new DateTime(1997, 7, 7, 18, 6, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 549,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 5, 18, 7, 55, 52, 0, DateTimeKind.Utc), new DateTime(2024, 5, 18, 7, 55, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 550,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1906, 5, 18, 15, 9, 42, 0, DateTimeKind.Utc), new DateTime(1906, 5, 18, 15, 9, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 551,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1914, 8, 8, 8, 19, 50, 0, DateTimeKind.Utc), new DateTime(1914, 8, 8, 8, 19, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 552,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2010, 3, 25, 11, 21, 16, 0, DateTimeKind.Utc), new DateTime(2010, 3, 25, 11, 21, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 553,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2018, 7, 28, 17, 52, 44, 0, DateTimeKind.Utc), new DateTime(2018, 7, 28, 17, 52, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 554,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1948, 6, 12, 17, 43, 10, 0, DateTimeKind.Utc), new DateTime(1948, 6, 12, 17, 43, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 555,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 9, 16, 5, 42, 58, 0, DateTimeKind.Utc), new DateTime(1902, 9, 16, 5, 42, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 556,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2008, 4, 23, 3, 6, 30, 0, DateTimeKind.Utc), new DateTime(2008, 4, 23, 3, 6, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 557,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1993, 5, 9, 9, 51, 51, 0, DateTimeKind.Utc), new DateTime(1993, 5, 9, 9, 51, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 558,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1988, 6, 3, 8, 20, 19, 0, DateTimeKind.Utc), new DateTime(1988, 6, 3, 8, 20, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 559,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2012, 4, 17, 20, 14, 39, 0, DateTimeKind.Utc), new DateTime(2012, 4, 17, 20, 14, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 560,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1934, 5, 28, 1, 18, 31, 0, DateTimeKind.Utc), new DateTime(1934, 5, 28, 1, 18, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 561,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1936, 8, 16, 21, 36, 4, 0, DateTimeKind.Utc), new DateTime(1936, 8, 16, 21, 36, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 562,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1955, 9, 14, 11, 59, 25, 0, DateTimeKind.Utc), new DateTime(1955, 9, 14, 11, 59, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 563,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1955, 11, 18, 13, 1, 12, 0, DateTimeKind.Utc), new DateTime(1955, 11, 18, 13, 1, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 564,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1910, 8, 13, 5, 19, 23, 0, DateTimeKind.Utc), new DateTime(1910, 8, 13, 5, 19, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 565,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1948, 1, 2, 3, 52, 43, 0, DateTimeKind.Utc), new DateTime(1948, 1, 2, 3, 52, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 566,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1963, 8, 4, 18, 6, 12, 0, DateTimeKind.Utc), new DateTime(1963, 8, 4, 18, 6, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 567,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1938, 9, 26, 0, 54, 33, 0, DateTimeKind.Utc), new DateTime(1938, 9, 26, 0, 54, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 568,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2005, 5, 10, 3, 25, 14, 0, DateTimeKind.Utc), new DateTime(2005, 5, 10, 3, 25, 14, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 569,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 9, 11, 18, 59, 38, 0, DateTimeKind.Utc), new DateTime(1902, 9, 11, 18, 59, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 570,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1908, 2, 10, 3, 30, 36, 0, DateTimeKind.Utc), new DateTime(1908, 2, 10, 3, 30, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 571,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 4, 26, 18, 57, 19, 0, DateTimeKind.Utc), new DateTime(1902, 4, 26, 18, 57, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 572,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1936, 8, 25, 9, 14, 12, 0, DateTimeKind.Utc), new DateTime(1936, 8, 25, 9, 14, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 573,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1937, 2, 22, 21, 21, 53, 0, DateTimeKind.Utc), new DateTime(1937, 2, 22, 21, 21, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 574,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1905, 3, 17, 19, 7, 8, 0, DateTimeKind.Utc), new DateTime(1905, 3, 17, 19, 7, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 575,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1943, 9, 20, 11, 41, 0, 0, DateTimeKind.Utc), new DateTime(1943, 9, 20, 11, 41, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 576,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2010, 2, 9, 6, 58, 36, 0, DateTimeKind.Utc), new DateTime(2010, 2, 9, 6, 58, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 577,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 1, 14, 23, 51, 43, 0, DateTimeKind.Utc), new DateTime(1979, 1, 14, 23, 51, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 578,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1942, 7, 14, 3, 28, 53, 0, DateTimeKind.Utc), new DateTime(1942, 7, 14, 3, 28, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 579,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2007, 3, 21, 10, 5, 15, 0, DateTimeKind.Utc), new DateTime(2007, 3, 21, 10, 5, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 580,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1901, 3, 5, 18, 24, 12, 0, DateTimeKind.Utc), new DateTime(1901, 3, 5, 18, 24, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 581,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1980, 9, 1, 21, 31, 4, 0, DateTimeKind.Utc), new DateTime(1980, 9, 1, 21, 31, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 582,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2012, 1, 4, 3, 14, 16, 0, DateTimeKind.Utc), new DateTime(2012, 1, 4, 3, 14, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 583,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 1, 11, 20, 26, 29, 0, DateTimeKind.Utc), new DateTime(1950, 1, 11, 20, 26, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 584,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1982, 3, 8, 18, 37, 29, 0, DateTimeKind.Utc), new DateTime(1982, 3, 8, 18, 37, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 585,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1932, 6, 2, 1, 15, 43, 0, DateTimeKind.Utc), new DateTime(1932, 6, 2, 1, 15, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 586,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1952, 10, 20, 6, 21, 2, 0, DateTimeKind.Utc), new DateTime(1952, 10, 20, 6, 21, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 587,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1990, 6, 4, 9, 14, 27, 0, DateTimeKind.Utc), new DateTime(1990, 6, 4, 9, 14, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 588,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1996, 8, 27, 11, 1, 2, 0, DateTimeKind.Utc), new DateTime(1996, 8, 27, 11, 1, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 589,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2008, 2, 23, 16, 5, 11, 0, DateTimeKind.Utc), new DateTime(2008, 2, 23, 16, 5, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 590,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2018, 10, 5, 12, 36, 3, 0, DateTimeKind.Utc), new DateTime(2018, 10, 5, 12, 36, 3, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 591,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1900, 10, 22, 9, 43, 22, 0, DateTimeKind.Utc), new DateTime(1900, 10, 22, 9, 43, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 592,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1972, 2, 20, 8, 7, 58, 0, DateTimeKind.Utc), new DateTime(1972, 2, 20, 8, 7, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 593,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1946, 3, 28, 19, 0, 55, 0, DateTimeKind.Utc), new DateTime(1946, 3, 28, 19, 0, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 594,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1969, 9, 13, 0, 10, 5, 0, DateTimeKind.Utc), new DateTime(1969, 9, 13, 0, 10, 5, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 595,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2017, 9, 22, 11, 18, 29, 0, DateTimeKind.Utc), new DateTime(2017, 9, 22, 11, 18, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 596,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2008, 3, 25, 1, 22, 23, 0, DateTimeKind.Utc), new DateTime(2008, 3, 25, 1, 22, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 597,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1985, 5, 28, 13, 52, 52, 0, DateTimeKind.Utc), new DateTime(1985, 5, 28, 13, 52, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 598,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1939, 6, 2, 19, 18, 50, 0, DateTimeKind.Utc), new DateTime(1939, 6, 2, 19, 18, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 599,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 2, 24, 6, 56, 47, 0, DateTimeKind.Utc), new DateTime(1925, 2, 24, 6, 56, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 600,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1976, 11, 19, 16, 27, 59, 0, DateTimeKind.Utc), new DateTime(1976, 11, 19, 16, 27, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 601,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1972, 2, 24, 5, 27, 53, 0, DateTimeKind.Utc), new DateTime(1972, 2, 24, 5, 27, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 602,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1912, 4, 25, 13, 7, 38, 0, DateTimeKind.Utc), new DateTime(1912, 4, 25, 13, 7, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 603,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 11, 27, 13, 42, 38, 0, DateTimeKind.Utc), new DateTime(2019, 11, 27, 13, 42, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 604,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1901, 2, 13, 22, 16, 10, 0, DateTimeKind.Utc), new DateTime(1901, 2, 13, 22, 16, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 605,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1980, 7, 8, 1, 25, 23, 0, DateTimeKind.Utc), new DateTime(1980, 7, 8, 1, 25, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 606,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1989, 1, 26, 23, 58, 46, 0, DateTimeKind.Utc), new DateTime(1989, 1, 26, 23, 58, 46, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 607,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1901, 2, 3, 3, 41, 58, 0, DateTimeKind.Utc), new DateTime(1901, 2, 3, 3, 41, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 608,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 17, 56, 0, DateTimeKind.Utc), new DateTime(2019, 8, 1, 5, 17, 56, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 609,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2005, 1, 8, 0, 38, 19, 0, DateTimeKind.Utc), new DateTime(2005, 1, 8, 0, 38, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 610,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1968, 8, 23, 15, 34, 50, 0, DateTimeKind.Utc), new DateTime(1968, 8, 23, 15, 34, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 611,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1975, 1, 26, 11, 51, 6, 0, DateTimeKind.Utc), new DateTime(1975, 1, 26, 11, 51, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 612,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1988, 11, 1, 4, 32, 35, 0, DateTimeKind.Utc), new DateTime(1988, 11, 1, 4, 32, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 613,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1970, 10, 12, 11, 59, 38, 0, DateTimeKind.Utc), new DateTime(1970, 10, 12, 11, 59, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 614,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1917, 5, 9, 8, 13, 22, 0, DateTimeKind.Utc), new DateTime(1917, 5, 9, 8, 13, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 615,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1911, 8, 11, 14, 25, 19, 0, DateTimeKind.Utc), new DateTime(1911, 8, 11, 14, 25, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 616,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2020, 5, 16, 5, 33, 39, 0, DateTimeKind.Utc), new DateTime(2020, 5, 16, 5, 33, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 617,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1905, 6, 23, 21, 30, 19, 0, DateTimeKind.Utc), new DateTime(1905, 6, 23, 21, 30, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 618,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2016, 8, 15, 16, 27, 46, 0, DateTimeKind.Utc), new DateTime(2016, 8, 15, 16, 27, 46, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 619,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2012, 1, 19, 4, 30, 7, 0, DateTimeKind.Utc), new DateTime(2012, 1, 19, 4, 30, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 620,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 3, 23, 12, 23, 9, 0, DateTimeKind.Utc), new DateTime(1964, 3, 23, 12, 23, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 621,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1993, 2, 16, 16, 12, 10, 0, DateTimeKind.Utc), new DateTime(1993, 2, 16, 16, 12, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 622,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1905, 4, 9, 18, 24, 31, 0, DateTimeKind.Utc), new DateTime(1905, 4, 9, 18, 24, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 623,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 3, 27, 23, 24, 33, 0, DateTimeKind.Utc), new DateTime(2006, 3, 27, 23, 24, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 624,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2008, 5, 7, 13, 41, 20, 0, DateTimeKind.Utc), new DateTime(2008, 5, 7, 13, 41, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 625,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1983, 9, 24, 9, 41, 16, 0, DateTimeKind.Utc), new DateTime(1983, 9, 24, 9, 41, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 626,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2003, 6, 3, 15, 9, 23, 0, DateTimeKind.Utc), new DateTime(2003, 6, 3, 15, 9, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 627,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1996, 3, 14, 7, 37, 7, 0, DateTimeKind.Utc), new DateTime(1996, 3, 14, 7, 37, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 628,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1957, 2, 20, 3, 19, 15, 0, DateTimeKind.Utc), new DateTime(1957, 2, 20, 3, 19, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 629,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1922, 6, 25, 6, 40, 57, 0, DateTimeKind.Utc), new DateTime(1922, 6, 25, 6, 40, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 630,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2016, 2, 12, 4, 1, 24, 0, DateTimeKind.Utc), new DateTime(2016, 2, 12, 4, 1, 24, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 631,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1939, 8, 19, 0, 56, 53, 0, DateTimeKind.Utc), new DateTime(1939, 8, 19, 0, 56, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 632,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1954, 3, 3, 13, 13, 9, 0, DateTimeKind.Utc), new DateTime(1954, 3, 3, 13, 13, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 633,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1908, 6, 23, 2, 6, 33, 0, DateTimeKind.Utc), new DateTime(1908, 6, 23, 2, 6, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 634,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1981, 6, 14, 14, 12, 10, 0, DateTimeKind.Utc), new DateTime(1981, 6, 14, 14, 12, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 635,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 7, 24, 2, 41, 59, 0, DateTimeKind.Utc), new DateTime(1950, 7, 24, 2, 41, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 636,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 7, 7, 1, 59, 57, 0, DateTimeKind.Utc), new DateTime(2019, 7, 7, 1, 59, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 637,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1957, 5, 6, 18, 41, 5, 0, DateTimeKind.Utc), new DateTime(1957, 5, 6, 18, 41, 5, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 638,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1918, 8, 9, 16, 11, 7, 0, DateTimeKind.Utc), new DateTime(1918, 8, 9, 16, 11, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 639,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1919, 10, 2, 20, 32, 28, 0, DateTimeKind.Utc), new DateTime(1919, 10, 2, 20, 32, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 640,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2015, 9, 13, 11, 36, 22, 0, DateTimeKind.Utc), new DateTime(2015, 9, 13, 11, 36, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 641,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 4, 15, 2, 35, 38, 0, DateTimeKind.Utc), new DateTime(1902, 4, 15, 2, 35, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 642,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2017, 1, 16, 19, 38, 40, 0, DateTimeKind.Utc), new DateTime(2017, 1, 16, 19, 38, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 643,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1944, 10, 24, 9, 25, 33, 0, DateTimeKind.Utc), new DateTime(1944, 10, 24, 9, 25, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 644,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 8, 11, 17, 56, 52, 0, DateTimeKind.Utc), new DateTime(2006, 8, 11, 17, 56, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 645,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2015, 1, 1, 17, 8, 15, 0, DateTimeKind.Utc), new DateTime(2015, 1, 1, 17, 8, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 646,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1963, 11, 23, 19, 45, 22, 0, DateTimeKind.Utc), new DateTime(1963, 11, 23, 19, 45, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 647,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1968, 1, 2, 16, 45, 10, 0, DateTimeKind.Utc), new DateTime(1968, 1, 2, 16, 45, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 648,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1971, 4, 5, 9, 30, 40, 0, DateTimeKind.Utc), new DateTime(1971, 4, 5, 9, 30, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 649,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 6, 9, 21, 37, 54, 0, DateTimeKind.Utc), new DateTime(1979, 6, 9, 21, 37, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 650,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1899, 4, 11, 15, 10, 30, 0, DateTimeKind.Utc), new DateTime(1899, 4, 11, 15, 10, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 651,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1975, 3, 25, 6, 18, 39, 0, DateTimeKind.Utc), new DateTime(1975, 3, 25, 6, 18, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 652,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2007, 7, 4, 11, 50, 22, 0, DateTimeKind.Utc), new DateTime(2007, 7, 4, 11, 50, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 653,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 3, 27, 4, 8, 36, 0, DateTimeKind.Utc), new DateTime(1962, 3, 27, 4, 8, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 654,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1986, 7, 17, 8, 6, 35, 0, DateTimeKind.Utc), new DateTime(1986, 7, 17, 8, 6, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 655,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 7, 11, 22, 48, 27, 0, DateTimeKind.Utc), new DateTime(2019, 7, 11, 22, 48, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 656,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 10, 25, 13, 3, 34, 0, DateTimeKind.Utc), new DateTime(2023, 10, 25, 13, 3, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 657,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1935, 4, 1, 12, 30, 56, 0, DateTimeKind.Utc), new DateTime(1935, 4, 1, 12, 30, 56, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 658,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1969, 2, 20, 22, 22, 26, 0, DateTimeKind.Utc), new DateTime(1969, 2, 20, 22, 22, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 659,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2018, 9, 5, 18, 57, 37, 0, DateTimeKind.Utc), new DateTime(2018, 9, 5, 18, 57, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 660,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2014, 3, 3, 6, 19, 41, 0, DateTimeKind.Utc), new DateTime(2014, 3, 3, 6, 19, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 661,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1934, 11, 22, 15, 29, 56, 0, DateTimeKind.Utc), new DateTime(1934, 11, 22, 15, 29, 56, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 662,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 11, 4, 9, 53, 51, 0, DateTimeKind.Utc), new DateTime(1962, 11, 4, 9, 53, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 663,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1972, 2, 2, 15, 47, 56, 0, DateTimeKind.Utc), new DateTime(1972, 2, 2, 15, 47, 56, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 664,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2012, 1, 8, 22, 57, 59, 0, DateTimeKind.Utc), new DateTime(2012, 1, 8, 22, 57, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 665,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1935, 3, 26, 5, 38, 47, 0, DateTimeKind.Utc), new DateTime(1935, 3, 26, 5, 38, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 666,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1958, 1, 28, 8, 14, 34, 0, DateTimeKind.Utc), new DateTime(1958, 1, 28, 8, 14, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 667,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1923, 10, 20, 18, 25, 24, 0, DateTimeKind.Utc), new DateTime(1923, 10, 20, 18, 25, 24, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 668,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1937, 7, 26, 7, 11, 47, 0, DateTimeKind.Utc), new DateTime(1937, 7, 26, 7, 11, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 669,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1973, 4, 13, 3, 22, 17, 0, DateTimeKind.Utc), new DateTime(1973, 4, 13, 3, 22, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 670,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1952, 4, 28, 18, 22, 16, 0, DateTimeKind.Utc), new DateTime(1952, 4, 28, 18, 22, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 671,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1900, 3, 10, 7, 54, 52, 0, DateTimeKind.Utc), new DateTime(1900, 3, 10, 7, 54, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 672,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2009, 3, 27, 11, 26, 53, 0, DateTimeKind.Utc), new DateTime(2009, 3, 27, 11, 26, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 673,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1930, 2, 17, 20, 36, 23, 0, DateTimeKind.Utc), new DateTime(1930, 2, 17, 20, 36, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 674,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1906, 11, 1, 3, 38, 21, 0, DateTimeKind.Utc), new DateTime(1906, 11, 1, 3, 38, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 675,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1940, 4, 18, 16, 54, 52, 0, DateTimeKind.Utc), new DateTime(1940, 4, 18, 16, 54, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 676,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1974, 5, 15, 9, 44, 9, 0, DateTimeKind.Utc), new DateTime(1974, 5, 15, 9, 44, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 677,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1909, 11, 19, 0, 25, 55, 0, DateTimeKind.Utc), new DateTime(1909, 11, 19, 0, 25, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 678,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 2, 24, 13, 54, 13, 0, DateTimeKind.Utc), new DateTime(2006, 2, 24, 13, 54, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 679,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1986, 7, 21, 13, 41, 22, 0, DateTimeKind.Utc), new DateTime(1986, 7, 21, 13, 41, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 680,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1928, 10, 18, 23, 59, 35, 0, DateTimeKind.Utc), new DateTime(1928, 10, 18, 23, 59, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 681,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1928, 3, 10, 1, 51, 0, 0, DateTimeKind.Utc), new DateTime(1928, 3, 10, 1, 51, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 682,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1945, 10, 12, 10, 44, 37, 0, DateTimeKind.Utc), new DateTime(1945, 10, 12, 10, 44, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 683,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1990, 1, 16, 2, 16, 30, 0, DateTimeKind.Utc), new DateTime(1990, 1, 16, 2, 16, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 684,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1965, 9, 12, 9, 58, 18, 0, DateTimeKind.Utc), new DateTime(1965, 9, 12, 9, 58, 18, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 685,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1914, 1, 21, 3, 10, 51, 0, DateTimeKind.Utc), new DateTime(1914, 1, 21, 3, 10, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 686,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1966, 2, 28, 1, 48, 13, 0, DateTimeKind.Utc), new DateTime(1966, 2, 28, 1, 48, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 687,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1972, 9, 8, 19, 11, 3, 0, DateTimeKind.Utc), new DateTime(1972, 9, 8, 19, 11, 3, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 688,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 3, 24, 2, 50, 39, 0, DateTimeKind.Utc), new DateTime(2002, 3, 24, 2, 50, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 689,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 2, 18, 2, 25, 13, 0, DateTimeKind.Utc), new DateTime(2002, 2, 18, 2, 25, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 690,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1921, 10, 7, 0, 55, 50, 0, DateTimeKind.Utc), new DateTime(1921, 10, 7, 0, 55, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 691,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1931, 3, 19, 13, 54, 36, 0, DateTimeKind.Utc), new DateTime(1931, 3, 19, 13, 54, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 692,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 8, 7, 7, 30, 28, 0, DateTimeKind.Utc), new DateTime(1979, 8, 7, 7, 30, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 693,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1928, 8, 17, 8, 35, 43, 0, DateTimeKind.Utc), new DateTime(1928, 8, 17, 8, 35, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 694,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1957, 1, 5, 1, 19, 2, 0, DateTimeKind.Utc), new DateTime(1957, 1, 5, 1, 19, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 695,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1929, 5, 20, 18, 53, 58, 0, DateTimeKind.Utc), new DateTime(1929, 5, 20, 18, 53, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 696,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1899, 7, 25, 10, 34, 57, 0, DateTimeKind.Utc), new DateTime(1899, 7, 25, 10, 34, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 697,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1947, 3, 11, 5, 28, 11, 0, DateTimeKind.Utc), new DateTime(1947, 3, 11, 5, 28, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 698,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1953, 6, 18, 3, 52, 44, 0, DateTimeKind.Utc), new DateTime(1953, 6, 18, 3, 52, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 699,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1978, 10, 7, 12, 34, 54, 0, DateTimeKind.Utc), new DateTime(1978, 10, 7, 12, 34, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 700,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1983, 3, 26, 15, 18, 28, 0, DateTimeKind.Utc), new DateTime(1983, 3, 26, 15, 18, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 701,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2014, 10, 22, 6, 18, 57, 0, DateTimeKind.Utc), new DateTime(2014, 10, 22, 6, 18, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 702,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1974, 9, 4, 15, 57, 19, 0, DateTimeKind.Utc), new DateTime(1974, 9, 4, 15, 57, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 703,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1943, 3, 16, 23, 38, 49, 0, DateTimeKind.Utc), new DateTime(1943, 3, 16, 23, 38, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 704,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 2, 16, 23, 8, 2, 0, DateTimeKind.Utc), new DateTime(1950, 2, 16, 23, 8, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 705,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1990, 6, 28, 22, 45, 23, 0, DateTimeKind.Utc), new DateTime(1990, 6, 28, 22, 45, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 706,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1904, 9, 27, 21, 18, 36, 0, DateTimeKind.Utc), new DateTime(1904, 9, 27, 21, 18, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 707,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 3, 6, 15, 31, 3, 0, DateTimeKind.Utc), new DateTime(1950, 3, 6, 15, 31, 3, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 708,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1974, 1, 25, 22, 8, 19, 0, DateTimeKind.Utc), new DateTime(1974, 1, 25, 22, 8, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 709,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1945, 8, 16, 1, 13, 11, 0, DateTimeKind.Utc), new DateTime(1945, 8, 16, 1, 13, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 710,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2015, 11, 21, 17, 31, 48, 0, DateTimeKind.Utc), new DateTime(2015, 11, 21, 17, 31, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 711,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2021, 8, 2, 17, 34, 11, 0, DateTimeKind.Utc), new DateTime(2021, 8, 2, 17, 34, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 712,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1944, 6, 26, 22, 33, 27, 0, DateTimeKind.Utc), new DateTime(1944, 6, 26, 22, 33, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 713,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 9, 17, 11, 21, 7, 0, DateTimeKind.Utc), new DateTime(1979, 9, 17, 11, 21, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 714,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1919, 9, 11, 15, 34, 4, 0, DateTimeKind.Utc), new DateTime(1919, 9, 11, 15, 34, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 715,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2004, 11, 16, 18, 57, 21, 0, DateTimeKind.Utc), new DateTime(2004, 11, 16, 18, 57, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 716,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2007, 8, 19, 9, 41, 53, 0, DateTimeKind.Utc), new DateTime(2007, 8, 19, 9, 41, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 717,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1900, 10, 13, 16, 33, 39, 0, DateTimeKind.Utc), new DateTime(1900, 10, 13, 16, 33, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 718,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 5, 4, 2, 26, 27, 0, DateTimeKind.Utc), new DateTime(1950, 5, 4, 2, 26, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 719,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1975, 5, 17, 14, 33, 42, 0, DateTimeKind.Utc), new DateTime(1975, 5, 17, 14, 33, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 720,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1953, 4, 2, 23, 54, 35, 0, DateTimeKind.Utc), new DateTime(1953, 4, 2, 23, 54, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 721,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1981, 7, 15, 13, 4, 52, 0, DateTimeKind.Utc), new DateTime(1981, 7, 15, 13, 4, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 722,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1997, 3, 2, 16, 28, 30, 0, DateTimeKind.Utc), new DateTime(1997, 3, 2, 16, 28, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 723,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1985, 6, 7, 16, 14, 8, 0, DateTimeKind.Utc), new DateTime(1985, 6, 7, 16, 14, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 724,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2018, 9, 15, 1, 8, 30, 0, DateTimeKind.Utc), new DateTime(2018, 9, 15, 1, 8, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 725,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1996, 3, 4, 22, 56, 21, 0, DateTimeKind.Utc), new DateTime(1996, 3, 4, 22, 56, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 726,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 1, 27, 20, 1, 57, 0, DateTimeKind.Utc), new DateTime(2002, 1, 27, 20, 1, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 727,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1914, 10, 11, 6, 18, 10, 0, DateTimeKind.Utc), new DateTime(1914, 10, 11, 6, 18, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 728,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1948, 11, 28, 2, 55, 4, 0, DateTimeKind.Utc), new DateTime(1948, 11, 28, 2, 55, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 729,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1957, 8, 3, 22, 1, 9, 0, DateTimeKind.Utc), new DateTime(1957, 8, 3, 22, 1, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 730,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1906, 7, 13, 0, 46, 49, 0, DateTimeKind.Utc), new DateTime(1906, 7, 13, 0, 46, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 731,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1991, 10, 9, 16, 52, 25, 0, DateTimeKind.Utc), new DateTime(1991, 10, 9, 16, 52, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 732,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1967, 10, 13, 6, 34, 23, 0, DateTimeKind.Utc), new DateTime(1967, 10, 13, 6, 34, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 733,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1997, 8, 13, 8, 40, 13, 0, DateTimeKind.Utc), new DateTime(1997, 8, 13, 8, 40, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 734,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1966, 8, 10, 1, 29, 13, 0, DateTimeKind.Utc), new DateTime(1966, 8, 10, 1, 29, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 735,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1934, 10, 1, 19, 46, 26, 0, DateTimeKind.Utc), new DateTime(1934, 10, 1, 19, 46, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 736,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1960, 2, 3, 12, 30, 28, 0, DateTimeKind.Utc), new DateTime(1960, 2, 3, 12, 30, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 737,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 8, 1, 13, 32, 3, 0, DateTimeKind.Utc), new DateTime(2006, 8, 1, 13, 32, 3, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 738,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 2, 5, 16, 8, 19, 0, DateTimeKind.Utc), new DateTime(1977, 2, 5, 16, 8, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 739,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1987, 8, 26, 5, 28, 5, 0, DateTimeKind.Utc), new DateTime(1987, 8, 26, 5, 28, 5, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 740,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1960, 8, 10, 2, 24, 58, 0, DateTimeKind.Utc), new DateTime(1960, 8, 10, 2, 24, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 741,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 9, 3, 0, 48, 27, 0, DateTimeKind.Utc), new DateTime(1950, 9, 3, 0, 48, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 742,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1937, 3, 6, 23, 30, 58, 0, DateTimeKind.Utc), new DateTime(1937, 3, 6, 23, 30, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 743,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1923, 11, 5, 6, 25, 18, 0, DateTimeKind.Utc), new DateTime(1923, 11, 5, 6, 25, 18, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 744,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1906, 7, 22, 16, 5, 3, 0, DateTimeKind.Utc), new DateTime(1906, 7, 22, 16, 5, 3, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 745,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 3, 18, 23, 2, 49, 0, DateTimeKind.Utc), new DateTime(1964, 3, 18, 23, 2, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 746,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1914, 9, 9, 1, 8, 48, 0, DateTimeKind.Utc), new DateTime(1914, 9, 9, 1, 8, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 747,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2021, 7, 11, 16, 22, 53, 0, DateTimeKind.Utc), new DateTime(2021, 7, 11, 16, 22, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 748,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1916, 9, 6, 22, 1, 29, 0, DateTimeKind.Utc), new DateTime(1916, 9, 6, 22, 1, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 749,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2017, 3, 8, 1, 1, 48, 0, DateTimeKind.Utc), new DateTime(2017, 3, 8, 1, 1, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 750,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 9, 19, 0, 29, 32, 0, DateTimeKind.Utc), new DateTime(1925, 9, 19, 0, 29, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 751,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 4, 6, 8, 49, 44, 0, DateTimeKind.Utc), new DateTime(2002, 4, 6, 8, 49, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 752,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1984, 2, 24, 8, 17, 49, 0, DateTimeKind.Utc), new DateTime(1984, 2, 24, 8, 17, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 753,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2015, 5, 7, 21, 31, 21, 0, DateTimeKind.Utc), new DateTime(2015, 5, 7, 21, 31, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 754,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2007, 7, 7, 3, 3, 49, 0, DateTimeKind.Utc), new DateTime(2007, 7, 7, 3, 3, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 755,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1971, 2, 21, 11, 50, 24, 0, DateTimeKind.Utc), new DateTime(1971, 2, 21, 11, 50, 24, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 756,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1917, 11, 4, 20, 52, 3, 0, DateTimeKind.Utc), new DateTime(1917, 11, 4, 20, 52, 3, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 757,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1985, 9, 26, 10, 15, 52, 0, DateTimeKind.Utc), new DateTime(1985, 9, 26, 10, 15, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 758,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 7, 26, 10, 7, 39, 0, DateTimeKind.Utc), new DateTime(1979, 7, 26, 10, 7, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 759,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1971, 4, 6, 7, 9, 54, 0, DateTimeKind.Utc), new DateTime(1971, 4, 6, 7, 9, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 760,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1937, 8, 8, 9, 46, 44, 0, DateTimeKind.Utc), new DateTime(1937, 8, 8, 9, 46, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 761,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1900, 3, 9, 10, 11, 20, 0, DateTimeKind.Utc), new DateTime(1900, 3, 9, 10, 11, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 762,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1986, 1, 15, 4, 11, 44, 0, DateTimeKind.Utc), new DateTime(1986, 1, 15, 4, 11, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 763,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1954, 5, 9, 8, 30, 27, 0, DateTimeKind.Utc), new DateTime(1954, 5, 9, 8, 30, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 764,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2011, 2, 28, 1, 54, 30, 0, DateTimeKind.Utc), new DateTime(2011, 2, 28, 1, 54, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 765,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1923, 10, 23, 5, 31, 11, 0, DateTimeKind.Utc), new DateTime(1923, 10, 23, 5, 31, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 766,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1997, 4, 1, 4, 26, 4, 0, DateTimeKind.Utc), new DateTime(1997, 4, 1, 4, 26, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 767,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1970, 3, 12, 14, 44, 1, 0, DateTimeKind.Utc), new DateTime(1970, 3, 12, 14, 44, 1, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 768,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1917, 5, 5, 11, 50, 44, 0, DateTimeKind.Utc), new DateTime(1917, 5, 5, 11, 50, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 769,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1973, 11, 5, 19, 29, 37, 0, DateTimeKind.Utc), new DateTime(1973, 11, 5, 19, 29, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 770,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1995, 11, 9, 19, 14, 19, 0, DateTimeKind.Utc), new DateTime(1995, 11, 9, 19, 14, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 771,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1967, 6, 16, 7, 23, 53, 0, DateTimeKind.Utc), new DateTime(1967, 6, 16, 7, 23, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 772,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1988, 4, 28, 5, 46, 18, 0, DateTimeKind.Utc), new DateTime(1988, 4, 28, 5, 46, 18, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 773,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1905, 4, 12, 22, 55, 30, 0, DateTimeKind.Utc), new DateTime(1905, 4, 12, 22, 55, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 774,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1942, 9, 1, 1, 37, 33, 0, DateTimeKind.Utc), new DateTime(1942, 9, 1, 1, 37, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 775,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1900, 11, 23, 9, 24, 29, 0, DateTimeKind.Utc), new DateTime(1900, 11, 23, 9, 24, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 776,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1997, 9, 27, 1, 2, 15, 0, DateTimeKind.Utc), new DateTime(1997, 9, 27, 1, 2, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 777,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1957, 10, 1, 6, 45, 34, 0, DateTimeKind.Utc), new DateTime(1957, 10, 1, 6, 45, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 778,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1996, 4, 6, 20, 44, 10, 0, DateTimeKind.Utc), new DateTime(1996, 4, 6, 20, 44, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 779,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 10, 1, 18, 27, 30, 0, DateTimeKind.Utc), new DateTime(1925, 10, 1, 18, 27, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 780,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1938, 6, 24, 23, 17, 25, 0, DateTimeKind.Utc), new DateTime(1938, 6, 24, 23, 17, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 781,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1906, 4, 25, 11, 27, 0, 0, DateTimeKind.Utc), new DateTime(1906, 4, 25, 11, 27, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 782,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1943, 11, 8, 3, 28, 4, 0, DateTimeKind.Utc), new DateTime(1943, 11, 8, 3, 28, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 783,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 1, 28, 10, 16, 16, 0, DateTimeKind.Utc), new DateTime(1962, 1, 28, 10, 16, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 784,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1945, 2, 7, 15, 10, 34, 0, DateTimeKind.Utc), new DateTime(1945, 2, 7, 15, 10, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 785,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1955, 1, 9, 10, 45, 32, 0, DateTimeKind.Utc), new DateTime(1955, 1, 9, 10, 45, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 786,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 6, 16, 13, 11, 26, 0, DateTimeKind.Utc), new DateTime(1950, 6, 16, 13, 11, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 787,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1987, 4, 25, 4, 30, 45, 0, DateTimeKind.Utc), new DateTime(1987, 4, 25, 4, 30, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 788,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2013, 1, 10, 22, 16, 22, 0, DateTimeKind.Utc), new DateTime(2013, 1, 10, 22, 16, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 789,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 10, 7, 13, 37, 7, 0, DateTimeKind.Utc), new DateTime(1964, 10, 7, 13, 37, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 790,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1924, 5, 5, 7, 1, 27, 0, DateTimeKind.Utc), new DateTime(1924, 5, 5, 7, 1, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 791,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1987, 11, 7, 17, 43, 59, 0, DateTimeKind.Utc), new DateTime(1987, 11, 7, 17, 43, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 792,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 11, 26, 13, 44, 59, 0, DateTimeKind.Utc), new DateTime(1964, 11, 26, 13, 44, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 793,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1948, 3, 19, 11, 43, 5, 0, DateTimeKind.Utc), new DateTime(1948, 3, 19, 11, 43, 5, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 794,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1926, 6, 21, 22, 55, 52, 0, DateTimeKind.Utc), new DateTime(1926, 6, 21, 22, 55, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 795,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1938, 10, 24, 10, 21, 45, 0, DateTimeKind.Utc), new DateTime(1938, 10, 24, 10, 21, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 796,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1935, 5, 8, 10, 27, 35, 0, DateTimeKind.Utc), new DateTime(1935, 5, 8, 10, 27, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 797,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1963, 2, 10, 8, 26, 20, 0, DateTimeKind.Utc), new DateTime(1963, 2, 10, 8, 26, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 798,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1958, 11, 4, 5, 10, 24, 0, DateTimeKind.Utc), new DateTime(1958, 11, 4, 5, 10, 24, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 799,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1958, 9, 20, 1, 4, 31, 0, DateTimeKind.Utc), new DateTime(1958, 9, 20, 1, 4, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 800,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1991, 9, 28, 8, 24, 53, 0, DateTimeKind.Utc), new DateTime(1991, 9, 28, 8, 24, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 801,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1916, 2, 16, 3, 15, 19, 0, DateTimeKind.Utc), new DateTime(1916, 2, 16, 3, 15, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 802,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1989, 11, 21, 1, 56, 33, 0, DateTimeKind.Utc), new DateTime(1989, 11, 21, 1, 56, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 803,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1993, 10, 2, 9, 27, 57, 0, DateTimeKind.Utc), new DateTime(1993, 10, 2, 9, 27, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 804,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1991, 1, 19, 10, 56, 37, 0, DateTimeKind.Utc), new DateTime(1991, 1, 19, 10, 56, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 805,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1906, 3, 10, 17, 41, 41, 0, DateTimeKind.Utc), new DateTime(1906, 3, 10, 17, 41, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 806,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1973, 2, 22, 11, 12, 20, 0, DateTimeKind.Utc), new DateTime(1973, 2, 22, 11, 12, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 807,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1996, 4, 21, 19, 30, 12, 0, DateTimeKind.Utc), new DateTime(1996, 4, 21, 19, 30, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 808,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1982, 5, 23, 3, 17, 12, 0, DateTimeKind.Utc), new DateTime(1982, 5, 23, 3, 17, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 809,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1956, 4, 9, 0, 37, 19, 0, DateTimeKind.Utc), new DateTime(1956, 4, 9, 0, 37, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 810,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 8, 5, 22, 3, 0, 0, DateTimeKind.Utc), new DateTime(1925, 8, 5, 22, 3, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 811,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 11, 8, 1, 28, 47, 0, DateTimeKind.Utc), new DateTime(2024, 11, 8, 1, 28, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 812,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1996, 4, 19, 17, 36, 7, 0, DateTimeKind.Utc), new DateTime(1996, 4, 19, 17, 36, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 813,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1928, 11, 16, 11, 46, 32, 0, DateTimeKind.Utc), new DateTime(1928, 11, 16, 11, 46, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 814,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 11, 27, 2, 16, 19, 0, DateTimeKind.Utc), new DateTime(2002, 11, 27, 2, 16, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 815,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1947, 7, 15, 10, 14, 30, 0, DateTimeKind.Utc), new DateTime(1947, 7, 15, 10, 14, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 816,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1921, 10, 8, 16, 48, 31, 0, DateTimeKind.Utc), new DateTime(1921, 10, 8, 16, 48, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 817,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2015, 7, 26, 0, 21, 59, 0, DateTimeKind.Utc), new DateTime(2015, 7, 26, 0, 21, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 818,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1969, 9, 22, 4, 48, 41, 0, DateTimeKind.Utc), new DateTime(1969, 9, 22, 4, 48, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 819,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1993, 9, 26, 14, 7, 8, 0, DateTimeKind.Utc), new DateTime(1993, 9, 26, 14, 7, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 820,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1904, 10, 21, 22, 39, 55, 0, DateTimeKind.Utc), new DateTime(1904, 10, 21, 22, 39, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 821,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1931, 4, 2, 3, 32, 46, 0, DateTimeKind.Utc), new DateTime(1931, 4, 2, 3, 32, 46, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 822,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2004, 6, 4, 1, 32, 9, 0, DateTimeKind.Utc), new DateTime(2004, 6, 4, 1, 32, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 823,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1975, 10, 16, 23, 33, 32, 0, DateTimeKind.Utc), new DateTime(1975, 10, 16, 23, 33, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 824,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1971, 3, 22, 19, 42, 29, 0, DateTimeKind.Utc), new DateTime(1971, 3, 22, 19, 42, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 825,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1972, 7, 20, 3, 39, 55, 0, DateTimeKind.Utc), new DateTime(1972, 7, 20, 3, 39, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 826,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2000, 11, 27, 0, 44, 2, 0, DateTimeKind.Utc), new DateTime(2000, 11, 27, 0, 44, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 827,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2017, 5, 6, 23, 20, 16, 0, DateTimeKind.Utc), new DateTime(2017, 5, 6, 23, 20, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 828,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1972, 8, 7, 18, 59, 18, 0, DateTimeKind.Utc), new DateTime(1972, 8, 7, 18, 59, 18, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 829,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1970, 1, 10, 4, 22, 27, 0, DateTimeKind.Utc), new DateTime(1970, 1, 10, 4, 22, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 830,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1919, 5, 18, 13, 33, 58, 0, DateTimeKind.Utc), new DateTime(1919, 5, 18, 13, 33, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 831,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1906, 8, 25, 4, 14, 33, 0, DateTimeKind.Utc), new DateTime(1906, 8, 25, 4, 14, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 832,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1924, 7, 3, 12, 1, 8, 0, DateTimeKind.Utc), new DateTime(1924, 7, 3, 12, 1, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 833,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1942, 7, 25, 11, 14, 0, 0, DateTimeKind.Utc), new DateTime(1942, 7, 25, 11, 14, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 834,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1933, 10, 16, 9, 34, 33, 0, DateTimeKind.Utc), new DateTime(1933, 10, 16, 9, 34, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 835,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1975, 7, 18, 11, 50, 17, 0, DateTimeKind.Utc), new DateTime(1975, 7, 18, 11, 50, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 836,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1952, 5, 25, 4, 54, 39, 0, DateTimeKind.Utc), new DateTime(1952, 5, 25, 4, 54, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 837,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1948, 5, 14, 15, 33, 23, 0, DateTimeKind.Utc), new DateTime(1948, 5, 14, 15, 33, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 838,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 1, 2, 4, 50, 46, 0, DateTimeKind.Utc), new DateTime(1925, 1, 2, 4, 50, 46, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 839,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1973, 8, 6, 14, 16, 43, 0, DateTimeKind.Utc), new DateTime(1973, 8, 6, 14, 16, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 840,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 8, 4, 7, 34, 37, 0, DateTimeKind.Utc), new DateTime(1950, 8, 4, 7, 34, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 841,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2018, 8, 22, 18, 5, 37, 0, DateTimeKind.Utc), new DateTime(2018, 8, 22, 18, 5, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 842,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1931, 2, 20, 5, 4, 51, 0, DateTimeKind.Utc), new DateTime(1931, 2, 20, 5, 4, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 843,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1965, 7, 8, 4, 10, 31, 0, DateTimeKind.Utc), new DateTime(1965, 7, 8, 4, 10, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 844,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1961, 5, 22, 19, 53, 8, 0, DateTimeKind.Utc), new DateTime(1961, 5, 22, 19, 53, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 845,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1911, 9, 4, 3, 47, 14, 0, DateTimeKind.Utc), new DateTime(1911, 9, 4, 3, 47, 14, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 846,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1966, 1, 23, 20, 42, 50, 0, DateTimeKind.Utc), new DateTime(1966, 1, 23, 20, 42, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 847,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 5, 28, 10, 55, 42, 0, DateTimeKind.Utc), new DateTime(1977, 5, 28, 10, 55, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 848,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1910, 5, 18, 8, 4, 39, 0, DateTimeKind.Utc), new DateTime(1910, 5, 18, 8, 4, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 849,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1957, 3, 14, 14, 48, 9, 0, DateTimeKind.Utc), new DateTime(1957, 3, 14, 14, 48, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 850,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2005, 2, 23, 14, 40, 16, 0, DateTimeKind.Utc), new DateTime(2005, 2, 23, 14, 40, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 851,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1963, 2, 10, 10, 40, 59, 0, DateTimeKind.Utc), new DateTime(1963, 2, 10, 10, 40, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 852,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 8, 26, 10, 33, 44, 0, DateTimeKind.Utc), new DateTime(1902, 8, 26, 10, 33, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 853,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1968, 1, 15, 1, 43, 31, 0, DateTimeKind.Utc), new DateTime(1968, 1, 15, 1, 43, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 854,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1965, 9, 21, 10, 39, 33, 0, DateTimeKind.Utc), new DateTime(1965, 9, 21, 10, 39, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 855,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1993, 11, 8, 15, 0, 35, 0, DateTimeKind.Utc), new DateTime(1993, 11, 8, 15, 0, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 856,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1900, 11, 21, 16, 55, 47, 0, DateTimeKind.Utc), new DateTime(1900, 11, 21, 16, 55, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 857,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1943, 8, 20, 14, 18, 23, 0, DateTimeKind.Utc), new DateTime(1943, 8, 20, 14, 18, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 858,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1992, 1, 20, 17, 2, 45, 0, DateTimeKind.Utc), new DateTime(1992, 1, 20, 17, 2, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 859,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1980, 9, 11, 7, 5, 55, 0, DateTimeKind.Utc), new DateTime(1980, 9, 11, 7, 5, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 860,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1966, 1, 13, 18, 41, 44, 0, DateTimeKind.Utc), new DateTime(1966, 1, 13, 18, 41, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 861,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1988, 5, 20, 7, 23, 33, 0, DateTimeKind.Utc), new DateTime(1988, 5, 20, 7, 23, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 862,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1898, 10, 4, 17, 42, 3, 0, DateTimeKind.Utc), new DateTime(1898, 10, 4, 17, 42, 3, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 863,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 11, 13, 8, 42, 36, 0, DateTimeKind.Utc), new DateTime(2002, 11, 13, 8, 42, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 864,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2009, 1, 26, 12, 0, 14, 0, DateTimeKind.Utc), new DateTime(2009, 1, 26, 12, 0, 14, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 865,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1923, 8, 26, 19, 9, 51, 0, DateTimeKind.Utc), new DateTime(1923, 8, 26, 19, 9, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 866,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1939, 7, 28, 23, 54, 56, 0, DateTimeKind.Utc), new DateTime(1939, 7, 28, 23, 54, 56, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 867,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1987, 5, 19, 3, 44, 10, 0, DateTimeKind.Utc), new DateTime(1987, 5, 19, 3, 44, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 868,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1975, 11, 2, 7, 28, 10, 0, DateTimeKind.Utc), new DateTime(1975, 11, 2, 7, 28, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 869,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1956, 3, 10, 20, 54, 40, 0, DateTimeKind.Utc), new DateTime(1956, 3, 10, 20, 54, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 870,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2004, 3, 11, 10, 6, 40, 0, DateTimeKind.Utc), new DateTime(2004, 3, 11, 10, 6, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 871,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 2, 20, 6, 23, 8, 0, DateTimeKind.Utc), new DateTime(1979, 2, 20, 6, 23, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 872,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1909, 10, 1, 12, 38, 16, 0, DateTimeKind.Utc), new DateTime(1909, 10, 1, 12, 38, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 873,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2020, 9, 8, 17, 54, 4, 0, DateTimeKind.Utc), new DateTime(2020, 9, 8, 17, 54, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 874,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1920, 10, 8, 17, 22, 57, 0, DateTimeKind.Utc), new DateTime(1920, 10, 8, 17, 22, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 875,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 6, 19, 7, 7, 43, 0, DateTimeKind.Utc), new DateTime(1962, 6, 19, 7, 7, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 876,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1971, 3, 9, 23, 29, 34, 0, DateTimeKind.Utc), new DateTime(1971, 3, 9, 23, 29, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 877,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1958, 4, 16, 22, 14, 36, 0, DateTimeKind.Utc), new DateTime(1958, 4, 16, 22, 14, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 878,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1919, 11, 16, 1, 53, 9, 0, DateTimeKind.Utc), new DateTime(1919, 11, 16, 1, 53, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 879,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 2, 8, 6, 16, 14, 0, DateTimeKind.Utc), new DateTime(1950, 2, 8, 6, 16, 14, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 880,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 11, 23, 17, 46, 54, 0, DateTimeKind.Utc), new DateTime(1950, 11, 23, 17, 46, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 881,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1956, 9, 21, 6, 56, 23, 0, DateTimeKind.Utc), new DateTime(1956, 9, 21, 6, 56, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 882,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 11, 8, 16, 14, 34, 0, DateTimeKind.Utc), new DateTime(2019, 11, 8, 16, 14, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 883,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1966, 3, 18, 15, 33, 25, 0, DateTimeKind.Utc), new DateTime(1966, 3, 18, 15, 33, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 884,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1949, 5, 17, 12, 53, 0, 0, DateTimeKind.Utc), new DateTime(1949, 5, 17, 12, 53, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 885,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1955, 4, 28, 2, 33, 34, 0, DateTimeKind.Utc), new DateTime(1955, 4, 28, 2, 33, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 886,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1995, 9, 16, 15, 27, 26, 0, DateTimeKind.Utc), new DateTime(1995, 9, 16, 15, 27, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 887,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2008, 10, 1, 4, 6, 54, 0, DateTimeKind.Utc), new DateTime(2008, 10, 1, 4, 6, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 888,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2012, 8, 25, 16, 44, 0, 0, DateTimeKind.Utc), new DateTime(2012, 8, 25, 16, 44, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 889,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1974, 9, 10, 9, 19, 19, 0, DateTimeKind.Utc), new DateTime(1974, 9, 10, 9, 19, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 890,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1939, 11, 26, 17, 49, 38, 0, DateTimeKind.Utc), new DateTime(1939, 11, 26, 17, 49, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 891,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1949, 10, 12, 16, 56, 29, 0, DateTimeKind.Utc), new DateTime(1949, 10, 12, 16, 56, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 892,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1899, 11, 23, 4, 46, 40, 0, DateTimeKind.Utc), new DateTime(1899, 11, 23, 4, 46, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 893,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 3, 10, 16, 36, 10, 0, DateTimeKind.Utc), new DateTime(1950, 3, 10, 16, 36, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 894,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1916, 9, 16, 23, 29, 47, 0, DateTimeKind.Utc), new DateTime(1916, 9, 16, 23, 29, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 895,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 5, 12, 5, 17, 30, 0, DateTimeKind.Utc), new DateTime(1925, 5, 12, 5, 17, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 896,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1966, 2, 2, 8, 46, 14, 0, DateTimeKind.Utc), new DateTime(1966, 2, 2, 8, 46, 14, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 897,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1959, 3, 22, 8, 40, 49, 0, DateTimeKind.Utc), new DateTime(1959, 3, 22, 8, 40, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 898,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1923, 5, 1, 16, 57, 5, 0, DateTimeKind.Utc), new DateTime(1923, 5, 1, 16, 57, 5, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 899,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1898, 8, 10, 17, 34, 4, 0, DateTimeKind.Utc), new DateTime(1898, 8, 10, 17, 34, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 900,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1908, 5, 11, 15, 27, 33, 0, DateTimeKind.Utc), new DateTime(1908, 5, 11, 15, 27, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 901,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1908, 9, 18, 7, 38, 37, 0, DateTimeKind.Utc), new DateTime(1908, 9, 18, 7, 38, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 902,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1976, 1, 14, 2, 11, 23, 0, DateTimeKind.Utc), new DateTime(1976, 1, 14, 2, 11, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 903,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1949, 9, 3, 17, 46, 4, 0, DateTimeKind.Utc), new DateTime(1949, 9, 3, 17, 46, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 904,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1998, 6, 12, 7, 14, 39, 0, DateTimeKind.Utc), new DateTime(1998, 6, 12, 7, 14, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 905,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1919, 9, 16, 23, 17, 20, 0, DateTimeKind.Utc), new DateTime(1919, 9, 16, 23, 17, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 906,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 10, 22, 5, 17, 53, 0, DateTimeKind.Utc), new DateTime(2006, 10, 22, 5, 17, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 907,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 10, 22, 9, 3, 55, 0, DateTimeKind.Utc), new DateTime(1925, 10, 22, 9, 3, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 908,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 11, 13, 22, 19, 48, 0, DateTimeKind.Utc), new DateTime(1977, 11, 13, 22, 19, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 909,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 4, 19, 7, 50, 55, 0, DateTimeKind.Utc), new DateTime(2022, 4, 19, 7, 50, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 910,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1915, 9, 16, 22, 8, 50, 0, DateTimeKind.Utc), new DateTime(1915, 9, 16, 22, 8, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 911,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1904, 7, 22, 3, 14, 20, 0, DateTimeKind.Utc), new DateTime(1904, 7, 22, 3, 14, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 912,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1978, 3, 14, 4, 30, 52, 0, DateTimeKind.Utc), new DateTime(1978, 3, 14, 4, 30, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 913,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1937, 5, 14, 11, 42, 19, 0, DateTimeKind.Utc), new DateTime(1937, 5, 14, 11, 42, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 914,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1924, 3, 14, 18, 0, 55, 0, DateTimeKind.Utc), new DateTime(1924, 3, 14, 18, 0, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 915,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1983, 6, 1, 19, 4, 32, 0, DateTimeKind.Utc), new DateTime(1983, 6, 1, 19, 4, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_display_id",
                table: "screenings",
                column: "display_id");

            migrationBuilder.AddForeignKey(
                name: "FK_screenings_displays_display_id",
                table: "screenings",
                column: "display_id",
                principalTable: "displays",
                principalColumn: "display_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_screenings_displays_display_id",
                table: "screenings");

            migrationBuilder.DropTable(
                name: "displays");

            migrationBuilder.DropIndex(
                name: "IX_screenings_display_id",
                table: "screenings");

            migrationBuilder.RenameColumn(
                name: "display_id",
                table: "screenings",
                newName: "screen_numbers");

            migrationBuilder.AddColumn<int>(
                name: "capacity",
                table: "screenings",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 1,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 32, new DateTime(1989, 3, 28, 1, 4, 24, 0, DateTimeKind.Utc), new DateTime(1989, 4, 26, 5, 4, 24, 0, DateTimeKind.Utc), new DateTime(1989, 3, 28, 1, 4, 24, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 2,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 52, new DateTime(1959, 7, 7, 8, 20, 55, 0, DateTimeKind.Utc), new DateTime(1959, 7, 12, 13, 20, 55, 0, DateTimeKind.Utc), new DateTime(1959, 7, 7, 8, 20, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 3,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 72, new DateTime(1992, 7, 15, 17, 7, 33, 0, DateTimeKind.Utc), new DateTime(1992, 8, 8, 19, 7, 33, 0, DateTimeKind.Utc), new DateTime(1992, 7, 15, 17, 7, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 4,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 25, new DateTime(2000, 10, 3, 0, 9, 48, 0, DateTimeKind.Utc), new DateTime(2000, 10, 27, 2, 9, 48, 0, DateTimeKind.Utc), new DateTime(2000, 10, 3, 0, 9, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 5,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 52, new DateTime(2004, 11, 5, 5, 12, 45, 0, DateTimeKind.Utc), new DateTime(2004, 12, 2, 8, 12, 45, 0, DateTimeKind.Utc), new DateTime(2004, 11, 5, 5, 12, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 6,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 23, new DateTime(1963, 2, 24, 13, 54, 17, 0, DateTimeKind.Utc), new DateTime(1963, 2, 27, 19, 54, 17, 0, DateTimeKind.Utc), new DateTime(1963, 2, 24, 13, 54, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 7,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 15, new DateTime(1963, 8, 13, 11, 32, 9, 0, DateTimeKind.Utc), new DateTime(1963, 8, 14, 20, 32, 9, 0, DateTimeKind.Utc), new DateTime(1963, 8, 13, 11, 32, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 8,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 23, new DateTime(2007, 6, 4, 12, 30, 30, 0, DateTimeKind.Utc), new DateTime(2007, 6, 9, 16, 30, 30, 0, DateTimeKind.Utc), new DateTime(2007, 6, 4, 12, 30, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 9,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 42, new DateTime(2008, 4, 10, 2, 14, 35, 0, DateTimeKind.Utc), new DateTime(2008, 5, 9, 6, 14, 35, 0, DateTimeKind.Utc), new DateTime(2008, 4, 10, 2, 14, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 10,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 72, new DateTime(1929, 8, 2, 3, 13, 9, 0, DateTimeKind.Utc), new DateTime(1929, 8, 26, 11, 13, 9, 0, DateTimeKind.Utc), new DateTime(1929, 8, 2, 3, 13, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 11,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 32, new DateTime(1930, 3, 11, 11, 50, 10, 0, DateTimeKind.Utc), new DateTime(1930, 3, 31, 15, 50, 10, 0, DateTimeKind.Utc), new DateTime(1930, 3, 11, 11, 50, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 12,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 38, new DateTime(1910, 3, 20, 5, 12, 25, 0, DateTimeKind.Utc), new DateTime(1910, 4, 12, 6, 12, 25, 0, DateTimeKind.Utc), new DateTime(1910, 3, 20, 5, 12, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 13,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 67, new DateTime(1912, 4, 10, 22, 8, 41, 0, DateTimeKind.Utc), new DateTime(1912, 4, 29, 17, 8, 41, 0, DateTimeKind.Utc), new DateTime(1912, 4, 10, 22, 8, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 14,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 38, new DateTime(1985, 4, 12, 15, 20, 50, 0, DateTimeKind.Utc), new DateTime(1985, 4, 27, 18, 20, 50, 0, DateTimeKind.Utc), new DateTime(1985, 4, 12, 15, 20, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 15,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 42, new DateTime(1949, 5, 27, 5, 17, 11, 0, DateTimeKind.Utc), new DateTime(1949, 6, 22, 21, 17, 11, 0, DateTimeKind.Utc), new DateTime(1949, 5, 27, 5, 17, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 16,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 79, new DateTime(1926, 5, 14, 6, 12, 15, 0, DateTimeKind.Utc), new DateTime(1926, 5, 19, 10, 12, 15, 0, DateTimeKind.Utc), new DateTime(1926, 5, 14, 6, 12, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 17,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 79, new DateTime(1998, 5, 18, 22, 26, 18, 0, DateTimeKind.Utc), new DateTime(1998, 6, 11, 20, 26, 18, 0, DateTimeKind.Utc), new DateTime(1998, 5, 18, 22, 26, 18, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 18,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 67, new DateTime(2002, 7, 5, 22, 59, 53, 0, DateTimeKind.Utc), new DateTime(2002, 7, 20, 18, 59, 53, 0, DateTimeKind.Utc), new DateTime(2002, 7, 5, 22, 59, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 19,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 29, new DateTime(1930, 4, 17, 9, 27, 55, 0, DateTimeKind.Utc), new DateTime(1930, 5, 3, 9, 27, 55, 0, DateTimeKind.Utc), new DateTime(1930, 4, 17, 9, 27, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 20,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 67, new DateTime(1991, 7, 26, 12, 4, 25, 0, DateTimeKind.Utc), new DateTime(1991, 8, 9, 19, 4, 25, 0, DateTimeKind.Utc), new DateTime(1991, 7, 26, 12, 4, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 21,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 24, new DateTime(1929, 10, 26, 12, 0, 50, 0, DateTimeKind.Utc), new DateTime(1929, 11, 15, 0, 0, 50, 0, DateTimeKind.Utc), new DateTime(1929, 10, 26, 12, 0, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 22,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 79, new DateTime(2019, 10, 4, 1, 7, 45, 0, DateTimeKind.Utc), new DateTime(2019, 10, 15, 13, 7, 45, 0, DateTimeKind.Utc), new DateTime(2019, 10, 4, 1, 7, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 23,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 73, new DateTime(1904, 9, 25, 2, 49, 42, 0, DateTimeKind.Utc), new DateTime(1904, 10, 6, 11, 49, 42, 0, DateTimeKind.Utc), new DateTime(1904, 9, 25, 2, 49, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 24,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 73, new DateTime(1986, 6, 13, 0, 59, 57, 0, DateTimeKind.Utc), new DateTime(1986, 6, 26, 22, 59, 57, 0, DateTimeKind.Utc), new DateTime(1986, 6, 13, 0, 59, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 25,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 62, new DateTime(1974, 10, 26, 13, 33, 35, 0, DateTimeKind.Utc), new DateTime(1974, 10, 28, 22, 33, 35, 0, DateTimeKind.Utc), new DateTime(1974, 10, 26, 13, 33, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 26,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 52, new DateTime(1941, 3, 9, 5, 41, 34, 0, DateTimeKind.Utc), new DateTime(1941, 3, 15, 8, 41, 34, 0, DateTimeKind.Utc), new DateTime(1941, 3, 9, 5, 41, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 27,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 73, new DateTime(1949, 4, 18, 7, 58, 9, 0, DateTimeKind.Utc), new DateTime(1949, 4, 25, 10, 58, 9, 0, DateTimeKind.Utc), new DateTime(1949, 4, 18, 7, 58, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 28,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 23, new DateTime(1995, 2, 6, 19, 19, 42, 0, DateTimeKind.Utc), new DateTime(1995, 3, 5, 19, 19, 42, 0, DateTimeKind.Utc), new DateTime(1995, 2, 6, 19, 19, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 29,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 15, new DateTime(1905, 8, 23, 5, 49, 35, 0, DateTimeKind.Utc), new DateTime(1905, 9, 15, 15, 49, 35, 0, DateTimeKind.Utc), new DateTime(1905, 8, 23, 5, 49, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 30,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 32, new DateTime(2023, 3, 25, 22, 54, 9, 0, DateTimeKind.Utc), new DateTime(2023, 4, 16, 16, 54, 9, 0, DateTimeKind.Utc), new DateTime(2023, 3, 25, 22, 54, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 31,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 24, new DateTime(2016, 5, 8, 12, 43, 51, 0, DateTimeKind.Utc), new DateTime(2016, 6, 5, 21, 43, 51, 0, DateTimeKind.Utc), new DateTime(2016, 5, 8, 12, 43, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 32,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 73, new DateTime(1953, 10, 2, 6, 41, 30, 0, DateTimeKind.Utc), new DateTime(1953, 10, 11, 0, 41, 30, 0, DateTimeKind.Utc), new DateTime(1953, 10, 2, 6, 41, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 33,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 52, new DateTime(1910, 5, 15, 6, 16, 48, 0, DateTimeKind.Utc), new DateTime(1910, 5, 15, 11, 16, 48, 0, DateTimeKind.Utc), new DateTime(1910, 5, 15, 6, 16, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 34,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 52, new DateTime(1995, 9, 15, 4, 29, 54, 0, DateTimeKind.Utc), new DateTime(1995, 9, 16, 15, 29, 54, 0, DateTimeKind.Utc), new DateTime(1995, 9, 15, 4, 29, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 35,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 23, new DateTime(1999, 2, 13, 17, 13, 28, 0, DateTimeKind.Utc), new DateTime(1999, 3, 1, 18, 13, 28, 0, DateTimeKind.Utc), new DateTime(1999, 2, 13, 17, 13, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 36,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 22, new DateTime(1987, 6, 12, 10, 22, 33, 0, DateTimeKind.Utc), new DateTime(1987, 7, 1, 10, 22, 33, 0, DateTimeKind.Utc), new DateTime(1987, 6, 12, 10, 22, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 37,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 8, new DateTime(2010, 3, 13, 8, 23, 29, 0, DateTimeKind.Utc), new DateTime(2010, 3, 20, 21, 23, 29, 0, DateTimeKind.Utc), new DateTime(2010, 3, 13, 8, 23, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 38,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 22, new DateTime(1980, 9, 27, 6, 6, 27, 0, DateTimeKind.Utc), new DateTime(1980, 10, 6, 10, 6, 27, 0, DateTimeKind.Utc), new DateTime(1980, 9, 27, 6, 6, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 39,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 24, new DateTime(1907, 8, 27, 1, 10, 7, 0, DateTimeKind.Utc), new DateTime(1907, 8, 27, 9, 10, 7, 0, DateTimeKind.Utc), new DateTime(1907, 8, 27, 1, 10, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 40,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 23, new DateTime(1979, 9, 26, 8, 44, 36, 0, DateTimeKind.Utc), new DateTime(1979, 10, 12, 0, 44, 36, 0, DateTimeKind.Utc), new DateTime(1979, 9, 26, 8, 44, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 41,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 42, new DateTime(1951, 8, 17, 14, 34, 13, 0, DateTimeKind.Utc), new DateTime(1951, 8, 29, 7, 34, 13, 0, DateTimeKind.Utc), new DateTime(1951, 8, 17, 14, 34, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 42,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 29, new DateTime(1911, 8, 28, 22, 22, 2, 0, DateTimeKind.Utc), new DateTime(1911, 9, 27, 10, 22, 2, 0, DateTimeKind.Utc), new DateTime(1911, 8, 28, 22, 22, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 43,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 52, new DateTime(1942, 5, 11, 0, 32, 42, 0, DateTimeKind.Utc), new DateTime(1942, 5, 12, 21, 32, 42, 0, DateTimeKind.Utc), new DateTime(1942, 5, 11, 0, 32, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 44,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 23, new DateTime(2020, 6, 1, 23, 39, 31, 0, DateTimeKind.Utc), new DateTime(2020, 6, 17, 2, 39, 31, 0, DateTimeKind.Utc), new DateTime(2020, 6, 1, 23, 39, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 45,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 32, new DateTime(1965, 7, 9, 6, 48, 38, 0, DateTimeKind.Utc), new DateTime(1965, 7, 31, 14, 48, 38, 0, DateTimeKind.Utc), new DateTime(1965, 7, 9, 6, 48, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 46,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 32, new DateTime(1978, 6, 14, 20, 55, 41, 0, DateTimeKind.Utc), new DateTime(1978, 6, 18, 18, 55, 41, 0, DateTimeKind.Utc), new DateTime(1978, 6, 14, 20, 55, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 47,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 92, new DateTime(2010, 1, 6, 17, 10, 27, 0, DateTimeKind.Utc), new DateTime(2010, 2, 5, 13, 10, 27, 0, DateTimeKind.Utc), new DateTime(2010, 1, 6, 17, 10, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 48,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 73, new DateTime(1955, 2, 10, 21, 43, 45, 0, DateTimeKind.Utc), new DateTime(1955, 3, 6, 22, 43, 45, 0, DateTimeKind.Utc), new DateTime(1955, 2, 10, 21, 43, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 49,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 62, new DateTime(1991, 7, 6, 5, 23, 13, 0, DateTimeKind.Utc), new DateTime(1991, 7, 20, 21, 23, 13, 0, DateTimeKind.Utc), new DateTime(1991, 7, 6, 5, 23, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 50,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 42, new DateTime(1972, 5, 2, 2, 3, 56, 0, DateTimeKind.Utc), new DateTime(1972, 5, 31, 10, 3, 56, 0, DateTimeKind.Utc), new DateTime(1972, 5, 2, 2, 3, 56, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 51,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 73, new DateTime(2016, 10, 24, 8, 19, 51, 0, DateTimeKind.Utc), new DateTime(2016, 11, 13, 11, 19, 51, 0, DateTimeKind.Utc), new DateTime(2016, 10, 24, 8, 19, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 52,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 62, new DateTime(1967, 6, 15, 16, 9, 28, 0, DateTimeKind.Utc), new DateTime(1967, 7, 13, 1, 9, 28, 0, DateTimeKind.Utc), new DateTime(1967, 6, 15, 16, 9, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 53,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 29, new DateTime(1961, 3, 10, 13, 31, 32, 0, DateTimeKind.Utc), new DateTime(1961, 4, 7, 14, 31, 32, 0, DateTimeKind.Utc), new DateTime(1961, 3, 10, 13, 31, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 54,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 38, new DateTime(1921, 7, 26, 12, 32, 12, 0, DateTimeKind.Utc), new DateTime(1921, 7, 27, 4, 32, 12, 0, DateTimeKind.Utc), new DateTime(1921, 7, 26, 12, 32, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 55,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 38, new DateTime(1952, 5, 4, 6, 15, 29, 0, DateTimeKind.Utc), new DateTime(1952, 5, 17, 5, 15, 29, 0, DateTimeKind.Utc), new DateTime(1952, 5, 4, 6, 15, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 56,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 62, new DateTime(1978, 9, 1, 6, 47, 21, 0, DateTimeKind.Utc), new DateTime(1978, 9, 23, 11, 47, 21, 0, DateTimeKind.Utc), new DateTime(1978, 9, 1, 6, 47, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 57,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 38, new DateTime(1977, 2, 23, 11, 21, 13, 0, DateTimeKind.Utc), new DateTime(1977, 3, 7, 8, 21, 13, 0, DateTimeKind.Utc), new DateTime(1977, 2, 23, 11, 21, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 58,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 52, new DateTime(1929, 1, 13, 17, 43, 8, 0, DateTimeKind.Utc), new DateTime(1929, 1, 22, 12, 43, 8, 0, DateTimeKind.Utc), new DateTime(1929, 1, 13, 17, 43, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 59,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 52, new DateTime(2011, 1, 26, 12, 54, 26, 0, DateTimeKind.Utc), new DateTime(2011, 2, 1, 3, 54, 26, 0, DateTimeKind.Utc), new DateTime(2011, 1, 26, 12, 54, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 60,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 38, new DateTime(1901, 5, 8, 15, 56, 54, 0, DateTimeKind.Utc), new DateTime(1901, 6, 7, 11, 56, 54, 0, DateTimeKind.Utc), new DateTime(1901, 5, 8, 15, 56, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 61,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 62, new DateTime(1988, 4, 7, 0, 4, 21, 0, DateTimeKind.Utc), new DateTime(1988, 4, 19, 15, 4, 21, 0, DateTimeKind.Utc), new DateTime(1988, 4, 7, 0, 4, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 62,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 25, new DateTime(1958, 3, 13, 23, 55, 26, 0, DateTimeKind.Utc), new DateTime(1958, 3, 31, 13, 55, 26, 0, DateTimeKind.Utc), new DateTime(1958, 3, 13, 23, 55, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 63,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 67, new DateTime(1992, 8, 8, 16, 17, 31, 0, DateTimeKind.Utc), new DateTime(1992, 9, 3, 20, 17, 31, 0, DateTimeKind.Utc), new DateTime(1992, 8, 8, 16, 17, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 64,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 67, new DateTime(1994, 8, 20, 23, 22, 13, 0, DateTimeKind.Utc), new DateTime(1994, 9, 15, 22, 22, 13, 0, DateTimeKind.Utc), new DateTime(1994, 8, 20, 23, 22, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 65,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 32, new DateTime(1973, 2, 26, 13, 14, 23, 0, DateTimeKind.Utc), new DateTime(1973, 3, 24, 14, 14, 23, 0, DateTimeKind.Utc), new DateTime(1973, 2, 26, 13, 14, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 66,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 79, new DateTime(1909, 11, 5, 21, 46, 5, 0, DateTimeKind.Utc), new DateTime(1909, 11, 9, 22, 46, 5, 0, DateTimeKind.Utc), new DateTime(1909, 11, 5, 21, 46, 5, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 67,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 92, new DateTime(2022, 3, 27, 2, 15, 29, 0, DateTimeKind.Utc), new DateTime(2022, 4, 19, 5, 15, 29, 0, DateTimeKind.Utc), new DateTime(2022, 3, 27, 2, 15, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 68,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 62, new DateTime(1985, 11, 3, 11, 46, 11, 0, DateTimeKind.Utc), new DateTime(1985, 11, 29, 6, 46, 11, 0, DateTimeKind.Utc), new DateTime(1985, 11, 3, 11, 46, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 69,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 38, new DateTime(1920, 4, 3, 17, 52, 13, 0, DateTimeKind.Utc), new DateTime(1920, 4, 25, 5, 52, 13, 0, DateTimeKind.Utc), new DateTime(1920, 4, 3, 17, 52, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 70,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 92, new DateTime(1925, 8, 26, 0, 25, 57, 0, DateTimeKind.Utc), new DateTime(1925, 9, 8, 12, 25, 57, 0, DateTimeKind.Utc), new DateTime(1925, 8, 26, 0, 25, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 71,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 62, new DateTime(1956, 10, 28, 1, 52, 55, 0, DateTimeKind.Utc), new DateTime(1956, 11, 25, 19, 52, 55, 0, DateTimeKind.Utc), new DateTime(1956, 10, 28, 1, 52, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 72,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 72, new DateTime(1933, 10, 27, 4, 42, 2, 0, DateTimeKind.Utc), new DateTime(1933, 11, 24, 6, 42, 2, 0, DateTimeKind.Utc), new DateTime(1933, 10, 27, 4, 42, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 73,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 42, new DateTime(1969, 8, 13, 5, 18, 27, 0, DateTimeKind.Utc), new DateTime(1969, 8, 16, 19, 18, 27, 0, DateTimeKind.Utc), new DateTime(1969, 8, 13, 5, 18, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 74,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 67, new DateTime(1913, 2, 10, 16, 23, 53, 0, DateTimeKind.Utc), new DateTime(1913, 2, 23, 8, 23, 53, 0, DateTimeKind.Utc), new DateTime(1913, 2, 10, 16, 23, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 75,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 52, new DateTime(1934, 4, 4, 22, 39, 2, 0, DateTimeKind.Utc), new DateTime(1934, 4, 20, 12, 39, 2, 0, DateTimeKind.Utc), new DateTime(1934, 4, 4, 22, 39, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 76,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 52, new DateTime(1922, 11, 24, 0, 37, 20, 0, DateTimeKind.Utc), new DateTime(1922, 12, 11, 4, 37, 20, 0, DateTimeKind.Utc), new DateTime(1922, 11, 24, 0, 37, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 77,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 8, new DateTime(1959, 7, 2, 4, 10, 54, 0, DateTimeKind.Utc), new DateTime(1959, 7, 28, 9, 10, 54, 0, DateTimeKind.Utc), new DateTime(1959, 7, 2, 4, 10, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 78,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 25, new DateTime(1930, 1, 18, 1, 10, 12, 0, DateTimeKind.Utc), new DateTime(1930, 1, 31, 15, 10, 12, 0, DateTimeKind.Utc), new DateTime(1930, 1, 18, 1, 10, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 79,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 24, new DateTime(1996, 1, 12, 10, 52, 17, 0, DateTimeKind.Utc), new DateTime(1996, 2, 5, 9, 52, 17, 0, DateTimeKind.Utc), new DateTime(1996, 1, 12, 10, 52, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 80,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 38, new DateTime(1974, 9, 15, 2, 46, 31, 0, DateTimeKind.Utc), new DateTime(1974, 9, 18, 8, 46, 31, 0, DateTimeKind.Utc), new DateTime(1974, 9, 15, 2, 46, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 81,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 52, new DateTime(2001, 4, 6, 21, 58, 44, 0, DateTimeKind.Utc), new DateTime(2001, 4, 29, 11, 58, 44, 0, DateTimeKind.Utc), new DateTime(2001, 4, 6, 21, 58, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 82,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 8, new DateTime(1926, 7, 2, 2, 43, 40, 0, DateTimeKind.Utc), new DateTime(1926, 7, 15, 19, 43, 40, 0, DateTimeKind.Utc), new DateTime(1926, 7, 2, 2, 43, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 83,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 72, new DateTime(1950, 11, 27, 10, 26, 22, 0, DateTimeKind.Utc), new DateTime(1950, 12, 20, 1, 26, 22, 0, DateTimeKind.Utc), new DateTime(1950, 11, 27, 10, 26, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 84,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 72, new DateTime(1933, 3, 5, 21, 9, 39, 0, DateTimeKind.Utc), new DateTime(1933, 3, 8, 17, 9, 39, 0, DateTimeKind.Utc), new DateTime(1933, 3, 5, 21, 9, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 85,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 15, new DateTime(1976, 9, 3, 12, 24, 51, 0, DateTimeKind.Utc), new DateTime(1976, 9, 27, 21, 24, 51, 0, DateTimeKind.Utc), new DateTime(1976, 9, 3, 12, 24, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 86,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 22, new DateTime(2004, 5, 24, 12, 21, 49, 0, DateTimeKind.Utc), new DateTime(2004, 6, 3, 21, 21, 49, 0, DateTimeKind.Utc), new DateTime(2004, 5, 24, 12, 21, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 87,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 22, new DateTime(1987, 5, 1, 21, 49, 37, 0, DateTimeKind.Utc), new DateTime(1987, 5, 23, 7, 49, 37, 0, DateTimeKind.Utc), new DateTime(1987, 5, 1, 21, 49, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 88,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 73, new DateTime(1918, 8, 8, 17, 1, 55, 0, DateTimeKind.Utc), new DateTime(1918, 8, 20, 19, 1, 55, 0, DateTimeKind.Utc), new DateTime(1918, 8, 8, 17, 1, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 89,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 38, new DateTime(1940, 2, 10, 3, 49, 32, 0, DateTimeKind.Utc), new DateTime(1940, 3, 6, 17, 49, 32, 0, DateTimeKind.Utc), new DateTime(1940, 2, 10, 3, 49, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 90,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 52, new DateTime(1944, 10, 6, 13, 16, 13, 0, DateTimeKind.Utc), new DateTime(1944, 10, 15, 21, 16, 13, 0, DateTimeKind.Utc), new DateTime(1944, 10, 6, 13, 16, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 91,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 73, new DateTime(1980, 8, 5, 4, 15, 20, 0, DateTimeKind.Utc), new DateTime(1980, 9, 3, 13, 15, 20, 0, DateTimeKind.Utc), new DateTime(1980, 8, 5, 4, 15, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 92,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 15, new DateTime(2005, 10, 17, 3, 44, 4, 0, DateTimeKind.Utc), new DateTime(2005, 10, 30, 21, 44, 4, 0, DateTimeKind.Utc), new DateTime(2005, 10, 17, 3, 44, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 93,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 29, new DateTime(1942, 5, 12, 13, 45, 28, 0, DateTimeKind.Utc), new DateTime(1942, 5, 31, 8, 45, 28, 0, DateTimeKind.Utc), new DateTime(1942, 5, 12, 13, 45, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 94,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 25, new DateTime(1945, 10, 21, 3, 12, 14, 0, DateTimeKind.Utc), new DateTime(1945, 11, 2, 23, 12, 14, 0, DateTimeKind.Utc), new DateTime(1945, 10, 21, 3, 12, 14, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 95,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 67, new DateTime(1966, 8, 16, 6, 8, 27, 0, DateTimeKind.Utc), new DateTime(1966, 8, 21, 17, 8, 27, 0, DateTimeKind.Utc), new DateTime(1966, 8, 16, 6, 8, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 96,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 23, new DateTime(1976, 2, 3, 19, 13, 7, 0, DateTimeKind.Utc), new DateTime(1976, 2, 24, 14, 13, 7, 0, DateTimeKind.Utc), new DateTime(1976, 2, 3, 19, 13, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 97,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 42, new DateTime(1956, 11, 12, 22, 53, 7, 0, DateTimeKind.Utc), new DateTime(1956, 12, 8, 22, 53, 7, 0, DateTimeKind.Utc), new DateTime(1956, 11, 12, 22, 53, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 98,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 62, new DateTime(1941, 3, 12, 5, 46, 25, 0, DateTimeKind.Utc), new DateTime(1941, 3, 25, 18, 46, 25, 0, DateTimeKind.Utc), new DateTime(1941, 3, 12, 5, 46, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 99,
                columns: new[] { "capacity", "created_at", "startsAt", "updated_at" },
                values: new object[] { 92, new DateTime(1916, 10, 5, 17, 10, 23, 0, DateTimeKind.Utc), new DateTime(1916, 10, 20, 17, 10, 23, 0, DateTimeKind.Utc), new DateTime(1916, 10, 5, 17, 10, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 6, 14, 22, 38, 33, 0, DateTimeKind.Utc), new DateTime(1962, 6, 14, 22, 38, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1997, 7, 22, 3, 30, 35, 0, DateTimeKind.Utc), new DateTime(1997, 7, 22, 3, 30, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 6, 5, 6, 5, 46, 0, DateTimeKind.Utc), new DateTime(2022, 6, 5, 6, 5, 46, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1907, 5, 28, 14, 48, 59, 0, DateTimeKind.Utc), new DateTime(1907, 5, 28, 14, 48, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 4, 26, 3, 8, 18, 0, DateTimeKind.Utc), new DateTime(2002, 4, 26, 3, 8, 18, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1936, 10, 28, 16, 17, 43, 0, DateTimeKind.Utc), new DateTime(1936, 10, 28, 16, 17, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 6, 10, 20, 9, 20, 0, DateTimeKind.Utc), new DateTime(1979, 6, 10, 20, 9, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1943, 3, 20, 20, 16, 14, 0, DateTimeKind.Utc), new DateTime(1943, 3, 20, 20, 16, 14, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1930, 10, 21, 9, 38, 44, 0, DateTimeKind.Utc), new DateTime(1930, 10, 21, 9, 38, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 10, 20, 11, 6, 21, 0, DateTimeKind.Utc), new DateTime(1950, 10, 20, 11, 6, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 8, 12, 10, 49, 37, 0, DateTimeKind.Utc), new DateTime(1977, 8, 12, 10, 49, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1975, 4, 7, 10, 37, 33, 0, DateTimeKind.Utc), new DateTime(1975, 4, 7, 10, 37, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1953, 3, 8, 15, 14, 36, 0, DateTimeKind.Utc), new DateTime(1953, 3, 8, 15, 14, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1937, 11, 1, 16, 52, 16, 0, DateTimeKind.Utc), new DateTime(1937, 11, 1, 16, 52, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1970, 11, 7, 5, 17, 23, 0, DateTimeKind.Utc), new DateTime(1970, 11, 7, 5, 17, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1903, 2, 13, 23, 13, 30, 0, DateTimeKind.Utc), new DateTime(1903, 2, 13, 23, 13, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2016, 11, 11, 1, 13, 59, 0, DateTimeKind.Utc), new DateTime(2016, 11, 11, 1, 13, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 7, 4, 56, 25, 0, DateTimeKind.Utc), new DateTime(2024, 9, 7, 4, 56, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1958, 9, 19, 1, 11, 7, 0, DateTimeKind.Utc), new DateTime(1958, 9, 19, 1, 11, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1940, 11, 22, 3, 52, 53, 0, DateTimeKind.Utc), new DateTime(1940, 11, 22, 3, 52, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1945, 5, 28, 20, 23, 29, 0, DateTimeKind.Utc), new DateTime(1945, 5, 28, 20, 23, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1913, 6, 28, 18, 42, 19, 0, DateTimeKind.Utc), new DateTime(1913, 6, 28, 18, 42, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1926, 3, 22, 0, 41, 3, 0, DateTimeKind.Utc), new DateTime(1926, 3, 22, 0, 41, 3, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 25,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 5, 28, 19, 44, 30, 0, DateTimeKind.Utc), new DateTime(1902, 5, 28, 19, 44, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 26,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1990, 11, 27, 7, 38, 17, 0, DateTimeKind.Utc), new DateTime(1990, 11, 27, 7, 38, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 27,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1990, 9, 2, 11, 42, 50, 0, DateTimeKind.Utc), new DateTime(1990, 9, 2, 11, 42, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 28,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 2, 12, 18, 3, 28, 0, DateTimeKind.Utc), new DateTime(2023, 2, 12, 18, 3, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 29,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1952, 8, 2, 8, 51, 57, 0, DateTimeKind.Utc), new DateTime(1952, 8, 2, 8, 51, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 30,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1943, 4, 7, 17, 6, 29, 0, DateTimeKind.Utc), new DateTime(1943, 4, 7, 17, 6, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 31,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2013, 7, 18, 11, 7, 26, 0, DateTimeKind.Utc), new DateTime(2013, 7, 18, 11, 7, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 32,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1965, 9, 24, 17, 2, 54, 0, DateTimeKind.Utc), new DateTime(1965, 9, 24, 17, 2, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 33,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1934, 9, 15, 22, 2, 33, 0, DateTimeKind.Utc), new DateTime(1934, 9, 15, 22, 2, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 34,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 4, 10, 12, 23, 2, 0, DateTimeKind.Utc), new DateTime(1979, 4, 10, 12, 23, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 35,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1953, 5, 3, 0, 56, 20, 0, DateTimeKind.Utc), new DateTime(1953, 5, 3, 0, 56, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 36,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1903, 1, 20, 13, 34, 8, 0, DateTimeKind.Utc), new DateTime(1903, 1, 20, 13, 34, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 37,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1923, 6, 1, 23, 13, 15, 0, DateTimeKind.Utc), new DateTime(1923, 6, 1, 23, 13, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 38,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1980, 8, 19, 3, 3, 6, 0, DateTimeKind.Utc), new DateTime(1980, 8, 19, 3, 3, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 39,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1951, 5, 7, 16, 4, 49, 0, DateTimeKind.Utc), new DateTime(1951, 5, 7, 16, 4, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 40,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1919, 5, 5, 14, 2, 44, 0, DateTimeKind.Utc), new DateTime(1919, 5, 5, 14, 2, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 41,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1939, 6, 25, 11, 40, 1, 0, DateTimeKind.Utc), new DateTime(1939, 6, 25, 11, 40, 1, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 42,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1926, 9, 5, 9, 43, 32, 0, DateTimeKind.Utc), new DateTime(1926, 9, 5, 9, 43, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 43,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1966, 8, 2, 1, 51, 40, 0, DateTimeKind.Utc), new DateTime(1966, 8, 2, 1, 51, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 44,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1944, 4, 10, 23, 35, 30, 0, DateTimeKind.Utc), new DateTime(1944, 4, 10, 23, 35, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 45,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1909, 4, 27, 20, 22, 10, 0, DateTimeKind.Utc), new DateTime(1909, 4, 27, 20, 22, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 46,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 13, 6, 39, 41, 0, DateTimeKind.Utc), new DateTime(2023, 7, 13, 6, 39, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 47,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1947, 2, 2, 15, 56, 18, 0, DateTimeKind.Utc), new DateTime(1947, 2, 2, 15, 56, 18, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 48,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2018, 1, 21, 16, 9, 25, 0, DateTimeKind.Utc), new DateTime(2018, 1, 21, 16, 9, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 49,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1995, 2, 15, 11, 13, 45, 0, DateTimeKind.Utc), new DateTime(1995, 2, 15, 11, 13, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 50,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 4, 27, 8, 23, 19, 0, DateTimeKind.Utc), new DateTime(1950, 4, 27, 8, 23, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 51,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1908, 5, 11, 23, 23, 7, 0, DateTimeKind.Utc), new DateTime(1908, 5, 11, 23, 23, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 52,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1909, 3, 28, 8, 40, 41, 0, DateTimeKind.Utc), new DateTime(1909, 3, 28, 8, 40, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 53,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 8, 10, 0, 2, 33, 0, DateTimeKind.Utc), new DateTime(1979, 8, 10, 0, 2, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 54,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1997, 5, 6, 12, 5, 17, 0, DateTimeKind.Utc), new DateTime(1997, 5, 6, 12, 5, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 55,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1981, 6, 11, 16, 51, 19, 0, DateTimeKind.Utc), new DateTime(1981, 6, 11, 16, 51, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 56,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1992, 1, 23, 17, 34, 34, 0, DateTimeKind.Utc), new DateTime(1992, 1, 23, 17, 34, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 57,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2018, 11, 18, 14, 36, 53, 0, DateTimeKind.Utc), new DateTime(2018, 11, 18, 14, 36, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 58,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1951, 5, 12, 19, 50, 30, 0, DateTimeKind.Utc), new DateTime(1951, 5, 12, 19, 50, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 59,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1951, 5, 9, 9, 34, 59, 0, DateTimeKind.Utc), new DateTime(1951, 5, 9, 9, 34, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 60,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1914, 7, 8, 1, 19, 53, 0, DateTimeKind.Utc), new DateTime(1914, 7, 8, 1, 19, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 61,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1992, 5, 12, 16, 37, 38, 0, DateTimeKind.Utc), new DateTime(1992, 5, 12, 16, 37, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 62,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2013, 11, 5, 18, 4, 4, 0, DateTimeKind.Utc), new DateTime(2013, 11, 5, 18, 4, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 63,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2014, 3, 22, 7, 6, 41, 0, DateTimeKind.Utc), new DateTime(2014, 3, 22, 7, 6, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 64,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2008, 10, 19, 20, 16, 28, 0, DateTimeKind.Utc), new DateTime(2008, 10, 19, 20, 16, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 65,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1901, 4, 13, 19, 34, 0, 0, DateTimeKind.Utc), new DateTime(1901, 4, 13, 19, 34, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 66,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1935, 10, 18, 17, 51, 12, 0, DateTimeKind.Utc), new DateTime(1935, 10, 18, 17, 51, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 67,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1959, 9, 22, 18, 55, 54, 0, DateTimeKind.Utc), new DateTime(1959, 9, 22, 18, 55, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 68,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1944, 8, 10, 5, 28, 23, 0, DateTimeKind.Utc), new DateTime(1944, 8, 10, 5, 28, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 69,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1924, 10, 13, 13, 12, 30, 0, DateTimeKind.Utc), new DateTime(1924, 10, 13, 13, 12, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 70,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1924, 10, 4, 22, 38, 16, 0, DateTimeKind.Utc), new DateTime(1924, 10, 4, 22, 38, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 71,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1921, 2, 10, 3, 28, 11, 0, DateTimeKind.Utc), new DateTime(1921, 2, 10, 3, 28, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 72,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1955, 2, 10, 13, 49, 21, 0, DateTimeKind.Utc), new DateTime(1955, 2, 10, 13, 49, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 73,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2014, 2, 26, 18, 29, 37, 0, DateTimeKind.Utc), new DateTime(2014, 2, 26, 18, 29, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 74,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1916, 9, 25, 1, 35, 45, 0, DateTimeKind.Utc), new DateTime(1916, 9, 25, 1, 35, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 75,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1967, 8, 19, 2, 32, 57, 0, DateTimeKind.Utc), new DateTime(1967, 8, 19, 2, 32, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 76,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1908, 7, 3, 12, 35, 48, 0, DateTimeKind.Utc), new DateTime(1908, 7, 3, 12, 35, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 77,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1968, 3, 5, 3, 45, 18, 0, DateTimeKind.Utc), new DateTime(1968, 3, 5, 3, 45, 18, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 78,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1905, 7, 1, 2, 40, 6, 0, DateTimeKind.Utc), new DateTime(1905, 7, 1, 2, 40, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 79,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1975, 5, 12, 12, 47, 49, 0, DateTimeKind.Utc), new DateTime(1975, 5, 12, 12, 47, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 80,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1948, 2, 15, 14, 35, 45, 0, DateTimeKind.Utc), new DateTime(1948, 2, 15, 14, 35, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 81,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 4, 18, 8, 29, 16, 0, DateTimeKind.Utc), new DateTime(1964, 4, 18, 8, 29, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 82,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1932, 5, 15, 2, 13, 16, 0, DateTimeKind.Utc), new DateTime(1932, 5, 15, 2, 13, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 83,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1956, 1, 2, 13, 1, 57, 0, DateTimeKind.Utc), new DateTime(1956, 1, 2, 13, 1, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 84,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1993, 5, 2, 13, 30, 6, 0, DateTimeKind.Utc), new DateTime(1993, 5, 2, 13, 30, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 85,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1970, 7, 22, 6, 6, 28, 0, DateTimeKind.Utc), new DateTime(1970, 7, 22, 6, 6, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 86,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1933, 11, 18, 9, 36, 24, 0, DateTimeKind.Utc), new DateTime(1933, 11, 18, 9, 36, 24, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 87,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1983, 8, 4, 17, 49, 15, 0, DateTimeKind.Utc), new DateTime(1983, 8, 4, 17, 49, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 88,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1974, 6, 6, 3, 2, 46, 0, DateTimeKind.Utc), new DateTime(1974, 6, 6, 3, 2, 46, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 89,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1995, 10, 3, 13, 50, 8, 0, DateTimeKind.Utc), new DateTime(1995, 10, 3, 13, 50, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 90,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1988, 11, 24, 12, 47, 55, 0, DateTimeKind.Utc), new DateTime(1988, 11, 24, 12, 47, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 91,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 1, 9, 0, 48, 15, 0, DateTimeKind.Utc), new DateTime(1964, 1, 9, 0, 48, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 92,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 1, 12, 15, 54, 19, 0, DateTimeKind.Utc), new DateTime(1979, 1, 12, 15, 54, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 93,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 1, 18, 18, 57, 58, 0, DateTimeKind.Utc), new DateTime(2002, 1, 18, 18, 57, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 94,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2011, 5, 15, 23, 29, 17, 0, DateTimeKind.Utc), new DateTime(2011, 5, 15, 23, 29, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 95,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1948, 8, 4, 11, 41, 38, 0, DateTimeKind.Utc), new DateTime(1948, 8, 4, 11, 41, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 96,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1971, 2, 26, 5, 12, 48, 0, DateTimeKind.Utc), new DateTime(1971, 2, 26, 5, 12, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 97,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 7, 20, 22, 29, 59, 0, DateTimeKind.Utc), new DateTime(2019, 7, 20, 22, 29, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 98,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1945, 2, 26, 18, 45, 48, 0, DateTimeKind.Utc), new DateTime(1945, 2, 26, 18, 45, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 99,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 11, 1, 20, 38, 21, 0, DateTimeKind.Utc), new DateTime(1962, 11, 1, 20, 38, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 100,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1946, 7, 15, 0, 37, 6, 0, DateTimeKind.Utc), new DateTime(1946, 7, 15, 0, 37, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 101,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1914, 2, 10, 18, 4, 45, 0, DateTimeKind.Utc), new DateTime(1914, 2, 10, 18, 4, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 102,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1952, 7, 23, 19, 49, 22, 0, DateTimeKind.Utc), new DateTime(1952, 7, 23, 19, 49, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 103,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1931, 11, 27, 13, 35, 22, 0, DateTimeKind.Utc), new DateTime(1931, 11, 27, 13, 35, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 104,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1945, 8, 27, 7, 58, 45, 0, DateTimeKind.Utc), new DateTime(1945, 8, 27, 7, 58, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 105,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 8, 15, 13, 49, 39, 0, DateTimeKind.Utc), new DateTime(1977, 8, 15, 13, 49, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 106,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1934, 11, 27, 14, 49, 20, 0, DateTimeKind.Utc), new DateTime(1934, 11, 27, 14, 49, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 107,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1978, 7, 2, 3, 19, 8, 0, DateTimeKind.Utc), new DateTime(1978, 7, 2, 3, 19, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 108,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 3, 15, 35, 41, 0, DateTimeKind.Utc), new DateTime(2023, 8, 3, 15, 35, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 109,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1948, 10, 27, 3, 38, 59, 0, DateTimeKind.Utc), new DateTime(1948, 10, 27, 3, 38, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 110,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1917, 9, 5, 14, 8, 20, 0, DateTimeKind.Utc), new DateTime(1917, 9, 5, 14, 8, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 111,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1930, 10, 22, 3, 31, 52, 0, DateTimeKind.Utc), new DateTime(1930, 10, 22, 3, 31, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 112,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1953, 8, 4, 14, 54, 59, 0, DateTimeKind.Utc), new DateTime(1953, 8, 4, 14, 54, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 113,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1939, 3, 9, 19, 19, 17, 0, DateTimeKind.Utc), new DateTime(1939, 3, 9, 19, 19, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 114,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1982, 11, 4, 19, 9, 59, 0, DateTimeKind.Utc), new DateTime(1982, 11, 4, 19, 9, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 115,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1987, 2, 9, 22, 27, 0, 0, DateTimeKind.Utc), new DateTime(1987, 2, 9, 22, 27, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 116,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1919, 1, 14, 16, 54, 26, 0, DateTimeKind.Utc), new DateTime(1919, 1, 14, 16, 54, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 117,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1944, 10, 5, 5, 11, 55, 0, DateTimeKind.Utc), new DateTime(1944, 10, 5, 5, 11, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 118,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1971, 9, 27, 23, 49, 25, 0, DateTimeKind.Utc), new DateTime(1971, 9, 27, 23, 49, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 119,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1984, 4, 14, 21, 55, 8, 0, DateTimeKind.Utc), new DateTime(1984, 4, 14, 21, 55, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 120,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 5, 21, 18, 27, 22, 0, DateTimeKind.Utc), new DateTime(1925, 5, 21, 18, 27, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 121,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1970, 6, 6, 2, 27, 51, 0, DateTimeKind.Utc), new DateTime(1970, 6, 6, 2, 27, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 122,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 7, 9, 20, 26, 29, 0, DateTimeKind.Utc), new DateTime(1962, 7, 9, 20, 26, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 123,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1913, 5, 23, 4, 13, 22, 0, DateTimeKind.Utc), new DateTime(1913, 5, 23, 4, 13, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 124,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1904, 9, 10, 21, 16, 7, 0, DateTimeKind.Utc), new DateTime(1904, 9, 10, 21, 16, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 125,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 4, 4, 8, 28, 27, 0, DateTimeKind.Utc), new DateTime(1964, 4, 4, 8, 28, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 126,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1989, 7, 11, 18, 39, 42, 0, DateTimeKind.Utc), new DateTime(1989, 7, 11, 18, 39, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 127,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1990, 6, 10, 1, 27, 11, 0, DateTimeKind.Utc), new DateTime(1990, 6, 10, 1, 27, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 128,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1912, 9, 26, 23, 45, 29, 0, DateTimeKind.Utc), new DateTime(1912, 9, 26, 23, 45, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 129,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1941, 1, 6, 8, 44, 43, 0, DateTimeKind.Utc), new DateTime(1941, 1, 6, 8, 44, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 130,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1904, 8, 7, 2, 34, 9, 0, DateTimeKind.Utc), new DateTime(1904, 8, 7, 2, 34, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 131,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1992, 2, 5, 20, 8, 52, 0, DateTimeKind.Utc), new DateTime(1992, 2, 5, 20, 8, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 132,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1914, 4, 22, 2, 28, 45, 0, DateTimeKind.Utc), new DateTime(1914, 4, 22, 2, 28, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 133,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1903, 11, 8, 3, 45, 26, 0, DateTimeKind.Utc), new DateTime(1903, 11, 8, 3, 45, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 134,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1926, 6, 15, 14, 59, 28, 0, DateTimeKind.Utc), new DateTime(1926, 6, 15, 14, 59, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 135,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1929, 4, 24, 15, 43, 58, 0, DateTimeKind.Utc), new DateTime(1929, 4, 24, 15, 43, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 136,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1960, 8, 26, 3, 19, 16, 0, DateTimeKind.Utc), new DateTime(1960, 8, 26, 3, 19, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 137,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 3, 19, 0, 51, 24, 0, DateTimeKind.Utc), new DateTime(1902, 3, 19, 0, 51, 24, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 138,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1988, 3, 15, 11, 18, 45, 0, DateTimeKind.Utc), new DateTime(1988, 3, 15, 11, 18, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 139,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1954, 11, 26, 18, 51, 2, 0, DateTimeKind.Utc), new DateTime(1954, 11, 26, 18, 51, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 140,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1978, 2, 6, 16, 36, 47, 0, DateTimeKind.Utc), new DateTime(1978, 2, 6, 16, 36, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 141,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 6, 18, 19, 35, 49, 0, DateTimeKind.Utc), new DateTime(1902, 6, 18, 19, 35, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 142,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 10, 19, 0, 6, 29, 0, DateTimeKind.Utc), new DateTime(2006, 10, 19, 0, 6, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 143,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1996, 3, 20, 2, 54, 44, 0, DateTimeKind.Utc), new DateTime(1996, 3, 20, 2, 54, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 144,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2017, 9, 2, 1, 11, 49, 0, DateTimeKind.Utc), new DateTime(2017, 9, 2, 1, 11, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 145,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1904, 8, 22, 20, 31, 12, 0, DateTimeKind.Utc), new DateTime(1904, 8, 22, 20, 31, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 146,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1910, 4, 19, 21, 59, 21, 0, DateTimeKind.Utc), new DateTime(1910, 4, 19, 21, 59, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 147,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2000, 11, 19, 16, 36, 26, 0, DateTimeKind.Utc), new DateTime(2000, 11, 19, 16, 36, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 148,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1912, 5, 23, 10, 59, 39, 0, DateTimeKind.Utc), new DateTime(1912, 5, 23, 10, 59, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 149,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1943, 6, 7, 10, 43, 49, 0, DateTimeKind.Utc), new DateTime(1943, 6, 7, 10, 43, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 150,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1991, 11, 9, 18, 45, 52, 0, DateTimeKind.Utc), new DateTime(1991, 11, 9, 18, 45, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 151,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1903, 1, 10, 10, 54, 44, 0, DateTimeKind.Utc), new DateTime(1903, 1, 10, 10, 54, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 152,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2004, 10, 7, 7, 18, 59, 0, DateTimeKind.Utc), new DateTime(2004, 10, 7, 7, 18, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 153,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1906, 3, 6, 14, 57, 45, 0, DateTimeKind.Utc), new DateTime(1906, 3, 6, 14, 57, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 154,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1900, 7, 21, 2, 29, 1, 0, DateTimeKind.Utc), new DateTime(1900, 7, 21, 2, 29, 1, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 155,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 18, 20, 9, 1, 0, DateTimeKind.Utc), new DateTime(2023, 8, 18, 20, 9, 1, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 156,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1905, 1, 5, 19, 39, 35, 0, DateTimeKind.Utc), new DateTime(1905, 1, 5, 19, 39, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 157,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1909, 8, 15, 1, 35, 6, 0, DateTimeKind.Utc), new DateTime(1909, 8, 15, 1, 35, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 158,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1954, 1, 6, 5, 22, 29, 0, DateTimeKind.Utc), new DateTime(1954, 1, 6, 5, 22, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 159,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1978, 2, 1, 13, 46, 7, 0, DateTimeKind.Utc), new DateTime(1978, 2, 1, 13, 46, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 160,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1916, 11, 15, 7, 27, 15, 0, DateTimeKind.Utc), new DateTime(1916, 11, 15, 7, 27, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 161,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1912, 11, 21, 4, 16, 17, 0, DateTimeKind.Utc), new DateTime(1912, 11, 21, 4, 16, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 162,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2004, 4, 17, 14, 31, 16, 0, DateTimeKind.Utc), new DateTime(2004, 4, 17, 14, 31, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 163,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 11, 2, 14, 40, 27, 0, DateTimeKind.Utc), new DateTime(1925, 11, 2, 14, 40, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 164,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2001, 9, 8, 3, 12, 1, 0, DateTimeKind.Utc), new DateTime(2001, 9, 8, 3, 12, 1, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 165,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1899, 6, 7, 0, 38, 43, 0, DateTimeKind.Utc), new DateTime(1899, 6, 7, 0, 38, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 166,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1909, 9, 7, 6, 56, 35, 0, DateTimeKind.Utc), new DateTime(1909, 9, 7, 6, 56, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 167,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1945, 3, 22, 21, 23, 6, 0, DateTimeKind.Utc), new DateTime(1945, 3, 22, 21, 23, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 168,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2011, 1, 17, 17, 20, 48, 0, DateTimeKind.Utc), new DateTime(2011, 1, 17, 17, 20, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 169,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1910, 6, 7, 1, 30, 41, 0, DateTimeKind.Utc), new DateTime(1910, 6, 7, 1, 30, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 170,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 11, 23, 16, 11, 45, 0, DateTimeKind.Utc), new DateTime(2022, 11, 23, 16, 11, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 171,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1905, 9, 18, 20, 29, 45, 0, DateTimeKind.Utc), new DateTime(1905, 9, 18, 20, 29, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 172,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1905, 11, 1, 10, 14, 26, 0, DateTimeKind.Utc), new DateTime(1905, 11, 1, 10, 14, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 173,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1986, 10, 11, 4, 15, 9, 0, DateTimeKind.Utc), new DateTime(1986, 10, 11, 4, 15, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 174,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1953, 4, 5, 10, 55, 6, 0, DateTimeKind.Utc), new DateTime(1953, 4, 5, 10, 55, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 175,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1960, 1, 7, 12, 17, 59, 0, DateTimeKind.Utc), new DateTime(1960, 1, 7, 12, 17, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 176,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1999, 8, 2, 0, 50, 34, 0, DateTimeKind.Utc), new DateTime(1999, 8, 2, 0, 50, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 177,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1957, 1, 16, 19, 40, 23, 0, DateTimeKind.Utc), new DateTime(1957, 1, 16, 19, 40, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 178,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1999, 8, 9, 19, 21, 36, 0, DateTimeKind.Utc), new DateTime(1999, 8, 9, 19, 21, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 179,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1938, 9, 20, 15, 15, 54, 0, DateTimeKind.Utc), new DateTime(1938, 9, 20, 15, 15, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 180,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1973, 7, 25, 12, 22, 26, 0, DateTimeKind.Utc), new DateTime(1973, 7, 25, 12, 22, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 181,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 6, 18, 0, 38, 33, 0, DateTimeKind.Utc), new DateTime(1964, 6, 18, 0, 38, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 182,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1946, 8, 2, 19, 41, 13, 0, DateTimeKind.Utc), new DateTime(1946, 8, 2, 19, 41, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 183,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1974, 7, 18, 18, 37, 16, 0, DateTimeKind.Utc), new DateTime(1974, 7, 18, 18, 37, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 184,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2003, 8, 20, 15, 12, 29, 0, DateTimeKind.Utc), new DateTime(2003, 8, 20, 15, 12, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 185,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1933, 2, 12, 3, 24, 12, 0, DateTimeKind.Utc), new DateTime(1933, 2, 12, 3, 24, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 186,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1985, 11, 19, 2, 18, 8, 0, DateTimeKind.Utc), new DateTime(1985, 11, 19, 2, 18, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 187,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1994, 9, 1, 17, 25, 39, 0, DateTimeKind.Utc), new DateTime(1994, 9, 1, 17, 25, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 188,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1966, 6, 4, 11, 1, 39, 0, DateTimeKind.Utc), new DateTime(1966, 6, 4, 11, 1, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 189,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1934, 10, 1, 14, 41, 40, 0, DateTimeKind.Utc), new DateTime(1934, 10, 1, 14, 41, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 190,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1992, 10, 10, 3, 44, 28, 0, DateTimeKind.Utc), new DateTime(1992, 10, 10, 3, 44, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 191,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1917, 3, 8, 20, 6, 44, 0, DateTimeKind.Utc), new DateTime(1917, 3, 8, 20, 6, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 192,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1967, 6, 9, 11, 0, 50, 0, DateTimeKind.Utc), new DateTime(1967, 6, 9, 11, 0, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 193,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1931, 2, 8, 0, 5, 40, 0, DateTimeKind.Utc), new DateTime(1931, 2, 8, 0, 5, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 194,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1945, 9, 5, 17, 51, 35, 0, DateTimeKind.Utc), new DateTime(1945, 9, 5, 17, 51, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 195,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1923, 1, 8, 23, 21, 25, 0, DateTimeKind.Utc), new DateTime(1923, 1, 8, 23, 21, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 196,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2000, 7, 1, 12, 33, 11, 0, DateTimeKind.Utc), new DateTime(2000, 7, 1, 12, 33, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 197,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1946, 8, 12, 8, 56, 31, 0, DateTimeKind.Utc), new DateTime(1946, 8, 12, 8, 56, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 198,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1944, 9, 23, 3, 20, 34, 0, DateTimeKind.Utc), new DateTime(1944, 9, 23, 3, 20, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 199,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1951, 8, 23, 15, 46, 57, 0, DateTimeKind.Utc), new DateTime(1951, 8, 23, 15, 46, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 200,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1939, 5, 11, 16, 39, 2, 0, DateTimeKind.Utc), new DateTime(1939, 5, 11, 16, 39, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 201,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1957, 7, 4, 20, 40, 23, 0, DateTimeKind.Utc), new DateTime(1957, 7, 4, 20, 40, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 202,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2001, 9, 16, 1, 39, 24, 0, DateTimeKind.Utc), new DateTime(2001, 9, 16, 1, 39, 24, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 203,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1932, 1, 24, 14, 22, 3, 0, DateTimeKind.Utc), new DateTime(1932, 1, 24, 14, 22, 3, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 204,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1997, 1, 21, 16, 34, 38, 0, DateTimeKind.Utc), new DateTime(1997, 1, 21, 16, 34, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 205,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 2, 24, 1, 12, 9, 0, DateTimeKind.Utc), new DateTime(1977, 2, 24, 1, 12, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 206,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2003, 8, 2, 8, 53, 22, 0, DateTimeKind.Utc), new DateTime(2003, 8, 2, 8, 53, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 207,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1947, 6, 4, 9, 20, 36, 0, DateTimeKind.Utc), new DateTime(1947, 6, 4, 9, 20, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 208,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1903, 4, 2, 9, 22, 46, 0, DateTimeKind.Utc), new DateTime(1903, 4, 2, 9, 22, 46, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 209,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1910, 8, 1, 7, 54, 36, 0, DateTimeKind.Utc), new DateTime(1910, 8, 1, 7, 54, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 210,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1936, 9, 28, 11, 14, 30, 0, DateTimeKind.Utc), new DateTime(1936, 9, 28, 11, 14, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 211,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1969, 9, 15, 9, 13, 57, 0, DateTimeKind.Utc), new DateTime(1969, 9, 15, 9, 13, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 212,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1943, 10, 4, 11, 13, 53, 0, DateTimeKind.Utc), new DateTime(1943, 10, 4, 11, 13, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 213,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2015, 5, 20, 2, 39, 13, 0, DateTimeKind.Utc), new DateTime(2015, 5, 20, 2, 39, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 214,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1973, 3, 23, 1, 58, 29, 0, DateTimeKind.Utc), new DateTime(1973, 3, 23, 1, 58, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 215,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1914, 6, 22, 10, 4, 6, 0, DateTimeKind.Utc), new DateTime(1914, 6, 22, 10, 4, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 216,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1946, 10, 8, 15, 51, 36, 0, DateTimeKind.Utc), new DateTime(1946, 10, 8, 15, 51, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 217,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1908, 8, 4, 2, 1, 28, 0, DateTimeKind.Utc), new DateTime(1908, 8, 4, 2, 1, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 218,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1982, 7, 14, 3, 22, 32, 0, DateTimeKind.Utc), new DateTime(1982, 7, 14, 3, 22, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 219,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2014, 3, 4, 18, 53, 0, 0, DateTimeKind.Utc), new DateTime(2014, 3, 4, 18, 53, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 220,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1988, 6, 22, 0, 15, 42, 0, DateTimeKind.Utc), new DateTime(1988, 6, 22, 0, 15, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 221,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1920, 11, 24, 23, 5, 18, 0, DateTimeKind.Utc), new DateTime(1920, 11, 24, 23, 5, 18, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 222,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1978, 4, 15, 2, 2, 59, 0, DateTimeKind.Utc), new DateTime(1978, 4, 15, 2, 2, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 223,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1910, 6, 6, 7, 24, 21, 0, DateTimeKind.Utc), new DateTime(1910, 6, 6, 7, 24, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 224,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 11, 5, 5, 30, 53, 0, DateTimeKind.Utc), new DateTime(2024, 11, 5, 5, 30, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 225,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 1, 5, 55, 21, 0, DateTimeKind.Utc), new DateTime(2023, 7, 1, 5, 55, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 226,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2004, 1, 12, 9, 54, 5, 0, DateTimeKind.Utc), new DateTime(2004, 1, 12, 9, 54, 5, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 227,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 8, 15, 4, 30, 4, 0, DateTimeKind.Utc), new DateTime(1979, 8, 15, 4, 30, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 228,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1901, 10, 5, 3, 40, 23, 0, DateTimeKind.Utc), new DateTime(1901, 10, 5, 3, 40, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 229,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1999, 5, 3, 9, 2, 16, 0, DateTimeKind.Utc), new DateTime(1999, 5, 3, 9, 2, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 230,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1968, 11, 12, 22, 0, 29, 0, DateTimeKind.Utc), new DateTime(1968, 11, 12, 22, 0, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 231,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1935, 5, 11, 3, 14, 59, 0, DateTimeKind.Utc), new DateTime(1935, 5, 11, 3, 14, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 232,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1973, 8, 17, 2, 40, 44, 0, DateTimeKind.Utc), new DateTime(1973, 8, 17, 2, 40, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 233,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2003, 9, 14, 1, 13, 40, 0, DateTimeKind.Utc), new DateTime(2003, 9, 14, 1, 13, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 234,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1991, 10, 27, 15, 26, 31, 0, DateTimeKind.Utc), new DateTime(1991, 10, 27, 15, 26, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 235,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1931, 5, 1, 3, 51, 58, 0, DateTimeKind.Utc), new DateTime(1931, 5, 1, 3, 51, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 236,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1983, 8, 19, 0, 53, 7, 0, DateTimeKind.Utc), new DateTime(1983, 8, 19, 0, 53, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 237,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1987, 10, 17, 3, 32, 59, 0, DateTimeKind.Utc), new DateTime(1987, 10, 17, 3, 32, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 238,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1998, 8, 20, 8, 34, 13, 0, DateTimeKind.Utc), new DateTime(1998, 8, 20, 8, 34, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 239,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1998, 6, 20, 18, 12, 9, 0, DateTimeKind.Utc), new DateTime(1998, 6, 20, 18, 12, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 240,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1969, 8, 27, 20, 53, 48, 0, DateTimeKind.Utc), new DateTime(1969, 8, 27, 20, 53, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 241,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2021, 6, 23, 14, 26, 58, 0, DateTimeKind.Utc), new DateTime(2021, 6, 23, 14, 26, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 242,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1906, 9, 26, 8, 21, 21, 0, DateTimeKind.Utc), new DateTime(1906, 9, 26, 8, 21, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 243,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1907, 7, 9, 22, 50, 45, 0, DateTimeKind.Utc), new DateTime(1907, 7, 9, 22, 50, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 244,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 11, 24, 18, 20, 22, 0, DateTimeKind.Utc), new DateTime(2002, 11, 24, 18, 20, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 245,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1932, 11, 14, 12, 28, 13, 0, DateTimeKind.Utc), new DateTime(1932, 11, 14, 12, 28, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 246,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1922, 10, 28, 18, 11, 5, 0, DateTimeKind.Utc), new DateTime(1922, 10, 28, 18, 11, 5, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 247,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1919, 3, 8, 17, 17, 46, 0, DateTimeKind.Utc), new DateTime(1919, 3, 8, 17, 17, 46, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 248,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1935, 5, 4, 8, 40, 38, 0, DateTimeKind.Utc), new DateTime(1935, 5, 4, 8, 40, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 249,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 7, 24, 4, 1, 58, 0, DateTimeKind.Utc), new DateTime(2006, 7, 24, 4, 1, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 250,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 3, 4, 10, 20, 31, 0, DateTimeKind.Utc), new DateTime(2019, 3, 4, 10, 20, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 251,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1960, 7, 10, 16, 9, 30, 0, DateTimeKind.Utc), new DateTime(1960, 7, 10, 16, 9, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 252,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1946, 4, 11, 5, 45, 39, 0, DateTimeKind.Utc), new DateTime(1946, 4, 11, 5, 45, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 253,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1960, 2, 18, 1, 29, 53, 0, DateTimeKind.Utc), new DateTime(1960, 2, 18, 1, 29, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 254,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1929, 10, 7, 20, 39, 50, 0, DateTimeKind.Utc), new DateTime(1929, 10, 7, 20, 39, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 255,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1947, 1, 24, 23, 49, 59, 0, DateTimeKind.Utc), new DateTime(1947, 1, 24, 23, 49, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 256,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2021, 8, 24, 17, 14, 43, 0, DateTimeKind.Utc), new DateTime(2021, 8, 24, 17, 14, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 257,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1953, 7, 9, 14, 58, 23, 0, DateTimeKind.Utc), new DateTime(1953, 7, 9, 14, 58, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 258,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1930, 8, 25, 4, 41, 55, 0, DateTimeKind.Utc), new DateTime(1930, 8, 25, 4, 41, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 259,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1942, 10, 20, 5, 12, 26, 0, DateTimeKind.Utc), new DateTime(1942, 10, 20, 5, 12, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 260,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1934, 8, 26, 11, 18, 8, 0, DateTimeKind.Utc), new DateTime(1934, 8, 26, 11, 18, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 261,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1983, 5, 13, 9, 14, 2, 0, DateTimeKind.Utc), new DateTime(1983, 5, 13, 9, 14, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 262,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2000, 9, 25, 21, 38, 53, 0, DateTimeKind.Utc), new DateTime(2000, 9, 25, 21, 38, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 263,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1973, 7, 27, 20, 35, 1, 0, DateTimeKind.Utc), new DateTime(1973, 7, 27, 20, 35, 1, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 264,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 3, 9, 21, 38, 57, 0, DateTimeKind.Utc), new DateTime(2023, 3, 9, 21, 38, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 265,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1934, 9, 15, 9, 27, 35, 0, DateTimeKind.Utc), new DateTime(1934, 9, 15, 9, 27, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 266,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2001, 11, 8, 3, 56, 35, 0, DateTimeKind.Utc), new DateTime(2001, 11, 8, 3, 56, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 267,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2016, 10, 12, 19, 22, 55, 0, DateTimeKind.Utc), new DateTime(2016, 10, 12, 19, 22, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 268,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1905, 5, 7, 19, 37, 34, 0, DateTimeKind.Utc), new DateTime(1905, 5, 7, 19, 37, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 269,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1961, 5, 2, 21, 29, 5, 0, DateTimeKind.Utc), new DateTime(1961, 5, 2, 21, 29, 5, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 270,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2003, 9, 22, 12, 5, 29, 0, DateTimeKind.Utc), new DateTime(2003, 9, 22, 12, 5, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 271,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1963, 5, 9, 6, 5, 41, 0, DateTimeKind.Utc), new DateTime(1963, 5, 9, 6, 5, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 272,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1976, 5, 19, 8, 54, 43, 0, DateTimeKind.Utc), new DateTime(1976, 5, 19, 8, 54, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 273,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1976, 2, 24, 9, 51, 11, 0, DateTimeKind.Utc), new DateTime(1976, 2, 24, 9, 51, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 274,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1990, 6, 4, 22, 54, 0, 0, DateTimeKind.Utc), new DateTime(1990, 6, 4, 22, 54, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 275,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1968, 11, 13, 4, 18, 11, 0, DateTimeKind.Utc), new DateTime(1968, 11, 13, 4, 18, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 276,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2003, 5, 22, 21, 17, 58, 0, DateTimeKind.Utc), new DateTime(2003, 5, 22, 21, 17, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 277,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 9, 10, 12, 11, 11, 0, DateTimeKind.Utc), new DateTime(1977, 9, 10, 12, 11, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 278,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2012, 2, 15, 7, 16, 19, 0, DateTimeKind.Utc), new DateTime(2012, 2, 15, 7, 16, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 279,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1929, 5, 26, 13, 46, 36, 0, DateTimeKind.Utc), new DateTime(1929, 5, 26, 13, 46, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 280,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1945, 7, 14, 7, 42, 10, 0, DateTimeKind.Utc), new DateTime(1945, 7, 14, 7, 42, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 281,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1927, 5, 4, 11, 31, 28, 0, DateTimeKind.Utc), new DateTime(1927, 5, 4, 11, 31, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 282,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 8, 25, 21, 45, 4, 0, DateTimeKind.Utc), new DateTime(2019, 8, 25, 21, 45, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 283,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2004, 3, 9, 22, 2, 45, 0, DateTimeKind.Utc), new DateTime(2004, 3, 9, 22, 2, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 284,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1959, 3, 19, 3, 55, 51, 0, DateTimeKind.Utc), new DateTime(1959, 3, 19, 3, 55, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 285,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1934, 3, 19, 3, 31, 43, 0, DateTimeKind.Utc), new DateTime(1934, 3, 19, 3, 31, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 286,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1958, 4, 3, 4, 18, 44, 0, DateTimeKind.Utc), new DateTime(1958, 4, 3, 4, 18, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 287,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1905, 5, 18, 1, 21, 32, 0, DateTimeKind.Utc), new DateTime(1905, 5, 18, 1, 21, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 288,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1954, 5, 20, 19, 44, 34, 0, DateTimeKind.Utc), new DateTime(1954, 5, 20, 19, 44, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 289,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1938, 5, 15, 17, 48, 28, 0, DateTimeKind.Utc), new DateTime(1938, 5, 15, 17, 48, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 290,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1963, 1, 15, 6, 11, 15, 0, DateTimeKind.Utc), new DateTime(1963, 1, 15, 6, 11, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 291,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 9, 6, 3, 24, 25, 0, DateTimeKind.Utc), new DateTime(2002, 9, 6, 3, 24, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 292,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 8, 25, 13, 52, 37, 0, DateTimeKind.Utc), new DateTime(2024, 8, 25, 13, 52, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 293,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1912, 5, 25, 2, 41, 33, 0, DateTimeKind.Utc), new DateTime(1912, 5, 25, 2, 41, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 294,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1919, 6, 15, 2, 50, 4, 0, DateTimeKind.Utc), new DateTime(1919, 6, 15, 2, 50, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 295,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1921, 9, 15, 14, 40, 13, 0, DateTimeKind.Utc), new DateTime(1921, 9, 15, 14, 40, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 296,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1926, 9, 7, 9, 13, 34, 0, DateTimeKind.Utc), new DateTime(1926, 9, 7, 9, 13, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 297,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1943, 4, 28, 6, 50, 5, 0, DateTimeKind.Utc), new DateTime(1943, 4, 28, 6, 50, 5, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 298,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1985, 9, 17, 21, 37, 22, 0, DateTimeKind.Utc), new DateTime(1985, 9, 17, 21, 37, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 299,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1974, 5, 12, 23, 5, 44, 0, DateTimeKind.Utc), new DateTime(1974, 5, 12, 23, 5, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 300,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1991, 9, 27, 2, 58, 39, 0, DateTimeKind.Utc), new DateTime(1991, 9, 27, 2, 58, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 301,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2012, 5, 28, 16, 19, 4, 0, DateTimeKind.Utc), new DateTime(2012, 5, 28, 16, 19, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 302,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1949, 9, 6, 7, 45, 24, 0, DateTimeKind.Utc), new DateTime(1949, 9, 6, 7, 45, 24, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 303,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1971, 10, 18, 10, 23, 4, 0, DateTimeKind.Utc), new DateTime(1971, 10, 18, 10, 23, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 304,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 4, 4, 3, 59, 16, 0, DateTimeKind.Utc), new DateTime(1962, 4, 4, 3, 59, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 305,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 3, 20, 11, 38, 29, 0, DateTimeKind.Utc), new DateTime(2002, 3, 20, 11, 38, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 306,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1975, 3, 10, 7, 22, 26, 0, DateTimeKind.Utc), new DateTime(1975, 3, 10, 7, 22, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 307,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1911, 1, 13, 11, 30, 53, 0, DateTimeKind.Utc), new DateTime(1911, 1, 13, 11, 30, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 308,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1919, 4, 19, 23, 23, 12, 0, DateTimeKind.Utc), new DateTime(1919, 4, 19, 23, 23, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 309,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1913, 4, 10, 21, 36, 41, 0, DateTimeKind.Utc), new DateTime(1913, 4, 10, 21, 36, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 310,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1968, 9, 12, 17, 50, 4, 0, DateTimeKind.Utc), new DateTime(1968, 9, 12, 17, 50, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 311,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1946, 11, 3, 17, 41, 30, 0, DateTimeKind.Utc), new DateTime(1946, 11, 3, 17, 41, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 312,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1908, 4, 15, 4, 20, 22, 0, DateTimeKind.Utc), new DateTime(1908, 4, 15, 4, 20, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 313,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 1, 22, 5, 58, 42, 0, DateTimeKind.Utc), new DateTime(1977, 1, 22, 5, 58, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 314,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1976, 10, 25, 11, 21, 21, 0, DateTimeKind.Utc), new DateTime(1976, 10, 25, 11, 21, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 315,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1917, 8, 18, 15, 44, 37, 0, DateTimeKind.Utc), new DateTime(1917, 8, 18, 15, 44, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 316,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1904, 5, 5, 8, 6, 34, 0, DateTimeKind.Utc), new DateTime(1904, 5, 5, 8, 6, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 317,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1998, 5, 17, 3, 54, 6, 0, DateTimeKind.Utc), new DateTime(1998, 5, 17, 3, 54, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 318,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1986, 11, 27, 23, 15, 35, 0, DateTimeKind.Utc), new DateTime(1986, 11, 27, 23, 15, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 319,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2013, 4, 22, 16, 5, 0, 0, DateTimeKind.Utc), new DateTime(2013, 4, 22, 16, 5, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 320,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1924, 10, 17, 17, 33, 58, 0, DateTimeKind.Utc), new DateTime(1924, 10, 17, 17, 33, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 321,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2008, 5, 15, 21, 7, 56, 0, DateTimeKind.Utc), new DateTime(2008, 5, 15, 21, 7, 56, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 322,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1923, 3, 26, 5, 25, 31, 0, DateTimeKind.Utc), new DateTime(1923, 3, 26, 5, 25, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 323,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1912, 6, 26, 18, 47, 23, 0, DateTimeKind.Utc), new DateTime(1912, 6, 26, 18, 47, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 324,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1948, 3, 14, 1, 43, 24, 0, DateTimeKind.Utc), new DateTime(1948, 3, 14, 1, 43, 24, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 325,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 4, 9, 3, 9, 12, 0, DateTimeKind.Utc), new DateTime(2006, 4, 9, 3, 9, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 326,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 1, 25, 14, 16, 27, 0, DateTimeKind.Utc), new DateTime(2023, 1, 25, 14, 16, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 327,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1971, 9, 24, 0, 45, 59, 0, DateTimeKind.Utc), new DateTime(1971, 9, 24, 0, 45, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 328,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1986, 8, 26, 5, 34, 37, 0, DateTimeKind.Utc), new DateTime(1986, 8, 26, 5, 34, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 329,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1909, 6, 3, 4, 20, 22, 0, DateTimeKind.Utc), new DateTime(1909, 6, 3, 4, 20, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 330,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 10, 21, 2, 2, 45, 0, DateTimeKind.Utc), new DateTime(1962, 10, 21, 2, 2, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 331,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 1, 4, 16, 13, 22, 0, DateTimeKind.Utc), new DateTime(1979, 1, 4, 16, 13, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 332,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1978, 6, 6, 10, 10, 59, 0, DateTimeKind.Utc), new DateTime(1978, 6, 6, 10, 10, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 333,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1969, 5, 13, 11, 20, 1, 0, DateTimeKind.Utc), new DateTime(1969, 5, 13, 11, 20, 1, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 334,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 7, 23, 16, 3, 41, 0, DateTimeKind.Utc), new DateTime(1962, 7, 23, 16, 3, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 335,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1911, 9, 20, 12, 6, 26, 0, DateTimeKind.Utc), new DateTime(1911, 9, 20, 12, 6, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 336,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1992, 6, 22, 1, 22, 43, 0, DateTimeKind.Utc), new DateTime(1992, 6, 22, 1, 22, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 337,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2010, 1, 14, 12, 36, 4, 0, DateTimeKind.Utc), new DateTime(2010, 1, 14, 12, 36, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 338,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1953, 8, 8, 2, 36, 57, 0, DateTimeKind.Utc), new DateTime(1953, 8, 8, 2, 36, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 339,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2017, 1, 14, 16, 36, 25, 0, DateTimeKind.Utc), new DateTime(2017, 1, 14, 16, 36, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 340,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2020, 11, 28, 9, 34, 24, 0, DateTimeKind.Utc), new DateTime(2020, 11, 28, 9, 34, 24, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 341,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1984, 2, 11, 17, 42, 42, 0, DateTimeKind.Utc), new DateTime(1984, 2, 11, 17, 42, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 342,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 6, 1, 17, 34, 19, 0, DateTimeKind.Utc), new DateTime(1925, 6, 1, 17, 34, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 343,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1965, 11, 28, 17, 14, 25, 0, DateTimeKind.Utc), new DateTime(1965, 11, 28, 17, 14, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 344,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1951, 11, 6, 17, 35, 4, 0, DateTimeKind.Utc), new DateTime(1951, 11, 6, 17, 35, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 345,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2020, 1, 24, 8, 6, 23, 0, DateTimeKind.Utc), new DateTime(2020, 1, 24, 8, 6, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 346,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1992, 6, 13, 1, 50, 29, 0, DateTimeKind.Utc), new DateTime(1992, 6, 13, 1, 50, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 347,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1985, 8, 26, 13, 54, 7, 0, DateTimeKind.Utc), new DateTime(1985, 8, 26, 13, 54, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 348,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2018, 3, 13, 3, 10, 36, 0, DateTimeKind.Utc), new DateTime(2018, 3, 13, 3, 10, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 349,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1952, 3, 21, 13, 59, 35, 0, DateTimeKind.Utc), new DateTime(1952, 3, 21, 13, 59, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 350,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 11, 15, 7, 46, 40, 0, DateTimeKind.Utc), new DateTime(1925, 11, 15, 7, 46, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 351,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 10, 11, 14, 58, 6, 0, DateTimeKind.Utc), new DateTime(2006, 10, 11, 14, 58, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 352,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2009, 6, 5, 12, 1, 32, 0, DateTimeKind.Utc), new DateTime(2009, 6, 5, 12, 1, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 353,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1961, 10, 3, 1, 47, 21, 0, DateTimeKind.Utc), new DateTime(1961, 10, 3, 1, 47, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 354,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1974, 9, 25, 5, 54, 51, 0, DateTimeKind.Utc), new DateTime(1974, 9, 25, 5, 54, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 355,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1981, 3, 14, 20, 51, 53, 0, DateTimeKind.Utc), new DateTime(1981, 3, 14, 20, 51, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 356,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2020, 5, 26, 5, 42, 1, 0, DateTimeKind.Utc), new DateTime(2020, 5, 26, 5, 42, 1, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 357,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1991, 4, 8, 8, 16, 42, 0, DateTimeKind.Utc), new DateTime(1991, 4, 8, 8, 16, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 358,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1956, 11, 7, 4, 3, 8, 0, DateTimeKind.Utc), new DateTime(1956, 11, 7, 4, 3, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 359,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1961, 2, 5, 4, 42, 58, 0, DateTimeKind.Utc), new DateTime(1961, 2, 5, 4, 42, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 360,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2001, 7, 28, 12, 58, 47, 0, DateTimeKind.Utc), new DateTime(2001, 7, 28, 12, 58, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 361,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1976, 1, 17, 6, 32, 39, 0, DateTimeKind.Utc), new DateTime(1976, 1, 17, 6, 32, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 362,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 3, 5, 1, 20, 28, 0, DateTimeKind.Utc), new DateTime(1977, 3, 5, 1, 20, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 363,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1911, 3, 15, 3, 46, 58, 0, DateTimeKind.Utc), new DateTime(1911, 3, 15, 3, 46, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 364,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 6, 4, 8, 21, 43, 0, DateTimeKind.Utc), new DateTime(1977, 6, 4, 8, 21, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 365,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1992, 9, 19, 22, 26, 5, 0, DateTimeKind.Utc), new DateTime(1992, 9, 19, 22, 26, 5, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 366,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1903, 3, 10, 11, 44, 15, 0, DateTimeKind.Utc), new DateTime(1903, 3, 10, 11, 44, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 367,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1912, 3, 11, 13, 34, 48, 0, DateTimeKind.Utc), new DateTime(1912, 3, 11, 13, 34, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 368,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 5, 23, 16, 3, 28, 0, DateTimeKind.Utc), new DateTime(2024, 5, 23, 16, 3, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 369,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1955, 8, 24, 23, 54, 30, 0, DateTimeKind.Utc), new DateTime(1955, 8, 24, 23, 54, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 370,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1980, 4, 19, 21, 31, 45, 0, DateTimeKind.Utc), new DateTime(1980, 4, 19, 21, 31, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 371,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 8, 23, 1, 1, 7, 0, DateTimeKind.Utc), new DateTime(2024, 8, 23, 1, 1, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 372,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1912, 8, 15, 6, 2, 34, 0, DateTimeKind.Utc), new DateTime(1912, 8, 15, 6, 2, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 373,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1973, 1, 25, 7, 20, 55, 0, DateTimeKind.Utc), new DateTime(1973, 1, 25, 7, 20, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 374,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2013, 1, 21, 4, 29, 46, 0, DateTimeKind.Utc), new DateTime(2013, 1, 21, 4, 29, 46, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 375,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1929, 1, 9, 20, 49, 27, 0, DateTimeKind.Utc), new DateTime(1929, 1, 9, 20, 49, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 376,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1972, 3, 20, 15, 34, 53, 0, DateTimeKind.Utc), new DateTime(1972, 3, 20, 15, 34, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 377,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 11, 12, 16, 34, 25, 0, DateTimeKind.Utc), new DateTime(2023, 11, 12, 16, 34, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 378,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2021, 3, 18, 6, 23, 51, 0, DateTimeKind.Utc), new DateTime(2021, 3, 18, 6, 23, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 379,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 4, 27, 17, 58, 27, 0, DateTimeKind.Utc), new DateTime(1977, 4, 27, 17, 58, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 380,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1901, 9, 6, 0, 48, 58, 0, DateTimeKind.Utc), new DateTime(1901, 9, 6, 0, 48, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 381,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2004, 3, 23, 0, 40, 49, 0, DateTimeKind.Utc), new DateTime(2004, 3, 23, 0, 40, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 382,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2010, 11, 14, 23, 20, 23, 0, DateTimeKind.Utc), new DateTime(2010, 11, 14, 23, 20, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 383,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 3, 14, 7, 12, 18, 0, DateTimeKind.Utc), new DateTime(1964, 3, 14, 7, 12, 18, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 384,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1919, 11, 19, 10, 13, 29, 0, DateTimeKind.Utc), new DateTime(1919, 11, 19, 10, 13, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 385,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 10, 8, 5, 36, 45, 0, DateTimeKind.Utc), new DateTime(1964, 10, 8, 5, 36, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 386,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1985, 11, 5, 10, 50, 18, 0, DateTimeKind.Utc), new DateTime(1985, 11, 5, 10, 50, 18, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 387,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1975, 11, 15, 19, 22, 25, 0, DateTimeKind.Utc), new DateTime(1975, 11, 15, 19, 22, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 388,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1947, 7, 28, 13, 13, 44, 0, DateTimeKind.Utc), new DateTime(1947, 7, 28, 13, 13, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 389,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2021, 9, 17, 21, 51, 48, 0, DateTimeKind.Utc), new DateTime(2021, 9, 17, 21, 51, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 390,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1940, 5, 2, 7, 31, 49, 0, DateTimeKind.Utc), new DateTime(1940, 5, 2, 7, 31, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 391,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1969, 8, 11, 17, 18, 23, 0, DateTimeKind.Utc), new DateTime(1969, 8, 11, 17, 18, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 392,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1929, 2, 12, 4, 41, 17, 0, DateTimeKind.Utc), new DateTime(1929, 2, 12, 4, 41, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 393,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1998, 5, 17, 5, 2, 35, 0, DateTimeKind.Utc), new DateTime(1998, 5, 17, 5, 2, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 394,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 11, 18, 12, 15, 52, 0, DateTimeKind.Utc), new DateTime(1964, 11, 18, 12, 15, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 395,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1917, 9, 3, 7, 5, 26, 0, DateTimeKind.Utc), new DateTime(1917, 9, 3, 7, 5, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 396,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1929, 4, 12, 16, 14, 43, 0, DateTimeKind.Utc), new DateTime(1929, 4, 12, 16, 14, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 397,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1906, 8, 9, 14, 17, 7, 0, DateTimeKind.Utc), new DateTime(1906, 8, 9, 14, 17, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 398,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1941, 9, 2, 7, 6, 29, 0, DateTimeKind.Utc), new DateTime(1941, 9, 2, 7, 6, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 399,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1924, 2, 11, 11, 47, 32, 0, DateTimeKind.Utc), new DateTime(1924, 2, 11, 11, 47, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 400,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1923, 1, 12, 11, 33, 30, 0, DateTimeKind.Utc), new DateTime(1923, 1, 12, 11, 33, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 401,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1934, 11, 1, 22, 56, 23, 0, DateTimeKind.Utc), new DateTime(1934, 11, 1, 22, 56, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 402,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2009, 2, 4, 21, 9, 21, 0, DateTimeKind.Utc), new DateTime(2009, 2, 4, 21, 9, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 403,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1932, 11, 20, 12, 10, 27, 0, DateTimeKind.Utc), new DateTime(1932, 11, 20, 12, 10, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 404,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2001, 10, 20, 14, 7, 58, 0, DateTimeKind.Utc), new DateTime(2001, 10, 20, 14, 7, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 405,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1907, 9, 14, 20, 28, 11, 0, DateTimeKind.Utc), new DateTime(1907, 9, 14, 20, 28, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 406,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1938, 7, 4, 19, 17, 22, 0, DateTimeKind.Utc), new DateTime(1938, 7, 4, 19, 17, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 407,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1913, 5, 24, 15, 26, 59, 0, DateTimeKind.Utc), new DateTime(1913, 5, 24, 15, 26, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 408,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1941, 4, 28, 0, 11, 51, 0, DateTimeKind.Utc), new DateTime(1941, 4, 28, 0, 11, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 409,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 8, 25, 22, 40, 42, 0, DateTimeKind.Utc), new DateTime(2006, 8, 25, 22, 40, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 410,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 8, 23, 0, 52, 8, 0, DateTimeKind.Utc), new DateTime(2002, 8, 23, 0, 52, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 411,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2011, 1, 18, 22, 33, 34, 0, DateTimeKind.Utc), new DateTime(2011, 1, 18, 22, 33, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 412,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1927, 6, 18, 7, 22, 47, 0, DateTimeKind.Utc), new DateTime(1927, 6, 18, 7, 22, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 413,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1974, 2, 12, 16, 16, 47, 0, DateTimeKind.Utc), new DateTime(1974, 2, 12, 16, 16, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 414,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1899, 1, 17, 15, 0, 46, 0, DateTimeKind.Utc), new DateTime(1899, 1, 17, 15, 0, 46, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 415,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1939, 5, 25, 9, 58, 37, 0, DateTimeKind.Utc), new DateTime(1939, 5, 25, 9, 58, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 416,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1969, 1, 15, 17, 45, 26, 0, DateTimeKind.Utc), new DateTime(1969, 1, 15, 17, 45, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 417,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1944, 5, 22, 9, 46, 42, 0, DateTimeKind.Utc), new DateTime(1944, 5, 22, 9, 46, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 418,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 6, 9, 1, 20, 31, 0, DateTimeKind.Utc), new DateTime(1925, 6, 9, 1, 20, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 419,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1938, 2, 12, 0, 1, 48, 0, DateTimeKind.Utc), new DateTime(1938, 2, 12, 0, 1, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 420,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1967, 3, 28, 20, 37, 11, 0, DateTimeKind.Utc), new DateTime(1967, 3, 28, 20, 37, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 421,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1986, 10, 14, 0, 44, 17, 0, DateTimeKind.Utc), new DateTime(1986, 10, 14, 0, 44, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 422,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1933, 10, 12, 22, 19, 52, 0, DateTimeKind.Utc), new DateTime(1933, 10, 12, 22, 19, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 423,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1901, 7, 9, 21, 25, 28, 0, DateTimeKind.Utc), new DateTime(1901, 7, 9, 21, 25, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 424,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1955, 3, 1, 8, 5, 50, 0, DateTimeKind.Utc), new DateTime(1955, 3, 1, 8, 5, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 425,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1923, 7, 2, 16, 10, 30, 0, DateTimeKind.Utc), new DateTime(1923, 7, 2, 16, 10, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 426,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1954, 6, 22, 13, 41, 57, 0, DateTimeKind.Utc), new DateTime(1954, 6, 22, 13, 41, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 427,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 3, 23, 0, 47, 27, 0, DateTimeKind.Utc), new DateTime(1925, 3, 23, 0, 47, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 428,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1912, 4, 23, 12, 59, 23, 0, DateTimeKind.Utc), new DateTime(1912, 4, 23, 12, 59, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 429,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1963, 8, 24, 12, 24, 22, 0, DateTimeKind.Utc), new DateTime(1963, 8, 24, 12, 24, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 430,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1920, 4, 21, 15, 49, 11, 0, DateTimeKind.Utc), new DateTime(1920, 4, 21, 15, 49, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 431,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1926, 7, 21, 21, 30, 49, 0, DateTimeKind.Utc), new DateTime(1926, 7, 21, 21, 30, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 432,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1910, 6, 27, 8, 40, 13, 0, DateTimeKind.Utc), new DateTime(1910, 6, 27, 8, 40, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 433,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1985, 5, 13, 13, 15, 43, 0, DateTimeKind.Utc), new DateTime(1985, 5, 13, 13, 15, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 434,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 8, 16, 16, 11, 30, 0, DateTimeKind.Utc), new DateTime(1902, 8, 16, 16, 11, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 435,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1982, 11, 3, 9, 23, 21, 0, DateTimeKind.Utc), new DateTime(1982, 11, 3, 9, 23, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 436,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1926, 7, 11, 14, 48, 12, 0, DateTimeKind.Utc), new DateTime(1926, 7, 11, 14, 48, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 437,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1990, 3, 24, 23, 26, 32, 0, DateTimeKind.Utc), new DateTime(1990, 3, 24, 23, 26, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 438,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1956, 2, 28, 14, 49, 59, 0, DateTimeKind.Utc), new DateTime(1956, 2, 28, 14, 49, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 439,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2015, 7, 3, 23, 36, 9, 0, DateTimeKind.Utc), new DateTime(2015, 7, 3, 23, 36, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 440,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 7, 12, 5, 13, 34, 0, DateTimeKind.Utc), new DateTime(1979, 7, 12, 5, 13, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 441,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1990, 8, 2, 13, 7, 6, 0, DateTimeKind.Utc), new DateTime(1990, 8, 2, 13, 7, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 442,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 2, 18, 5, 50, 1, 0, DateTimeKind.Utc), new DateTime(2006, 2, 18, 5, 50, 1, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 443,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2009, 1, 7, 0, 12, 1, 0, DateTimeKind.Utc), new DateTime(2009, 1, 7, 0, 12, 1, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 444,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 1, 3, 2, 28, 47, 0, DateTimeKind.Utc), new DateTime(1964, 1, 3, 2, 28, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 445,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1933, 3, 27, 5, 57, 15, 0, DateTimeKind.Utc), new DateTime(1933, 3, 27, 5, 57, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 446,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2001, 6, 28, 6, 14, 44, 0, DateTimeKind.Utc), new DateTime(2001, 6, 28, 6, 14, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 447,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1957, 10, 2, 21, 45, 44, 0, DateTimeKind.Utc), new DateTime(1957, 10, 2, 21, 45, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 448,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1944, 8, 22, 1, 6, 33, 0, DateTimeKind.Utc), new DateTime(1944, 8, 22, 1, 6, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 449,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2015, 7, 10, 9, 41, 10, 0, DateTimeKind.Utc), new DateTime(2015, 7, 10, 9, 41, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 450,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1957, 7, 7, 6, 18, 53, 0, DateTimeKind.Utc), new DateTime(1957, 7, 7, 6, 18, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 451,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1917, 7, 4, 8, 25, 19, 0, DateTimeKind.Utc), new DateTime(1917, 7, 4, 8, 25, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 452,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1904, 7, 23, 11, 33, 20, 0, DateTimeKind.Utc), new DateTime(1904, 7, 23, 11, 33, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 453,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 8, 9, 8, 44, 47, 0, DateTimeKind.Utc), new DateTime(2022, 8, 9, 8, 44, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 454,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1900, 3, 4, 9, 17, 20, 0, DateTimeKind.Utc), new DateTime(1900, 3, 4, 9, 17, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 455,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2014, 5, 24, 19, 48, 37, 0, DateTimeKind.Utc), new DateTime(2014, 5, 24, 19, 48, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 456,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 3, 17, 3, 43, 7, 0, DateTimeKind.Utc), new DateTime(1962, 3, 17, 3, 43, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 457,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1973, 1, 8, 10, 59, 30, 0, DateTimeKind.Utc), new DateTime(1973, 1, 8, 10, 59, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 458,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1991, 5, 2, 23, 24, 2, 0, DateTimeKind.Utc), new DateTime(1991, 5, 2, 23, 24, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 459,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2007, 2, 25, 10, 15, 3, 0, DateTimeKind.Utc), new DateTime(2007, 2, 25, 10, 15, 3, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 460,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1996, 9, 10, 19, 26, 59, 0, DateTimeKind.Utc), new DateTime(1996, 9, 10, 19, 26, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 461,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1960, 3, 23, 4, 59, 22, 0, DateTimeKind.Utc), new DateTime(1960, 3, 23, 4, 59, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 462,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1994, 10, 26, 4, 46, 44, 0, DateTimeKind.Utc), new DateTime(1994, 10, 26, 4, 46, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 463,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 7, 7, 14, 39, 51, 0, DateTimeKind.Utc), new DateTime(1964, 7, 7, 14, 39, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 464,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1932, 11, 1, 18, 57, 42, 0, DateTimeKind.Utc), new DateTime(1932, 11, 1, 18, 57, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 465,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1992, 1, 26, 12, 22, 58, 0, DateTimeKind.Utc), new DateTime(1992, 1, 26, 12, 22, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 466,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1997, 9, 16, 6, 57, 45, 0, DateTimeKind.Utc), new DateTime(1997, 9, 16, 6, 57, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 467,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1987, 7, 13, 16, 13, 34, 0, DateTimeKind.Utc), new DateTime(1987, 7, 13, 16, 13, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 468,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1915, 8, 10, 3, 54, 41, 0, DateTimeKind.Utc), new DateTime(1915, 8, 10, 3, 54, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 469,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2003, 2, 3, 11, 31, 30, 0, DateTimeKind.Utc), new DateTime(2003, 2, 3, 11, 31, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 470,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2020, 8, 8, 2, 26, 54, 0, DateTimeKind.Utc), new DateTime(2020, 8, 8, 2, 26, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 471,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1954, 3, 13, 22, 24, 58, 0, DateTimeKind.Utc), new DateTime(1954, 3, 13, 22, 24, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 472,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1920, 3, 18, 11, 54, 6, 0, DateTimeKind.Utc), new DateTime(1920, 3, 18, 11, 54, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 473,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1949, 7, 20, 10, 38, 17, 0, DateTimeKind.Utc), new DateTime(1949, 7, 20, 10, 38, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 474,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1945, 7, 5, 5, 41, 12, 0, DateTimeKind.Utc), new DateTime(1945, 7, 5, 5, 41, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 475,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2007, 4, 8, 1, 18, 14, 0, DateTimeKind.Utc), new DateTime(2007, 4, 8, 1, 18, 14, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 476,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1959, 7, 3, 12, 15, 58, 0, DateTimeKind.Utc), new DateTime(1959, 7, 3, 12, 15, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 477,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1913, 3, 8, 8, 57, 39, 0, DateTimeKind.Utc), new DateTime(1913, 3, 8, 8, 57, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 478,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1905, 4, 8, 23, 4, 57, 0, DateTimeKind.Utc), new DateTime(1905, 4, 8, 23, 4, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 479,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 6, 2, 23, 43, 50, 0, DateTimeKind.Utc), new DateTime(2002, 6, 2, 23, 43, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 480,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1994, 3, 16, 6, 4, 5, 0, DateTimeKind.Utc), new DateTime(1994, 3, 16, 6, 4, 5, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 481,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1988, 2, 27, 9, 59, 17, 0, DateTimeKind.Utc), new DateTime(1988, 2, 27, 9, 59, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 482,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1898, 10, 10, 17, 19, 27, 0, DateTimeKind.Utc), new DateTime(1898, 10, 10, 17, 19, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 483,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1900, 1, 18, 11, 10, 19, 0, DateTimeKind.Utc), new DateTime(1900, 1, 18, 11, 10, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 484,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2016, 10, 7, 7, 13, 47, 0, DateTimeKind.Utc), new DateTime(2016, 10, 7, 7, 13, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 485,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1921, 6, 25, 6, 46, 2, 0, DateTimeKind.Utc), new DateTime(1921, 6, 25, 6, 46, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 486,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 10, 4, 4, 38, 50, 0, DateTimeKind.Utc), new DateTime(1950, 10, 4, 4, 38, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 487,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1988, 8, 11, 23, 59, 11, 0, DateTimeKind.Utc), new DateTime(1988, 8, 11, 23, 59, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 488,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 2, 6, 14, 58, 42, 0, DateTimeKind.Utc), new DateTime(1977, 2, 6, 14, 58, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 489,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1922, 3, 1, 5, 19, 12, 0, DateTimeKind.Utc), new DateTime(1922, 3, 1, 5, 19, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 490,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 5, 26, 3, 12, 29, 0, DateTimeKind.Utc), new DateTime(2006, 5, 26, 3, 12, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 491,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1949, 9, 3, 6, 18, 27, 0, DateTimeKind.Utc), new DateTime(1949, 9, 3, 6, 18, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 492,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1940, 10, 11, 19, 46, 29, 0, DateTimeKind.Utc), new DateTime(1940, 10, 11, 19, 46, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 493,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2020, 11, 25, 1, 40, 7, 0, DateTimeKind.Utc), new DateTime(2020, 11, 25, 1, 40, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 494,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1974, 7, 15, 4, 4, 30, 0, DateTimeKind.Utc), new DateTime(1974, 7, 15, 4, 4, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 495,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1899, 2, 16, 21, 18, 13, 0, DateTimeKind.Utc), new DateTime(1899, 2, 16, 21, 18, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 496,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2016, 7, 14, 20, 34, 14, 0, DateTimeKind.Utc), new DateTime(2016, 7, 14, 20, 34, 14, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 497,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1910, 4, 23, 17, 16, 7, 0, DateTimeKind.Utc), new DateTime(1910, 4, 23, 17, 16, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 498,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1939, 5, 14, 12, 16, 22, 0, DateTimeKind.Utc), new DateTime(1939, 5, 14, 12, 16, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 499,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1939, 9, 21, 18, 33, 37, 0, DateTimeKind.Utc), new DateTime(1939, 9, 21, 18, 33, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 500,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 3, 19, 14, 16, 7, 0, DateTimeKind.Utc), new DateTime(2022, 3, 19, 14, 16, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 501,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2014, 5, 15, 3, 52, 12, 0, DateTimeKind.Utc), new DateTime(2014, 5, 15, 3, 52, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 502,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1900, 2, 11, 15, 57, 19, 0, DateTimeKind.Utc), new DateTime(1900, 2, 11, 15, 57, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 503,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1938, 10, 9, 9, 50, 40, 0, DateTimeKind.Utc), new DateTime(1938, 10, 9, 9, 50, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 504,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1901, 6, 26, 4, 34, 30, 0, DateTimeKind.Utc), new DateTime(1901, 6, 26, 4, 34, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 505,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1961, 2, 1, 20, 53, 20, 0, DateTimeKind.Utc), new DateTime(1961, 2, 1, 20, 53, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 506,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1970, 6, 2, 16, 48, 50, 0, DateTimeKind.Utc), new DateTime(1970, 6, 2, 16, 48, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 507,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1973, 2, 15, 6, 31, 10, 0, DateTimeKind.Utc), new DateTime(1973, 2, 15, 6, 31, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 508,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 24, 9, 28, 41, 0, DateTimeKind.Utc), new DateTime(2023, 8, 24, 9, 28, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 509,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1938, 7, 11, 23, 33, 48, 0, DateTimeKind.Utc), new DateTime(1938, 7, 11, 23, 33, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 510,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1926, 9, 24, 0, 38, 43, 0, DateTimeKind.Utc), new DateTime(1926, 9, 24, 0, 38, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 511,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1924, 2, 6, 1, 3, 26, 0, DateTimeKind.Utc), new DateTime(1924, 2, 6, 1, 3, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 512,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1931, 8, 2, 10, 47, 39, 0, DateTimeKind.Utc), new DateTime(1931, 8, 2, 10, 47, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 513,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1918, 9, 27, 17, 11, 52, 0, DateTimeKind.Utc), new DateTime(1918, 9, 27, 17, 11, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 514,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1980, 2, 20, 7, 31, 18, 0, DateTimeKind.Utc), new DateTime(1980, 2, 20, 7, 31, 18, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 515,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2018, 7, 27, 6, 26, 4, 0, DateTimeKind.Utc), new DateTime(2018, 7, 27, 6, 26, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 516,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1898, 7, 15, 19, 3, 21, 0, DateTimeKind.Utc), new DateTime(1898, 7, 15, 19, 3, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 517,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 11, 18, 9, 8, 49, 0, DateTimeKind.Utc), new DateTime(2019, 11, 18, 9, 8, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 518,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 10, 23, 17, 50, 48, 0, DateTimeKind.Utc), new DateTime(1977, 10, 23, 17, 50, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 519,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 6, 16, 23, 22, 32, 0, DateTimeKind.Utc), new DateTime(2006, 6, 16, 23, 22, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 520,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 10, 18, 21, 6, 29, 0, DateTimeKind.Utc), new DateTime(1902, 10, 18, 21, 6, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 521,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1959, 11, 6, 23, 26, 13, 0, DateTimeKind.Utc), new DateTime(1959, 11, 6, 23, 26, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 522,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1914, 5, 20, 14, 46, 15, 0, DateTimeKind.Utc), new DateTime(1914, 5, 20, 14, 46, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 523,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1928, 3, 28, 20, 41, 39, 0, DateTimeKind.Utc), new DateTime(1928, 3, 28, 20, 41, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 524,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 3, 21, 3, 24, 57, 0, DateTimeKind.Utc), new DateTime(1962, 3, 21, 3, 24, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 525,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 1, 6, 23, 45, 10, 0, DateTimeKind.Utc), new DateTime(1962, 1, 6, 23, 45, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 526,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1990, 1, 24, 3, 55, 8, 0, DateTimeKind.Utc), new DateTime(1990, 1, 24, 3, 55, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 527,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1976, 8, 12, 13, 35, 28, 0, DateTimeKind.Utc), new DateTime(1976, 8, 12, 13, 35, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 528,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1911, 3, 20, 7, 43, 8, 0, DateTimeKind.Utc), new DateTime(1911, 3, 20, 7, 43, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 529,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1971, 2, 6, 23, 24, 52, 0, DateTimeKind.Utc), new DateTime(1971, 2, 6, 23, 24, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 530,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1992, 4, 17, 5, 28, 24, 0, DateTimeKind.Utc), new DateTime(1992, 4, 17, 5, 28, 24, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 531,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 2, 18, 12, 52, 44, 0, DateTimeKind.Utc), new DateTime(1902, 2, 18, 12, 52, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 532,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1951, 1, 9, 19, 14, 3, 0, DateTimeKind.Utc), new DateTime(1951, 1, 9, 19, 14, 3, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 533,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1928, 11, 18, 6, 2, 9, 0, DateTimeKind.Utc), new DateTime(1928, 11, 18, 6, 2, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 534,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1928, 3, 10, 1, 24, 34, 0, DateTimeKind.Utc), new DateTime(1928, 3, 10, 1, 24, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 535,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 19, 22, 24, 35, 0, DateTimeKind.Utc), new DateTime(2023, 9, 19, 22, 24, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 536,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1968, 5, 5, 0, 31, 26, 0, DateTimeKind.Utc), new DateTime(1968, 5, 5, 0, 31, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 537,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2007, 7, 11, 23, 53, 38, 0, DateTimeKind.Utc), new DateTime(2007, 7, 11, 23, 53, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 538,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2003, 9, 27, 3, 43, 27, 0, DateTimeKind.Utc), new DateTime(2003, 9, 27, 3, 43, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 539,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1929, 6, 9, 10, 0, 16, 0, DateTimeKind.Utc), new DateTime(1929, 6, 9, 10, 0, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 540,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1908, 11, 21, 0, 31, 6, 0, DateTimeKind.Utc), new DateTime(1908, 11, 21, 0, 31, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 541,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1909, 6, 19, 17, 16, 52, 0, DateTimeKind.Utc), new DateTime(1909, 6, 19, 17, 16, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 542,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2012, 3, 12, 4, 23, 26, 0, DateTimeKind.Utc), new DateTime(2012, 3, 12, 4, 23, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 543,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1994, 3, 9, 16, 13, 39, 0, DateTimeKind.Utc), new DateTime(1994, 3, 9, 16, 13, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 544,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 10, 1, 4, 42, 55, 0, DateTimeKind.Utc), new DateTime(1979, 10, 1, 4, 42, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 545,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1935, 2, 11, 21, 56, 33, 0, DateTimeKind.Utc), new DateTime(1935, 2, 11, 21, 56, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 546,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1988, 10, 2, 6, 53, 25, 0, DateTimeKind.Utc), new DateTime(1988, 10, 2, 6, 53, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 547,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2022, 2, 14, 1, 13, 30, 0, DateTimeKind.Utc), new DateTime(2022, 2, 14, 1, 13, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 548,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 1, 3, 20, 40, 44, 0, DateTimeKind.Utc), new DateTime(1902, 1, 3, 20, 40, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 549,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2021, 5, 21, 1, 22, 39, 0, DateTimeKind.Utc), new DateTime(2021, 5, 21, 1, 22, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 550,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1908, 10, 22, 17, 25, 9, 0, DateTimeKind.Utc), new DateTime(1908, 10, 22, 17, 25, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 551,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 1, 9, 20, 28, 33, 0, DateTimeKind.Utc), new DateTime(1962, 1, 9, 20, 28, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 552,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1946, 6, 11, 21, 42, 6, 0, DateTimeKind.Utc), new DateTime(1946, 6, 11, 21, 42, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 553,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1922, 7, 18, 12, 9, 37, 0, DateTimeKind.Utc), new DateTime(1922, 7, 18, 12, 9, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 554,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2004, 5, 13, 14, 54, 31, 0, DateTimeKind.Utc), new DateTime(2004, 5, 13, 14, 54, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 555,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2000, 8, 13, 9, 12, 59, 0, DateTimeKind.Utc), new DateTime(2000, 8, 13, 9, 12, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 556,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1981, 3, 20, 7, 33, 12, 0, DateTimeKind.Utc), new DateTime(1981, 3, 20, 7, 33, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 557,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 2, 17, 12, 28, 11, 0, DateTimeKind.Utc), new DateTime(1925, 2, 17, 12, 28, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 558,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1944, 1, 20, 15, 53, 48, 0, DateTimeKind.Utc), new DateTime(1944, 1, 20, 15, 53, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 559,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 7, 21, 3, 54, 58, 0, DateTimeKind.Utc), new DateTime(1902, 7, 21, 3, 54, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 560,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1987, 10, 4, 18, 3, 49, 0, DateTimeKind.Utc), new DateTime(1987, 10, 4, 18, 3, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 561,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1910, 11, 8, 9, 13, 27, 0, DateTimeKind.Utc), new DateTime(1910, 11, 8, 9, 13, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 562,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1951, 10, 1, 10, 18, 59, 0, DateTimeKind.Utc), new DateTime(1951, 10, 1, 10, 18, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 563,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1901, 4, 28, 6, 15, 48, 0, DateTimeKind.Utc), new DateTime(1901, 4, 28, 6, 15, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 564,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2003, 2, 22, 15, 21, 38, 0, DateTimeKind.Utc), new DateTime(2003, 2, 22, 15, 21, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 565,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1928, 6, 10, 17, 36, 40, 0, DateTimeKind.Utc), new DateTime(1928, 6, 10, 17, 36, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 566,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1909, 6, 4, 18, 25, 29, 0, DateTimeKind.Utc), new DateTime(1909, 6, 4, 18, 25, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 567,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2013, 11, 25, 5, 12, 0, 0, DateTimeKind.Utc), new DateTime(2013, 11, 25, 5, 12, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 568,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1997, 7, 7, 18, 6, 35, 0, DateTimeKind.Utc), new DateTime(1997, 7, 7, 18, 6, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 569,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 5, 18, 7, 55, 52, 0, DateTimeKind.Utc), new DateTime(2024, 5, 18, 7, 55, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 570,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1906, 5, 18, 15, 9, 42, 0, DateTimeKind.Utc), new DateTime(1906, 5, 18, 15, 9, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 571,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1914, 8, 8, 8, 19, 50, 0, DateTimeKind.Utc), new DateTime(1914, 8, 8, 8, 19, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 572,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2010, 3, 25, 11, 21, 16, 0, DateTimeKind.Utc), new DateTime(2010, 3, 25, 11, 21, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 573,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2018, 7, 28, 17, 52, 44, 0, DateTimeKind.Utc), new DateTime(2018, 7, 28, 17, 52, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 574,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1948, 6, 12, 17, 43, 10, 0, DateTimeKind.Utc), new DateTime(1948, 6, 12, 17, 43, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 575,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 9, 16, 5, 42, 58, 0, DateTimeKind.Utc), new DateTime(1902, 9, 16, 5, 42, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 576,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2008, 4, 23, 3, 6, 30, 0, DateTimeKind.Utc), new DateTime(2008, 4, 23, 3, 6, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 577,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1993, 5, 9, 9, 51, 51, 0, DateTimeKind.Utc), new DateTime(1993, 5, 9, 9, 51, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 578,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1988, 6, 3, 8, 20, 19, 0, DateTimeKind.Utc), new DateTime(1988, 6, 3, 8, 20, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 579,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2012, 4, 17, 20, 14, 39, 0, DateTimeKind.Utc), new DateTime(2012, 4, 17, 20, 14, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 580,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1934, 5, 28, 1, 18, 31, 0, DateTimeKind.Utc), new DateTime(1934, 5, 28, 1, 18, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 581,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1936, 8, 16, 21, 36, 4, 0, DateTimeKind.Utc), new DateTime(1936, 8, 16, 21, 36, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 582,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1955, 9, 14, 11, 59, 25, 0, DateTimeKind.Utc), new DateTime(1955, 9, 14, 11, 59, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 583,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1955, 11, 18, 13, 1, 12, 0, DateTimeKind.Utc), new DateTime(1955, 11, 18, 13, 1, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 584,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1910, 8, 13, 5, 19, 23, 0, DateTimeKind.Utc), new DateTime(1910, 8, 13, 5, 19, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 585,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1948, 1, 2, 3, 52, 43, 0, DateTimeKind.Utc), new DateTime(1948, 1, 2, 3, 52, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 586,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1963, 8, 4, 18, 6, 12, 0, DateTimeKind.Utc), new DateTime(1963, 8, 4, 18, 6, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 587,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1938, 9, 26, 0, 54, 33, 0, DateTimeKind.Utc), new DateTime(1938, 9, 26, 0, 54, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 588,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2005, 5, 10, 3, 25, 14, 0, DateTimeKind.Utc), new DateTime(2005, 5, 10, 3, 25, 14, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 589,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 9, 11, 18, 59, 38, 0, DateTimeKind.Utc), new DateTime(1902, 9, 11, 18, 59, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 590,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1908, 2, 10, 3, 30, 36, 0, DateTimeKind.Utc), new DateTime(1908, 2, 10, 3, 30, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 591,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 4, 26, 18, 57, 19, 0, DateTimeKind.Utc), new DateTime(1902, 4, 26, 18, 57, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 592,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1936, 8, 25, 9, 14, 12, 0, DateTimeKind.Utc), new DateTime(1936, 8, 25, 9, 14, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 593,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1937, 2, 22, 21, 21, 53, 0, DateTimeKind.Utc), new DateTime(1937, 2, 22, 21, 21, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 594,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1905, 3, 17, 19, 7, 8, 0, DateTimeKind.Utc), new DateTime(1905, 3, 17, 19, 7, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 595,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1943, 9, 20, 11, 41, 0, 0, DateTimeKind.Utc), new DateTime(1943, 9, 20, 11, 41, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 596,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2010, 2, 9, 6, 58, 36, 0, DateTimeKind.Utc), new DateTime(2010, 2, 9, 6, 58, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 597,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 1, 14, 23, 51, 43, 0, DateTimeKind.Utc), new DateTime(1979, 1, 14, 23, 51, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 598,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1942, 7, 14, 3, 28, 53, 0, DateTimeKind.Utc), new DateTime(1942, 7, 14, 3, 28, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 599,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2007, 3, 21, 10, 5, 15, 0, DateTimeKind.Utc), new DateTime(2007, 3, 21, 10, 5, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 600,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1901, 3, 5, 18, 24, 12, 0, DateTimeKind.Utc), new DateTime(1901, 3, 5, 18, 24, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 601,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1980, 9, 1, 21, 31, 4, 0, DateTimeKind.Utc), new DateTime(1980, 9, 1, 21, 31, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 602,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2012, 1, 4, 3, 14, 16, 0, DateTimeKind.Utc), new DateTime(2012, 1, 4, 3, 14, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 603,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 1, 11, 20, 26, 29, 0, DateTimeKind.Utc), new DateTime(1950, 1, 11, 20, 26, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 604,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1982, 3, 8, 18, 37, 29, 0, DateTimeKind.Utc), new DateTime(1982, 3, 8, 18, 37, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 605,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1932, 6, 2, 1, 15, 43, 0, DateTimeKind.Utc), new DateTime(1932, 6, 2, 1, 15, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 606,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1952, 10, 20, 6, 21, 2, 0, DateTimeKind.Utc), new DateTime(1952, 10, 20, 6, 21, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 607,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1990, 6, 4, 9, 14, 27, 0, DateTimeKind.Utc), new DateTime(1990, 6, 4, 9, 14, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 608,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1996, 8, 27, 11, 1, 2, 0, DateTimeKind.Utc), new DateTime(1996, 8, 27, 11, 1, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 609,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2008, 2, 23, 16, 5, 11, 0, DateTimeKind.Utc), new DateTime(2008, 2, 23, 16, 5, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 610,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2018, 10, 5, 12, 36, 3, 0, DateTimeKind.Utc), new DateTime(2018, 10, 5, 12, 36, 3, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 611,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1900, 10, 22, 9, 43, 22, 0, DateTimeKind.Utc), new DateTime(1900, 10, 22, 9, 43, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 612,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1972, 2, 20, 8, 7, 58, 0, DateTimeKind.Utc), new DateTime(1972, 2, 20, 8, 7, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 613,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1946, 3, 28, 19, 0, 55, 0, DateTimeKind.Utc), new DateTime(1946, 3, 28, 19, 0, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 614,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1969, 9, 13, 0, 10, 5, 0, DateTimeKind.Utc), new DateTime(1969, 9, 13, 0, 10, 5, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 615,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2017, 9, 22, 11, 18, 29, 0, DateTimeKind.Utc), new DateTime(2017, 9, 22, 11, 18, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 616,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2008, 3, 25, 1, 22, 23, 0, DateTimeKind.Utc), new DateTime(2008, 3, 25, 1, 22, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 617,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1985, 5, 28, 13, 52, 52, 0, DateTimeKind.Utc), new DateTime(1985, 5, 28, 13, 52, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 618,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1939, 6, 2, 19, 18, 50, 0, DateTimeKind.Utc), new DateTime(1939, 6, 2, 19, 18, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 619,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 2, 24, 6, 56, 47, 0, DateTimeKind.Utc), new DateTime(1925, 2, 24, 6, 56, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 620,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1976, 11, 19, 16, 27, 59, 0, DateTimeKind.Utc), new DateTime(1976, 11, 19, 16, 27, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 621,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1972, 2, 24, 5, 27, 53, 0, DateTimeKind.Utc), new DateTime(1972, 2, 24, 5, 27, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 622,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1912, 4, 25, 13, 7, 38, 0, DateTimeKind.Utc), new DateTime(1912, 4, 25, 13, 7, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 623,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 11, 27, 13, 42, 38, 0, DateTimeKind.Utc), new DateTime(2019, 11, 27, 13, 42, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 624,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1901, 2, 13, 22, 16, 10, 0, DateTimeKind.Utc), new DateTime(1901, 2, 13, 22, 16, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 625,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1980, 7, 8, 1, 25, 23, 0, DateTimeKind.Utc), new DateTime(1980, 7, 8, 1, 25, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 626,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1989, 1, 26, 23, 58, 46, 0, DateTimeKind.Utc), new DateTime(1989, 1, 26, 23, 58, 46, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 627,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1901, 2, 3, 3, 41, 58, 0, DateTimeKind.Utc), new DateTime(1901, 2, 3, 3, 41, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 628,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 8, 1, 5, 17, 56, 0, DateTimeKind.Utc), new DateTime(2019, 8, 1, 5, 17, 56, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 629,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2005, 1, 8, 0, 38, 19, 0, DateTimeKind.Utc), new DateTime(2005, 1, 8, 0, 38, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 630,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1968, 8, 23, 15, 34, 50, 0, DateTimeKind.Utc), new DateTime(1968, 8, 23, 15, 34, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 631,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1975, 1, 26, 11, 51, 6, 0, DateTimeKind.Utc), new DateTime(1975, 1, 26, 11, 51, 6, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 632,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1988, 11, 1, 4, 32, 35, 0, DateTimeKind.Utc), new DateTime(1988, 11, 1, 4, 32, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 633,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1970, 10, 12, 11, 59, 38, 0, DateTimeKind.Utc), new DateTime(1970, 10, 12, 11, 59, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 634,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1917, 5, 9, 8, 13, 22, 0, DateTimeKind.Utc), new DateTime(1917, 5, 9, 8, 13, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 635,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1911, 8, 11, 14, 25, 19, 0, DateTimeKind.Utc), new DateTime(1911, 8, 11, 14, 25, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 636,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2020, 5, 16, 5, 33, 39, 0, DateTimeKind.Utc), new DateTime(2020, 5, 16, 5, 33, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 637,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1905, 6, 23, 21, 30, 19, 0, DateTimeKind.Utc), new DateTime(1905, 6, 23, 21, 30, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 638,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2016, 8, 15, 16, 27, 46, 0, DateTimeKind.Utc), new DateTime(2016, 8, 15, 16, 27, 46, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 639,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2012, 1, 19, 4, 30, 7, 0, DateTimeKind.Utc), new DateTime(2012, 1, 19, 4, 30, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 640,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 3, 23, 12, 23, 9, 0, DateTimeKind.Utc), new DateTime(1964, 3, 23, 12, 23, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 641,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1993, 2, 16, 16, 12, 10, 0, DateTimeKind.Utc), new DateTime(1993, 2, 16, 16, 12, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 642,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1905, 4, 9, 18, 24, 31, 0, DateTimeKind.Utc), new DateTime(1905, 4, 9, 18, 24, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 643,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 3, 27, 23, 24, 33, 0, DateTimeKind.Utc), new DateTime(2006, 3, 27, 23, 24, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 644,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2008, 5, 7, 13, 41, 20, 0, DateTimeKind.Utc), new DateTime(2008, 5, 7, 13, 41, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 645,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1983, 9, 24, 9, 41, 16, 0, DateTimeKind.Utc), new DateTime(1983, 9, 24, 9, 41, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 646,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2003, 6, 3, 15, 9, 23, 0, DateTimeKind.Utc), new DateTime(2003, 6, 3, 15, 9, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 647,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1996, 3, 14, 7, 37, 7, 0, DateTimeKind.Utc), new DateTime(1996, 3, 14, 7, 37, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 648,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1957, 2, 20, 3, 19, 15, 0, DateTimeKind.Utc), new DateTime(1957, 2, 20, 3, 19, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 649,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1922, 6, 25, 6, 40, 57, 0, DateTimeKind.Utc), new DateTime(1922, 6, 25, 6, 40, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 650,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2016, 2, 12, 4, 1, 24, 0, DateTimeKind.Utc), new DateTime(2016, 2, 12, 4, 1, 24, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 651,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1939, 8, 19, 0, 56, 53, 0, DateTimeKind.Utc), new DateTime(1939, 8, 19, 0, 56, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 652,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1954, 3, 3, 13, 13, 9, 0, DateTimeKind.Utc), new DateTime(1954, 3, 3, 13, 13, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 653,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1908, 6, 23, 2, 6, 33, 0, DateTimeKind.Utc), new DateTime(1908, 6, 23, 2, 6, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 654,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1981, 6, 14, 14, 12, 10, 0, DateTimeKind.Utc), new DateTime(1981, 6, 14, 14, 12, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 655,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 7, 24, 2, 41, 59, 0, DateTimeKind.Utc), new DateTime(1950, 7, 24, 2, 41, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 656,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 7, 7, 1, 59, 57, 0, DateTimeKind.Utc), new DateTime(2019, 7, 7, 1, 59, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 657,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1957, 5, 6, 18, 41, 5, 0, DateTimeKind.Utc), new DateTime(1957, 5, 6, 18, 41, 5, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 658,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1918, 8, 9, 16, 11, 7, 0, DateTimeKind.Utc), new DateTime(1918, 8, 9, 16, 11, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 659,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1919, 10, 2, 20, 32, 28, 0, DateTimeKind.Utc), new DateTime(1919, 10, 2, 20, 32, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 660,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2015, 9, 13, 11, 36, 22, 0, DateTimeKind.Utc), new DateTime(2015, 9, 13, 11, 36, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 661,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 4, 15, 2, 35, 38, 0, DateTimeKind.Utc), new DateTime(1902, 4, 15, 2, 35, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 662,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2017, 1, 16, 19, 38, 40, 0, DateTimeKind.Utc), new DateTime(2017, 1, 16, 19, 38, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 663,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1944, 10, 24, 9, 25, 33, 0, DateTimeKind.Utc), new DateTime(1944, 10, 24, 9, 25, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 664,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 8, 11, 17, 56, 52, 0, DateTimeKind.Utc), new DateTime(2006, 8, 11, 17, 56, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 665,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2015, 1, 1, 17, 8, 15, 0, DateTimeKind.Utc), new DateTime(2015, 1, 1, 17, 8, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 666,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1963, 11, 23, 19, 45, 22, 0, DateTimeKind.Utc), new DateTime(1963, 11, 23, 19, 45, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 667,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1968, 1, 2, 16, 45, 10, 0, DateTimeKind.Utc), new DateTime(1968, 1, 2, 16, 45, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 668,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1971, 4, 5, 9, 30, 40, 0, DateTimeKind.Utc), new DateTime(1971, 4, 5, 9, 30, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 669,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 6, 9, 21, 37, 54, 0, DateTimeKind.Utc), new DateTime(1979, 6, 9, 21, 37, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 670,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1899, 4, 11, 15, 10, 30, 0, DateTimeKind.Utc), new DateTime(1899, 4, 11, 15, 10, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 671,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1975, 3, 25, 6, 18, 39, 0, DateTimeKind.Utc), new DateTime(1975, 3, 25, 6, 18, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 672,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2007, 7, 4, 11, 50, 22, 0, DateTimeKind.Utc), new DateTime(2007, 7, 4, 11, 50, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 673,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 3, 27, 4, 8, 36, 0, DateTimeKind.Utc), new DateTime(1962, 3, 27, 4, 8, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 674,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1986, 7, 17, 8, 6, 35, 0, DateTimeKind.Utc), new DateTime(1986, 7, 17, 8, 6, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 675,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 7, 11, 22, 48, 27, 0, DateTimeKind.Utc), new DateTime(2019, 7, 11, 22, 48, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 676,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 10, 25, 13, 3, 34, 0, DateTimeKind.Utc), new DateTime(2023, 10, 25, 13, 3, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 677,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1935, 4, 1, 12, 30, 56, 0, DateTimeKind.Utc), new DateTime(1935, 4, 1, 12, 30, 56, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 678,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1969, 2, 20, 22, 22, 26, 0, DateTimeKind.Utc), new DateTime(1969, 2, 20, 22, 22, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 679,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2018, 9, 5, 18, 57, 37, 0, DateTimeKind.Utc), new DateTime(2018, 9, 5, 18, 57, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 680,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2014, 3, 3, 6, 19, 41, 0, DateTimeKind.Utc), new DateTime(2014, 3, 3, 6, 19, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 681,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1934, 11, 22, 15, 29, 56, 0, DateTimeKind.Utc), new DateTime(1934, 11, 22, 15, 29, 56, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 682,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 11, 4, 9, 53, 51, 0, DateTimeKind.Utc), new DateTime(1962, 11, 4, 9, 53, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 683,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1972, 2, 2, 15, 47, 56, 0, DateTimeKind.Utc), new DateTime(1972, 2, 2, 15, 47, 56, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 684,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2012, 1, 8, 22, 57, 59, 0, DateTimeKind.Utc), new DateTime(2012, 1, 8, 22, 57, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 685,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1935, 3, 26, 5, 38, 47, 0, DateTimeKind.Utc), new DateTime(1935, 3, 26, 5, 38, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 686,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1958, 1, 28, 8, 14, 34, 0, DateTimeKind.Utc), new DateTime(1958, 1, 28, 8, 14, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 687,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1923, 10, 20, 18, 25, 24, 0, DateTimeKind.Utc), new DateTime(1923, 10, 20, 18, 25, 24, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 688,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1937, 7, 26, 7, 11, 47, 0, DateTimeKind.Utc), new DateTime(1937, 7, 26, 7, 11, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 689,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1973, 4, 13, 3, 22, 17, 0, DateTimeKind.Utc), new DateTime(1973, 4, 13, 3, 22, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 690,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1952, 4, 28, 18, 22, 16, 0, DateTimeKind.Utc), new DateTime(1952, 4, 28, 18, 22, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 691,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1900, 3, 10, 7, 54, 52, 0, DateTimeKind.Utc), new DateTime(1900, 3, 10, 7, 54, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 692,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2009, 3, 27, 11, 26, 53, 0, DateTimeKind.Utc), new DateTime(2009, 3, 27, 11, 26, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 693,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1930, 2, 17, 20, 36, 23, 0, DateTimeKind.Utc), new DateTime(1930, 2, 17, 20, 36, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 694,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1906, 11, 1, 3, 38, 21, 0, DateTimeKind.Utc), new DateTime(1906, 11, 1, 3, 38, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 695,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1940, 4, 18, 16, 54, 52, 0, DateTimeKind.Utc), new DateTime(1940, 4, 18, 16, 54, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 696,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1974, 5, 15, 9, 44, 9, 0, DateTimeKind.Utc), new DateTime(1974, 5, 15, 9, 44, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 697,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1909, 11, 19, 0, 25, 55, 0, DateTimeKind.Utc), new DateTime(1909, 11, 19, 0, 25, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 698,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 2, 24, 13, 54, 13, 0, DateTimeKind.Utc), new DateTime(2006, 2, 24, 13, 54, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 699,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1986, 7, 21, 13, 41, 22, 0, DateTimeKind.Utc), new DateTime(1986, 7, 21, 13, 41, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 700,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1928, 10, 18, 23, 59, 35, 0, DateTimeKind.Utc), new DateTime(1928, 10, 18, 23, 59, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 701,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1928, 3, 10, 1, 51, 0, 0, DateTimeKind.Utc), new DateTime(1928, 3, 10, 1, 51, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 702,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1945, 10, 12, 10, 44, 37, 0, DateTimeKind.Utc), new DateTime(1945, 10, 12, 10, 44, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 703,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1990, 1, 16, 2, 16, 30, 0, DateTimeKind.Utc), new DateTime(1990, 1, 16, 2, 16, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 704,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1965, 9, 12, 9, 58, 18, 0, DateTimeKind.Utc), new DateTime(1965, 9, 12, 9, 58, 18, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 705,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1914, 1, 21, 3, 10, 51, 0, DateTimeKind.Utc), new DateTime(1914, 1, 21, 3, 10, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 706,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1966, 2, 28, 1, 48, 13, 0, DateTimeKind.Utc), new DateTime(1966, 2, 28, 1, 48, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 707,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1972, 9, 8, 19, 11, 3, 0, DateTimeKind.Utc), new DateTime(1972, 9, 8, 19, 11, 3, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 708,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 3, 24, 2, 50, 39, 0, DateTimeKind.Utc), new DateTime(2002, 3, 24, 2, 50, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 709,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 2, 18, 2, 25, 13, 0, DateTimeKind.Utc), new DateTime(2002, 2, 18, 2, 25, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 710,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1921, 10, 7, 0, 55, 50, 0, DateTimeKind.Utc), new DateTime(1921, 10, 7, 0, 55, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 711,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1931, 3, 19, 13, 54, 36, 0, DateTimeKind.Utc), new DateTime(1931, 3, 19, 13, 54, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 712,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 8, 7, 7, 30, 28, 0, DateTimeKind.Utc), new DateTime(1979, 8, 7, 7, 30, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 713,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1928, 8, 17, 8, 35, 43, 0, DateTimeKind.Utc), new DateTime(1928, 8, 17, 8, 35, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 714,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1957, 1, 5, 1, 19, 2, 0, DateTimeKind.Utc), new DateTime(1957, 1, 5, 1, 19, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 715,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1929, 5, 20, 18, 53, 58, 0, DateTimeKind.Utc), new DateTime(1929, 5, 20, 18, 53, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 716,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1899, 7, 25, 10, 34, 57, 0, DateTimeKind.Utc), new DateTime(1899, 7, 25, 10, 34, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 717,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1947, 3, 11, 5, 28, 11, 0, DateTimeKind.Utc), new DateTime(1947, 3, 11, 5, 28, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 718,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1953, 6, 18, 3, 52, 44, 0, DateTimeKind.Utc), new DateTime(1953, 6, 18, 3, 52, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 719,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1978, 10, 7, 12, 34, 54, 0, DateTimeKind.Utc), new DateTime(1978, 10, 7, 12, 34, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 720,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1983, 3, 26, 15, 18, 28, 0, DateTimeKind.Utc), new DateTime(1983, 3, 26, 15, 18, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 721,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2014, 10, 22, 6, 18, 57, 0, DateTimeKind.Utc), new DateTime(2014, 10, 22, 6, 18, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 722,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1974, 9, 4, 15, 57, 19, 0, DateTimeKind.Utc), new DateTime(1974, 9, 4, 15, 57, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 723,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1943, 3, 16, 23, 38, 49, 0, DateTimeKind.Utc), new DateTime(1943, 3, 16, 23, 38, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 724,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 2, 16, 23, 8, 2, 0, DateTimeKind.Utc), new DateTime(1950, 2, 16, 23, 8, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 725,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1990, 6, 28, 22, 45, 23, 0, DateTimeKind.Utc), new DateTime(1990, 6, 28, 22, 45, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 726,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1904, 9, 27, 21, 18, 36, 0, DateTimeKind.Utc), new DateTime(1904, 9, 27, 21, 18, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 727,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 3, 6, 15, 31, 3, 0, DateTimeKind.Utc), new DateTime(1950, 3, 6, 15, 31, 3, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 728,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1974, 1, 25, 22, 8, 19, 0, DateTimeKind.Utc), new DateTime(1974, 1, 25, 22, 8, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 729,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1945, 8, 16, 1, 13, 11, 0, DateTimeKind.Utc), new DateTime(1945, 8, 16, 1, 13, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 730,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2015, 11, 21, 17, 31, 48, 0, DateTimeKind.Utc), new DateTime(2015, 11, 21, 17, 31, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 731,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2021, 8, 2, 17, 34, 11, 0, DateTimeKind.Utc), new DateTime(2021, 8, 2, 17, 34, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 732,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1944, 6, 26, 22, 33, 27, 0, DateTimeKind.Utc), new DateTime(1944, 6, 26, 22, 33, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 733,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 9, 17, 11, 21, 7, 0, DateTimeKind.Utc), new DateTime(1979, 9, 17, 11, 21, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 734,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1919, 9, 11, 15, 34, 4, 0, DateTimeKind.Utc), new DateTime(1919, 9, 11, 15, 34, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 735,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2004, 11, 16, 18, 57, 21, 0, DateTimeKind.Utc), new DateTime(2004, 11, 16, 18, 57, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 736,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2007, 8, 19, 9, 41, 53, 0, DateTimeKind.Utc), new DateTime(2007, 8, 19, 9, 41, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 737,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1900, 10, 13, 16, 33, 39, 0, DateTimeKind.Utc), new DateTime(1900, 10, 13, 16, 33, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 738,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 5, 4, 2, 26, 27, 0, DateTimeKind.Utc), new DateTime(1950, 5, 4, 2, 26, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 739,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1975, 5, 17, 14, 33, 42, 0, DateTimeKind.Utc), new DateTime(1975, 5, 17, 14, 33, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 740,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1953, 4, 2, 23, 54, 35, 0, DateTimeKind.Utc), new DateTime(1953, 4, 2, 23, 54, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 741,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1981, 7, 15, 13, 4, 52, 0, DateTimeKind.Utc), new DateTime(1981, 7, 15, 13, 4, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 742,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1997, 3, 2, 16, 28, 30, 0, DateTimeKind.Utc), new DateTime(1997, 3, 2, 16, 28, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 743,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1985, 6, 7, 16, 14, 8, 0, DateTimeKind.Utc), new DateTime(1985, 6, 7, 16, 14, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 744,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2018, 9, 15, 1, 8, 30, 0, DateTimeKind.Utc), new DateTime(2018, 9, 15, 1, 8, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 745,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1996, 3, 4, 22, 56, 21, 0, DateTimeKind.Utc), new DateTime(1996, 3, 4, 22, 56, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 746,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 1, 27, 20, 1, 57, 0, DateTimeKind.Utc), new DateTime(2002, 1, 27, 20, 1, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 747,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1914, 10, 11, 6, 18, 10, 0, DateTimeKind.Utc), new DateTime(1914, 10, 11, 6, 18, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 748,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1948, 11, 28, 2, 55, 4, 0, DateTimeKind.Utc), new DateTime(1948, 11, 28, 2, 55, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 749,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1957, 8, 3, 22, 1, 9, 0, DateTimeKind.Utc), new DateTime(1957, 8, 3, 22, 1, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 750,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1906, 7, 13, 0, 46, 49, 0, DateTimeKind.Utc), new DateTime(1906, 7, 13, 0, 46, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 751,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1991, 10, 9, 16, 52, 25, 0, DateTimeKind.Utc), new DateTime(1991, 10, 9, 16, 52, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 752,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1967, 10, 13, 6, 34, 23, 0, DateTimeKind.Utc), new DateTime(1967, 10, 13, 6, 34, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 753,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1997, 8, 13, 8, 40, 13, 0, DateTimeKind.Utc), new DateTime(1997, 8, 13, 8, 40, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 754,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1966, 8, 10, 1, 29, 13, 0, DateTimeKind.Utc), new DateTime(1966, 8, 10, 1, 29, 13, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 755,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1934, 10, 1, 19, 46, 26, 0, DateTimeKind.Utc), new DateTime(1934, 10, 1, 19, 46, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 756,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1960, 2, 3, 12, 30, 28, 0, DateTimeKind.Utc), new DateTime(1960, 2, 3, 12, 30, 28, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 757,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2006, 8, 1, 13, 32, 3, 0, DateTimeKind.Utc), new DateTime(2006, 8, 1, 13, 32, 3, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 758,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 2, 5, 16, 8, 19, 0, DateTimeKind.Utc), new DateTime(1977, 2, 5, 16, 8, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 759,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1987, 8, 26, 5, 28, 5, 0, DateTimeKind.Utc), new DateTime(1987, 8, 26, 5, 28, 5, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 760,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1960, 8, 10, 2, 24, 58, 0, DateTimeKind.Utc), new DateTime(1960, 8, 10, 2, 24, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 761,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 9, 3, 0, 48, 27, 0, DateTimeKind.Utc), new DateTime(1950, 9, 3, 0, 48, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 762,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1937, 3, 6, 23, 30, 58, 0, DateTimeKind.Utc), new DateTime(1937, 3, 6, 23, 30, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 763,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1923, 11, 5, 6, 25, 18, 0, DateTimeKind.Utc), new DateTime(1923, 11, 5, 6, 25, 18, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 764,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1906, 7, 22, 16, 5, 3, 0, DateTimeKind.Utc), new DateTime(1906, 7, 22, 16, 5, 3, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 765,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 3, 18, 23, 2, 49, 0, DateTimeKind.Utc), new DateTime(1964, 3, 18, 23, 2, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 766,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1914, 9, 9, 1, 8, 48, 0, DateTimeKind.Utc), new DateTime(1914, 9, 9, 1, 8, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 767,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2021, 7, 11, 16, 22, 53, 0, DateTimeKind.Utc), new DateTime(2021, 7, 11, 16, 22, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 768,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1916, 9, 6, 22, 1, 29, 0, DateTimeKind.Utc), new DateTime(1916, 9, 6, 22, 1, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 769,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2017, 3, 8, 1, 1, 48, 0, DateTimeKind.Utc), new DateTime(2017, 3, 8, 1, 1, 48, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 770,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 9, 19, 0, 29, 32, 0, DateTimeKind.Utc), new DateTime(1925, 9, 19, 0, 29, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 771,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 4, 6, 8, 49, 44, 0, DateTimeKind.Utc), new DateTime(2002, 4, 6, 8, 49, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 772,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1984, 2, 24, 8, 17, 49, 0, DateTimeKind.Utc), new DateTime(1984, 2, 24, 8, 17, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 773,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2015, 5, 7, 21, 31, 21, 0, DateTimeKind.Utc), new DateTime(2015, 5, 7, 21, 31, 21, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 774,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2007, 7, 7, 3, 3, 49, 0, DateTimeKind.Utc), new DateTime(2007, 7, 7, 3, 3, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 775,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1971, 2, 21, 11, 50, 24, 0, DateTimeKind.Utc), new DateTime(1971, 2, 21, 11, 50, 24, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 776,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1917, 11, 4, 20, 52, 3, 0, DateTimeKind.Utc), new DateTime(1917, 11, 4, 20, 52, 3, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 777,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1985, 9, 26, 10, 15, 52, 0, DateTimeKind.Utc), new DateTime(1985, 9, 26, 10, 15, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 778,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 7, 26, 10, 7, 39, 0, DateTimeKind.Utc), new DateTime(1979, 7, 26, 10, 7, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 779,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1971, 4, 6, 7, 9, 54, 0, DateTimeKind.Utc), new DateTime(1971, 4, 6, 7, 9, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 780,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1937, 8, 8, 9, 46, 44, 0, DateTimeKind.Utc), new DateTime(1937, 8, 8, 9, 46, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 781,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1900, 3, 9, 10, 11, 20, 0, DateTimeKind.Utc), new DateTime(1900, 3, 9, 10, 11, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 782,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1986, 1, 15, 4, 11, 44, 0, DateTimeKind.Utc), new DateTime(1986, 1, 15, 4, 11, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 783,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1954, 5, 9, 8, 30, 27, 0, DateTimeKind.Utc), new DateTime(1954, 5, 9, 8, 30, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 784,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2011, 2, 28, 1, 54, 30, 0, DateTimeKind.Utc), new DateTime(2011, 2, 28, 1, 54, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 785,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1923, 10, 23, 5, 31, 11, 0, DateTimeKind.Utc), new DateTime(1923, 10, 23, 5, 31, 11, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 786,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1997, 4, 1, 4, 26, 4, 0, DateTimeKind.Utc), new DateTime(1997, 4, 1, 4, 26, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 787,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1970, 3, 12, 14, 44, 1, 0, DateTimeKind.Utc), new DateTime(1970, 3, 12, 14, 44, 1, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 788,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1917, 5, 5, 11, 50, 44, 0, DateTimeKind.Utc), new DateTime(1917, 5, 5, 11, 50, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 789,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1973, 11, 5, 19, 29, 37, 0, DateTimeKind.Utc), new DateTime(1973, 11, 5, 19, 29, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 790,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1995, 11, 9, 19, 14, 19, 0, DateTimeKind.Utc), new DateTime(1995, 11, 9, 19, 14, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 791,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1967, 6, 16, 7, 23, 53, 0, DateTimeKind.Utc), new DateTime(1967, 6, 16, 7, 23, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 792,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1988, 4, 28, 5, 46, 18, 0, DateTimeKind.Utc), new DateTime(1988, 4, 28, 5, 46, 18, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 793,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1905, 4, 12, 22, 55, 30, 0, DateTimeKind.Utc), new DateTime(1905, 4, 12, 22, 55, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 794,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1942, 9, 1, 1, 37, 33, 0, DateTimeKind.Utc), new DateTime(1942, 9, 1, 1, 37, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 795,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1900, 11, 23, 9, 24, 29, 0, DateTimeKind.Utc), new DateTime(1900, 11, 23, 9, 24, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 796,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1997, 9, 27, 1, 2, 15, 0, DateTimeKind.Utc), new DateTime(1997, 9, 27, 1, 2, 15, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 797,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1957, 10, 1, 6, 45, 34, 0, DateTimeKind.Utc), new DateTime(1957, 10, 1, 6, 45, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 798,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1996, 4, 6, 20, 44, 10, 0, DateTimeKind.Utc), new DateTime(1996, 4, 6, 20, 44, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 799,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 10, 1, 18, 27, 30, 0, DateTimeKind.Utc), new DateTime(1925, 10, 1, 18, 27, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 800,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1938, 6, 24, 23, 17, 25, 0, DateTimeKind.Utc), new DateTime(1938, 6, 24, 23, 17, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 801,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1906, 4, 25, 11, 27, 0, 0, DateTimeKind.Utc), new DateTime(1906, 4, 25, 11, 27, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 802,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1943, 11, 8, 3, 28, 4, 0, DateTimeKind.Utc), new DateTime(1943, 11, 8, 3, 28, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 803,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 1, 28, 10, 16, 16, 0, DateTimeKind.Utc), new DateTime(1962, 1, 28, 10, 16, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 804,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1945, 2, 7, 15, 10, 34, 0, DateTimeKind.Utc), new DateTime(1945, 2, 7, 15, 10, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 805,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1955, 1, 9, 10, 45, 32, 0, DateTimeKind.Utc), new DateTime(1955, 1, 9, 10, 45, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 806,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 6, 16, 13, 11, 26, 0, DateTimeKind.Utc), new DateTime(1950, 6, 16, 13, 11, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 807,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1987, 4, 25, 4, 30, 45, 0, DateTimeKind.Utc), new DateTime(1987, 4, 25, 4, 30, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 808,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2013, 1, 10, 22, 16, 22, 0, DateTimeKind.Utc), new DateTime(2013, 1, 10, 22, 16, 22, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 809,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 10, 7, 13, 37, 7, 0, DateTimeKind.Utc), new DateTime(1964, 10, 7, 13, 37, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 810,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1924, 5, 5, 7, 1, 27, 0, DateTimeKind.Utc), new DateTime(1924, 5, 5, 7, 1, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 811,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1987, 11, 7, 17, 43, 59, 0, DateTimeKind.Utc), new DateTime(1987, 11, 7, 17, 43, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 812,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1964, 11, 26, 13, 44, 59, 0, DateTimeKind.Utc), new DateTime(1964, 11, 26, 13, 44, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 813,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1948, 3, 19, 11, 43, 5, 0, DateTimeKind.Utc), new DateTime(1948, 3, 19, 11, 43, 5, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 814,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1926, 6, 21, 22, 55, 52, 0, DateTimeKind.Utc), new DateTime(1926, 6, 21, 22, 55, 52, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 815,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1938, 10, 24, 10, 21, 45, 0, DateTimeKind.Utc), new DateTime(1938, 10, 24, 10, 21, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 816,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1935, 5, 8, 10, 27, 35, 0, DateTimeKind.Utc), new DateTime(1935, 5, 8, 10, 27, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 817,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1963, 2, 10, 8, 26, 20, 0, DateTimeKind.Utc), new DateTime(1963, 2, 10, 8, 26, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 818,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1958, 11, 4, 5, 10, 24, 0, DateTimeKind.Utc), new DateTime(1958, 11, 4, 5, 10, 24, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 819,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1958, 9, 20, 1, 4, 31, 0, DateTimeKind.Utc), new DateTime(1958, 9, 20, 1, 4, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 820,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1991, 9, 28, 8, 24, 53, 0, DateTimeKind.Utc), new DateTime(1991, 9, 28, 8, 24, 53, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 821,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1916, 2, 16, 3, 15, 19, 0, DateTimeKind.Utc), new DateTime(1916, 2, 16, 3, 15, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 822,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1989, 11, 21, 1, 56, 33, 0, DateTimeKind.Utc), new DateTime(1989, 11, 21, 1, 56, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 823,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1993, 10, 2, 9, 27, 57, 0, DateTimeKind.Utc), new DateTime(1993, 10, 2, 9, 27, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 824,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1991, 1, 19, 10, 56, 37, 0, DateTimeKind.Utc), new DateTime(1991, 1, 19, 10, 56, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 825,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1906, 3, 10, 17, 41, 41, 0, DateTimeKind.Utc), new DateTime(1906, 3, 10, 17, 41, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 826,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1973, 2, 22, 11, 12, 20, 0, DateTimeKind.Utc), new DateTime(1973, 2, 22, 11, 12, 20, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 827,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1996, 4, 21, 19, 30, 12, 0, DateTimeKind.Utc), new DateTime(1996, 4, 21, 19, 30, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 828,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1982, 5, 23, 3, 17, 12, 0, DateTimeKind.Utc), new DateTime(1982, 5, 23, 3, 17, 12, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 829,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1956, 4, 9, 0, 37, 19, 0, DateTimeKind.Utc), new DateTime(1956, 4, 9, 0, 37, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 830,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 8, 5, 22, 3, 0, 0, DateTimeKind.Utc), new DateTime(1925, 8, 5, 22, 3, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 831,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 11, 8, 1, 28, 47, 0, DateTimeKind.Utc), new DateTime(2024, 11, 8, 1, 28, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 832,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1996, 4, 19, 17, 36, 7, 0, DateTimeKind.Utc), new DateTime(1996, 4, 19, 17, 36, 7, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 833,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1928, 11, 16, 11, 46, 32, 0, DateTimeKind.Utc), new DateTime(1928, 11, 16, 11, 46, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 834,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 11, 27, 2, 16, 19, 0, DateTimeKind.Utc), new DateTime(2002, 11, 27, 2, 16, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 835,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1947, 7, 15, 10, 14, 30, 0, DateTimeKind.Utc), new DateTime(1947, 7, 15, 10, 14, 30, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 836,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1921, 10, 8, 16, 48, 31, 0, DateTimeKind.Utc), new DateTime(1921, 10, 8, 16, 48, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 837,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2015, 7, 26, 0, 21, 59, 0, DateTimeKind.Utc), new DateTime(2015, 7, 26, 0, 21, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 838,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1969, 9, 22, 4, 48, 41, 0, DateTimeKind.Utc), new DateTime(1969, 9, 22, 4, 48, 41, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 839,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1993, 9, 26, 14, 7, 8, 0, DateTimeKind.Utc), new DateTime(1993, 9, 26, 14, 7, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 840,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1904, 10, 21, 22, 39, 55, 0, DateTimeKind.Utc), new DateTime(1904, 10, 21, 22, 39, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 841,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1931, 4, 2, 3, 32, 46, 0, DateTimeKind.Utc), new DateTime(1931, 4, 2, 3, 32, 46, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 842,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2004, 6, 4, 1, 32, 9, 0, DateTimeKind.Utc), new DateTime(2004, 6, 4, 1, 32, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 843,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1975, 10, 16, 23, 33, 32, 0, DateTimeKind.Utc), new DateTime(1975, 10, 16, 23, 33, 32, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 844,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1971, 3, 22, 19, 42, 29, 0, DateTimeKind.Utc), new DateTime(1971, 3, 22, 19, 42, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 845,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1972, 7, 20, 3, 39, 55, 0, DateTimeKind.Utc), new DateTime(1972, 7, 20, 3, 39, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 846,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2000, 11, 27, 0, 44, 2, 0, DateTimeKind.Utc), new DateTime(2000, 11, 27, 0, 44, 2, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 847,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2017, 5, 6, 23, 20, 16, 0, DateTimeKind.Utc), new DateTime(2017, 5, 6, 23, 20, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 848,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1972, 8, 7, 18, 59, 18, 0, DateTimeKind.Utc), new DateTime(1972, 8, 7, 18, 59, 18, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 849,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1970, 1, 10, 4, 22, 27, 0, DateTimeKind.Utc), new DateTime(1970, 1, 10, 4, 22, 27, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 850,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1919, 5, 18, 13, 33, 58, 0, DateTimeKind.Utc), new DateTime(1919, 5, 18, 13, 33, 58, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 851,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1906, 8, 25, 4, 14, 33, 0, DateTimeKind.Utc), new DateTime(1906, 8, 25, 4, 14, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 852,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1924, 7, 3, 12, 1, 8, 0, DateTimeKind.Utc), new DateTime(1924, 7, 3, 12, 1, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 853,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1942, 7, 25, 11, 14, 0, 0, DateTimeKind.Utc), new DateTime(1942, 7, 25, 11, 14, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 854,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1933, 10, 16, 9, 34, 33, 0, DateTimeKind.Utc), new DateTime(1933, 10, 16, 9, 34, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 855,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1975, 7, 18, 11, 50, 17, 0, DateTimeKind.Utc), new DateTime(1975, 7, 18, 11, 50, 17, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 856,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1952, 5, 25, 4, 54, 39, 0, DateTimeKind.Utc), new DateTime(1952, 5, 25, 4, 54, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 857,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1948, 5, 14, 15, 33, 23, 0, DateTimeKind.Utc), new DateTime(1948, 5, 14, 15, 33, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 858,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 1, 2, 4, 50, 46, 0, DateTimeKind.Utc), new DateTime(1925, 1, 2, 4, 50, 46, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 859,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1973, 8, 6, 14, 16, 43, 0, DateTimeKind.Utc), new DateTime(1973, 8, 6, 14, 16, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 860,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 8, 4, 7, 34, 37, 0, DateTimeKind.Utc), new DateTime(1950, 8, 4, 7, 34, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 861,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2018, 8, 22, 18, 5, 37, 0, DateTimeKind.Utc), new DateTime(2018, 8, 22, 18, 5, 37, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 862,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1931, 2, 20, 5, 4, 51, 0, DateTimeKind.Utc), new DateTime(1931, 2, 20, 5, 4, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 863,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1965, 7, 8, 4, 10, 31, 0, DateTimeKind.Utc), new DateTime(1965, 7, 8, 4, 10, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 864,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1961, 5, 22, 19, 53, 8, 0, DateTimeKind.Utc), new DateTime(1961, 5, 22, 19, 53, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 865,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1911, 9, 4, 3, 47, 14, 0, DateTimeKind.Utc), new DateTime(1911, 9, 4, 3, 47, 14, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 866,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1966, 1, 23, 20, 42, 50, 0, DateTimeKind.Utc), new DateTime(1966, 1, 23, 20, 42, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 867,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1977, 5, 28, 10, 55, 42, 0, DateTimeKind.Utc), new DateTime(1977, 5, 28, 10, 55, 42, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 868,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1910, 5, 18, 8, 4, 39, 0, DateTimeKind.Utc), new DateTime(1910, 5, 18, 8, 4, 39, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 869,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1957, 3, 14, 14, 48, 9, 0, DateTimeKind.Utc), new DateTime(1957, 3, 14, 14, 48, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 870,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2005, 2, 23, 14, 40, 16, 0, DateTimeKind.Utc), new DateTime(2005, 2, 23, 14, 40, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 871,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1963, 2, 10, 10, 40, 59, 0, DateTimeKind.Utc), new DateTime(1963, 2, 10, 10, 40, 59, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 872,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1902, 8, 26, 10, 33, 44, 0, DateTimeKind.Utc), new DateTime(1902, 8, 26, 10, 33, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 873,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1968, 1, 15, 1, 43, 31, 0, DateTimeKind.Utc), new DateTime(1968, 1, 15, 1, 43, 31, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 874,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1965, 9, 21, 10, 39, 33, 0, DateTimeKind.Utc), new DateTime(1965, 9, 21, 10, 39, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 875,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1993, 11, 8, 15, 0, 35, 0, DateTimeKind.Utc), new DateTime(1993, 11, 8, 15, 0, 35, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 876,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1900, 11, 21, 16, 55, 47, 0, DateTimeKind.Utc), new DateTime(1900, 11, 21, 16, 55, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 877,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1943, 8, 20, 14, 18, 23, 0, DateTimeKind.Utc), new DateTime(1943, 8, 20, 14, 18, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 878,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1992, 1, 20, 17, 2, 45, 0, DateTimeKind.Utc), new DateTime(1992, 1, 20, 17, 2, 45, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 879,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1980, 9, 11, 7, 5, 55, 0, DateTimeKind.Utc), new DateTime(1980, 9, 11, 7, 5, 55, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 880,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1966, 1, 13, 18, 41, 44, 0, DateTimeKind.Utc), new DateTime(1966, 1, 13, 18, 41, 44, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 881,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1988, 5, 20, 7, 23, 33, 0, DateTimeKind.Utc), new DateTime(1988, 5, 20, 7, 23, 33, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 882,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1898, 10, 4, 17, 42, 3, 0, DateTimeKind.Utc), new DateTime(1898, 10, 4, 17, 42, 3, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 883,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2002, 11, 13, 8, 42, 36, 0, DateTimeKind.Utc), new DateTime(2002, 11, 13, 8, 42, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 884,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2009, 1, 26, 12, 0, 14, 0, DateTimeKind.Utc), new DateTime(2009, 1, 26, 12, 0, 14, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 885,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1923, 8, 26, 19, 9, 51, 0, DateTimeKind.Utc), new DateTime(1923, 8, 26, 19, 9, 51, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 886,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1939, 7, 28, 23, 54, 56, 0, DateTimeKind.Utc), new DateTime(1939, 7, 28, 23, 54, 56, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 887,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1987, 5, 19, 3, 44, 10, 0, DateTimeKind.Utc), new DateTime(1987, 5, 19, 3, 44, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 888,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1975, 11, 2, 7, 28, 10, 0, DateTimeKind.Utc), new DateTime(1975, 11, 2, 7, 28, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 889,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1956, 3, 10, 20, 54, 40, 0, DateTimeKind.Utc), new DateTime(1956, 3, 10, 20, 54, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 890,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2004, 3, 11, 10, 6, 40, 0, DateTimeKind.Utc), new DateTime(2004, 3, 11, 10, 6, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 891,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1979, 2, 20, 6, 23, 8, 0, DateTimeKind.Utc), new DateTime(1979, 2, 20, 6, 23, 8, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 892,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1909, 10, 1, 12, 38, 16, 0, DateTimeKind.Utc), new DateTime(1909, 10, 1, 12, 38, 16, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 893,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2020, 9, 8, 17, 54, 4, 0, DateTimeKind.Utc), new DateTime(2020, 9, 8, 17, 54, 4, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 894,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1920, 10, 8, 17, 22, 57, 0, DateTimeKind.Utc), new DateTime(1920, 10, 8, 17, 22, 57, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 895,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1962, 6, 19, 7, 7, 43, 0, DateTimeKind.Utc), new DateTime(1962, 6, 19, 7, 7, 43, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 896,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1971, 3, 9, 23, 29, 34, 0, DateTimeKind.Utc), new DateTime(1971, 3, 9, 23, 29, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 897,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1958, 4, 16, 22, 14, 36, 0, DateTimeKind.Utc), new DateTime(1958, 4, 16, 22, 14, 36, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 898,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1919, 11, 16, 1, 53, 9, 0, DateTimeKind.Utc), new DateTime(1919, 11, 16, 1, 53, 9, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 899,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 2, 8, 6, 16, 14, 0, DateTimeKind.Utc), new DateTime(1950, 2, 8, 6, 16, 14, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 900,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 11, 23, 17, 46, 54, 0, DateTimeKind.Utc), new DateTime(1950, 11, 23, 17, 46, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 901,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1956, 9, 21, 6, 56, 23, 0, DateTimeKind.Utc), new DateTime(1956, 9, 21, 6, 56, 23, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 902,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2019, 11, 8, 16, 14, 34, 0, DateTimeKind.Utc), new DateTime(2019, 11, 8, 16, 14, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 903,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1966, 3, 18, 15, 33, 25, 0, DateTimeKind.Utc), new DateTime(1966, 3, 18, 15, 33, 25, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 904,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1949, 5, 17, 12, 53, 0, 0, DateTimeKind.Utc), new DateTime(1949, 5, 17, 12, 53, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 905,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1955, 4, 28, 2, 33, 34, 0, DateTimeKind.Utc), new DateTime(1955, 4, 28, 2, 33, 34, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 906,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1995, 9, 16, 15, 27, 26, 0, DateTimeKind.Utc), new DateTime(1995, 9, 16, 15, 27, 26, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 907,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2008, 10, 1, 4, 6, 54, 0, DateTimeKind.Utc), new DateTime(2008, 10, 1, 4, 6, 54, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 908,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2012, 8, 25, 16, 44, 0, 0, DateTimeKind.Utc), new DateTime(2012, 8, 25, 16, 44, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 909,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1974, 9, 10, 9, 19, 19, 0, DateTimeKind.Utc), new DateTime(1974, 9, 10, 9, 19, 19, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 910,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1939, 11, 26, 17, 49, 38, 0, DateTimeKind.Utc), new DateTime(1939, 11, 26, 17, 49, 38, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 911,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1949, 10, 12, 16, 56, 29, 0, DateTimeKind.Utc), new DateTime(1949, 10, 12, 16, 56, 29, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 912,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1899, 11, 23, 4, 46, 40, 0, DateTimeKind.Utc), new DateTime(1899, 11, 23, 4, 46, 40, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 913,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1950, 3, 10, 16, 36, 10, 0, DateTimeKind.Utc), new DateTime(1950, 3, 10, 16, 36, 10, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 914,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1916, 9, 16, 23, 29, 47, 0, DateTimeKind.Utc), new DateTime(1916, 9, 16, 23, 29, 47, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 915,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1925, 5, 12, 5, 17, 30, 0, DateTimeKind.Utc), new DateTime(1925, 5, 12, 5, 17, 30, 0, DateTimeKind.Utc) });
        }
    }
}
