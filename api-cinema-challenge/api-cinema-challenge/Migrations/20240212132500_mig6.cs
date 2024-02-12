using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tickets",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ScreeningsId",
                table: "tickets",
                newName: "screenings_fk");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "tickets",
                newName: "customers_fk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "tickets",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "screenings_fk",
                table: "tickets",
                newName: "ScreeningsId");

            migrationBuilder.RenameColumn(
                name: "customers_fk",
                table: "tickets",
                newName: "CustomerId");
        }
    }
}
