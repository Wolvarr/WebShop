using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.Dal.Migrations
{
    public partial class seed : Migration
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
                    BillingAddress_ZipCode = table.Column<string>(nullable: true),
                    BillingAddress_Settlement = table.Column<string>(nullable: true),
                    BillingAddress_StreetAddress = table.Column<string>(nullable: true),
                    ShippingAddress_ZipCode = table.Column<string>(nullable: true),
                    ShippingAddress_Settlement = table.Column<string>(nullable: true),
                    ShippingAddress_StreetAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
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
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    OrderStatus = table.Column<int>(nullable: false),
                    BillingAddress_ZipCode = table.Column<string>(nullable: true),
                    BillingAddress_Settlement = table.Column<string>(nullable: true),
                    BillingAddress_StreetAddress = table.Column<string>(nullable: true),
                    ShippingAddress_ZipCode = table.Column<string>(nullable: true),
                    ShippingAddress_Settlement = table.Column<string>(nullable: true),
                    ShippingAddress_StreetAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_UserCartItems_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSubscriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    ItemId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSubscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSubscriptions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    OrderId = table.Column<Guid>(nullable: true),
                    BuiltInFanNumber = table.Column<int>(nullable: true),
                    SupportedMotherboard = table.Column<int>(nullable: true),
                    Height = table.Column<int>(nullable: true),
                    Width = table.Column<int>(nullable: true),
                    Depth = table.Column<int>(nullable: true),
                    HDDNumber = table.Column<int>(nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Items_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
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
                    Date = table.Column<DateTime>(nullable: false)
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
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompletPCs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    CaseId = table.Column<Guid>(nullable: false),
                    MotherBoardId = table.Column<Guid>(nullable: false),
                    CpuId = table.Column<Guid>(nullable: false),
                    GpuId = table.Column<Guid>(nullable: false),
                    PowerSupplyId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletPCs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompletPCs_Items_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompletPCs_Items_CpuId",
                        column: x => x.CpuId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompletPCs_Items_GpuId",
                        column: x => x.GpuId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompletPCs_Items_MotherBoardId",
                        column: x => x.MotherBoardId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompletPCs_Items_PowerSupplyId",
                        column: x => x.PowerSupplyId,
                        principalTable: "Items",
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
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PC_Drives",
                columns: table => new
                {
                    PcId = table.Column<Guid>(nullable: false),
                    DriveId = table.Column<Guid>(nullable: false),
                    CompletPCId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PC_Drives", x => x.PcId);
                    table.ForeignKey(
                        name: "FK_PC_Drives_CompletPCs_CompletPCId",
                        column: x => x.CompletPCId,
                        principalTable: "CompletPCs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PC_Memories",
                columns: table => new
                {
                    PcId = table.Column<Guid>(nullable: false),
                    MemoryId = table.Column<Guid>(nullable: false),
                    CompletPCId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PC_Memories", x => x.PcId);
                    table.ForeignKey(
                        name: "FK_PC_Memories_CompletPCs_CompletPCId",
                        column: x => x.CompletPCId,
                        principalTable: "CompletPCs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "ShortDescription", "Warranty", "BuiltInFanNumber", "Depth", "HDDNumber", "Height", "SupportedMotherboard", "Width" },
                values: new object[] { new Guid("21000000-0000-0000-0000-000000000000"), 10, 2, new DateTime(2020, 3, 27, 18, 18, 34, 829, DateTimeKind.Local).AddTicks(2675), "E-ATX formátumú Torony kialakítású számtógépház beépített 2 db 140 mm-es ventilátorral. Letisztul formabontó design, Edzett üveg oldalpanelek, TT LCS tanúsítvány. ", null, "Case", false, false, false, false, "Thermaltake", "Thermaltake CA-1P6-00F1WN-00 Level 20 HT számítógépház fekete", null, 59000, "21000000-0000-0000-0000-000000000000.jpg", "Very nice case", "3 years", 3, 503, 4, 613, 0, 468 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "ShortDescription", "Warranty", "BaseClock", "TDP", "Weight", "Chipset", "MemorySocketNumber", "Motherboard_Socket", "SupportedMemorySpeed", "SupportedMemoryType", "Type" },
                values: new object[,]
                {
                    { new Guid("12000000-0000-0000-0000-000000000000"), 20, 5, new DateTime(2020, 4, 16, 18, 18, 34, 832, DateTimeKind.Local).AddTicks(2189), "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.", null, "Motherboard", false, false, false, false, "Gigabyte", "Gigabyte GA-B365-D3H alaplap", null, 35000, "12000000-0000-0000-0000-000000000000.jpg", "Basic motherboard. No overcloccing here", "2 years", 0, 0, 0, "B365", 0, 10, "2133, 2400, 2666", 3, 2 },
                    { new Guid("11000000-0000-0000-0000-000000000000"), 20, 5, new DateTime(2020, 4, 16, 18, 18, 34, 832, DateTimeKind.Local).AddTicks(2118), "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.", 48000, "Motherboard", false, false, false, false, "ASUS", "ASUS PRIME Z390-A alaplap", null, 69000, "11000000-0000-0000-0000-000000000000.jpg", "Great motherboard. Gets the job done", "20 years", 0, 0, 0, "Z390", 4, 10, "2133, 2400, 2666, 2800, 3000, 3200, 3300, 3333, 3400, 3466, 3600", 3, 0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "ShortDescription", "Warranty", "BaseClock", "TDP", "Weight", "Capacity", "Kit", "MemoryType1", "Timing" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), 20, 4, new DateTime(2020, 5, 11, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(9820), "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.", null, "Memory", false, false, true, false, "Kingston", "Kingston 2x8GB DDR4 3200MHz HyperX Predator RGB HX432C16PB3AK2/16 memória", null, 41000, "10000000-0000-0000-0000-000000000001.jpg", "High end memory with inbuilt RGB for so many fps!!!", "5 years", 3200, 0, 0, 8, 2, 3, 16 },
                    { new Guid("90000000-0000-0000-0000-000000000000"), 20, 4, new DateTime(2020, 4, 16, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(9753), "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.", 34000, "Memory", false, false, false, false, "Kingston", "Kingston 2x8GB DDR4 3200MHz HyperX Predator XMP HX432C16PB3K2/16 memória", null, 38000, "90000000-0000-0000-0000-000000000000.jpg", "High end memory in amazing white color", "5 years", 3200, 0, 0, 8, 2, 3, 16 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "ShortDescription", "Warranty", "BaseClock", "TDP", "Weight", "ReadSpeed", "Size", "HardDrive_Socket", "WriteSpeed" },
                values: new object[,]
                {
                    { new Guid("80000000-0000-0000-0000-000000000000"), 20, 3, new DateTime(2020, 5, 13, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(8125), "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.", 65000, "HardDrive", false, false, false, false, "Seagate", "Seagate SkyHawk Surveillance 10TB 7200rpm 256MB SATA3 3,5\" HDD", null, 108000, "80000000-0000-0000-0000-000000000000.jpg", "Biggest HDD you've ever seen", "5 years", 0, 0, 0, 50, 10000, 0, 35 },
                    { new Guid("70000000-0000-0000-0000-000000000000"), 0, 3, new DateTime(2020, 4, 16, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(8117), "A Kingston A400 egy 2,5\" -os SSD meghajtó, melynek kapacitása 240 GB és PC vagy notebook felhasználást képes teljesmértékben egy egy erőteljes géppé változtatni. A készülék frissítése még sosem volt egyszerűbb. Összehasonlítva a mechanikus merevlemezekkel azonnal észrevehető a teljesítmény növekedés. Már az indítás során észlelhetjük, hogy az operációs rendszer betöltése sokkal gyorsabb. Ésegyéb műveletek, mint az alkalmazások indítására, másolás vagy mozgó kép indítására sem kell már olyan sokáig várni, mint korábban", null, "HardDrive", false, false, true, false, "Kingston", "Kingston 240GB SA400S37/240G SSD meghajtó", null, 14000, "70000000-0000-0000-0000-000000000000.jpg", "Resonably fast SSD ", "5 years", 0, 0, 0, 500, 240, 1, 350 },
                    { new Guid("60000000-0000-0000-0000-000000000000"), 20, 3, new DateTime(2020, 4, 16, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(8051), null, null, "HardDrive", false, false, false, false, "Samsung", "Samsung 250GB 970 EVO Plus MZ-V7S250BW M.2 PCIe SSD meghajtó", null, 28600, "60000000-0000-0000-0000-000000000000.jpg", "Very fast SSD ", "5 years", 0, 0, 0, 3500, 250, 2, 2300 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "ShortDescription", "Warranty", "BaseClock", "TDP", "Weight", "ATXConnector", "Efficiency", "IsModular", "MolexConnector", "SixPinConnector", "SixPlusTwoConnector" },
                values: new object[] { new Guid("13000000-0000-0000-0000-000000000000"), 20, 6, new DateTime(2020, 4, 16, 18, 18, 34, 832, DateTimeKind.Local).AddTicks(4562), "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.", null, "PowerSupply", false, false, false, false, "Chieftec", "Chieftec ECO 400W GPE-400S tápegység", null, 13700, "13000000-0000-0000-0000-000000000000.jpg", "Cheap ass psu, dont buy this", "3 years", 0, 0, 0, 1, 85, false, 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "ShortDescription", "Warranty", "BaseClock", "TDP", "Weight", "BandWidth", "BuiltInMemory", "CoolerType", "MemoryClock", "MemoryType", "PowerSupplyConnection" },
                values: new object[,]
                {
                    { new Guid("55500000-0000-0000-0000-000000000000"), 15, 1, new DateTime(2020, 5, 14, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(6375), "Új Turing GPU architektúra és Ray-tracing technológia: tükröződés és fejlettebb effektek valós időben. DirectX 12: fejlettebb vizualitás és optimalizált teljesítmény. Axial-tech fans: különleges és egyedi hűtés, halk és hatékony működés. Super Alloy Power II: elsőosztályú alkatrészekkel szerelve a hosszú élettartamért és a stabil energiaellátásért.MaxContact Technology: a hűtőborda hatékonyabb elhelyezésével nő a hővezetőképesség", 370000, "GraphicsCard", false, false, true, false, "MSI", "Asus RTX2080 Ti 11GB GDDR6 ROG-STRIX-RTX2080TI-O11G-GAMING", null, 548590, "55500000-0000-0000-0000-000000000000.jpg", "Best GPU money can buy", "3 years", 1350, 170, 0, 128, 11264, "Active", 14000, 7, "8 + 8" },
                    { new Guid("40000000-0000-0000-0000-000000000000"), 3, 1, new DateTime(2020, 4, 16, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(6266), "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.", 165000, "GraphicsCard", false, false, true, false, "Gigabyte", "Gigabyte RTX2070 Super 8GB GDDR6 GV-N207SGAMINGOC WHITE-8GD videokártya", null, 216000, "40000000-0000-0000-0000-000000000000.jpg", "High end gpu in amazing white color", "5 years", 1770, 215, 0, 256, 8192, "Windforce 3x", 14000, 7, "6 + 8" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "ShortDescription", "Warranty", "BaseClock", "TDP", "Weight", "CoreNumber", "ProcessorFamily", "Socket", "Technology", "ThreadNumber" },
                values: new object[,]
                {
                    { new Guid("33000000-0000-0000-0000-000000000000"), 1, 0, new DateTime(2020, 4, 16, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(3756), "Magok száma:24, Család:AMD Ryzen Threadripper, Processzor foglalat:AMD TR4, Órajel (Mhz):3000, VGA típus:Nem, Fogyasztás (W):250, L3 Cache (MB):64, Architektúra (bit):Zen+, Gyártási technológia (nm):12, Hűtőventilátor:Nem, L2 Cache (MB):12, Hűtőborda:Nem", 410000, "Cpu", false, false, false, false, "AMD", "AMD Ryzen Threadripper 2970WX ", null, 443390, "33000000-0000-0000-0000-000000000000.jpg", "Felsőkategóriás processor, munkaállomásba", "3 years", 3000, 250, 0, 24, "AMD threadripper", 12, 12, 24 },
                    { new Guid("30000000-0000-0000-0000-000000000000"), 10, 0, new DateTime(2020, 4, 16, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(3748), "Magok száma:6, Processzor foglalat:Intel 1151 v2, Család:Coffee Lake, Órajel (Mhz):2900, VGA típus:Nem, Hűtőventilátor:Igen, Fogyasztás (W):65, Architektúra (bit):64, L3 Cache (MB):9, Hűtőborda:Igen, Gyártási technológia (nm):14, L2 Cache (MB):1,5, Szálak száma:6,", null, "Cpu", false, false, false, false, "Intel", "Intel Core i5-9400f", null, 82000, "30000000-0000-0000-0000-000000000000.jpg", "Középkategóriás processor munkára és játékra egyaránt", "3 years", 3500, 45, 0, 4, "Intel core 5", 10, 14, 4 },
                    { new Guid("20000000-0000-0000-0000-000000000000"), 10, 0, new DateTime(2020, 4, 16, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(3737), "Magok száma:6, Processzor foglalat:Intel 1151 v2, Család:Coffee Lake, Órajel (Mhz):3700, VGA típus:Intel UHD Graphics 630, Hűtőventilátor:Nem, Fogyasztás (W):95, Architektúra (bit):64, L3 Cache (MB):9, Hűtőborda:Nem, Gyártási technológia (nm):14, L2 Cache (MB):2, Szálak száma:6,", 65000, "Cpu", false, false, true, false, "Intel", "Intel Core i5-9600K", null, 82000, "20000000-0000-0000-0000-000000000000.jpg", "Very good gaming processor", "3 years", 3700, 65, 0, 6, "Intel core 5", 10, 14, 6 },
                    { new Guid("10000000-0000-0000-0000-000000000000"), 10, 0, new DateTime(2020, 3, 27, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(3601), "A legjobb többprocesszoros teljesítmény az osztályában, a játékosok számára. Jobb teljesítmény. Hihetetlen technológia. Az intelligens Ryzen processzorok csak még okosabbak lettek. ", null, "Cpu", false, false, false, false, "AMD", "AMD Ryzen 3 2200G", null, 31500, "10000000-0000-0000-0000-000000000000.jpg", "So basic processor", "5 years", 3400, 65, 0, 4, "AMD Ryzen 3", 3, 14, 4 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "ShortDescription", "Warranty", "BuiltInFanNumber", "Depth", "HDDNumber", "Height", "SupportedMotherboard", "Width" },
                values: new object[,]
                {
                    { new Guid("31000000-0000-0000-0000-000000000000"), 2, 2, new DateTime(2020, 3, 27, 18, 18, 34, 830, DateTimeKind.Local).AddTicks(9822), "A Thermaltake a számítógépházába összeolvasztotta a szépséget és a teljesítményt, a View 32 Tempered Glass RGB Edition középkategóriás számítógépház tervezésébe. Négy prémium minőségű, 4 mm vastag, edzett üvegablakkal (felső, elülső, bal és jobb) készült, a belső rendszer közvetlen megtekintéséhez és a kiváló alvázvédelemhez. Három beépített 120 mm-es Riing LED RGB ventilátor (kettő elöl és egy hátul) biztosítja az RGB megvilágítását és az optimális szellőzést.", 18000, "Case", false, false, true, false, "Thermaltake", "Thermaltake View 32 Tempered Glass RGB Edition", null, 49000, "31000000-0000-0000-0000-000000000000.jpg", "So much RGB => So much FPS", "3 years", 3, 500, 4, 521, 0, 201 },
                    { new Guid("22000000-0000-0000-0000-000000000000"), 10, 2, new DateTime(2020, 3, 27, 18, 18, 34, 830, DateTimeKind.Local).AddTicks(9733), "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque.", null, "Case", false, false, false, false, "DeepCool", "DeepCool EARLKASE RGB WH fehér számítógép ház", null, 59000, "22000000-0000-0000-0000-000000000000.jpg", "White and big case", "3 years", 3, 500, 4, 511, 0, 204 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "ShortDescription", "Warranty", "BaseClock", "TDP", "Weight", "BandWidth", "BuiltInMemory", "CoolerType", "MemoryClock", "MemoryType", "PowerSupplyConnection" },
                values: new object[] { new Guid("50000000-0000-0000-0000-000000000000"), 0, 1, new DateTime(2020, 5, 14, 18, 18, 34, 831, DateTimeKind.Local).AddTicks(6364), "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.", 79900, "GraphicsCard", false, false, false, false, "MSI", "MSI Radeon RX 5500 XT MECH 8G OC videokártya", null, 85500, "50000000-0000-0000-0000-000000000000.jpg", "Low end basic graphics card for work", "3 years", 1845, 130, 0, 128, 8192, "Active", 14000, 7, "8" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "ShortDescription", "Warranty", "BaseClock", "TDP", "Weight", "ATXConnector", "Efficiency", "IsModular", "MolexConnector", "SixPinConnector", "SixPlusTwoConnector" },
                values: new object[] { new Guid("14000000-0000-0000-0000-000000000000"), 0, 6, new DateTime(2020, 4, 16, 18, 18, 34, 832, DateTimeKind.Local).AddTicks(4653), "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.", 25000, "PowerSupply", false, false, true, false, "FSP", "FSP 650W Hyper M tápegység", null, 29790, "14000000-0000-0000-0000-000000000000.jpg", "You should by this not that chinesee crap", "3 years", 0, 0, 0, 1, 85, true, 3, 0, 4 });

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
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CompletPCs_CaseId",
                table: "CompletPCs",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_CompletPCs_CpuId",
                table: "CompletPCs",
                column: "CpuId");

            migrationBuilder.CreateIndex(
                name: "IX_CompletPCs_GpuId",
                table: "CompletPCs",
                column: "GpuId");

            migrationBuilder.CreateIndex(
                name: "IX_CompletPCs_MotherBoardId",
                table: "CompletPCs",
                column: "MotherBoardId");

            migrationBuilder.CreateIndex(
                name: "IX_CompletPCs_PowerSupplyId",
                table: "CompletPCs",
                column: "PowerSupplyId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_OrderId",
                table: "Items",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PC_Drives_CompletPCId",
                table: "PC_Drives",
                column: "CompletPCId");

            migrationBuilder.CreateIndex(
                name: "IX_PC_Memories_CompletPCId",
                table: "PC_Memories",
                column: "CompletPCId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ItemId",
                table: "Ratings",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCartItems_UserId",
                table: "UserCartItems",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSubscriptions_UserId",
                table: "UserSubscriptions",
                column: "UserId");
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
                name: "PC_Drives");

            migrationBuilder.DropTable(
                name: "PC_Memories");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "UserCartItems");

            migrationBuilder.DropTable(
                name: "UserSubscriptions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CompletPCs");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
