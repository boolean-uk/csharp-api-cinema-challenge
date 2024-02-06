using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateScreeningSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "tickets",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9301), "Elisabeth@email.com", "Elisabeth", "56122811" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9330), "David@email.com", "David", "32734109" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9336), "David@email.com", "David", "51967771" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "phone" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9341), "99968378" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9345), "Frank@email.com", "Frank", "41371165" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "phone" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9356), "16530955" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9361), "David@email.com", "David", "89877089" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9365), "David@email.com", "David", "34166824" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9370), "Ruben@email.com", "Ruben", "37350938" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9376), "George@email.com", "George", "25439371" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9380), "Ruben@email.com", "Ruben", "82323535" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9496), "A movie about a Policeman that is quite Fast", 3, 122, "The Fast Policeman" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9636), "A movie about a Piper that is quite Seethrough", 1, 89, "The Seethrough Piper" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9643), "A movie about a Piper that is quite Round", 2, 252, "The Round Piper" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9648), "A movie about a Policeman that is quite Purple", 0, 208, "The Purple Policeman" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9652), "A movie about a Phone that is quite Mad", 0, 203, "The Mad Phone" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9658), "A movie about a Computer that is quite Mad", 1, 172, "The Mad Computer" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "description", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9662), "A movie about a Policeman that is quite Round", 194, "The Round Policeman" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9667), "A movie about a Computer that is quite Round", 0, 212, "The Round Computer" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "rating", "runtime_mins" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9671), 3, 241 });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "description", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9676), "A movie about a Phone that is quite Round", 83, "The Round Phone" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9681), "A movie about a Computer that is quite Amazing", 2, 222, "The Amazing Computer" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9685), "A movie about a Computer that is quite Seethrough", 3, 185, "The Seethrough Computer" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "created_at", "description", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9690), "A movie about a Computer that is quite Round", 219, "The Round Computer" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "created_at", "description", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9694), "A movie about a Swan that is quite Slow", 224, "The Slow Swan" });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "capacity", "movie_id" },
                values: new object[] { 58, 8 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "capacity", "movie_id" },
                values: new object[] { 54, 9 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "capacity", "movie_id" },
                values: new object[] { 32, 1 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "capacity", "movie_id", "starts_at" },
                values: new object[] { 38, 10, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "capacity", "movie_id" },
                values: new object[] { 55, 8 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "capacity", "movie_id" },
                values: new object[] { 56, 2 });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumns: new[] { "customer_id", "screening_id" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9829), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumns: new[] { "customer_id", "screening_id" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9836), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumns: new[] { "customer_id", "screening_id" },
                keyValues: new object[] { 3, 4 },
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 42, 37, 769, DateTimeKind.Local).AddTicks(9833), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "tickets",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5088), "David@email.com", "David", "60728988" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5120), "Frank@email.com", "Frank", "77744006" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5125), "Frank@email.com", "Frank", "58548887" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "phone" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5129), "28438558" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5134), "David@email.com", "David", "32090007" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "phone" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5140), "56613342" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5145), "Piotr@email.com", "Piotr", "32297558" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5149), "Ruben@email.com", "Ruben", "83332048" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5153), "David@email.com", "David", "55505102" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5158), "Piotr@email.com", "Piotr", "24937168" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5162), "Frank@email.com", "Frank", "64015786" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5220), "A movie about a Policeman that is quite Seethrough", 1, 81, "The Seethrough Policeman" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5351), "A movie about a Leopard that is quite Fast", 3, 166, "The Fast Leopard" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5356), "A movie about a Piper that is quite Amazing", 0, 42, "The Amazing Piper" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5361), "A movie about a Piper that is quite Purple", 3, 195, "The Purple Piper" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5366), "A movie about a Swan that is quite Amazing", 3, 208, "The Amazing Swan" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5370), "A movie about a Phone that is quite Fast", 0, 175, "The Fast Phone" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "description", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5375), "A movie about a Piper that is quite Mad", 60, "The Mad Piper" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5379), "A movie about a Leopard that is quite Purple", 3, 85, "The Purple Leopard" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "rating", "runtime_mins" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5383), 0, 89 });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "description", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5388), "A movie about a Leopard that is quite Slow", 87, "The Slow Leopard" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5393), "A movie about a Piper that is quite Amazing", 1, 153, "The Amazing Piper" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "description", "rating", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5397), "A movie about a Phone that is quite Amazing", 2, 99, "The Amazing Phone" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "created_at", "description", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5401), "A movie about a Swan that is quite Fast", 192, "The Fast Swan" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "created_at", "description", "runtime_mins", "title" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5435), "A movie about a Swan that is quite Fast", 208, "The Fast Swan" });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "capacity", "movie_id" },
                values: new object[] { 3, 7 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "capacity", "movie_id" },
                values: new object[] { 1, 10 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "capacity", "movie_id" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "capacity", "movie_id", "starts_at" },
                values: new object[] { 2, 3, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "capacity", "movie_id" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "capacity", "movie_id" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumns: new[] { "customer_id", "screening_id" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5550), null });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumns: new[] { "customer_id", "screening_id" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5555), null });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumns: new[] { "customer_id", "screening_id" },
                keyValues: new object[] { 3, 4 },
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 6, 13, 35, 38, 918, DateTimeKind.Local).AddTicks(5553), null });
        }
    }
}
