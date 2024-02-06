using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class AddFirst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "custommer",
                columns: table => new
                {
                    custommer_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "Date", nullable: false),
                    updated_at = table.Column<DateTime>(type: "Date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_custommer", x => x.custommer_id);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    movie_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "Date", nullable: false),
                    updated_at = table.Column<DateTime>(type: "Date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.movie_id);
                });

            migrationBuilder.CreateTable(
                name: "screening",
                columns: table => new
                {
                    screening_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    screen_number = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    start_at = table.Column<DateTime>(type: "Date", nullable: false),
                    created_at = table.Column<DateTime>(type: "Date", nullable: false),
                    updated_at = table.Column<DateTime>(type: "Date", nullable: true),
                    MovieId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screening", x => x.screening_id);
                    table.ForeignKey(
                        name: "FK_screening_movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "movies",
                        principalColumn: "movie_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ticket",
                columns: table => new
                {
                    ScreeningId = table.Column<int>(type: "integer", nullable: false),
                    CustommerId = table.Column<int>(type: "integer", nullable: false),
                    ticket_id = table.Column<int>(type: "integer", nullable: false),
                    seat_number = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "Date", nullable: false),
                    updated_at = table.Column<DateTime>(type: "Date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticket", x => new { x.ScreeningId, x.CustommerId });
                    table.ForeignKey(
                        name: "FK_ticket_custommer_CustommerId",
                        column: x => x.CustommerId,
                        principalTable: "custommer",
                        principalColumn: "custommer_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ticket_screening_ScreeningId",
                        column: x => x.ScreeningId,
                        principalTable: "screening",
                        principalColumn: "screening_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_screening_MovieId",
                table: "screening",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_CustommerId",
                table: "ticket",
                column: "CustommerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ticket");

            migrationBuilder.DropTable(
                name: "custommer");

            migrationBuilder.DropTable(
                name: "screening");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
