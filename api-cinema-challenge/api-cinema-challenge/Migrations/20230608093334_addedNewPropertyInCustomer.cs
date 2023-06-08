using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class addedNewPropertyInCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ticketId",
                table: "Customers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ticketId",
                table: "Customers",
                column: "ticketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Tickets_ticketId",
                table: "Customers",
                column: "ticketId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Tickets_ticketId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ticketId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ticketId",
                table: "Customers");
        }
    }
}
