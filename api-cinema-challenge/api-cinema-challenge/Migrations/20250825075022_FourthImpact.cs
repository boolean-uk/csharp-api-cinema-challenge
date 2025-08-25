using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class FourthImpact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "tickets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "tickets",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "tickets",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "CustomerId", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "CustomerId", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_tickets_CustomerId",
                table: "tickets",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_customers_CustomerId",
                table: "tickets",
                column: "CustomerId",
                principalTable: "customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tickets_customers_CustomerId",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_tickets_CustomerId",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "tickets");
        }
    }
}
