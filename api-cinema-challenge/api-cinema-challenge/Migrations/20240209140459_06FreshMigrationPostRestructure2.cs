using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class _06FreshMigrationPostRestructure2 : Migration
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
                    description = table.Column<string>(type: "text", nullable: false),
                    runtime = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fk_screening_id = table.Column<int>(type: "integer", nullable: false),
                    fk_customer_id = table.Column<int>(type: "integer", nullable: false),
                    number_of_seats = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "screenings",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    screen_number = table.Column<int>(type: "integer", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    starts_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fk_movie_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3904), "mick.baker@theworld.ca", "Mick Baker", "81 96 00 67", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3906) },
                    { 2, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3913), "kate.winslet@gov.gr", "Kate Winslet", "43 48 09 95", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3914) },
                    { 3, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3918), "geezer.ward@theworld.ca", "Geezer Ward", "94 64 22 91", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3918) },
                    { 4, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3922), "kate.dio@gov.nl", "Kate Dio", "43 79 01 38", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3923) },
                    { 5, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3927), "jimi.trump@gov.gr", "Jimi Trump", "90 99 19 52", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3928) },
                    { 6, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3933), "ronnie.jagger@gov.gr", "Ronnie Jagger", "76 27 10 36", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3933) },
                    { 7, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3937), "roger.winslet@bbc.co.uk", "Roger Winslet", "82 15 13 30", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3937) },
                    { 8, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3941), "geezer.winfrey@gov.us", "Geezer Winfrey", "45 24 88 28", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3941) },
                    { 9, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3945), "mick.may@google.com", "Mick May", "94 79 08 01", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3946) },
                    { 10, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3950), "audrey.iommi@bbc.co.uk", "Audrey Iommi", "77 75 91 68", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3950) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3956), "The story of Henry Hill and his life in the mafia, covering his relationship with his wife Karen and his mob partners Jimmy Conway and Tommy DeVito.", "R", 148, "Goodfellas", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3956) },
                    { 2, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3958), "In 1980 Miami, a determined Cuban immigrant takes over a drug cartel and succumbs to greed.", "R", 170, "Scarface", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3958) },
                    { 3, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3959), "A family in 1630s New England is torn apart by the forces of witchcraft, black magic and possession.", "R", 93, "The VVitch: A New-England Folktale", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3960) },
                    { 4, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3961), "Vampire Count Orlok expresses interest in a new residence and real estate agent Hutter's wife.", "Not Rated", 94, "Nosferatu", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3961) },
                    { 5, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3963), "When a cockerel apparently flies into a chicken farm, the chickens see him as an opportunity to escape their evil owners.", "G", 84, "Chicken Run", new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3963) }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "created_at", "fk_customer_id", "number_of_seats", "fk_screening_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3987), 8, 0, 5, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3987) },
                    { 2, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3989), 10, 0, 4, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3989) },
                    { 3, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3990), 1, 0, 3, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3990) },
                    { 4, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3991), 1, 0, 3, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3991) },
                    { 5, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3992), 4, 0, 3, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3992) },
                    { 6, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3993), 8, 0, 3, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3993) },
                    { 7, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3994), 2, 0, 2, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3994) },
                    { 8, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3995), 4, 0, 3, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3995) },
                    { 9, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3996), 10, 0, 3, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3996) },
                    { 10, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3997), 2, 0, 5, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3997) },
                    { 11, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3998), 2, 0, 5, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3998) },
                    { 12, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3998), 7, 0, 4, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3998) },
                    { 13, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3999), 1, 0, 5, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3999) },
                    { 14, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4000), 5, 0, 3, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4000) },
                    { 15, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4001), 10, 0, 2, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4001) },
                    { 16, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4029), 10, 0, 1, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4029) },
                    { 17, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4030), 1, 0, 5, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4030) },
                    { 18, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4032), 7, 0, 4, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4032) },
                    { 19, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4032), 6, 0, 3, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4033) },
                    { 20, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4033), 2, 0, 5, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(4033) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "created_at", "fk_movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 119, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3977), 1, 2, new DateTime(2024, 2, 9, 18, 4, 58, 915, DateTimeKind.Utc).AddTicks(3970), new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3977) },
                    { 2, 195, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3979), 3, 2, new DateTime(2024, 2, 9, 18, 4, 58, 915, DateTimeKind.Utc).AddTicks(3979), new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3979) },
                    { 3, 176, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3980), 1, 1, new DateTime(2024, 2, 9, 17, 4, 58, 915, DateTimeKind.Utc).AddTicks(3980), new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3981) },
                    { 4, 112, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3981), 4, 3, new DateTime(2024, 2, 9, 18, 4, 58, 915, DateTimeKind.Utc).AddTicks(3981), new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3982) },
                    { 5, 50, new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3983), 3, 2, new DateTime(2024, 2, 9, 19, 4, 58, 915, DateTimeKind.Utc).AddTicks(3982), new DateTime(2024, 2, 9, 14, 4, 58, 915, DateTimeKind.Utc).AddTicks(3983) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_fk_movie_id",
                table: "screenings",
                column: "fk_movie_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "screenings");

            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
