using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class ImplementingAuthorization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    role = table.Column<int>(type: "integer", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<string>(type: "text", nullable: false),
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
                    runtime_mins = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    movie_id = table.Column<int>(type: "integer", nullable: false)
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
                    id = table.Column<int>(type: "integer", nullable: false),
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    num_seats = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => new { x.id, x.screening_id, x.customer_id });
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
                columns: new[] { "id", "created_at", "email", "name", "phone", "updated_at", "user_id" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5728), "DonaldDuck@gmail.com", "Donald Duck", "(496) 262-1642", new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5731), "1" },
                    { 2, new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5737), "ElvisPresley@gmail.com", "Elvis Presley", "(200) 933-1067", new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5740), "2" },
                    { 3, new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5788), "Barack.Obama@gmail.com", "Barack Obama", "(853) 847-7386", new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5791), "3" },
                    { 4, new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5796), "OprahWinfrey@gmail.com", "Oprah Winfrey", "(609) 360-3328", new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5799), "4" }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "description", "rating", "runtime_mins", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5580), "It was ok, critics are indifferent.", "R", 86, "Amelie", new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5660) },
                    { 2, new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5666), "Suitable for all ages.", "PG-13", 145, "One Flew Over The Cuckoo's Nest", new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5669) },
                    { 3, new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5673), "This is a cult classic.", "G", 37, "Alien - Prometheus", new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5676) },
                    { 4, new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5680), "This is a cult classic.", "PG", 108, "Fantastic Mr. Fox", new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5682) }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "created_at", "movie_id", "screen_number", "starts_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 39, new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5808), 3, 29, new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5805), new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5811) },
                    { 2, 36, new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5819), 3, 36, new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5816), new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5822) },
                    { 3, 46, new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5829), 4, 40, new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5826), new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5831) },
                    { 4, 57, new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5838), 3, 16, new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5835), new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5841) }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "customer_id", "id", "screening_id", "created_at", "num_seats", "updated_at" },
                values: new object[,]
                {
                    { 2, 1, 2, new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5846), 3, new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5849) },
                    { 3, 2, 3, new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5854), 1, new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5857) },
                    { 4, 3, 4, new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5860), 1, new DateTime(2024, 2, 13, 11, 41, 19, 522, DateTimeKind.Utc).AddTicks(5863) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

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
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "screenings");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
