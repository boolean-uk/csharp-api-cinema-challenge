using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class initDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    imdb_rating = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    runtime_min = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "screenings",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    number = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fk_movie_id = table.Column<int>(type: "integer", nullable: false),
                    MovieId1 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => x.id);
                    table.ForeignKey(
                        name: "FK_screenings_movies_MovieId1",
                        column: x => x.MovieId1,
                        principalTable: "movies",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_screenings_movies_fk_movie_id",
                        column: x => x.fk_movie_id,
                        principalTable: "movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7601), "Marshall42@gmail.com", "Marshall Delgado", "909 11 881", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7606), "Lily89@experis.com", "Lily Pritchett", "888 22 999", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7626), "Marshall16@experis.com", "Marshall Dunpy", "888 22 999", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7629), "Ted68@live.com", "Ted Dunpy", "888 22 999", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7631), "Marshall86@hotmail.com", "Marshall Pritchett", "222 25 555", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7634), "Marshall64@live.com", "Marshall Thorpe", "909 11 881", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7636), "Robin6@live.com", "Robin Delgado", "909 11 881", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7638), "Lily52@gmail.com", "Lily Thorpe", "888 22 999", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7639), "Robin92@live.com", "Robin Thorpe", "909 11 881", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7642), "Lily7@gmail.com", "Lily Thorpe", "909 11 881", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7643), "Barney50@experis.com", "Barney Dunpy", "909 11 881", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7645), "Lily64@gmail.com", "Lily Thorpe", "222 25 555", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7646), "Marshall94@gmail.com", "Marshall Pritchett", "222 25 555", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7648), "Ted17@experis.com", "Ted Dunpy", "909 11 881", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7649), "Barney65@hotmail.com", "Barney Delgado", "909 11 881", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7650), "Lily78@gmail.com", "Lily Delgado", "909 11 881", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7652), "Ted6@experis.com", "Ted Dunpy", "909 11 881", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7655), "Ted12@live.com", "Ted Pritchett", "888 22 999", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7657), "Ted23@gmail.com", "Ted Thorpe", "909 11 881", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7659), "Ted38@hotmail.com", "Ted Pritchett", "222 25 555", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "description", "imdb_rating", "runtime_min", "title" },
                values: new object[,]
                {
                    { 1, "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "9.3", 142, "The Shawshank Redemption" },
                    { 2, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", "9.2", 175, "The Godfather" },
                    { 3, "When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", "9.0", 152, "The Dark Knight" },
                    { 4, "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "8.9", 154, "Pulp Fiction" },
                    { 5, "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", "8.8", 148, "Inception" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_fk_movie_id",
                table: "screenings",
                column: "fk_movie_id");

            migrationBuilder.CreateIndex(
                name: "IX_screenings_MovieId1",
                table: "screenings",
                column: "MovieId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "screenings");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
