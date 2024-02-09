using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "movieid",
                table: "screens",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CustomerScreen",
                columns: table => new
                {
                    CustomersId = table.Column<int>(type: "integer", nullable: false),
                    ScreeningsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerScreen", x => new { x.CustomersId, x.ScreeningsId });
                    table.ForeignKey(
                        name: "FK_CustomerScreen_customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerScreen_screens_ScreeningsId",
                        column: x => x.ScreeningsId,
                        principalTable: "screens",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "barack@obama.com", "Barack Obama", "+4712345678", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "donald@trump.com", "Donald Trump", "+4787654321", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "joe@biden.com", "Joe Biden", "+4712348765", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "createdAt", "rating", "runtimeMins", "title", "updatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "R", 180, "Oppenheimer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12A", 158, "There Will Be Blood", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12A", 201, "The Lord of the Rings: The Return of the King", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "screens",
                columns: new[] { "id", "capacity", "createdAt", "movieid", "screenNumber", "startsAt", "updatedAt" },
                values: new object[,]
                {
                    { 1, 120, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 80, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 98, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screens_movieid",
                table: "screens",
                column: "movieid");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerScreen_ScreeningsId",
                table: "CustomerScreen",
                column: "ScreeningsId");

            migrationBuilder.AddForeignKey(
                name: "FK_screens_movies_movieid",
                table: "screens",
                column: "movieid",
                principalTable: "movies",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_screens_movies_movieid",
                table: "screens");

            migrationBuilder.DropTable(
                name: "CustomerScreen");

            migrationBuilder.DropIndex(
                name: "IX_screens_movieid",
                table: "screens");

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "screens",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "screens",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "screens",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "movieid",
                table: "screens");
        }
    }
}
