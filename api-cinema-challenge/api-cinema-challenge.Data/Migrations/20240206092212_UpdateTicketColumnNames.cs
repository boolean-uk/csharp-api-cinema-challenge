using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTicketColumnNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
