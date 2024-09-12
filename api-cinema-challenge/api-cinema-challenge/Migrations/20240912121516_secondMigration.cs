using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class secondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    numSeats = table.Column<int>(type: "integer", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    customerId = table.Column<int>(type: "integer", nullable: false),
                    screeningId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.id);
                    table.ForeignKey(
                        name: "FK_tickets_customers_customerId",
                        column: x => x.customerId,
                        principalTable: "customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tickets_screenings_screeningId",
                        column: x => x.screeningId,
                        principalTable: "screenings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(7862), "Ma@snailmail.com", "Mario the Echidna", "+46439195962", new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(7875), "Po@snailmail.com", "Patrick Mario", "+46231430050", new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(7882), "Ya@snailmail.com", "Yoshi the Echidna", "+46509109411", new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(7888), "Ph@snailmail.com", "Patrick Peach", "+46676273396", new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8014), "Pa@snailmail.com", "Princess the Echidna", "+46711484461", new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8024), "Lr@snailmail.com", "Luigi the Dinosaur", "+46965234826", new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8030), "Py@snailmail.com", "Princess Daisy", "+46773878524", new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8036), "Ka@snailmail.com", "Knuckles the Echidna", "+46098848588", new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8042), "Yh@snailmail.com", "Yoshi Peach", "+46275119578", new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8049), "Ls@snailmail.com", "Luigi Cheeks", "+46441437596", new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "description", "rating", "runtimeMins", "title", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8056), "Hold on to your popcorn, cause this movie is filled with incredible action scenes that will leave you speechless", "PG-7", 122, "Beauty & the Trumpet", new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "description", "rating", "runtimeMins", "title", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8060), "Hold on to your popcorn, cause this movie is filled with incredible action scenes that will leave you speechless", "PG-13", 166, "Frog", new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "description", "rating", "runtimeMins", "title", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8062), "Hold on to your popcorn, cause this movie is filled with incredible action scenes that will leave you speechless", "PG-13", 146, "Dystopian Boys", new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "description", "rating", "runtimeMins", "title", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8064), "Hold on to your popcorn, cause this movie is filled with incredible action scenes that will leave you speechless", "PG-7", 233, "Elf on the Boys", new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "createdAt", "description", "runtimeMins", "title", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8065), "This movie will rock your socks with comedy beyond your wildest expectations!", 143, "Saving the Bees", new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "createdAt", "description", "rating", "runtimeMins", "title", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8068), "A sad story filled with drama and anticipation", "PG-7", 62, "Saving the Boys", new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "createdAt", "description", "rating", "runtimeMins", "title", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8069), "This movie will rock your socks with comedy beyond your wildest expectations!", "PG-7", 116, "Shelf", new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "createdAt", "description", "rating", "runtimeMins", "title", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8071), "A sad story filled with drama and anticipation", "PG-13", 89, "Crazy Trumpet", new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "createdAt", "description", "rating", "runtimeMins", "title", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8072), "A sad story filled with drama and anticipation", "PG-3", 89, "Elf on the Trumpet", new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "createdAt", "description", "rating", "runtimeMins", "title", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8075), "A sad story filled with drama and anticipation", "PG-3", 168, "Lady & the Shelf", new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8075) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 40, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8154), 8, 5, new DateTime(2024, 9, 15, 9, 15, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 34, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8208), 1, 2, new DateTime(2024, 9, 13, 13, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 50, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8215), 9, 10, new DateTime(2024, 9, 15, 4, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8215) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "movieId", "startsAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8221), 5, new DateTime(2024, 9, 14, 17, 45, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 36, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8227), 3, 3, new DateTime(2024, 9, 14, 23, 45, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 36, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8234), 10, 3, new DateTime(2024, 9, 13, 7, 45, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8234) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 34, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8241), 4, 2, new DateTime(2024, 9, 12, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 48, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8246), 4, 9, new DateTime(2024, 9, 12, 17, 45, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8246) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "capacity", "createdAt", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 32, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8252), 1, new DateTime(2024, 9, 14, 20, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8252) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 48, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8259), 1, 9, new DateTime(2024, 9, 14, 14, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 46, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8265), 1, 8, new DateTime(2024, 9, 13, 0, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 32, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8272), 5, 1, new DateTime(2024, 9, 13, 17, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8272) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 40, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8278), 5, 5, new DateTime(2024, 9, 15, 5, 45, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8278) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 40, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8284), 2, 5, new DateTime(2024, 9, 12, 16, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "createdAt", "movieId", "startsAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8289), 7, new DateTime(2024, 9, 15, 2, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 32, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8294), 7, 1, new DateTime(2024, 9, 15, 5, 15, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 36, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8300), 6, 3, new DateTime(2024, 9, 13, 20, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 46, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8309), 7, 8, new DateTime(2024, 9, 15, 8, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 46, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8315), 5, 8, new DateTime(2024, 9, 15, 8, 15, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 38, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8321), 1, 4, new DateTime(2024, 9, 13, 9, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8321) });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "createdAt", "customerId", "numSeats", "screeningId", "updatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8327), 7, 3, 17, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8327) },
                    { 2, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8331), 10, 3, 19, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8331) },
                    { 3, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8333), 5, 1, 10, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8333) },
                    { 4, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8334), 2, 2, 8, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8334) },
                    { 5, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8336), 7, 1, 7, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8336) },
                    { 6, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8338), 5, 2, 1, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8338) },
                    { 7, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8339), 3, 3, 5, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8339) },
                    { 8, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8340), 5, 2, 17, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8340) },
                    { 9, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8342), 9, 5, 20, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8342) },
                    { 10, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8344), 10, 4, 20, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8344) },
                    { 11, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8345), 10, 4, 1, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8345) },
                    { 12, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8346), 4, 4, 14, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8346) },
                    { 13, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8347), 2, 5, 13, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8347) },
                    { 14, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8348), 4, 4, 15, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8348) },
                    { 15, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8349), 8, 4, 1, new DateTime(2024, 9, 12, 12, 15, 16, 93, DateTimeKind.Utc).AddTicks(8349) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tickets_customerId",
                table: "tickets",
                column: "customerId");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_screeningId",
                table: "tickets",
                column: "screeningId");
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
                columns: new[] { "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4889), "Ps@snailmail.com", "Princess Squarepants", "+46304255506", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4899), "Yo@snailmail.com", "Yoshi Mario", "+46742181602", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4904), "Mr@snailmail.com", "Mario Star", "+46322218750", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4907), "Sy@snailmail.com", "Spongebob Daisy", "+46188924328", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4912), "Mh@snailmail.com", "Mario Peach", "+46961720906", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4918), "Sa@snailmail.com", "Spongebob the Echidna", "+46584419699", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4923), "Sa@snailmail.com", "Spongebob the Echidna", "+46277861519", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4927), "Dr@snailmail.com", "Donkey Star", "+46493408740", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4931), "Sr@snailmail.com", "Sonic the Dinosaur", "+46825755504", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4936), "Sr@snailmail.com", "Sandy Star", "+46770207150", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4936) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "description", "rating", "runtimeMins", "title", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4943), "The universal bestselling love story, now adapted into a movie", "PG-3", 69, "Saving the Trumpet", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "description", "rating", "runtimeMins", "title", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4946), "A sad story filled with drama and anticipation", "PG-18", 154, "Beauty & the Trumpet", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "description", "rating", "runtimeMins", "title", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4948), "This movie will rock your socks with comedy beyond your wildest expectations!", "PG-3", 209, "Elf on the Boys", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4948) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "description", "rating", "runtimeMins", "title", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4949), "There has been a murder in town, can they solve the mystery before it is too late?", "PG-3", 158, "Crazy Trumpet", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "createdAt", "description", "runtimeMins", "title", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4951), "Got a date around the corner? Grab your significant other and enjoy a sensational and emotional story unfold like never before", 113, "Elf on the Bees", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "createdAt", "description", "rating", "runtimeMins", "title", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4953), "This movie will rock your socks with comedy beyond your wildest expectations!", "PG-13", 117, "Lady & the Beast", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "createdAt", "description", "rating", "runtimeMins", "title", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4955), "A sad story filled with drama and anticipation", "PG-13", 135, "The Shelf", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "createdAt", "description", "rating", "runtimeMins", "title", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4956), "This movie will rock your socks with comedy beyond your wildest expectations!", "PG-7", 149, "Saving the Frog", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4956) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "createdAt", "description", "rating", "runtimeMins", "title", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4957), "The universal bestselling love story, now adapted into a movie", "PG-18", 61, "Beauty & the Shelf", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "createdAt", "description", "rating", "runtimeMins", "title", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4959), "This movie will rock your socks with comedy beyond your wildest expectations!", "PG-18", 172, "Dystopian Boys", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 48, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5030), 1, 9, new DateTime(2024, 9, 15, 3, 45, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 46, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5079), 3, 8, new DateTime(2024, 9, 15, 1, 15, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 48, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5083), 3, 9, new DateTime(2024, 9, 12, 15, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5083) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "movieId", "startsAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5087), 10, new DateTime(2024, 9, 12, 22, 15, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 34, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5091), 7, 2, new DateTime(2024, 9, 14, 7, 45, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 34, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5095), 8, 2, new DateTime(2024, 9, 13, 22, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 50, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5099), 5, 10, new DateTime(2024, 9, 14, 1, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5099) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 34, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5102), 7, 2, new DateTime(2024, 9, 12, 19, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "capacity", "createdAt", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 42, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5106), 6, new DateTime(2024, 9, 14, 4, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5106) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 46, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5110), 2, 8, new DateTime(2024, 9, 13, 0, 45, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 44, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5114), 9, 7, new DateTime(2024, 9, 13, 16, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 34, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5117), 7, 2, new DateTime(2024, 9, 13, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 36, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5121), 9, 3, new DateTime(2024, 9, 13, 19, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5121) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 34, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5124), 9, 2, new DateTime(2024, 9, 12, 23, 45, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5124) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "createdAt", "movieId", "startsAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5127), 6, new DateTime(2024, 9, 15, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 36, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5130), 5, 3, new DateTime(2024, 9, 14, 3, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 48, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5133), 10, 9, new DateTime(2024, 9, 14, 3, 15, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 44, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5137), 9, 7, new DateTime(2024, 9, 13, 0, 15, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5137) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 42, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5141), 7, 6, new DateTime(2024, 9, 13, 7, 45, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[] { 34, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5144), 2, 2, new DateTime(2024, 9, 14, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5144) });
        }
    }
}
