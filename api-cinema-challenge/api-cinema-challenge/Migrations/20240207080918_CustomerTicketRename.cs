using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class CustomerTicketRename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CusomterTickets_customers_CustomerId",
                table: "CusomterTickets");

            migrationBuilder.DropForeignKey(
                name: "FK_CusomterTickets_tickets_TicketId",
                table: "CusomterTickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CusomterTickets",
                table: "CusomterTickets");

            migrationBuilder.RenameTable(
                name: "CusomterTickets",
                newName: "customer_tickets");

            migrationBuilder.RenameColumn(
                name: "TicketId",
                table: "customer_tickets",
                newName: "ticket_id");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "customer_tickets",
                newName: "customer_id");

            migrationBuilder.RenameIndex(
                name: "IX_CusomterTickets_TicketId",
                table: "customer_tickets",
                newName: "IX_customer_tickets_ticket_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customer_tickets",
                table: "customer_tickets",
                columns: new[] { "customer_id", "ticket_id" });

            migrationBuilder.AddForeignKey(
                name: "FK_customer_tickets_customers_customer_id",
                table: "customer_tickets",
                column: "customer_id",
                principalTable: "customers",
                principalColumn: "customer_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_customer_tickets_tickets_ticket_id",
                table: "customer_tickets",
                column: "ticket_id",
                principalTable: "tickets",
                principalColumn: "ticket_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customer_tickets_customers_customer_id",
                table: "customer_tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_customer_tickets_tickets_ticket_id",
                table: "customer_tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customer_tickets",
                table: "customer_tickets");

            migrationBuilder.RenameTable(
                name: "customer_tickets",
                newName: "CusomterTickets");

            migrationBuilder.RenameColumn(
                name: "ticket_id",
                table: "CusomterTickets",
                newName: "TicketId");

            migrationBuilder.RenameColumn(
                name: "customer_id",
                table: "CusomterTickets",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_customer_tickets_ticket_id",
                table: "CusomterTickets",
                newName: "IX_CusomterTickets_TicketId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CusomterTickets",
                table: "CusomterTickets",
                columns: new[] { "CustomerId", "TicketId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CusomterTickets_customers_CustomerId",
                table: "CusomterTickets",
                column: "CustomerId",
                principalTable: "customers",
                principalColumn: "customer_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CusomterTickets_tickets_TicketId",
                table: "CusomterTickets",
                column: "TicketId",
                principalTable: "tickets",
                principalColumn: "ticket_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
