using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.Dal.Migrations
{
    public partial class address_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_AspNetUsers_UserId",
                table: "Ratings");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCartItems_AspNetUsers_UserId",
                table: "UserCartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSubscriptions_AspNetUsers_UserId",
                table: "UserSubscriptions");

            migrationBuilder.DropIndex(
                name: "IX_UserSubscriptions_UserId",
                table: "UserSubscriptions");

            migrationBuilder.DropIndex(
                name: "IX_UserCartItems_UserId",
                table: "UserCartItems");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "BillingAddress_Settlement",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "BillingAddress_StreetAddress",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShippingAddress_Settlement",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShippingAddress_StreetAddress",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "BillingAddress_Settlement",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BillingAddress_StreetAddress",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ShippingAddress_Settlement",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ShippingAddress_StreetAddress",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<Guid>(
                name: "WebShopUserId",
                table: "UserSubscriptions",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "WebShopUserId",
                table: "UserCartItems",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "WebShopUserId",
                table: "Ratings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BillingAddress_City",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BillingAddress_Country",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BillingAddress_HouseNumberAndDoor",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BillingAddress_Street",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress_City",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress_Country",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress_HouseNumberAndDoor",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress_Street",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NickName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BillingAddress_City",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BillingAddress_Country",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BillingAddress_HouseNumberAndDoor",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BillingAddress_Street",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress_City",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress_Country",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress_HouseNumberAndDoor",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress_Street",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 3, 28, 18, 7, 44, 688, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("22000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 3, 28, 18, 7, 44, 690, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 3, 28, 18, 7, 44, 690, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 3, 28, 18, 7, 44, 690, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 17, 18, 7, 44, 690, DateTimeKind.Local).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 17, 18, 7, 44, 690, DateTimeKind.Local).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("33000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 17, 18, 7, 44, 690, DateTimeKind.Local).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 17, 18, 7, 44, 691, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 15, 18, 7, 44, 691, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("55500000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 15, 18, 7, 44, 691, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 17, 18, 7, 44, 691, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("70000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 17, 18, 7, 44, 691, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("80000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 14, 18, 7, 44, 691, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 5, 12, 18, 7, 44, 691, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("90000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 17, 18, 7, 44, 691, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("11000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 17, 18, 7, 44, 691, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("12000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 17, 18, 7, 44, 691, DateTimeKind.Local).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("13000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 17, 18, 7, 44, 692, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("14000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 4, 17, 18, 7, 44, 692, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.CreateIndex(
                name: "IX_UserSubscriptions_WebShopUserId",
                table: "UserSubscriptions",
                column: "WebShopUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCartItems_WebShopUserId",
                table: "UserCartItems",
                column: "WebShopUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_WebShopUserId",
                table: "Ratings",
                column: "WebShopUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_AspNetUsers_WebShopUserId",
                table: "Ratings",
                column: "WebShopUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCartItems_AspNetUsers_WebShopUserId",
                table: "UserCartItems",
                column: "WebShopUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSubscriptions_AspNetUsers_WebShopUserId",
                table: "UserSubscriptions",
                column: "WebShopUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_AspNetUsers_WebShopUserId",
                table: "Ratings");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCartItems_AspNetUsers_WebShopUserId",
                table: "UserCartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSubscriptions_AspNetUsers_WebShopUserId",
                table: "UserSubscriptions");

            migrationBuilder.DropIndex(
                name: "IX_UserSubscriptions_WebShopUserId",
                table: "UserSubscriptions");

            migrationBuilder.DropIndex(
                name: "IX_UserCartItems_WebShopUserId",
                table: "UserCartItems");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_WebShopUserId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "WebShopUserId",
                table: "UserSubscriptions");

            migrationBuilder.DropColumn(
                name: "WebShopUserId",
                table: "UserCartItems");

            migrationBuilder.DropColumn(
                name: "WebShopUserId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "BillingAddress_City",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "BillingAddress_Country",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "BillingAddress_HouseNumberAndDoor",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "BillingAddress_Street",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShippingAddress_City",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShippingAddress_Country",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShippingAddress_HouseNumberAndDoor",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShippingAddress_Street",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "NickName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BillingAddress_City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BillingAddress_Country",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BillingAddress_HouseNumberAndDoor",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BillingAddress_Street",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ShippingAddress_City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ShippingAddress_Country",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ShippingAddress_HouseNumberAndDoor",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ShippingAddress_Street",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "BillingAddress_Settlement",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BillingAddress_StreetAddress",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress_Settlement",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress_StreetAddress",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BillingAddress_Settlement",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BillingAddress_StreetAddress",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress_Settlement",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress_StreetAddress",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_UserSubscriptions_UserId",
                table: "UserSubscriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCartItems_UserId",
                table: "UserCartItems",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_AspNetUsers_UserId",
                table: "Ratings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCartItems_AspNetUsers_UserId",
                table: "UserCartItems",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSubscriptions_AspNetUsers_UserId",
                table: "UserSubscriptions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
