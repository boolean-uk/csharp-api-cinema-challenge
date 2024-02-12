using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class addticketsUpdatessssssss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "tickets",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "tickets",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7271), "Lily7@live.com", "Lily Dunpy" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7282), "Barney46@live.com", "Barney Thorpe" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7286), "Ted16@experis.com", "Ted Delgado", "222 25 555" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7287), "Lily65@experis.com", "Lily Dunpy", "888 22 999" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7289), "Lily79@live.com", "Lily Delgado", "909 11 881" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7293), "Ted45@live.com", "Ted Dunpy" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7295), "Marshall0@hotmail.com", "Marshall Pritchett", "888 22 999" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "email", "phone" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7296), "Ted38@live.com", "222 25 555" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7298), "Ted69@hotmail.com", "Ted Thorpe" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7300), "Barney47@experis.com", "Barney Delgado" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7301), "Robin74@gmail.com", "Robin Dunpy", "222 25 555" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7303), "Lily30@experis.com", "Lily Dunpy", "909 11 881" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7304), "Barney37@live.com", "Barney Delgado" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "created_at", "email", "phone" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7306), "Lily53@experis.com", "909 11 881" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7307), "Robin38@hotmail.com", "Robin Delgado", "888 22 999" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7309), "Ted20@live.com", "Ted Pritchett", "888 22 999" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7310), "Marshall92@live.com", "Marshall Pritchett" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7312), "Lily69@experis.com", "Lily Dunpy" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7314), "Robin44@experis.com", "Robin Dunpy" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7315), "Robin92@live.com", "Robin Pritchett", "222 25 555" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                column: "created_at",
                value: new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                column: "created_at",
                value: new DateTime(2024, 2, 9, 10, 34, 54, 362, DateTimeKind.Utc).AddTicks(7326));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "created_at",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "tickets");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4297), "Robin53@hotmail.com", "Robin Pritchett" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4302), "Lily14@gmail.com", "Lily Delgado" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4304), "Marshall30@experis.com", "Marshall Dunpy", "909 11 881" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4306), "Ted78@gmail.com", "Ted Pritchett", "909 11 881" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4308), "Ted52@gmail.com", "Ted Thorpe", "222 25 555" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4310), "Barney90@hotmail.com", "Barney Pritchett" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4312), "Barney13@hotmail.com", "Barney Dunpy", "909 11 881" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "email", "phone" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4318), "Ted11@gmail.com", "888 22 999" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4319), "Marshall67@gmail.com", "Marshall Thorpe" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4321), "Robin91@hotmail.com", "Robin Thorpe" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4322), "Marshall35@live.com", "Marshall Thorpe", "888 22 999" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4324), "Barney4@experis.com", "Barney Dunpy", "888 22 999" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4326), "Ted3@hotmail.com", "Ted Delgado" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "created_at", "email", "phone" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4327), "Lily79@hotmail.com", "222 25 555" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4328), "Ted51@gmail.com", "Ted Thorpe", "909 11 881" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4330), "Barney49@live.com", "Barney Thorpe", "909 11 881" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4331), "Ted64@experis.com", "Ted Pritchett" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4333), "Lily84@gmail.com", "Lily Pritchett" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4357), "Robin60@experis.com", "Robin Delgado" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4359), "Marshall49@experis.com", "Marshall Thorpe", "888 22 999" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                column: "created_at",
                value: new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                column: "created_at",
                value: new DateTime(2024, 2, 9, 10, 14, 10, 594, DateTimeKind.Utc).AddTicks(4367));
        }
    }
}
