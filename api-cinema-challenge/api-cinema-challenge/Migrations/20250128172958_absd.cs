using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class absd : Migration
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
                });

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    num_seats = table.Column<int>(type: "integer", nullable: false),
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 2, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1401), "johndoe@example.com", "John Doe", "555-1234", new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1403) },
                    { 3, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1725), "janesmith@example.com", "Jane Smith", "555-5678", new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1727) },
                    { 4, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1730), "michaelj@example.com", "Michael Johnson", "555-9876", new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1732) },
                    { 5, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1734), "emilyd@example.com", "Emily Davis", "555-4321", new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1736) },
                    { 6, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1738), "chriswilliams@example.com", "Chris Williams", "555-8765", new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1739) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "Description", "rating", "runetime_mins", "title", "updated_at" },
                values: new object[,]
                {
                    { 2, new DateTime(2025, 1, 28, 17, 29, 51, 805, DateTimeKind.Utc).AddTicks(8696), "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "R", 142, "The Shawshank Redemption", new DateTime(2025, 1, 28, 17, 29, 51, 807, DateTimeKind.Utc).AddTicks(9747) },
                    { 3, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1029), "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", "R", 175, "The Godfather", new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1035) },
                    { 4, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1039), "When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", "PG-13", 152, "The Dark Knight", new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1040) },
                    { 5, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1058), "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an extraordinary, though simple, life.", "PG-13", 142, "Forrest Gump", new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1060) },
                    { 6, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1063), "A thief who enters the dreams of others to steal secrets from their subconscious is given the inverse task of planting an idea into the mind of a CEO.", "PG-13", 148, "Inception", new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1064) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 2, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2366), 1, 1, new DateTime(2025, 1, 28, 18, 29, 51, 808, DateTimeKind.Utc).AddTicks(2668), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2369) },
                    { 3, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2767), 1, 1, new DateTime(2025, 1, 28, 19, 29, 51, 808, DateTimeKind.Utc).AddTicks(2772), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2769) },
                    { 4, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2774), 1, 1, new DateTime(2025, 1, 28, 20, 29, 51, 808, DateTimeKind.Utc).AddTicks(2777), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2775) },
                    { 5, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2779), 1, 1, new DateTime(2025, 1, 28, 21, 29, 51, 808, DateTimeKind.Utc).AddTicks(2783), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2781) },
                    { 6, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2785), 2, 1, new DateTime(2025, 1, 28, 22, 29, 51, 808, DateTimeKind.Utc).AddTicks(2789), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2787) },
                    { 7, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2791), 2, 2, new DateTime(2025, 1, 28, 18, 29, 51, 808, DateTimeKind.Utc).AddTicks(2794), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2792) },
                    { 8, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2796), 2, 2, new DateTime(2025, 1, 28, 19, 29, 51, 808, DateTimeKind.Utc).AddTicks(2800), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2798) },
                    { 9, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2802), 2, 2, new DateTime(2025, 1, 28, 20, 29, 51, 808, DateTimeKind.Utc).AddTicks(2805), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2803) },
                    { 10, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2807), 2, 2, new DateTime(2025, 1, 28, 21, 29, 51, 808, DateTimeKind.Utc).AddTicks(2831), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2809) },
                    { 11, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2833), 2, 2, new DateTime(2025, 1, 28, 22, 29, 51, 808, DateTimeKind.Utc).AddTicks(2837), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2835) },
                    { 12, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2839), 3, 3, new DateTime(2025, 1, 28, 18, 29, 51, 808, DateTimeKind.Utc).AddTicks(2842), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2840) },
                    { 13, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2844), 3, 3, new DateTime(2025, 1, 28, 19, 29, 51, 808, DateTimeKind.Utc).AddTicks(2848), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2846) },
                    { 14, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2850), 3, 3, new DateTime(2025, 1, 28, 20, 29, 51, 808, DateTimeKind.Utc).AddTicks(2853), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2851) },
                    { 15, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2855), 3, 3, new DateTime(2025, 1, 28, 21, 29, 51, 808, DateTimeKind.Utc).AddTicks(2859), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2857) },
                    { 16, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2861), 3, 3, new DateTime(2025, 1, 28, 22, 29, 51, 808, DateTimeKind.Utc).AddTicks(2864), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2862) },
                    { 17, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2866), 1, 1, new DateTime(2025, 1, 28, 23, 29, 51, 808, DateTimeKind.Utc).AddTicks(2869), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2867) },
                    { 18, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2871), 1, 1, new DateTime(2025, 1, 29, 0, 29, 51, 808, DateTimeKind.Utc).AddTicks(2875), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2873) },
                    { 19, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2877), 1, 1, new DateTime(2025, 1, 29, 1, 29, 51, 808, DateTimeKind.Utc).AddTicks(2880), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2878) },
                    { 20, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2882), 1, 1, new DateTime(2025, 1, 29, 2, 29, 51, 808, DateTimeKind.Utc).AddTicks(2886), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2884) },
                    { 21, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2888), 2, 1, new DateTime(2025, 1, 29, 3, 29, 51, 808, DateTimeKind.Utc).AddTicks(2891), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2889) },
                    { 22, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2905), 2, 2, new DateTime(2025, 1, 28, 23, 29, 51, 808, DateTimeKind.Utc).AddTicks(2908), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2907) },
                    { 23, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2911), 2, 2, new DateTime(2025, 1, 29, 0, 29, 51, 808, DateTimeKind.Utc).AddTicks(2916), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2912) },
                    { 24, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2918), 2, 2, new DateTime(2025, 1, 29, 1, 29, 51, 808, DateTimeKind.Utc).AddTicks(2922), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2920) },
                    { 25, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2923), 2, 2, new DateTime(2025, 1, 29, 2, 29, 51, 808, DateTimeKind.Utc).AddTicks(2927), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2925) },
                    { 26, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2929), 2, 2, new DateTime(2025, 1, 29, 3, 29, 51, 808, DateTimeKind.Utc).AddTicks(2932), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2930) },
                    { 27, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2934), 3, 3, new DateTime(2025, 1, 28, 23, 29, 51, 808, DateTimeKind.Utc).AddTicks(2937), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2935) },
                    { 28, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2939), 3, 3, new DateTime(2025, 1, 29, 0, 29, 51, 808, DateTimeKind.Utc).AddTicks(2943), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2941) },
                    { 29, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2945), 3, 3, new DateTime(2025, 1, 29, 1, 29, 51, 808, DateTimeKind.Utc).AddTicks(2948), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2946) },
                    { 30, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2950), 3, 3, new DateTime(2025, 1, 29, 2, 29, 51, 808, DateTimeKind.Utc).AddTicks(2953), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2951) },
                    { 31, 50, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2955), 3, 3, new DateTime(2025, 1, 29, 3, 29, 51, 808, DateTimeKind.Utc).AddTicks(2959), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2957) }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "created_at", "num_seats", "screening_id", "updated_at" },
                values: new object[,]
                {
                    { 2, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4030), 4, 1, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4035) },
                    { 3, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4254), 2, 2, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4256) },
                    { 4, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4258), 4, 2, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4260) },
                    { 5, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4262), 1, 3, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4263) },
                    { 6, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4266), 1, 3, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4267) },
                    { 7, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4269), 1, 3, new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4271) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "movies");

            migrationBuilder.DropTable(
                name: "screenings");

            migrationBuilder.DropTable(
                name: "tickets");
        }
    }
}
