using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
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
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    description = table.Column<string>(type: "text", nullable: false),
                    runtimeMins = table.Column<int>(type: "integer", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    screenNumber = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    startsAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    movieId = table.Column<int>(type: "integer", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => x.id);
                    table.ForeignKey(
                        name: "FK_screenings_movies_movieId",
                        column: x => x.movieId,
                        principalTable: "movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "createdAt", "email", "name", "phone", "updatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4889), "Ps@snailmail.com", "Princess Squarepants", "+46304255506", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4889) },
                    { 2, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4899), "Yo@snailmail.com", "Yoshi Mario", "+46742181602", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4899) },
                    { 3, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4904), "Mr@snailmail.com", "Mario Star", "+46322218750", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4904) },
                    { 4, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4907), "Sy@snailmail.com", "Spongebob Daisy", "+46188924328", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4907) },
                    { 5, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4912), "Mh@snailmail.com", "Mario Peach", "+46961720906", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4912) },
                    { 6, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4918), "Sa@snailmail.com", "Spongebob the Echidna", "+46584419699", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4918) },
                    { 7, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4923), "Sa@snailmail.com", "Spongebob the Echidna", "+46277861519", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4923) },
                    { 8, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4927), "Dr@snailmail.com", "Donkey Star", "+46493408740", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4927) },
                    { 9, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4931), "Sr@snailmail.com", "Sonic the Dinosaur", "+46825755504", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4931) },
                    { 10, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4936), "Sr@snailmail.com", "Sandy Star", "+46770207150", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4936) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "createdAt", "description", "rating", "runtimeMins", "title", "updatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4943), "The universal bestselling love story, now adapted into a movie", "PG-3", 69, "Saving the Trumpet", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4943) },
                    { 2, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4946), "A sad story filled with drama and anticipation", "PG-18", 154, "Beauty & the Trumpet", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4946) },
                    { 3, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4948), "This movie will rock your socks with comedy beyond your wildest expectations!", "PG-3", 209, "Elf on the Boys", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4948) },
                    { 4, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4949), "There has been a murder in town, can they solve the mystery before it is too late?", "PG-3", 158, "Crazy Trumpet", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4949) },
                    { 5, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4951), "Got a date around the corner? Grab your significant other and enjoy a sensational and emotional story unfold like never before", "PG-3", 113, "Elf on the Bees", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4951) },
                    { 6, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4953), "This movie will rock your socks with comedy beyond your wildest expectations!", "PG-13", 117, "Lady & the Beast", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4953) },
                    { 7, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4955), "A sad story filled with drama and anticipation", "PG-13", 135, "The Shelf", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4955) },
                    { 8, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4956), "This movie will rock your socks with comedy beyond your wildest expectations!", "PG-7", 149, "Saving the Frog", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4956) },
                    { 9, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4957), "The universal bestselling love story, now adapted into a movie", "PG-18", 61, "Beauty & the Shelf", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4957) },
                    { 10, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4959), "This movie will rock your socks with comedy beyond your wildest expectations!", "PG-18", 172, "Dystopian Boys", new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(4959) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "createdAt", "movieId", "screenNumber", "startsAt", "updatedAt" },
                values: new object[,]
                {
                    { 1, 48, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5030), 1, 9, new DateTime(2024, 9, 15, 3, 45, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5030) },
                    { 2, 46, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5079), 3, 8, new DateTime(2024, 9, 15, 1, 15, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5079) },
                    { 3, 48, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5083), 3, 9, new DateTime(2024, 9, 12, 15, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5083) },
                    { 4, 48, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5087), 10, 9, new DateTime(2024, 9, 12, 22, 15, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5087) },
                    { 5, 34, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5091), 7, 2, new DateTime(2024, 9, 14, 7, 45, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5091) },
                    { 6, 34, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5095), 8, 2, new DateTime(2024, 9, 13, 22, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5095) },
                    { 7, 50, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5099), 5, 10, new DateTime(2024, 9, 14, 1, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5099) },
                    { 8, 34, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5102), 7, 2, new DateTime(2024, 9, 12, 19, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5102) },
                    { 9, 42, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5106), 1, 6, new DateTime(2024, 9, 14, 4, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5106) },
                    { 10, 46, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5110), 2, 8, new DateTime(2024, 9, 13, 0, 45, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5110) },
                    { 11, 44, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5114), 9, 7, new DateTime(2024, 9, 13, 16, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5114) },
                    { 12, 34, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5117), 7, 2, new DateTime(2024, 9, 13, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5117) },
                    { 13, 36, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5121), 9, 3, new DateTime(2024, 9, 13, 19, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5121) },
                    { 14, 34, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5124), 9, 2, new DateTime(2024, 9, 12, 23, 45, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5124) },
                    { 15, 32, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5127), 6, 1, new DateTime(2024, 9, 15, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5127) },
                    { 16, 36, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5130), 5, 3, new DateTime(2024, 9, 14, 3, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5130) },
                    { 17, 48, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5133), 10, 9, new DateTime(2024, 9, 14, 3, 15, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5133) },
                    { 18, 44, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5137), 9, 7, new DateTime(2024, 9, 13, 0, 15, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5137) },
                    { 19, 42, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5141), 7, 6, new DateTime(2024, 9, 13, 7, 45, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5141) },
                    { 20, 34, new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5144), 2, 2, new DateTime(2024, 9, 14, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 9, 12, 8, 50, 41, 673, DateTimeKind.Utc).AddTicks(5144) }
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
                name: "customers");

            migrationBuilder.DropTable(
                name: "screenings");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
