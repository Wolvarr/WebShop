using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.Dal.Migrations
{
    public partial class last_one : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 8, 10, 58, 34, 386, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("22000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 8, 10, 58, 34, 388, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 8, 10, 58, 34, 388, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000011"),
                columns: new[] { "GamingFlag", "HasRGB", "OriginalPrice" },
                values: new object[] { true, true, 595790 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 8, 10, 58, 34, 388, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 28, 10, 58, 34, 388, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 28, 10, 58, 34, 388, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("33000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 28, 10, 58, 34, 388, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000000"),
                columns: new[] { "DateSinceInStore", "GamingFlag", "HasRGB" },
                values: new object[] { new DateTime(2020, 4, 28, 10, 58, 34, 388, DateTimeKind.Local).AddTicks(7159), true, true });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 26, 10, 58, 34, 388, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("55500000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 26, 10, 58, 34, 388, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 28, 10, 58, 34, 388, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("70000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 28, 10, 58, 34, 388, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("80000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 25, 10, 58, 34, 388, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "DateSinceInStore", "GamingFlag", "HasRGB" },
                values: new object[] { new DateTime(2020, 5, 23, 10, 58, 34, 389, DateTimeKind.Local).AddTicks(526), true, true });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("90000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 28, 10, 58, 34, 389, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("11000000-0000-0000-0000-000000000000"),
                columns: new[] { "DateSinceInStore", "GamingFlag", "HasRGB" },
                values: new object[] { new DateTime(2020, 4, 28, 10, 58, 34, 389, DateTimeKind.Local).AddTicks(2686), true, true });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("12000000-0000-0000-0000-000000000000"),
                columns: new[] { "DateSinceInStore", "ShortDescription" },
                values: new object[] { new DateTime(2020, 4, 28, 10, 58, 34, 389, DateTimeKind.Local).AddTicks(2754), "Basic motherboard. No overclocking here" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("13000000-0000-0000-0000-000000000000"),
                columns: new[] { "DateSinceInStore", "ShortDescription" },
                values: new object[] { new DateTime(2020, 4, 28, 10, 58, 34, 389, DateTimeKind.Local).AddTicks(4943), "Cheap psu, dont buy this" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("14000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 28, 10, 58, 34, 389, DateTimeKind.Local).AddTicks(5013));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 1, 13, 35, 44, 969, DateTimeKind.Local).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("22000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 1, 13, 35, 44, 970, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 1, 13, 35, 44, 970, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000011"),
                columns: new[] { "GamingFlag", "HasRGB", "OriginalPrice" },
                values: new object[] { false, false, 295790 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 1, 13, 35, 44, 971, DateTimeKind.Local).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 21, 13, 35, 44, 971, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 21, 13, 35, 44, 971, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("33000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 21, 13, 35, 44, 971, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000000"),
                columns: new[] { "DateSinceInStore", "GamingFlag", "HasRGB" },
                values: new object[] { new DateTime(2020, 4, 21, 13, 35, 44, 971, DateTimeKind.Local).AddTicks(3726), false, false });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 19, 13, 35, 44, 971, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("55500000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 19, 13, 35, 44, 971, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 21, 13, 35, 44, 971, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("70000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 21, 13, 35, 44, 971, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("80000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 18, 13, 35, 44, 971, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "DateSinceInStore", "GamingFlag", "HasRGB" },
                values: new object[] { new DateTime(2020, 5, 16, 13, 35, 44, 971, DateTimeKind.Local).AddTicks(7125), false, false });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("90000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 21, 13, 35, 44, 971, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("11000000-0000-0000-0000-000000000000"),
                columns: new[] { "DateSinceInStore", "GamingFlag", "HasRGB" },
                values: new object[] { new DateTime(2020, 4, 21, 13, 35, 44, 971, DateTimeKind.Local).AddTicks(9352), false, false });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("12000000-0000-0000-0000-000000000000"),
                columns: new[] { "DateSinceInStore", "ShortDescription" },
                values: new object[] { new DateTime(2020, 4, 21, 13, 35, 44, 971, DateTimeKind.Local).AddTicks(9420), "Basic motherboard. No overcloccing here" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("13000000-0000-0000-0000-000000000000"),
                columns: new[] { "DateSinceInStore", "ShortDescription" },
                values: new object[] { new DateTime(2020, 4, 21, 13, 35, 44, 972, DateTimeKind.Local).AddTicks(1585), "Cheap ass psu, dont buy this" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("14000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 21, 13, 35, 44, 972, DateTimeKind.Local).AddTicks(1655));
        }
    }
}
