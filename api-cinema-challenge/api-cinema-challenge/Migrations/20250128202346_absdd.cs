using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class absdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "customer_id",
                table: "tickets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(3390), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(3858), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(3863), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(3867), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(3872), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(3873) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 381, DateTimeKind.Utc).AddTicks(4045), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(2945), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(2956), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(2960), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(2965), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(4616), new DateTime(2025, 1, 28, 21, 23, 39, 384, DateTimeKind.Utc).AddTicks(4971), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5085), new DateTime(2025, 1, 28, 22, 23, 39, 384, DateTimeKind.Utc).AddTicks(5090), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5093), new DateTime(2025, 1, 28, 23, 23, 39, 384, DateTimeKind.Utc).AddTicks(5121), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5124), new DateTime(2025, 1, 29, 0, 23, 39, 384, DateTimeKind.Utc).AddTicks(5128), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5130), new DateTime(2025, 1, 29, 1, 23, 39, 384, DateTimeKind.Utc).AddTicks(5136), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5140), new DateTime(2025, 1, 28, 21, 23, 39, 384, DateTimeKind.Utc).AddTicks(5144), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5147), new DateTime(2025, 1, 28, 22, 23, 39, 384, DateTimeKind.Utc).AddTicks(5151), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5153), new DateTime(2025, 1, 28, 23, 23, 39, 384, DateTimeKind.Utc).AddTicks(5157), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5160), new DateTime(2025, 1, 29, 0, 23, 39, 384, DateTimeKind.Utc).AddTicks(5164), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5166), new DateTime(2025, 1, 29, 1, 23, 39, 384, DateTimeKind.Utc).AddTicks(5170), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5172), new DateTime(2025, 1, 28, 21, 23, 39, 384, DateTimeKind.Utc).AddTicks(5176), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5179), new DateTime(2025, 1, 28, 22, 23, 39, 384, DateTimeKind.Utc).AddTicks(5183), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5189), new DateTime(2025, 1, 28, 23, 23, 39, 384, DateTimeKind.Utc).AddTicks(5193), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5191) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5195), new DateTime(2025, 1, 29, 0, 23, 39, 384, DateTimeKind.Utc).AddTicks(5199), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5202), new DateTime(2025, 1, 29, 1, 23, 39, 384, DateTimeKind.Utc).AddTicks(5206), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5208), new DateTime(2025, 1, 29, 2, 23, 39, 384, DateTimeKind.Utc).AddTicks(5227), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5230), new DateTime(2025, 1, 29, 3, 23, 39, 384, DateTimeKind.Utc).AddTicks(5234), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5236), new DateTime(2025, 1, 29, 4, 23, 39, 384, DateTimeKind.Utc).AddTicks(5240), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5242), new DateTime(2025, 1, 29, 5, 23, 39, 384, DateTimeKind.Utc).AddTicks(5246), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5249), new DateTime(2025, 1, 29, 6, 23, 39, 384, DateTimeKind.Utc).AddTicks(5253), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5255), new DateTime(2025, 1, 29, 2, 23, 39, 384, DateTimeKind.Utc).AddTicks(5259), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5261), new DateTime(2025, 1, 29, 3, 23, 39, 384, DateTimeKind.Utc).AddTicks(5265), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5267), new DateTime(2025, 1, 29, 4, 23, 39, 384, DateTimeKind.Utc).AddTicks(5271), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5274), new DateTime(2025, 1, 29, 5, 23, 39, 384, DateTimeKind.Utc).AddTicks(5277), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5280), new DateTime(2025, 1, 29, 6, 23, 39, 384, DateTimeKind.Utc).AddTicks(5284), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5286), new DateTime(2025, 1, 29, 2, 23, 39, 384, DateTimeKind.Utc).AddTicks(5290), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5292), new DateTime(2025, 1, 29, 3, 23, 39, 384, DateTimeKind.Utc).AddTicks(5296), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5298), new DateTime(2025, 1, 29, 4, 23, 39, 384, DateTimeKind.Utc).AddTicks(5302), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5304), new DateTime(2025, 1, 29, 5, 23, 39, 384, DateTimeKind.Utc).AddTicks(5308), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5311), new DateTime(2025, 1, 29, 6, 23, 39, 384, DateTimeKind.Utc).AddTicks(5317), new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(6745), 0, new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(7010), 0, new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(7012) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(7015), 0, new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(7019), 0, new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(7024), 0, new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(7028), 0, new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(7030) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "customer_id",
                table: "tickets");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1401), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1725), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1730), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1734), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1738), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1739) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 805, DateTimeKind.Utc).AddTicks(8696), new DateTime(2025, 1, 28, 17, 29, 51, 807, DateTimeKind.Utc).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1029), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1039), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1058), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1063), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2366), new DateTime(2025, 1, 28, 18, 29, 51, 808, DateTimeKind.Utc).AddTicks(2668), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2369) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2767), new DateTime(2025, 1, 28, 19, 29, 51, 808, DateTimeKind.Utc).AddTicks(2772), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2774), new DateTime(2025, 1, 28, 20, 29, 51, 808, DateTimeKind.Utc).AddTicks(2777), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2779), new DateTime(2025, 1, 28, 21, 29, 51, 808, DateTimeKind.Utc).AddTicks(2783), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2785), new DateTime(2025, 1, 28, 22, 29, 51, 808, DateTimeKind.Utc).AddTicks(2789), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2791), new DateTime(2025, 1, 28, 18, 29, 51, 808, DateTimeKind.Utc).AddTicks(2794), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2796), new DateTime(2025, 1, 28, 19, 29, 51, 808, DateTimeKind.Utc).AddTicks(2800), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2798) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2802), new DateTime(2025, 1, 28, 20, 29, 51, 808, DateTimeKind.Utc).AddTicks(2805), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2807), new DateTime(2025, 1, 28, 21, 29, 51, 808, DateTimeKind.Utc).AddTicks(2831), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2833), new DateTime(2025, 1, 28, 22, 29, 51, 808, DateTimeKind.Utc).AddTicks(2837), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2839), new DateTime(2025, 1, 28, 18, 29, 51, 808, DateTimeKind.Utc).AddTicks(2842), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2844), new DateTime(2025, 1, 28, 19, 29, 51, 808, DateTimeKind.Utc).AddTicks(2848), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2850), new DateTime(2025, 1, 28, 20, 29, 51, 808, DateTimeKind.Utc).AddTicks(2853), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2851) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2855), new DateTime(2025, 1, 28, 21, 29, 51, 808, DateTimeKind.Utc).AddTicks(2859), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2861), new DateTime(2025, 1, 28, 22, 29, 51, 808, DateTimeKind.Utc).AddTicks(2864), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2862) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2866), new DateTime(2025, 1, 28, 23, 29, 51, 808, DateTimeKind.Utc).AddTicks(2869), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2871), new DateTime(2025, 1, 29, 0, 29, 51, 808, DateTimeKind.Utc).AddTicks(2875), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2877), new DateTime(2025, 1, 29, 1, 29, 51, 808, DateTimeKind.Utc).AddTicks(2880), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2882), new DateTime(2025, 1, 29, 2, 29, 51, 808, DateTimeKind.Utc).AddTicks(2886), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2888), new DateTime(2025, 1, 29, 3, 29, 51, 808, DateTimeKind.Utc).AddTicks(2891), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2905), new DateTime(2025, 1, 28, 23, 29, 51, 808, DateTimeKind.Utc).AddTicks(2908), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2911), new DateTime(2025, 1, 29, 0, 29, 51, 808, DateTimeKind.Utc).AddTicks(2916), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2918), new DateTime(2025, 1, 29, 1, 29, 51, 808, DateTimeKind.Utc).AddTicks(2922), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2923), new DateTime(2025, 1, 29, 2, 29, 51, 808, DateTimeKind.Utc).AddTicks(2927), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2929), new DateTime(2025, 1, 29, 3, 29, 51, 808, DateTimeKind.Utc).AddTicks(2932), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2934), new DateTime(2025, 1, 28, 23, 29, 51, 808, DateTimeKind.Utc).AddTicks(2937), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2939), new DateTime(2025, 1, 29, 0, 29, 51, 808, DateTimeKind.Utc).AddTicks(2943), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2945), new DateTime(2025, 1, 29, 1, 29, 51, 808, DateTimeKind.Utc).AddTicks(2948), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2950), new DateTime(2025, 1, 29, 2, 29, 51, 808, DateTimeKind.Utc).AddTicks(2953), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2955), new DateTime(2025, 1, 29, 3, 29, 51, 808, DateTimeKind.Utc).AddTicks(2959), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(2957) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4030), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4254), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4258), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4262), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4266), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4269), new DateTime(2025, 1, 28, 17, 29, 51, 808, DateTimeKind.Utc).AddTicks(4271) });
        }
    }
}
