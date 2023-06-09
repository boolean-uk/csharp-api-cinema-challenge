using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class MoviesUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ScreeningId",
                table: "Movies",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ScreeningId",
                table: "Movies",
                column: "ScreeningId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Screenings_ScreeningId",
                table: "Movies",
                column: "ScreeningId",
                principalTable: "Screenings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Screenings_ScreeningId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ScreeningId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ScreeningId",
                table: "Movies");
        }
    }
}
