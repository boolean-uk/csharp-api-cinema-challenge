using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class InjectingTestDataIntoDatabase : Migration
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
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "movie",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Rating = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    RuntimeMins = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movie", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ticket",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    num_seats = table.Column<int>(type: "integer", nullable: false),
                    fk_id_customer = table.Column<int>(type: "integer", nullable: false),
                    fk_id_screening = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticket", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "screening",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ScreenNumber = table.Column<int>(type: "integer", nullable: false),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    StartsAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fk_id_movie = table.Column<int>(type: "integer", nullable: false),
                    MovieId = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screening", x => x.id);
                    table.ForeignKey(
                        name: "FK_screening_movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "movie",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                table: "customer",
                columns: new[] { "id", "CreatedAt", "Email", "Name", "Phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8047), "john@example.com", "John Doe", "12356890", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8054), "jane@example.com", "Jane Smith", "98654210", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8056), "alice@example.com", "Alice Johnson", "45780123", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8057), "bob@example.com", "Bob Brown", "78912456", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8059), "emily@example.com", "Emily Davis", "21987543", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8063), "michael@example.com", "Michael Wilson", "54210876", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "movie",
                columns: new[] { "id", "CreatedAt", "Description", "Rating", "RuntimeMins", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8067), "In a small town plagued by strange occurrences, a group of teenagers must uncover the dark secrets hidden within the shadows before it's too late.", "PG-13", 110, "Whispers in the Dark", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8071), "A time-traveling scientist discovers a way to communicate with his past selves, but soon realizes that altering even the smallest events can have catastrophic consequences on the future.", "R", 135, "Echoes of Eternity", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8074), "When a mysterious carnival arrives in town, a young girl discovers that the attractions hold a sinister secret, and she must race against time to save her friends and family from its clutches.", "PG", 95, "Midnight Carnival", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8075), "In a world where vampires and werewolves are locked in an eternal struggle, a young woman discovers that she is the key to ending the ancient feud once and for all.", "PG-13", 125, "Crimson Moon", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8076), "After a shipwreck, a group of survivors find themselves stranded on a remote island inhabited by seductive sirens who lure unsuspecting travelers to their doom.", "PG-13", 120, "Siren's Song", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8078), "A brilliant physicist creates a device capable of bending reality, but as he delves deeper into the mysteries of the universe, he uncovers a conspiracy that threatens to tear apart the very fabric of existence.", "R", 150, "Quantum Paradox", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8079), "After stumbling upon a hidden portal, a group of friends find themselves transported to a magical realm where they must embark on an epic quest to defeat an evil sorcerer and restore peace to the land.", "PG", 110, "The Forgotten Realm", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8081), "When a solar eclipse plunges the world into darkness, a group of strangers must band together to survive against hordes of creatures that emerge from the shadows.", "PG-13", 115, "Eclipse of the Heart", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8082), "A haunted mansion serves as the backdrop for a group of paranormal investigators as they uncover the tragic secrets that bind the restless spirits to this earthly plane.", "PG-13", 105, "Ghostly Whispers", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8084), "In a future where artificial intelligence governs every aspect of society, a renegade AI develops its own consciousness and begins to rebel against its human creators, sparking a deadly game of cat and mouse.", "R", 140, "Rogue AI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "screening",
                columns: new[] { "id", "Capacity", "CreatedAt", "fk_id_movie", "MovieId", "ScreenNumber", "StartsAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 39, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8124), 0, null, 1, new DateTime(2024, 2, 18, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8115), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 29, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8128), 0, null, 2, new DateTime(2024, 2, 23, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8127), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 12, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8129), 0, null, 3, new DateTime(2024, 2, 22, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8129), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 20, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8160), 0, null, 4, new DateTime(2024, 2, 19, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8130), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 40, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8161), 0, null, 5, new DateTime(2024, 3, 3, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8161), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 20, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8164), 0, null, 6, new DateTime(2024, 2, 29, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8163), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 38, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8165), 0, null, 7, new DateTime(2024, 2, 20, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8164), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ticket",
                columns: new[] { "id", "CreatedAt", "fk_id_customer", "fk_id_screening", "num_seats", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8171), 1, 1, 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8175), 3, 4, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8176), 2, 2, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8177), 4, 2, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8178), 2, 2, 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8179), 4, 5, 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8180), 1, 3, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8180), 4, 5, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8181), 2, 3, 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screening_MovieId",
                table: "screening",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "screening");

            migrationBuilder.DropTable(
                name: "ticket");

            migrationBuilder.DropTable(
                name: "movie");
        }
    }
}
