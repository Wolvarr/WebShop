using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.Dal.Migrations
{
    public partial class order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Order_OrderId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameIndex(
                name: "IX_Order_UserId",
                table: "Orders",
                newName: "IX_Orders_UserId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryDate",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 3, 28, 16, 33, 22, 315, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("22000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 3, 28, 16, 33, 22, 317, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 3, 28, 16, 33, 22, 317, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 3, 28, 16, 33, 22, 317, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 17, 16, 33, 22, 317, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 17, 16, 33, 22, 317, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("33000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 17, 16, 33, 22, 317, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 17, 16, 33, 22, 318, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 15, 16, 33, 22, 318, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("55500000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 15, 16, 33, 22, 318, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 17, 16, 33, 22, 318, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("70000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 17, 16, 33, 22, 318, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("80000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 14, 16, 33, 22, 318, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 12, 16, 33, 22, 318, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("90000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 17, 16, 33, 22, 318, DateTimeKind.Local).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("11000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 17, 16, 33, 22, 318, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("12000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 17, 16, 33, 22, 318, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("13000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 17, 16, 33, 22, 318, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("14000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 17, 16, 33, 22, 318, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Orders_OrderId",
                table: "Items",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Items_Orders_OrderId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeliveryDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserId",
                table: "Order",
                newName: "IX_Order_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 3, 27, 18, 18, 34, 829, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("22000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 3, 27, 18, 18, 34, 830, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 3, 27, 18, 18, 34, 830, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 3, 27, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 16, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 16, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("33000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 16, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 16, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 14, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("55500000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 14, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 16, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("70000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 16, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("80000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 13, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 11, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("90000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 16, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("11000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 16, 18, 18, 34, 832, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("12000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 16, 18, 18, 34, 832, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("13000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 16, 18, 18, 34, 832, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("14000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 16, 18, 18, 34, 832, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Order_OrderId",
                table: "Items",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
