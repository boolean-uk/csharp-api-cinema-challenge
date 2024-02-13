using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class Cinema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    date_updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    runtime_mins = table.Column<int>(type: "integer", nullable: false),
                    time_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    time_updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "screening",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    movie_id = table.Column<int>(type: "integer", nullable: false),
                    screen_num = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    date_updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screening", x => x.id);
                    table.ForeignKey(
                        name: "FK_screening_Movie_movie_id",
                        column: x => x.movie_id,
                        principalTable: "Movie",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ticket",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    num_seats = table.Column<int>(type: "integer", nullable: false),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    date_updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticket", x => x.id);
                    table.ForeignKey(
                        name: "FK_ticket_customer_customer_id",
                        column: x => x.customer_id,
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ticket_screening_screening_id",
                        column: x => x.screening_id,
                        principalTable: "screening",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "id", "description", "rating", "runtime_mins", "time_created", "time_updated", "title" },
                values: new object[,]
                {
                    { 1, "A movie about Microscopic", "4/10", 113, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A bunch of Flowers" },
                    { 2, "A movie about Orange", "2/10", 438, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fifteen Buildings" },
                    { 3, "A movie about Orange", "1/10", 277, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fifteen Cars" },
                    { 4, "A movie about Microscopic", "3/10", 316, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An army of Flowers" },
                    { 5, "A movie about Orange", "2/10", 364, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Several Houses" },
                    { 6, "A movie about Rose Smelling", "1/10", 318, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Leopards" },
                    { 7, "A movie about Orange", "1/10", 236, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Several Planets" },
                    { 8, "A movie about Orange", "3/10", 259, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A bunch of Houses" },
                    { 9, "A movie about Bitter", "9/10", 337, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Several Houses" },
                    { 10, "A movie about Microscopic", "0/10", 84, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Cars" }
                });

            migrationBuilder.InsertData(
                table: "customer",
                columns: new[] { "id", "email", "name", "phone", "date_created", "date_updated" },
                values: new object[,]
                {
                    { 1, "Charles Windsor@bbc.co.uk", "Charles Windsor", "94672250", new DateTime(2024, 2, 12, 14, 12, 9, 618, DateTimeKind.Utc).AddTicks(8926), new DateTime(2024, 2, 12, 14, 12, 9, 618, DateTimeKind.Utc).AddTicks(8926) },
                    { 2, "Jimi Windsor@bbc.co.uk", "Jimi Windsor", "91606802", new DateTime(2024, 2, 12, 14, 12, 9, 618, DateTimeKind.Utc).AddTicks(8957), new DateTime(2024, 2, 12, 14, 12, 9, 618, DateTimeKind.Utc).AddTicks(8957) },
                    { 3, "Barack Winfrey@google.com", "Barack Winfrey", "48288920", new DateTime(2024, 2, 12, 14, 12, 9, 618, DateTimeKind.Utc).AddTicks(8959), new DateTime(2024, 2, 12, 14, 12, 9, 618, DateTimeKind.Utc).AddTicks(8959) },
                    { 4, "Elvis Hepburn@google.com", "Elvis Hepburn", "76939017", new DateTime(2024, 2, 12, 14, 12, 9, 618, DateTimeKind.Utc).AddTicks(8961), new DateTime(2024, 2, 12, 14, 12, 9, 618, DateTimeKind.Utc).AddTicks(8961) },
                    { 5, "Donald Winfrey@something.com", "Donald Winfrey", "77279980", new DateTime(2024, 2, 12, 14, 12, 9, 618, DateTimeKind.Utc).AddTicks(8962), new DateTime(2024, 2, 12, 14, 12, 9, 618, DateTimeKind.Utc).AddTicks(8962) },
                    { 6, "Elvis Windsor@theworld.ca", "Elvis Windsor", "54705178", new DateTime(2024, 2, 12, 14, 12, 9, 618, DateTimeKind.Utc).AddTicks(8964), new DateTime(2024, 2, 12, 14, 12, 9, 618, DateTimeKind.Utc).AddTicks(8964) },
                    { 7, "Elvis Winslet@nasa.org.us", "Elvis Winslet", "63754366", new DateTime(2024, 2, 12, 14, 12, 9, 618, DateTimeKind.Utc).AddTicks(8966), new DateTime(2024, 2, 12, 14, 12, 9, 618, DateTimeKind.Utc).AddTicks(8966) },
                    { 8, "Elvis Presley@bbc.co.uk", "Elvis Presley", "22226343", new DateTime(2024, 2, 12, 14, 12, 9, 618, DateTimeKind.Utc).AddTicks(8967), new DateTime(2024, 2, 12, 14, 12, 9, 618, DateTimeKind.Utc).AddTicks(8967) },
                    { 9, "Donald Hendrix@nasa.org.us", "Donald Hendrix", "20710201", new DateTime(2024, 2, 12, 14, 12, 9, 618, DateTimeKind.Utc).AddTicks(8969), new DateTime(2024, 2, 12, 14, 12, 9, 618, DateTimeKind.Utc).AddTicks(8969) },
                    { 10, "Elvis Winfrey@tesla.com", "Elvis Winfrey", "39737877", new DateTime(2024, 2, 12, 14, 12, 9, 618, DateTimeKind.Utc).AddTicks(8970), new DateTime(2024, 2, 12, 14, 12, 9, 618, DateTimeKind.Utc).AddTicks(8970) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screening_movie_id",
                table: "screening",
                column: "movie_id");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_customer_id",
                table: "ticket",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_screening_id",
                table: "ticket",
                column: "screening_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ticket");

            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "screening");

            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
