using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class screeningsTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Screenings");

            migrationBuilder.DropColumn(
                name: "Theater",
                table: "Screenings");

            migrationBuilder.RenameColumn(
                name: "ScreeningTime",
                table: "Screenings",
                newName: "StartsAt");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Screenings",
                newName: "ScreenNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartsAt",
                table: "Screenings",
                newName: "ScreeningTime");

            migrationBuilder.RenameColumn(
                name: "ScreenNumber",
                table: "Screenings",
                newName: "MovieId");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Screenings",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Theater",
                table: "Screenings",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
