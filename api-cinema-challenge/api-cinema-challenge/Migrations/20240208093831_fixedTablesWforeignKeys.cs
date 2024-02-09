using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class fixedTablesWforeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_screenings_movies_movie_id",
                table: "screenings");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_customers_customer_id",
                table: "tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_screenings_screening_id",
                table: "tickets");

            migrationBuilder.RenameColumn(
                name: "screening_id",
                table: "tickets",
                newName: "ScreeningId");

            migrationBuilder.RenameColumn(
                name: "customer_id",
                table: "tickets",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_tickets_screening_id",
                table: "tickets",
                newName: "IX_tickets_ScreeningId");

            migrationBuilder.RenameIndex(
                name: "IX_tickets_customer_id",
                table: "tickets",
                newName: "IX_tickets_CustomerId");

            migrationBuilder.RenameColumn(
                name: "movie_id",
                table: "screenings",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_screenings_movie_id",
                table: "screenings",
                newName: "IX_screenings_MovieId");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "screenings",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355), new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355), new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355), new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355), new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355), new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355), new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355), new DateTime(2024, 2, 9, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355), new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355), new DateTime(2024, 2, 10, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355), new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355), new DateTime(2024, 2, 11, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355), new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355), new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355), new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355), new DateTime(2024, 2, 8, 9, 38, 30, 981, DateTimeKind.Utc).AddTicks(355) });

            migrationBuilder.AddForeignKey(
                name: "FK_screenings_movies_MovieId",
                table: "screenings",
                column: "MovieId",
                principalTable: "movies",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_customers_CustomerId",
                table: "tickets",
                column: "CustomerId",
                principalTable: "customers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_screenings_ScreeningId",
                table: "tickets",
                column: "ScreeningId",
                principalTable: "screenings",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_screenings_movies_MovieId",
                table: "screenings");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_customers_CustomerId",
                table: "tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_screenings_ScreeningId",
                table: "tickets");

            migrationBuilder.RenameColumn(
                name: "ScreeningId",
                table: "tickets",
                newName: "screening_id");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "tickets",
                newName: "customer_id");

            migrationBuilder.RenameIndex(
                name: "IX_tickets_ScreeningId",
                table: "tickets",
                newName: "IX_tickets_screening_id");

            migrationBuilder.RenameIndex(
                name: "IX_tickets_CustomerId",
                table: "tickets",
                newName: "IX_tickets_customer_id");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "screenings",
                newName: "movie_id");

            migrationBuilder.RenameIndex(
                name: "IX_screenings_MovieId",
                table: "screenings",
                newName: "IX_screenings_movie_id");

            migrationBuilder.AlterColumn<int>(
                name: "movie_id",
                table: "screenings",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 2, 8, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 2, 9, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 2, 10, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 2, 7, 11, 52, 22, 895, DateTimeKind.Utc).AddTicks(1923) });

            migrationBuilder.AddForeignKey(
                name: "FK_screenings_movies_movie_id",
                table: "screenings",
                column: "movie_id",
                principalTable: "movies",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_customers_customer_id",
                table: "tickets",
                column: "customer_id",
                principalTable: "customers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_screenings_screening_id",
                table: "tickets",
                column: "screening_id",
                principalTable: "screenings",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
