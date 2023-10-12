using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class EightMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ScreenId",
                table: "movies");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "movies",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "movies",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "movies",
                newName: "id");

            migrationBuilder.AddColumn<int>(
                name: "movieId",
                table: "screens",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "movieId",
                table: "screens");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "movies",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "movies",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "movies",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "ScreenId",
                table: "movies",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
