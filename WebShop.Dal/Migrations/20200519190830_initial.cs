using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.Dal.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    NickName = table.Column<string>(nullable: true),
                    BillingAddress_ZipCode = table.Column<string>(nullable: true),
                    BillingAddress_Country = table.Column<string>(nullable: true),
                    BillingAddress_City = table.Column<string>(nullable: true),
                    BillingAddress_Street = table.Column<string>(nullable: true),
                    BillingAddress_HouseNumberAndDoor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Category = table.Column<int>(nullable: false),
                    Available = table.Column<int>(nullable: false),
                    PicturePath = table.Column<string>(nullable: true),
                    OriginalPrice = table.Column<int>(nullable: false),
                    DiscountedPrice = table.Column<int>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Warranty = table.Column<string>(nullable: true),
                    GamingFlag = table.Column<bool>(nullable: false),
                    IsUsed = table.Column<bool>(nullable: false),
                    HasRGB = table.Column<bool>(nullable: false),
                    DateSinceInStore = table.Column<DateTime>(nullable: false),
                    HighlightedItem = table.Column<bool>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    BuiltInFanNumber = table.Column<int>(nullable: true),
                    SupportedMotherboard = table.Column<int>(nullable: true),
                    Height = table.Column<int>(nullable: true),
                    Width = table.Column<int>(nullable: true),
                    Depth = table.Column<int>(nullable: true),
                    HDDNumber = table.Column<int>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Case = table.Column<string>(nullable: true),
                    Motherboard = table.Column<string>(nullable: true),
                    Cpu = table.Column<string>(nullable: true),
                    Gpu = table.Column<string>(nullable: true),
                    Memories = table.Column<string>(nullable: true),
                    Drives = table.Column<string>(nullable: true),
                    PowerSupply = table.Column<string>(nullable: true),
                    BaseClock = table.Column<int>(nullable: true),
                    TDP = table.Column<int>(nullable: true),
                    Weight = table.Column<int>(nullable: true),
                    ProcessorFamily = table.Column<string>(nullable: true),
                    Technology = table.Column<int>(nullable: true),
                    CoreNumber = table.Column<int>(nullable: true),
                    ThreadNumber = table.Column<int>(nullable: true),
                    Socket = table.Column<int>(nullable: true),
                    BuiltInMemory = table.Column<int>(nullable: true),
                    MemoryClock = table.Column<int>(nullable: true),
                    BandWidth = table.Column<int>(nullable: true),
                    CoolerType = table.Column<string>(nullable: true),
                    MemoryType = table.Column<int>(nullable: true),
                    PowerSupplyConnection = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: true),
                    ReadSpeed = table.Column<int>(nullable: true),
                    WriteSpeed = table.Column<int>(nullable: true),
                    HardDrive_Socket = table.Column<int>(nullable: true),
                    Capacity = table.Column<int>(nullable: true),
                    MemoryType1 = table.Column<int>(nullable: true),
                    Timing = table.Column<int>(nullable: true),
                    Kit = table.Column<int>(nullable: true),
                    Type = table.Column<int>(nullable: true),
                    Chipset = table.Column<string>(nullable: true),
                    Motherboard_Socket = table.Column<int>(nullable: true),
                    SupportedMemoryType = table.Column<int>(nullable: true),
                    SupportedMemorySpeed = table.Column<string>(nullable: true),
                    MemorySocketNumber = table.Column<int>(nullable: true),
                    ATXConnector = table.Column<int>(nullable: true),
                    MolexConnector = table.Column<int>(nullable: true),
                    SixPinConnector = table.Column<int>(nullable: true),
                    SixPlusTwoConnector = table.Column<int>(nullable: true),
                    Efficiency = table.Column<int>(nullable: true),
                    IsModular = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    OrderStatus = table.Column<int>(nullable: false),
                    PaymentMethod = table.Column<int>(nullable: false),
                    BillingAddress_ZipCode = table.Column<string>(nullable: true),
                    BillingAddress_Country = table.Column<string>(nullable: true),
                    BillingAddress_City = table.Column<string>(nullable: true),
                    BillingAddress_Street = table.Column<string>(nullable: true),
                    BillingAddress_HouseNumberAndDoor = table.Column<string>(nullable: true),
                    ShippingAddress_ZipCode = table.Column<string>(nullable: true),
                    ShippingAddress_Country = table.Column<string>(nullable: true),
                    ShippingAddress_City = table.Column<string>(nullable: true),
                    ShippingAddress_Street = table.Column<string>(nullable: true),
                    ShippingAddress_HouseNumberAndDoor = table.Column<string>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    WebShopUserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_WebShopUserId",
                        column: x => x.WebShopUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserSubscriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    ItemId = table.Column<Guid>(nullable: false),
                    WebShopUserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSubscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSubscriptions_AspNetUsers_WebShopUserId",
                        column: x => x.WebShopUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ItemId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    CommentText = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    WebShopUserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_WebShopUserId",
                        column: x => x.WebShopUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ItemId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Value = table.Column<int>(nullable: false),
                    WebShopUserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.UniqueConstraint("AK_Ratings_ItemId_UserId", x => new { x.ItemId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Ratings_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_AspNetUsers_WebShopUserId",
                        column: x => x.WebShopUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserCartItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    ItemId = table.Column<Guid>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCartItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCartItems_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    OrderId = table.Column<Guid>(nullable: false),
                    ItemId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OriginalPrice", "PicturePath", "ShortDescription", "Warranty", "BuiltInFanNumber", "Depth", "HDDNumber", "Height", "SupportedMotherboard", "Width" },
                values: new object[] { new Guid("21000000-0000-0000-0000-000000000000"), 10, 2, new DateTime(2020, 3, 30, 21, 8, 29, 901, DateTimeKind.Local).AddTicks(3258), "E-ATX formátumú Torony kialakítású számtógépház beépített 2 db 140 mm-es ventilátorral. Letisztul formabontó design, Edzett üveg oldalpanelek, TT LCS tanúsítvány. ", null, "Case", false, false, false, false, "Thermaltake", "Thermaltake CA-1P6-00F1WN-00 Level 20 HT számítógépház fekete", 59000, "21000000-0000-0000-0000-000000000000.jpg", "Very nice case", "3 years", 3, 503, 4, 613, 0, 468 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OriginalPrice", "PicturePath", "ShortDescription", "Warranty", "BaseClock", "TDP", "Weight", "Chipset", "MemorySocketNumber", "Motherboard_Socket", "SupportedMemorySpeed", "SupportedMemoryType", "Type" },
                values: new object[,]
                {
                    { new Guid("12000000-0000-0000-0000-000000000000"), 20, 5, new DateTime(2020, 4, 19, 21, 8, 29, 904, DateTimeKind.Local).AddTicks(1003), "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.", null, "Motherboard", false, false, false, false, "Gigabyte", "Gigabyte GA-B365-D3H alaplap", 35000, "12000000-0000-0000-0000-000000000000.jpg", "Basic motherboard. No overcloccing here", "2 years", 0, 0, 0, "B365", 0, 10, "2133, 2400, 2666", 3, 2 },
                    { new Guid("11000000-0000-0000-0000-000000000000"), 20, 5, new DateTime(2020, 4, 19, 21, 8, 29, 904, DateTimeKind.Local).AddTicks(878), "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.", 48000, "Motherboard", false, false, false, false, "ASUS", "ASUS PRIME Z390-A alaplap", 69000, "11000000-0000-0000-0000-000000000000.jpg", "Great motherboard. Gets the job done", "20 years", 0, 0, 0, "Z390", 4, 10, "2133, 2400, 2666, 2800, 3000, 3200, 3300, 3333, 3400, 3466, 3600", 3, 0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OriginalPrice", "PicturePath", "ShortDescription", "Warranty", "BaseClock", "TDP", "Weight", "Capacity", "Kit", "MemoryType1", "Timing" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), 20, 4, new DateTime(2020, 5, 14, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(8612), "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.", null, "Memory", false, false, true, false, "Kingston", "Kingston 2x8GB DDR4 3200MHz HyperX Predator RGB HX432C16PB3AK2/16 memória", 41000, "10000000-0000-0000-0000-000000000001.jpg", "High end memory with inbuilt RGB for so many fps!!!", "5 years", 3200, 0, 0, 8, 2, 3, 16 },
                    { new Guid("90000000-0000-0000-0000-000000000000"), 20, 4, new DateTime(2020, 4, 19, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(8535), "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.", 34000, "Memory", false, false, false, false, "Kingston", "Kingston 2x8GB DDR4 3200MHz HyperX Predator XMP HX432C16PB3K2/16 memória", 38000, "90000000-0000-0000-0000-000000000000.jpg", "High end memory in amazing white color", "5 years", 3200, 0, 0, 8, 2, 3, 16 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OriginalPrice", "PicturePath", "ShortDescription", "Warranty", "BaseClock", "TDP", "Weight", "ReadSpeed", "Size", "HardDrive_Socket", "WriteSpeed" },
                values: new object[,]
                {
                    { new Guid("80000000-0000-0000-0000-000000000000"), 20, 3, new DateTime(2020, 5, 16, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(6928), "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.", 65000, "HardDrive", false, false, false, false, "Seagate", "Seagate SkyHawk Surveillance 10TB 7200rpm 256MB SATA3 3,5\" HDD", 108000, "80000000-0000-0000-0000-000000000000.jpg", "Biggest HDD you've ever seen", "5 years", 0, 0, 0, 50, 10000, 0, 35 },
                    { new Guid("70000000-0000-0000-0000-000000000000"), 0, 3, new DateTime(2020, 4, 19, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(6921), "A Kingston A400 egy 2,5\" -os SSD meghajtó, melynek kapacitása 240 GB és PC vagy notebook felhasználást képes teljesmértékben egy egy erőteljes géppé változtatni. A készülék frissítése még sosem volt egyszerűbb. Összehasonlítva a mechanikus merevlemezekkel azonnal észrevehető a teljesítmény növekedés. Már az indítás során észlelhetjük, hogy az operációs rendszer betöltése sokkal gyorsabb. Ésegyéb műveletek, mint az alkalmazások indítására, másolás vagy mozgó kép indítására sem kell már olyan sokáig várni, mint korábban", null, "HardDrive", false, false, true, false, "Kingston", "Kingston 240GB SA400S37/240G SSD meghajtó", 14000, "70000000-0000-0000-0000-000000000000.jpg", "Resonably fast SSD ", "5 years", 0, 0, 0, 500, 240, 1, 350 },
                    { new Guid("60000000-0000-0000-0000-000000000000"), 20, 3, new DateTime(2020, 4, 19, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(6853), null, null, "HardDrive", false, false, false, false, "Samsung", "Samsung 250GB 970 EVO Plus MZ-V7S250BW M.2 PCIe SSD meghajtó", 28600, "60000000-0000-0000-0000-000000000000.jpg", "Very fast SSD ", "5 years", 0, 0, 0, 3500, 250, 2, 2300 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OriginalPrice", "PicturePath", "ShortDescription", "Warranty", "BaseClock", "TDP", "Weight", "BandWidth", "BuiltInMemory", "CoolerType", "MemoryClock", "MemoryType", "PowerSupplyConnection" },
                values: new object[] { new Guid("55500000-0000-0000-0000-000000000000"), 15, 1, new DateTime(2020, 5, 17, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(5226), "Új Turing GPU architektúra és Ray-tracing technológia: tükröződés és fejlettebb effektek valós időben. DirectX 12: fejlettebb vizualitás és optimalizált teljesítmény. Axial-tech fans: különleges és egyedi hűtés, halk és hatékony működés. Super Alloy Power II: elsőosztályú alkatrészekkel szerelve a hosszú élettartamért és a stabil energiaellátásért.MaxContact Technology: a hűtőborda hatékonyabb elhelyezésével nő a hővezetőképesség", 370000, "GraphicsCard", false, false, true, false, "MSI", "Asus RTX2080 Ti 11GB GDDR6 ROG-STRIX-RTX2080TI-O11G-GAMING", 548590, "55500000-0000-0000-0000-000000000000.jpg", "Best GPU money can buy", "3 years", 1350, 170, 0, 128, 11264, "Active", 14000, 7, "8 + 8" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OriginalPrice", "PicturePath", "ShortDescription", "Warranty", "BaseClock", "TDP", "Weight", "ATXConnector", "Efficiency", "IsModular", "MolexConnector", "SixPinConnector", "SixPlusTwoConnector" },
                values: new object[] { new Guid("13000000-0000-0000-0000-000000000000"), 20, 6, new DateTime(2020, 4, 19, 21, 8, 29, 904, DateTimeKind.Local).AddTicks(3216), "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.", null, "PowerSupply", false, false, false, false, "Chieftec", "Chieftec ECO 400W GPE-400S tápegység", 13700, "13000000-0000-0000-0000-000000000000.jpg", "Cheap ass psu, dont buy this", "3 years", 0, 0, 0, 1, 85, false, 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OriginalPrice", "PicturePath", "ShortDescription", "Warranty", "BaseClock", "TDP", "Weight", "BandWidth", "BuiltInMemory", "CoolerType", "MemoryClock", "MemoryType", "PowerSupplyConnection" },
                values: new object[] { new Guid("50000000-0000-0000-0000-000000000000"), 0, 1, new DateTime(2020, 5, 17, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(5219), "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.", 79900, "GraphicsCard", false, false, false, false, "MSI", "MSI Radeon RX 5500 XT MECH 8G OC videokártya", 85500, "50000000-0000-0000-0000-000000000000.jpg", "Low end basic graphics card for work", "3 years", 1845, 130, 0, 128, 8192, "Active", 14000, 7, "8" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OriginalPrice", "PicturePath", "ShortDescription", "Warranty", "BaseClock", "TDP", "Weight", "CoreNumber", "ProcessorFamily", "Socket", "Technology", "ThreadNumber" },
                values: new object[,]
                {
                    { new Guid("33000000-0000-0000-0000-000000000000"), 1, 0, new DateTime(2020, 4, 19, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(2864), "Magok száma:24, Család:AMD Ryzen Threadripper, Processzor foglalat:AMD TR4, Órajel (Mhz):3000, VGA típus:Nem, Fogyasztás (W):250, L3 Cache (MB):64, Architektúra (bit):Zen+, Gyártási technológia (nm):12, Hűtőventilátor:Nem, L2 Cache (MB):12, Hűtőborda:Nem", 410000, "Cpu", false, false, false, false, "AMD", "AMD Ryzen Threadripper 2970WX ", 443390, "33000000-0000-0000-0000-000000000000.jpg", "Felsőkategóriás processor, munkaállomásba", "3 years", 3000, 250, 0, 24, "AMD threadripper", 12, 12, 24 },
                    { new Guid("30000000-0000-0000-0000-000000000000"), 10, 0, new DateTime(2020, 4, 19, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(2859), "Magok száma:6, Processzor foglalat:Intel 1151 v2, Család:Coffee Lake, Órajel (Mhz):2900, VGA típus:Nem, Hűtőventilátor:Igen, Fogyasztás (W):65, Architektúra (bit):64, L3 Cache (MB):9, Hűtőborda:Igen, Gyártási technológia (nm):14, L2 Cache (MB):1,5, Szálak száma:6,", null, "Cpu", false, false, false, false, "Intel", "Intel Core i5-9400f", 82000, "30000000-0000-0000-0000-000000000000.jpg", "Középkategóriás processor munkára és játékra egyaránt", "3 years", 3500, 45, 0, 4, "Intel core 5", 10, 14, 4 },
                    { new Guid("20000000-0000-0000-0000-000000000000"), 10, 0, new DateTime(2020, 4, 19, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(2849), "Magok száma:6, Processzor foglalat:Intel 1151 v2, Család:Coffee Lake, Órajel (Mhz):3700, VGA típus:Intel UHD Graphics 630, Hűtőventilátor:Nem, Fogyasztás (W):95, Architektúra (bit):64, L3 Cache (MB):9, Hűtőborda:Nem, Gyártási technológia (nm):14, L2 Cache (MB):2, Szálak száma:6,", 65000, "Cpu", false, false, true, false, "Intel", "Intel Core i5-9600K", 82000, "20000000-0000-0000-0000-000000000000.jpg", "Very good gaming processor", "3 years", 3700, 65, 0, 6, "Intel core 5", 10, 14, 6 },
                    { new Guid("10000000-0000-0000-0000-000000000000"), 10, 0, new DateTime(2020, 3, 30, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(2742), "A legjobb többprocesszoros teljesítmény az osztályában, a játékosok számára. Jobb teljesítmény. Hihetetlen technológia. Az intelligens Ryzen processzorok csak még okosabbak lettek. ", null, "Cpu", false, false, false, false, "AMD", "AMD Ryzen 3 2200G", 31500, "10000000-0000-0000-0000-000000000000.jpg", "So basic processor", "5 years", 3400, 65, 0, 4, "AMD Ryzen 3", 3, 14, 4 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OriginalPrice", "PicturePath", "ShortDescription", "Warranty", "Brand", "Case", "Cpu", "Drives", "Gpu", "Memories", "Motherboard", "PowerSupply" },
                values: new object[,]
                {
                    { new Guid("21000000-0000-0000-0000-000000000012"), 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A dinamikus, szélnyíró készülékház kifinomult formával rendelkezik, hogy növelje a légáramot, miközben 30dB alatt tartja a zajszinteket a csendesebb játék és munka érdekében. Az elülső hangsúlyokon keresztül megtalálható vágások kiszélesítették a szellőzőket, így több levegő jut a készülékházba. Belül a CPU, a grafikus kártya és a tápegység külön foglalatokban található, minimalizálva a termikus interferenciát és csökkentve a környezeti hőmérsékletet. A légáram növelő dizájn felgyorsítja a hőeloszlást, hogy magasabb általános teljesítményt tegyen lehetővé és tartson meg.", null, "CompletPC", false, false, false, false, "ASUS", "ASUS ROG Strix GA15 Gamer asztali számítógép(G15DH-HU004D)", 295790, "21000000-0000-0000-0000-000000000012.jpg", "Highend gaming pc mindenre is", "3 years", null, "Asus Strix Boss gépház", "Intel I9-9900K", "1TGB SSD, 10TB HDD", "nVidia GeForce RTX 2060 Super - 8GB", "4 x Kingston HyperX fury 8gb 3200mhz", "ASUS Strix Z490 gaming pro alaplap", null },
                    { new Guid("21000000-0000-0000-0000-000000000011"), 15, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A dinamikus, szélnyíró készülékház kifinomult formával rendelkezik, hogy növelje a légáramot, miközben 30dB alatt tartja a zajszinteket a csendesebb játék és munka érdekében. Az elülső hangsúlyokon keresztül megtalálható vágások kiszélesítették a szellőzőket, így több levegő jut a készülékházba. Belül a CPU, a grafikus kártya és a tápegység külön foglalatokban található, minimalizálva a termikus interferenciát és csökkentve a környezeti hőmérsékletet. A légáram növelő dizájn felgyorsítja a hőeloszlást, hogy magasabb általános teljesítményt tegyen lehetővé és tartson meg.", null, "CompletPC", false, false, false, false, "ASUS", "ASUS ROG asztali gamer számítógép (G15DH-HU011D)", 295790, "21000000-0000-0000-0000-000000000011.jpg", "Viszonylag olcsó, jó árérték arányú számítógép", "2 years", null, "Asus omega colorful RGB gépház", "AMD Ryzen 5 3600X", "256GB SSD, 1TB HDD", "nvidia geforce gtx 1650", "2 x Kingston HyperX fury 8gb 3200mhz", "ASUS Strix B460 gaming pro alaplap", null }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OriginalPrice", "PicturePath", "ShortDescription", "Warranty", "BuiltInFanNumber", "Depth", "HDDNumber", "Height", "SupportedMotherboard", "Width" },
                values: new object[,]
                {
                    { new Guid("31000000-0000-0000-0000-000000000000"), 2, 2, new DateTime(2020, 3, 30, 21, 8, 29, 902, DateTimeKind.Local).AddTicks(9650), "A Thermaltake a számítógépházába összeolvasztotta a szépséget és a teljesítményt, a View 32 Tempered Glass RGB Edition középkategóriás számítógépház tervezésébe. Négy prémium minőségű, 4 mm vastag, edzett üvegablakkal (felső, elülső, bal és jobb) készült, a belső rendszer közvetlen megtekintéséhez és a kiváló alvázvédelemhez. Három beépített 120 mm-es Riing LED RGB ventilátor (kettő elöl és egy hátul) biztosítja az RGB megvilágítását és az optimális szellőzést.", 18000, "Case", false, false, true, false, "Thermaltake", "Thermaltake View 32 Tempered Glass RGB Edition", 49000, "31000000-0000-0000-0000-000000000000.jpg", "So much RGB => So much FPS", "3 years", 3, 500, 4, 521, 0, 201 },
                    { new Guid("22000000-0000-0000-0000-000000000000"), 10, 2, new DateTime(2020, 3, 30, 21, 8, 29, 902, DateTimeKind.Local).AddTicks(9564), "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque.", null, "Case", false, false, false, false, "DeepCool", "DeepCool EARLKASE RGB WH fehér számítógép ház", 59000, "22000000-0000-0000-0000-000000000000.jpg", "White and big case", "3 years", 3, 500, 4, 511, 0, 204 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OriginalPrice", "PicturePath", "ShortDescription", "Warranty", "BaseClock", "TDP", "Weight", "BandWidth", "BuiltInMemory", "CoolerType", "MemoryClock", "MemoryType", "PowerSupplyConnection" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000000"), 3, 1, new DateTime(2020, 4, 19, 21, 8, 29, 903, DateTimeKind.Local).AddTicks(5144), "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.", 165000, "GraphicsCard", false, false, true, false, "Gigabyte", "Gigabyte RTX2070 Super 8GB GDDR6 GV-N207SGAMINGOC WHITE-8GD videokártya", 216000, "40000000-0000-0000-0000-000000000000.jpg", "High end gpu in amazing white color", "5 years", 1770, 215, 0, 256, 8192, "Windforce 3x", 14000, 7, "6 + 8" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OriginalPrice", "PicturePath", "ShortDescription", "Warranty", "BaseClock", "TDP", "Weight", "ATXConnector", "Efficiency", "IsModular", "MolexConnector", "SixPinConnector", "SixPlusTwoConnector" },
                values: new object[] { new Guid("14000000-0000-0000-0000-000000000000"), 0, 6, new DateTime(2020, 4, 19, 21, 8, 29, 904, DateTimeKind.Local).AddTicks(3294), "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.", 25000, "PowerSupply", false, false, true, false, "FSP", "FSP 650W Hyper M tápegység", 29790, "14000000-0000-0000-0000-000000000000.jpg", "You should by this not that chinesee crap", "3 years", 0, 0, 0, 1, 85, true, 3, 0, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ItemId",
                table: "Comments",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_WebShopUserId",
                table: "Comments",
                column: "WebShopUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_WebShopUserId",
                table: "Orders",
                column: "WebShopUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_WebShopUserId",
                table: "Ratings",
                column: "WebShopUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCartItems_ItemId",
                table: "UserCartItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCartItems_UserId",
                table: "UserCartItems",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSubscriptions_WebShopUserId",
                table: "UserSubscriptions",
                column: "WebShopUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "UserCartItems");

            migrationBuilder.DropTable(
                name: "UserSubscriptions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
