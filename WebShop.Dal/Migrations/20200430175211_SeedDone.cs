using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.Dal.Migrations
{
    public partial class SeedDone : Migration
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
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Available = table.Column<int>(nullable: false),
                    PicturePath = table.Column<string>(nullable: true),
                    ExpectedAvailalbleDate = table.Column<DateTime>(nullable: true),
                    OriginalPrice = table.Column<int>(nullable: false),
                    DiscountedPrice = table.Column<int>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Warranty = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    OrderId = table.Column<Guid>(nullable: true),
                    BuiltInFanNumber = table.Column<int>(nullable: true),
                    SupportedMotherboard = table.Column<int>(nullable: true),
                    Heigth = table.Column<int>(nullable: true),
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
                    table.UniqueConstraint("AK_Ratings_ItemId_UserId", x => new { x.ItemId, x.UserId });
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
                columns: new[] { "Id", "Available", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BuiltInFanNumber", "Depth", "HDDNumber", "Heigth", "SupportedMotherboard", "Width" },
                values: new object[,]
                {
                    { new Guid("04092a85-820c-4d74-bb16-d8211d9a0486"), 10, "Very nice case", null, "Case", null, "Thermaltake", "Thermaltake CA-1P6-00F1WN-00 Level 20 HT számítógépház fekete", null, 59000, "", "3 years", 3, 503, 4, 613, 0, 468 },
                    { new Guid("f4099481-9168-45cf-ad0d-8a1ff5eb125d"), 10, "Very white and big case", null, "Case", null, "DeepCool", "DeepCool EARLKASE RGB WH fehér számítógép ház", null, 59000, "", "3 years", 3, 500, 4, 511, 0, 204 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "CoreNumber", "ProcessorFamily", "Socket", "Technology", "ThreadNumber" },
                values: new object[,]
                {
                    { new Guid("f90a3c5a-9d32-4c9b-bc0b-003fc6c0c246"), 10, "So basic processor", null, "Cpu", null, "AMD", "AMD Ryzen 3 2200G", null, 31500, "", "5 years", 3400, 65, 0, 4, "AMD Ryzen 3", 3, 14, 4 },
                    { new Guid("b6ffb02a-3623-43fa-bed6-2886eb6f26cb"), 10, "Very good gaming processor", null, "Cpu", null, "Intel", "Intel Core i5-9600K", null, 82000, "", "3 years", 3700, 65, 0, 6, "Intel core 5", 10, 14, 6 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "BandWidth", "BuiltInMemory", "CoolerType", "MemoryClock", "MemoryType", "PowerSupplyConnection" },
                values: new object[,]
                {
                    { new Guid("be11e82a-d759-4f14-9a3d-3dfc1980ec37"), 3, "High end gpu in amazing white color", null, "GraphicsCard", null, "Gigabyte", "Gigabyte RTX2070 Super 8GB GDDR6 GV-N207SGAMINGOC WHITE-8GD videokártya", null, 216000, "", "5 years", 1770, 215, 0, 256, 8192, "Windforce 3x", 14000, 7, "6 + 8" },
                    { new Guid("6d1f6d66-ca74-47d0-a41e-7b06d13ef4b1"), 15, "Low end basic graphics card for work", null, "GraphicsCard", null, "MSI", "MSI Radeon RX 5500 XT MECH 8G OC videokártya", null, 85500, "", "3 years", 1845, 130, 0, 128, 8192, "Active", 14000, 7, "8" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "ReadSpeed", "Size", "HardDrive_Socket", "WriteSpeed" },
                values: new object[,]
                {
                    { new Guid("0ce851c3-827a-4372-8ae7-d59f817a3023"), 20, "Very fast SSD ", null, "HardDrive", null, "Samsung", "Samsung 250GB 970 EVO Plus MZ-V7S250BW M.2 PCIe SSD meghajtó", null, 28600, "", "5 years", 0, 0, 0, 3500, 250, 2, 2300 },
                    { new Guid("f3212a53-9952-40bb-a62f-2487ca73c321"), 50, "Resonably fast SSD ", null, "HardDrive", null, "Kingston", "Kingston 240GB SA400S37/240G SSD meghajtó", null, 14000, "", "5 years", 0, 0, 0, 500, 240, 1, 350 },
                    { new Guid("fe80a0c0-c034-4a6b-8b1f-bbd14788323f"), 20, "Biggest HDD you've ever seen", null, "HardDrive", null, "Seagate", "Seagate SkyHawk Surveillance 10TB 7200rpm 256MB SATA3 3,5\" HDD", null, 108000, "", "5 years", 0, 0, 0, 50, 10000, 0, 35 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "Capacity", "Kit", "MemoryType1", "Timing" },
                values: new object[,]
                {
                    { new Guid("90734580-ca21-404b-956d-d5c98a6c44c6"), 20, "High end memory in amazing white color", null, "Memory", null, "Kingston", "Kingston 2x8GB DDR4 3200MHz HyperX Predator XMP HX432C16PB3K2/16 memória", null, 38000, "", "5 years", 3200, 0, 0, 8, 2, 3, 16 },
                    { new Guid("ef0f10d9-f90c-4197-a752-c71abdce0b8e"), 20, "High end memory with inbuilt RGB for so many fps!!!", null, "Memory", null, "Kingston", "Kingston 2x8GB DDR4 3200MHz HyperX Predator RGB HX432C16PB3AK2/16 memória", null, 41000, "", "5 years", 3200, 0, 0, 8, 2, 3, 16 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "Chipset", "MemorySocketNumber", "Motherboard_Socket", "SupportedMemorySpeed", "SupportedMemoryType", "Type" },
                values: new object[,]
                {
                    { new Guid("0d406cec-4a45-4b25-86b1-7b7969bd8e83"), 20, "Great motherboard. Gets shit done", null, "Motherboard", null, "ASUS", "Asus Prime Z390-A alaplap", null, 66000, "", "20 years", 0, 0, 0, "Z390", 4, 10, "2133, 2400, 2666, 2800, 3000, 3200, 3300, 3333, 3400, 3466, 3600, 3733, 3866, 4000, 4133, 4266", 3, 0 },
                    { new Guid("fb60813f-08cf-42de-afbb-9b7badbb2b5e"), 20, "Basic motherboard. No overcloccing here", null, "Motherboard", null, "Gigabyte", "Gigabyte GA-B365-D3H alaplap", null, 35000, "", "2 years", 0, 0, 0, "B365", 0, 10, "2133, 2400, 2666", 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "ATXConnector", "Efficiency", "IsModular", "MolexConnector", "SixPinConnector", "SixPlusTwoConnector" },
                values: new object[,]
                {
                    { new Guid("e5bf1add-8aba-42c6-96b5-c8bee3d8c02b"), 20, "Cheap ass psu, dont buy this", null, "PowerSupply", null, "Chieftec", "Chieftec ECO 400W GPE-400S tápegység", null, 13700, "", "3 years", 0, 0, 0, 1, 85, false, 2, 0, 0 },
                    { new Guid("e627406d-b2ef-49c7-94a7-d1353c06f644"), 20, "You should by this not that chinesee shit", null, "PowerSupply", null, "FSP", "FSP 650W Hyper M tápegység", null, 29790, "", "3 years", 0, 0, 0, 1, 85, true, 3, 0, 4 }
                });

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
                name: "IX_Ratings_UserId",
                table: "Ratings",
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
