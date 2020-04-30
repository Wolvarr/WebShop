using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.Dal.Migrations
{
    public partial class Init01 : Migration
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
                    ExpectedAvailalbleDate = table.Column<DateTime>(nullable: false),
                    OriginalPrice = table.Column<int>(nullable: false),
                    DiscountedPrice = table.Column<int>(nullable: false),
                    AverageRating = table.Column<int>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Warranty = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    OrderId = table.Column<Guid>(nullable: true),
                    BuildInFanNumber = table.Column<int>(nullable: true),
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
                    WriteSize = table.Column<int>(nullable: true),
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
