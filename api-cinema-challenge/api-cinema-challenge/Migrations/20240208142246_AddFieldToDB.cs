using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "movies",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "movies",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(464), "Robin82@live.com", "Robin Dunpy", "222 25 555" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(467), "Lily81@live.com", "Lily Thorpe" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(470), "Lily92@hotmail.com", "Lily Pritchett" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(473), "Robin71@hotmail.com", "Robin Delgado" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(475), "Marshall55@hotmail.com", "Marshall Dunpy", "888 22 999" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(479), "Barney61@hotmail.com", "Barney Pritchett" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(482), "Ted11@experis.com", "Ted Pritchett", "888 22 999" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(485), "Robin33@gmail.com", "Robin Dunpy", "909 11 881" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(486), "Marshall60@live.com", "Marshall Pritchett", "888 22 999" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(492), "Barney18@gmail.com", "Barney Thorpe", "888 22 999" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(494), "Lily86@hotmail.com", "Lily Pritchett", "888 22 999" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(495), "Robin33@experis.com", "Robin Pritchett" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(497), "Barney57@hotmail.com", "Barney Dunpy" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(499), "Robin85@experis.com", "Robin Thorpe" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(501), "Lily48@live.com", "Lily Dunpy", "888 22 999" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(502), "Robin39@hotmail.com", "Robin Delgado", "888 22 999" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "created_at", "email" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(504), "Ted12@live.com" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(507), "Robin24@experis.com", "Robin Dunpy" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "created_at", "email", "phone" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(510), "Ted16@live.com", "888 22 999" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(511), "Robin47@gmail.com", "Robin Dunpy" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(517), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(519), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(522), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(523), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 14, 22, 46, 309, DateTimeKind.Utc).AddTicks(525), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "created_at",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "movies");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7601), "Marshall42@gmail.com", "Marshall Delgado", "909 11 881" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7606), "Lily89@experis.com", "Lily Pritchett" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7626), "Marshall16@experis.com", "Marshall Dunpy" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7629), "Ted68@live.com", "Ted Dunpy" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7631), "Marshall86@hotmail.com", "Marshall Pritchett", "222 25 555" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7634), "Marshall64@live.com", "Marshall Thorpe" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7636), "Robin6@live.com", "Robin Delgado", "909 11 881" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7638), "Lily52@gmail.com", "Lily Thorpe", "888 22 999" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7639), "Robin92@live.com", "Robin Thorpe", "909 11 881" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7642), "Lily7@gmail.com", "Lily Thorpe", "909 11 881" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7643), "Barney50@experis.com", "Barney Dunpy", "909 11 881" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7645), "Lily64@gmail.com", "Lily Thorpe" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7646), "Marshall94@gmail.com", "Marshall Pritchett" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7648), "Ted17@experis.com", "Ted Dunpy" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7649), "Barney65@hotmail.com", "Barney Delgado", "909 11 881" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "created_at", "email", "name", "phone" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7650), "Lily78@gmail.com", "Lily Delgado", "909 11 881" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "created_at", "email" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7652), "Ted6@experis.com" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7655), "Ted12@live.com", "Ted Pritchett" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "created_at", "email", "phone" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7657), "Ted23@gmail.com", "909 11 881" });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "created_at", "email", "name" },
                values: new object[] { new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7659), "Ted38@hotmail.com", "Ted Pritchett" });
        }
    }
}
