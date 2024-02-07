using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class movieContainScreenings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 362);

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 1,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1954, 2, 6, 9, 50, 1, 0, DateTimeKind.Utc), "Allen Greyrat", "Allen.Greyrat@gov.gr", "+474 825189659", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 2,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1909, 5, 21, 16, 41, 11, 0, DateTimeKind.Utc), "Jim Miller", "Jim.Miller@nasa.org.us", "+500 2120216472", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 3,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1981, 10, 17, 6, 54, 13, 0, DateTimeKind.Utc), "Jacob Baker", "Jacob.Baker@tesla.com", "+689 1120628204", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 4,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1998, 8, 23, 23, 22, 0, 0, DateTimeKind.Utc), "Cid Greyrat", "Cid.Greyrat@gov.gr", "+589 2043443646", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 5,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1962, 5, 19, 22, 44, 7, 0, DateTimeKind.Utc), "Will Smith", "Will.Smith@gov.ru", "+532 85856835", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 6,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1899, 4, 19, 2, 42, 31, 0, DateTimeKind.Utc), "Will Garcia", "Will.Garcia@something.com", "+172 458786237", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 7,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2024, 7, 28, 21, 44, 45, 0, DateTimeKind.Utc), "Will Smith", "Will.Smith@gov.nl", "+637 227726758", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 8,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1985, 10, 19, 23, 30, 51, 0, DateTimeKind.Utc), "Elisabeth Martinez", "Elisabeth.Martinez@gov.nl", "+714 1306303537", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 9,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2012, 5, 26, 3, 54, 54, 0, DateTimeKind.Utc), "Alice Johnson", "Alice.Johnson@gov.us", "+65 1184487161", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 10,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2006, 8, 22, 20, 13, 59, 0, DateTimeKind.Utc), "Elisabeth Smith", "Elisabeth.Smith@something.com", "+777 1700090802", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 11,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2001, 5, 5, 11, 37, 34, 0, DateTimeKind.Utc), "Ellen Miller", "Ellen.Miller@google.com", "+238 453580672", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 12,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1919, 9, 22, 15, 56, 46, 0, DateTimeKind.Utc), "Robert Garcia", "Robert.Garcia@gov.ru", "+59 2082752533", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(618) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 13,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1942, 9, 23, 21, 37, 12, 0, DateTimeKind.Utc), "Robert Miller", "Robert.Miller@bbc.co.uk", "+865 1187759090", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 14,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2003, 11, 10, 9, 10, 7, 0, DateTimeKind.Utc), "Kate Kagenou", "Kate.Kagenou@bbc.co.uk", "+563 986311662", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 15,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1983, 2, 17, 16, 42, 12, 0, DateTimeKind.Utc), "Ellen Garcia", "Ellen.Garcia@nasa.org.us", "+61 1781211749", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 16,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1988, 4, 10, 4, 28, 29, 0, DateTimeKind.Utc), "Bobby Brown", "Bobby.Brown@something.com", "+611 603754498", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 17,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1950, 4, 23, 0, 40, 48, 0, DateTimeKind.Utc), "William Martinez", "William.Martinez@gov.ru", "+456 1306556471", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 18,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1944, 5, 20, 15, 55, 50, 0, DateTimeKind.Utc), "Kate Williams", "Kate.Williams@something.com", "+576 1615970559", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 19,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1999, 1, 10, 16, 32, 33, 0, DateTimeKind.Utc), "Audrey Brown", "Audrey.Brown@something.com", "+89 1267029840", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 20,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1966, 11, 16, 19, 23, 17, 0, DateTimeKind.Utc), "Allen Williams", "Allen.Williams@tesla.com", "+316 1098763816", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 21,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1966, 3, 15, 23, 28, 4, 0, DateTimeKind.Utc), "Audrey Rodriguez", "Audrey.Rodriguez@gov.us", "+37 290530446", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(729) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 22,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1962, 5, 1, 11, 6, 2, 0, DateTimeKind.Utc), "Sara Williams", "Sara.Williams@gov.ru", "+557 382042604", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 23,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1978, 8, 23, 19, 5, 10, 0, DateTimeKind.Utc), "Allen Rodriguez", "Allen.Rodriguez@bbc.co.uk", "+844 1333058656", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(752) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 24,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2002, 3, 24, 22, 5, 45, 0, DateTimeKind.Utc), "Elisabeth Miller", "Elisabeth.Miller@nasa.org.us", "+881 123692562", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 25,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2018, 2, 16, 11, 12, 43, 0, DateTimeKind.Utc), "Robert Johnson", "Robert.Johnson@bbc.co.uk", "+796 429470211", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(777) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 26,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1987, 6, 17, 18, 10, 24, 0, DateTimeKind.Utc), "Alice Brown", "Alice.Brown@gov.ru", "+817 498089027", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 27,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1912, 3, 7, 16, 1, 45, 0, DateTimeKind.Utc), "Elisabeth Rodriguez", "Elisabeth.Rodriguez@bbc.co.uk", "+45 789847796", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 28,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1992, 4, 16, 5, 7, 33, 0, DateTimeKind.Utc), "Bob Kagenou", "Bob.Kagenou@something.com", "+188 237586229", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 29,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1949, 9, 25, 15, 56, 14, 0, DateTimeKind.Utc), "Timothy Garcia", "Timothy.Garcia@google.com", "+528 1163049180", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(829) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 30,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2020, 5, 5, 12, 55, 46, 0, DateTimeKind.Utc), "Alice Miller", "Alice.Miller@google.com", "+216 1539904221", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 31,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2001, 10, 19, 8, 51, 19, 0, DateTimeKind.Utc), "Robert Brown", "Robert.Brown@something.com", "+469 2116806052", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 32,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1944, 6, 10, 15, 56, 33, 0, DateTimeKind.Utc), "Allen Greyrat", "Allen.Greyrat@nasa.org.us", "+311 1234802453", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 33,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1937, 7, 20, 9, 6, 30, 0, DateTimeKind.Utc), "Maria Jones", "Maria.Jones@theworld.ca", "+318 75255455", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(879) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 34,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1980, 7, 7, 11, 30, 39, 0, DateTimeKind.Utc), "Elisabeth Kagenou", "Elisabeth.Kagenou@theworld.ca", "+531 227260101", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(978) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 35,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1934, 11, 24, 13, 20, 38, 0, DateTimeKind.Utc), "Allen Baker", "Allen.Baker@gov.gr", "+713 1532380192", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 36,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2022, 3, 12, 17, 25, 18, 0, DateTimeKind.Utc), "Rudeus Smith", "Rudeus.Smith@gov.us", "+190 1829195893", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1004) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 37,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1985, 5, 1, 8, 16, 45, 0, DateTimeKind.Utc), "Alice Brown", "Alice.Brown@gov.nl", "+239 2131455025", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 38,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1968, 2, 21, 2, 57, 36, 0, DateTimeKind.Utc), "Elisabeth Brown", "Elisabeth.Brown@nasa.org.us", "+917 1046286697", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 39,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1955, 4, 17, 21, 48, 58, 0, DateTimeKind.Utc), "Robert Rodriguez", "Robert.Rodriguez@gov.nl", "+536 872244567", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 40,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1943, 2, 1, 8, 4, 51, 0, DateTimeKind.Utc), "Bob Greyrat", "Bob.Greyrat@gov.nl", "+729 1889246847", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 41,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1956, 5, 7, 8, 5, 56, 0, DateTimeKind.Utc), "William Brown", "William.Brown@gov.gr", "+803 799361286", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 42,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1972, 11, 20, 16, 17, 26, 0, DateTimeKind.Utc), "William Jones", "William.Jones@bbc.co.uk", "+526 1093142648", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 43,
                columns: new[] { "created_at", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1933, 7, 10, 23, 49, 36, 0, DateTimeKind.Utc), "Robert.Jones@gov.us", "+800 1067300679", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 44,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1963, 3, 5, 17, 0, 31, 0, DateTimeKind.Utc), "Sara Davis", "Sara.Davis@gov.us", "+338 237976244", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 45,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1933, 5, 17, 14, 34, 56, 0, DateTimeKind.Utc), "Cid Martinez", "Cid.Martinez@gov.us", "+534 386898088", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 46,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2009, 7, 6, 11, 52, 30, 0, DateTimeKind.Utc), "Alice Davis", "Alice.Davis@something.com", "+533 705641498", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 47,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1976, 6, 23, 0, 28, 9, 0, DateTimeKind.Utc), "Audrey Johnson", "Audrey.Johnson@gov.nl", "+697 1089253505", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 48,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1942, 3, 8, 11, 6, 48, 0, DateTimeKind.Utc), "William Baker", "William.Baker@google.com", "+409 258745880", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 49,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1946, 9, 17, 19, 6, 33, 0, DateTimeKind.Utc), "Bob Garcia", "Bob.Garcia@gov.gr", "+858 803488105", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 50,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2000, 9, 21, 21, 0, 5, 0, DateTimeKind.Utc), "Will Jones", "Will.Jones@gov.ru", "+298 730031045", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 51,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1957, 2, 11, 7, 34, 53, 0, DateTimeKind.Utc), "Bob Martinez", "Bob.Martinez@google.com", "+774 134804828", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 52,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1985, 3, 27, 3, 1, 21, 0, DateTimeKind.Utc), "Will Garcia", "Will.Garcia@gov.gr", "+266 489133803", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1207) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 53,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1912, 7, 28, 2, 15, 18, 0, DateTimeKind.Utc), "Bob Smith", "Bob.Smith@tesla.com", "+455 2077522680", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1221) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 54,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1958, 8, 19, 1, 26, 40, 0, DateTimeKind.Utc), "Rudeus Greyrat", "Rudeus.Greyrat@nasa.org.us", "+738 1050069321", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 55,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2004, 7, 17, 10, 35, 53, 0, DateTimeKind.Utc), "Elisabeth Jones", "Elisabeth.Jones@gov.gr", "+199 113914259", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 56,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1962, 10, 14, 10, 28, 52, 0, DateTimeKind.Utc), "Robert Martinez", "Robert.Martinez@bbc.co.uk", "+570 1307670351", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 57,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1944, 4, 21, 7, 35, 43, 0, DateTimeKind.Utc), "Bob Kagenou", "Bob.Kagenou@gov.nl", "+627 1025254057", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1271) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 58,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1958, 5, 8, 8, 45, 34, 0, DateTimeKind.Utc), "Will Smith", "Will.Smith@something.com", "+376 1219106121", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 59,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1960, 2, 18, 7, 37, 19, 0, DateTimeKind.Utc), "Jacob Greyrat", "Jacob.Greyrat@gov.us", "+45 18307117", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 60,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1918, 10, 12, 18, 33, 17, 0, DateTimeKind.Utc), "Maria Garcia", "Maria.Garcia@bbc.co.uk", "+206 648275501", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 61,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1952, 2, 12, 11, 29, 28, 0, DateTimeKind.Utc), "Rob Brown", "Rob.Brown@bbc.co.uk", "+390 742846950", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 62,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2022, 3, 12, 7, 21, 0, 0, DateTimeKind.Utc), "Audrey Williams", "Audrey.Williams@theworld.ca", "+774 1714928039", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 63,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1965, 2, 25, 9, 23, 53, 0, DateTimeKind.Utc), "Sara Williams", "Sara.Williams@something.com", "+692 225024761", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 64,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2004, 3, 23, 9, 58, 32, 0, DateTimeKind.Utc), "Rudeus Smith", "Rudeus.Smith@gov.nl", "+872 1130569329", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1417) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 65,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1934, 3, 18, 15, 56, 41, 0, DateTimeKind.Utc), "Audrey Martinez", "Audrey.Martinez@theworld.ca", "+413 908613277", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 66,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1905, 8, 1, 2, 58, 41, 0, DateTimeKind.Utc), "Bob Greyrat", "Bob.Greyrat@tesla.com", "+484 566439253", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 67,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1977, 7, 7, 11, 28, 19, 0, DateTimeKind.Utc), "Will Martinez", "Will.Martinez@bbc.co.uk", "+594 1947226011", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 68,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2010, 8, 23, 9, 4, 21, 0, DateTimeKind.Utc), "William Kagenou", "William.Kagenou@gov.us", "+563 951797717", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1466) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 69,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1910, 1, 9, 11, 20, 24, 0, DateTimeKind.Utc), "Timothy Jones", "Timothy.Jones@google.com", "+512 1836417593", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 70,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1967, 5, 26, 16, 49, 18, 0, DateTimeKind.Utc), "Maria Williams", "Maria.Williams@gov.us", "+450 210732957", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1491) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 71,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1922, 11, 12, 15, 25, 19, 0, DateTimeKind.Utc), "William Johnson", "William.Johnson@something.com", "+592 332706848", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 72,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1988, 3, 27, 2, 23, 54, 0, DateTimeKind.Utc), "Robert Williams", "Robert.Williams@gov.us", "+09 1787350828", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 73,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2018, 10, 25, 20, 57, 23, 0, DateTimeKind.Utc), "Bobby Rodriguez", "Bobby.Rodriguez@gov.nl", "+983 1479748132", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 74,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1985, 6, 26, 22, 16, 16, 0, DateTimeKind.Utc), "Allen Brown", "Allen.Brown@gov.gr", "+382 799621538", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 75,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1942, 2, 24, 2, 21, 28, 0, DateTimeKind.Utc), "Will Davis", "Will.Davis@gov.ru", "+790 783758099", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 76,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2022, 2, 28, 9, 7, 47, 0, DateTimeKind.Utc), "Rudeus Baker", "Rudeus.Baker@gov.us", "+628 2106782311", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 77,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1902, 1, 23, 7, 33, 25, 0, DateTimeKind.Utc), "Alice Baker", "Alice.Baker@google.com", "+907 181728910", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 78,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1922, 2, 26, 4, 30, 17, 0, DateTimeKind.Utc), "Jim Johnson", "Jim.Johnson@bbc.co.uk", "+840 920694557", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 79,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1909, 7, 9, 23, 18, 9, 0, DateTimeKind.Utc), "Ellen Miller", "Ellen.Miller@gov.us", "+926 2002989242", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 80,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1924, 7, 21, 22, 58, 46, 0, DateTimeKind.Utc), "Alice Williams", "Alice.Williams@theworld.ca", "+174 81603040", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 81,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1970, 10, 6, 20, 24, 18, 0, DateTimeKind.Utc), "William Williams", "William.Williams@theworld.ca", "+593 2113318909", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 82,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1994, 3, 9, 4, 26, 58, 0, DateTimeKind.Utc), "Maria Brown", "Maria.Brown@tesla.com", "+163 1908719049", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 83,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1917, 1, 12, 4, 8, 24, 0, DateTimeKind.Utc), "Allen Brown", "Allen.Brown@bbc.co.uk", "+925 1265522742", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 84,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1911, 7, 15, 14, 54, 56, 0, DateTimeKind.Utc), "Bob Greyrat", "Bob.Greyrat@nasa.org.us", "+425 1559111472", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 85,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2004, 7, 20, 10, 14, 26, 0, DateTimeKind.Utc), "Allen Smith", "Allen.Smith@google.com", "+694 1390258532", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 86,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1929, 5, 4, 2, 17, 7, 0, DateTimeKind.Utc), "Rob Rodriguez", "Rob.Rodriguez@google.com", "+749 746396979", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1685) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 87,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1997, 5, 15, 19, 8, 1, 0, DateTimeKind.Utc), "Elisabeth Johnson", "Elisabeth.Johnson@bbc.co.uk", "+753 1515662569", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 88,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1904, 11, 16, 6, 4, 21, 0, DateTimeKind.Utc), "Will Williams", "Will.Williams@google.com", "+30 1059567469", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 89,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1982, 4, 28, 14, 31, 7, 0, DateTimeKind.Utc), "Alice Davis", "Alice.Davis@gov.ru", "+912 2097973178", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 90,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1982, 10, 23, 0, 22, 10, 0, DateTimeKind.Utc), "Timothy Kagenou", "Timothy.Kagenou@nasa.org.us", "+204 268517298", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 91,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1991, 1, 10, 18, 7, 33, 0, DateTimeKind.Utc), "Elisabeth Smith", "Elisabeth.Smith@gov.nl", "+616 1101922667", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1793) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 92,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1990, 9, 15, 20, 12, 43, 0, DateTimeKind.Utc), "Will Baker", "Will.Baker@nasa.org.us", "+86 903326350", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1807) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 93,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1964, 6, 18, 18, 6, 15, 0, DateTimeKind.Utc), "Maria Baker", "Maria.Baker@something.com", "+817 1198184551", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 94,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1964, 2, 6, 23, 50, 29, 0, DateTimeKind.Utc), "Rudeus Martinez", "Rudeus.Martinez@tesla.com", "+101 1597403631", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 95,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2005, 1, 15, 20, 20, 22, 0, DateTimeKind.Utc), "Elisabeth Miller", "Elisabeth.Miller@gov.gr", "+280 754079888", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 96,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1974, 4, 7, 18, 25, 41, 0, DateTimeKind.Utc), "Cid Miller", "Cid.Miller@something.com", "+409 31374099", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 97,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1951, 7, 13, 5, 21, 21, 0, DateTimeKind.Utc), "Kate Jones", "Kate.Jones@gov.gr", "+218 1476963104", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 98,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1904, 10, 27, 18, 54, 10, 0, DateTimeKind.Utc), "Rob Brown", "Rob.Brown@google.com", "+144 1423509118", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 99,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1963, 11, 18, 23, 52, 4, 0, DateTimeKind.Utc), "Alice Rodriguez", "Alice.Rodriguez@google.com", "+230 1686635946", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 100,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1910, 2, 7, 16, 24, 12, 0, DateTimeKind.Utc), "Cid Kagenou", "Cid.Kagenou@google.com", "+895 1667191068", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 101,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1994, 3, 20, 13, 15, 28, 0, DateTimeKind.Utc), "Jacob Smith", "Jacob.Smith@gov.ru", "+103 1377905049", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 102,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1931, 8, 8, 18, 19, 13, 0, DateTimeKind.Utc), "Rudeus Davis", "Rudeus.Davis@something.com", "+251 971858881", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1932) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 103,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1984, 4, 14, 12, 19, 29, 0, DateTimeKind.Utc), "Timothy Williams", "Timothy.Williams@bbc.co.uk", "+977 505812876", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1944) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 104,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1923, 5, 17, 4, 13, 32, 0, DateTimeKind.Utc), "Cid Greyrat", "Cid.Greyrat@gov.gr", "+112 1385441494", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 105,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1912, 7, 7, 6, 47, 10, 0, DateTimeKind.Utc), "Ellen Baker", "Ellen.Baker@nasa.org.us", "+566 1805452301", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 106,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1952, 1, 14, 9, 59, 53, 0, DateTimeKind.Utc), "Rob Baker", "Rob.Baker@nasa.org.us", "+703 668429392", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 107,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1940, 6, 7, 5, 33, 31, 0, DateTimeKind.Utc), "Jacob Johnson", "Jacob.Johnson@something.com", "+19 1731261053", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 108,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1916, 1, 17, 6, 29, 58, 0, DateTimeKind.Utc), "Rudeus Miller", "Rudeus.Miller@gov.ru", "+892 1741441526", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 109,
                columns: new[] { "created_at", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1990, 3, 7, 6, 34, 9, 0, DateTimeKind.Utc), "Maria.Smith@gov.us", "+111 2037898696", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2012) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 110,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1936, 4, 6, 5, 28, 52, 0, DateTimeKind.Utc), "Jacob Williams", "Jacob.Williams@something.com", "+635 715391910", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 111,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1929, 2, 21, 7, 32, 30, 0, DateTimeKind.Utc), "William Garcia", "William.Garcia@bbc.co.uk", "+508 1839973544", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 112,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1922, 7, 23, 7, 59, 5, 0, DateTimeKind.Utc), "Rudeus Kagenou", "Rudeus.Kagenou@gov.gr", "+830 1185413719", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 113,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1981, 2, 4, 6, 47, 58, 0, DateTimeKind.Utc), "Ellen Miller", "Ellen.Miller@gov.ru", "+203 1649929161", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 114,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1991, 1, 9, 10, 58, 17, 0, DateTimeKind.Utc), "Ellen Garcia", "Ellen.Garcia@google.com", "+814 1768085676", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 115,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2002, 2, 17, 14, 29, 9, 0, DateTimeKind.Utc), "Jacob Davis", "Jacob.Davis@tesla.com", "+929 881869955", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 116,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1918, 2, 9, 11, 13, 7, 0, DateTimeKind.Utc), "Robert Martinez", "Robert.Martinez@theworld.ca", "+667 623214539", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 117,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1975, 8, 3, 8, 22, 26, 0, DateTimeKind.Utc), "Jim Garcia", "Jim.Garcia@nasa.org.us", "+773 430955703", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 118,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1928, 8, 18, 11, 30, 52, 0, DateTimeKind.Utc), "Cid Kagenou", "Cid.Kagenou@gov.ru", "+08 558070961", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 119,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1982, 2, 15, 0, 55, 17, 0, DateTimeKind.Utc), "Audrey Miller", "Audrey.Miller@nasa.org.us", "+336 214006771", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 120,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1976, 4, 26, 11, 41, 48, 0, DateTimeKind.Utc), "Kate Martinez", "Kate.Martinez@gov.ru", "+791 1738523239", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 121,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2021, 11, 24, 14, 8, 51, 0, DateTimeKind.Utc), "Cid Johnson", "Cid.Johnson@gov.nl", "+800 1749604376", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 122,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1936, 9, 9, 11, 32, 48, 0, DateTimeKind.Utc), "Timothy Davis", "Timothy.Davis@bbc.co.uk", "+910 1692451718", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 123,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1937, 3, 17, 21, 56, 50, 0, DateTimeKind.Utc), "Bob Johnson", "Bob.Johnson@gov.us", "+704 1403833387", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 124,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1936, 9, 15, 7, 59, 29, 0, DateTimeKind.Utc), "Maria Miller", "Maria.Miller@gov.us", "+547 661651744", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 125,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1962, 6, 8, 5, 33, 1, 0, DateTimeKind.Utc), "Maria Rodriguez", "Maria.Rodriguez@theworld.ca", "+419 997563291", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 126,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1958, 7, 28, 19, 57, 6, 0, DateTimeKind.Utc), "Audrey Williams", "Audrey.Williams@nasa.org.us", "+123 1382457909", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 127,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1954, 11, 25, 23, 42, 41, 0, DateTimeKind.Utc), "Will Martinez", "Will.Martinez@gov.nl", "+983 26680730", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 128,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1941, 8, 21, 17, 37, 41, 0, DateTimeKind.Utc), "Jim Davis", "Jim.Davis@gov.ru", "+666 847882955", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 129,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1939, 11, 11, 4, 51, 57, 0, DateTimeKind.Utc), "Timothy Smith", "Timothy.Smith@something.com", "+347 464436286", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 130,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1984, 4, 25, 2, 19, 11, 0, DateTimeKind.Utc), "Audrey Smith", "Audrey.Smith@nasa.org.us", "+927 1945198624", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 131,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1999, 5, 8, 14, 34, 38, 0, DateTimeKind.Utc), "Ellen Smith", "Ellen.Smith@theworld.ca", "+278 626711383", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 132,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2016, 2, 26, 18, 56, 8, 0, DateTimeKind.Utc), "Jacob Rodriguez", "Jacob.Rodriguez@google.com", "+20 1160609018", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 133,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2024, 6, 5, 18, 49, 6, 0, DateTimeKind.Utc), "Kate Jones", "Kate.Jones@tesla.com", "+832 389349786", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 134,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1923, 11, 4, 1, 6, 44, 0, DateTimeKind.Utc), "Rudeus Baker", "Rudeus.Baker@something.com", "+176 1977210655", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 135,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1983, 8, 21, 2, 48, 23, 0, DateTimeKind.Utc), "William Baker", "William.Baker@theworld.ca", "+456 1095205665", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 136,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1940, 10, 3, 7, 33, 16, 0, DateTimeKind.Utc), "Bobby Martinez", "Bobby.Martinez@tesla.com", "+630 234972760", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2391) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 137,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1961, 1, 19, 15, 54, 55, 0, DateTimeKind.Utc), "Kate Smith", "Kate.Smith@theworld.ca", "+889 1244450292", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 138,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1939, 5, 22, 21, 22, 17, 0, DateTimeKind.Utc), "Audrey Garcia", "Audrey.Garcia@tesla.com", "+415 450282058", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 139,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2010, 9, 3, 20, 8, 20, 0, DateTimeKind.Utc), "William Garcia", "William.Garcia@nasa.org.us", "+208 1762938718", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2425) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 140,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1976, 9, 10, 15, 8, 38, 0, DateTimeKind.Utc), "Bobby Baker", "Bobby.Baker@theworld.ca", "+813 480354982", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 141,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1960, 9, 19, 12, 49, 51, 0, DateTimeKind.Utc), "Jacob Davis", "Jacob.Davis@gov.us", "+73 796812875", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 142,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1944, 6, 19, 21, 32, 4, 0, DateTimeKind.Utc), "William Davis", "William.Davis@gov.nl", "+44 707938456", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 143,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1898, 6, 2, 22, 0, 27, 0, DateTimeKind.Utc), "Allen Brown", "Allen.Brown@nasa.org.us", "+473 1460690243", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 144,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1909, 6, 1, 21, 12, 9, 0, DateTimeKind.Utc), "Jim Smith", "Jim.Smith@something.com", "+875 683819604", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 145,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1907, 1, 8, 10, 49, 28, 0, DateTimeKind.Utc), "Will Miller", "Will.Miller@something.com", "+407 1868736326", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 146,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1975, 5, 17, 6, 21, 16, 0, DateTimeKind.Utc), "Jacob Williams", "Jacob.Williams@something.com", "+00 859644623", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 147,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1951, 1, 20, 12, 1, 36, 0, DateTimeKind.Utc), "Elisabeth Jones", "Elisabeth.Jones@nasa.org.us", "+459 101958714", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 148,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1921, 4, 20, 14, 1, 10, 0, DateTimeKind.Utc), "Robert Williams", "Robert.Williams@tesla.com", "+773 1682503130", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 149,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1919, 6, 18, 9, 32, 28, 0, DateTimeKind.Utc), "Rudeus Williams", "Rudeus.Williams@something.com", "+26 211958418", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 150,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1963, 9, 21, 12, 56, 12, 0, DateTimeKind.Utc), "Jim Rodriguez", "Jim.Rodriguez@tesla.com", "+801 2138904560", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 151,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2023, 4, 7, 11, 22, 26, 0, DateTimeKind.Utc), "Jim Jones", "Jim.Jones@google.com", "+959 947610342", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 152,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1911, 9, 13, 21, 42, 50, 0, DateTimeKind.Utc), "Robert Smith", "Robert.Smith@bbc.co.uk", "+839 69885622", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 153,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1975, 4, 18, 11, 17, 17, 0, DateTimeKind.Utc), "Cid Miller", "Cid.Miller@something.com", "+442 173464017", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2638) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 154,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1946, 7, 26, 3, 53, 57, 0, DateTimeKind.Utc), "Jacob Davis", "Jacob.Davis@gov.nl", "+290 1397156332", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 155,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1931, 6, 20, 1, 17, 41, 0, DateTimeKind.Utc), "Robert Johnson", "Robert.Johnson@theworld.ca", "+194 1404738226", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 156,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1942, 9, 3, 15, 2, 48, 0, DateTimeKind.Utc), "Jacob Davis", "Jacob.Davis@google.com", "+136 359334806", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2672) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 157,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2002, 7, 5, 14, 57, 25, 0, DateTimeKind.Utc), "Audrey Kagenou", "Audrey.Kagenou@gov.gr", "+488 894717647", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 158,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1983, 11, 16, 15, 28, 49, 0, DateTimeKind.Utc), "William Jones", "William.Jones@something.com", "+832 1605880426", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 159,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1968, 2, 10, 20, 18, 23, 0, DateTimeKind.Utc), "Elisabeth Davis", "Elisabeth.Davis@theworld.ca", "+900 702895030", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 160,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1979, 3, 19, 5, 7, 29, 0, DateTimeKind.Utc), "Kate Williams", "Kate.Williams@gov.nl", "+155 1903725159", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 161,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1955, 4, 23, 9, 10, 9, 0, DateTimeKind.Utc), "Sara Martinez", "Sara.Martinez@gov.us", "+901 657557662", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 162,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2020, 1, 3, 13, 16, 39, 0, DateTimeKind.Utc), "Jim Greyrat", "Jim.Greyrat@nasa.org.us", "+434 1861784708", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 163,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1984, 8, 8, 21, 56, 41, 0, DateTimeKind.Utc), "Bobby Greyrat", "Bobby.Greyrat@gov.us", "+15 143737361", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 164,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1994, 2, 10, 0, 36, 31, 0, DateTimeKind.Utc), "Jacob Rodriguez", "Jacob.Rodriguez@nasa.org.us", "+615 275958707", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 165,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1989, 9, 19, 15, 9, 19, 0, DateTimeKind.Utc), "Bobby Davis", "Bobby.Davis@gov.nl", "+625 342423767", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 166,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1954, 11, 26, 22, 11, 44, 0, DateTimeKind.Utc), "Jim Martinez", "Jim.Martinez@gov.gr", "+949 1212800901", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 167,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2017, 5, 6, 17, 15, 19, 0, DateTimeKind.Utc), "Rob Johnson", "Rob.Johnson@gov.nl", "+140 714669585", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 168,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2018, 9, 2, 0, 44, 13, 0, DateTimeKind.Utc), "Maria Johnson", "Maria.Johnson@bbc.co.uk", "+88 1659484169", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 169,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1932, 3, 19, 17, 33, 0, 0, DateTimeKind.Utc), "Alice Kagenou", "Alice.Kagenou@something.com", "+134 1888787365", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 170,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1951, 5, 4, 10, 51, 37, 0, DateTimeKind.Utc), "Jacob Jones", "Jacob.Jones@theworld.ca", "+96 1213469891", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 171,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1968, 7, 1, 2, 23, 19, 0, DateTimeKind.Utc), "Will Baker", "Will.Baker@gov.us", "+681 1472164551", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 172,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1962, 9, 13, 12, 58, 35, 0, DateTimeKind.Utc), "Allen Smith", "Allen.Smith@theworld.ca", "+384 638274877", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 173,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1909, 10, 14, 0, 47, 0, 0, DateTimeKind.Utc), "Alice Williams", "Alice.Williams@gov.ru", "+733 311309406", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 174,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1908, 4, 19, 2, 48, 3, 0, DateTimeKind.Utc), "Cid Brown", "Cid.Brown@gov.ru", "+302 123205656", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 175,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1999, 3, 23, 23, 12, 33, 0, DateTimeKind.Utc), "Jacob Davis", "Jacob.Davis@theworld.ca", "+722 619386588", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 176,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1992, 2, 22, 19, 45, 23, 0, DateTimeKind.Utc), "Cid Davis", "Cid.Davis@nasa.org.us", "+70 1559542050", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 177,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1937, 6, 10, 5, 2, 42, 0, DateTimeKind.Utc), "Rudeus Smith", "Rudeus.Smith@bbc.co.uk", "+811 1222065128", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 178,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1962, 6, 5, 12, 34, 11, 0, DateTimeKind.Utc), "Rob Jones", "Rob.Jones@nasa.org.us", "+748 780955582", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 179,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1933, 3, 12, 10, 4, 58, 0, DateTimeKind.Utc), "Sara Smith", "Sara.Smith@theworld.ca", "+49 1896606544", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 180,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1920, 7, 22, 3, 52, 31, 0, DateTimeKind.Utc), "Ellen Davis", "Ellen.Davis@gov.us", "+659 78155219", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 181,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1985, 3, 8, 18, 34, 42, 0, DateTimeKind.Utc), "Will Jones", "Will.Jones@something.com", "+705 944265949", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 182,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1919, 8, 24, 15, 22, 38, 0, DateTimeKind.Utc), "Elisabeth Smith", "Elisabeth.Smith@gov.us", "+202 1699350738", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 183,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1915, 3, 14, 9, 6, 29, 0, DateTimeKind.Utc), "Alice Davis", "Alice.Davis@tesla.com", "+643 1624231881", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 184,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1998, 11, 12, 21, 29, 58, 0, DateTimeKind.Utc), "Allen Miller", "Allen.Miller@google.com", "+997 1912877499", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 185,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1960, 1, 28, 8, 32, 1, 0, DateTimeKind.Utc), "William Brown", "William.Brown@tesla.com", "+642 1885467860", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 186,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2000, 8, 21, 9, 20, 20, 0, DateTimeKind.Utc), "Jacob Williams", "Jacob.Williams@bbc.co.uk", "+335 1180800562", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 187,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1966, 7, 5, 0, 14, 28, 0, DateTimeKind.Utc), "William Brown", "William.Brown@gov.gr", "+959 90111747", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 188,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1943, 6, 5, 7, 3, 1, 0, DateTimeKind.Utc), "Kate Greyrat", "Kate.Greyrat@bbc.co.uk", "+287 1617744460", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 189,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1913, 3, 2, 3, 7, 1, 0, DateTimeKind.Utc), "William Johnson", "William.Johnson@tesla.com", "+289 1327350010", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3128) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 190,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1942, 6, 19, 0, 18, 27, 0, DateTimeKind.Utc), "Elisabeth Miller", "Elisabeth.Miller@gov.ru", "+668 1696026166", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 191,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1965, 2, 24, 22, 59, 0, 0, DateTimeKind.Utc), "Ellen Johnson", "Ellen.Johnson@tesla.com", "+549 2047509629", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 192,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1934, 7, 3, 0, 42, 27, 0, DateTimeKind.Utc), "Sara Jones", "Sara.Jones@bbc.co.uk", "+583 2047217435", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 193,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1944, 6, 19, 8, 23, 12, 0, DateTimeKind.Utc), "Jacob Kagenou", "Jacob.Kagenou@gov.gr", "+984 1850491887", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 194,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1910, 9, 11, 13, 30, 53, 0, DateTimeKind.Utc), "Ellen Kagenou", "Ellen.Kagenou@google.com", "+988 933694018", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 195,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1944, 1, 25, 16, 35, 13, 0, DateTimeKind.Utc), "Will Jones", "Will.Jones@something.com", "+188 773043649", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 196,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2002, 10, 18, 10, 17, 50, 0, DateTimeKind.Utc), "Rudeus Johnson", "Rudeus.Johnson@gov.gr", "+679 1570658398", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 197,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1963, 1, 3, 11, 15, 21, 0, DateTimeKind.Utc), "Bob Martinez", "Bob.Martinez@gov.nl", "+784 1049944491", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 198,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1967, 3, 18, 18, 13, 5, 0, DateTimeKind.Utc), "Audrey Greyrat", "Audrey.Greyrat@google.com", "+145 1379573845", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 199,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2009, 11, 24, 23, 45, 29, 0, DateTimeKind.Utc), "Sara Davis", "Sara.Davis@gov.nl", "+483 1597667170", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 1,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), "PG-13", 233, " Obtuse Computer", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 2,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2007, 3, 22, 0, 0, 0, 0, DateTimeKind.Utc), "G", 306, "A Depressed Building", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 3,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2010, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), "NC-17", 363, " Flimsy Airplane", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 4,
                columns: new[] { "created_at", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2011, 8, 2, 0, 0, 0, 0, DateTimeKind.Utc), 370, " Stubborn Donkey", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 5,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2013, 5, 24, 0, 0, 0, 0, DateTimeKind.Utc), "PG", 129, " Legendary Car", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 6,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Utc), "PG", 186, "  Bread", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 7,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2013, 2, 17, 0, 0, 0, 0, DateTimeKind.Utc), "PG-13", 142, " Flimsy Dog", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 8,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2020, 4, 19, 0, 0, 0, 0, DateTimeKind.Utc), "PG-13", 133, " Mystical Bread", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 9,
                columns: new[] { "created_at", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2018, 5, 5, 0, 0, 0, 0, DateTimeKind.Utc), 137, "The Sad Bread", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 10,
                columns: new[] { "created_at", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2006, 8, 3, 0, 0, 0, 0, DateTimeKind.Utc), 406, "A Obtuse Woman", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 11,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2002, 5, 28, 0, 0, 0, 0, DateTimeKind.Utc), "NC-17", 156, " Depressed Woman", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 12,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2001, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc), "PG-13", 353, "  Building", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 13,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2018, 3, 2, 0, 0, 0, 0, DateTimeKind.Utc), "PG-13", 338, " Depressing Computer", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 14,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2002, 11, 21, 0, 0, 0, 0, DateTimeKind.Utc), "PG", 343, " Angry Dog", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 15,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2009, 3, 28, 0, 0, 0, 0, DateTimeKind.Utc), "G", 265, " Legendary Car", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 16,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc), "PG-13", 310, "A  Goose", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 17,
                columns: new[] { "created_at", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2015, 2, 26, 0, 0, 0, 0, DateTimeKind.Utc), 256, "  Goose", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 18,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Utc), "NC-17", 244, " Depressed Dog", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 19,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "R", 347, "A Depressing Building", new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 1,
                columns: new[] { "capacity", "created_at", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 38, new DateTime(2001, 1, 13, 18, 34, 35, 0, DateTimeKind.Utc), 12, new DateTime(2001, 1, 17, 11, 34, 35, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 2,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 32, new DateTime(2024, 10, 11, 4, 16, 47, 0, DateTimeKind.Utc), 14, 4, new DateTime(2024, 10, 27, 6, 16, 47, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 3,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 62, new DateTime(2017, 7, 12, 2, 11, 37, 0, DateTimeKind.Utc), 10, 10, new DateTime(2017, 7, 17, 5, 11, 37, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 4,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 67, new DateTime(1996, 9, 19, 5, 17, 4, 0, DateTimeKind.Utc), 19, 17, new DateTime(1996, 10, 1, 0, 17, 4, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 5,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 67, new DateTime(1915, 10, 13, 19, 47, 16, 0, DateTimeKind.Utc), 10, 17, new DateTime(1915, 10, 14, 5, 47, 16, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 6,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 62, new DateTime(1901, 1, 2, 21, 55, 51, 0, DateTimeKind.Utc), 13, 10, new DateTime(1901, 1, 29, 8, 55, 51, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 7,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 23, new DateTime(1989, 8, 11, 20, 8, 4, 0, DateTimeKind.Utc), 3, 16, new DateTime(1989, 8, 28, 2, 8, 4, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 8,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 24, new DateTime(1903, 1, 10, 9, 10, 1, 0, DateTimeKind.Utc), 19, 5, new DateTime(1903, 1, 15, 7, 10, 1, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 9,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 72, new DateTime(2012, 1, 21, 23, 0, 49, 0, DateTimeKind.Utc), 12, 19, new DateTime(2012, 1, 22, 20, 0, 49, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 10,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 73, new DateTime(2014, 5, 16, 16, 34, 29, 0, DateTimeKind.Utc), 16, 6, new DateTime(2014, 6, 15, 10, 34, 29, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 11,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 73, new DateTime(1933, 4, 8, 16, 59, 37, 0, DateTimeKind.Utc), 9, 6, new DateTime(1933, 4, 10, 9, 59, 37, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3392) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 12,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 15, new DateTime(1911, 5, 20, 9, 50, 30, 0, DateTimeKind.Utc), 3, 1, new DateTime(1911, 5, 30, 0, 50, 30, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 13,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 25, new DateTime(2000, 5, 24, 10, 21, 57, 0, DateTimeKind.Utc), 3, 2, new DateTime(2000, 5, 31, 0, 21, 57, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 14,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 79, new DateTime(1920, 7, 10, 5, 21, 3, 0, DateTimeKind.Utc), 2, 20, new DateTime(1920, 8, 9, 4, 21, 3, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 15,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 72, new DateTime(2011, 8, 6, 5, 22, 3, 0, DateTimeKind.Utc), 13, 19, new DateTime(2011, 8, 6, 5, 22, 3, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 16,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 79, new DateTime(1954, 1, 20, 13, 32, 31, 0, DateTimeKind.Utc), 10, 20, new DateTime(1954, 2, 17, 12, 32, 31, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 17,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 32, new DateTime(2019, 9, 28, 11, 41, 53, 0, DateTimeKind.Utc), 18, 4, new DateTime(2019, 10, 20, 14, 41, 53, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 18,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 73, new DateTime(1986, 11, 21, 19, 57, 58, 0, DateTimeKind.Utc), 14, 6, new DateTime(1986, 12, 12, 3, 57, 58, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 19,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 25, new DateTime(2008, 5, 8, 15, 50, 6, 0, DateTimeKind.Utc), 10, 2, new DateTime(2008, 5, 14, 10, 50, 6, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 20,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 92, new DateTime(1982, 1, 18, 4, 34, 49, 0, DateTimeKind.Utc), 7, 8, new DateTime(1982, 2, 9, 3, 34, 49, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 21,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 23, new DateTime(1999, 11, 16, 9, 45, 33, 0, DateTimeKind.Utc), 4, 16, new DateTime(1999, 11, 19, 11, 45, 33, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 22,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 52, new DateTime(2012, 11, 9, 13, 21, 39, 0, DateTimeKind.Utc), 9, 11, new DateTime(2012, 12, 2, 6, 21, 39, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 23,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 52, new DateTime(1959, 11, 3, 19, 30, 42, 0, DateTimeKind.Utc), 7, 18, new DateTime(1959, 11, 26, 4, 30, 42, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 24,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 22, new DateTime(1959, 2, 5, 1, 15, 33, 0, DateTimeKind.Utc), 4, 7, new DateTime(1959, 3, 3, 20, 15, 33, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 25,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 32, new DateTime(1995, 10, 14, 2, 20, 51, 0, DateTimeKind.Utc), 1, 4, new DateTime(1995, 10, 29, 20, 20, 51, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 26,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 52, new DateTime(1992, 7, 14, 2, 7, 51, 0, DateTimeKind.Utc), 2, 11, new DateTime(1992, 7, 28, 17, 7, 51, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 27,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 38, new DateTime(1916, 5, 11, 9, 49, 3, 0, DateTimeKind.Utc), 16, 12, new DateTime(1916, 6, 9, 1, 49, 3, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 28,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 24, new DateTime(2006, 7, 19, 4, 41, 37, 0, DateTimeKind.Utc), 15, 5, new DateTime(2006, 7, 29, 12, 41, 37, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 29,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 32, new DateTime(1973, 5, 2, 0, 12, 52, 0, DateTimeKind.Utc), 4, 4, new DateTime(1973, 5, 13, 5, 12, 52, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 30,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 22, new DateTime(1938, 10, 15, 15, 58, 56, 0, DateTimeKind.Utc), 18, 7, new DateTime(1938, 11, 5, 3, 58, 56, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3509) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 31,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 29, new DateTime(1965, 2, 8, 12, 37, 13, 0, DateTimeKind.Utc), 18, 14, new DateTime(1965, 2, 23, 2, 37, 13, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3516) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 32,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 62, new DateTime(1988, 4, 14, 16, 39, 36, 0, DateTimeKind.Utc), 5, 10, new DateTime(1988, 5, 14, 7, 39, 36, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 33,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 79, new DateTime(2015, 8, 17, 0, 8, 30, 0, DateTimeKind.Utc), 8, 20, new DateTime(2015, 9, 14, 18, 8, 30, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 34,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 8, new DateTime(2001, 6, 18, 11, 4, 55, 0, DateTimeKind.Utc), 2, 9, new DateTime(2001, 7, 2, 5, 4, 55, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 35,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 25, new DateTime(1992, 5, 19, 20, 55, 9, 0, DateTimeKind.Utc), 10, 2, new DateTime(1992, 5, 31, 0, 55, 9, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 36,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 29, new DateTime(2024, 4, 26, 10, 56, 1, 0, DateTimeKind.Utc), 17, 14, new DateTime(2024, 5, 25, 22, 56, 1, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3548) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 37,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 42, new DateTime(1978, 1, 5, 0, 32, 58, 0, DateTimeKind.Utc), 5, 13, new DateTime(1978, 1, 27, 20, 32, 58, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 38,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 29, new DateTime(1936, 7, 10, 22, 15, 37, 0, DateTimeKind.Utc), 10, 14, new DateTime(1936, 7, 31, 3, 15, 37, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 39,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 22, new DateTime(1944, 6, 26, 2, 14, 11, 0, DateTimeKind.Utc), 16, 7, new DateTime(1944, 7, 2, 17, 14, 11, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 40,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 38, new DateTime(2018, 9, 25, 4, 55, 19, 0, DateTimeKind.Utc), 10, 12, new DateTime(2018, 10, 16, 10, 55, 19, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 41,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 62, new DateTime(1975, 7, 7, 1, 12, 46, 0, DateTimeKind.Utc), 13, 15, new DateTime(1975, 8, 1, 0, 12, 46, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 42,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 73, new DateTime(1974, 11, 18, 9, 51, 34, 0, DateTimeKind.Utc), 16, 3, new DateTime(1974, 11, 18, 10, 51, 34, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 43,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 62, new DateTime(2016, 3, 19, 11, 9, 23, 0, DateTimeKind.Utc), 14, 15, new DateTime(2016, 4, 12, 7, 9, 23, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 44,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 29, new DateTime(1912, 4, 15, 12, 1, 49, 0, DateTimeKind.Utc), 2, 14, new DateTime(1912, 4, 16, 13, 1, 49, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 45,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 79, new DateTime(1973, 2, 1, 22, 42, 17, 0, DateTimeKind.Utc), 1, 20, new DateTime(1973, 3, 3, 20, 42, 17, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 46,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 8, new DateTime(2014, 11, 26, 11, 49, 8, 0, DateTimeKind.Utc), 6, 9, new DateTime(2014, 12, 19, 0, 49, 8, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 47,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 15, new DateTime(1956, 2, 8, 19, 58, 52, 0, DateTimeKind.Utc), 19, 1, new DateTime(1956, 2, 11, 10, 58, 52, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3619) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 48,
                columns: new[] { "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1945, 7, 12, 14, 43, 26, 0, DateTimeKind.Utc), 2, 15, new DateTime(1945, 7, 15, 21, 43, 26, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 49,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 15, new DateTime(1903, 11, 23, 14, 46, 12, 0, DateTimeKind.Utc), 5, 1, new DateTime(1903, 11, 28, 8, 46, 12, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 2,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1980, 8, 24, 14, 33, 41, 0, DateTimeKind.Utc), 83, 1, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 3,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(2007, 2, 3, 17, 56, 14, 0, DateTimeKind.Utc), 125, 3, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 4,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2023, 1, 23, 21, 35, 15, 0, DateTimeKind.Utc), 153, 1, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 5,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(2000, 2, 17, 9, 6, 52, 0, DateTimeKind.Utc), 111, 1, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3666) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 6,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1935, 1, 7, 15, 48, 3, 0, DateTimeKind.Utc), 145, 2, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 7,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1975, 4, 28, 1, 54, 23, 0, DateTimeKind.Utc), 22, 1, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 8,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1911, 8, 11, 4, 14, 46, 0, DateTimeKind.Utc), 19, 3, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3686) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 9,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1970, 3, 10, 15, 37, 56, 0, DateTimeKind.Utc), 160, 2, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3691) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 10,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1916, 3, 12, 13, 19, 14, 0, DateTimeKind.Utc), 6, 3, 2, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 11,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1900, 11, 15, 20, 40, 53, 0, DateTimeKind.Utc), 134, 2, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 12,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1950, 2, 2, 4, 12, 15, 0, DateTimeKind.Utc), 110, 1, 2, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3712) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 13,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1973, 8, 4, 9, 24, 6, 0, DateTimeKind.Utc), 193, 3, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3719) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 14,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1950, 1, 16, 21, 5, 41, 0, DateTimeKind.Utc), 74, 1, 3, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3725) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 15,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1995, 6, 22, 6, 28, 42, 0, DateTimeKind.Utc), 36, 2, 3, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 16,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2015, 5, 13, 15, 58, 27, 0, DateTimeKind.Utc), 11, 2, 3, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3735) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 17,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1948, 4, 24, 5, 41, 58, 0, DateTimeKind.Utc), 52, 3, 3, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 18,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1986, 1, 5, 14, 44, 24, 0, DateTimeKind.Utc), 92, 3, 3, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3746) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 19,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2022, 2, 12, 16, 20, 44, 0, DateTimeKind.Utc), 68, 3, 3, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3753) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 20,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2013, 11, 16, 23, 12, 5, 0, DateTimeKind.Utc), 166, 2, 3, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3759) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 21,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1985, 10, 23, 6, 2, 32, 0, DateTimeKind.Utc), 52, 1, 3, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 22,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1988, 6, 18, 12, 31, 57, 0, DateTimeKind.Utc), 146, 4, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 23,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1956, 6, 28, 8, 0, 3, 0, DateTimeKind.Utc), 162, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 24,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(2000, 8, 10, 15, 10, 41, 0, DateTimeKind.Utc), 89, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3783) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 25,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1918, 2, 21, 13, 24, 52, 0, DateTimeKind.Utc), 155, 3, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 26,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1961, 8, 5, 9, 58, 33, 0, DateTimeKind.Utc), 56, 5, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 27,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1970, 3, 7, 22, 35, 23, 0, DateTimeKind.Utc), 30, 5, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 28,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1898, 5, 22, 7, 49, 8, 0, DateTimeKind.Utc), 121, 1, 5, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3806) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 29,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1995, 6, 18, 10, 31, 19, 0, DateTimeKind.Utc), 109, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 30,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1912, 8, 8, 11, 33, 14, 0, DateTimeKind.Utc), 83, 1, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 31,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(2008, 7, 8, 6, 11, 21, 0, DateTimeKind.Utc), 87, 1, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 32,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1990, 1, 3, 1, 32, 20, 0, DateTimeKind.Utc), 138, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3827) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 33,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1941, 5, 21, 20, 29, 44, 0, DateTimeKind.Utc), 74, 2, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 34,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1908, 1, 7, 16, 58, 10, 0, DateTimeKind.Utc), 119, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 35,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(2009, 7, 26, 21, 26, 36, 0, DateTimeKind.Utc), 105, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3873) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 36,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1898, 11, 14, 23, 47, 1, 0, DateTimeKind.Utc), 61, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3878) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 37,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1942, 6, 20, 4, 18, 46, 0, DateTimeKind.Utc), 137, 2, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3884) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 38,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1905, 7, 26, 21, 36, 1, 0, DateTimeKind.Utc), 92, 1, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 39,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1904, 8, 21, 11, 4, 1, 0, DateTimeKind.Utc), 44, 2, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3895) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 40,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1942, 11, 5, 15, 30, 4, 0, DateTimeKind.Utc), 40, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 41,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1986, 7, 27, 0, 18, 12, 0, DateTimeKind.Utc), 164, 1, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3906) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 42,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1928, 7, 19, 8, 12, 57, 0, DateTimeKind.Utc), 88, 2, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3913) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 43,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(2022, 6, 12, 5, 53, 52, 0, DateTimeKind.Utc), 157, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 44,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1961, 5, 25, 10, 57, 13, 0, DateTimeKind.Utc), 176, 1, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3923) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 45,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2001, 1, 23, 5, 37, 20, 0, DateTimeKind.Utc), 47, 2, 8, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 46,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1983, 10, 11, 17, 24, 4, 0, DateTimeKind.Utc), 6, 2, 8, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 47,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1983, 11, 9, 14, 9, 35, 0, DateTimeKind.Utc), 170, 3, 8, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 48,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1931, 9, 25, 14, 48, 15, 0, DateTimeKind.Utc), 175, 3, 8, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3947) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 49,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2013, 5, 18, 3, 26, 27, 0, DateTimeKind.Utc), 20, 1, 8, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3952) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 50,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1993, 4, 5, 7, 11, 7, 0, DateTimeKind.Utc), 57, 1, 8, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 51,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1906, 7, 7, 6, 58, 49, 0, DateTimeKind.Utc), 90, 1, 9, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3963) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 52,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2012, 9, 12, 2, 1, 52, 0, DateTimeKind.Utc), 174, 3, 9, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 53,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2020, 5, 24, 12, 10, 43, 0, DateTimeKind.Utc), 116, 9, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3972) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 54,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1948, 4, 4, 19, 44, 52, 0, DateTimeKind.Utc), 115, 9, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3977) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 55,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2013, 3, 21, 8, 38, 12, 0, DateTimeKind.Utc), 196, 3, 9, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 56,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1938, 9, 20, 9, 23, 54, 0, DateTimeKind.Utc), 60, 9, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 57,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1990, 8, 12, 10, 22, 52, 0, DateTimeKind.Utc), 11, 9, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 58,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2021, 10, 4, 0, 53, 51, 0, DateTimeKind.Utc), 37, 1, 9, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 59,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1901, 3, 25, 12, 31, 43, 0, DateTimeKind.Utc), 173, 3, 9, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 60,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1899, 1, 28, 14, 28, 57, 0, DateTimeKind.Utc), 124, 3, 9, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 61,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1979, 4, 17, 12, 18, 59, 0, DateTimeKind.Utc), 58, 1, 9, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 62,
                columns: new[] { "created_at", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1920, 6, 22, 17, 11, 4, 0, DateTimeKind.Utc), 9, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 63,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1966, 4, 3, 7, 5, 52, 0, DateTimeKind.Utc), 30, 2, 9, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 64,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(2017, 7, 1, 3, 49, 34, 0, DateTimeKind.Utc), 91, 2, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 65,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1969, 9, 19, 10, 14, 39, 0, DateTimeKind.Utc), 157, 1, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 66,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1924, 6, 27, 19, 47, 45, 0, DateTimeKind.Utc), 194, 3, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 67,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1980, 8, 28, 16, 21, 13, 0, DateTimeKind.Utc), 29, 3, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 68,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1926, 7, 12, 10, 50, 33, 0, DateTimeKind.Utc), 48, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 69,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1931, 3, 16, 14, 41, 42, 0, DateTimeKind.Utc), 149, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 70,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1968, 1, 10, 21, 24, 11, 0, DateTimeKind.Utc), 127, 10, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 71,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1968, 2, 5, 10, 0, 58, 0, DateTimeKind.Utc), 27, 10, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 72,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1950, 6, 28, 0, 13, 27, 0, DateTimeKind.Utc), 194, 1, 10, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 73,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2020, 10, 9, 20, 10, 27, 0, DateTimeKind.Utc), 9, 3, 10, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 74,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1971, 2, 2, 22, 48, 12, 0, DateTimeKind.Utc), 170, 1, 10, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 75,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1978, 7, 25, 8, 35, 34, 0, DateTimeKind.Utc), 106, 1, 10, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 76,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1947, 1, 18, 3, 48, 28, 0, DateTimeKind.Utc), 95, 10, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 77,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1926, 2, 7, 19, 48, 54, 0, DateTimeKind.Utc), 40, 2, 10, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4108) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 78,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1913, 4, 20, 13, 10, 29, 0, DateTimeKind.Utc), 39, 10, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 79,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1957, 8, 23, 22, 39, 4, 0, DateTimeKind.Utc), 149, 10, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 80,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1948, 4, 19, 3, 12, 39, 0, DateTimeKind.Utc), 181, 10, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4125) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 81,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2015, 7, 17, 5, 3, 15, 0, DateTimeKind.Utc), 48, 3, 11, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 82,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1975, 6, 12, 13, 5, 27, 0, DateTimeKind.Utc), 95, 11, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 83,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1923, 8, 5, 17, 6, 27, 0, DateTimeKind.Utc), 143, 3, 11, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 84,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2013, 3, 28, 5, 56, 46, 0, DateTimeKind.Utc), 197, 3, 11, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 85,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2011, 6, 28, 3, 5, 56, 0, DateTimeKind.Utc), 84, 1, 11, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 86,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1993, 5, 13, 20, 5, 27, 0, DateTimeKind.Utc), 80, 1, 11, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4159) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 87,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1907, 5, 13, 20, 13, 57, 0, DateTimeKind.Utc), 54, 2, 11, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 88,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1981, 6, 27, 11, 46, 15, 0, DateTimeKind.Utc), 116, 11, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 89,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1971, 9, 26, 7, 53, 39, 0, DateTimeKind.Utc), 1, 1, 11, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 90,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1918, 11, 25, 18, 56, 30, 0, DateTimeKind.Utc), 127, 1, 11, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 91,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1984, 2, 17, 9, 9, 38, 0, DateTimeKind.Utc), 35, 11, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 92,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1931, 5, 25, 13, 58, 11, 0, DateTimeKind.Utc), 11, 11, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 93,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1945, 9, 25, 18, 21, 13, 0, DateTimeKind.Utc), 14, 3, 11, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 94,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1924, 1, 2, 0, 27, 5, 0, DateTimeKind.Utc), 114, 3, 11, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 95,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1940, 2, 25, 12, 57, 26, 0, DateTimeKind.Utc), 44, 11, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 96,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1907, 9, 7, 7, 28, 9, 0, DateTimeKind.Utc), 42, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 97,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1901, 3, 12, 8, 53, 3, 0, DateTimeKind.Utc), 12, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 98,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1899, 3, 15, 4, 34, 56, 0, DateTimeKind.Utc), 104, 2, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 99,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1941, 4, 14, 15, 41, 55, 0, DateTimeKind.Utc), 4, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 100,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1966, 9, 5, 1, 28, 56, 0, DateTimeKind.Utc), 105, 2, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 101,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1967, 10, 9, 23, 56, 52, 0, DateTimeKind.Utc), 136, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 102,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1975, 3, 16, 6, 52, 1, 0, DateTimeKind.Utc), 18, 1, 14, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 103,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1992, 6, 9, 7, 33, 27, 0, DateTimeKind.Utc), 64, 1, 14, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 104,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1931, 8, 3, 11, 15, 20, 0, DateTimeKind.Utc), 83, 14, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 105,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1922, 2, 10, 10, 50, 1, 0, DateTimeKind.Utc), 49, 2, 14, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 106,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1938, 7, 15, 22, 14, 11, 0, DateTimeKind.Utc), 17, 3, 14, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 107,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1902, 9, 23, 2, 33, 26, 0, DateTimeKind.Utc), 84, 2, 14, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 108,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1920, 9, 5, 19, 41, 2, 0, DateTimeKind.Utc), 191, 14, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4284) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 109,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1956, 1, 18, 9, 6, 0, 0, DateTimeKind.Utc), 21, 15, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 110,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1950, 2, 11, 12, 25, 46, 0, DateTimeKind.Utc), 5, 3, 15, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 111,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1956, 4, 11, 19, 0, 53, 0, DateTimeKind.Utc), 128, 2, 15, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 112,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1989, 9, 11, 8, 13, 0, 0, DateTimeKind.Utc), 80, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 113,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1899, 6, 2, 3, 35, 46, 0, DateTimeKind.Utc), 98, 3, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4312) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 114,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(2000, 2, 21, 22, 5, 17, 0, DateTimeKind.Utc), 82, 3, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 115,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1997, 10, 8, 18, 49, 28, 0, DateTimeKind.Utc), 39, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 116,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(2009, 6, 19, 3, 44, 55, 0, DateTimeKind.Utc), 114, 1, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 117,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1944, 7, 3, 4, 57, 28, 0, DateTimeKind.Utc), 20, 2, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4333) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 118,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1932, 1, 20, 22, 38, 7, 0, DateTimeKind.Utc), 87, 1, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 119,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1965, 4, 3, 12, 7, 14, 0, DateTimeKind.Utc), 81, 1, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 120,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1912, 7, 16, 20, 11, 2, 0, DateTimeKind.Utc), 167, 2, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 121,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1948, 8, 8, 13, 1, 7, 0, DateTimeKind.Utc), 128, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 122,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1997, 3, 26, 11, 9, 31, 0, DateTimeKind.Utc), 51, 3, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 123,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1910, 7, 24, 0, 54, 26, 0, DateTimeKind.Utc), 120, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 124,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1994, 5, 5, 0, 46, 42, 0, DateTimeKind.Utc), 40, 1, 15, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 125,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2017, 5, 3, 18, 15, 22, 0, DateTimeKind.Utc), 58, 1, 15, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 126,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1967, 5, 27, 4, 25, 50, 0, DateTimeKind.Utc), 3, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 127,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1996, 10, 10, 3, 26, 46, 0, DateTimeKind.Utc), 92, 1, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 128,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1984, 8, 15, 5, 1, 11, 0, DateTimeKind.Utc), 196, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 129,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1972, 6, 22, 10, 3, 24, 0, DateTimeKind.Utc), 126, 1, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 130,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(2010, 4, 24, 4, 17, 28, 0, DateTimeKind.Utc), 79, 3, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 131,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1980, 5, 20, 0, 28, 13, 0, DateTimeKind.Utc), 81, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 132,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1918, 9, 24, 6, 27, 33, 0, DateTimeKind.Utc), 62, 16, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4473) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 133,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1962, 7, 21, 4, 37, 51, 0, DateTimeKind.Utc), 151, 16, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 134,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1994, 10, 4, 2, 50, 45, 0, DateTimeKind.Utc), 4, 1, 16, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 135,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1936, 3, 27, 15, 6, 0, 0, DateTimeKind.Utc), 77, 16, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 136,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1982, 3, 18, 2, 17, 41, 0, DateTimeKind.Utc), 67, 3, 16, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4498) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 137,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2017, 1, 8, 1, 12, 59, 0, DateTimeKind.Utc), 186, 1, 16, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 138,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1957, 9, 12, 5, 52, 20, 0, DateTimeKind.Utc), 186, 16, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4508) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 139,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1946, 5, 15, 7, 58, 30, 0, DateTimeKind.Utc), 113, 16, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4513) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 140,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1994, 1, 25, 12, 51, 47, 0, DateTimeKind.Utc), 20, 1, 16, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 141,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1960, 8, 5, 23, 17, 17, 0, DateTimeKind.Utc), 100, 16, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 142,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1905, 8, 4, 12, 58, 13, 0, DateTimeKind.Utc), 19, 3, 17, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 143,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1960, 4, 21, 20, 51, 27, 0, DateTimeKind.Utc), 129, 2, 17, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 144,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1993, 5, 9, 7, 33, 8, 0, DateTimeKind.Utc), 119, 2, 17, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 145,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1912, 3, 19, 13, 4, 17, 0, DateTimeKind.Utc), 154, 3, 17, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 146,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1925, 2, 25, 9, 6, 54, 0, DateTimeKind.Utc), 59, 17, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 147,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1959, 1, 15, 23, 4, 30, 0, DateTimeKind.Utc), 33, 3, 17, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 148,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1974, 2, 10, 23, 29, 35, 0, DateTimeKind.Utc), 190, 1, 17, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 149,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1946, 10, 17, 7, 32, 6, 0, DateTimeKind.Utc), 73, 17, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4564) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 150,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1913, 7, 13, 19, 29, 58, 0, DateTimeKind.Utc), 4, 17, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 151,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1902, 4, 6, 1, 43, 26, 0, DateTimeKind.Utc), 143, 17, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 152,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1990, 8, 14, 6, 20, 29, 0, DateTimeKind.Utc), 78, 17, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 153,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1987, 9, 27, 8, 5, 28, 0, DateTimeKind.Utc), 10, 2, 18, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 154,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1941, 10, 28, 1, 34, 20, 0, DateTimeKind.Utc), 34, 1, 18, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 155,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1980, 10, 6, 1, 19, 45, 0, DateTimeKind.Utc), 54, 18, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 156,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1991, 2, 1, 13, 5, 43, 0, DateTimeKind.Utc), 137, 2, 18, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 157,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1945, 8, 27, 21, 38, 37, 0, DateTimeKind.Utc), 60, 3, 18, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 158,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1915, 3, 7, 8, 8, 13, 0, DateTimeKind.Utc), 45, 2, 18, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 159,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1979, 2, 15, 6, 51, 31, 0, DateTimeKind.Utc), 115, 2, 18, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 160,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1918, 9, 17, 17, 54, 24, 0, DateTimeKind.Utc), 79, 18, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 161,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1998, 1, 15, 8, 32, 21, 0, DateTimeKind.Utc), 137, 2, 18, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 162,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1931, 3, 16, 5, 20, 16, 0, DateTimeKind.Utc), 156, 18, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 163,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1925, 4, 20, 8, 10, 24, 0, DateTimeKind.Utc), 180, 18, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 164,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1963, 1, 7, 19, 41, 14, 0, DateTimeKind.Utc), 34, 2, 18, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 165,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1925, 9, 1, 9, 31, 10, 0, DateTimeKind.Utc), 114, 3, 18, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 166,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2010, 1, 9, 11, 58, 6, 0, DateTimeKind.Utc), 50, 18, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 167,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2002, 4, 21, 1, 39, 45, 0, DateTimeKind.Utc), 41, 18, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 168,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1972, 10, 20, 4, 23, 46, 0, DateTimeKind.Utc), 69, 18, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 169,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1942, 9, 19, 1, 54, 38, 0, DateTimeKind.Utc), 160, 1, 18, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 170,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1951, 6, 16, 7, 59, 49, 0, DateTimeKind.Utc), 57, 2, 18, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 171,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1936, 3, 2, 15, 11, 15, 0, DateTimeKind.Utc), 158, 2, 18, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 172,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1945, 1, 21, 13, 56, 28, 0, DateTimeKind.Utc), 36, 18, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 173,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1965, 4, 4, 9, 2, 54, 0, DateTimeKind.Utc), 137, 18, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4687) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 174,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1936, 10, 11, 16, 26, 58, 0, DateTimeKind.Utc), 36, 3, 19, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 175,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1898, 7, 11, 22, 47, 59, 0, DateTimeKind.Utc), 87, 19, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 176,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1900, 9, 23, 17, 59, 12, 0, DateTimeKind.Utc), 114, 19, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 177,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2002, 9, 28, 23, 0, 18, 0, DateTimeKind.Utc), 114, 1, 19, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 178,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1935, 4, 21, 12, 35, 23, 0, DateTimeKind.Utc), 132, 3, 19, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 179,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1976, 5, 14, 1, 57, 18, 0, DateTimeKind.Utc), 139, 2, 19, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 180,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1933, 4, 2, 12, 20, 6, 0, DateTimeKind.Utc), 135, 19, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 181,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1936, 6, 26, 4, 42, 53, 0, DateTimeKind.Utc), 44, 19, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 182,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1914, 8, 23, 3, 15, 26, 0, DateTimeKind.Utc), 155, 3, 20, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4739) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 183,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1941, 6, 7, 22, 33, 9, 0, DateTimeKind.Utc), 49, 1, 20, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 184,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1958, 7, 28, 10, 17, 28, 0, DateTimeKind.Utc), 65, 2, 20, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4751) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 185,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1930, 9, 18, 4, 42, 45, 0, DateTimeKind.Utc), 86, 2, 20, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4757) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 186,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1973, 5, 22, 6, 50, 0, 0, DateTimeKind.Utc), 31, 2, 20, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4763) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 187,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1998, 5, 23, 6, 53, 4, 0, DateTimeKind.Utc), 171, 1, 20, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 188,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1974, 2, 16, 9, 18, 2, 0, DateTimeKind.Utc), 188, 1, 20, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 189,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1902, 7, 19, 22, 16, 30, 0, DateTimeKind.Utc), 138, 3, 21, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 190,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1994, 11, 10, 14, 29, 29, 0, DateTimeKind.Utc), 34, 1, 21, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 191,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1999, 10, 24, 1, 19, 45, 0, DateTimeKind.Utc), 114, 3, 22, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 192,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1982, 2, 19, 9, 24, 9, 0, DateTimeKind.Utc), 168, 1, 22, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 193,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2006, 4, 13, 2, 3, 53, 0, DateTimeKind.Utc), 61, 3, 22, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4802) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 194,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 1, 20, 17, 45, 26, 0, DateTimeKind.Utc), 137, 3, 22, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 195,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1967, 11, 22, 17, 45, 38, 0, DateTimeKind.Utc), 3, 22, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4812) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 196,
                columns: new[] { "created_at", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1998, 11, 7, 4, 33, 50, 0, DateTimeKind.Utc), 22, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 197,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1955, 6, 7, 12, 35, 12, 0, DateTimeKind.Utc), 25, 3, 22, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 198,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1991, 4, 24, 18, 14, 3, 0, DateTimeKind.Utc), 21, 1, 22, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 199,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1928, 1, 17, 13, 23, 59, 0, DateTimeKind.Utc), 22, 1, 22, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 200,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1899, 8, 2, 2, 5, 32, 0, DateTimeKind.Utc), 129, 3, 22, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 201,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1966, 10, 22, 21, 18, 32, 0, DateTimeKind.Utc), 2, 1, 22, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 202,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1997, 6, 26, 18, 36, 11, 0, DateTimeKind.Utc), 61, 23, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 203,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1987, 2, 12, 8, 41, 25, 0, DateTimeKind.Utc), 112, 1, 23, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 204,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1899, 1, 15, 23, 21, 55, 0, DateTimeKind.Utc), 86, 23, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4871) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 205,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1978, 11, 26, 8, 41, 42, 0, DateTimeKind.Utc), 127, 3, 23, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4876) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 206,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1936, 7, 10, 12, 35, 42, 0, DateTimeKind.Utc), 145, 1, 23, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 207,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1967, 8, 18, 3, 32, 2, 0, DateTimeKind.Utc), 97, 3, 23, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4886) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 208,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1966, 7, 12, 17, 26, 30, 0, DateTimeKind.Utc), 7, 23, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4891) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 209,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1931, 9, 17, 22, 50, 13, 0, DateTimeKind.Utc), 62, 1, 23, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4896) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 210,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1985, 11, 2, 15, 33, 3, 0, DateTimeKind.Utc), 93, 1, 24, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 211,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1981, 10, 5, 12, 28, 42, 0, DateTimeKind.Utc), 130, 2, 24, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 212,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1938, 1, 2, 19, 55, 46, 0, DateTimeKind.Utc), 92, 24, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 213,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1998, 8, 23, 6, 1, 22, 0, DateTimeKind.Utc), 154, 25, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 214,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1919, 2, 28, 1, 45, 33, 0, DateTimeKind.Utc), 31, 2, 25, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 215,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1898, 3, 2, 4, 49, 58, 0, DateTimeKind.Utc), 87, 25, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 216,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1957, 4, 22, 14, 27, 0, 0, DateTimeKind.Utc), 13, 1, 25, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4933) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 217,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2010, 6, 4, 11, 27, 11, 0, DateTimeKind.Utc), 191, 26, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4938) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 218,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1940, 3, 13, 12, 0, 1, 0, DateTimeKind.Utc), 193, 1, 26, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 219,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1952, 1, 23, 18, 36, 56, 0, DateTimeKind.Utc), 49, 1, 26, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 220,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1978, 2, 26, 6, 19, 20, 0, DateTimeKind.Utc), 16, 3, 26, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 221,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1953, 9, 18, 9, 38, 9, 0, DateTimeKind.Utc), 67, 26, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 222,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1952, 10, 17, 1, 6, 19, 0, DateTimeKind.Utc), 148, 2, 27, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 223,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1949, 6, 12, 7, 53, 10, 0, DateTimeKind.Utc), 25, 2, 27, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 224,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1910, 7, 18, 6, 21, 12, 0, DateTimeKind.Utc), 86, 3, 27, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 225,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1956, 4, 11, 22, 57, 29, 0, DateTimeKind.Utc), 21, 27, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 226,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1905, 2, 5, 2, 13, 48, 0, DateTimeKind.Utc), 110, 27, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 227,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1962, 1, 25, 11, 38, 37, 0, DateTimeKind.Utc), 104, 1, 27, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 228,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1955, 11, 26, 16, 17, 19, 0, DateTimeKind.Utc), 73, 1, 27, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 229,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1955, 1, 24, 10, 6, 30, 0, DateTimeKind.Utc), 6, 27, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 230,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2008, 10, 25, 22, 1, 18, 0, DateTimeKind.Utc), 63, 2, 28, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 231,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1926, 5, 2, 7, 20, 23, 0, DateTimeKind.Utc), 32, 1, 28, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 232,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1965, 9, 19, 12, 5, 49, 0, DateTimeKind.Utc), 173, 1, 28, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 233,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1976, 1, 16, 3, 7, 28, 0, DateTimeKind.Utc), 44, 2, 28, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 234,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1933, 3, 4, 0, 29, 35, 0, DateTimeKind.Utc), 4, 2, 28, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 235,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1912, 2, 3, 14, 41, 9, 0, DateTimeKind.Utc), 123, 28, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 236,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1983, 7, 12, 0, 53, 22, 0, DateTimeKind.Utc), 7, 29, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 237,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1985, 4, 5, 17, 12, 11, 0, DateTimeKind.Utc), 59, 3, 29, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5046) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 238,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1951, 4, 23, 18, 2, 22, 0, DateTimeKind.Utc), 163, 2, 29, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 239,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1985, 5, 22, 22, 9, 39, 0, DateTimeKind.Utc), 35, 3, 29, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 240,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1949, 10, 18, 1, 13, 35, 0, DateTimeKind.Utc), 73, 3, 29, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 241,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2022, 3, 19, 19, 4, 37, 0, DateTimeKind.Utc), 195, 1, 29, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 242,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1985, 9, 8, 20, 8, 31, 0, DateTimeKind.Utc), 103, 29, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 243,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1990, 2, 14, 22, 16, 43, 0, DateTimeKind.Utc), 6, 1, 29, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 244,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1902, 8, 3, 8, 53, 44, 0, DateTimeKind.Utc), 15, 3, 30, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 245,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2002, 11, 2, 18, 53, 5, 0, DateTimeKind.Utc), 199, 30, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 246,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1968, 1, 15, 0, 38, 18, 0, DateTimeKind.Utc), 198, 30, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 247,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1974, 6, 2, 18, 6, 58, 0, DateTimeKind.Utc), 36, 1, 30, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 248,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2008, 10, 15, 23, 54, 41, 0, DateTimeKind.Utc), 111, 31, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5111) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 249,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2008, 1, 28, 0, 30, 28, 0, DateTimeKind.Utc), 5, 3, 32, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 250,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1929, 4, 26, 1, 13, 1, 0, DateTimeKind.Utc), 78, 2, 32, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5123) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 251,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1906, 2, 9, 21, 32, 32, 0, DateTimeKind.Utc), 157, 3, 32, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5129) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 252,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1941, 4, 19, 9, 49, 18, 0, DateTimeKind.Utc), 183, 1, 32, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5135) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 253,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1931, 7, 17, 22, 54, 1, 0, DateTimeKind.Utc), 81, 2, 32, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 254,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1967, 9, 13, 16, 19, 44, 0, DateTimeKind.Utc), 10, 32, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 255,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1981, 1, 8, 15, 41, 6, 0, DateTimeKind.Utc), 117, 2, 32, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 256,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1987, 2, 1, 22, 23, 23, 0, DateTimeKind.Utc), 90, 1, 32, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 257,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1944, 5, 27, 5, 50, 12, 0, DateTimeKind.Utc), 81, 3, 32, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5217) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 258,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2014, 9, 1, 13, 33, 36, 0, DateTimeKind.Utc), 190, 1, 32, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 259,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2007, 9, 23, 21, 57, 50, 0, DateTimeKind.Utc), 87, 32, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 260,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1910, 11, 15, 17, 58, 38, 0, DateTimeKind.Utc), 105, 3, 32, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 261,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1958, 4, 15, 15, 30, 39, 0, DateTimeKind.Utc), 39, 32, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 262,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1944, 8, 25, 6, 56, 25, 0, DateTimeKind.Utc), 45, 32, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 263,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1971, 6, 10, 23, 23, 27, 0, DateTimeKind.Utc), 125, 1, 32, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 264,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1929, 7, 5, 9, 17, 13, 0, DateTimeKind.Utc), 131, 1, 32, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 265,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1952, 8, 22, 10, 9, 56, 0, DateTimeKind.Utc), 113, 1, 32, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 266,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2002, 10, 21, 17, 17, 57, 0, DateTimeKind.Utc), 43, 33, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 267,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2005, 7, 23, 7, 38, 6, 0, DateTimeKind.Utc), 68, 2, 35, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5284) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 268,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1915, 3, 9, 1, 32, 19, 0, DateTimeKind.Utc), 176, 1, 35, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 269,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1936, 7, 5, 19, 39, 0, 0, DateTimeKind.Utc), 152, 1, 36, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5295) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 270,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2002, 3, 13, 2, 51, 14, 0, DateTimeKind.Utc), 198, 2, 37, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 271,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2006, 1, 10, 3, 38, 17, 0, DateTimeKind.Utc), 18, 2, 37, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 272,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1978, 9, 14, 13, 6, 44, 0, DateTimeKind.Utc), 131, 37, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 273,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1927, 5, 24, 23, 2, 57, 0, DateTimeKind.Utc), 113, 1, 37, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 274,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1936, 6, 14, 5, 50, 31, 0, DateTimeKind.Utc), 152, 1, 37, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 275,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1958, 2, 10, 18, 35, 13, 0, DateTimeKind.Utc), 125, 37, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 276,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2018, 10, 13, 13, 14, 49, 0, DateTimeKind.Utc), 126, 1, 37, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 277,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1945, 7, 23, 17, 45, 41, 0, DateTimeKind.Utc), 103, 38, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 278,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1951, 2, 20, 17, 46, 26, 0, DateTimeKind.Utc), 177, 1, 38, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 279,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1943, 6, 13, 10, 43, 51, 0, DateTimeKind.Utc), 21, 38, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 280,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1987, 2, 17, 7, 33, 55, 0, DateTimeKind.Utc), 81, 39, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 281,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1983, 10, 8, 4, 22, 25, 0, DateTimeKind.Utc), 145, 3, 39, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 282,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2010, 11, 1, 17, 33, 54, 0, DateTimeKind.Utc), 8, 39, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 283,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2011, 4, 3, 10, 17, 35, 0, DateTimeKind.Utc), 96, 1, 39, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 284,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1937, 7, 21, 15, 52, 51, 0, DateTimeKind.Utc), 78, 39, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5369) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 285,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1909, 6, 14, 7, 38, 2, 0, DateTimeKind.Utc), 11, 1, 40, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5374) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 286,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2009, 9, 27, 3, 30, 0, 0, DateTimeKind.Utc), 65, 1, 40, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5379) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 287,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1943, 8, 22, 9, 19, 5, 0, DateTimeKind.Utc), 104, 1, 40, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 288,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1989, 8, 11, 22, 9, 2, 0, DateTimeKind.Utc), 50, 2, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 289,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1903, 3, 4, 19, 30, 32, 0, DateTimeKind.Utc), 165, 2, 41, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 290,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1940, 9, 1, 5, 32, 17, 0, DateTimeKind.Utc), 100, 2, 41, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 291,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1965, 2, 5, 20, 4, 33, 0, DateTimeKind.Utc), 132, 2, 41, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 292,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1998, 3, 14, 3, 49, 44, 0, DateTimeKind.Utc), 184, 41, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 293,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1919, 10, 12, 1, 43, 31, 0, DateTimeKind.Utc), 21, 41, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5414) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 294,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1991, 8, 10, 8, 53, 51, 0, DateTimeKind.Utc), 159, 3, 41, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 295,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2018, 3, 19, 20, 42, 37, 0, DateTimeKind.Utc), 87, 3, 41, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5425) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 296,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2015, 2, 9, 17, 26, 33, 0, DateTimeKind.Utc), 191, 3, 41, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5429) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 297,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1959, 1, 1, 15, 24, 42, 0, DateTimeKind.Utc), 139, 41, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 298,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1983, 2, 7, 15, 53, 32, 0, DateTimeKind.Utc), 70, 3, 41, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 299,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1898, 7, 15, 10, 18, 23, 0, DateTimeKind.Utc), 45, 3, 41, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 300,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2005, 1, 18, 8, 58, 42, 0, DateTimeKind.Utc), 3, 3, 41, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 301,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2014, 11, 2, 16, 26, 17, 0, DateTimeKind.Utc), 176, 2, 41, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 302,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2015, 7, 26, 15, 54, 48, 0, DateTimeKind.Utc), 71, 41, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5461) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 303,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1936, 6, 6, 3, 48, 26, 0, DateTimeKind.Utc), 120, 41, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 304,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1906, 6, 17, 11, 3, 38, 0, DateTimeKind.Utc), 193, 42, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 305,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1920, 2, 15, 23, 0, 31, 0, DateTimeKind.Utc), 135, 42, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 306,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1923, 1, 10, 15, 46, 11, 0, DateTimeKind.Utc), 193, 42, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5485) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 307,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1981, 11, 13, 5, 56, 41, 0, DateTimeKind.Utc), 59, 43, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5491) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 308,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1936, 8, 20, 17, 14, 28, 0, DateTimeKind.Utc), 25, 2, 43, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 309,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1921, 3, 9, 1, 5, 18, 0, DateTimeKind.Utc), 101, 3, 43, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 310,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1910, 5, 25, 6, 40, 48, 0, DateTimeKind.Utc), 184, 2, 43, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5508) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 311,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2021, 8, 22, 13, 13, 58, 0, DateTimeKind.Utc), 95, 43, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5513) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 312,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1966, 3, 25, 16, 24, 36, 0, DateTimeKind.Utc), 93, 2, 43, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 313,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1937, 7, 21, 12, 58, 17, 0, DateTimeKind.Utc), 159, 2, 43, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 314,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1982, 11, 13, 1, 14, 29, 0, DateTimeKind.Utc), 146, 2, 43, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 315,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1950, 4, 22, 23, 34, 20, 0, DateTimeKind.Utc), 188, 43, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 316,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1947, 10, 28, 7, 52, 55, 0, DateTimeKind.Utc), 115, 3, 43, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 317,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1901, 9, 26, 3, 23, 45, 0, DateTimeKind.Utc), 187, 3, 43, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5546) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 318,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1914, 2, 18, 1, 29, 55, 0, DateTimeKind.Utc), 85, 43, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 319,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1985, 1, 11, 4, 44, 10, 0, DateTimeKind.Utc), 36, 3, 44, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 320,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1950, 5, 9, 22, 33, 41, 0, DateTimeKind.Utc), 44, 1, 44, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5563) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 321,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1991, 1, 5, 19, 44, 17, 0, DateTimeKind.Utc), 24, 2, 44, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 322,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1923, 7, 2, 23, 18, 27, 0, DateTimeKind.Utc), 129, 44, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 323,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1973, 7, 9, 18, 42, 50, 0, DateTimeKind.Utc), 85, 3, 45, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 324,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1996, 11, 3, 2, 45, 41, 0, DateTimeKind.Utc), 40, 3, 45, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5586) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 325,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1931, 11, 27, 10, 5, 50, 0, DateTimeKind.Utc), 97, 45, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 326,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1931, 5, 5, 3, 14, 52, 0, DateTimeKind.Utc), 33, 45, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 327,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1930, 4, 8, 3, 52, 2, 0, DateTimeKind.Utc), 142, 2, 45, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 328,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2006, 3, 28, 10, 35, 10, 0, DateTimeKind.Utc), 145, 2, 45, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 329,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1952, 6, 5, 19, 14, 47, 0, DateTimeKind.Utc), 165, 3, 45, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 330,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1963, 7, 22, 3, 14, 49, 0, DateTimeKind.Utc), 198, 45, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 331,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 6, 1, 11, 29, 51, 0, DateTimeKind.Utc), 83, 45, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 332,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1983, 6, 7, 20, 14, 8, 0, DateTimeKind.Utc), 179, 45, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 333,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1943, 1, 4, 6, 2, 41, 0, DateTimeKind.Utc), 33, 3, 45, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 334,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1925, 2, 26, 6, 40, 19, 0, DateTimeKind.Utc), 173, 45, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5682) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 335,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1969, 1, 6, 4, 16, 2, 0, DateTimeKind.Utc), 78, 2, 45, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 336,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1988, 2, 8, 7, 55, 50, 0, DateTimeKind.Utc), 19, 2, 45, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 337,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 11, 6, 14, 16, 0, DateTimeKind.Utc), 11, 1, 45, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 338,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2020, 6, 7, 1, 10, 29, 0, DateTimeKind.Utc), 15, 3, 45, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 339,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1942, 7, 19, 19, 37, 39, 0, DateTimeKind.Utc), 84, 3, 45, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 340,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1991, 11, 5, 6, 42, 8, 0, DateTimeKind.Utc), 194, 1, 45, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 341,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1988, 8, 9, 20, 23, 2, 0, DateTimeKind.Utc), 162, 1, 45, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 342,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2012, 10, 25, 14, 9, 5, 0, DateTimeKind.Utc), 38, 46, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 343,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1946, 11, 1, 18, 30, 48, 0, DateTimeKind.Utc), 44, 46, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 344,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2001, 8, 16, 16, 0, 8, 0, DateTimeKind.Utc), 138, 1, 47, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 345,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1998, 6, 20, 11, 45, 16, 0, DateTimeKind.Utc), 94, 3, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 346,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1908, 9, 23, 0, 42, 45, 0, DateTimeKind.Utc), 164, 2, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 347,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1898, 9, 21, 21, 56, 22, 0, DateTimeKind.Utc), 55, 3, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 348,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1981, 7, 19, 13, 37, 24, 0, DateTimeKind.Utc), 38, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 349,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1999, 7, 1, 5, 42, 12, 0, DateTimeKind.Utc), 123, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 350,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1905, 11, 28, 12, 24, 54, 0, DateTimeKind.Utc), 140, 2, 49, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 351,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(2008, 1, 13, 20, 18, 41, 0, DateTimeKind.Utc), 192, 1, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5779) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 352,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1942, 5, 10, 18, 42, 47, 0, DateTimeKind.Utc), 117, new DateTime(2024, 2, 7, 11, 11, 14, 188, DateTimeKind.Utc).AddTicks(5784) });

            migrationBuilder.CreateIndex(
                name: "IX_screenings_movie_id",
                table: "screenings",
                column: "movie_id");

            migrationBuilder.AddForeignKey(
                name: "FK_screenings_movies_movie_id",
                table: "screenings",
                column: "movie_id",
                principalTable: "movies",
                principalColumn: "movie_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_screenings_movies_movie_id",
                table: "screenings");

            migrationBuilder.DropIndex(
                name: "IX_screenings_movie_id",
                table: "screenings");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 1,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1916, 3, 24, 4, 31, 0, 0, DateTimeKind.Utc), "Will Johnson", "Will.Johnson@tesla.com", "+53 738266256", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 2,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1963, 11, 14, 19, 22, 35, 0, DateTimeKind.Utc), "Will Miller", "Will.Miller@gov.gr", "+94 1400384223", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 3,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1944, 11, 20, 13, 10, 40, 0, DateTimeKind.Utc), "Bobby Jones", "Bobby.Jones@google.com", "+194 45283225", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 4,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1983, 11, 6, 22, 25, 20, 0, DateTimeKind.Utc), "William Rodriguez", "William.Rodriguez@google.com", "+600 1325262784", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 5,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1926, 1, 1, 3, 51, 3, 0, DateTimeKind.Utc), "Bob Johnson", "Bob.Johnson@gov.gr", "+352 702956661", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 6,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1985, 1, 17, 20, 49, 23, 0, DateTimeKind.Utc), "Allen Smith", "Allen.Smith@gov.us", "+604 685353189", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7007) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 7,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2004, 2, 10, 0, 15, 47, 0, DateTimeKind.Utc), "Bob Kagenou", "Bob.Kagenou@google.com", "+160 415912316", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 8,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1975, 3, 22, 15, 25, 11, 0, DateTimeKind.Utc), "Kate Davis", "Kate.Davis@something.com", "+601 1736784578", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 9,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1995, 4, 9, 13, 42, 34, 0, DateTimeKind.Utc), "Jacob Johnson", "Jacob.Johnson@tesla.com", "+742 1092266709", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 10,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2013, 10, 20, 7, 41, 24, 0, DateTimeKind.Utc), "Will Garcia", "Will.Garcia@tesla.com", "+983 1421477286", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 11,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1904, 2, 21, 2, 43, 9, 0, DateTimeKind.Utc), "Sara Kagenou", "Sara.Kagenou@bbc.co.uk", "+431 1540327943", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7041) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 12,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1932, 9, 21, 4, 44, 42, 0, DateTimeKind.Utc), "Allen Davis", "Allen.Davis@nasa.org.us", "+764 67936839", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7047) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 13,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1922, 9, 13, 12, 14, 51, 0, DateTimeKind.Utc), "Will Miller", "Will.Miller@something.com", "+151 1011712681", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 14,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1926, 7, 20, 2, 25, 16, 0, DateTimeKind.Utc), "Robert Garcia", "Robert.Garcia@something.com", "+745 453449198", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 15,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1937, 2, 16, 23, 21, 55, 0, DateTimeKind.Utc), "Jacob Miller", "Jacob.Miller@bbc.co.uk", "+643 1712293239", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 16,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1988, 2, 18, 6, 33, 18, 0, DateTimeKind.Utc), "Audrey Martinez", "Audrey.Martinez@nasa.org.us", "+700 981265519", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 17,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1903, 10, 15, 15, 21, 54, 0, DateTimeKind.Utc), "Kate Garcia", "Kate.Garcia@something.com", "+731 1957589368", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 18,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2009, 7, 10, 7, 27, 40, 0, DateTimeKind.Utc), "Kate Jones", "Kate.Jones@something.com", "+03 1595132190", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 19,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1916, 1, 28, 4, 59, 42, 0, DateTimeKind.Utc), "Kate Rodriguez", "Kate.Rodriguez@something.com", "+315 358384940", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 20,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1968, 1, 18, 11, 10, 51, 0, DateTimeKind.Utc), "Bobby Williams", "Bobby.Williams@bbc.co.uk", "+838 417844431", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 21,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1943, 6, 14, 5, 56, 35, 0, DateTimeKind.Utc), "Sara Martinez", "Sara.Martinez@google.com", "+324 262735745", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 22,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1967, 5, 5, 9, 31, 7, 0, DateTimeKind.Utc), "Alice Smith", "Alice.Smith@gov.nl", "+600 1459769740", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 23,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2007, 6, 4, 15, 33, 53, 0, DateTimeKind.Utc), "Allen Smith", "Allen.Smith@gov.gr", "+874 2130464129", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 24,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1997, 5, 15, 14, 40, 30, 0, DateTimeKind.Utc), "Elisabeth Baker", "Elisabeth.Baker@tesla.com", "+863 400849650", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 25,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2002, 1, 27, 0, 3, 10, 0, DateTimeKind.Utc), "William Kagenou", "William.Kagenou@gov.us", "+239 100949758", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 26,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1920, 2, 28, 1, 14, 26, 0, DateTimeKind.Utc), "Elisabeth Jones", "Elisabeth.Jones@gov.us", "+541 825326231", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 27,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2006, 5, 12, 6, 5, 36, 0, DateTimeKind.Utc), "Bobby Jones", "Bobby.Jones@theworld.ca", "+56 425492932", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 28,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1923, 5, 6, 4, 55, 20, 0, DateTimeKind.Utc), "Will Williams", "Will.Williams@bbc.co.uk", "+173 940990694", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 29,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1915, 8, 15, 5, 36, 30, 0, DateTimeKind.Utc), "Timothy Jones", "Timothy.Jones@gov.nl", "+950 535228039", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 30,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1911, 6, 9, 6, 55, 23, 0, DateTimeKind.Utc), "Jim Johnson", "Jim.Johnson@something.com", "+416 1062046471", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 31,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1992, 6, 25, 20, 57, 43, 0, DateTimeKind.Utc), "Rob Greyrat", "Rob.Greyrat@something.com", "+740 125363573", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 32,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1915, 3, 15, 19, 22, 58, 0, DateTimeKind.Utc), "William Brown", "William.Brown@theworld.ca", "+117 1215928231", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 33,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2003, 9, 7, 8, 51, 24, 0, DateTimeKind.Utc), "Jim Johnson", "Jim.Johnson@google.com", "+83 1446339993", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 34,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1913, 9, 10, 0, 20, 17, 0, DateTimeKind.Utc), "Allen Jones", "Allen.Jones@tesla.com", "+327 1963165617", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 35,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1981, 9, 12, 23, 22, 46, 0, DateTimeKind.Utc), "Jim Davis", "Jim.Davis@theworld.ca", "+932 1799244409", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 36,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1898, 11, 27, 15, 47, 3, 0, DateTimeKind.Utc), "Sara Rodriguez", "Sara.Rodriguez@gov.us", "+245 1287863514", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 37,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1919, 11, 16, 6, 50, 31, 0, DateTimeKind.Utc), "Allen Williams", "Allen.Williams@theworld.ca", "+273 1676277886", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 38,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1956, 6, 17, 23, 36, 47, 0, DateTimeKind.Utc), "Kate Williams", "Kate.Williams@gov.gr", "+26 955988276", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 39,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2018, 11, 6, 23, 54, 10, 0, DateTimeKind.Utc), "Allen Davis", "Allen.Davis@tesla.com", "+454 2049259157", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 40,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1962, 11, 21, 21, 6, 42, 0, DateTimeKind.Utc), "Kate Jones", "Kate.Jones@gov.gr", "+889 1572575135", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 41,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2024, 3, 1, 8, 22, 16, 0, DateTimeKind.Utc), "Allen Baker", "Allen.Baker@gov.gr", "+963 2035018133", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 42,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1991, 1, 16, 0, 24, 56, 0, DateTimeKind.Utc), "Rob Miller", "Rob.Miller@gov.ru", "+410 389928339", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 43,
                columns: new[] { "created_at", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1918, 1, 24, 12, 54, 34, 0, DateTimeKind.Utc), "Robert.Jones@nasa.org.us", "+597 1570266386", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7346) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 44,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2020, 2, 22, 1, 16, 16, 0, DateTimeKind.Utc), "Robert Martinez", "Robert.Martinez@gov.nl", "+630 1219689948", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 45,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1937, 11, 11, 12, 52, 30, 0, DateTimeKind.Utc), "Cid Rodriguez", "Cid.Rodriguez@gov.ru", "+506 106954488", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 46,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2012, 2, 16, 8, 10, 36, 0, DateTimeKind.Utc), "Bobby Miller", "Bobby.Miller@tesla.com", "+816 120096280", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 47,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1928, 2, 24, 13, 43, 25, 0, DateTimeKind.Utc), "Timothy Miller", "Timothy.Miller@gov.us", "+141 207485785", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 48,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1960, 5, 27, 17, 10, 2, 0, DateTimeKind.Utc), "William Kagenou", "William.Kagenou@gov.ru", "+408 266655048", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 49,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2007, 2, 20, 4, 47, 36, 0, DateTimeKind.Utc), "Jim Baker", "Jim.Baker@google.com", "+336 691396280", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 50,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1948, 4, 19, 20, 6, 53, 0, DateTimeKind.Utc), "Jim Brown", "Jim.Brown@gov.us", "+523 856793380", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 51,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1916, 10, 15, 22, 58, 29, 0, DateTimeKind.Utc), "Jim Miller", "Jim.Miller@something.com", "+38 864418318", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 52,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1963, 2, 16, 5, 23, 26, 0, DateTimeKind.Utc), "Rob Rodriguez", "Rob.Rodriguez@bbc.co.uk", "+73 2067782561", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 53,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1937, 2, 1, 3, 23, 26, 0, DateTimeKind.Utc), "Ellen Williams", "Ellen.Williams@gov.nl", "+965 484656394", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 54,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1985, 2, 14, 17, 9, 22, 0, DateTimeKind.Utc), "Jacob Greyrat", "Jacob.Greyrat@google.com", "+694 1085462959", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 55,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1935, 3, 7, 5, 20, 55, 0, DateTimeKind.Utc), "William Johnson", "William.Johnson@theworld.ca", "+709 226208312", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 56,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1968, 6, 2, 21, 41, 28, 0, DateTimeKind.Utc), "Bobby Smith", "Bobby.Smith@something.com", "+847 1527963231", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 57,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1948, 8, 1, 11, 10, 11, 0, DateTimeKind.Utc), "Will Brown", "Will.Brown@theworld.ca", "+980 1600180180", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 58,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2004, 2, 12, 18, 58, 10, 0, DateTimeKind.Utc), "Rob Johnson", "Rob.Johnson@gov.ru", "+793 1091345728", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 59,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2011, 2, 23, 1, 3, 2, 0, DateTimeKind.Utc), "Rob Johnson", "Rob.Johnson@gov.nl", "+350 1214767952", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 60,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1918, 6, 10, 23, 55, 35, 0, DateTimeKind.Utc), "Bobby Greyrat", "Bobby.Greyrat@bbc.co.uk", "+617 47554240", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 61,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1977, 7, 16, 15, 24, 28, 0, DateTimeKind.Utc), "Jacob Jones", "Jacob.Jones@google.com", "+861 1717727697", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 62,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1996, 5, 23, 9, 50, 59, 0, DateTimeKind.Utc), "William Brown", "William.Brown@tesla.com", "+145 1661725583", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 63,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1900, 2, 23, 19, 30, 10, 0, DateTimeKind.Utc), "Will Brown", "Will.Brown@tesla.com", "+23 540511227", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 64,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2001, 1, 8, 7, 41, 47, 0, DateTimeKind.Utc), "Maria Williams", "Maria.Williams@bbc.co.uk", "+746 2122486392", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 65,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1981, 5, 25, 10, 28, 59, 0, DateTimeKind.Utc), "Robert Smith", "Robert.Smith@gov.ru", "+980 740176299", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 66,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2000, 1, 24, 11, 21, 33, 0, DateTimeKind.Utc), "Rudeus Martinez", "Rudeus.Martinez@gov.nl", "+899 1697862684", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 67,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1954, 2, 7, 11, 2, 13, 0, DateTimeKind.Utc), "Rob Brown", "Rob.Brown@theworld.ca", "+988 699928898", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 68,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1915, 9, 6, 10, 41, 44, 0, DateTimeKind.Utc), "Timothy Rodriguez", "Timothy.Rodriguez@nasa.org.us", "+755 265092538", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 69,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1962, 7, 9, 3, 23, 55, 0, DateTimeKind.Utc), "Bobby Davis", "Bobby.Davis@nasa.org.us", "+252 18491224", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 70,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1929, 5, 20, 10, 12, 24, 0, DateTimeKind.Utc), "Jim Williams", "Jim.Williams@gov.gr", "+365 161399808", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 71,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1919, 7, 25, 0, 43, 38, 0, DateTimeKind.Utc), "Jim Baker", "Jim.Baker@theworld.ca", "+265 1817346210", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 72,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1986, 4, 13, 15, 59, 21, 0, DateTimeKind.Utc), "Alice Miller", "Alice.Miller@bbc.co.uk", "+650 575133224", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7567) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 73,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1982, 7, 16, 19, 50, 6, 0, DateTimeKind.Utc), "Jacob Martinez", "Jacob.Martinez@gov.us", "+412 1510806921", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7574) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 74,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1905, 6, 3, 4, 24, 16, 0, DateTimeKind.Utc), "Alice Johnson", "Alice.Johnson@gov.us", "+609 379938515", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 75,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1958, 1, 14, 15, 15, 26, 0, DateTimeKind.Utc), "Ellen Williams", "Ellen.Williams@gov.nl", "+469 247575093", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 76,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1985, 8, 16, 22, 44, 19, 0, DateTimeKind.Utc), "Cid Williams", "Cid.Williams@bbc.co.uk", "+848 1381359352", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 77,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2010, 4, 12, 12, 25, 31, 0, DateTimeKind.Utc), "Will Baker", "Will.Baker@bbc.co.uk", "+569 280400219", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 78,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2014, 6, 25, 15, 30, 33, 0, DateTimeKind.Utc), "William Miller", "William.Miller@gov.ru", "+768 182624658", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 79,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1964, 3, 14, 8, 59, 31, 0, DateTimeKind.Utc), "Rudeus Martinez", "Rudeus.Martinez@google.com", "+757 1500182276", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 80,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2004, 3, 15, 17, 2, 8, 0, DateTimeKind.Utc), "Timothy Johnson", "Timothy.Johnson@theworld.ca", "+321 1400456943", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 81,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1916, 8, 22, 17, 59, 30, 0, DateTimeKind.Utc), "Will Martinez", "Will.Martinez@bbc.co.uk", "+134 1671583919", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 82,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1910, 5, 3, 17, 29, 16, 0, DateTimeKind.Utc), "Cid Brown", "Cid.Brown@gov.gr", "+523 772123202", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 83,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1959, 11, 3, 2, 58, 56, 0, DateTimeKind.Utc), "Elisabeth Rodriguez", "Elisabeth.Rodriguez@theworld.ca", "+994 1612724219", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 84,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1949, 8, 23, 6, 19, 20, 0, DateTimeKind.Utc), "Maria Garcia", "Maria.Garcia@gov.us", "+711 280035215", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 85,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2015, 10, 15, 11, 4, 11, 0, DateTimeKind.Utc), "Alice Miller", "Alice.Miller@gov.ru", "+926 1730777553", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 86,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1920, 2, 27, 6, 23, 32, 0, DateTimeKind.Utc), "Bobby Martinez", "Bobby.Martinez@gov.us", "+203 542565448", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 87,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1937, 10, 3, 8, 22, 52, 0, DateTimeKind.Utc), "Jim Kagenou", "Jim.Kagenou@theworld.ca", "+325 2131243919", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 88,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2002, 1, 8, 22, 51, 54, 0, DateTimeKind.Utc), "William Williams", "William.Williams@tesla.com", "+847 2139114151", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 89,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1916, 3, 5, 5, 16, 44, 0, DateTimeKind.Utc), "Sara Jones", "Sara.Jones@gov.gr", "+108 1438505198", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 90,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2019, 4, 9, 1, 30, 56, 0, DateTimeKind.Utc), "Allen Greyrat", "Allen.Greyrat@theworld.ca", "+143 1303414210", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 91,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1931, 3, 14, 16, 6, 12, 0, DateTimeKind.Utc), "Allen Davis", "Allen.Davis@gov.nl", "+79 2026257695", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 92,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1933, 2, 16, 21, 6, 21, 0, DateTimeKind.Utc), "Rudeus Davis", "Rudeus.Davis@gov.gr", "+889 555443330", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 93,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1958, 11, 20, 14, 54, 48, 0, DateTimeKind.Utc), "Elisabeth Jones", "Elisabeth.Jones@theworld.ca", "+555 540646039", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 94,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2020, 9, 21, 18, 5, 52, 0, DateTimeKind.Utc), "Cid Smith", "Cid.Smith@google.com", "+662 1497672243", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 95,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1920, 7, 23, 7, 9, 34, 0, DateTimeKind.Utc), "Bobby Miller", "Bobby.Miller@gov.us", "+683 515348725", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 96,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1993, 2, 14, 20, 14, 19, 0, DateTimeKind.Utc), "Sara Kagenou", "Sara.Kagenou@gov.gr", "+250 899241604", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 97,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1942, 8, 16, 15, 10, 44, 0, DateTimeKind.Utc), "Jim Greyrat", "Jim.Greyrat@gov.us", "+411 812750916", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 98,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1931, 10, 24, 8, 41, 31, 0, DateTimeKind.Utc), "Elisabeth Davis", "Elisabeth.Davis@tesla.com", "+308 1335684739", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 99,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1976, 1, 27, 14, 28, 16, 0, DateTimeKind.Utc), "Elisabeth Greyrat", "Elisabeth.Greyrat@nasa.org.us", "+578 319425060", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 100,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1984, 11, 2, 1, 49, 4, 0, DateTimeKind.Utc), "Ellen Williams", "Ellen.Williams@google.com", "+922 1219006548", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 101,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1997, 4, 20, 2, 58, 18, 0, DateTimeKind.Utc), "Bob Rodriguez", "Bob.Rodriguez@nasa.org.us", "+200 582382115", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 102,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1988, 7, 5, 20, 0, 34, 0, DateTimeKind.Utc), "Kate Greyrat", "Kate.Greyrat@theworld.ca", "+993 547374224", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 103,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1996, 10, 26, 22, 29, 34, 0, DateTimeKind.Utc), "Audrey Smith", "Audrey.Smith@something.com", "+764 331544314", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 104,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1905, 7, 18, 14, 4, 30, 0, DateTimeKind.Utc), "Jim Brown", "Jim.Brown@gov.nl", "+569 1254603337", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 105,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2024, 6, 8, 3, 44, 14, 0, DateTimeKind.Utc), "Rudeus Baker", "Rudeus.Baker@gov.us", "+284 345387187", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 106,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1977, 8, 3, 23, 46, 12, 0, DateTimeKind.Utc), "Maria Greyrat", "Maria.Greyrat@google.com", "+167 1254763428", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 107,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1947, 9, 3, 18, 33, 11, 0, DateTimeKind.Utc), "William Davis", "William.Davis@gov.nl", "+751 1688875341", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 108,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1904, 6, 3, 6, 41, 5, 0, DateTimeKind.Utc), "Sara Rodriguez", "Sara.Rodriguez@gov.gr", "+708 1981620110", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 109,
                columns: new[] { "created_at", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2018, 4, 2, 22, 38, 2, 0, DateTimeKind.Utc), "Maria.Smith@gov.gr", "+381 528030350", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 110,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1968, 9, 2, 1, 24, 34, 0, DateTimeKind.Utc), "Sara Davis", "Sara.Davis@gov.gr", "+966 80170288", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 111,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1975, 4, 15, 6, 52, 18, 0, DateTimeKind.Utc), "Elisabeth Smith", "Elisabeth.Smith@gov.gr", "+544 1222178496", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 112,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1992, 3, 11, 19, 27, 38, 0, DateTimeKind.Utc), "Audrey Rodriguez", "Audrey.Rodriguez@gov.gr", "+881 1275574516", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 113,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1914, 11, 1, 11, 7, 44, 0, DateTimeKind.Utc), "Bob Miller", "Bob.Miller@gov.nl", "+826 734962344", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 114,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1978, 6, 1, 15, 16, 24, 0, DateTimeKind.Utc), "Audrey Smith", "Audrey.Smith@gov.nl", "+952 609675900", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 115,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1957, 7, 15, 16, 24, 46, 0, DateTimeKind.Utc), "Robert Martinez", "Robert.Martinez@nasa.org.us", "+298 1149963718", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 116,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1984, 1, 25, 14, 28, 24, 0, DateTimeKind.Utc), "Allen Davis", "Allen.Davis@something.com", "+971 68715326", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 117,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2022, 5, 26, 19, 53, 19, 0, DateTimeKind.Utc), "Alice Johnson", "Alice.Johnson@gov.gr", "+928 650658721", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7898) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 118,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1978, 5, 7, 17, 5, 30, 0, DateTimeKind.Utc), "Ellen Rodriguez", "Ellen.Rodriguez@gov.us", "+551 413970198", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 119,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1965, 4, 7, 15, 56, 0, 0, DateTimeKind.Utc), "Timothy Smith", "Timothy.Smith@gov.gr", "+703 869445313", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 120,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1950, 1, 24, 22, 35, 52, 0, DateTimeKind.Utc), "Ellen Miller", "Ellen.Miller@tesla.com", "+645 1938740760", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 121,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1987, 10, 9, 19, 59, 35, 0, DateTimeKind.Utc), "Robert Garcia", "Robert.Garcia@bbc.co.uk", "+658 1950833653", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 122,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1930, 11, 15, 7, 2, 13, 0, DateTimeKind.Utc), "Elisabeth Baker", "Elisabeth.Baker@bbc.co.uk", "+222 669285701", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 123,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1904, 2, 8, 9, 11, 34, 0, DateTimeKind.Utc), "Jacob Kagenou", "Jacob.Kagenou@tesla.com", "+202 04184392", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 124,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1947, 9, 12, 10, 8, 30, 0, DateTimeKind.Utc), "Robert Baker", "Robert.Baker@nasa.org.us", "+436 1365652074", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 125,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1923, 3, 20, 1, 54, 5, 0, DateTimeKind.Utc), "Jacob Miller", "Jacob.Miller@gov.us", "+892 739476145", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 126,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1983, 3, 18, 22, 9, 33, 0, DateTimeKind.Utc), "Rudeus Jones", "Rudeus.Jones@bbc.co.uk", "+612 1183768233", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 127,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1952, 11, 15, 16, 14, 53, 0, DateTimeKind.Utc), "Rob Brown", "Rob.Brown@gov.gr", "+738 179077025", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 128,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1938, 10, 13, 17, 55, 7, 0, DateTimeKind.Utc), "Bob Martinez", "Bob.Martinez@gov.nl", "+17 1907555139", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 129,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2011, 6, 3, 5, 54, 49, 0, DateTimeKind.Utc), "Timothy Johnson", "Timothy.Johnson@gov.nl", "+974 261505656", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 130,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1981, 1, 16, 23, 33, 47, 0, DateTimeKind.Utc), "Will Williams", "Will.Williams@bbc.co.uk", "+466 1152616939", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 131,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1995, 4, 11, 23, 44, 40, 0, DateTimeKind.Utc), "Jim Brown", "Jim.Brown@gov.us", "+940 385887568", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 132,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1902, 5, 20, 17, 36, 28, 0, DateTimeKind.Utc), "Audrey Garcia", "Audrey.Garcia@google.com", "+280 302641443", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 133,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1970, 6, 6, 16, 9, 33, 0, DateTimeKind.Utc), "Audrey Johnson", "Audrey.Johnson@nasa.org.us", "+295 1040560966", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 134,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1972, 7, 23, 23, 16, 23, 0, DateTimeKind.Utc), "Sara Kagenou", "Sara.Kagenou@bbc.co.uk", "+645 1148261802", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 135,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1943, 5, 8, 13, 4, 0, 0, DateTimeKind.Utc), "Bobby Smith", "Bobby.Smith@gov.ru", "+96 1818196454", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 136,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1993, 11, 19, 2, 27, 42, 0, DateTimeKind.Utc), "Cid Smith", "Cid.Smith@gov.gr", "+91 46108090", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 137,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1946, 2, 20, 13, 34, 8, 0, DateTimeKind.Utc), "Maria Jones", "Maria.Jones@bbc.co.uk", "+403 1576935112", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 138,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1982, 7, 16, 9, 58, 45, 0, DateTimeKind.Utc), "Robert Williams", "Robert.Williams@gov.us", "+915 70900378", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 139,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2017, 5, 28, 1, 11, 11, 0, DateTimeKind.Utc), "Bobby Jones", "Bobby.Jones@gov.nl", "+656 1012170688", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 140,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1912, 7, 24, 16, 18, 37, 0, DateTimeKind.Utc), "Cid Baker", "Cid.Baker@gov.nl", "+93 1271813406", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 141,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1979, 1, 28, 2, 21, 16, 0, DateTimeKind.Utc), "Bobby Johnson", "Bobby.Johnson@tesla.com", "+692 359372214", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 142,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1930, 6, 2, 3, 45, 5, 0, DateTimeKind.Utc), "Audrey Rodriguez", "Audrey.Rodriguez@tesla.com", "+917 1776428001", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 143,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2009, 11, 16, 9, 27, 48, 0, DateTimeKind.Utc), "Sara Greyrat", "Sara.Greyrat@theworld.ca", "+751 1479134732", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 144,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1997, 10, 27, 1, 20, 6, 0, DateTimeKind.Utc), "Elisabeth Smith", "Elisabeth.Smith@theworld.ca", "+664 51474434", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 145,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1922, 3, 22, 4, 53, 42, 0, DateTimeKind.Utc), "Bob Smith", "Bob.Smith@google.com", "+194 06126308", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 146,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1924, 6, 20, 10, 56, 16, 0, DateTimeKind.Utc), "Allen Miller", "Allen.Miller@gov.us", "+290 15797183", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 147,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1990, 8, 3, 2, 0, 34, 0, DateTimeKind.Utc), "Audrey Baker", "Audrey.Baker@gov.ru", "+02 907915769", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 148,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2017, 4, 10, 11, 39, 12, 0, DateTimeKind.Utc), "Cid Johnson", "Cid.Johnson@gov.us", "+362 1963212750", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 149,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1906, 7, 27, 4, 57, 33, 0, DateTimeKind.Utc), "Jacob Baker", "Jacob.Baker@gov.nl", "+393 37733873", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 150,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1941, 5, 6, 2, 10, 19, 0, DateTimeKind.Utc), "Audrey Greyrat", "Audrey.Greyrat@gov.gr", "+144 629726137", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 151,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1902, 8, 25, 20, 59, 4, 0, DateTimeKind.Utc), "Audrey Williams", "Audrey.Williams@gov.gr", "+763 719704611", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8176) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 152,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1974, 6, 21, 19, 18, 59, 0, DateTimeKind.Utc), "Will Miller", "Will.Miller@gov.gr", "+468 1157749908", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 153,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1933, 4, 23, 8, 55, 28, 0, DateTimeKind.Utc), "Elisabeth Baker", "Elisabeth.Baker@tesla.com", "+758 1888902111", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 154,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1935, 1, 18, 11, 22, 13, 0, DateTimeKind.Utc), "Jacob Kagenou", "Jacob.Kagenou@gov.us", "+278 528403085", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 155,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1935, 2, 8, 2, 5, 12, 0, DateTimeKind.Utc), "Jacob Davis", "Jacob.Davis@gov.ru", "+173 1658142946", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 156,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1992, 4, 23, 4, 10, 20, 0, DateTimeKind.Utc), "Timothy Martinez", "Timothy.Martinez@gov.us", "+803 1829950874", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8207) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 157,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1969, 11, 24, 23, 35, 26, 0, DateTimeKind.Utc), "Bob Garcia", "Bob.Garcia@bbc.co.uk", "+214 1689454544", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 158,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1905, 2, 28, 14, 6, 35, 0, DateTimeKind.Utc), "Timothy Greyrat", "Timothy.Greyrat@something.com", "+196 1604722295", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 159,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1903, 11, 16, 0, 46, 27, 0, DateTimeKind.Utc), "Audrey Williams", "Audrey.Williams@gov.ru", "+769 1424822642", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 160,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1934, 9, 28, 6, 37, 53, 0, DateTimeKind.Utc), "Sara Johnson", "Sara.Johnson@gov.gr", "+10 1117616666", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 161,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1944, 10, 26, 3, 17, 40, 0, DateTimeKind.Utc), "Rob Brown", "Rob.Brown@gov.ru", "+634 980052189", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 162,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1990, 9, 12, 5, 39, 31, 0, DateTimeKind.Utc), "Elisabeth Miller", "Elisabeth.Miller@something.com", "+529 195944236", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 163,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2003, 2, 2, 8, 53, 32, 0, DateTimeKind.Utc), "Kate Brown", "Kate.Brown@gov.gr", "+758 1198620244", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8252) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 164,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1902, 6, 25, 22, 10, 59, 0, DateTimeKind.Utc), "Sara Smith", "Sara.Smith@gov.us", "+639 105550845", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 165,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1928, 6, 7, 21, 9, 8, 0, DateTimeKind.Utc), "Cid Greyrat", "Cid.Greyrat@tesla.com", "+933 98544447", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 166,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2015, 11, 5, 19, 45, 29, 0, DateTimeKind.Utc), "Jacob Kagenou", "Jacob.Kagenou@nasa.org.us", "+904 2141391243", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 167,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1923, 3, 12, 13, 13, 20, 0, DateTimeKind.Utc), "Alice Garcia", "Alice.Garcia@gov.ru", "+933 1173182345", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 168,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1922, 4, 22, 8, 22, 30, 0, DateTimeKind.Utc), "Elisabeth Miller", "Elisabeth.Miller@something.com", "+849 785635547", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 169,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1926, 1, 18, 17, 42, 11, 0, DateTimeKind.Utc), "Robert Miller", "Robert.Miller@gov.nl", "+934 477131027", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 170,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1924, 10, 23, 4, 33, 25, 0, DateTimeKind.Utc), "Sara Jones", "Sara.Jones@tesla.com", "+715 719694674", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8296) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 171,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2002, 9, 13, 2, 1, 41, 0, DateTimeKind.Utc), "Rudeus Jones", "Rudeus.Jones@gov.us", "+688 936674321", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 172,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1935, 11, 5, 23, 44, 33, 0, DateTimeKind.Utc), "Bob Smith", "Bob.Smith@tesla.com", "+823 883447660", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 173,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2005, 5, 16, 12, 50, 21, 0, DateTimeKind.Utc), "Maria Rodriguez", "Maria.Rodriguez@gov.gr", "+264 1814146348", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 174,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1964, 5, 26, 10, 8, 21, 0, DateTimeKind.Utc), "Jim Miller", "Jim.Miller@gov.ru", "+150 943656263", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8322) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 175,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2013, 7, 15, 23, 57, 27, 0, DateTimeKind.Utc), "Bob Davis", "Bob.Davis@tesla.com", "+760 789423022", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 176,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1992, 8, 3, 15, 9, 34, 0, DateTimeKind.Utc), "Audrey Smith", "Audrey.Smith@google.com", "+340 708445291", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 177,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1926, 11, 9, 15, 12, 14, 0, DateTimeKind.Utc), "Jacob Davis", "Jacob.Davis@bbc.co.uk", "+178 1085147353", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 178,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1990, 5, 28, 12, 57, 18, 0, DateTimeKind.Utc), "Alice Baker", "Alice.Baker@google.com", "+612 1396736560", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 179,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1956, 8, 24, 8, 21, 22, 0, DateTimeKind.Utc), "Audrey Johnson", "Audrey.Johnson@something.com", "+761 441923371", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 180,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1974, 1, 14, 14, 50, 39, 0, DateTimeKind.Utc), "Will Garcia", "Will.Garcia@tesla.com", "+188 1405711339", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 181,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1921, 1, 14, 23, 30, 8, 0, DateTimeKind.Utc), "Maria Johnson", "Maria.Johnson@google.com", "+723 482642556", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 182,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1988, 5, 4, 1, 3, 19, 0, DateTimeKind.Utc), "Robert Smith", "Robert.Smith@bbc.co.uk", "+642 381861454", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 183,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1917, 2, 13, 0, 9, 28, 0, DateTimeKind.Utc), "Sara Miller", "Sara.Miller@bbc.co.uk", "+390 226778589", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 184,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1944, 7, 20, 16, 18, 2, 0, DateTimeKind.Utc), "Will Williams", "Will.Williams@bbc.co.uk", "+750 1440047339", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8422) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 185,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1941, 6, 4, 22, 41, 31, 0, DateTimeKind.Utc), "Jim Miller", "Jim.Miller@google.com", "+762 1900278518", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8429) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 186,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1986, 2, 16, 13, 27, 32, 0, DateTimeKind.Utc), "Kate Rodriguez", "Kate.Rodriguez@google.com", "+685 2084337528", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8435) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 187,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1915, 2, 27, 16, 52, 10, 0, DateTimeKind.Utc), "Rudeus Johnson", "Rudeus.Johnson@something.com", "+549 704411810", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 188,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1971, 8, 4, 1, 11, 56, 0, DateTimeKind.Utc), "Bobby Baker", "Bobby.Baker@gov.us", "+411 61019613", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 189,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1943, 7, 7, 3, 43, 2, 0, DateTimeKind.Utc), "Maria Rodriguez", "Maria.Rodriguez@google.com", "+536 1682596782", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 190,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1972, 4, 7, 0, 15, 39, 0, DateTimeKind.Utc), "Kate Greyrat", "Kate.Greyrat@tesla.com", "+663 821193430", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 191,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1982, 11, 20, 6, 24, 41, 0, DateTimeKind.Utc), "Kate Greyrat", "Kate.Greyrat@bbc.co.uk", "+518 707544365", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 192,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(2014, 3, 3, 21, 19, 53, 0, DateTimeKind.Utc), "Robert Smith", "Robert.Smith@gov.ru", "+861 1471597086", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 193,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1948, 6, 5, 16, 11, 37, 0, DateTimeKind.Utc), "Elisabeth Kagenou", "Elisabeth.Kagenou@tesla.com", "+955 1832993378", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 194,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1922, 2, 6, 6, 39, 33, 0, DateTimeKind.Utc), "Rudeus Kagenou", "Rudeus.Kagenou@nasa.org.us", "+226 952646469", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8486) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 195,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1934, 11, 25, 8, 36, 23, 0, DateTimeKind.Utc), "William Davis", "William.Davis@gov.ru", "+544 190996842", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 196,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1912, 5, 4, 13, 9, 58, 0, DateTimeKind.Utc), "Ellen Baker", "Ellen.Baker@gov.ru", "+87 1198620986", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8498) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 197,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1967, 8, 26, 11, 16, 5, 0, DateTimeKind.Utc), "Audrey Rodriguez", "Audrey.Rodriguez@nasa.org.us", "+800 1886068305", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 198,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1966, 7, 15, 17, 1, 34, 0, DateTimeKind.Utc), "Elisabeth Williams", "Elisabeth.Williams@gov.gr", "+731 30422213", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8511) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 199,
                columns: new[] { "created_at", "name", "email", "phoneNumber", "updated_at" },
                values: new object[] { new DateTime(1912, 2, 28, 10, 46, 53, 0, DateTimeKind.Utc), "Audrey Martinez", "Audrey.Martinez@tesla.com", "+307 843653552", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 1,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2016, 8, 21, 0, 0, 0, 0, DateTimeKind.Utc), "NC-17", 121, "A Flimsy Building", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 2,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2016, 2, 20, 0, 0, 0, 0, DateTimeKind.Utc), "NC-17", 171, " Happy Cat", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 3,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), "PG", 95, " Happy Bread", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 4,
                columns: new[] { "created_at", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Utc), 342, " Mystical Building", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 5,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2008, 3, 17, 0, 0, 0, 0, DateTimeKind.Utc), "PG-13", 240, " Flimsy Woman", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 6,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2014, 5, 20, 0, 0, 0, 0, DateTimeKind.Utc), "R", 128, "A Depressed Bread", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 7,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2016, 4, 11, 0, 0, 0, 0, DateTimeKind.Utc), "NC-17", 263, " Sad Cat", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 8,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Utc), "NC-17", 294, "The Obtuse Computer", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 9,
                columns: new[] { "created_at", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2004, 4, 11, 0, 0, 0, 0, DateTimeKind.Utc), 366, "A Legendary Car", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 10,
                columns: new[] { "created_at", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2010, 4, 15, 0, 0, 0, 0, DateTimeKind.Utc), 300, " Happy Airplane", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 11,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2016, 4, 3, 0, 0, 0, 0, DateTimeKind.Utc), "PG", 312, "The Depressed Man", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 12,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Utc), "PG", 149, " Depressing Computer", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6897) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 13,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2019, 4, 23, 0, 0, 0, 0, DateTimeKind.Utc), "R", 98, " Stubborn Woman", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 14,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2005, 7, 24, 0, 0, 0, 0, DateTimeKind.Utc), "NC-17", 197, "A Sad Dog", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 15,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Utc), "PG-13", 428, " Fantastical Airplane", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 16,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2016, 10, 5, 0, 0, 0, 0, DateTimeKind.Utc), "G", 414, "The Flimsy Goose", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 17,
                columns: new[] { "created_at", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2012, 4, 24, 0, 0, 0, 0, DateTimeKind.Utc), 227, "The Happy Bread", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 18,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2015, 11, 11, 0, 0, 0, 0, DateTimeKind.Utc), "R", 157, " Legendary Man", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movie_id",
                keyValue: 19,
                columns: new[] { "created_at", "rating", "runtime_minutes", "title", "updated_at" },
                values: new object[] { new DateTime(2015, 8, 8, 0, 0, 0, 0, DateTimeKind.Utc), "G", 257, "The Fantastical Woman", new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 1,
                columns: new[] { "capacity", "created_at", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 24, new DateTime(1972, 5, 26, 11, 1, 46, 0, DateTimeKind.Utc), 5, new DateTime(1972, 6, 6, 15, 1, 46, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8533) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 2,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 15, new DateTime(1910, 6, 16, 11, 11, 44, 0, DateTimeKind.Utc), 6, 1, new DateTime(1910, 6, 18, 20, 11, 44, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8539) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 3,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 15, new DateTime(1914, 6, 25, 8, 53, 39, 0, DateTimeKind.Utc), 13, 1, new DateTime(1914, 7, 2, 12, 53, 39, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 4,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 52, new DateTime(1907, 2, 12, 0, 50, 18, 0, DateTimeKind.Utc), 11, 18, new DateTime(1907, 3, 10, 22, 50, 18, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 5,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 23, new DateTime(1958, 5, 18, 5, 13, 14, 0, DateTimeKind.Utc), 11, 16, new DateTime(1958, 5, 28, 3, 13, 14, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 6,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 73, new DateTime(1944, 3, 19, 15, 49, 11, 0, DateTimeKind.Utc), 15, 6, new DateTime(1944, 3, 25, 7, 49, 11, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8553) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 7,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 29, new DateTime(1905, 9, 14, 7, 49, 30, 0, DateTimeKind.Utc), 19, 14, new DateTime(1905, 9, 30, 16, 49, 30, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 8,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 62, new DateTime(1990, 11, 26, 7, 17, 24, 0, DateTimeKind.Utc), 14, 10, new DateTime(1990, 12, 19, 23, 17, 24, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 9,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 73, new DateTime(1998, 6, 17, 18, 38, 11, 0, DateTimeKind.Utc), 18, 6, new DateTime(1998, 7, 5, 0, 38, 11, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 10,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 62, new DateTime(1918, 8, 8, 3, 34, 31, 0, DateTimeKind.Utc), 18, 10, new DateTime(1918, 8, 27, 12, 34, 31, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 11,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 25, new DateTime(1931, 1, 22, 7, 48, 46, 0, DateTimeKind.Utc), 13, 2, new DateTime(1931, 2, 6, 23, 48, 46, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8569) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 12,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 38, new DateTime(1963, 1, 13, 22, 32, 42, 0, DateTimeKind.Utc), 12, 12, new DateTime(1963, 1, 31, 6, 32, 42, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8573) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 13,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 42, new DateTime(1992, 4, 11, 2, 28, 24, 0, DateTimeKind.Utc), 11, 13, new DateTime(1992, 4, 11, 16, 28, 24, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 14,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 23, new DateTime(1982, 2, 10, 23, 30, 21, 0, DateTimeKind.Utc), 12, 16, new DateTime(1982, 2, 17, 20, 30, 21, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 15,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 62, new DateTime(1997, 11, 12, 18, 51, 58, 0, DateTimeKind.Utc), 12, 15, new DateTime(1997, 11, 26, 11, 51, 58, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 16,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 62, new DateTime(1903, 1, 15, 20, 37, 30, 0, DateTimeKind.Utc), 5, 10, new DateTime(1903, 1, 22, 15, 37, 30, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 17,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 23, new DateTime(1967, 3, 5, 11, 57, 44, 0, DateTimeKind.Utc), 7, 16, new DateTime(1967, 3, 10, 21, 57, 44, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 18,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 42, new DateTime(1924, 5, 6, 7, 9, 0, 0, DateTimeKind.Utc), 16, 13, new DateTime(1924, 5, 24, 20, 9, 0, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 19,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 92, new DateTime(1955, 2, 22, 10, 17, 26, 0, DateTimeKind.Utc), 8, 8, new DateTime(1955, 3, 5, 14, 17, 26, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 20,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 8, new DateTime(1917, 7, 20, 15, 20, 18, 0, DateTimeKind.Utc), 10, 9, new DateTime(1917, 8, 5, 6, 20, 18, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 21,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 15, new DateTime(1968, 6, 19, 21, 1, 31, 0, DateTimeKind.Utc), 19, 1, new DateTime(1968, 6, 27, 14, 1, 31, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8627) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 22,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 73, new DateTime(1934, 7, 7, 8, 44, 55, 0, DateTimeKind.Utc), 8, 6, new DateTime(1934, 8, 4, 7, 44, 55, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 23,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 62, new DateTime(1987, 5, 27, 10, 46, 34, 0, DateTimeKind.Utc), 6, 15, new DateTime(1987, 6, 25, 11, 46, 34, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 24,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 62, new DateTime(2005, 10, 26, 18, 15, 8, 0, DateTimeKind.Utc), 18, 15, new DateTime(2005, 11, 16, 4, 15, 8, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 25,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 52, new DateTime(1939, 6, 8, 9, 34, 46, 0, DateTimeKind.Utc), 8, 11, new DateTime(1939, 7, 5, 18, 34, 46, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 26,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 38, new DateTime(1975, 6, 9, 17, 17, 39, 0, DateTimeKind.Utc), 19, 12, new DateTime(1975, 6, 20, 4, 17, 39, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8644) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 27,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 32, new DateTime(2002, 9, 24, 9, 8, 27, 0, DateTimeKind.Utc), 6, 4, new DateTime(2002, 10, 23, 19, 8, 27, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 28,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 92, new DateTime(1983, 4, 18, 0, 12, 45, 0, DateTimeKind.Utc), 7, 8, new DateTime(1983, 5, 6, 1, 12, 45, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 29,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 92, new DateTime(1990, 10, 9, 14, 53, 22, 0, DateTimeKind.Utc), 5, 8, new DateTime(1990, 10, 26, 6, 53, 22, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 30,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 24, new DateTime(1955, 10, 5, 9, 47, 58, 0, DateTimeKind.Utc), 4, 5, new DateTime(1955, 10, 5, 20, 47, 58, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 31,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 32, new DateTime(2003, 8, 16, 19, 43, 58, 0, DateTimeKind.Utc), 7, 4, new DateTime(2003, 8, 17, 21, 43, 58, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 32,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 24, new DateTime(1921, 6, 1, 7, 53, 25, 0, DateTimeKind.Utc), 2, 5, new DateTime(1921, 6, 1, 10, 53, 25, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 33,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 24, new DateTime(1962, 11, 9, 14, 50, 49, 0, DateTimeKind.Utc), 14, 5, new DateTime(1962, 12, 5, 12, 50, 49, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 34,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 29, new DateTime(1903, 2, 6, 22, 32, 24, 0, DateTimeKind.Utc), 10, 14, new DateTime(1903, 3, 6, 19, 32, 24, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 35,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 15, new DateTime(1963, 5, 18, 14, 44, 52, 0, DateTimeKind.Utc), 5, 1, new DateTime(1963, 5, 19, 22, 44, 52, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 36,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 15, new DateTime(1902, 9, 10, 4, 44, 37, 0, DateTimeKind.Utc), 14, 1, new DateTime(1902, 10, 4, 9, 44, 37, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 37,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 73, new DateTime(2012, 6, 15, 19, 18, 8, 0, DateTimeKind.Utc), 6, 6, new DateTime(2012, 7, 8, 4, 18, 8, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 38,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 73, new DateTime(1910, 4, 2, 21, 46, 44, 0, DateTimeKind.Utc), 6, 3, new DateTime(1910, 4, 16, 15, 46, 44, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 39,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 52, new DateTime(1986, 8, 24, 17, 58, 39, 0, DateTimeKind.Utc), 7, 18, new DateTime(1986, 9, 17, 23, 58, 39, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 40,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 22, new DateTime(2022, 4, 23, 5, 3, 12, 0, DateTimeKind.Utc), 15, 7, new DateTime(2022, 5, 3, 8, 3, 12, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 41,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 52, new DateTime(1930, 11, 8, 21, 23, 51, 0, DateTimeKind.Utc), 11, 11, new DateTime(1930, 11, 12, 14, 23, 51, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 42,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 79, new DateTime(2014, 3, 4, 1, 8, 47, 0, DateTimeKind.Utc), 9, 20, new DateTime(2014, 3, 7, 0, 8, 47, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 43,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 23, new DateTime(1992, 5, 4, 13, 33, 5, 0, DateTimeKind.Utc), 7, 16, new DateTime(1992, 5, 12, 6, 33, 5, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 44,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 72, new DateTime(1931, 7, 21, 19, 53, 53, 0, DateTimeKind.Utc), 14, 19, new DateTime(1931, 7, 24, 22, 53, 53, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 45,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 23, new DateTime(1980, 11, 25, 2, 59, 38, 0, DateTimeKind.Utc), 12, 16, new DateTime(1980, 12, 23, 17, 59, 38, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8703) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 46,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 67, new DateTime(1937, 8, 28, 17, 20, 58, 0, DateTimeKind.Utc), 19, 17, new DateTime(1937, 9, 11, 10, 20, 58, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 47,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 79, new DateTime(1927, 9, 9, 18, 53, 11, 0, DateTimeKind.Utc), 1, 20, new DateTime(1927, 9, 29, 5, 53, 11, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 48,
                columns: new[] { "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { new DateTime(1903, 3, 26, 8, 10, 12, 0, DateTimeKind.Utc), 14, 10, new DateTime(1903, 4, 13, 1, 10, 12, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "screening_id",
                keyValue: 49,
                columns: new[] { "capacity", "created_at", "movie_id", "screen_numbers", "startsAt", "updated_at" },
                values: new object[] { 32, new DateTime(1901, 2, 16, 6, 10, 49, 0, DateTimeKind.Utc), 13, 4, new DateTime(1901, 2, 16, 16, 10, 49, 0, DateTimeKind.Utc), new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 2,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1927, 4, 13, 20, 39, 45, 0, DateTimeKind.Utc), 198, 2, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 3,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1908, 2, 23, 4, 32, 43, 0, DateTimeKind.Utc), 113, 1, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 4,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1954, 11, 4, 0, 30, 42, 0, DateTimeKind.Utc), 190, 2, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 5,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1908, 7, 4, 20, 45, 25, 0, DateTimeKind.Utc), 191, 2, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 6,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1972, 6, 13, 10, 20, 38, 0, DateTimeKind.Utc), 166, 1, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 7,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1975, 10, 8, 1, 47, 32, 0, DateTimeKind.Utc), 32, 3, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 8,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1907, 2, 9, 7, 59, 1, 0, DateTimeKind.Utc), 100, 1, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 9,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1985, 8, 15, 5, 39, 27, 0, DateTimeKind.Utc), 66, 3, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 10,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1934, 3, 20, 0, 9, 49, 0, DateTimeKind.Utc), 163, 1, 3, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 11,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1899, 7, 26, 1, 32, 51, 0, DateTimeKind.Utc), 65, 4, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 12,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1979, 4, 14, 17, 59, 33, 0, DateTimeKind.Utc), 23, 2, 4, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 13,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1909, 2, 8, 17, 41, 0, 0, DateTimeKind.Utc), 128, 4, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 14,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1947, 9, 6, 14, 36, 4, 0, DateTimeKind.Utc), 83, 2, 4, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 15,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1931, 7, 20, 7, 51, 9, 0, DateTimeKind.Utc), 87, 1, 4, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 16,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1943, 4, 3, 1, 31, 36, 0, DateTimeKind.Utc), 124, 3, 4, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 17,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2021, 6, 22, 6, 49, 59, 0, DateTimeKind.Utc), 146, 2, 4, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 18,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1987, 3, 15, 13, 51, 11, 0, DateTimeKind.Utc), 177, 1, 4, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 19,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1947, 10, 11, 9, 15, 42, 0, DateTimeKind.Utc), 27, 2, 5, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 20,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1975, 9, 9, 7, 53, 29, 0, DateTimeKind.Utc), 95, 3, 5, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 21,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2023, 4, 4, 5, 6, 19, 0, DateTimeKind.Utc), 45, 2, 5, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 22,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1907, 1, 2, 20, 7, 57, 0, DateTimeKind.Utc), 86, 5, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 23,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1948, 4, 22, 20, 21, 4, 0, DateTimeKind.Utc), 186, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 24,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1918, 1, 13, 10, 53, 43, 0, DateTimeKind.Utc), 8, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 25,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1990, 10, 7, 23, 6, 25, 0, DateTimeKind.Utc), 39, 1, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 26,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1966, 11, 17, 4, 35, 8, 0, DateTimeKind.Utc), 18, 6, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 27,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2012, 11, 13, 2, 55, 37, 0, DateTimeKind.Utc), 15, 6, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 28,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1948, 4, 3, 2, 1, 40, 0, DateTimeKind.Utc), 185, 3, 6, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 29,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1965, 9, 8, 3, 5, 48, 0, DateTimeKind.Utc), 70, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 30,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1992, 1, 14, 0, 9, 21, 0, DateTimeKind.Utc), 46, 2, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 31,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1965, 5, 10, 23, 36, 10, 0, DateTimeKind.Utc), 57, 2, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 32,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(2010, 3, 18, 22, 55, 46, 0, DateTimeKind.Utc), 140, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 33,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1967, 7, 26, 6, 4, 26, 0, DateTimeKind.Utc), 69, 3, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 34,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1983, 9, 8, 20, 4, 35, 0, DateTimeKind.Utc), 130, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 35,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1963, 3, 1, 8, 45, 33, 0, DateTimeKind.Utc), 61, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 36,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1974, 2, 28, 2, 51, 37, 0, DateTimeKind.Utc), 65, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 37,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1941, 8, 12, 5, 45, 6, 0, DateTimeKind.Utc), 121, 3, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 38,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1917, 9, 20, 10, 33, 43, 0, DateTimeKind.Utc), 11, 3, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 39,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1981, 11, 6, 8, 38, 31, 0, DateTimeKind.Utc), 66, 3, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 40,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1907, 5, 22, 11, 11, 8, 0, DateTimeKind.Utc), 74, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 41,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1957, 8, 3, 5, 45, 23, 0, DateTimeKind.Utc), 98, 2, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 42,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1957, 11, 7, 15, 17, 59, 0, DateTimeKind.Utc), 104, 3, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 43,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1993, 4, 11, 14, 33, 51, 0, DateTimeKind.Utc), 181, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 44,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1996, 4, 5, 22, 55, 44, 0, DateTimeKind.Utc), 66, 3, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 45,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1912, 9, 19, 11, 2, 38, 0, DateTimeKind.Utc), 46, 1, 6, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 46,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1987, 9, 18, 6, 48, 6, 0, DateTimeKind.Utc), 100, 1, 6, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 47,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1992, 11, 7, 12, 6, 24, 0, DateTimeKind.Utc), 77, 1, 7, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 48,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1935, 2, 9, 2, 3, 19, 0, DateTimeKind.Utc), 79, 1, 7, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 49,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1943, 3, 6, 21, 40, 20, 0, DateTimeKind.Utc), 67, 2, 7, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 50,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1906, 9, 25, 22, 19, 17, 0, DateTimeKind.Utc), 141, 3, 7, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 51,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1922, 5, 2, 7, 1, 45, 0, DateTimeKind.Utc), 5, 2, 7, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 52,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1915, 6, 27, 1, 4, 2, 0, DateTimeKind.Utc), 191, 1, 7, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 53,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2017, 9, 15, 23, 14, 12, 0, DateTimeKind.Utc), 80, 8, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 54,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1904, 6, 18, 0, 59, 50, 0, DateTimeKind.Utc), 34, 8, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 55,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2019, 11, 16, 11, 31, 14, 0, DateTimeKind.Utc), 188, 1, 8, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 56,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1937, 4, 2, 4, 15, 2, 0, DateTimeKind.Utc), 6, 8, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 57,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2015, 5, 4, 3, 21, 26, 0, DateTimeKind.Utc), 151, 8, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 58,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1944, 2, 3, 20, 36, 15, 0, DateTimeKind.Utc), 96, 3, 8, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 59,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2018, 3, 5, 3, 17, 47, 0, DateTimeKind.Utc), 18, 2, 8, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 60,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1954, 5, 7, 20, 47, 27, 0, DateTimeKind.Utc), 134, 1, 8, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 61,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2011, 11, 9, 6, 25, 15, 0, DateTimeKind.Utc), 124, 3, 8, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 62,
                columns: new[] { "created_at", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1921, 2, 5, 16, 40, 1, 0, DateTimeKind.Utc), 8, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 63,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2008, 10, 22, 19, 26, 16, 0, DateTimeKind.Utc), 63, 1, 8, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 64,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1967, 8, 15, 13, 48, 15, 0, DateTimeKind.Utc), 136, 1, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 65,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1988, 3, 28, 22, 49, 7, 0, DateTimeKind.Utc), 99, 2, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 66,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1997, 4, 18, 19, 26, 45, 0, DateTimeKind.Utc), 180, 2, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 67,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1955, 4, 4, 1, 9, 25, 0, DateTimeKind.Utc), 21, 2, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 68,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1923, 3, 28, 13, 32, 54, 0, DateTimeKind.Utc), 199, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 69,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1934, 11, 11, 4, 24, 32, 0, DateTimeKind.Utc), 17, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 70,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1950, 11, 14, 23, 44, 14, 0, DateTimeKind.Utc), 84, 9, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 71,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2022, 2, 10, 0, 40, 34, 0, DateTimeKind.Utc), 32, 9, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 72,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1968, 2, 24, 22, 8, 23, 0, DateTimeKind.Utc), 56, 2, 9, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 73,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2018, 9, 4, 14, 34, 25, 0, DateTimeKind.Utc), 66, 1, 9, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 74,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1985, 10, 8, 21, 10, 26, 0, DateTimeKind.Utc), 139, 2, 9, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 75,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2012, 7, 11, 3, 5, 38, 0, DateTimeKind.Utc), 29, 2, 9, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 76,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1998, 11, 1, 9, 11, 59, 0, DateTimeKind.Utc), 177, 9, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 77,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1998, 9, 1, 4, 2, 49, 0, DateTimeKind.Utc), 185, 3, 9, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 78,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2008, 6, 13, 11, 41, 18, 0, DateTimeKind.Utc), 23, 9, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 79,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1899, 6, 27, 8, 41, 30, 0, DateTimeKind.Utc), 147, 9, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 80,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1916, 11, 10, 3, 12, 21, 0, DateTimeKind.Utc), 11, 9, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 81,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1990, 2, 1, 11, 1, 23, 0, DateTimeKind.Utc), 55, 1, 9, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 82,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1908, 5, 26, 7, 14, 16, 0, DateTimeKind.Utc), 197, 9, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 83,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2016, 3, 7, 11, 30, 45, 0, DateTimeKind.Utc), 186, 1, 9, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 84,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1979, 8, 11, 18, 3, 5, 0, DateTimeKind.Utc), 26, 2, 10, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 85,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1927, 9, 22, 5, 33, 32, 0, DateTimeKind.Utc), 80, 2, 10, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 86,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1991, 7, 11, 18, 32, 37, 0, DateTimeKind.Utc), 17, 2, 10, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 87,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1914, 11, 13, 4, 45, 46, 0, DateTimeKind.Utc), 172, 1, 10, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 88,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1975, 6, 27, 22, 34, 12, 0, DateTimeKind.Utc), 17, 10, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 89,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2005, 5, 20, 12, 5, 20, 0, DateTimeKind.Utc), 196, 2, 10, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 90,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2008, 6, 9, 10, 5, 12, 0, DateTimeKind.Utc), 58, 3, 10, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 91,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1934, 9, 27, 17, 12, 14, 0, DateTimeKind.Utc), 155, 10, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 92,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2011, 2, 25, 2, 20, 52, 0, DateTimeKind.Utc), 107, 10, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 93,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1931, 3, 27, 3, 16, 36, 0, DateTimeKind.Utc), 124, 2, 10, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 94,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2022, 3, 20, 15, 20, 40, 0, DateTimeKind.Utc), 43, 1, 10, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 95,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1904, 6, 12, 14, 28, 18, 0, DateTimeKind.Utc), 69, 10, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 96,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1984, 5, 24, 18, 16, 35, 0, DateTimeKind.Utc), 155, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 97,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1958, 10, 21, 18, 55, 13, 0, DateTimeKind.Utc), 13, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 98,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(2010, 11, 27, 1, 26, 41, 0, DateTimeKind.Utc), 101, 1, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 99,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1951, 4, 8, 5, 14, 39, 0, DateTimeKind.Utc), 70, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 100,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1980, 2, 28, 10, 7, 48, 0, DateTimeKind.Utc), 181, 3, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 101,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1937, 7, 2, 9, 34, 8, 0, DateTimeKind.Utc), 99, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 102,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2002, 1, 28, 18, 54, 30, 0, DateTimeKind.Utc), 27, 2, 12, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 103,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1948, 4, 7, 6, 17, 37, 0, DateTimeKind.Utc), 151, 2, 12, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 104,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1970, 6, 24, 2, 6, 33, 0, DateTimeKind.Utc), 124, 12, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9058) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 105,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2013, 3, 8, 5, 58, 10, 0, DateTimeKind.Utc), 107, 1, 12, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9061) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 106,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1929, 2, 5, 6, 7, 45, 0, DateTimeKind.Utc), 86, 1, 12, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 107,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1911, 9, 22, 14, 48, 11, 0, DateTimeKind.Utc), 108, 1, 13, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 108,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1929, 10, 5, 3, 26, 53, 0, DateTimeKind.Utc), 140, 13, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 109,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1930, 6, 2, 1, 48, 19, 0, DateTimeKind.Utc), 183, 13, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9074) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 110,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1937, 5, 26, 9, 35, 34, 0, DateTimeKind.Utc), 199, 1, 14, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9077) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 111,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1936, 11, 10, 3, 59, 47, 0, DateTimeKind.Utc), 35, 1, 14, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 112,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(2015, 7, 8, 15, 40, 28, 0, DateTimeKind.Utc), 68, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 113,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1904, 4, 22, 8, 2, 7, 0, DateTimeKind.Utc), 20, 1, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 114,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(2013, 8, 13, 17, 35, 39, 0, DateTimeKind.Utc), 122, 2, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 115,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1935, 5, 12, 2, 40, 54, 0, DateTimeKind.Utc), 24, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 116,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1910, 11, 13, 0, 59, 39, 0, DateTimeKind.Utc), 192, 2, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 117,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1928, 10, 23, 0, 53, 14, 0, DateTimeKind.Utc), 171, 1, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 118,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1913, 4, 9, 14, 36, 26, 0, DateTimeKind.Utc), 64, 3, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 119,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1929, 11, 23, 22, 28, 43, 0, DateTimeKind.Utc), 30, 2, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 120,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(2010, 2, 17, 5, 23, 31, 0, DateTimeKind.Utc), 121, 1, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 121,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1927, 5, 25, 5, 32, 6, 0, DateTimeKind.Utc), 110, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 122,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1987, 5, 9, 21, 49, 58, 0, DateTimeKind.Utc), 39, 2, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 123,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1982, 9, 24, 17, 27, 51, 0, DateTimeKind.Utc), 39, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 124,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1989, 6, 2, 8, 50, 4, 0, DateTimeKind.Utc), 184, 2, 16, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 125,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1967, 6, 8, 0, 29, 55, 0, DateTimeKind.Utc), 53, 3, 16, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 126,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(2014, 10, 3, 11, 29, 59, 0, DateTimeKind.Utc), 144, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 127,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(2007, 4, 2, 15, 40, 25, 0, DateTimeKind.Utc), 126, 2, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 128,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1940, 9, 16, 11, 42, 22, 0, DateTimeKind.Utc), 59, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 129,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1980, 4, 1, 5, 23, 14, 0, DateTimeKind.Utc), 60, 2, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 130,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1898, 3, 2, 4, 47, 1, 0, DateTimeKind.Utc), 94, 1, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 131,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1997, 1, 27, 6, 8, 14, 0, DateTimeKind.Utc), 73, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 132,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1913, 9, 2, 4, 34, 47, 0, DateTimeKind.Utc), 139, 17, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 133,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1963, 11, 25, 3, 34, 23, 0, DateTimeKind.Utc), 134, 17, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 134,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1956, 11, 26, 0, 6, 13, 0, DateTimeKind.Utc), 30, 2, 18, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 135,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1922, 4, 7, 3, 6, 50, 0, DateTimeKind.Utc), 99, 18, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 136,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2017, 2, 25, 9, 19, 50, 0, DateTimeKind.Utc), 109, 2, 18, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 137,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1912, 10, 13, 14, 45, 54, 0, DateTimeKind.Utc), 57, 3, 18, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 138,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2002, 5, 23, 15, 39, 40, 0, DateTimeKind.Utc), 2, 18, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 139,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1926, 8, 26, 0, 49, 44, 0, DateTimeKind.Utc), 185, 18, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 140,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1965, 3, 2, 5, 13, 6, 0, DateTimeKind.Utc), 152, 2, 18, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 141,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1898, 6, 3, 19, 4, 12, 0, DateTimeKind.Utc), 15, 18, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 142,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2008, 5, 3, 0, 6, 20, 0, DateTimeKind.Utc), 127, 1, 18, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 143,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1962, 8, 10, 0, 56, 46, 0, DateTimeKind.Utc), 90, 1, 18, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 144,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1961, 8, 11, 20, 49, 52, 0, DateTimeKind.Utc), 24, 3, 19, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 145,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1963, 11, 26, 10, 50, 29, 0, DateTimeKind.Utc), 15, 2, 19, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 146,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1977, 2, 4, 12, 36, 1, 0, DateTimeKind.Utc), 17, 19, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 147,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2001, 3, 18, 20, 7, 29, 0, DateTimeKind.Utc), 55, 2, 19, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 148,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1975, 3, 5, 2, 26, 7, 0, DateTimeKind.Utc), 103, 2, 19, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 149,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1901, 4, 22, 5, 55, 27, 0, DateTimeKind.Utc), 195, 19, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 150,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1994, 10, 27, 1, 25, 26, 0, DateTimeKind.Utc), 43, 20, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 151,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1906, 9, 4, 0, 30, 16, 0, DateTimeKind.Utc), 49, 20, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 152,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1926, 6, 8, 16, 33, 12, 0, DateTimeKind.Utc), 28, 21, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 153,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1905, 8, 26, 4, 27, 11, 0, DateTimeKind.Utc), 104, 1, 21, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 154,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1975, 8, 14, 4, 57, 27, 0, DateTimeKind.Utc), 101, 3, 22, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 155,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1903, 9, 9, 9, 37, 15, 0, DateTimeKind.Utc), 136, 22, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 156,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1984, 5, 7, 21, 59, 33, 0, DateTimeKind.Utc), 196, 1, 22, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 157,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1906, 10, 12, 18, 17, 43, 0, DateTimeKind.Utc), 188, 1, 22, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 158,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1977, 10, 2, 18, 31, 41, 0, DateTimeKind.Utc), 152, 1, 22, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 159,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2007, 9, 21, 6, 56, 42, 0, DateTimeKind.Utc), 9, 3, 22, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 160,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1942, 6, 14, 17, 51, 39, 0, DateTimeKind.Utc), 87, 22, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 161,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2011, 10, 8, 11, 27, 5, 0, DateTimeKind.Utc), 44, 1, 22, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9258) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 162,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2011, 3, 1, 12, 56, 6, 0, DateTimeKind.Utc), 27, 22, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 163,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1974, 3, 21, 14, 21, 57, 0, DateTimeKind.Utc), 162, 22, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9263) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 164,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1921, 1, 3, 6, 42, 27, 0, DateTimeKind.Utc), 68, 3, 22, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 165,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1967, 6, 14, 4, 30, 52, 0, DateTimeKind.Utc), 177, 1, 22, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9269) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 166,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1933, 3, 18, 20, 19, 5, 0, DateTimeKind.Utc), 187, 22, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 167,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1927, 9, 16, 17, 48, 57, 0, DateTimeKind.Utc), 146, 22, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 168,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1914, 10, 18, 6, 43, 23, 0, DateTimeKind.Utc), 11, 23, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 169,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1990, 10, 18, 15, 51, 46, 0, DateTimeKind.Utc), 132, 2, 23, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 170,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2021, 5, 26, 4, 43, 39, 0, DateTimeKind.Utc), 59, 1, 23, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 171,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1952, 10, 17, 15, 5, 56, 0, DateTimeKind.Utc), 98, 1, 23, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 172,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2002, 5, 19, 10, 31, 17, 0, DateTimeKind.Utc), 33, 23, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 173,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1975, 2, 3, 12, 29, 51, 0, DateTimeKind.Utc), 78, 23, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 174,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1900, 2, 17, 10, 11, 28, 0, DateTimeKind.Utc), 155, 2, 24, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9296) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 175,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1916, 9, 17, 18, 58, 47, 0, DateTimeKind.Utc), 125, 24, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9299) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 176,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1950, 3, 22, 7, 15, 49, 0, DateTimeKind.Utc), 172, 24, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 177,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2009, 5, 17, 2, 39, 22, 0, DateTimeKind.Utc), 44, 3, 24, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 178,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1907, 11, 6, 0, 7, 24, 0, DateTimeKind.Utc), 64, 1, 24, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9307) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 179,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1953, 8, 22, 3, 16, 22, 0, DateTimeKind.Utc), 180, 1, 24, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 180,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1963, 1, 7, 19, 38, 48, 0, DateTimeKind.Utc), 80, 24, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 181,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 9, 13, 8, 38, 31, 0, DateTimeKind.Utc), 191, 24, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 182,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1919, 6, 3, 17, 1, 34, 0, DateTimeKind.Utc), 99, 2, 24, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 183,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1958, 7, 23, 21, 2, 9, 0, DateTimeKind.Utc), 166, 2, 24, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 184,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2017, 3, 14, 11, 52, 27, 0, DateTimeKind.Utc), 72, 1, 24, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 185,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1995, 7, 9, 4, 34, 45, 0, DateTimeKind.Utc), 193, 1, 24, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 186,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1982, 8, 28, 15, 34, 3, 0, DateTimeKind.Utc), 196, 1, 25, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 187,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1952, 3, 7, 22, 36, 54, 0, DateTimeKind.Utc), 99, 2, 25, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 188,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1999, 7, 21, 22, 2, 9, 0, DateTimeKind.Utc), 183, 3, 25, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 189,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1964, 7, 23, 0, 33, 9, 0, DateTimeKind.Utc), 153, 2, 25, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 190,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1997, 7, 14, 19, 58, 40, 0, DateTimeKind.Utc), 5, 2, 25, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 191,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1935, 6, 5, 5, 0, 48, 0, DateTimeKind.Utc), 125, 2, 25, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 192,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1977, 11, 5, 7, 49, 35, 0, DateTimeKind.Utc), 120, 3, 25, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 193,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1924, 9, 24, 11, 9, 17, 0, DateTimeKind.Utc), 46, 1, 25, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 194,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1919, 6, 18, 12, 22, 20, 0, DateTimeKind.Utc), 65, 1, 25, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 195,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2016, 10, 3, 1, 8, 41, 0, DateTimeKind.Utc), 119, 25, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9356) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 196,
                columns: new[] { "created_at", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1946, 1, 19, 17, 0, 38, 0, DateTimeKind.Utc), 25, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 197,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2007, 8, 6, 0, 7, 31, 0, DateTimeKind.Utc), 172, 1, 25, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 198,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1956, 11, 23, 10, 24, 14, 0, DateTimeKind.Utc), 92, 2, 26, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 199,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1933, 5, 18, 2, 23, 40, 0, DateTimeKind.Utc), 167, 2, 26, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 200,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1935, 7, 3, 22, 53, 5, 0, DateTimeKind.Utc), 70, 1, 26, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 201,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1905, 3, 21, 5, 31, 27, 0, DateTimeKind.Utc), 25, 3, 26, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 202,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1980, 4, 2, 22, 0, 28, 0, DateTimeKind.Utc), 39, 26, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 203,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1918, 6, 15, 21, 39, 51, 0, DateTimeKind.Utc), 170, 3, 26, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 204,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2018, 2, 7, 13, 36, 14, 0, DateTimeKind.Utc), 183, 26, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 205,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1975, 10, 27, 16, 10, 59, 0, DateTimeKind.Utc), 155, 1, 26, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 206,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2014, 6, 11, 12, 12, 0, 0, DateTimeKind.Utc), 150, 2, 26, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 207,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2002, 5, 8, 5, 29, 28, 0, DateTimeKind.Utc), 76, 1, 26, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 208,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1899, 1, 12, 4, 34, 24, 0, DateTimeKind.Utc), 192, 26, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 209,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1940, 3, 4, 10, 11, 5, 0, DateTimeKind.Utc), 135, 2, 27, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 210,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1989, 11, 3, 0, 1, 40, 0, DateTimeKind.Utc), 116, 3, 27, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 211,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1947, 4, 25, 2, 12, 50, 0, DateTimeKind.Utc), 22, 1, 27, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 212,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1900, 4, 4, 15, 4, 8, 0, DateTimeKind.Utc), 47, 27, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 213,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1976, 2, 4, 23, 46, 54, 0, DateTimeKind.Utc), 1, 28, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 214,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1976, 9, 23, 12, 34, 26, 0, DateTimeKind.Utc), 88, 1, 28, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 215,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1988, 6, 18, 8, 26, 53, 0, DateTimeKind.Utc), 19, 28, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 216,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1951, 9, 4, 18, 58, 5, 0, DateTimeKind.Utc), 160, 2, 28, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 217,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1968, 3, 11, 10, 14, 31, 0, DateTimeKind.Utc), 36, 28, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 218,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1958, 9, 25, 3, 35, 17, 0, DateTimeKind.Utc), 1, 3, 28, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 219,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1988, 4, 1, 0, 13, 45, 0, DateTimeKind.Utc), 151, 2, 28, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9424) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 220,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1923, 4, 1, 5, 34, 45, 0, DateTimeKind.Utc), 147, 1, 28, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 221,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1921, 7, 16, 13, 31, 36, 0, DateTimeKind.Utc), 174, 28, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 222,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1912, 9, 19, 6, 23, 25, 0, DateTimeKind.Utc), 174, 3, 29, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 223,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1898, 10, 26, 18, 19, 4, 0, DateTimeKind.Utc), 88, 1, 29, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 224,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1952, 11, 7, 16, 56, 0, 0, DateTimeKind.Utc), 173, 1, 30, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 225,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1933, 6, 8, 22, 1, 43, 0, DateTimeKind.Utc), 86, 31, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 226,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1965, 9, 11, 19, 6, 30, 0, DateTimeKind.Utc), 66, 31, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 227,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1930, 7, 25, 2, 16, 42, 0, DateTimeKind.Utc), 78, 2, 31, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9449) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 228,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1971, 5, 20, 3, 2, 53, 0, DateTimeKind.Utc), 22, 3, 31, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 229,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1920, 10, 17, 23, 38, 58, 0, DateTimeKind.Utc), 25, 31, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 230,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1913, 8, 16, 5, 9, 49, 0, DateTimeKind.Utc), 189, 1, 31, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 231,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1977, 7, 27, 20, 11, 57, 0, DateTimeKind.Utc), 192, 3, 32, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 232,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1924, 4, 19, 5, 5, 13, 0, DateTimeKind.Utc), 25, 2, 32, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 233,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2011, 8, 4, 5, 46, 3, 0, DateTimeKind.Utc), 75, 1, 32, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 234,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1979, 3, 7, 9, 20, 52, 0, DateTimeKind.Utc), 183, 1, 32, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 235,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1937, 5, 19, 12, 11, 40, 0, DateTimeKind.Utc), 12, 33, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 236,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1978, 10, 2, 16, 11, 59, 0, DateTimeKind.Utc), 117, 33, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 237,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1948, 4, 18, 4, 56, 44, 0, DateTimeKind.Utc), 162, 2, 33, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9478) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 238,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1994, 10, 26, 3, 27, 40, 0, DateTimeKind.Utc), 116, 1, 33, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 239,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1924, 5, 2, 12, 38, 51, 0, DateTimeKind.Utc), 165, 1, 33, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 240,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1966, 7, 10, 22, 20, 15, 0, DateTimeKind.Utc), 128, 1, 33, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 241,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1993, 10, 6, 14, 50, 51, 0, DateTimeKind.Utc), 75, 3, 34, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 242,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1978, 8, 14, 8, 29, 40, 0, DateTimeKind.Utc), 165, 34, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 243,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1958, 8, 20, 13, 28, 51, 0, DateTimeKind.Utc), 158, 3, 35, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 244,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1962, 11, 1, 8, 39, 16, 0, DateTimeKind.Utc), 95, 1, 35, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 245,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1992, 10, 12, 6, 7, 35, 0, DateTimeKind.Utc), 185, 35, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 246,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1953, 11, 13, 11, 15, 4, 0, DateTimeKind.Utc), 137, 36, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 247,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2008, 7, 21, 11, 42, 48, 0, DateTimeKind.Utc), 99, 2, 36, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 248,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1933, 6, 21, 15, 4, 14, 0, DateTimeKind.Utc), 130, 36, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 249,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1937, 6, 8, 7, 56, 19, 0, DateTimeKind.Utc), 69, 1, 36, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 250,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1923, 11, 5, 8, 0, 50, 0, DateTimeKind.Utc), 71, 1, 37, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 251,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1914, 9, 23, 6, 49, 17, 0, DateTimeKind.Utc), 183, 1, 37, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 252,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1977, 4, 26, 13, 8, 54, 0, DateTimeKind.Utc), 148, 2, 37, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 253,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2014, 1, 2, 16, 3, 23, 0, DateTimeKind.Utc), 196, 1, 37, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 254,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1902, 5, 26, 22, 15, 50, 0, DateTimeKind.Utc), 153, 37, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 255,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2022, 10, 17, 0, 29, 31, 0, DateTimeKind.Utc), 75, 1, 37, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 256,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2013, 4, 9, 3, 25, 4, 0, DateTimeKind.Utc), 97, 3, 37, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 257,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2014, 5, 27, 4, 50, 14, 0, DateTimeKind.Utc), 74, 1, 37, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 258,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1991, 4, 2, 14, 56, 17, 0, DateTimeKind.Utc), 152, 3, 37, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 259,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1953, 7, 3, 20, 54, 7, 0, DateTimeKind.Utc), 199, 37, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 260,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1949, 1, 8, 13, 59, 8, 0, DateTimeKind.Utc), 31, 1, 37, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 261,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1968, 9, 9, 15, 59, 28, 0, DateTimeKind.Utc), 142, 38, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 262,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1967, 2, 22, 15, 6, 55, 0, DateTimeKind.Utc), 23, 38, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 263,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2010, 6, 23, 17, 55, 19, 0, DateTimeKind.Utc), 24, 3, 39, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9581) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 264,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1902, 1, 19, 18, 34, 13, 0, DateTimeKind.Utc), 29, 2, 39, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 265,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1995, 4, 3, 21, 1, 27, 0, DateTimeKind.Utc), 34, 2, 39, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 266,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1979, 6, 3, 21, 6, 15, 0, DateTimeKind.Utc), 86, 39, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 267,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2011, 10, 10, 7, 5, 8, 0, DateTimeKind.Utc), 151, 1, 39, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 268,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1923, 11, 17, 4, 36, 57, 0, DateTimeKind.Utc), 152, 2, 40, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 269,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1898, 2, 19, 15, 15, 24, 0, DateTimeKind.Utc), 31, 2, 40, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 270,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1997, 6, 20, 23, 40, 50, 0, DateTimeKind.Utc), 183, 1, 40, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 271,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1948, 4, 25, 1, 11, 25, 0, DateTimeKind.Utc), 22, 1, 41, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 272,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1965, 3, 19, 6, 0, 5, 0, DateTimeKind.Utc), 198, 41, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 273,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2000, 11, 28, 3, 59, 23, 0, DateTimeKind.Utc), 126, 3, 41, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 274,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1921, 10, 4, 22, 48, 27, 0, DateTimeKind.Utc), 68, 3, 41, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 275,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1926, 3, 23, 2, 43, 58, 0, DateTimeKind.Utc), 186, 41, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 276,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1910, 4, 24, 23, 18, 3, 0, DateTimeKind.Utc), 55, 2, 41, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 277,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1914, 11, 15, 2, 23, 34, 0, DateTimeKind.Utc), 152, 41, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 278,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1968, 7, 9, 20, 46, 2, 0, DateTimeKind.Utc), 175, 3, 41, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 279,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1936, 7, 6, 22, 7, 39, 0, DateTimeKind.Utc), 139, 41, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 280,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2009, 4, 27, 13, 43, 27, 0, DateTimeKind.Utc), 17, 41, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 281,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1917, 6, 13, 17, 18, 20, 0, DateTimeKind.Utc), 154, 1, 41, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 282,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1942, 6, 17, 6, 53, 24, 0, DateTimeKind.Utc), 58, 41, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 283,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2024, 4, 6, 7, 30, 32, 0, DateTimeKind.Utc), 50, 2, 41, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 284,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1899, 1, 13, 12, 48, 25, 0, DateTimeKind.Utc), 9, 41, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 285,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1989, 5, 15, 8, 50, 51, 0, DateTimeKind.Utc), 138, 2, 41, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 286,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2010, 8, 27, 10, 19, 25, 0, DateTimeKind.Utc), 188, 2, 41, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 287,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2005, 9, 15, 8, 47, 40, 0, DateTimeKind.Utc), 130, 3, 41, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 288,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1947, 8, 23, 23, 41, 57, 0, DateTimeKind.Utc), 149, 1, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 289,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1921, 9, 23, 18, 44, 16, 0, DateTimeKind.Utc), 195, 1, 42, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 290,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2001, 11, 10, 3, 3, 59, 0, DateTimeKind.Utc), 7, 1, 42, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9658) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 291,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2020, 8, 8, 3, 54, 59, 0, DateTimeKind.Utc), 177, 1, 42, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 292,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1919, 3, 22, 17, 35, 50, 0, DateTimeKind.Utc), 157, 42, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 293,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1998, 9, 19, 14, 59, 47, 0, DateTimeKind.Utc), 172, 43, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 294,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2004, 3, 10, 13, 5, 41, 0, DateTimeKind.Utc), 134, 2, 43, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 295,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1983, 7, 7, 5, 39, 46, 0, DateTimeKind.Utc), 96, 1, 43, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 296,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1965, 5, 24, 15, 48, 58, 0, DateTimeKind.Utc), 61, 1, 43, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 297,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1922, 11, 25, 11, 47, 30, 0, DateTimeKind.Utc), 113, 43, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 298,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1962, 10, 5, 10, 4, 13, 0, DateTimeKind.Utc), 159, 2, 43, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 299,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1913, 11, 11, 13, 55, 36, 0, DateTimeKind.Utc), 109, 1, 43, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 300,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1988, 8, 15, 5, 11, 58, 0, DateTimeKind.Utc), 116, 2, 44, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 301,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1980, 1, 28, 16, 6, 1, 0, DateTimeKind.Utc), 27, 1, 44, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 302,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1961, 4, 21, 1, 18, 24, 0, DateTimeKind.Utc), 82, 44, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 303,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1929, 7, 11, 1, 17, 58, 0, DateTimeKind.Utc), 10, 44, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 304,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2021, 4, 16, 12, 40, 10, 0, DateTimeKind.Utc), 87, 45, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 305,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1942, 6, 8, 6, 17, 35, 0, DateTimeKind.Utc), 168, 45, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 306,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1970, 3, 6, 3, 5, 53, 0, DateTimeKind.Utc), 42, 45, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 307,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1928, 5, 7, 9, 18, 30, 0, DateTimeKind.Utc), 19, 46, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 308,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1909, 8, 9, 0, 44, 21, 0, DateTimeKind.Utc), 152, 3, 46, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 309,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1925, 3, 21, 16, 5, 21, 0, DateTimeKind.Utc), 71, 1, 46, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9713) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 310,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2015, 6, 15, 20, 49, 43, 0, DateTimeKind.Utc), 104, 3, 46, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 311,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1917, 9, 10, 1, 20, 27, 0, DateTimeKind.Utc), 147, 46, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9719) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 312,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2011, 7, 2, 13, 20, 1, 0, DateTimeKind.Utc), 34, 3, 46, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 313,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2020, 8, 7, 2, 33, 37, 0, DateTimeKind.Utc), 177, 1, 46, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9725) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 314,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2016, 6, 14, 9, 59, 40, 0, DateTimeKind.Utc), 24, 3, 46, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9728) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 315,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1921, 1, 13, 15, 49, 12, 0, DateTimeKind.Utc), 163, 46, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 316,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1977, 8, 20, 4, 44, 19, 0, DateTimeKind.Utc), 119, 1, 46, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 317,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2003, 9, 18, 9, 23, 45, 0, DateTimeKind.Utc), 142, 1, 46, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 318,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1925, 10, 6, 18, 50, 37, 0, DateTimeKind.Utc), 54, 46, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 319,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1976, 1, 13, 4, 10, 33, 0, DateTimeKind.Utc), 170, 2, 46, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9741) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 320,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1941, 8, 3, 6, 14, 10, 0, DateTimeKind.Utc), 33, 3, 46, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 321,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1933, 3, 17, 13, 29, 30, 0, DateTimeKind.Utc), 188, 1, 46, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 322,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1914, 1, 5, 1, 56, 36, 0, DateTimeKind.Utc), 97, 46, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 323,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2020, 2, 16, 11, 3, 8, 0, DateTimeKind.Utc), 134, 2, 47, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9753) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 324,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1937, 7, 21, 9, 57, 9, 0, DateTimeKind.Utc), 176, 1, 47, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 325,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1963, 7, 25, 6, 52, 35, 0, DateTimeKind.Utc), 141, 47, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 326,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1919, 8, 20, 8, 58, 19, 0, DateTimeKind.Utc), 99, 47, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 327,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1968, 9, 22, 20, 31, 46, 0, DateTimeKind.Utc), 124, 3, 47, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9764) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 328,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1956, 8, 8, 22, 41, 0, 0, DateTimeKind.Utc), 133, 1, 47, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 329,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1933, 6, 23, 3, 46, 26, 0, DateTimeKind.Utc), 30, 2, 47, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 330,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1917, 10, 28, 23, 40, 21, 0, DateTimeKind.Utc), 119, 47, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 331,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1934, 7, 27, 20, 8, 46, 0, DateTimeKind.Utc), 65, 47, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 332,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1911, 2, 16, 11, 27, 31, 0, DateTimeKind.Utc), 141, 47, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 333,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1933, 7, 2, 16, 4, 54, 0, DateTimeKind.Utc), 137, 1, 47, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 334,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1900, 5, 18, 8, 2, 18, 0, DateTimeKind.Utc), 76, 47, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 335,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2011, 7, 12, 17, 19, 5, 0, DateTimeKind.Utc), 194, 1, 47, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 336,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2013, 10, 3, 15, 27, 16, 0, DateTimeKind.Utc), 23, 1, 47, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 337,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1909, 5, 22, 20, 31, 14, 0, DateTimeKind.Utc), 191, 3, 48, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 338,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2021, 9, 2, 1, 22, 0, 0, DateTimeKind.Utc), 122, 1, 48, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 339,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1899, 2, 23, 3, 51, 25, 0, DateTimeKind.Utc), 43, 2, 48, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 340,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1997, 8, 16, 7, 13, 15, 0, DateTimeKind.Utc), 110, 2, 48, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 341,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1967, 2, 13, 5, 26, 17, 0, DateTimeKind.Utc), 103, 2, 48, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 342,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1938, 6, 24, 1, 18, 39, 0, DateTimeKind.Utc), 121, 48, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 343,
                columns: new[] { "created_at", "customer_id", "screening_id", "updated_at" },
                values: new object[] { new DateTime(1923, 1, 22, 5, 37, 3, 0, DateTimeKind.Utc), 35, 48, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 344,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2020, 10, 23, 9, 22, 59, 0, DateTimeKind.Utc), 10, 3, 48, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 345,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1944, 7, 13, 14, 12, 44, 0, DateTimeKind.Utc), 146, 1, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 346,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1974, 10, 16, 14, 22, 55, 0, DateTimeKind.Utc), 60, 1, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9819) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 347,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1976, 10, 21, 23, 39, 49, 0, DateTimeKind.Utc), 176, 1, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9823) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 348,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(2005, 4, 20, 5, 6, 8, 0, DateTimeKind.Utc), 102, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9826) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 349,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1995, 2, 6, 13, 37, 38, 0, DateTimeKind.Utc), 56, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 350,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[] { new DateTime(2004, 9, 28, 12, 22, 8, 0, DateTimeKind.Utc), 122, 1, 48, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 351,
                columns: new[] { "created_at", "customer_id", "number_of_seats", "updated_at" },
                values: new object[] { new DateTime(1940, 11, 2, 0, 55, 4, 0, DateTimeKind.Utc), 195, 2, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "ticket_id",
                keyValue: 352,
                columns: new[] { "created_at", "customer_id", "updated_at" },
                values: new object[] { new DateTime(1947, 6, 9, 11, 33, 3, 0, DateTimeKind.Utc), 100, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9838) });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "ticket_id", "created_at", "customer_id", "number_of_seats", "screening_id", "updated_at" },
                values: new object[,]
                {
                    { 353, new DateTime(1900, 1, 9, 23, 40, 41, 0, DateTimeKind.Utc), 45, 3, 49, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9841) },
                    { 354, new DateTime(1919, 8, 19, 20, 59, 46, 0, DateTimeKind.Utc), 174, 2, 49, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9844) },
                    { 355, new DateTime(1926, 7, 14, 17, 19, 14, 0, DateTimeKind.Utc), 140, 1, 49, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9847) },
                    { 356, new DateTime(1902, 9, 20, 9, 42, 33, 0, DateTimeKind.Utc), 13, 2, 49, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9849) },
                    { 357, new DateTime(1947, 9, 16, 4, 5, 48, 0, DateTimeKind.Utc), 93, 2, 49, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9852) },
                    { 358, new DateTime(1943, 6, 4, 17, 37, 35, 0, DateTimeKind.Utc), 52, 2, 49, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9855) },
                    { 359, new DateTime(1994, 7, 12, 16, 14, 17, 0, DateTimeKind.Utc), 7, 1, 49, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9858) },
                    { 360, new DateTime(1998, 6, 4, 19, 58, 23, 0, DateTimeKind.Utc), 10, 2, 49, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9860) },
                    { 361, new DateTime(1971, 2, 19, 1, 27, 51, 0, DateTimeKind.Utc), 17, 2, 49, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9863) },
                    { 362, new DateTime(1995, 11, 18, 20, 47, 1, 0, DateTimeKind.Utc), 61, 1, 49, new DateTime(2024, 2, 7, 11, 3, 38, 879, DateTimeKind.Utc).AddTicks(9866) }
                });
        }
    }
}
