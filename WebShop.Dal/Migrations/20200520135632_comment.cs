using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.Dal.Migrations
{
    public partial class comment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_WebShopUserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_WebShopUserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_WebShopUserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Comments_WebShopUserId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "WebShopUserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "WebShopUserId",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 3, 31, 15, 56, 31, 577, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("22000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 3, 31, 15, 56, 31, 578, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 3, 31, 15, 56, 31, 578, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 3, 31, 15, 56, 31, 579, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 20, 15, 56, 31, 579, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 20, 15, 56, 31, 579, DateTimeKind.Local).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("33000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 20, 15, 56, 31, 579, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 20, 15, 56, 31, 579, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 18, 15, 56, 31, 579, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("55500000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 18, 15, 56, 31, 579, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 20, 15, 56, 31, 579, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("70000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 20, 15, 56, 31, 579, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("80000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 17, 15, 56, 31, 579, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 15, 15, 56, 31, 579, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("90000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 20, 15, 56, 31, 579, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("11000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 20, 15, 56, 31, 579, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("12000000-0000-0000-0000-000000000000"),
                columns: new[] { "DateSinceInStore", "Motherboard_Socket" },
                values: new object[] { new DateTime(2020, 4, 20, 15, 56, 31, 579, DateTimeKind.Local).AddTicks(8848), 3 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("13000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 20, 15, 56, 31, 580, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("14000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 20, 15, 56, 31, 580, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserId",
                table: "Comments");

            migrationBuilder.AddColumn<Guid>(
                name: "WebShopUserId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "WebShopUserId",
                table: "Comments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 3, 30, 21, 8, 29, 901, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("22000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 3, 30, 21, 8, 29, 902, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 3, 30, 21, 8, 29, 902, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 3, 30, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 19, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 19, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("33000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 19, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 19, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 17, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("55500000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 17, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 19, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("70000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 19, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("80000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 16, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 14, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("90000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 19, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("11000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 19, 21, 8, 29, 904, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("12000000-0000-0000-0000-000000000000"),
                columns: new[] { "DateSinceInStore", "Motherboard_Socket" },
                values: new object[] { new DateTime(2020, 4, 19, 21, 8, 29, 904, DateTimeKind.Local).AddTicks(1003), 10 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("13000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 19, 21, 8, 29, 904, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("14000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 19, 21, 8, 29, 904, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_WebShopUserId",
                table: "Orders",
                column: "WebShopUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_WebShopUserId",
                table: "Comments",
                column: "WebShopUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_WebShopUserId",
                table: "Comments",
                column: "WebShopUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_WebShopUserId",
                table: "Orders",
                column: "WebShopUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
