using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class LimitCascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookings_customers_customer_id",
                table: "bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_bookings_screenings_screening_id",
                table: "bookings");

            migrationBuilder.AddColumn<bool>(
                name: "available",
                table: "movies",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_customers_customer_id",
                table: "bookings",
                column: "customer_id",
                principalTable: "customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_screenings_screening_id",
                table: "bookings",
                column: "screening_id",
                principalTable: "screenings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookings_customers_customer_id",
                table: "bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_bookings_screenings_screening_id",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "available",
                table: "movies");

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_customers_customer_id",
                table: "bookings",
                column: "customer_id",
                principalTable: "customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_screenings_screening_id",
                table: "bookings",
                column: "screening_id",
                principalTable: "screenings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
