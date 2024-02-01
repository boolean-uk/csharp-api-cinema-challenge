using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    runtime_mins = table.Column<string>(type: "text", nullable: false),
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    screen_number = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ends_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    movie_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => x.Id);
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
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    customer_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.id);
                    table.ForeignKey(
                        name: "FK_tickets_customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tickets_screenings_screening_id",
                        column: x => x.screening_id,
                        principalTable: "screenings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SeatRow = table.Column<string>(type: "text", nullable: false),
                    SeatNumber = table.Column<int>(type: "integer", nullable: false),
                    ScreeningId = table.Column<int>(type: "integer", nullable: false),
                    TicketId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seats_screenings_ScreeningId",
                        column: x => x.ScreeningId,
                        principalTable: "screenings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Seats_tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "tickets",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "Id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5115), "charlespresley@tesla.com", "CharlesPresley", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5116) },
                    { 2, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5121), "elvishepburn@gov.gr", "ElvisHepburn", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5121) },
                    { 3, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5123), "katetrump@gov.us", "KateTrump", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5123) },
                    { 4, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5125), "elvistrump@bbc.co.uk", "ElvisTrump", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5125) },
                    { 5, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5127), "barackobama@gov.ru", "BarackObama", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5127) },
                    { 6, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5130), "kateobama@theworld.ca", "KateObama", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5130) },
                    { 7, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5132), "audreywindsor@nasa.org.us", "AudreyWindsor", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5132) },
                    { 8, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5134), "audreyhepburn@something.com", "AudreyHepburn", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5134) },
                    { 9, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5136), "audreywinslet@something.com", "AudreyWinslet", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5136) },
                    { 10, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5139), "baracktrump@google.com", "BarackTrump", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5139) },
                    { 11, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5141), "charleswinslet@bbc.co.uk", "CharlesWinslet", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5141) },
                    { 12, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5143), "audreypresley@gov.us", "AudreyPresley", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5143) },
                    { 13, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5145), "charlesmiddleton@gov.nl", "CharlesMiddleton", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5145) },
                    { 14, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5147), "audreypresley@google.com", "AudreyPresley", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5147) },
                    { 15, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5149), "donaldwinslet@google.com", "DonaldWinslet", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5149) },
                    { 16, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5151), "katepresley@google.com", "KatePresley", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5151) },
                    { 17, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5153), "oprahhepburn@google.com", "OprahHepburn", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5153) },
                    { 18, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5156), "mickwindsor@gov.ru", "MickWindsor", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5156) },
                    { 19, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5157), "katewinfrey@theworld.ca", "KateWinfrey", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5158) },
                    { 20, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5159), "donaldwinslet@gov.nl", "DonaldWinslet", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5160) },
                    { 21, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5161), "mickwindsor@tesla.com", "MickWindsor", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5162) },
                    { 22, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5163), "elvisobama@gov.nl", "ElvisObama", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5163) },
                    { 23, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5197), "donaldobama@gov.us", "DonaldObama", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5198) },
                    { 24, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5200), "oprahjagger@gov.us", "OprahJagger", "21234", new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5200) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "description", "rating", "runtime_mins", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A family heads to an isolated hotel for the winter where they are isolated from the outside world and soon begin to experience strange and terrifying events.", "G", "240", "Interstellar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A man's obsession with self-improvement takes a dark turn.", "PG-13", "240", "The Shawshank Redemption", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A family heads to an isolated hotel for the winter where they are isolated from the outside world and soon begin to experience strange and terrifying events.", "PG", "240", "Interstellar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Three gunslingers ride into a small town seeking a fortune in gold buried beneath it.", "PG", "240", "The Matrix", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A man with a low IQ but incredible talent for ping-pong becomes an unlikely hero.", "PG", "240", "The Shining", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A former NASA pilot and a group of scientists travel through a wormhole in search of a new home for humanity.", "R", "240", "The Matrix", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A young lion prince is betrayed and exiled from his kingdom, but he must return to reclaim his birthright and overthrow the evil usurper who took his place.", "PG-13", "240", "12 Angry Men", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A former NASA pilot and a group of scientists travel through a wormhole in search of a new home for humanity.", "NC-17", "240", "Spirited Away", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Three gunslingers ride into a small town seeking a fortune in gold buried beneath it.", "PG-13", "240", "The Lion King", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A computer hacker learns that reality is not what it seems when he joins a group of freedom fighters who use advanced technology to fight against a tyrannical regime.", "NC-17", "240", "Forrest Gump", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A young lion prince is betrayed and exiled from his kingdom, but he must return to reclaim his birthright and overthrow the evil usurper who took his place.", "NC-17", "240", "Star Wars: Episode IV - A New Hope", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A thief learns that he has the ability to enter people's dreams, and he uses this ability to steal information from others.", "G", "240", "Fight Club", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A powerful Mafia family's aging patriarch transfers control of his empire to his reluctant youngest son.", "PG-13", "240", "The Lion King", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A man's obsession with self-improvement takes a dark turn.", "G", "240", "The Matrix", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A teenager accidentally travels back in time to 1955 and must race against time to get back to his own era.", "G", "240", "12 Angry Men", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Three gunslingers ride into a small town seeking a fortune in gold buried beneath it.", "NC-17", "240", "Pulp Fiction", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A family heads to an isolated hotel for the winter where they are isolated from the outside world and soon begin to experience strange and terrifying events.", "PG-13", "240", "The Godfather", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A man's obsession with self-improvement takes a dark turn.", "R", "240", "The Good, the Bad and the Ugly", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A man with a low IQ but incredible talent for ping-pong becomes an unlikely hero.", "PG-13", "240", "Schindler's List", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A computer hacker learns that reality is not what it seems when he joins a group of freedom fighters who use advanced technology to fight against a tyrannical regime.", "PG-13", "240", "Forrest Gump", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Three gunslingers ride into a small town seeking a fortune in gold buried beneath it.", "PG", "240", "The Godfather", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A man's obsession with self-improvement takes a dark turn.", "PG-13", "240", "Interstellar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A man is wrongly convicted of murder and sentenced to life in Shawshank State Penitentiary, where he befriends a fellow inmate and finds hope in the face of adversity.", "PG-13", "240", "Fight Club", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A man is wrongly convicted of murder and sentenced to life in Shawshank State Penitentiary, where he befriends a fellow inmate and finds hope in the face of adversity.", "PG", "240", "Forrest Gump", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A man with a low IQ but incredible talent for ping-pong becomes an unlikely hero.", "NC-17", "240", "The Lord of the Rings: The Return of the King", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A man's obsession with self-improvement takes a dark turn.", "PG", "240", "Forrest Gump", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A jury of 12 men must decide the fate of a man accused of murder, but their own prejudices and preconceptions threaten to derail their deliberations.", "G", "240", "The Good, the Bad and the Ugly", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A man with a low IQ but incredible talent for ping-pong becomes an unlikely hero.", "NC-17", "240", "Inception", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A hit man, his partner, and a group of gangsters square off in a series of brutal encounters.", "G", "240", "The Shawshank Redemption", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "Id", "capacity", "ends_at", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 112, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5288), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(5284), 1, 16, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5284), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5289) },
                    { 2, 40, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5339), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(5339), 10, 24, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5339), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5339) },
                    { 3, 29, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5387), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(5387), 2, 21, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5386), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5387) },
                    { 4, 86, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5467), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(5467), 11, 6, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5467), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5467) },
                    { 5, 114, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5515), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(5515), 15, 13, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5515), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5515) },
                    { 6, 98, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5563), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(5563), 23, 1, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5563), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5564) },
                    { 7, 76, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5610), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(5610), 28, 3, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5610), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5610) },
                    { 8, 38, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5658), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(5658), 5, 15, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5658), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5659) },
                    { 9, 44, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5705), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(5705), 23, 11, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5705), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5705) },
                    { 10, 34, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5753), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(5753), 15, 9, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5753), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5754) },
                    { 11, 37, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5800), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(5800), 2, 13, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5800), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5801) },
                    { 12, 83, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5847), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(5847), 24, 19, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5847), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5848) },
                    { 13, 43, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5894), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(5894), 4, 8, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5894), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5895) },
                    { 14, 95, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5971), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(5971), 1, 20, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5971), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(5972) },
                    { 15, 84, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6020), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(6020), 22, 7, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6020), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6021) },
                    { 16, 61, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6067), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(6067), 24, 6, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6067), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6068) },
                    { 17, 74, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6114), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(6114), 18, 16, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6114), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6115) },
                    { 18, 48, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6163), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(6163), 17, 19, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6163), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6163) },
                    { 19, 84, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6211), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(6210), 9, 7, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6210), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6211) },
                    { 20, 85, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6258), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(6258), 4, 12, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6258), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6258) },
                    { 21, 77, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6306), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(6305), 28, 11, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6305), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6306) },
                    { 22, 121, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6382), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(6382), 9, 3, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6381), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6382) },
                    { 23, 95, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6429), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(6429), 11, 18, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6428), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6429) },
                    { 24, 63, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6476), new DateTime(2024, 2, 1, 23, 33, 7, 702, DateTimeKind.Utc).AddTicks(6475), 20, 2, new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6475), new DateTime(2024, 2, 1, 21, 33, 7, 702, DateTimeKind.Utc).AddTicks(6476) }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "ScreeningId", "SeatNumber", "SeatRow", "TicketId" },
                values: new object[,]
                {
                    { -2110061721, 13, 7, "A.", null },
                    { -2109809662, 15, 8, "A.", null },
                    { -2087264783, 15, 1, "A.", null },
                    { -2076250462, 5, 4, "A.", null },
                    { -2053484279, 14, 4, "A.", null },
                    { -2050730818, 13, 6, "A.", null },
                    { -2046072927, 16, 2, "A.", null },
                    { -2028658324, 16, 7, "A.", null },
                    { -2006405433, 17, 2, "A.", null },
                    { -1969178999, 16, 3, "A.", null },
                    { -1963972886, 15, 5, "A.", null },
                    { -1963336898, 9, 1, "A.", null },
                    { -1940104102, 19, 8, "A.", null },
                    { -1939366721, 22, 8, "A.", null },
                    { -1876034056, 11, 8, "A.", null },
                    { -1868140247, 13, 5, "A.", null },
                    { -1851935266, 7, 7, "A.", null },
                    { -1831590021, 7, 2, "A.", null },
                    { -1812522575, 24, 5, "A.", null },
                    { -1808834453, 22, 7, "A.", null },
                    { -1748089102, 1, 6, "A.", null },
                    { -1702133734, 8, 6, "A.", null },
                    { -1691321582, 8, 8, "A.", null },
                    { -1671508371, 11, 1, "A.", null },
                    { -1638323652, 10, 3, "A.", null },
                    { -1597025052, 14, 8, "A.", null },
                    { -1555364135, 10, 7, "A.", null },
                    { -1544649551, 18, 4, "A.", null },
                    { -1496417274, 4, 5, "A.", null },
                    { -1482625747, 4, 1, "A.", null },
                    { -1447398696, 16, 8, "A.", null },
                    { -1415122946, 1, 7, "A.", null },
                    { -1415007251, 19, 2, "A.", null },
                    { -1306380110, 22, 3, "A.", null },
                    { -1304299288, 24, 7, "A.", null },
                    { -1282565272, 18, 3, "A.", null },
                    { -1271780009, 7, 6, "A.", null },
                    { -1252604751, 14, 7, "A.", null },
                    { -1221900435, 15, 3, "A.", null },
                    { -1218013368, 1, 8, "A.", null },
                    { -1188734826, 6, 7, "A.", null },
                    { -1160282265, 23, 6, "A.", null },
                    { -1157954388, 6, 6, "A.", null },
                    { -1137338698, 8, 1, "A.", null },
                    { -1118512080, 12, 4, "A.", null },
                    { -1085835071, 2, 8, "A.", null },
                    { -1084931272, 17, 5, "A.", null },
                    { -1061875407, 6, 3, "A.", null },
                    { -1053890211, 21, 1, "A.", null },
                    { -1044981546, 6, 4, "A.", null },
                    { -1032292885, 23, 7, "A.", null },
                    { -1002163558, 3, 6, "A.", null },
                    { -993097077, 17, 6, "A.", null },
                    { -934618731, 3, 7, "A.", null },
                    { -917471741, 9, 6, "A.", null },
                    { -891949918, 16, 1, "A.", null },
                    { -867578390, 11, 5, "A.", null },
                    { -845418183, 15, 9, "A.", null },
                    { -826603298, 20, 4, "A.", null },
                    { -773885029, 11, 7, "A.", null },
                    { -728502312, 23, 8, "A.", null },
                    { -725278573, 5, 7, "A.", null },
                    { -722497878, 7, 9, "A.", null },
                    { -704065400, 15, 4, "A.", null },
                    { -656469439, 10, 9, "A.", null },
                    { -646186676, 4, 7, "A.", null },
                    { -563839959, 4, 3, "A.", null },
                    { -537838263, 21, 5, "A.", null },
                    { -531673330, 4, 8, "A.", null },
                    { -524580160, 9, 3, "A.", null },
                    { -521812410, 21, 7, "A.", null },
                    { -498443972, 19, 3, "A.", null },
                    { -404357946, 14, 6, "A.", null },
                    { -382696590, 14, 2, "A.", null },
                    { -372352011, 19, 5, "A.", null },
                    { -371559655, 20, 3, "A.", null },
                    { -335277880, 4, 6, "A.", null },
                    { -333253062, 5, 9, "A.", null },
                    { -318149121, 9, 7, "A.", null },
                    { -313708898, 2, 7, "A.", null },
                    { -311076514, 8, 3, "A.", null },
                    { -300929571, 7, 5, "A.", null },
                    { -260038277, 15, 7, "A.", null },
                    { -251860222, 9, 4, "A.", null },
                    { -220684145, 2, 1, "A.", null },
                    { -189785713, 2, 9, "A.", null },
                    { -172718626, 21, 3, "A.", null },
                    { -154697835, 18, 1, "A.", null },
                    { -138292413, 3, 4, "A.", null },
                    { -123873661, 10, 2, "A.", null },
                    { -123821455, 17, 8, "A.", null },
                    { -83540399, 23, 1, "A.", null },
                    { -51418653, 20, 1, "A.", null },
                    { -42994742, 24, 9, "A.", null },
                    { -24549760, 21, 9, "A.", null },
                    { 19741202, 3, 8, "A.", null },
                    { 21248966, 20, 7, "A.", null },
                    { 32221249, 12, 3, "A.", null },
                    { 49144008, 8, 4, "A.", null },
                    { 52233899, 2, 6, "A.", null },
                    { 52240569, 12, 1, "A.", null },
                    { 63961284, 11, 3, "A.", null },
                    { 72048873, 5, 3, "A.", null },
                    { 74405574, 12, 7, "A.", null },
                    { 125663188, 10, 6, "A.", null },
                    { 128666695, 11, 6, "A.", null },
                    { 129012406, 13, 1, "A.", null },
                    { 154042077, 5, 1, "A.", null },
                    { 175414758, 14, 5, "A.", null },
                    { 274130493, 13, 8, "A.", null },
                    { 281144649, 14, 3, "A.", null },
                    { 288235899, 16, 4, "A.", null },
                    { 295691533, 24, 6, "A.", null },
                    { 295786395, 3, 9, "A.", null },
                    { 342628354, 8, 5, "A.", null },
                    { 374420505, 6, 5, "A.", null },
                    { 377270662, 4, 4, "A.", null },
                    { 392028213, 5, 5, "A.", null },
                    { 407160037, 9, 8, "A.", null },
                    { 410966018, 20, 5, "A.", null },
                    { 419132189, 17, 1, "A.", null },
                    { 426247530, 3, 3, "A.", null },
                    { 447208579, 23, 3, "A.", null },
                    { 453542737, 22, 9, "A.", null },
                    { 485472683, 6, 2, "A.", null },
                    { 493755471, 9, 2, "A.", null },
                    { 517487807, 4, 9, "A.", null },
                    { 533796746, 13, 3, "A.", null },
                    { 548897097, 15, 2, "A.", null },
                    { 591168653, 6, 8, "A.", null },
                    { 599896769, 7, 4, "A.", null },
                    { 633166262, 14, 9, "A.", null },
                    { 671211197, 12, 9, "A.", null },
                    { 698185013, 10, 4, "A.", null },
                    { 718267779, 20, 8, "A.", null },
                    { 725689925, 9, 9, "A.", null },
                    { 726472610, 8, 9, "A.", null },
                    { 806598982, 20, 6, "A.", null },
                    { 843590554, 22, 2, "A.", null },
                    { 853842197, 10, 1, "A.", null },
                    { 888247326, 19, 1, "A.", null },
                    { 908116277, 18, 5, "A.", null },
                    { 921614530, 21, 8, "A.", null },
                    { 943748161, 5, 6, "A.", null },
                    { 956785010, 12, 5, "A.", null },
                    { 964440886, 23, 5, "A.", null },
                    { 987635214, 13, 2, "A.", null },
                    { 1000325318, 10, 8, "A.", null },
                    { 1006321202, 1, 2, "A.", null },
                    { 1019913633, 6, 9, "A.", null },
                    { 1041327140, 13, 4, "A.", null },
                    { 1043906026, 23, 2, "A.", null },
                    { 1055664655, 21, 4, "A.", null },
                    { 1057568610, 2, 2, "A.", null },
                    { 1070038150, 21, 6, "A.", null },
                    { 1085356706, 11, 9, "A.", null },
                    { 1122716902, 18, 2, "A.", null },
                    { 1129465222, 5, 2, "A.", null },
                    { 1129853142, 22, 6, "A.", null },
                    { 1146941040, 3, 5, "A.", null },
                    { 1153577552, 9, 5, "A.", null },
                    { 1216203591, 1, 5, "A.", null },
                    { 1246388108, 5, 8, "A.", null },
                    { 1251805048, 12, 8, "A.", null },
                    { 1260042275, 21, 2, "A.", null },
                    { 1281912874, 14, 1, "A.", null },
                    { 1283241997, 2, 4, "A.", null },
                    { 1352143610, 18, 7, "A.", null },
                    { 1365109997, 24, 1, "A.", null },
                    { 1368963694, 19, 6, "A.", null },
                    { 1419416494, 24, 2, "A.", null },
                    { 1444944259, 22, 1, "A.", null },
                    { 1477919999, 7, 3, "A.", null },
                    { 1482341665, 17, 9, "A.", null },
                    { 1497362206, 19, 7, "A.", null },
                    { 1506039212, 15, 6, "A.", null },
                    { 1542669768, 8, 2, "A.", null },
                    { 1549417795, 24, 3, "A.", null },
                    { 1565253906, 10, 5, "A.", null },
                    { 1599398701, 17, 7, "A.", null },
                    { 1615663143, 11, 2, "A.", null },
                    { 1636172517, 16, 5, "A.", null },
                    { 1648987193, 1, 1, "A.", null },
                    { 1653520416, 18, 8, "A.", null },
                    { 1655581964, 12, 2, "A.", null },
                    { 1656966456, 22, 5, "A.", null },
                    { 1670775321, 18, 6, "A.", null },
                    { 1672240630, 3, 2, "A.", null },
                    { 1672789484, 20, 9, "A.", null },
                    { 1730758284, 17, 4, "A.", null },
                    { 1738526519, 8, 7, "A.", null },
                    { 1740083993, 7, 8, "A.", null },
                    { 1747547701, 2, 3, "A.", null },
                    { 1752800953, 11, 4, "A.", null },
                    { 1768517219, 7, 1, "A.", null },
                    { 1796943367, 17, 3, "A.", null },
                    { 1809667771, 1, 9, "A.", null },
                    { 1828114849, 19, 9, "A.", null },
                    { 1838648179, 16, 9, "A.", null },
                    { 1838652547, 23, 9, "A.", null },
                    { 1863771289, 20, 2, "A.", null },
                    { 1906060889, 4, 2, "A.", null },
                    { 1906213421, 19, 4, "A.", null },
                    { 1931701738, 24, 8, "A.", null },
                    { 1945457965, 2, 5, "A.", null },
                    { 1979987466, 1, 3, "A.", null },
                    { 1989742061, 3, 1, "A.", null },
                    { 1993112933, 23, 4, "A.", null },
                    { 2003330133, 22, 4, "A.", null },
                    { 2004569850, 6, 1, "A.", null },
                    { 2051970023, 1, 4, "A.", null },
                    { 2091136371, 12, 6, "A.", null },
                    { 2094150774, 16, 6, "A.", null },
                    { 2094474996, 13, 9, "A.", null },
                    { 2120419420, 24, 4, "A.", null },
                    { 2123054417, 18, 9, "A.", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_movie_id",
                table: "screenings",
                column: "movie_id");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_ScreeningId",
                table: "Seats",
                column: "ScreeningId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_TicketId",
                table: "Seats",
                column: "TicketId");

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
                name: "Seats");

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
