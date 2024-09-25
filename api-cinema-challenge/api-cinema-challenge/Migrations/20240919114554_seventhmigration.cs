using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class seventhmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "created_at", "email", "name", "phone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1089), "john.doe@example.com", "John Doe", "555-123-4567", new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1090) },
                    { 2, new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1092), "jane.smith@example.com", "Jane Smith", "555-234-5678", new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1092) },
                    { 3, new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1093), "michael.johnson@example.com", "Michael Johnson", "555-345-6789", new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1094) },
                    { 4, new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1127), "emily.davis@example.com", "Emily Davis", "555-456-7890", new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1129) },
                    { 5, new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1130), "david.wilson@example.com", "David Wilson", "555-567-8901", new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1131) }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "description", "rating", "runtimeMins", "title", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1078), "A skilled thief, Dom Cobb, who can infiltrate and steal information from dreams, is tasked with planting an idea into a target's subconscious. As the mission becomes more dangerous, Cobb confronts his own troubled past.", "PG-13", 148, "Inception", new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1079) },
                    { 2, new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1082), "Batman faces his greatest challenge yet as the Joker wreaks havoc on Gotham City. As chaos ensues, Bruce Wayne must grapple with the cost of being a hero and the line between good and evil.", "PG-13", 152, "The Dark Knight", new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1082) },
                    { 3, new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1084), "In a future where Earth is on the brink of collapse, a team of astronauts travels through a wormhole in search of a new home for humanity. The film explores themes of time, space, and love as a survival force.", "PG-13", 169, "Interstellar", new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1084) },
                    { 4, new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1085), "A hacker, Neo, discovers that reality as he knows it is a simulation controlled by machines. He joins a group of rebels to fight against the machines and free humanity from their virtual prison.", "R", 136, "The Matrix", new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1086) }
                });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "CustomerId", "ScreeningId", "created_at", "id", "updated_at", "number_of_seats" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1145), 1, new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1146), 1 },
                    { 2, 1, new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1148), 2, new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1148), 1 },
                    { 5, 1, new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1152), 5, new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1152), 1 },
                    { 3, 2, new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1149), 3, new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1150), 1 },
                    { 4, 2, new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1150), 4, new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1151), 1 }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "capacity", "created_at", "Movieid", "screenNumber", "startsAt", "updated_at" },
                values: new object[,]
                {
                    { 1, 100, new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1138), 1, 0, new DateTime(2024, 9, 20, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1134), new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1139) },
                    { 2, 120, new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1142), 2, 0, new DateTime(2024, 9, 21, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1141), new DateTime(2024, 9, 19, 11, 45, 54, 248, DateTimeKind.Utc).AddTicks(1142) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumns: new[] { "CustomerId", "ScreeningId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumns: new[] { "CustomerId", "ScreeningId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumns: new[] { "CustomerId", "ScreeningId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumns: new[] { "CustomerId", "ScreeningId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumns: new[] { "CustomerId", "ScreeningId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
