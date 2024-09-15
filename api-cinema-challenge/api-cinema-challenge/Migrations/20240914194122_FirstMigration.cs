using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    names = table.Column<string>(type: "text", nullable: false),
                    emails = table.Column<string>(type: "text", nullable: false),
                    phoneNumbers = table.Column<string>(type: "text", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "Screening",
                columns: table => new
                {
                    ScreeningId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    StartsAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MovieId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screening", x => x.ScreeningId);
                    table.ForeignKey(
                        name: "FK_Screening_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NumberOfSeats = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    ScreeningId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_Screening_ScreeningId",
                        column: x => x.ScreeningId,
                        principalTable: "Screening",
                        principalColumn: "ScreeningId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "emails", "names", "phoneNumbers", "createdAt", "updatedAt" },
                values: new object[] { 1, "boby@koak.com", "Bob", "12341512", new DateTime(2024, 9, 14, 19, 41, 21, 396, DateTimeKind.Utc).AddTicks(4341), new DateTime(2024, 9, 14, 19, 41, 21, 396, DateTimeKind.Utc).AddTicks(4343) });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "MovieId", "CreatedAt", "Description", "Rating", "Title", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 9, 14, 19, 41, 21, 396, DateTimeKind.Utc).AddTicks(4455), "Description", 12, "Lion King", new DateTime(2024, 9, 14, 19, 41, 21, 396, DateTimeKind.Utc).AddTicks(4455) });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ScreeningId", "Capacity", "CreatedAt", "MovieId", "StartsAt", "UpdatedAt" },
                values: new object[] { 1, 30, new DateTime(2024, 9, 14, 19, 41, 21, 396, DateTimeKind.Utc).AddTicks(4480), 1, new DateTime(2024, 9, 14, 19, 53, 21, 396, DateTimeKind.Utc).AddTicks(4468), new DateTime(2024, 9, 14, 19, 41, 21, 396, DateTimeKind.Utc).AddTicks(4481) });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "CustomerId", "NumberOfSeats", "ScreeningId", "CreatedAt", "UpdateAt" },
                values: new object[] { 1, 1, 1, 1, new DateTime(2024, 9, 14, 19, 41, 21, 396, DateTimeKind.Utc).AddTicks(4493), new DateTime(2024, 9, 14, 19, 41, 21, 396, DateTimeKind.Utc).AddTicks(4494) });

            migrationBuilder.CreateIndex(
                name: "IX_Screening_MovieId",
                table: "Screening",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_CustomerId",
                table: "Ticket",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ScreeningId",
                table: "Ticket",
                column: "ScreeningId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Screening");

            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
