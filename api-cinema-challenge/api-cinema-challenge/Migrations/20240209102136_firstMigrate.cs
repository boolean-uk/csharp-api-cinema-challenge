using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class firstMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    runtime = table.Column<int>(type: "integer", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "screenings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    screenNumber = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    startsAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    movieId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_screenings_movies_movieId",
                        column: x => x.movieId,
                        principalTable: "movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customer",
                columns: new[] { "Id", "createdAt", "email", "name", "phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6021), "Charles Presley@gov.ru", "Charles Presley", "44348162", new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6022) },
                    { 2, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6024), "Barack Winslet@bbc.co.uk", "Barack Winslet", "59943377", new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6024) },
                    { 3, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6025), "Audrey Presley@bbc.co.uk", "Audrey Presley", "31878797", new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6025) },
                    { 4, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6026), "Audrey Trump@tesla.com", "Audrey Trump", "97149314", new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6027) },
                    { 5, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6027), "Barack Winslet@gov.us", "Barack Winslet", "61428868", new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6028) },
                    { 6, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6029), "Kate Middleton@something.com", "Kate Middleton", "67137459", new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6030) },
                    { 7, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6031), "Donald Hepburn@google.com", "Donald Hepburn", "97149314", new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6031) },
                    { 8, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6032), "Oprah Middleton@nasa.org.us", "Oprah Middleton", "61428868", new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6032) },
                    { 9, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6033), "Barack Presley@gov.ru", "Barack Presley", "61428868", new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6033) },
                    { 10, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6034), "Jimi Windsor@nasa.org.us", "Jimi Windsor", "97149314", new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6035) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "Id", "createdAt", "description", "rating", "runtime", "title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6002), "Who what where when", "NC-17", 135, "Fifteen Transparent Planets", new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6004) },
                    { 2, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6005), "Boooring", "PG-13", 190, "An army of Zombies", new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6006) },
                    { 3, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6007), "Who what where when", "NC-17", 122, "Two Purple Flowers", new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6007) },
                    { 4, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6008), "Boooring", "PG", 135, "Two Purple Flowers", new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6008) },
                    { 5, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6009), "Very scary", "PG-13", 190, "Fifteen Transparent Planets", new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6009) },
                    { 6, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6010), "Very scary", "R", 122, "The Orange Cars", new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6011) },
                    { 7, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6011), "Lorem ipsum test ummmm", "PG-13", 135, "A herd of Microscopic Flowers", new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6012) },
                    { 8, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6013), "Very scary", "NC-17", 60, "Several", new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6013) },
                    { 9, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6014), "Very scary", "R", 122, "A bunch of Green Men", new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6014) },
                    { 10, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6015), "Very scary", "R", 190, "Two Purple Flowers", new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6015) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "Id", "capacity", "createdAt", "movieId", "screenNumber", "UpdatedAt", "startsAt" },
                values: new object[,]
                {
                    { 1, 84, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6041), 4, 1, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6041), new DateTime(2024, 2, 25, 12, 50, 35, 936, DateTimeKind.Utc).AddTicks(6037) },
                    { 2, 70, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6043), 3, 5, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6044), new DateTime(2024, 2, 19, 0, 23, 35, 936, DateTimeKind.Utc).AddTicks(6043) },
                    { 3, 63, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6045), 2, 3, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6045), new DateTime(2024, 3, 9, 0, 5, 35, 936, DateTimeKind.Utc).AddTicks(6044) },
                    { 4, 24, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6046), 9, 7, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6046), new DateTime(2024, 2, 12, 12, 9, 35, 936, DateTimeKind.Utc).AddTicks(6045) },
                    { 5, 72, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6047), 9, 9, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6047), new DateTime(2024, 3, 10, 21, 55, 35, 936, DateTimeKind.Utc).AddTicks(6047) },
                    { 6, 22, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6049), 3, 8, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6049), new DateTime(2024, 2, 12, 19, 23, 35, 936, DateTimeKind.Utc).AddTicks(6049) },
                    { 7, 35, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6050), 1, 6, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6051), new DateTime(2024, 2, 11, 19, 16, 35, 936, DateTimeKind.Utc).AddTicks(6050) },
                    { 8, 37, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6052), 5, 1, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6052), new DateTime(2024, 2, 23, 0, 16, 35, 936, DateTimeKind.Utc).AddTicks(6051) },
                    { 9, 71, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6053), 1, 9, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6053), new DateTime(2024, 2, 15, 23, 24, 35, 936, DateTimeKind.Utc).AddTicks(6052) },
                    { 10, 25, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6054), 7, 7, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6054), new DateTime(2024, 3, 10, 7, 52, 35, 936, DateTimeKind.Utc).AddTicks(6054) },
                    { 11, 77, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6055), 5, 6, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6055), new DateTime(2024, 2, 20, 15, 1, 35, 936, DateTimeKind.Utc).AddTicks(6055) },
                    { 12, 35, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6056), 9, 8, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6056), new DateTime(2024, 3, 7, 23, 27, 35, 936, DateTimeKind.Utc).AddTicks(6056) },
                    { 13, 75, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6057), 7, 2, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6057), new DateTime(2024, 2, 13, 23, 34, 35, 936, DateTimeKind.Utc).AddTicks(6057) },
                    { 14, 61, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6058), 4, 3, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6058), new DateTime(2024, 3, 7, 4, 6, 35, 936, DateTimeKind.Utc).AddTicks(6058) },
                    { 15, 84, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6059), 5, 6, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6059), new DateTime(2024, 3, 3, 7, 18, 35, 936, DateTimeKind.Utc).AddTicks(6059) },
                    { 16, 41, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6060), 9, 8, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6060), new DateTime(2024, 3, 1, 17, 0, 35, 936, DateTimeKind.Utc).AddTicks(6060) },
                    { 17, 75, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6061), 8, 3, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6061), new DateTime(2024, 3, 1, 14, 1, 35, 936, DateTimeKind.Utc).AddTicks(6061) },
                    { 18, 80, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6063), 6, 9, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6063), new DateTime(2024, 2, 24, 20, 25, 35, 936, DateTimeKind.Utc).AddTicks(6062) },
                    { 19, 67, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6064), 7, 4, new DateTime(2024, 2, 9, 10, 21, 35, 936, DateTimeKind.Utc).AddTicks(6064), new DateTime(2024, 3, 7, 21, 59, 35, 936, DateTimeKind.Utc).AddTicks(6063) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_movieId",
                table: "screenings",
                column: "movieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "screenings");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
