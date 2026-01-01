using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class please : Migration
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
                    rating = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    runetime_mins = table.Column<int>(type: "integer", nullable: false),
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
                    movie_id = table.Column<int>(type: "integer", nullable: false),
                    screen_number = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => x.id);
                    table.ForeignKey(
                        name: "FK_screenings_movies_movie_id",
                        column: x => x.movie_id,
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
                    num_seats = table.Column<int>(type: "integer", nullable: false),
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    { 1, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7349), "johndoe@example.com", "John Doe", "555-1234", new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7351) },
                    { 2, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7712), "janesmith@example.com", "Jane Smith", "555-5678", new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7714) },
                    { 3, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7716), "michaelj@example.com", "Michael Johnson", "555-9876", new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7718) },
                    { 4, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7720), "emilyd@example.com", "Emily Davis", "555-4321", new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7722) },
                    { 5, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7725), "chriswilliams@example.com", "Chris Williams", "555-8765", new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7726) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "Description", "rating", "runetime_mins", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 28, 21, 15, 22, 207, DateTimeKind.Utc).AddTicks(5052), "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "R", 142, "The Shawshank Redemption", new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(5638) },
                    { 2, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(6984), "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", "R", 175, "The Godfather", new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(6990) },
                    { 3, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(6993), "When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", "PG-13", 152, "The Dark Knight", new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(6995) },
                    { 4, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(6997), "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an extraordinary, though simple, life.", "PG-13", 142, "Forrest Gump", new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(6999) },
                    { 5, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7001), "A thief who enters the dreams of others to steal secrets from their subconscious is given the inverse task of planting an idea into the mind of a CEO.", "PG-13", 148, "Inception", new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7003) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8369), 1, 1, new DateTime(2025, 1, 28, 22, 15, 22, 209, DateTimeKind.Utc).AddTicks(8668), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8372) },
                    { 2, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8776), 1, 1, new DateTime(2025, 1, 28, 23, 15, 22, 209, DateTimeKind.Utc).AddTicks(8780), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8778) },
                    { 3, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8783), 1, 1, new DateTime(2025, 1, 29, 0, 15, 22, 209, DateTimeKind.Utc).AddTicks(8786), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8784) },
                    { 4, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8789), 1, 1, new DateTime(2025, 1, 29, 1, 15, 22, 209, DateTimeKind.Utc).AddTicks(8793), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8791) },
                    { 5, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8795), 2, 1, new DateTime(2025, 1, 29, 2, 15, 22, 209, DateTimeKind.Utc).AddTicks(8798), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8796) },
                    { 6, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8800), 2, 2, new DateTime(2025, 1, 28, 22, 15, 22, 209, DateTimeKind.Utc).AddTicks(8804), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8802) },
                    { 7, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8827), 2, 2, new DateTime(2025, 1, 28, 23, 15, 22, 209, DateTimeKind.Utc).AddTicks(8832), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8829) },
                    { 8, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8834), 2, 2, new DateTime(2025, 1, 29, 0, 15, 22, 209, DateTimeKind.Utc).AddTicks(8838), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8836) },
                    { 9, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8840), 2, 2, new DateTime(2025, 1, 29, 1, 15, 22, 209, DateTimeKind.Utc).AddTicks(8843), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8841) },
                    { 10, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8845), 2, 2, new DateTime(2025, 1, 29, 2, 15, 22, 209, DateTimeKind.Utc).AddTicks(8849), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8847) },
                    { 11, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8851), 3, 3, new DateTime(2025, 1, 28, 22, 15, 22, 209, DateTimeKind.Utc).AddTicks(8854), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8852) },
                    { 12, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8856), 3, 3, new DateTime(2025, 1, 28, 23, 15, 22, 209, DateTimeKind.Utc).AddTicks(8860), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8858) },
                    { 13, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8862), 3, 3, new DateTime(2025, 1, 29, 0, 15, 22, 209, DateTimeKind.Utc).AddTicks(8865), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8863) },
                    { 14, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8867), 3, 3, new DateTime(2025, 1, 29, 1, 15, 22, 209, DateTimeKind.Utc).AddTicks(8871), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8869) },
                    { 15, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8873), 3, 3, new DateTime(2025, 1, 29, 2, 15, 22, 209, DateTimeKind.Utc).AddTicks(8876), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8874) },
                    { 16, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8878), 1, 1, new DateTime(2025, 1, 29, 3, 15, 22, 209, DateTimeKind.Utc).AddTicks(8882), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8880) },
                    { 17, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8884), 1, 1, new DateTime(2025, 1, 29, 4, 15, 22, 209, DateTimeKind.Utc).AddTicks(8888), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8885) },
                    { 18, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8890), 1, 1, new DateTime(2025, 1, 29, 5, 15, 22, 209, DateTimeKind.Utc).AddTicks(8893), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8891) },
                    { 19, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8895), 1, 1, new DateTime(2025, 1, 29, 6, 15, 22, 209, DateTimeKind.Utc).AddTicks(8899), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8897) },
                    { 20, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8915), 2, 1, new DateTime(2025, 1, 29, 7, 15, 22, 209, DateTimeKind.Utc).AddTicks(8919), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8917) },
                    { 21, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8921), 2, 2, new DateTime(2025, 1, 29, 3, 15, 22, 209, DateTimeKind.Utc).AddTicks(8925), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8923) },
                    { 22, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8927), 2, 2, new DateTime(2025, 1, 29, 4, 15, 22, 209, DateTimeKind.Utc).AddTicks(8930), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8928) },
                    { 23, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8932), 2, 2, new DateTime(2025, 1, 29, 5, 15, 22, 209, DateTimeKind.Utc).AddTicks(8936), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8934) },
                    { 24, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8938), 2, 2, new DateTime(2025, 1, 29, 6, 15, 22, 209, DateTimeKind.Utc).AddTicks(8941), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8939) },
                    { 25, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8943), 2, 2, new DateTime(2025, 1, 29, 7, 15, 22, 209, DateTimeKind.Utc).AddTicks(8947), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8945) },
                    { 26, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8949), 3, 3, new DateTime(2025, 1, 29, 3, 15, 22, 209, DateTimeKind.Utc).AddTicks(8952), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8950) },
                    { 27, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8954), 3, 3, new DateTime(2025, 1, 29, 4, 15, 22, 209, DateTimeKind.Utc).AddTicks(8958), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8956) },
                    { 28, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8960), 3, 3, new DateTime(2025, 1, 29, 5, 15, 22, 209, DateTimeKind.Utc).AddTicks(8963), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8961) },
                    { 29, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8965), 3, 3, new DateTime(2025, 1, 29, 6, 15, 22, 209, DateTimeKind.Utc).AddTicks(8969), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8967) },
                    { 30, 50, new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8971), 3, 3, new DateTime(2025, 1, 29, 7, 15, 22, 209, DateTimeKind.Utc).AddTicks(8974), new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8972) }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "created_at", "customer_id", "num_seats", "screening_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(579), 1, 4, 1, new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(587) },
                    { 2, new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(895), 2, 2, 2, new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(897) },
                    { 3, new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(900), 3, 4, 2, new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(901) },
                    { 4, new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(904), 4, 1, 3, new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(905) },
                    { 5, new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(908), 5, 1, 3, new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(909) },
                    { 6, new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(911), 5, 1, 3, new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(913) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_movie_id",
                table: "screenings",
                column: "movie_id");

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
