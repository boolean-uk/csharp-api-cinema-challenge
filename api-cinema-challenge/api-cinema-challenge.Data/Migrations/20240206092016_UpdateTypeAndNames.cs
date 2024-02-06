using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTypeAndNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_customers_CustomerId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_screenings_ScreeningId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets");

            migrationBuilder.RenameTable(
                name: "Tickets",
                newName: "tickets");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "tickets",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "NumSeats",
                table: "tickets",
                newName: "num_seats");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "tickets",
                newName: "created_at");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_ScreeningId",
                table: "tickets",
                newName: "IX_tickets_ScreeningId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "starts_at",
                table: "screenings",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "customers",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "customers",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "tickets",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "tickets",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tickets",
                table: "tickets",
                columns: new[] { "CustomerId", "ScreeningId" });

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
                name: "FK_tickets_customers_CustomerId",
                table: "tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_screenings_ScreeningId",
                table: "tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tickets",
                table: "tickets");

            migrationBuilder.RenameTable(
                name: "tickets",
                newName: "Tickets");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Tickets",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "num_seats",
                table: "Tickets",
                newName: "NumSeats");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Tickets",
                newName: "CreatedAt");

            migrationBuilder.RenameIndex(
                name: "IX_tickets_ScreeningId",
                table: "Tickets",
                newName: "IX_Tickets_ScreeningId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tickets",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tickets",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "starts_at",
                table: "screenings",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "customers",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "customers",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets",
                columns: new[] { "CustomerId", "ScreeningId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_customers_CustomerId",
                table: "Tickets",
                column: "CustomerId",
                principalTable: "customers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_screenings_ScreeningId",
                table: "Tickets",
                column: "ScreeningId",
                principalTable: "screenings",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
