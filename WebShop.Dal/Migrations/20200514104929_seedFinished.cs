using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.Dal.Migrations
{
    public partial class seedFinished : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("dd884446-12dc-40c5-beb7-7e3cc7bae998"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("eb83b70c-4e5f-48ab-b3f1-33b902d333f7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4343deb5-9ae6-488c-872d-540f55bb379b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("54c97917-af94-4706-9b85-805458b31ce1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("45732f7d-7888-44ec-adab-a718d6790725"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f4f4b3e1-01f6-486b-809d-7435eb7d1957"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("297dfc2a-8afa-490b-802b-28a70185ea10"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("aa534326-311a-4efe-af84-77e49021668e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ef2ebad3-e2c3-4ff3-bf1c-5a172793589c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1a6159d6-8f03-4e5f-b239-eee901a87071"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("257befe9-f5ae-47dc-9ed4-8e1326dd10e6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1e5457de-1620-4f0a-9052-c9c74cb38f99"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c6cb697b-cf94-4397-a8ad-996f0ee4b661"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("13d5078a-96cc-42d5-9ee5-d8926e3ce0d0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b33d5699-3133-47ae-bf48-4ccd210794de"));

            migrationBuilder.DropColumn(
                name: "ExpectedAvailalbleDate",
                table: "Items");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateSinceInStore",
                table: "Items",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "HighlightedItem",
                table: "Items",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000000"),
                column: "DateSinceInStore",
                value: new DateTime(2020, 3, 25, 12, 49, 28, 975, DateTimeKind.Local).AddTicks(1438));

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BuiltInFanNumber", "Depth", "HDDNumber", "Height", "SupportedMotherboard", "Width" },
                values: new object[,]
                {
                    { new Guid("21000000-0000-0000-0000-000000000000"), 10, 2, new DateTime(2020, 3, 25, 12, 49, 28, 973, DateTimeKind.Local).AddTicks(2336), "Very nice case", null, "Case", false, false, false, false, "Thermaltake", "Thermaltake CA-1P6-00F1WN-00 Level 20 HT számítógépház fekete", null, 59000, "21000000-0000-0000-0000-000000000000", "3 years", 3, 503, 4, 613, 0, 468 },
                    { new Guid("22000000-0000-0000-0000-000000000000"), 10, 2, new DateTime(2020, 3, 25, 12, 49, 28, 974, DateTimeKind.Local).AddTicks(8418), "Very white and big case", null, "Case", false, false, false, false, "DeepCool", "DeepCool EARLKASE RGB WH fehér számítógép ház", null, 59000, "22000000-0000-0000-0000-000000000000", "3 years", 3, 500, 4, 511, 0, 204 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "CoreNumber", "ProcessorFamily", "Socket", "Technology", "ThreadNumber" },
                values: new object[,]
                {
                    { new Guid("20000000-0000-0000-0000-000000000000"), 10, 0, new DateTime(2020, 4, 14, 12, 49, 28, 975, DateTimeKind.Local).AddTicks(1573), "Very good gaming processor", 75000, "Cpu", false, false, true, false, "Intel", "Intel Core i5-9600K", null, 82000, "20000000-0000-0000-0000-000000000000", "3 years", 3700, 65, 0, 6, "Intel core 5", 10, 14, 6 },
                    { new Guid("30000000-0000-0000-0000-000000000000"), 10, 0, new DateTime(2020, 4, 14, 12, 49, 28, 975, DateTimeKind.Local).AddTicks(1583), "Középkategóriás processor munkára és játékra egyaránt", null, "Cpu", false, false, false, false, "Intel", "Intel Core i5-9400f", null, 82000, "30000000-0000-0000-0000-000000000000", "3 years", 3500, 45, 0, 4, "Intel core 5", 10, 14, 4 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "BandWidth", "BuiltInMemory", "CoolerType", "MemoryClock", "MemoryType", "PowerSupplyConnection" },
                values: new object[,]
                {
                    { new Guid("40000000-0000-0000-0000-000000000000"), 3, 1, new DateTime(2020, 4, 14, 12, 49, 28, 975, DateTimeKind.Local).AddTicks(3810), "High end gpu in amazing white color", null, "GraphicsCard", false, false, true, false, "Gigabyte", "Gigabyte RTX2070 Super 8GB GDDR6 GV-N207SGAMINGOC WHITE-8GD videokártya", null, 216000, "40000000-0000-0000-0000-000000000000", "5 years", 1770, 215, 0, 256, 8192, "Windforce 3x", 14000, 7, "6 + 8" },
                    { new Guid("50000000-0000-0000-0000-000000000000"), 15, 1, new DateTime(2020, 5, 12, 12, 49, 28, 975, DateTimeKind.Local).AddTicks(3894), "Low end basic graphics card for work", 79900, "GraphicsCard", false, false, false, false, "MSI", "MSI Radeon RX 5500 XT MECH 8G OC videokártya", null, 85500, "50000000-0000-0000-0000-000000000000", "3 years", 1845, 130, 0, 128, 8192, "Active", 14000, 7, "8" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "ReadSpeed", "Size", "HardDrive_Socket", "WriteSpeed" },
                values: new object[,]
                {
                    { new Guid("60000000-0000-0000-0000-000000000000"), 20, 3, new DateTime(2020, 4, 14, 12, 49, 28, 975, DateTimeKind.Local).AddTicks(5484), "Very fast SSD ", null, "HardDrive", false, false, false, false, "Samsung", "Samsung 250GB 970 EVO Plus MZ-V7S250BW M.2 PCIe SSD meghajtó", null, 28600, "60000000-0000-0000-0000-000000000000", "5 years", 0, 0, 0, 3500, 250, 2, 2300 },
                    { new Guid("70000000-0000-0000-0000-000000000000"), 50, 3, new DateTime(2020, 4, 14, 12, 49, 28, 975, DateTimeKind.Local).AddTicks(5544), "Resonably fast SSD ", null, "HardDrive", false, false, true, false, "Kingston", "Kingston 240GB SA400S37/240G SSD meghajtó", null, 14000, "70000000-0000-0000-0000-000000000000", "5 years", 0, 0, 0, 500, 240, 1, 350 },
                    { new Guid("80000000-0000-0000-0000-000000000000"), 20, 3, new DateTime(2020, 5, 11, 12, 49, 28, 975, DateTimeKind.Local).AddTicks(5552), "Biggest HDD you've ever seen", null, "HardDrive", false, false, false, false, "Seagate", "Seagate SkyHawk Surveillance 10TB 7200rpm 256MB SATA3 3,5\" HDD", null, 108000, "80000000-0000-0000-0000-000000000000", "5 years", 0, 0, 0, 50, 10000, 0, 35 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "Capacity", "Kit", "MemoryType1", "Timing" },
                values: new object[,]
                {
                    { new Guid("90000000-0000-0000-0000-000000000000"), 20, 4, new DateTime(2020, 4, 14, 12, 49, 28, 975, DateTimeKind.Local).AddTicks(7208), "High end memory in amazing white color", 34000, "Memory", false, false, false, false, "Kingston", "Kingston 2x8GB DDR4 3200MHz HyperX Predator XMP HX432C16PB3K2/16 memória", null, 38000, "90000000-0000-0000-0000-000000000000", "5 years", 3200, 0, 0, 8, 2, 3, 16 },
                    { new Guid("10000000-0000-0000-0000-000000000001"), 20, 4, new DateTime(2020, 5, 9, 12, 49, 28, 975, DateTimeKind.Local).AddTicks(7272), "High end memory with inbuilt RGB for so many fps!!!", null, "Memory", false, false, true, false, "Kingston", "Kingston 2x8GB DDR4 3200MHz HyperX Predator RGB HX432C16PB3AK2/16 memória", null, 41000, "10000000-0000-0000-0000-000000000001", "5 years", 3200, 0, 0, 8, 2, 3, 16 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "Chipset", "MemorySocketNumber", "Motherboard_Socket", "SupportedMemorySpeed", "SupportedMemoryType", "Type" },
                values: new object[,]
                {
                    { new Guid("11000000-0000-0000-0000-000000000000"), 20, 5, new DateTime(2020, 4, 14, 12, 49, 28, 975, DateTimeKind.Local).AddTicks(9496), "Great motherboard. Gets shit done", null, "Motherboard", false, false, false, false, "ASUS", null, null, 66000, "11000000-0000-0000-0000-000000000000", "20 years", 0, 0, 0, "Z390", 4, 10, "2133, 2400, 2666, 2800, 3000, 3200, 3300, 3333, 3400, 3466, 3600, 3733, 3866, 4000, 4133, 4266", 3, 0 },
                    { new Guid("12000000-0000-0000-0000-000000000000"), 20, 5, new DateTime(2020, 4, 14, 12, 49, 28, 975, DateTimeKind.Local).AddTicks(9562), "Basic motherboard. No overcloccing here", null, "Motherboard", false, false, false, false, "Gigabyte", "Gigabyte GA-B365-D3H alaplap", null, 35000, "12000000-0000-0000-0000-000000000000", "2 years", 0, 0, 0, "B365", 0, 10, "2133, 2400, 2666", 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "DateSinceInStore", "Description", "DiscountedPrice", "Discriminator", "GamingFlag", "HasRGB", "HighlightedItem", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "ATXConnector", "Efficiency", "IsModular", "MolexConnector", "SixPinConnector", "SixPlusTwoConnector" },
                values: new object[,]
                {
                    { new Guid("13000000-0000-0000-0000-000000000000"), 20, 6, new DateTime(2020, 4, 14, 12, 49, 28, 976, DateTimeKind.Local).AddTicks(1697), "Cheap ass psu, dont buy this", null, "PowerSupply", false, false, false, false, "Chieftec", "Chieftec ECO 400W GPE-400S tápegység", null, 13700, "13000000-0000-0000-0000-000000000000", "3 years", 0, 0, 0, 1, 85, false, 2, 0, 0 },
                    { new Guid("14000000-0000-0000-0000-000000000000"), 20, 6, new DateTime(2020, 4, 14, 12, 49, 28, 976, DateTimeKind.Local).AddTicks(1782), "You should by this not that chinesee shit", 25000, "PowerSupply", false, false, true, false, "FSP", "FSP 650W Hyper M tápegység", null, 29790, "14000000-0000-0000-0000-000000000000", "3 years", 0, 0, 0, 1, 85, true, 3, 0, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("22000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("70000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("80000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("90000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("11000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("12000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("13000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("14000000-0000-0000-0000-000000000000"));

            migrationBuilder.DropColumn(
                name: "DateSinceInStore",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "HighlightedItem",
                table: "Items");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpectedAvailalbleDate",
                table: "Items",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "GamingFlag", "HasRGB", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BuiltInFanNumber", "Depth", "HDDNumber", "Height", "SupportedMotherboard", "Width" },
                values: new object[,]
                {
                    { new Guid("eb83b70c-4e5f-48ab-b3f1-33b902d333f7"), 10, 2, "Very nice case", null, "Case", null, false, false, false, "Thermaltake", "Thermaltake CA-1P6-00F1WN-00 Level 20 HT számítógépház fekete", null, 59000, "", "3 years", 3, 503, 4, 613, 0, 468 },
                    { new Guid("dd884446-12dc-40c5-beb7-7e3cc7bae998"), 10, 2, "Very white and big case", null, "Case", null, false, false, false, "DeepCool", "DeepCool EARLKASE RGB WH fehér számítógép ház", null, 59000, "", "3 years", 3, 500, 4, 511, 0, 204 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "GamingFlag", "HasRGB", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "CoreNumber", "ProcessorFamily", "Socket", "Technology", "ThreadNumber" },
                values: new object[,]
                {
                    { new Guid("4343deb5-9ae6-488c-872d-540f55bb379b"), 10, 0, "Very good gaming processor", null, "Cpu", null, false, false, false, "Intel", "Intel Core i5-9600K", null, 82000, "", "3 years", 3700, 65, 0, 6, "Intel core 5", 10, 14, 6 },
                    { new Guid("54c97917-af94-4706-9b85-805458b31ce1"), 10, 0, "Középkategóriás processor munkára és játékra egyaránt", null, "Cpu", null, false, false, false, "Intel", "Intel Core i5-9400f", null, 82000, "", "3 years", 3500, 45, 0, 4, "Intel core 5", 10, 14, 4 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "GamingFlag", "HasRGB", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "BandWidth", "BuiltInMemory", "CoolerType", "MemoryClock", "MemoryType", "PowerSupplyConnection" },
                values: new object[,]
                {
                    { new Guid("45732f7d-7888-44ec-adab-a718d6790725"), 3, 1, "High end gpu in amazing white color", null, "GraphicsCard", null, false, false, false, "Gigabyte", "Gigabyte RTX2070 Super 8GB GDDR6 GV-N207SGAMINGOC WHITE-8GD videokártya", null, 216000, "", "5 years", 1770, 215, 0, 256, 8192, "Windforce 3x", 14000, 7, "6 + 8" },
                    { new Guid("f4f4b3e1-01f6-486b-809d-7435eb7d1957"), 15, 1, "Low end basic graphics card for work", null, "GraphicsCard", null, false, false, false, "MSI", "MSI Radeon RX 5500 XT MECH 8G OC videokártya", null, 85500, "", "3 years", 1845, 130, 0, 128, 8192, "Active", 14000, 7, "8" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "GamingFlag", "HasRGB", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "ReadSpeed", "Size", "HardDrive_Socket", "WriteSpeed" },
                values: new object[,]
                {
                    { new Guid("297dfc2a-8afa-490b-802b-28a70185ea10"), 20, 3, "Very fast SSD ", null, "HardDrive", null, false, false, false, "Samsung", "Samsung 250GB 970 EVO Plus MZ-V7S250BW M.2 PCIe SSD meghajtó", null, 28600, "", "5 years", 0, 0, 0, 3500, 250, 2, 2300 },
                    { new Guid("ef2ebad3-e2c3-4ff3-bf1c-5a172793589c"), 50, 3, "Resonably fast SSD ", null, "HardDrive", null, false, false, false, "Kingston", "Kingston 240GB SA400S37/240G SSD meghajtó", null, 14000, "", "5 years", 0, 0, 0, 500, 240, 1, 350 },
                    { new Guid("aa534326-311a-4efe-af84-77e49021668e"), 20, 3, "Biggest HDD you've ever seen", null, "HardDrive", null, false, false, false, "Seagate", "Seagate SkyHawk Surveillance 10TB 7200rpm 256MB SATA3 3,5\" HDD", null, 108000, "", "5 years", 0, 0, 0, 50, 10000, 0, 35 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "GamingFlag", "HasRGB", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "Capacity", "Kit", "MemoryType1", "Timing" },
                values: new object[,]
                {
                    { new Guid("1a6159d6-8f03-4e5f-b239-eee901a87071"), 20, 4, "High end memory in amazing white color", null, "Memory", null, false, false, false, "Kingston", "Kingston 2x8GB DDR4 3200MHz HyperX Predator XMP HX432C16PB3K2/16 memória", null, 38000, "", "5 years", 3200, 0, 0, 8, 2, 3, 16 },
                    { new Guid("257befe9-f5ae-47dc-9ed4-8e1326dd10e6"), 20, 4, "High end memory with inbuilt RGB for so many fps!!!", null, "Memory", null, false, false, false, "Kingston", "Kingston 2x8GB DDR4 3200MHz HyperX Predator RGB HX432C16PB3AK2/16 memória", null, 41000, "", "5 years", 3200, 0, 0, 8, 2, 3, 16 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "GamingFlag", "HasRGB", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "Chipset", "MemorySocketNumber", "Motherboard_Socket", "SupportedMemorySpeed", "SupportedMemoryType", "Type" },
                values: new object[,]
                {
                    { new Guid("c6cb697b-cf94-4397-a8ad-996f0ee4b661"), 20, 5, "Great motherboard. Gets shit done", null, "Motherboard", null, false, false, false, "ASUS", "Asus Prime Z390-A alaplap", null, 66000, "", "20 years", 0, 0, 0, "Z390", 4, 10, "2133, 2400, 2666, 2800, 3000, 3200, 3300, 3333, 3400, 3466, 3600, 3733, 3866, 4000, 4133, 4266", 3, 0 },
                    { new Guid("1e5457de-1620-4f0a-9052-c9c74cb38f99"), 20, 5, "Basic motherboard. No overcloccing here", null, "Motherboard", null, false, false, false, "Gigabyte", "Gigabyte GA-B365-D3H alaplap", null, 35000, "", "2 years", 0, 0, 0, "B365", 0, 10, "2133, 2400, 2666", 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "GamingFlag", "HasRGB", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "ATXConnector", "Efficiency", "IsModular", "MolexConnector", "SixPinConnector", "SixPlusTwoConnector" },
                values: new object[,]
                {
                    { new Guid("b33d5699-3133-47ae-bf48-4ccd210794de"), 20, 6, "Cheap ass psu, dont buy this", null, "PowerSupply", null, false, false, false, "Chieftec", "Chieftec ECO 400W GPE-400S tápegység", null, 13700, "", "3 years", 0, 0, 0, 1, 85, false, 2, 0, 0 },
                    { new Guid("13d5078a-96cc-42d5-9ee5-d8926e3ce0d0"), 20, 6, "You should by this not that chinesee shit", null, "PowerSupply", null, false, false, false, "FSP", "FSP 650W Hyper M tápegység", null, 29790, "", "3 years", 0, 0, 0, 1, 85, true, 3, 0, 4 }
                });
        }
    }
}
