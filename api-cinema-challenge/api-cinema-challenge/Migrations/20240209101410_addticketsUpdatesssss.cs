using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class addticketsUpdatesssss : Migration
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
                    runtime_min = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    fk_movie_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => x.id);
                    table.ForeignKey(
                        name: "FK_screenings_movies_fk_movie_id",
                        column: x => x.fk_movie_id,
                        principalTable: "movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    number_of_seats = table.Column<int>(type: "integer", nullable: false),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    screening_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.id);
                    table.ForeignKey(
                        name: "FK_tickets_customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tickets_screenings_screening_id",
                        column: x => x.screening_id,
                        principalTable: "screenings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4297), "Robin53@hotmail.com", "Robin Pritchett", "888 22 999", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4302), "Lily14@gmail.com", "Lily Delgado", "222 25 555", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4304), "Marshall30@experis.com", "Marshall Dunpy", "909 11 881", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4306), "Ted78@gmail.com", "Ted Pritchett", "909 11 881", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4308), "Ted52@gmail.com", "Ted Thorpe", "222 25 555", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4310), "Barney90@hotmail.com", "Barney Pritchett", "888 22 999", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4312), "Barney13@hotmail.com", "Barney Dunpy", "909 11 881", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4318), "Ted11@gmail.com", "Ted Dunpy", "888 22 999", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4319), "Marshall67@gmail.com", "Marshall Thorpe", "888 22 999", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4321), "Robin91@hotmail.com", "Robin Thorpe", "222 25 555", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4322), "Marshall35@live.com", "Marshall Thorpe", "888 22 999", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4324), "Barney4@experis.com", "Barney Dunpy", "888 22 999", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4326), "Ted3@hotmail.com", "Ted Delgado", "888 22 999", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4327), "Lily79@hotmail.com", "Lily Pritchett", "222 25 555", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4328), "Ted51@gmail.com", "Ted Thorpe", "909 11 881", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4330), "Barney49@live.com", "Barney Thorpe", "909 11 881", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4331), "Ted64@experis.com", "Ted Pritchett", "909 11 881", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4333), "Lily84@gmail.com", "Lily Pritchett", "909 11 881", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4357), "Robin60@experis.com", "Robin Delgado", "909 11 881", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4359), "Marshall49@experis.com", "Marshall Thorpe", "888 22 999", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "description", "imdb_rating", "runtime_min", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4362), "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "9.3", 142, "The Shawshank Redemption", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4364), "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", "9.2", 175, "The Godfather", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4365), "When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", "9.0", 152, "The Dark Knight", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4366), "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "8.9", 154, "Pulp Fiction", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4367), "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", "8.8", 148, "Inception", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_fk_movie_id",
                table: "screenings",
                column: "fk_movie_id");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_customer_id",
                table: "tickets",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_screening_id",
                table: "tickets",
                column: "screening_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "screenings");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
