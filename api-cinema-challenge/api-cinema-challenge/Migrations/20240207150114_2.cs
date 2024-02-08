using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    numSeats = table.Column<int>(type: "integer", nullable: false),
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    customer_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.id);
                    table.ForeignKey(
                        name: "FK_tickets_customer_customer_id",
                        column: x => x.customer_id,
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tickets_screening_screening_id",
                        column: x => x.screening_id,
                        principalTable: "screening",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 220, DateTimeKind.Utc).AddTicks(5502), "MichaelJohnson61@gmail.com", "Michael Johnson", "390.315.9105 x197", new DateTime(2024, 2, 7, 15, 1, 14, 220, DateTimeKind.Utc).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 222, DateTimeKind.Utc).AddTicks(6527), "JenniferBrown_Hand22@yahoo.com", "Jennifer Brown", "437.454.9222 x6341", new DateTime(2024, 2, 7, 15, 1, 14, 222, DateTimeKind.Utc).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 224, DateTimeKind.Utc).AddTicks(5032), "JaneWilliams.Veum@yahoo.com", "Jane Williams", "335-948-7870", new DateTime(2024, 2, 7, 15, 1, 14, 224, DateTimeKind.Utc).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 226, DateTimeKind.Utc).AddTicks(2794), "EmilySmith_Parisian@hotmail.com", "Emily Smith", "372.485.5959 x199", new DateTime(2024, 2, 7, 15, 1, 14, 226, DateTimeKind.Utc).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 228, DateTimeKind.Utc).AddTicks(5446), "EmilyGarcia.Conn@gmail.com", "Emily Garcia", "(547) 210-0541 x71829", new DateTime(2024, 2, 7, 15, 1, 14, 228, DateTimeKind.Utc).AddTicks(5449) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 230, DateTimeKind.Utc).AddTicks(7850), "JohnJohnson_Kovacek@hotmail.com", "John Johnson", "386.287.7134", new DateTime(2024, 2, 7, 15, 1, 14, 230, DateTimeKind.Utc).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 232, DateTimeKind.Utc).AddTicks(7167), "JessicaWilliams_Mohr86@yahoo.com", "Jessica Williams", "(700) 859-6343", new DateTime(2024, 2, 7, 15, 1, 14, 232, DateTimeKind.Utc).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 234, DateTimeKind.Utc).AddTicks(5768), "DanielWilliams0@hotmail.com", "Daniel Williams", "565-436-6727 x929", new DateTime(2024, 2, 7, 15, 1, 14, 234, DateTimeKind.Utc).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 236, DateTimeKind.Utc).AddTicks(4526), "MatthewJohnson_Maggio@yahoo.com", "Matthew Johnson", "282.488.9486 x45449", new DateTime(2024, 2, 7, 15, 1, 14, 236, DateTimeKind.Utc).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 238, DateTimeKind.Utc).AddTicks(4324), "JenniferBrown.Lind48@hotmail.com", "Jennifer Brown", "315-275-4079 x322", new DateTime(2024, 2, 7, 15, 1, 14, 238, DateTimeKind.Utc).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 240, DateTimeKind.Utc).AddTicks(3302), "MichaelJones.Herzog@yahoo.com", "Michael Jones", "831.358.1905", new DateTime(2024, 2, 7, 15, 1, 14, 240, DateTimeKind.Utc).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 242, DateTimeKind.Utc).AddTicks(2270), "JaneMiller_Lesch@hotmail.com", "Jane Miller", "855.847.7608 x622", new DateTime(2024, 2, 7, 15, 1, 14, 242, DateTimeKind.Utc).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 244, DateTimeKind.Utc).AddTicks(1010), "JaneJohnson38@gmail.com", "Jane Johnson", "(759) 996-7441 x3722", new DateTime(2024, 2, 7, 15, 1, 14, 244, DateTimeKind.Utc).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "created_at", "email", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 246, DateTimeKind.Utc).AddTicks(4058), "JessicaDavis.Von8@yahoo.com", "1-261-477-5665 x24754", new DateTime(2024, 2, 7, 15, 1, 14, 246, DateTimeKind.Utc).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 248, DateTimeKind.Utc).AddTicks(3753), "DavidJones.Emard@gmail.com", "David Jones", "660.697.9085", new DateTime(2024, 2, 7, 15, 1, 14, 248, DateTimeKind.Utc).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 250, DateTimeKind.Utc).AddTicks(3413), "JessicaWilliams_Sipes@yahoo.com", "Jessica Williams", "1-943-733-0024 x240", new DateTime(2024, 2, 7, 15, 1, 14, 250, DateTimeKind.Utc).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 252, DateTimeKind.Utc).AddTicks(1639), "JaneWilliams_Keeling36@yahoo.com", "Jane Williams", "(740) 640-4349 x5768", new DateTime(2024, 2, 7, 15, 1, 14, 252, DateTimeKind.Utc).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 253, DateTimeKind.Utc).AddTicks(9691), "JaneBrown.Baumbach@yahoo.com", "Jane Brown", "1-790-951-6610 x956", new DateTime(2024, 2, 7, 15, 1, 14, 253, DateTimeKind.Utc).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 255, DateTimeKind.Utc).AddTicks(7388), "JessicaDavis_Christiansen5@hotmail.com", "Jessica Davis", "(391) 851-4321", new DateTime(2024, 2, 7, 15, 1, 14, 255, DateTimeKind.Utc).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 257, DateTimeKind.Utc).AddTicks(5406), "JohnWilson41@hotmail.com", "John Wilson", "975.306.5588", new DateTime(2024, 2, 7, 15, 1, 14, 257, DateTimeKind.Utc).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 259, DateTimeKind.Utc).AddTicks(3343), "MatthewRodriguez98@gmail.com", "Matthew Rodriguez", "1-881-971-4979 x6202", new DateTime(2024, 2, 7, 15, 1, 14, 259, DateTimeKind.Utc).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 261, DateTimeKind.Utc).AddTicks(4683), "JessicaWilliams_Heathcote@hotmail.com", "Jessica Williams", "662.543.4993 x353", new DateTime(2024, 2, 7, 15, 1, 14, 261, DateTimeKind.Utc).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 263, DateTimeKind.Utc).AddTicks(3306), "JaneGarcia70@gmail.com", "Jane Garcia", "(891) 627-6032 x54142", new DateTime(2024, 2, 7, 15, 1, 14, 263, DateTimeKind.Utc).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 265, DateTimeKind.Utc).AddTicks(1308), "JessicaWilliams37@gmail.com", "Jessica Williams", "642.263.8864 x9629", new DateTime(2024, 2, 7, 15, 1, 14, 265, DateTimeKind.Utc).AddTicks(1309) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 266, DateTimeKind.Utc).AddTicks(9263), "JenniferJones_Murray@yahoo.com", "Jennifer Jones", "856-867-8080 x3278", new DateTime(2024, 2, 7, 15, 1, 14, 266, DateTimeKind.Utc).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 268, DateTimeKind.Utc).AddTicks(7918), "DavidRodriguez.Klocko@yahoo.com", "David Rodriguez", "269.808.2410 x730", new DateTime(2024, 2, 7, 15, 1, 14, 268, DateTimeKind.Utc).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 270, DateTimeKind.Utc).AddTicks(6357), "MatthewMiller_Gislason@hotmail.com", "Matthew Miller", "(379) 391-9650 x91108", new DateTime(2024, 2, 7, 15, 1, 14, 270, DateTimeKind.Utc).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 272, DateTimeKind.Utc).AddTicks(4416), "JaneRodriguez76@hotmail.com", "Jane Rodriguez", "1-636-276-3632 x065", new DateTime(2024, 2, 7, 15, 1, 14, 272, DateTimeKind.Utc).AddTicks(4418) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 274, DateTimeKind.Utc).AddTicks(2494), "JaneSmith36@yahoo.com", "Jane Smith", "640.573.5891", new DateTime(2024, 2, 7, 15, 1, 14, 274, DateTimeKind.Utc).AddTicks(2495) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 276, DateTimeKind.Utc).AddTicks(3337), "JessicaSmith.Hoppe@yahoo.com", "Jessica Smith", "1-512-305-5211", new DateTime(2024, 2, 7, 15, 1, 14, 276, DateTimeKind.Utc).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 278, DateTimeKind.Utc).AddTicks(3648), "DavidJones.Hayes51@gmail.com", "David Jones", "307.460.4358", new DateTime(2024, 2, 7, 15, 1, 14, 278, DateTimeKind.Utc).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 280, DateTimeKind.Utc).AddTicks(2787), "EmilyRodriguez.Dooley@hotmail.com", "Emily Rodriguez", "(935) 930-4853 x51629", new DateTime(2024, 2, 7, 15, 1, 14, 280, DateTimeKind.Utc).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 282, DateTimeKind.Utc).AddTicks(1106), "JenniferMiller.Volkman@hotmail.com", "Jennifer Miller", "841.282.1816 x57978", new DateTime(2024, 2, 7, 15, 1, 14, 282, DateTimeKind.Utc).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 283, DateTimeKind.Utc).AddTicks(9571), "MatthewGarcia.Boyer53@yahoo.com", "Matthew Garcia", "1-899-869-9153", new DateTime(2024, 2, 7, 15, 1, 14, 283, DateTimeKind.Utc).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 285, DateTimeKind.Utc).AddTicks(8285), "MichaelBrown71@hotmail.com", "Michael Brown", "1-509-623-1054", new DateTime(2024, 2, 7, 15, 1, 14, 285, DateTimeKind.Utc).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 287, DateTimeKind.Utc).AddTicks(7364), "JessicaBrown.Purdy7@hotmail.com", "Jessica Brown", "1-722-530-0521 x13549", new DateTime(2024, 2, 7, 15, 1, 14, 287, DateTimeKind.Utc).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 289, DateTimeKind.Utc).AddTicks(6356), "SarahMiller_Boehm23@gmail.com", "Sarah Miller", "842.414.2935", new DateTime(2024, 2, 7, 15, 1, 14, 289, DateTimeKind.Utc).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 291, DateTimeKind.Utc).AddTicks(7951), "JessicaDavis83@gmail.com", "Jessica Davis", "1-417-231-3002", new DateTime(2024, 2, 7, 15, 1, 14, 291, DateTimeKind.Utc).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 293, DateTimeKind.Utc).AddTicks(6425), "JessicaDavis.Parisian@yahoo.com", "Jessica Davis", "(313) 498-4358", new DateTime(2024, 2, 7, 15, 1, 14, 293, DateTimeKind.Utc).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 295, DateTimeKind.Utc).AddTicks(5616), "DavidJohnson_VonRueden@hotmail.com", "David Johnson", "1-794-386-5304 x942", new DateTime(2024, 2, 7, 15, 1, 14, 295, DateTimeKind.Utc).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 297, DateTimeKind.Utc).AddTicks(4369), "DanielWilson.Baumbach74@gmail.com", "Daniel Wilson", "1-961-946-2437", new DateTime(2024, 2, 7, 15, 1, 14, 297, DateTimeKind.Utc).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 299, DateTimeKind.Utc).AddTicks(4001), "JenniferJones83@yahoo.com", "Jennifer Jones", "704.961.0180 x28646", new DateTime(2024, 2, 7, 15, 1, 14, 299, DateTimeKind.Utc).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 301, DateTimeKind.Utc).AddTicks(2705), "JessicaRodriguez_Kihn69@yahoo.com", "Jessica Rodriguez", "1-823-542-9434", new DateTime(2024, 2, 7, 15, 1, 14, 301, DateTimeKind.Utc).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 303, DateTimeKind.Utc).AddTicks(1692), "JaneRodriguez.Gottlieb@hotmail.com", "Jane Rodriguez", "(255) 910-3171 x85161", new DateTime(2024, 2, 7, 15, 1, 14, 303, DateTimeKind.Utc).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 305, DateTimeKind.Utc).AddTicks(645), "JenniferSmith_Schinner8@gmail.com", "Jennifer Smith", "562.473.3940 x0392", new DateTime(2024, 2, 7, 15, 1, 14, 305, DateTimeKind.Utc).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 307, DateTimeKind.Utc).AddTicks(3805), "EmilySmith1@yahoo.com", "Emily Smith", "446.814.5928 x12615", new DateTime(2024, 2, 7, 15, 1, 14, 307, DateTimeKind.Utc).AddTicks(3806) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 310, DateTimeKind.Utc).AddTicks(7745), "JaneJones58@gmail.com", "Jane Jones", "1-828-629-0415", new DateTime(2024, 2, 7, 15, 1, 14, 310, DateTimeKind.Utc).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 314, DateTimeKind.Utc).AddTicks(1171), "JohnWilliams_Stokes@hotmail.com", "John Williams", "(391) 485-4553 x1635", new DateTime(2024, 2, 7, 15, 1, 14, 314, DateTimeKind.Utc).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 317, DateTimeKind.Utc).AddTicks(3634), "DanielMiller1@yahoo.com", "Daniel Miller", "209-488-5125", new DateTime(2024, 2, 7, 15, 1, 14, 317, DateTimeKind.Utc).AddTicks(3635) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 320, DateTimeKind.Utc).AddTicks(6930), "EmilyRodriguez21@yahoo.com", "Emily Rodriguez", "1-976-743-2174 x08272", new DateTime(2024, 2, 7, 15, 1, 14, 320, DateTimeKind.Utc).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 323, DateTimeKind.Utc).AddTicks(5861), "DavidGarcia.Wisozk@yahoo.com", "David Garcia", "558-909-7503 x801", new DateTime(2024, 2, 7, 15, 1, 14, 323, DateTimeKind.Utc).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 325, DateTimeKind.Utc).AddTicks(6205), "SarahWilson_Stamm59@gmail.com", "Sarah Wilson", "750.414.7848 x680", new DateTime(2024, 2, 7, 15, 1, 14, 325, DateTimeKind.Utc).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 327, DateTimeKind.Utc).AddTicks(5247), "MichaelDavis_Rogahn@hotmail.com", "Michael Davis", "450.753.1568 x972", new DateTime(2024, 2, 7, 15, 1, 14, 327, DateTimeKind.Utc).AddTicks(5249) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 329, DateTimeKind.Utc).AddTicks(5401), "EmilyDavis_Skiles@hotmail.com", "Emily Davis", "(580) 666-8388", new DateTime(2024, 2, 7, 15, 1, 14, 329, DateTimeKind.Utc).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 331, DateTimeKind.Utc).AddTicks(4489), "DanielWilson37@yahoo.com", "Daniel Wilson", "(210) 237-6474", new DateTime(2024, 2, 7, 15, 1, 14, 331, DateTimeKind.Utc).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 333, DateTimeKind.Utc).AddTicks(4676), "DavidBrown.Lakin@hotmail.com", "David Brown", "386-518-5687 x9047", new DateTime(2024, 2, 7, 15, 1, 14, 333, DateTimeKind.Utc).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 335, DateTimeKind.Utc).AddTicks(5068), "DanielJones_Braun84@yahoo.com", "Daniel Jones", "(390) 892-0877 x11639", new DateTime(2024, 2, 7, 15, 1, 14, 335, DateTimeKind.Utc).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 337, DateTimeKind.Utc).AddTicks(4368), "JessicaSmith47@gmail.com", "Jessica Smith", "754.579.8088", new DateTime(2024, 2, 7, 15, 1, 14, 337, DateTimeKind.Utc).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 339, DateTimeKind.Utc).AddTicks(7623), "MatthewJones74@hotmail.com", "Matthew Jones", "(874) 278-8093 x94007", new DateTime(2024, 2, 7, 15, 1, 14, 339, DateTimeKind.Utc).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 341, DateTimeKind.Utc).AddTicks(9051), "SarahDavis_Jaskolski@yahoo.com", "Sarah Davis", "1-863-385-5291", new DateTime(2024, 2, 7, 15, 1, 14, 341, DateTimeKind.Utc).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 343, DateTimeKind.Utc).AddTicks(8382), "JohnDavis35@gmail.com", "John Davis", "1-887-434-3331", new DateTime(2024, 2, 7, 15, 1, 14, 343, DateTimeKind.Utc).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 345, DateTimeKind.Utc).AddTicks(8155), "JessicaWilliams_Weber82@hotmail.com", "Jessica Williams", "546.222.9340", new DateTime(2024, 2, 7, 15, 1, 14, 345, DateTimeKind.Utc).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 347, DateTimeKind.Utc).AddTicks(6309), "MichaelRodriguez.Bernier94@yahoo.com", "Michael Rodriguez", "576-260-3265 x962", new DateTime(2024, 2, 7, 15, 1, 14, 347, DateTimeKind.Utc).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 349, DateTimeKind.Utc).AddTicks(6284), "EmilyBrown.Metz73@gmail.com", "Emily Brown", "625-697-6798 x67562", new DateTime(2024, 2, 7, 15, 1, 14, 349, DateTimeKind.Utc).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 351, DateTimeKind.Utc).AddTicks(4198), "MatthewJohnson20@hotmail.com", "Matthew Johnson", "(206) 489-6229", new DateTime(2024, 2, 7, 15, 1, 14, 351, DateTimeKind.Utc).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 354, DateTimeKind.Utc).AddTicks(2444), "EmilyRodriguez.Wiza@hotmail.com", "Emily Rodriguez", "1-275-382-4244", new DateTime(2024, 2, 7, 15, 1, 14, 354, DateTimeKind.Utc).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 356, DateTimeKind.Utc).AddTicks(820), "JohnJohnson_Heaney@hotmail.com", "John Johnson", "1-635-903-9130 x01381", new DateTime(2024, 2, 7, 15, 1, 14, 356, DateTimeKind.Utc).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 357, DateTimeKind.Utc).AddTicks(9511), "JessicaDavis_Littel@yahoo.com", "Jessica Davis", "(641) 530-8224 x972", new DateTime(2024, 2, 7, 15, 1, 14, 357, DateTimeKind.Utc).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 359, DateTimeKind.Utc).AddTicks(7681), "DavidMiller.Hermiston@gmail.com", "David Miller", "1-475-402-7197", new DateTime(2024, 2, 7, 15, 1, 14, 359, DateTimeKind.Utc).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 361, DateTimeKind.Utc).AddTicks(5852), "JenniferSmith.Keebler@hotmail.com", "Jennifer Smith", "(289) 801-8087", new DateTime(2024, 2, 7, 15, 1, 14, 361, DateTimeKind.Utc).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 363, DateTimeKind.Utc).AddTicks(4081), "DavidWilson56@yahoo.com", "David Wilson", "445.521.7279", new DateTime(2024, 2, 7, 15, 1, 14, 363, DateTimeKind.Utc).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 365, DateTimeKind.Utc).AddTicks(1874), "EmilyWilliams.Gerlach17@gmail.com", "Emily Williams", "756.351.9507 x7490", new DateTime(2024, 2, 7, 15, 1, 14, 365, DateTimeKind.Utc).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 367, DateTimeKind.Utc).AddTicks(280), "JaneWilliams_Kiehn85@hotmail.com", "Jane Williams", "205-903-3512", new DateTime(2024, 2, 7, 15, 1, 14, 367, DateTimeKind.Utc).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 376, DateTimeKind.Utc).AddTicks(1268), "JohnWilliams_Brakus@gmail.com", "John Williams", "744.242.4777 x73670", new DateTime(2024, 2, 7, 15, 1, 14, 376, DateTimeKind.Utc).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 378, DateTimeKind.Utc).AddTicks(4712), "DanielWilson_Jaskolski43@gmail.com", "Daniel Wilson", "(603) 743-8014 x45023", new DateTime(2024, 2, 7, 15, 1, 14, 378, DateTimeKind.Utc).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 380, DateTimeKind.Utc).AddTicks(2863), "MichaelGarcia27@yahoo.com", "Michael Garcia", "(473) 783-9388 x96134", new DateTime(2024, 2, 7, 15, 1, 14, 380, DateTimeKind.Utc).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 383, DateTimeKind.Utc).AddTicks(3932), "JohnWilliams_Cole@yahoo.com", "John Williams", "206.247.2836", new DateTime(2024, 2, 7, 15, 1, 14, 383, DateTimeKind.Utc).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 385, DateTimeKind.Utc).AddTicks(5150), "JenniferJohnson.Schultz52@gmail.com", "Jennifer Johnson", "351-791-3305 x182", new DateTime(2024, 2, 7, 15, 1, 14, 385, DateTimeKind.Utc).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 387, DateTimeKind.Utc).AddTicks(1801), "MatthewMiller_Ondricka66@gmail.com", "Matthew Miller", "1-407-971-3949", new DateTime(2024, 2, 7, 15, 1, 14, 387, DateTimeKind.Utc).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 388, DateTimeKind.Utc).AddTicks(9187), "JohnMiller.Pfeffer89@yahoo.com", "John Miller", "(982) 794-8325 x4935", new DateTime(2024, 2, 7, 15, 1, 14, 388, DateTimeKind.Utc).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 390, DateTimeKind.Utc).AddTicks(5765), "DavidBrown_Goodwin52@gmail.com", "David Brown", "1-785-513-7446 x4526", new DateTime(2024, 2, 7, 15, 1, 14, 390, DateTimeKind.Utc).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 392, DateTimeKind.Utc).AddTicks(1873), "JessicaBrown.Wuckert@yahoo.com", "Jessica Brown", "501-411-1557", new DateTime(2024, 2, 7, 15, 1, 14, 392, DateTimeKind.Utc).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 393, DateTimeKind.Utc).AddTicks(7908), "DavidSmith.Cummerata0@gmail.com", "David Smith", "257.228.4642 x42536", new DateTime(2024, 2, 7, 15, 1, 14, 393, DateTimeKind.Utc).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 395, DateTimeKind.Utc).AddTicks(4539), "DavidMiller.Wehner@gmail.com", "David Miller", "486.565.5569", new DateTime(2024, 2, 7, 15, 1, 14, 395, DateTimeKind.Utc).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 397, DateTimeKind.Utc).AddTicks(1285), "DanielWilson_Streich87@gmail.com", "Daniel Wilson", "412.284.8354 x62002", new DateTime(2024, 2, 7, 15, 1, 14, 397, DateTimeKind.Utc).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 399, DateTimeKind.Utc).AddTicks(1933), "DanielSmith.King72@gmail.com", "Daniel Smith", "(325) 264-6673", new DateTime(2024, 2, 7, 15, 1, 14, 399, DateTimeKind.Utc).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 401, DateTimeKind.Utc).AddTicks(1412), "JohnDavis_Mante@hotmail.com", "John Davis", "620.829.9002 x441", new DateTime(2024, 2, 7, 15, 1, 14, 401, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 402, DateTimeKind.Utc).AddTicks(8443), "JaneSmith44@hotmail.com", "Jane Smith", "549-874-4344", new DateTime(2024, 2, 7, 15, 1, 14, 402, DateTimeKind.Utc).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 404, DateTimeKind.Utc).AddTicks(4655), "MatthewRodriguez_Kshlerin@yahoo.com", "Matthew Rodriguez", "385.654.4808", new DateTime(2024, 2, 7, 15, 1, 14, 404, DateTimeKind.Utc).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 406, DateTimeKind.Utc).AddTicks(798), "JessicaWilliams.Gibson@hotmail.com", "Jessica Williams", "870-602-7651 x4803", new DateTime(2024, 2, 7, 15, 1, 14, 406, DateTimeKind.Utc).AddTicks(799) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 407, DateTimeKind.Utc).AddTicks(7439), "JaneJones_Hickle13@yahoo.com", "Jane Jones", "1-618-452-8989", new DateTime(2024, 2, 7, 15, 1, 14, 407, DateTimeKind.Utc).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 409, DateTimeKind.Utc).AddTicks(4498), "SarahSmith_Heathcote69@hotmail.com", "Sarah Smith", "268-810-6196", new DateTime(2024, 2, 7, 15, 1, 14, 409, DateTimeKind.Utc).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 411, DateTimeKind.Utc).AddTicks(1174), "MichaelGarcia97@gmail.com", "Michael Garcia", "758-646-3502", new DateTime(2024, 2, 7, 15, 1, 14, 411, DateTimeKind.Utc).AddTicks(1174) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 412, DateTimeKind.Utc).AddTicks(9286), "SarahSmith_Douglas@hotmail.com", "Sarah Smith", "493.882.3429 x509", new DateTime(2024, 2, 7, 15, 1, 14, 412, DateTimeKind.Utc).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 414, DateTimeKind.Utc).AddTicks(8784), "JessicaWilson65@hotmail.com", "Jessica Wilson", "1-616-795-0409 x318", new DateTime(2024, 2, 7, 15, 1, 14, 414, DateTimeKind.Utc).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 416, DateTimeKind.Utc).AddTicks(5582), "DavidGarcia_Christiansen@gmail.com", "David Garcia", "1-706-361-6844 x76887", new DateTime(2024, 2, 7, 15, 1, 14, 416, DateTimeKind.Utc).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "created_at", "email", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 418, DateTimeKind.Utc).AddTicks(2690), "DanielBrown.Hudson47@yahoo.com", "503-930-9630", new DateTime(2024, 2, 7, 15, 1, 14, 418, DateTimeKind.Utc).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 419, DateTimeKind.Utc).AddTicks(9312), "EmilyRodriguez_Wyman@yahoo.com", "Emily Rodriguez", "688-707-8241 x8273", new DateTime(2024, 2, 7, 15, 1, 14, 419, DateTimeKind.Utc).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 421, DateTimeKind.Utc).AddTicks(6110), "JohnJohnson.Jaskolski@gmail.com", "John Johnson", "840-489-1489", new DateTime(2024, 2, 7, 15, 1, 14, 421, DateTimeKind.Utc).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 423, DateTimeKind.Utc).AddTicks(2762), "MatthewWilliams_Bogisich@yahoo.com", "Matthew Williams", "1-530-855-2875", new DateTime(2024, 2, 7, 15, 1, 14, 423, DateTimeKind.Utc).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 424, DateTimeKind.Utc).AddTicks(9427), "Unde quibusdam et officiis. Non nihil molestiae id dolores aut et. Ipsa est at at. Laudantium vel cum qui quibusdam consectetur iusto. Numquam voluptatum temporibus et est aut minima modi architecto fugiat. Laborum minima omnis facere veniam deleniti qui necessitatibus.\n\nReiciendis in et fugit dolor. Qui et tempora nesciunt sit et molestiae. Ad labore et explicabo vel harum officia dolorum nobis magnam. Exercitationem iusto ipsam. Et inventore molestiae praesentium dolorem magnam ab.", "109 minutes", "Praesentium sit.", new DateTime(2024, 2, 7, 15, 1, 14, 424, DateTimeKind.Utc).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 426, DateTimeKind.Utc).AddTicks(6368), "Error totam id hic perspiciatis asperiores doloremque itaque qui. Dolorem laborum dolorum rerum vel necessitatibus. Quo nam labore possimus fugiat et. Nostrum unde qui doloremque tempore voluptate enim facilis. Et et ducimus repellendus et placeat reiciendis officia voluptatem. Qui recusandae voluptas quia et.\n\nSit impedit unde et quo ad a perferendis. Qui et incidunt dolores. Doloribus quia totam et repellendus. Natus cupiditate consectetur sint consequuntur qui ratione sit quidem.", "PG-13", "75 minutes", "Excepturi et.", new DateTime(2024, 2, 7, 15, 1, 14, 426, DateTimeKind.Utc).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 428, DateTimeKind.Utc).AddTicks(3946), "Harum quos omnis enim ipsam. Quae sunt amet aut assumenda minus deleniti. Quas fugiat dignissimos est dicta molestiae molestias. Maiores facere et recusandae ut omnis quisquam a accusamus. Ipsam rerum ut doloremque unde eveniet temporibus magni et. Consectetur id ut vitae explicabo et laudantium nobis.", "R", "68 minutes", "Tempora omnis unde.", new DateTime(2024, 2, 7, 15, 1, 14, 428, DateTimeKind.Utc).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 430, DateTimeKind.Utc).AddTicks(5002), "Deleniti sunt reiciendis eos. Et dolores reiciendis dicta nihil ipsam fuga dolorum quam sit. Velit repudiandae distinctio quisquam rerum est aut laboriosam. Veniam molestiae at ut id sit assumenda accusantium. Ipsa suscipit quo ut. Modi sit modi quae sint asperiores.", "R", "135 minutes", "Non aut libero.", new DateTime(2024, 2, 7, 15, 1, 14, 430, DateTimeKind.Utc).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 432, DateTimeKind.Utc).AddTicks(2398), "Aut est omnis. Nulla suscipit esse provident ducimus dolore placeat. Esse officia vel et voluptate dolorem iure. In sed laboriosam est aut autem.\n\nMaxime nesciunt recusandae sit sapiente est dignissimos. Expedita omnis consequatur consectetur. Sunt quae amet perspiciatis iste repellendus officia facilis.", "G", "61 minutes", "Voluptas quod tempore.", new DateTime(2024, 2, 7, 15, 1, 14, 432, DateTimeKind.Utc).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "description", "rating", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 433, DateTimeKind.Utc).AddTicks(9347), "Nobis nesciunt labore qui omnis. Voluptatibus rerum est est eligendi. Cupiditate dolorem ut sed. Et quos enim ratione aliquam.", "R", "Dignissimos tempora.", new DateTime(2024, 2, 7, 15, 1, 14, 433, DateTimeKind.Utc).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 435, DateTimeKind.Utc).AddTicks(6513), "In iste nihil ut ipsum occaecati voluptatum. Eveniet modi quidem impedit aspernatur. Vel dolor aut. Impedit odit voluptatem dolor. Aperiam sed doloribus. Facere possimus non et sunt.", "71 minutes", "Unde.", new DateTime(2024, 2, 7, 15, 1, 14, 435, DateTimeKind.Utc).AddTicks(6515) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 437, DateTimeKind.Utc).AddTicks(3536), "Reprehenderit ut fuga animi. Aut ut eum consequuntur blanditiis ut aspernatur doloremque. Et omnis eligendi ad dolores quia.", "177 minutes", "Blanditiis doloremque rerum.", new DateTime(2024, 2, 7, 15, 1, 14, 437, DateTimeKind.Utc).AddTicks(3537) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 439, DateTimeKind.Utc).AddTicks(1185), "Et eos aut consequuntur debitis. Vero vero reiciendis sed commodi a ab unde magnam delectus. Fuga eligendi repudiandae dolorem quis. Quaerat tenetur sint dicta temporibus consequatur dolores et accusamus libero. Rem nostrum voluptate ad sapiente consequatur perspiciatis ex.", "91 minutes", "Pariatur enim.", new DateTime(2024, 2, 7, 15, 1, 14, 439, DateTimeKind.Utc).AddTicks(1186) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 440, DateTimeKind.Utc).AddTicks(8699), "Quam qui explicabo ipsum. Hic qui omnis aut unde earum in consequatur aliquid impedit. Suscipit eveniet voluptate nemo voluptate vel doloribus blanditiis. Quibusdam ex rerum consequatur libero numquam commodi ratione doloribus odit.\n\nEt est autem. Odit quos et molestiae et dolorem officia aut beatae qui. Sunt ea quibusdam voluptas amet. Qui et voluptas et accusamus cupiditate consequatur labore. Voluptas dicta dignissimos ab culpa. Et quod omnis natus error sunt saepe ullam suscipit modi.", "R", "61 minutes", "Cupiditate aliquid.", new DateTime(2024, 2, 7, 15, 1, 14, 440, DateTimeKind.Utc).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 442, DateTimeKind.Utc).AddTicks(5846), "Ut sint facere. Consequatur quos sed occaecati voluptas. Ad aspernatur qui. Est alias sint.", "PG", "165 minutes", "Non.", new DateTime(2024, 2, 7, 15, 1, 14, 442, DateTimeKind.Utc).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 444, DateTimeKind.Utc).AddTicks(3783), "Error exercitationem est autem et et enim in. Aspernatur nihil neque enim. Odio cum similique repudiandae ipsa. Architecto perspiciatis est error dolores doloribus voluptatibus et quo. Doloremque omnis totam non quia nobis omnis veritatis magni molestiae. Incidunt qui sequi quo distinctio eum.\n\nEa exercitationem aliquid eius nulla ea. Doloremque recusandae incidunt quidem ducimus repellendus facilis. Ratione unde quidem. Corrupti voluptatum enim aliquid earum quia soluta voluptatem sit expedita. Voluptatem labore soluta.", "R", "167 minutes", "Ab.", new DateTime(2024, 2, 7, 15, 1, 14, 444, DateTimeKind.Utc).AddTicks(3783) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 447, DateTimeKind.Utc).AddTicks(114), "Iusto accusantium facilis quo. Hic et pariatur doloremque soluta laborum consequatur. Error aut ipsa modi temporibus et veritatis et provident similique. Aperiam perferendis nobis minus deleniti ad est tempora officiis. Perspiciatis facere voluptatem cumque minima neque accusantium ab aut id. Voluptas repudiandae ex molestiae aut mollitia mollitia repellendus.", "G", "64 minutes", "Voluptatem.", new DateTime(2024, 2, 7, 15, 1, 14, 447, DateTimeKind.Utc).AddTicks(117) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 448, DateTimeKind.Utc).AddTicks(8431), "Tempore et natus necessitatibus occaecati. Et repellat qui. Odio consequatur minima ex maxime illo. Laborum ad et iure eius.\n\nVoluptate error dolor molestiae voluptas quos. Nam voluptatum iste dolorum quia eum molestiae est sed error. Nesciunt nisi dolores voluptatem dicta ipsum earum. Rerum et odio veniam adipisci qui qui. Harum et inventore aspernatur suscipit.", "R", "179 minutes", "Velit ad.", new DateTime(2024, 2, 7, 15, 1, 14, 448, DateTimeKind.Utc).AddTicks(8432) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 450, DateTimeKind.Utc).AddTicks(5516), "Quas magni suscipit et dolor autem optio et magni quasi. Aut nemo quidem sunt vel neque quas dolores. Delectus est ut dolorem aut architecto soluta.\n\nDolorum quia ut fugit eaque vel. Amet est provident. Vitae quis sunt dolorum nesciunt. Sequi quibusdam qui minima voluptas minima voluptatem doloremque consectetur. Doloribus praesentium eum iusto. Harum aut quis.", "114 minutes", "Facere.", new DateTime(2024, 2, 7, 15, 1, 14, 450, DateTimeKind.Utc).AddTicks(5516) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 452, DateTimeKind.Utc).AddTicks(1871), "Harum doloremque et rerum in ut in pariatur. Reiciendis ut rerum enim eligendi. Architecto aut magni amet aut veniam repellat. Explicabo ipsa et voluptas sed et reiciendis et enim. Facere sapiente rerum dolor quas voluptas explicabo minus quisquam.", "R", "90 minutes", "Non quisquam.", new DateTime(2024, 2, 7, 15, 1, 14, 452, DateTimeKind.Utc).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 453, DateTimeKind.Utc).AddTicks(8084), "Cumque modi harum quibusdam blanditiis porro. Sunt soluta enim voluptate doloribus quasi fugiat. Quidem temporibus facilis enim sunt facilis sint est. Molestias et facere sed error. Omnis dolor autem libero aut.\n\nMaiores doloremque deserunt aut nesciunt voluptatem. Aut iure occaecati aut. Doloribus et nobis ut totam. Ut ducimus dicta sed eligendi aut quis deserunt. Et perferendis cupiditate vitae quae omnis. Est accusamus nostrum quis dolorem et tempore quaerat omnis et.", "R", "139 minutes", "Voluptatum.", new DateTime(2024, 2, 7, 15, 1, 14, 453, DateTimeKind.Utc).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 455, DateTimeKind.Utc).AddTicks(4296), "In rem id illum consequuntur dolorem nostrum nobis excepturi rerum. Explicabo aut aut saepe. Nam quod ipsa culpa et distinctio ducimus. Magni voluptates rerum aliquam adipisci eos. Autem consectetur et accusantium fuga distinctio illo adipisci aut. Error beatae omnis sed illum ipsum dolorem cumque nemo.\n\nFugiat esse necessitatibus. Dolores sit perspiciatis. Reiciendis consequatur id ut enim explicabo omnis id tempora ea.", "PG-13", "96 minutes", "Tempore.", new DateTime(2024, 2, 7, 15, 1, 14, 455, DateTimeKind.Utc).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 457, DateTimeKind.Utc).AddTicks(316), "Quae aliquam inventore. Ipsum aut qui. Nam tempore eligendi nihil culpa aut.", "91 minutes", "Corporis exercitationem.", new DateTime(2024, 2, 7, 15, 1, 14, 457, DateTimeKind.Utc).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 458, DateTimeKind.Utc).AddTicks(6504), "Id fugiat deleniti ipsum cupiditate. Quis sed dolor et saepe dolore eum ipsam. Dolor et deserunt quo non et. Aut ipsa mollitia fugit ipsam consectetur repudiandae. Voluptatem quasi nulla corporis aut quis accusantium aut consequatur.\n\nVoluptate impedit consequatur omnis reiciendis occaecati sapiente vitae. Explicabo enim delectus quis aut odit ipsam. Nam cum exercitationem dolores suscipit laudantium fugit quis dolores. Temporibus quia aliquid modi ut autem itaque nihil eos.", "R", "165 minutes", "Explicabo et.", new DateTime(2024, 2, 7, 15, 1, 14, 458, DateTimeKind.Utc).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2516), 10, new DateTime(2024, 2, 13, 8, 1, 14, 460, DateTimeKind.Utc).AddTicks(2518), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2555), 20, 4, new DateTime(2024, 2, 11, 10, 1, 14, 460, DateTimeKind.Utc).AddTicks(2556), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2556) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2557), 15, 4, new DateTime(2024, 2, 9, 5, 1, 14, 460, DateTimeKind.Utc).AddTicks(2558), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2558), 2, new DateTime(2024, 2, 9, 10, 1, 14, 460, DateTimeKind.Utc).AddTicks(2559), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2560), 14, 4, new DateTime(2024, 2, 10, 5, 1, 14, 460, DateTimeKind.Utc).AddTicks(2560), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2563), 13, 1, new DateTime(2024, 2, 12, 8, 1, 14, 460, DateTimeKind.Utc).AddTicks(2564), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2564), 14, new DateTime(2024, 2, 13, 9, 1, 14, 460, DateTimeKind.Utc).AddTicks(2565), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2566), 14, 3, new DateTime(2024, 2, 12, 1, 1, 14, 460, DateTimeKind.Utc).AddTicks(2566), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2567), 1, 1, new DateTime(2024, 2, 14, 6, 1, 14, 460, DateTimeKind.Utc).AddTicks(2567), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2569), 1, new DateTime(2024, 2, 12, 7, 1, 14, 460, DateTimeKind.Utc).AddTicks(2569), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2570), 5, 2, new DateTime(2024, 2, 10, 1, 1, 14, 460, DateTimeKind.Utc).AddTicks(2570), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2571), 17, 1, new DateTime(2024, 2, 14, 2, 1, 14, 460, DateTimeKind.Utc).AddTicks(2571), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2572), 5, 3, new DateTime(2024, 2, 14, 3, 1, 14, 460, DateTimeKind.Utc).AddTicks(2572), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2573), 8, new DateTime(2024, 2, 10, 7, 1, 14, 460, DateTimeKind.Utc).AddTicks(2573), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2573) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2574), 11, 4, new DateTime(2024, 2, 11, 10, 1, 14, 460, DateTimeKind.Utc).AddTicks(2574), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2583), 14, 2, new DateTime(2024, 2, 9, 2, 1, 14, 460, DateTimeKind.Utc).AddTicks(2583), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2584), 16, 2, new DateTime(2024, 2, 14, 5, 1, 14, 460, DateTimeKind.Utc).AddTicks(2584), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "created_at", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2586), new DateTime(2024, 2, 13, 5, 1, 14, 460, DateTimeKind.Utc).AddTicks(2586), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "created_at", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2587), new DateTime(2024, 2, 14, 7, 1, 14, 460, DateTimeKind.Utc).AddTicks(2587), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2588), 10, new DateTime(2024, 2, 14, 3, 1, 14, 460, DateTimeKind.Utc).AddTicks(2588), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2589), 19, new DateTime(2024, 2, 11, 5, 1, 14, 460, DateTimeKind.Utc).AddTicks(2589), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2590), 11, 4, new DateTime(2024, 2, 10, 1, 1, 14, 460, DateTimeKind.Utc).AddTicks(2590), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2591), 14, 2, new DateTime(2024, 2, 11, 5, 1, 14, 460, DateTimeKind.Utc).AddTicks(2591), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2592), 3, 3, new DateTime(2024, 2, 14, 5, 1, 14, 460, DateTimeKind.Utc).AddTicks(2592), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2592) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2593), 12, 1, new DateTime(2024, 2, 10, 8, 1, 14, 460, DateTimeKind.Utc).AddTicks(2593), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2594), 20, 1, new DateTime(2024, 2, 13, 1, 1, 14, 460, DateTimeKind.Utc).AddTicks(2594), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2595), 12, new DateTime(2024, 2, 13, 3, 1, 14, 460, DateTimeKind.Utc).AddTicks(2595), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2596), 16, 4, new DateTime(2024, 2, 10, 10, 1, 14, 460, DateTimeKind.Utc).AddTicks(2596), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2597), 7, 1, new DateTime(2024, 2, 12, 8, 1, 14, 460, DateTimeKind.Utc).AddTicks(2597), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2598), 7, 2, new DateTime(2024, 2, 12, 2, 1, 14, 460, DateTimeKind.Utc).AddTicks(2598), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2603), 1, 1, new DateTime(2024, 2, 11, 1, 1, 14, 460, DateTimeKind.Utc).AddTicks(2604), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2604), 16, new DateTime(2024, 2, 13, 5, 1, 14, 460, DateTimeKind.Utc).AddTicks(2605), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2605) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2605), 8, 2, new DateTime(2024, 2, 9, 2, 1, 14, 460, DateTimeKind.Utc).AddTicks(2606), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2607), 13, 3, new DateTime(2024, 2, 12, 5, 1, 14, 460, DateTimeKind.Utc).AddTicks(2608), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2608), 7, new DateTime(2024, 2, 9, 8, 1, 14, 460, DateTimeKind.Utc).AddTicks(2609), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2609), 10, 2, new DateTime(2024, 2, 11, 2, 1, 14, 460, DateTimeKind.Utc).AddTicks(2610), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "created_at", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2610), 2, new DateTime(2024, 2, 10, 8, 1, 14, 460, DateTimeKind.Utc).AddTicks(2611), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2611), 4, new DateTime(2024, 2, 13, 7, 1, 14, 460, DateTimeKind.Utc).AddTicks(2612), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2611) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2612), 9, 4, new DateTime(2024, 2, 14, 10, 1, 14, 460, DateTimeKind.Utc).AddTicks(2613), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2613), 6, 4, new DateTime(2024, 2, 12, 3, 1, 14, 460, DateTimeKind.Utc).AddTicks(2614), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2614), 7, 1, new DateTime(2024, 2, 9, 5, 1, 14, 460, DateTimeKind.Utc).AddTicks(2615), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2615), 15, 3, new DateTime(2024, 2, 14, 10, 1, 14, 460, DateTimeKind.Utc).AddTicks(2616), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2616), 16, 2, new DateTime(2024, 2, 12, 6, 1, 14, 460, DateTimeKind.Utc).AddTicks(2617), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "created_at", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2617), new DateTime(2024, 2, 10, 10, 1, 14, 460, DateTimeKind.Utc).AddTicks(2618), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2618) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2618), 3, new DateTime(2024, 2, 10, 5, 1, 14, 460, DateTimeKind.Utc).AddTicks(2619), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2619), 16, 2, new DateTime(2024, 2, 9, 3, 1, 14, 460, DateTimeKind.Utc).AddTicks(2620), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2621), 2, 3, new DateTime(2024, 2, 11, 2, 1, 14, 460, DateTimeKind.Utc).AddTicks(2621), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2621), 3, 2, new DateTime(2024, 2, 12, 5, 1, 14, 460, DateTimeKind.Utc).AddTicks(2622), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2622), 8, 2, new DateTime(2024, 2, 11, 8, 1, 14, 460, DateTimeKind.Utc).AddTicks(2623), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2623), 19, 1, new DateTime(2024, 2, 12, 3, 1, 14, 460, DateTimeKind.Utc).AddTicks(2624), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2624), 10, new DateTime(2024, 2, 11, 5, 1, 14, 460, DateTimeKind.Utc).AddTicks(2625), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2625), 7, 2, new DateTime(2024, 2, 9, 5, 1, 14, 460, DateTimeKind.Utc).AddTicks(2626), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2626), 16, 1, new DateTime(2024, 2, 12, 4, 1, 14, 460, DateTimeKind.Utc).AddTicks(2627), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2627), 5, 4, new DateTime(2024, 2, 13, 4, 1, 14, 460, DateTimeKind.Utc).AddTicks(2628), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2628) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2628), 18, new DateTime(2024, 2, 11, 3, 1, 14, 460, DateTimeKind.Utc).AddTicks(2629), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2629) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2629), 20, 4, new DateTime(2024, 2, 9, 2, 1, 14, 460, DateTimeKind.Utc).AddTicks(2630), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2630), 7, 2, new DateTime(2024, 2, 9, 5, 1, 14, 460, DateTimeKind.Utc).AddTicks(2631), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2631) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2631), 20, 3, new DateTime(2024, 2, 12, 6, 1, 14, 460, DateTimeKind.Utc).AddTicks(2632), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2632), 19, 4, new DateTime(2024, 2, 13, 9, 1, 14, 460, DateTimeKind.Utc).AddTicks(2633), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2633) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2633), 16, 2, new DateTime(2024, 2, 14, 5, 1, 14, 460, DateTimeKind.Utc).AddTicks(2634), new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2634) });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "id", "created_at", "customer_id", "numSeats", "screening_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2636), 25, 2, 40, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2636) },
                    { 2, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2651), 55, 1, 18, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2651) },
                    { 3, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2655), 28, 3, 53, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2655) },
                    { 4, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2657), 18, 4, 40, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2658) },
                    { 5, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2661), 91, 3, 16, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2662) },
                    { 6, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2666), 66, 3, 37, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2666) },
                    { 7, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2670), 44, 1, 28, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2670) },
                    { 8, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2672), 48, 3, 23, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2673) },
                    { 9, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2676), 34, 1, 60, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2676) },
                    { 10, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2681), 40, 4, 30, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2681) },
                    { 11, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2685), 89, 4, 58, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2685) },
                    { 12, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2695), 42, 1, 12, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2695) },
                    { 13, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2699), 52, 4, 58, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2699) },
                    { 14, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2702), 90, 3, 15, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2703) },
                    { 15, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2706), 93, 1, 33, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2706) },
                    { 16, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2709), 52, 1, 44, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2709) },
                    { 17, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2712), 96, 4, 39, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2713) },
                    { 18, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2717), 81, 4, 6, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2717) },
                    { 19, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2721), 44, 2, 54, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2721) },
                    { 20, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2723), 80, 1, 9, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2723) },
                    { 21, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2727), 52, 4, 39, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2727) },
                    { 22, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2730), 12, 3, 52, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2731) },
                    { 23, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2734), 65, 1, 29, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2735) },
                    { 24, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2737), 86, 3, 20, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2737) },
                    { 25, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2740), 58, 1, 38, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2741) },
                    { 26, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2744), 60, 3, 5, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2744) },
                    { 27, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2748), 36, 2, 56, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2748) },
                    { 28, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2750), 42, 3, 56, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2751) },
                    { 29, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2754), 13, 2, 50, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2754) },
                    { 30, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2758), 11, 1, 36, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2758) },
                    { 31, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2761), 9, 1, 7, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2762) },
                    { 32, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2764), 43, 3, 54, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2764) },
                    { 33, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2768), 42, 1, 46, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2768) },
                    { 34, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2772), 55, 4, 5, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2773) },
                    { 35, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2776), 93, 4, 59, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2777) },
                    { 36, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2779), 19, 1, 52, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2779) },
                    { 37, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2782), 53, 4, 32, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2783) },
                    { 38, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2786), 27, 4, 38, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2786) },
                    { 39, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2798), 65, 4, 7, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2798) },
                    { 40, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2800), 12, 1, 22, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2801) },
                    { 41, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2804), 7, 3, 26, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2804) },
                    { 42, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2808), 56, 4, 35, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2808) },
                    { 43, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2811), 58, 3, 25, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2812) },
                    { 44, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2814), 95, 3, 25, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2814) },
                    { 45, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2817), 5, 2, 3, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2817) },
                    { 46, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2821), 94, 1, 23, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2821) },
                    { 47, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2824), 43, 2, 30, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2825) },
                    { 48, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2827), 1, 1, 13, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2827) },
                    { 49, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2830), 13, 4, 19, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2831) },
                    { 50, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2834), 97, 1, 40, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2834) },
                    { 51, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2838), 94, 2, 27, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2838) },
                    { 52, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2840), 59, 2, 32, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2840) },
                    { 53, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2844), 77, 3, 31, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2844) },
                    { 54, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2847), 57, 2, 48, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2847) },
                    { 55, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2851), 80, 3, 52, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2851) },
                    { 56, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2853), 87, 4, 41, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2854) },
                    { 57, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2857), 35, 4, 11, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2857) },
                    { 58, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2861), 23, 1, 24, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2861) },
                    { 59, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2865), 52, 1, 57, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2865) },
                    { 60, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2867), 47, 1, 57, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2867) },
                    { 61, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2871), 50, 4, 3, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2871) },
                    { 62, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2875), 45, 4, 48, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2875) },
                    { 63, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2878), 27, 2, 49, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2878) },
                    { 64, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2880), 51, 2, 38, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2881) },
                    { 65, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2884), 8, 1, 25, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2884) },
                    { 66, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2899), 38, 1, 11, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2900) },
                    { 67, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2903), 45, 2, 55, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2904) },
                    { 68, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2906), 57, 1, 23, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2906) },
                    { 69, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2909), 83, 3, 30, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2910) },
                    { 70, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2913), 86, 1, 28, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2913) },
                    { 71, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2917), 54, 1, 50, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2917) },
                    { 72, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2919), 21, 4, 56, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2919) },
                    { 73, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2922), 93, 1, 14, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2923) },
                    { 74, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2926), 10, 3, 41, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2927) },
                    { 75, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2930), 11, 4, 2, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2930) },
                    { 76, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2932), 11, 4, 17, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2933) },
                    { 77, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2936), 99, 1, 58, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2937) },
                    { 78, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2940), 1, 3, 2, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2940) },
                    { 79, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2944), 90, 4, 19, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2944) },
                    { 80, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2946), 46, 4, 27, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2946) },
                    { 81, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2950), 45, 3, 1, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2950) },
                    { 82, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2953), 97, 4, 13, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2954) },
                    { 83, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2957), 49, 4, 21, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2957) },
                    { 84, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2959), 46, 3, 30, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2960) },
                    { 85, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2963), 27, 1, 38, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2963) },
                    { 86, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2967), 41, 2, 4, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2967) },
                    { 87, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2971), 19, 4, 28, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2971) },
                    { 88, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2973), 57, 4, 34, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2973) },
                    { 89, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2977), 93, 4, 46, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2977) },
                    { 90, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2980), 49, 4, 22, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2981) },
                    { 91, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2984), 46, 2, 1, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2984) },
                    { 92, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2986), 30, 3, 15, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2987) },
                    { 93, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2998), 14, 3, 46, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(2999) },
                    { 94, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3002), 27, 1, 6, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3002) },
                    { 95, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3006), 38, 3, 50, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3006) },
                    { 96, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3008), 63, 1, 37, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3008) },
                    { 97, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3012), 15, 4, 51, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3012) },
                    { 98, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3016), 95, 2, 25, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3016) },
                    { 99, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3019), 35, 2, 41, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3020) },
                    { 100, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3022), 60, 3, 19, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3022) },
                    { 101, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3025), 58, 4, 18, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3025) },
                    { 102, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3029), 32, 4, 10, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3029) },
                    { 103, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3033), 5, 2, 51, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3033) },
                    { 104, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3035), 66, 2, 60, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3036) },
                    { 105, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3039), 80, 2, 9, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3039) },
                    { 106, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3043), 40, 4, 46, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3043) },
                    { 107, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3046), 70, 2, 38, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3047) },
                    { 108, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3049), 24, 4, 46, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3049) },
                    { 109, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3052), 73, 4, 31, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3053) },
                    { 110, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3056), 47, 1, 15, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3056) },
                    { 111, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3060), 57, 2, 57, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3060) },
                    { 112, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3062), 6, 1, 58, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3063) },
                    { 113, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3066), 14, 2, 31, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3066) },
                    { 114, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3070), 1, 1, 15, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3070) },
                    { 115, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3073), 84, 3, 9, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3074) },
                    { 116, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3076), 93, 1, 7, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3076) },
                    { 117, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3079), 81, 3, 20, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3079) },
                    { 118, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3083), 50, 3, 7, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3083) },
                    { 119, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3086), 49, 4, 59, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3087) },
                    { 120, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3089), 44, 2, 49, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3089) },
                    { 121, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3092), 100, 3, 47, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3093) },
                    { 122, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3096), 82, 1, 46, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3096) },
                    { 123, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3107), 3, 4, 19, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3107) },
                    { 124, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3109), 23, 3, 60, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3109) },
                    { 125, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3113), 85, 4, 58, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3113) },
                    { 126, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3117), 94, 3, 6, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3117) },
                    { 127, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3122), 10, 1, 58, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3122) },
                    { 128, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3124), 100, 3, 58, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3124) },
                    { 129, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3127), 64, 1, 1, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3128) },
                    { 130, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3132), 46, 2, 3, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3133) },
                    { 131, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3136), 43, 2, 21, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3136) },
                    { 132, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3138), 81, 3, 49, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3139) },
                    { 133, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3142), 38, 1, 56, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3142) },
                    { 134, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3146), 91, 2, 36, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3146) },
                    { 135, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3149), 24, 3, 3, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3150) },
                    { 136, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3151), 94, 1, 26, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3152) },
                    { 137, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3155), 73, 1, 7, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3156) },
                    { 138, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3159), 93, 1, 60, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3159) },
                    { 139, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3162), 99, 4, 27, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3163) },
                    { 140, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3165), 33, 3, 36, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3165) },
                    { 141, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3168), 48, 2, 5, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3169) },
                    { 142, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3173), 29, 1, 58, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3173) },
                    { 143, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3176), 85, 1, 13, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3177) },
                    { 144, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3179), 58, 4, 32, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3179) },
                    { 145, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3190), 42, 2, 42, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3190) },
                    { 146, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3194), 12, 3, 32, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3194) },
                    { 147, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3197), 36, 2, 10, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3198) },
                    { 148, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3200), 99, 4, 30, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3200) },
                    { 149, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3203), 14, 1, 40, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3204) },
                    { 150, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3207), 43, 3, 25, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3207) },
                    { 151, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3211), 64, 1, 29, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3211) },
                    { 152, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3213), 62, 3, 27, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3213) },
                    { 153, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3217), 42, 4, 42, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3217) },
                    { 154, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3220), 92, 4, 34, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3221) },
                    { 155, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3224), 4, 4, 55, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3224) },
                    { 156, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3226), 5, 2, 53, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3227) },
                    { 157, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3230), 10, 4, 19, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3230) },
                    { 158, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3234), 64, 1, 59, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3234) },
                    { 159, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3237), 43, 4, 36, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3238) },
                    { 160, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3240), 50, 2, 51, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3240) },
                    { 161, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3243), 35, 4, 58, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3243) },
                    { 162, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3247), 39, 4, 10, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3247) },
                    { 163, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3251), 47, 4, 4, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3251) },
                    { 164, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3253), 2, 1, 19, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3253) },
                    { 165, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3256), 79, 4, 4, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3257) },
                    { 166, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3260), 33, 3, 56, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3260) },
                    { 167, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3264), 59, 2, 17, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3264) },
                    { 168, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3266), 53, 4, 31, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3266) },
                    { 169, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3270), 54, 3, 47, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3270) },
                    { 170, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3273), 67, 4, 33, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3274) },
                    { 171, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3277), 27, 4, 42, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3277) },
                    { 172, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3279), 3, 4, 8, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3280) },
                    { 173, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3283), 99, 1, 17, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3283) },
                    { 174, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3298), 15, 2, 58, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3299) },
                    { 175, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3302), 74, 1, 24, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3302) },
                    { 176, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3304), 14, 4, 20, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3304) },
                    { 177, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3308), 63, 3, 24, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3308) },
                    { 178, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3312), 72, 1, 28, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3312) },
                    { 179, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3315), 9, 1, 3, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3316) },
                    { 180, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3318), 1, 4, 48, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3318) },
                    { 181, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3321), 10, 1, 4, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3322) },
                    { 182, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3325), 74, 2, 22, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3325) },
                    { 183, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3329), 95, 3, 29, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3329) },
                    { 184, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3331), 51, 4, 37, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3331) },
                    { 185, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3334), 39, 2, 4, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3335) },
                    { 186, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3339), 22, 3, 2, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3339) },
                    { 187, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3342), 23, 3, 40, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3343) },
                    { 188, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3345), 99, 1, 47, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3345) },
                    { 189, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3349), 51, 3, 32, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3349) },
                    { 190, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3352), 97, 4, 53, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3353) },
                    { 191, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3356), 84, 2, 37, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3356) },
                    { 192, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3358), 83, 4, 35, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3359) },
                    { 193, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3362), 52, 4, 50, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3362) },
                    { 194, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3366), 27, 2, 38, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3366) },
                    { 195, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3369), 40, 1, 24, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3370) },
                    { 196, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3372), 46, 2, 2, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3372) },
                    { 197, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3375), 64, 1, 39, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3375) },
                    { 198, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3379), 32, 3, 33, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3379) },
                    { 199, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3383), 21, 1, 46, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3383) },
                    { 200, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3385), 74, 4, 43, new DateTime(2024, 2, 7, 15, 1, 14, 460, DateTimeKind.Utc).AddTicks(3385) }
                });

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
                name: "tickets");

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 448, DateTimeKind.Utc).AddTicks(4098), "DavidWilson74@yahoo.com", "David Wilson", "710.211.7464 x5831", new DateTime(2024, 2, 7, 14, 52, 52, 448, DateTimeKind.Utc).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 452, DateTimeKind.Utc).AddTicks(8545), "DanielGarcia19@hotmail.com", "Daniel Garcia", "1-578-969-4168", new DateTime(2024, 2, 7, 14, 52, 52, 452, DateTimeKind.Utc).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 456, DateTimeKind.Utc).AddTicks(6902), "EmilyJohnson24@yahoo.com", "Emily Johnson", "246.397.7688 x0560", new DateTime(2024, 2, 7, 14, 52, 52, 456, DateTimeKind.Utc).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 460, DateTimeKind.Utc).AddTicks(7834), "EmilyRodriguez.Marquardt12@yahoo.com", "Emily Rodriguez", "785-609-0856 x45051", new DateTime(2024, 2, 7, 14, 52, 52, 460, DateTimeKind.Utc).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 464, DateTimeKind.Utc).AddTicks(7105), "SarahSmith79@yahoo.com", "Sarah Smith", "1-956-855-8440 x0510", new DateTime(2024, 2, 7, 14, 52, 52, 464, DateTimeKind.Utc).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 468, DateTimeKind.Utc).AddTicks(2368), "DavidDavis47@hotmail.com", "David Davis", "(644) 419-0165 x4308", new DateTime(2024, 2, 7, 14, 52, 52, 468, DateTimeKind.Utc).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 471, DateTimeKind.Utc).AddTicks(6217), "MatthewMiller.MacGyver@gmail.com", "Matthew Miller", "(663) 308-3131 x154", new DateTime(2024, 2, 7, 14, 52, 52, 471, DateTimeKind.Utc).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 473, DateTimeKind.Utc).AddTicks(9931), "MatthewJohnson_Wolf@gmail.com", "Matthew Johnson", "(217) 805-0465 x81173", new DateTime(2024, 2, 7, 14, 52, 52, 473, DateTimeKind.Utc).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 476, DateTimeKind.Utc).AddTicks(9421), "JaneRodriguez_Wolff1@gmail.com", "Jane Rodriguez", "555.993.1288 x0139", new DateTime(2024, 2, 7, 14, 52, 52, 476, DateTimeKind.Utc).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 481, DateTimeKind.Utc).AddTicks(6227), "SarahWilson36@yahoo.com", "Sarah Wilson", "399.898.4242 x007", new DateTime(2024, 2, 7, 14, 52, 52, 481, DateTimeKind.Utc).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 484, DateTimeKind.Utc).AddTicks(712), "MatthewRodriguez.Brown@yahoo.com", "Matthew Rodriguez", "(798) 253-0559", new DateTime(2024, 2, 7, 14, 52, 52, 484, DateTimeKind.Utc).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 488, DateTimeKind.Utc).AddTicks(3427), "DanielWilson.Sporer@yahoo.com", "Daniel Wilson", "1-530-538-5803", new DateTime(2024, 2, 7, 14, 52, 52, 488, DateTimeKind.Utc).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 491, DateTimeKind.Utc).AddTicks(4855), "JessicaWilson_Kovacek@yahoo.com", "Jessica Wilson", "1-917-441-6772 x60157", new DateTime(2024, 2, 7, 14, 52, 52, 491, DateTimeKind.Utc).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "created_at", "email", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 493, DateTimeKind.Utc).AddTicks(9686), "JessicaDavis59@yahoo.com", "(879) 895-3646", new DateTime(2024, 2, 7, 14, 52, 52, 493, DateTimeKind.Utc).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 496, DateTimeKind.Utc).AddTicks(5899), "MatthewJohnson_Pouros@hotmail.com", "Matthew Johnson", "(588) 677-7341", new DateTime(2024, 2, 7, 14, 52, 52, 496, DateTimeKind.Utc).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 500, DateTimeKind.Utc).AddTicks(254), "DavidBrown29@hotmail.com", "David Brown", "(825) 348-8572", new DateTime(2024, 2, 7, 14, 52, 52, 500, DateTimeKind.Utc).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 504, DateTimeKind.Utc).AddTicks(2809), "DanielDavis99@hotmail.com", "Daniel Davis", "944.624.7729 x36669", new DateTime(2024, 2, 7, 14, 52, 52, 504, DateTimeKind.Utc).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 507, DateTimeKind.Utc).AddTicks(7024), "JohnDavis16@yahoo.com", "John Davis", "(266) 792-5775", new DateTime(2024, 2, 7, 14, 52, 52, 507, DateTimeKind.Utc).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 511, DateTimeKind.Utc).AddTicks(699), "JessicaWilliams_Boehm@yahoo.com", "Jessica Williams", "663.831.0035", new DateTime(2024, 2, 7, 14, 52, 52, 511, DateTimeKind.Utc).AddTicks(701) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 514, DateTimeKind.Utc).AddTicks(987), "DavidJones_Hahn@hotmail.com", "David Jones", "(824) 241-9006 x235", new DateTime(2024, 2, 7, 14, 52, 52, 514, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 517, DateTimeKind.Utc).AddTicks(1604), "SarahJones93@gmail.com", "Sarah Jones", "694.418.1668 x3560", new DateTime(2024, 2, 7, 14, 52, 52, 517, DateTimeKind.Utc).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 519, DateTimeKind.Utc).AddTicks(7362), "DavidGarcia40@gmail.com", "David Garcia", "673-538-8957", new DateTime(2024, 2, 7, 14, 52, 52, 519, DateTimeKind.Utc).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 523, DateTimeKind.Utc).AddTicks(5800), "JohnMiller_Von40@hotmail.com", "John Miller", "(843) 644-9635", new DateTime(2024, 2, 7, 14, 52, 52, 523, DateTimeKind.Utc).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 527, DateTimeKind.Utc).AddTicks(1923), "JenniferGarcia.Pfeffer54@yahoo.com", "Jennifer Garcia", "445-381-1628 x219", new DateTime(2024, 2, 7, 14, 52, 52, 527, DateTimeKind.Utc).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 531, DateTimeKind.Utc).AddTicks(5220), "DanielMiller.Macejkovic@yahoo.com", "Daniel Miller", "(414) 567-3699 x723", new DateTime(2024, 2, 7, 14, 52, 52, 531, DateTimeKind.Utc).AddTicks(5225) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 533, DateTimeKind.Utc).AddTicks(9513), "MatthewWilson.Bahringer88@yahoo.com", "Matthew Wilson", "552-583-3493 x11949", new DateTime(2024, 2, 7, 14, 52, 52, 533, DateTimeKind.Utc).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 536, DateTimeKind.Utc).AddTicks(4100), "DanielWilson.Feest@yahoo.com", "Daniel Wilson", "1-926-813-7747 x90712", new DateTime(2024, 2, 7, 14, 52, 52, 536, DateTimeKind.Utc).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 538, DateTimeKind.Utc).AddTicks(9964), "JessicaWilson_Upton@hotmail.com", "Jessica Wilson", "994-596-6228 x059", new DateTime(2024, 2, 7, 14, 52, 52, 538, DateTimeKind.Utc).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 541, DateTimeKind.Utc).AddTicks(5186), "JenniferMiller.Abernathy@yahoo.com", "Jennifer Miller", "1-475-347-8904 x075", new DateTime(2024, 2, 7, 14, 52, 52, 541, DateTimeKind.Utc).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 543, DateTimeKind.Utc).AddTicks(9078), "JenniferRodriguez2@gmail.com", "Jennifer Rodriguez", "831.501.5629 x05684", new DateTime(2024, 2, 7, 14, 52, 52, 543, DateTimeKind.Utc).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 546, DateTimeKind.Utc).AddTicks(2368), "MichaelJones55@hotmail.com", "Michael Jones", "436-472-0757", new DateTime(2024, 2, 7, 14, 52, 52, 546, DateTimeKind.Utc).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 551, DateTimeKind.Utc).AddTicks(2219), "MatthewGarcia_Watsica84@hotmail.com", "Matthew Garcia", "1-965-790-1314 x088", new DateTime(2024, 2, 7, 14, 52, 52, 551, DateTimeKind.Utc).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 556, DateTimeKind.Utc).AddTicks(518), "JenniferWilliams_Bogisich@hotmail.com", "Jennifer Williams", "1-793-888-7617", new DateTime(2024, 2, 7, 14, 52, 52, 556, DateTimeKind.Utc).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 560, DateTimeKind.Utc).AddTicks(7224), "MichaelJohnson77@yahoo.com", "Michael Johnson", "1-362-371-7336 x9367", new DateTime(2024, 2, 7, 14, 52, 52, 560, DateTimeKind.Utc).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 566, DateTimeKind.Utc).AddTicks(3005), "DanielBrown_Pollich53@gmail.com", "Daniel Brown", "(484) 988-5397", new DateTime(2024, 2, 7, 14, 52, 52, 566, DateTimeKind.Utc).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 570, DateTimeKind.Utc).AddTicks(8356), "JenniferJohnson.Orn30@hotmail.com", "Jennifer Johnson", "856.399.9240 x370", new DateTime(2024, 2, 7, 14, 52, 52, 570, DateTimeKind.Utc).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 575, DateTimeKind.Utc).AddTicks(2483), "JessicaWilson.Rowe@gmail.com", "Jessica Wilson", "696-413-2734", new DateTime(2024, 2, 7, 14, 52, 52, 575, DateTimeKind.Utc).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 580, DateTimeKind.Utc).AddTicks(3196), "JenniferWilliams.Douglas30@gmail.com", "Jennifer Williams", "553-255-1438", new DateTime(2024, 2, 7, 14, 52, 52, 580, DateTimeKind.Utc).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 583, DateTimeKind.Utc).AddTicks(3398), "JaneWilliams71@hotmail.com", "Jane Williams", "390-328-6466", new DateTime(2024, 2, 7, 14, 52, 52, 583, DateTimeKind.Utc).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 587, DateTimeKind.Utc).AddTicks(8589), "MatthewJones.Schaefer27@gmail.com", "Matthew Jones", "(312) 633-7599 x7756", new DateTime(2024, 2, 7, 14, 52, 52, 587, DateTimeKind.Utc).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 591, DateTimeKind.Utc).AddTicks(8814), "EmilyDavis_Rath88@hotmail.com", "Emily Davis", "991.417.7023 x84340", new DateTime(2024, 2, 7, 14, 52, 52, 591, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 596, DateTimeKind.Utc).AddTicks(2835), "MatthewSmith.Von@hotmail.com", "Matthew Smith", "878.237.1885 x1319", new DateTime(2024, 2, 7, 14, 52, 52, 596, DateTimeKind.Utc).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 598, DateTimeKind.Utc).AddTicks(8550), "DanielJohnson30@hotmail.com", "Daniel Johnson", "1-376-613-0439", new DateTime(2024, 2, 7, 14, 52, 52, 598, DateTimeKind.Utc).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 601, DateTimeKind.Utc).AddTicks(3280), "JaneJones_Kertzmann8@yahoo.com", "Jane Jones", "1-214-315-9886 x36844", new DateTime(2024, 2, 7, 14, 52, 52, 601, DateTimeKind.Utc).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 603, DateTimeKind.Utc).AddTicks(5717), "MichaelBrown79@yahoo.com", "Michael Brown", "946-511-5634", new DateTime(2024, 2, 7, 14, 52, 52, 603, DateTimeKind.Utc).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 606, DateTimeKind.Utc).AddTicks(7221), "DavidRodriguez.Denesik@gmail.com", "David Rodriguez", "810.493.6078", new DateTime(2024, 2, 7, 14, 52, 52, 606, DateTimeKind.Utc).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 610, DateTimeKind.Utc).AddTicks(4091), "DavidMiller82@gmail.com", "David Miller", "1-396-281-9911", new DateTime(2024, 2, 7, 14, 52, 52, 610, DateTimeKind.Utc).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 614, DateTimeKind.Utc).AddTicks(5503), "DanielDavis.Mann@gmail.com", "Daniel Davis", "425.876.2461 x911", new DateTime(2024, 2, 7, 14, 52, 52, 614, DateTimeKind.Utc).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 618, DateTimeKind.Utc).AddTicks(6398), "JohnSmith.Collier@hotmail.com", "John Smith", "419-991-2910", new DateTime(2024, 2, 7, 14, 52, 52, 618, DateTimeKind.Utc).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 622, DateTimeKind.Utc).AddTicks(7337), "DavidWilson52@yahoo.com", "David Wilson", "441-308-2759", new DateTime(2024, 2, 7, 14, 52, 52, 622, DateTimeKind.Utc).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 635, DateTimeKind.Utc).AddTicks(9865), "JenniferGarcia.Herman@yahoo.com", "Jennifer Garcia", "1-273-632-4031", new DateTime(2024, 2, 7, 14, 52, 52, 635, DateTimeKind.Utc).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 638, DateTimeKind.Utc).AddTicks(5936), "JenniferWilson43@hotmail.com", "Jennifer Wilson", "(667) 422-3309", new DateTime(2024, 2, 7, 14, 52, 52, 638, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 641, DateTimeKind.Utc).AddTicks(1531), "JaneJohnson83@hotmail.com", "Jane Johnson", "1-434-299-8569 x8069", new DateTime(2024, 2, 7, 14, 52, 52, 641, DateTimeKind.Utc).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 643, DateTimeKind.Utc).AddTicks(6763), "JaneWilliams.Gaylord47@gmail.com", "Jane Williams", "(705) 908-0438 x53567", new DateTime(2024, 2, 7, 14, 52, 52, 643, DateTimeKind.Utc).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 646, DateTimeKind.Utc).AddTicks(122), "JenniferSmith.Braun30@hotmail.com", "Jennifer Smith", "450.987.7237 x5469", new DateTime(2024, 2, 7, 14, 52, 52, 646, DateTimeKind.Utc).AddTicks(124) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 649, DateTimeKind.Utc).AddTicks(3448), "EmilyJohnson73@hotmail.com", "Emily Johnson", "545.571.6034", new DateTime(2024, 2, 7, 14, 52, 52, 649, DateTimeKind.Utc).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 653, DateTimeKind.Utc).AddTicks(1372), "JessicaMiller.Hamill65@yahoo.com", "Jessica Miller", "698.457.9932 x768", new DateTime(2024, 2, 7, 14, 52, 52, 653, DateTimeKind.Utc).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 656, DateTimeKind.Utc).AddTicks(3751), "SarahMiller_Ledner@gmail.com", "Sarah Miller", "295.644.0395 x73497", new DateTime(2024, 2, 7, 14, 52, 52, 656, DateTimeKind.Utc).AddTicks(3756) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 659, DateTimeKind.Utc).AddTicks(6493), "DanielJones32@gmail.com", "Daniel Jones", "1-658-632-5816", new DateTime(2024, 2, 7, 14, 52, 52, 659, DateTimeKind.Utc).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 662, DateTimeKind.Utc).AddTicks(1017), "JessicaBrown.Koepp@hotmail.com", "Jessica Brown", "1-203-707-0639", new DateTime(2024, 2, 7, 14, 52, 52, 662, DateTimeKind.Utc).AddTicks(1019) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 664, DateTimeKind.Utc).AddTicks(6517), "JaneRodriguez.Braun78@yahoo.com", "Jane Rodriguez", "(845) 570-0663 x4317", new DateTime(2024, 2, 7, 14, 52, 52, 664, DateTimeKind.Utc).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 667, DateTimeKind.Utc).AddTicks(2502), "MatthewSmith_Rogahn43@hotmail.com", "Matthew Smith", "1-222-585-3356", new DateTime(2024, 2, 7, 14, 52, 52, 667, DateTimeKind.Utc).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 669, DateTimeKind.Utc).AddTicks(7149), "EmilyDavis.Kshlerin18@gmail.com", "Emily Davis", "578-909-5485 x43238", new DateTime(2024, 2, 7, 14, 52, 52, 669, DateTimeKind.Utc).AddTicks(7153) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 672, DateTimeKind.Utc).AddTicks(6026), "JohnJohnson_Paucek@yahoo.com", "John Johnson", "318-569-4986", new DateTime(2024, 2, 7, 14, 52, 52, 672, DateTimeKind.Utc).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 677, DateTimeKind.Utc).AddTicks(7661), "JaneMiller68@yahoo.com", "Jane Miller", "1-799-634-4788", new DateTime(2024, 2, 7, 14, 52, 52, 677, DateTimeKind.Utc).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 682, DateTimeKind.Utc).AddTicks(6168), "JessicaRodriguez58@gmail.com", "Jessica Rodriguez", "1-542-663-4098 x44713", new DateTime(2024, 2, 7, 14, 52, 52, 682, DateTimeKind.Utc).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 687, DateTimeKind.Utc).AddTicks(418), "EmilyJones19@hotmail.com", "Emily Jones", "1-752-985-9138 x30123", new DateTime(2024, 2, 7, 14, 52, 52, 687, DateTimeKind.Utc).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 692, DateTimeKind.Utc).AddTicks(5412), "DavidBrown63@hotmail.com", "David Brown", "963-455-3835 x7429", new DateTime(2024, 2, 7, 14, 52, 52, 692, DateTimeKind.Utc).AddTicks(5416) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 696, DateTimeKind.Utc).AddTicks(3498), "SarahSmith.Kuphal@yahoo.com", "Sarah Smith", "1-622-618-5194 x1630", new DateTime(2024, 2, 7, 14, 52, 52, 696, DateTimeKind.Utc).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 698, DateTimeKind.Utc).AddTicks(7808), "DavidWilliams_Dooley30@hotmail.com", "David Williams", "240.862.9309 x6873", new DateTime(2024, 2, 7, 14, 52, 52, 698, DateTimeKind.Utc).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 701, DateTimeKind.Utc).AddTicks(3778), "EmilyMiller_Weimann@gmail.com", "Emily Miller", "(314) 243-6108 x748", new DateTime(2024, 2, 7, 14, 52, 52, 701, DateTimeKind.Utc).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 704, DateTimeKind.Utc).AddTicks(1220), "DanielWilson.Gutkowski@yahoo.com", "Daniel Wilson", "999.633.9547 x3057", new DateTime(2024, 2, 7, 14, 52, 52, 704, DateTimeKind.Utc).AddTicks(1224) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 707, DateTimeKind.Utc).AddTicks(1554), "DanielDavis.Hermiston56@yahoo.com", "Daniel Davis", "550-575-7699 x66567", new DateTime(2024, 2, 7, 14, 52, 52, 707, DateTimeKind.Utc).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 711, DateTimeKind.Utc).AddTicks(4994), "EmilyBrown37@gmail.com", "Emily Brown", "1-667-689-9026 x9690", new DateTime(2024, 2, 7, 14, 52, 52, 711, DateTimeKind.Utc).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 714, DateTimeKind.Utc).AddTicks(868), "MatthewMiller.Prosacco@yahoo.com", "Matthew Miller", "1-650-344-8178 x47515", new DateTime(2024, 2, 7, 14, 52, 52, 714, DateTimeKind.Utc).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 716, DateTimeKind.Utc).AddTicks(5016), "JessicaMiller44@hotmail.com", "Jessica Miller", "619.905.0826 x412", new DateTime(2024, 2, 7, 14, 52, 52, 716, DateTimeKind.Utc).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 719, DateTimeKind.Utc).AddTicks(9487), "DanielJohnson47@gmail.com", "Daniel Johnson", "1-403-450-9875", new DateTime(2024, 2, 7, 14, 52, 52, 719, DateTimeKind.Utc).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 724, DateTimeKind.Utc).AddTicks(3766), "EmilyRodriguez_Gutmann68@hotmail.com", "Emily Rodriguez", "441.228.0154 x845", new DateTime(2024, 2, 7, 14, 52, 52, 724, DateTimeKind.Utc).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 728, DateTimeKind.Utc).AddTicks(7705), "EmilySmith26@yahoo.com", "Emily Smith", "425-352-1176 x66132", new DateTime(2024, 2, 7, 14, 52, 52, 728, DateTimeKind.Utc).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 731, DateTimeKind.Utc).AddTicks(3711), "DanielWilson24@hotmail.com", "Daniel Wilson", "(462) 520-6083", new DateTime(2024, 2, 7, 14, 52, 52, 731, DateTimeKind.Utc).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 733, DateTimeKind.Utc).AddTicks(8212), "MichaelWilliams.Kertzmann39@gmail.com", "Michael Williams", "1-455-556-8315", new DateTime(2024, 2, 7, 14, 52, 52, 733, DateTimeKind.Utc).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 747, DateTimeKind.Utc).AddTicks(1704), "JenniferJones28@yahoo.com", "Jennifer Jones", "1-557-537-8551", new DateTime(2024, 2, 7, 14, 52, 52, 747, DateTimeKind.Utc).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 750, DateTimeKind.Utc).AddTicks(770), "MatthewWilliams.Schuppe@yahoo.com", "Matthew Williams", "374.286.6872", new DateTime(2024, 2, 7, 14, 52, 52, 750, DateTimeKind.Utc).AddTicks(773) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 754, DateTimeKind.Utc).AddTicks(165), "SarahSmith.Brekke56@hotmail.com", "Sarah Smith", "911-344-5856 x5367", new DateTime(2024, 2, 7, 14, 52, 52, 754, DateTimeKind.Utc).AddTicks(168) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 758, DateTimeKind.Utc).AddTicks(2475), "DanielDavis94@yahoo.com", "Daniel Davis", "288-443-1023 x0046", new DateTime(2024, 2, 7, 14, 52, 52, 758, DateTimeKind.Utc).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 761, DateTimeKind.Utc).AddTicks(4939), "MichaelJones_Rice@hotmail.com", "Michael Jones", "1-414-248-9493 x47208", new DateTime(2024, 2, 7, 14, 52, 52, 761, DateTimeKind.Utc).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 764, DateTimeKind.Utc).AddTicks(1180), "MatthewDavis_Beier44@yahoo.com", "Matthew Davis", "(490) 937-9688 x9708", new DateTime(2024, 2, 7, 14, 52, 52, 764, DateTimeKind.Utc).AddTicks(1184) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 766, DateTimeKind.Utc).AddTicks(4708), "MatthewRodriguez_Marquardt53@hotmail.com", "Matthew Rodriguez", "900.761.1136 x44281", new DateTime(2024, 2, 7, 14, 52, 52, 766, DateTimeKind.Utc).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 770, DateTimeKind.Utc).AddTicks(1265), "JenniferWilliams88@yahoo.com", "Jennifer Williams", "727.297.4053 x1028", new DateTime(2024, 2, 7, 14, 52, 52, 770, DateTimeKind.Utc).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 772, DateTimeKind.Utc).AddTicks(8155), "DanielSmith17@gmail.com", "Daniel Smith", "662-974-5928 x05538", new DateTime(2024, 2, 7, 14, 52, 52, 772, DateTimeKind.Utc).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 775, DateTimeKind.Utc).AddTicks(2967), "JaneGarcia63@hotmail.com", "Jane Garcia", "639-398-5780 x5411", new DateTime(2024, 2, 7, 14, 52, 52, 775, DateTimeKind.Utc).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 778, DateTimeKind.Utc).AddTicks(3793), "DanielWilson30@hotmail.com", "Daniel Wilson", "1-246-905-3410", new DateTime(2024, 2, 7, 14, 52, 52, 778, DateTimeKind.Utc).AddTicks(3796) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 781, DateTimeKind.Utc).AddTicks(2196), "JohnBrown41@gmail.com", "John Brown", "(714) 806-9705", new DateTime(2024, 2, 7, 14, 52, 52, 781, DateTimeKind.Utc).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 786, DateTimeKind.Utc).AddTicks(1349), "JenniferMiller90@yahoo.com", "Jennifer Miller", "445-223-2527", new DateTime(2024, 2, 7, 14, 52, 52, 786, DateTimeKind.Utc).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 788, DateTimeKind.Utc).AddTicks(6020), "MichaelSmith.OReilly@gmail.com", "Michael Smith", "442.262.9899 x565", new DateTime(2024, 2, 7, 14, 52, 52, 788, DateTimeKind.Utc).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 792, DateTimeKind.Utc).AddTicks(1563), "DanielMiller50@gmail.com", "Daniel Miller", "1-455-323-4200 x0839", new DateTime(2024, 2, 7, 14, 52, 52, 792, DateTimeKind.Utc).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "created_at", "email", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 795, DateTimeKind.Utc).AddTicks(3733), "DanielBrown59@gmail.com", "524-468-1999 x34454", new DateTime(2024, 2, 7, 14, 52, 52, 795, DateTimeKind.Utc).AddTicks(3736) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 798, DateTimeKind.Utc).AddTicks(4670), "DavidMiller_Reichel71@gmail.com", "David Miller", "397.520.0582", new DateTime(2024, 2, 7, 14, 52, 52, 798, DateTimeKind.Utc).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 801, DateTimeKind.Utc).AddTicks(7867), "DanielJohnson46@yahoo.com", "Daniel Johnson", "480.536.5864 x5898", new DateTime(2024, 2, 7, 14, 52, 52, 801, DateTimeKind.Utc).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "customer",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "created_at", "email", "name", "phone", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 805, DateTimeKind.Utc).AddTicks(4774), "EmilyDavis.Hintz@gmail.com", "Emily Davis", "1-605-568-1364", new DateTime(2024, 2, 7, 14, 52, 52, 805, DateTimeKind.Utc).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 808, DateTimeKind.Utc).AddTicks(977), "Incidunt commodi repellendus nisi fuga placeat. Ea sequi natus. Quis ratione ut. Voluptatibus maxime aut et tempora.", "120 minutes", "Ut ipsam placeat.", new DateTime(2024, 2, 7, 14, 52, 52, 808, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 811, DateTimeKind.Utc).AddTicks(385), "Maiores temporibus dolor id molestiae. Voluptate eos vero et suscipit nisi sed reiciendis et nostrum. Id aut delectus sint consequatur sit quo. Sed est ut nihil fugiat enim laudantium incidunt. Dolorum id aut et quae quis. Sed dolorum ut est.\n\nEst itaque autem aut qui. Voluptatum consequatur est dolorem incidunt cumque est ea est repellendus. Doloribus illum quis ut enim et. Et soluta sunt.", "G", "126 minutes", "Reprehenderit est officia.", new DateTime(2024, 2, 7, 14, 52, 52, 811, DateTimeKind.Utc).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 814, DateTimeKind.Utc).AddTicks(1787), "Quo dolores quia cumque dolor esse. Laborum necessitatibus unde enim. Quaerat eius adipisci cum iure est unde. Ducimus consequatur sit fugiat nesciunt amet est aut. Nam culpa quo. Et odio voluptas sed.\n\nEt repudiandae sed maxime aliquam enim nostrum consequuntur recusandae. Laborum officiis quae molestias aperiam id aut. Enim est perspiciatis aliquam accusamus animi commodi. Ipsum nulla est blanditiis ipsam quia.", "G", "135 minutes", "Officia non.", new DateTime(2024, 2, 7, 14, 52, 52, 814, DateTimeKind.Utc).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 816, DateTimeKind.Utc).AddTicks(9834), "Recusandae sed ut doloremque omnis id maiores sunt. Molestias voluptatem quia inventore ut et ut tempore eum. Perspiciatis cupiditate sit blanditiis veniam maiores perferendis.\n\nRatione voluptas maxime cumque. Itaque dolore enim animi beatae et exercitationem maiores sequi perspiciatis. Et temporibus ipsam aut adipisci aspernatur quia ad. Molestiae illum odit eligendi aspernatur.", "PG-13", "145 minutes", "Corporis vitae sint.", new DateTime(2024, 2, 7, 14, 52, 52, 816, DateTimeKind.Utc).AddTicks(9838) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 819, DateTimeKind.Utc).AddTicks(6349), "Soluta eum dolore occaecati aut. Est sunt voluptatem blanditiis at iusto sapiente rem voluptatum ipsa. Sint deleniti maxime ut iste. Voluptatem aut ut iste cum qui facere non repellat ut.", "R", "97 minutes", "Dolore eum enim.", new DateTime(2024, 2, 7, 14, 52, 52, 819, DateTimeKind.Utc).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "description", "rating", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 821, DateTimeKind.Utc).AddTicks(9661), "Aspernatur ut ut possimus eum atque. Consequuntur ut dolor omnis qui laudantium tenetur accusantium ut. Et nihil consequatur.\n\nMolestiae dolor earum iste labore. At sapiente voluptatem sit ea dolor accusamus dolor. Illo delectus fuga vel quisquam. Laudantium corporis doloribus quisquam accusamus necessitatibus vel dolorum.", "PG-13", "Alias occaecati.", new DateTime(2024, 2, 7, 14, 52, 52, 821, DateTimeKind.Utc).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 824, DateTimeKind.Utc).AddTicks(3309), "Rerum et sed est accusantium aut iure nihil sit sapiente. Explicabo maxime in molestias sapiente expedita nam. Molestias asperiores alias nulla vitae consequatur. Sed impedit aliquam. Eius ut natus mollitia sapiente quia ea esse quasi provident. Dolor eius itaque doloribus qui rerum voluptatem a hic.", "114 minutes", "Totam praesentium asperiores.", new DateTime(2024, 2, 7, 14, 52, 52, 824, DateTimeKind.Utc).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 826, DateTimeKind.Utc).AddTicks(7001), "Debitis eos et iste totam velit et. Praesentium delectus illum ut deleniti qui velit ut. Culpa aliquam optio et nihil. Quia velit in mollitia exercitationem. Soluta earum amet exercitationem voluptas qui nesciunt est voluptatem. Officia quia quod.\n\nEos ab labore inventore voluptatem totam. Odio ea sed corrupti adipisci beatae. Facere aut quod ut laudantium voluptatum. Temporibus id debitis animi.", "105 minutes", "Qui quam culpa.", new DateTime(2024, 2, 7, 14, 52, 52, 826, DateTimeKind.Utc).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 829, DateTimeKind.Utc).AddTicks(6549), "Recusandae eveniet natus. Necessitatibus natus sit est quo maiores. Itaque consequatur praesentium autem voluptatem repellendus quia magni tempora sit. Ipsa libero aut enim. Quae non et accusantium eaque minus est blanditiis. Illum hic illum nihil et est.", "73 minutes", "Ea laboriosam quae.", new DateTime(2024, 2, 7, 14, 52, 52, 829, DateTimeKind.Utc).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 832, DateTimeKind.Utc).AddTicks(1465), "Rerum deserunt porro ut a voluptas veritatis eos repudiandae. Eius aut laborum minus. Et qui qui sequi ut aut delectus. Enim quam laboriosam dolor. Est ea ea eum voluptas id voluptatum quasi.", "PG", "177 minutes", "Id qui at.", new DateTime(2024, 2, 7, 14, 52, 52, 832, DateTimeKind.Utc).AddTicks(1468) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 834, DateTimeKind.Utc).AddTicks(7360), "Architecto maiores exercitationem et dolorem facilis sunt quae. Quod hic sunt qui laudantium sit cum ullam. Hic beatae voluptates quod rerum quam et. Odit eius maiores soluta voluptas harum aut aut. Quo velit eligendi suscipit tempora aliquam et quam nisi sed.", "G", "112 minutes", "Reprehenderit.", new DateTime(2024, 2, 7, 14, 52, 52, 834, DateTimeKind.Utc).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 837, DateTimeKind.Utc).AddTicks(522), "Porro blanditiis ea voluptas non odit quia cum omnis. Quia recusandae veniam voluptates animi est est. Vel reiciendis amet doloribus doloribus id. Tempore quam ut quia quisquam. Nihil eveniet accusantium repellendus velit. Consectetur eum distinctio animi.", "G", "176 minutes", "Qui quae laboriosam.", new DateTime(2024, 2, 7, 14, 52, 52, 837, DateTimeKind.Utc).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 839, DateTimeKind.Utc).AddTicks(9548), "Excepturi vero omnis consequatur tempore molestias. Voluptatem eos quibusdam et at ex et harum. Saepe accusantium consequatur fugit impedit sequi. Deserunt qui nihil earum. Laboriosam dolorum nesciunt consequatur et corporis est dolorem earum quasi.\n\nExplicabo debitis animi excepturi quia eaque maxime placeat voluptatem. Quisquam non incidunt vitae. Architecto sed porro soluta. Quia quod sint maiores amet et quo ducimus nemo esse. Quidem aliquam reprehenderit ea quibusdam quas.", "PG", "75 minutes", "Dolore.", new DateTime(2024, 2, 7, 14, 52, 52, 839, DateTimeKind.Utc).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 842, DateTimeKind.Utc).AddTicks(2440), "Voluptate sed et magnam ea enim consequatur rerum illo quasi. Optio itaque velit omnis. Officiis reprehenderit delectus quia. Omnis enim dicta iste exercitationem consequatur distinctio inventore ea. Velit sit impedit aut voluptate sint. Consequatur eos accusantium iste magni expedita voluptatum.\n\nCumque quod nihil. Quia perspiciatis animi cumque vel voluptas exercitationem velit vero. Perferendis ut ratione eveniet velit recusandae.", "PG-13", "135 minutes", "Incidunt voluptatem.", new DateTime(2024, 2, 7, 14, 52, 52, 842, DateTimeKind.Utc).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 844, DateTimeKind.Utc).AddTicks(9365), "Molestiae et quae ipsa voluptas et velit. Numquam inventore atque debitis tempora dolores repudiandae nesciunt. Dolorem cupiditate assumenda est est odit vel quia earum. Consequatur odit totam facere impedit. A ea non non.\n\nOfficia voluptatem beatae quaerat iure corrupti et voluptatem placeat eaque. Quasi aut voluptates non expedita sit velit odit asperiores dolore. Quam nostrum hic. Et ea voluptates sequi nemo.", "146 minutes", "Voluptas.", new DateTime(2024, 2, 7, 14, 52, 52, 844, DateTimeKind.Utc).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 847, DateTimeKind.Utc).AddTicks(1487), "Aut dolor qui voluptatem autem quasi animi. Quia eum est aperiam vel distinctio molestias voluptatem. Quis rerum fuga asperiores. Facere cupiditate sit impedit.", "G", "158 minutes", "Sint quod.", new DateTime(2024, 2, 7, 14, 52, 52, 847, DateTimeKind.Utc).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 849, DateTimeKind.Utc).AddTicks(6515), "Dolorum eum qui. Nobis esse eligendi placeat maxime maiores ut. Voluptas sed voluptas.\n\nFugit aperiam aut error tempore illum harum natus ut amet. Beatae voluptatem nisi qui excepturi ut inventore consectetur qui ratione. Iure ea ipsa esse. Laboriosam atque voluptas magnam nam tenetur repudiandae excepturi aperiam. Quasi aut sunt dolor quas qui odit facilis labore.", "PG", "60 minutes", "Ea qui vero.", new DateTime(2024, 2, 7, 14, 52, 52, 849, DateTimeKind.Utc).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 851, DateTimeKind.Utc).AddTicks(7645), "At amet iste quo sit qui et iste. Facilis quia voluptatem vel sint rem fugit. Non dolores eligendi et aut odit. Perferendis sed ex corrupti ut et debitis. Et aut nesciunt ipsa sunt dicta perspiciatis laborum error corrupti. Deleniti error sunt dolorem praesentium est recusandae et.\n\nMolestiae eaque excepturi atque ut. Recusandae omnis qui sed in consequatur ab. Optio possimus cum aut inventore id labore. Blanditiis modi quam quibusdam. Odit quis provident corrupti. Aut eos id dolorem quae.", "G", "166 minutes", "Hic.", new DateTime(2024, 2, 7, 14, 52, 52, 851, DateTimeKind.Utc).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "created_at", "description", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 853, DateTimeKind.Utc).AddTicks(9609), "Dolorem magnam beatae velit placeat et modi. Impedit excepturi eum consequuntur dolor et. Amet aliquam fuga ut ut repudiandae et repudiandae delectus.", "106 minutes", "Sunt.", new DateTime(2024, 2, 7, 14, 52, 52, 853, DateTimeKind.Utc).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "movie",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "created_at", "description", "rating", "runtime", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 856, DateTimeKind.Utc).AddTicks(2807), "Distinctio ex possimus architecto exercitationem ut ad consequuntur perspiciatis et. Molestiae omnis expedita illum tempora nisi voluptatibus officiis. Nisi voluptatem nemo nemo aliquam minus est. Est facere unde inventore. Minus eum sint ea harum quis iusto.", "PG", "119 minutes", "Pariatur sit.", new DateTime(2024, 2, 7, 14, 52, 52, 856, DateTimeKind.Utc).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8153), 1, new DateTime(2024, 2, 11, 9, 52, 52, 858, DateTimeKind.Utc).AddTicks(8158), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8194), 5, 2, new DateTime(2024, 2, 9, 0, 52, 52, 858, DateTimeKind.Utc).AddTicks(8195), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8196), 1, 3, new DateTime(2024, 2, 11, 2, 52, 52, 858, DateTimeKind.Utc).AddTicks(8197), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8198), 4, new DateTime(2024, 2, 12, 5, 52, 52, 858, DateTimeKind.Utc).AddTicks(8199), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8200), 6, 1, new DateTime(2024, 2, 11, 0, 52, 52, 858, DateTimeKind.Utc).AddTicks(8200), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8203), 4, 3, new DateTime(2024, 2, 9, 2, 52, 52, 858, DateTimeKind.Utc).AddTicks(8203), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8203) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8204), 15, new DateTime(2024, 2, 12, 9, 52, 52, 858, DateTimeKind.Utc).AddTicks(8205), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8205) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8206), 7, 2, new DateTime(2024, 2, 9, 0, 52, 52, 858, DateTimeKind.Utc).AddTicks(8206), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8207), 8, 2, new DateTime(2024, 2, 13, 6, 52, 52, 858, DateTimeKind.Utc).AddTicks(8208), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8207) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8210), 10, new DateTime(2024, 2, 11, 5, 52, 52, 858, DateTimeKind.Utc).AddTicks(8210), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8211), 14, 1, new DateTime(2024, 2, 12, 0, 52, 52, 858, DateTimeKind.Utc).AddTicks(8212), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8213), 13, 4, new DateTime(2024, 2, 9, 7, 52, 52, 858, DateTimeKind.Utc).AddTicks(8214), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8213) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8216), 9, 2, new DateTime(2024, 2, 11, 4, 52, 52, 858, DateTimeKind.Utc).AddTicks(8217), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8216) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8218), 17, new DateTime(2024, 2, 9, 7, 52, 52, 858, DateTimeKind.Utc).AddTicks(8219), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8221), 1, 2, new DateTime(2024, 2, 11, 9, 52, 52, 858, DateTimeKind.Utc).AddTicks(8222), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8234), 15, 4, new DateTime(2024, 2, 14, 6, 52, 52, 858, DateTimeKind.Utc).AddTicks(8235), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8237), 17, 3, new DateTime(2024, 2, 14, 6, 52, 52, 858, DateTimeKind.Utc).AddTicks(8238), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8237) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "created_at", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8242), new DateTime(2024, 2, 12, 8, 52, 52, 858, DateTimeKind.Utc).AddTicks(8243), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "created_at", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8245), new DateTime(2024, 2, 11, 6, 52, 52, 858, DateTimeKind.Utc).AddTicks(8246), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8247), 16, new DateTime(2024, 2, 10, 0, 52, 52, 858, DateTimeKind.Utc).AddTicks(8248), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8248) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8250), 17, new DateTime(2024, 2, 13, 7, 52, 52, 858, DateTimeKind.Utc).AddTicks(8250), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8251), 14, 1, new DateTime(2024, 2, 10, 0, 52, 52, 858, DateTimeKind.Utc).AddTicks(8252), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8251) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8252), 10, 1, new DateTime(2024, 2, 10, 9, 52, 52, 858, DateTimeKind.Utc).AddTicks(8253), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8254), 20, 4, new DateTime(2024, 2, 13, 0, 52, 52, 858, DateTimeKind.Utc).AddTicks(8255), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8254) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8256), 8, 2, new DateTime(2024, 2, 10, 7, 52, 52, 858, DateTimeKind.Utc).AddTicks(8256), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8256) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8257), 6, 3, new DateTime(2024, 2, 9, 2, 52, 52, 858, DateTimeKind.Utc).AddTicks(8258), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8259), 2, new DateTime(2024, 2, 13, 7, 52, 52, 858, DateTimeKind.Utc).AddTicks(8259), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8261), 3, 3, new DateTime(2024, 2, 11, 5, 52, 52, 858, DateTimeKind.Utc).AddTicks(8261), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8262), 11, 3, new DateTime(2024, 2, 14, 3, 52, 52, 858, DateTimeKind.Utc).AddTicks(8263), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8263), 6, 3, new DateTime(2024, 2, 13, 5, 52, 52, 858, DateTimeKind.Utc).AddTicks(8264), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8278), 3, 2, new DateTime(2024, 2, 14, 7, 52, 52, 858, DateTimeKind.Utc).AddTicks(8278), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8278) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8279), 15, new DateTime(2024, 2, 12, 4, 52, 52, 858, DateTimeKind.Utc).AddTicks(8280), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8280), 7, 1, new DateTime(2024, 2, 9, 8, 52, 52, 858, DateTimeKind.Utc).AddTicks(8281), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8283), 8, 1, new DateTime(2024, 2, 10, 9, 52, 52, 858, DateTimeKind.Utc).AddTicks(8284), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8285), 18, new DateTime(2024, 2, 12, 7, 52, 52, 858, DateTimeKind.Utc).AddTicks(8285), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8286), 1, 4, new DateTime(2024, 2, 11, 9, 52, 52, 858, DateTimeKind.Utc).AddTicks(8287), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "created_at", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8288), 3, new DateTime(2024, 2, 13, 0, 52, 52, 858, DateTimeKind.Utc).AddTicks(8288), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8289), 11, new DateTime(2024, 2, 13, 9, 52, 52, 858, DateTimeKind.Utc).AddTicks(8290), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8291), 16, 3, new DateTime(2024, 2, 12, 3, 52, 52, 858, DateTimeKind.Utc).AddTicks(8291), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8308), 3, 1, new DateTime(2024, 2, 13, 8, 52, 52, 858, DateTimeKind.Utc).AddTicks(8308), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8310), 14, 4, new DateTime(2024, 2, 11, 2, 52, 52, 858, DateTimeKind.Utc).AddTicks(8310), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8311), 3, 1, new DateTime(2024, 2, 10, 7, 52, 52, 858, DateTimeKind.Utc).AddTicks(8312), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8313), 15, 3, new DateTime(2024, 2, 10, 1, 52, 52, 858, DateTimeKind.Utc).AddTicks(8313), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "created_at", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8314), new DateTime(2024, 2, 13, 1, 52, 52, 858, DateTimeKind.Utc).AddTicks(8315), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8316), 15, new DateTime(2024, 2, 13, 8, 52, 52, 858, DateTimeKind.Utc).AddTicks(8316), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8318), 10, 3, new DateTime(2024, 2, 11, 1, 52, 52, 858, DateTimeKind.Utc).AddTicks(8318), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8319), 20, 1, new DateTime(2024, 2, 11, 1, 52, 52, 858, DateTimeKind.Utc).AddTicks(8320), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8321), 4, 4, new DateTime(2024, 2, 9, 0, 52, 52, 858, DateTimeKind.Utc).AddTicks(8322), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8323), 20, 3, new DateTime(2024, 2, 9, 6, 52, 52, 858, DateTimeKind.Utc).AddTicks(8324), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8325), 16, 4, new DateTime(2024, 2, 9, 5, 52, 52, 858, DateTimeKind.Utc).AddTicks(8326), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8326), 15, new DateTime(2024, 2, 10, 3, 52, 52, 858, DateTimeKind.Utc).AddTicks(8327), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8328), 5, 4, new DateTime(2024, 2, 14, 2, 52, 52, 858, DateTimeKind.Utc).AddTicks(8328), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8329), 11, 4, new DateTime(2024, 2, 12, 2, 52, 52, 858, DateTimeKind.Utc).AddTicks(8330), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8331), 12, 2, new DateTime(2024, 2, 10, 4, 52, 52, 858, DateTimeKind.Utc).AddTicks(8331), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "created_at", "movie_id", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8332), 10, new DateTime(2024, 2, 10, 8, 52, 52, 858, DateTimeKind.Utc).AddTicks(8333), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8334), 13, 2, new DateTime(2024, 2, 11, 4, 52, 52, 858, DateTimeKind.Utc).AddTicks(8334), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8335), 17, 1, new DateTime(2024, 2, 13, 3, 52, 52, 858, DateTimeKind.Utc).AddTicks(8336), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8337), 12, 2, new DateTime(2024, 2, 13, 8, 52, 52, 858, DateTimeKind.Utc).AddTicks(8337), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8338), 20, 3, new DateTime(2024, 2, 11, 1, 52, 52, 858, DateTimeKind.Utc).AddTicks(8339), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "screening",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "created_at", "movie_id", "screenNumber", "statsAt", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8340), 13, 4, new DateTime(2024, 2, 11, 1, 52, 52, 858, DateTimeKind.Utc).AddTicks(8340), new DateTime(2024, 2, 7, 14, 52, 52, 858, DateTimeKind.Utc).AddTicks(8340) });
        }
    }
}
