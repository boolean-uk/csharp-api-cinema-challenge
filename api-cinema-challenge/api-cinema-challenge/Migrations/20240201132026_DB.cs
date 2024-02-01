using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class DB : Migration
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
                    num_seats = table.Column<int>(type: "integer", nullable: false),
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

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "Id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1660), "charlesjagger@gov.gr", "CharlesJagger", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1661) },
                    { 2, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1670), "audreytrump@nasa.org.us", "AudreyTrump", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1671) },
                    { 3, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1676), "charlesmiddleton@gov.gr", "CharlesMiddleton", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1676) },
                    { 4, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1680), "katehepburn@google.com", "KateHepburn", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1681) },
                    { 5, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1685), "katejagger@gov.gr", "KateJagger", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1685) },
                    { 6, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1692), "jimitrump@gov.gr", "JimiTrump", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1692) },
                    { 7, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1696), "elvisjagger@tesla.com", "ElvisJagger", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1696) },
                    { 8, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1700), "donaldtrump@gov.ru", "DonaldTrump", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1700) },
                    { 9, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1704), "barackwinfrey@theworld.ca", "BarackWinfrey", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1704) },
                    { 10, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1710), "elviswinslet@gov.ru", "ElvisWinslet", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1710) },
                    { 11, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1714), "charleswinfrey@gov.gr", "CharlesWinfrey", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1714) },
                    { 12, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1718), "barackwindsor@google.com", "BarackWindsor", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1718) },
                    { 13, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1722), "katewinfrey@bbc.co.uk", "KateWinfrey", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1722) },
                    { 14, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1726), "audreymiddleton@theworld.ca", "AudreyMiddleton", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1726) },
                    { 15, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1778), "elvishendrix@gov.gr", "ElvisHendrix", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1779) },
                    { 16, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1783), "donaldtrump@gov.nl", "DonaldTrump", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1784) },
                    { 17, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1788), "oprahpresley@gov.ru", "OprahPresley", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1788) },
                    { 18, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1795), "oprahobama@gov.nl", "OprahObama", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1795) },
                    { 19, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1799), "oprahwinfrey@tesla.com", "OprahWinfrey", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1799) },
                    { 20, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1803), "donaldhendrix@nasa.org.us", "DonaldHendrix", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1803) },
                    { 21, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1808), "katemiddleton@gov.gr", "KateMiddleton", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1808) },
                    { 22, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1812), "charleshendrix@bbc.co.uk", "CharlesHendrix", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1813) },
                    { 23, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1817), "katewindsor@gov.us", "KateWindsor", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1817) },
                    { 24, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1821), "elviswinfrey@gov.us", "ElvisWinfrey", "21234", new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1821) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "description", "rating", "runtime_mins", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A young lion prince is betrayed and exiled from his kingdom, but he must return to reclaim his birthright and overthrow the evil usurper who took his place.", "R", "240", "Back to the Future", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A man is wrongly convicted of murder and sentenced to life in Shawshank State Penitentiary, where he befriends a fellow inmate and finds hope in the face of adversity.", "PG", "240", "Forrest Gump", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A troubled young Batman confronts the Joker, a psychopathic criminal who plunges Gotham City into chaos.", "G", "240", "Pulp Fiction", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A man's obsession with self-improvement takes a dark turn.", "NC-17", "240", "Inception", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A young farm boy named Luke Skywalker joins a rebel alliance to fight against the evil Galactic Empire.", "R", "240", "The Shawshank Redemption", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A thief learns that he has the ability to enter people's dreams, and he uses this ability to steal information from others.", "PG", "240", "Fight Club", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A businessman saved from the Holocaust becomes determined to rescue others during the war.", "PG-13", "240", "Spirited Away", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Three gunslingers ride into a small town seeking a fortune in gold buried beneath it.", "PG-13", "240", "Star Wars: Episode IV - A New Hope", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A thief learns that he has the ability to enter people's dreams, and he uses this ability to steal information from others.", "NC-17", "240", "Spirited Away", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A hobbit named Frodo Baggins inherits the One Ring, an object of immense power that must be destroyed in the fires of Mount Doom in order to save Middle-earth from the Dark Lord Sauron.", "NC-17", "240", "Forrest Gump", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A thief learns that he has the ability to enter people's dreams, and he uses this ability to steal information from others.", "G", "240", "Back to the Future", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A family heads to an isolated hotel for the winter where they are isolated from the outside world and soon begin to experience strange and terrifying events.", "PG", "240", "The Matrix", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Three gunslingers ride into a small town seeking a fortune in gold buried beneath it.", "G", "240", "Fight Club", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A computer hacker learns that reality is not what it seems when he joins a group of freedom fighters who use advanced technology to fight against a tyrannical regime.", "PG-13", "240", "Fight Club", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A businessman saved from the Holocaust becomes determined to rescue others during the war.", "PG", "240", "The Shawshank Redemption", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A jury of 12 men must decide the fate of a man accused of murder, but their own prejudices and preconceptions threaten to derail their deliberations.", "PG-13", "240", "The Matrix", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A hit man, his partner, and a group of gangsters square off in a series of brutal encounters.", "PG", "240", "The Shining", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A family heads to an isolated hotel for the winter where they are isolated from the outside world and soon begin to experience strange and terrifying events.", "PG", "240", "The Matrix", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A family heads to an isolated hotel for the winter where they are isolated from the outside world and soon begin to experience strange and terrifying events.", "PG", "240", "The Lord of the Rings: The Return of the King", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Three gunslingers ride into a small town seeking a fortune in gold buried beneath it.", "R", "240", "Schindler's List", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A young lion prince is betrayed and exiled from his kingdom, but he must return to reclaim his birthright and overthrow the evil usurper who took his place.", "R", "240", "Fight Club", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A computer hacker learns that reality is not what it seems when he joins a group of freedom fighters who use advanced technology to fight against a tyrannical regime.", "NC-17", "240", "Star Wars: Episode IV - A New Hope", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A jury of 12 men must decide the fate of a man accused of murder, but their own prejudices and preconceptions threaten to derail their deliberations.", "G", "240", "The Matrix", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A man with a low IQ but incredible talent for ping-pong becomes an unlikely hero.", "G", "240", "The Shawshank Redemption", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A young farm boy named Luke Skywalker joins a rebel alliance to fight against the evil Galactic Empire.", "G", "240", "Schindler's List", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A powerful Mafia family's aging patriarch transfers control of his empire to his reluctant youngest son.", "G", "240", "The Shawshank Redemption", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A young lion prince is betrayed and exiled from his kingdom, but he must return to reclaim his birthright and overthrow the evil usurper who took his place.", "G", "240", "Star Wars: Episode IV - A New Hope", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A powerful Mafia family's aging patriarch transfers control of his empire to his reluctant youngest son.", "R", "240", "The Shining", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A hobbit named Frodo Baggins inherits the One Ring, an object of immense power that must be destroyed in the fires of Mount Doom in order to save Middle-earth from the Dark Lord Sauron.", "PG-13", "240", "Inception", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "Id", "capacity", "ends_at", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 30, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1901), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(1890), 13, 11, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1889), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1902) },
                    { 2, 73, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1908), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(1907), 20, 15, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1906), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1908) },
                    { 3, 37, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1910), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(1910), 27, 16, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1910), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1911) },
                    { 4, 27, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1913), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(1913), 3, 16, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1912), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1914) },
                    { 5, 95, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1916), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(1915), 14, 17, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1915), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1916) },
                    { 6, 74, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1920), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(1920), 2, 3, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1919), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1920) },
                    { 7, 49, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(1922), 11, 22, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1922), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1923) },
                    { 8, 92, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1926), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(1925), 14, 5, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1925), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1926) },
                    { 9, 88, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1928), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(1928), 22, 5, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1928), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1929) },
                    { 10, 59, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1994), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(1993), 13, 12, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1993), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1994) },
                    { 11, 120, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1996), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(1996), 11, 14, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1995), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1997) },
                    { 12, 60, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1999), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(1999), 23, 21, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1998), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(1999) },
                    { 13, 97, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2002), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(2001), 26, 9, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2001), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2002) },
                    { 14, 58, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2004), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(2004), 15, 3, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2003), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2004) },
                    { 15, 96, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2007), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(2006), 11, 24, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2006), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2007) },
                    { 16, 86, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2009), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(2009), 7, 20, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2008), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2009) },
                    { 17, 90, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2012), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(2011), 3, 9, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2011), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2012) },
                    { 18, 37, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2017), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(2016), 13, 24, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2016), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2017) },
                    { 19, 34, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2019), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(2019), 7, 12, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2019), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2020) },
                    { 20, 99, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2022), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(2021), 23, 19, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2021), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2022) },
                    { 21, 96, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2024), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(2024), 27, 3, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2024), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2025) },
                    { 22, 54, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2027), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(2027), 14, 15, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2026), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2027) },
                    { 23, 48, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2030), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(2029), 10, 21, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2029), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2030) },
                    { 24, 102, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2032), new DateTime(2024, 2, 1, 15, 20, 26, 703, DateTimeKind.Utc).AddTicks(2032), 16, 15, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2031), new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2033) }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "created_at", "customer_id", "num_seats", "screening_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2035), 5, 1, 9, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2036) },
                    { 2, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2041), 15, 1, 9, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2041) },
                    { 3, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2043), 22, 2, 11, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2043) },
                    { 4, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2044), 3, 1, 15, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2045) },
                    { 5, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2046), 22, 3, 9, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2046) },
                    { 6, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2050), 1, 1, 15, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2050) },
                    { 7, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2052), 1, 1, 4, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2052) },
                    { 8, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2053), 17, 2, 7, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2054) },
                    { 9, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2055), 17, 4, 8, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2055) },
                    { 10, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2059), 3, 4, 9, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2059) },
                    { 11, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2061), 21, 3, 4, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2061) },
                    { 12, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2062), 6, 2, 11, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2063) },
                    { 13, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2064), 15, 2, 17, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2065) },
                    { 14, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2066), 18, 4, 19, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2067) },
                    { 15, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2068), 4, 2, 22, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2068) },
                    { 16, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2070), 14, 1, 21, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2070) },
                    { 17, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2071), 10, 3, 13, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2072) },
                    { 18, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2075), 11, 4, 8, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2075) },
                    { 19, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2077), 18, 3, 22, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2077) },
                    { 20, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2078), 6, 2, 17, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2079) },
                    { 21, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2080), 11, 1, 13, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2080) },
                    { 22, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2082), 2, 2, 19, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2082) },
                    { 23, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2083), 8, 2, 23, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2084) },
                    { 24, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2085), 14, 2, 23, new DateTime(2024, 2, 1, 13, 20, 26, 703, DateTimeKind.Utc).AddTicks(2085) }
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
