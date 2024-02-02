using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customer" ,
                columns: table => new
                {
                    id = table.Column<int>(type: "integer" , nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy" , NpgsqlValueGenerationStrategy.IdentityByDefaultColumn) ,
                    name = table.Column<string>(type: "text" , nullable: false) ,
                    email = table.Column<string>(type: "text" , nullable: false) ,
                    phone = table.Column<string>(type: "text" , nullable: false) ,
                    createdat = table.Column<DateTime>(type: "timestamp with time zone" , nullable: false) ,
                    updatedat = table.Column<DateTime>(type: "timestamp with time zone" , nullable: false)
                } ,
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer" , x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "movie" ,
                columns: table => new
                {
                    id = table.Column<int>(type: "integer" , nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy" , NpgsqlValueGenerationStrategy.IdentityByDefaultColumn) ,
                    createdat = table.Column<DateTime>(type: "timestamp with time zone" , nullable: false) ,
                    updatedat = table.Column<DateTime>(type: "timestamp with time zone" , nullable: false) ,
                    title = table.Column<string>(type: "text" , nullable: false) ,
                    rating = table.Column<string>(type: "text" , nullable: false) ,
                    description = table.Column<string>(type: "text" , nullable: false) ,
                    runtimemins = table.Column<int>(type: "integer" , nullable: false)
                } ,
                constraints: table =>
                {
                    table.PrimaryKey("PK_movie" , x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "screening" ,
                columns: table => new
                {
                    id = table.Column<int>(type: "integer" , nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy" , NpgsqlValueGenerationStrategy.IdentityByDefaultColumn) ,
                    screennumber = table.Column<int>(type: "integer" , nullable: false) ,
                    capacity = table.Column<int>(type: "integer" , nullable: false) ,
                    startsat = table.Column<DateTime>(type: "timestamp with time zone" , nullable: false) ,
                    createdat = table.Column<DateTime>(type: "timestamp with time zone" , nullable: false) ,
                    updatedat = table.Column<DateTime>(type: "timestamp with time zone" , nullable: false) ,
                    movieid = table.Column<int>(type: "integer" , nullable: false)
                } ,
                constraints: table =>
                {
                    table.PrimaryKey("PK_screening" , x => x.id);
                    table.ForeignKey(
                        name: "FK_screening_movie_movieid" ,
                        column: x => x.movieid ,
                        principalTable: "movie" ,
                        principalColumn: "id" ,
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "customer" ,
                columns: new[] { "id" , "createdat" , "email" , "name" , "phone" , "updatedat" } ,
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer1@example.com", "Customer 1", "1234567890", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer2@example.com", "Customer 2", "0987654321", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "movie" ,
                columns: new[] { "id" , "createdat" , "description" , "rating" , "runtimemins" , "title" , "updatedat" } ,
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description 1", "PG", 120, "Movie 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description 2", "PG-13", 130, "Movie 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "screening" ,
                columns: new[] { "id" , "capacity" , "createdat" , "movieid" , "screennumber" , "startsat" , "updatedat" } ,
                values: new object[,]
                {
                    { 1, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2024, 2, 2, 11, 11, 25, 891, DateTimeKind.Utc).AddTicks(8854), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, new DateTime(2024, 2, 2, 11, 11, 25, 891, DateTimeKind.Utc).AddTicks(8858), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_screening_movieid" ,
                table: "screening" ,
                column: "movieid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "screening");

            migrationBuilder.DropTable(
                name: "movie");
        }
    }
}
