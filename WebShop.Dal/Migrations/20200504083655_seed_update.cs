using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.Dal.Migrations
{
    public partial class seed_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("77c9fcae-be22-4f12-b7fa-ab7dc58ae64d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fbd75247-0798-4784-974a-834d9869a70a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("972fda98-c4ed-4cbc-a79d-195821607f34"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b7b94c1a-cb39-48d5-b0b4-4a04f48127fc"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c6bca433-7702-43bf-90a0-7ef69cb55a33"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c7727cfc-9189-447e-bda2-9d516d75c0aa"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5982c152-3cb1-4e28-a3a1-8fa5497528c4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("82d18601-bfe8-4343-9718-7ddfb978c65d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e86e1c39-99b4-43c8-9916-fc026f9cdd85"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("286e1aa8-ebd1-4454-b0b7-345770d8f503"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c73edf2d-b6ee-4abe-808e-c509956f4639"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7aae5ffd-9f7e-4162-8e5e-8088119b0d67"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c578f03e-2a39-41d3-897d-6423db6afe9d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("65803f10-dabe-4783-9dda-b55a6bfa5a70"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("91899ffa-4e5b-4646-9552-616518ebc317"));

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
                    { new Guid("10000000-0000-0000-0000-000000000000"), 10, 0, @"So basic processor
                 random leírás ami ki tesz több sort, hogy kiderüljön, hogy a ui-on mégiscsak ugyanmár hogy a faszba néz ki.", null, "Cpu", null, false, false, false, "AMD", "AMD Ryzen 3 2200G", null, 31500, "10000000-0000-0000-0000-000000000000", "5 years", 3400, 65, 0, 4, "AMD Ryzen 3", 3, 14, 4 },
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("10000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "GamingFlag", "HasRGB", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BuiltInFanNumber", "Depth", "HDDNumber", "Height", "SupportedMotherboard", "Width" },
                values: new object[,]
                {
                    { new Guid("77c9fcae-be22-4f12-b7fa-ab7dc58ae64d"), 10, 0, "Very nice case", null, "Case", null, false, false, false, "Thermaltake", "Thermaltake CA-1P6-00F1WN-00 Level 20 HT számítógépház fekete", null, 59000, "", "3 years", 3, 503, 4, 613, 0, 468 },
                    { new Guid("fbd75247-0798-4784-974a-834d9869a70a"), 10, 0, "Very white and big case", null, "Case", null, false, false, false, "DeepCool", "DeepCool EARLKASE RGB WH fehér számítógép ház", null, 59000, "", "3 years", 3, 500, 4, 511, 0, 204 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "GamingFlag", "HasRGB", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "CoreNumber", "ProcessorFamily", "Socket", "Technology", "ThreadNumber" },
                values: new object[,]
                {
                    { new Guid("b7b94c1a-cb39-48d5-b0b4-4a04f48127fc"), 10, 0, "So basic processor", null, "Cpu", null, false, false, false, "AMD", "AMD Ryzen 3 2200G", null, 31500, "", "5 years", 3400, 65, 0, 4, "AMD Ryzen 3", 3, 14, 4 },
                    { new Guid("972fda98-c4ed-4cbc-a79d-195821607f34"), 10, 0, "Very good gaming processor", null, "Cpu", null, false, false, false, "Intel", "Intel Core i5-9600K", null, 82000, "", "3 years", 3700, 65, 0, 6, "Intel core 5", 10, 14, 6 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "GamingFlag", "HasRGB", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "BandWidth", "BuiltInMemory", "CoolerType", "MemoryClock", "MemoryType", "PowerSupplyConnection" },
                values: new object[,]
                {
                    { new Guid("c6bca433-7702-43bf-90a0-7ef69cb55a33"), 3, 0, "High end gpu in amazing white color", null, "GraphicsCard", null, false, false, false, "Gigabyte", "Gigabyte RTX2070 Super 8GB GDDR6 GV-N207SGAMINGOC WHITE-8GD videokártya", null, 216000, "", "5 years", 1770, 215, 0, 256, 8192, "Windforce 3x", 14000, 7, "6 + 8" },
                    { new Guid("c7727cfc-9189-447e-bda2-9d516d75c0aa"), 15, 0, "Low end basic graphics card for work", null, "GraphicsCard", null, false, false, false, "MSI", "MSI Radeon RX 5500 XT MECH 8G OC videokártya", null, 85500, "", "3 years", 1845, 130, 0, 128, 8192, "Active", 14000, 7, "8" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "GamingFlag", "HasRGB", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "ReadSpeed", "Size", "HardDrive_Socket", "WriteSpeed" },
                values: new object[,]
                {
                    { new Guid("e86e1c39-99b4-43c8-9916-fc026f9cdd85"), 20, 0, "Very fast SSD ", null, "HardDrive", null, false, false, false, "Samsung", "Samsung 250GB 970 EVO Plus MZ-V7S250BW M.2 PCIe SSD meghajtó", null, 28600, "", "5 years", 0, 0, 0, 3500, 250, 2, 2300 },
                    { new Guid("82d18601-bfe8-4343-9718-7ddfb978c65d"), 50, 0, "Resonably fast SSD ", null, "HardDrive", null, false, false, false, "Kingston", "Kingston 240GB SA400S37/240G SSD meghajtó", null, 14000, "", "5 years", 0, 0, 0, 500, 240, 1, 350 },
                    { new Guid("5982c152-3cb1-4e28-a3a1-8fa5497528c4"), 20, 0, "Biggest HDD you've ever seen", null, "HardDrive", null, false, false, false, "Seagate", "Seagate SkyHawk Surveillance 10TB 7200rpm 256MB SATA3 3,5\" HDD", null, 108000, "", "5 years", 0, 0, 0, 50, 10000, 0, 35 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "GamingFlag", "HasRGB", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "Capacity", "Kit", "MemoryType1", "Timing" },
                values: new object[,]
                {
                    { new Guid("286e1aa8-ebd1-4454-b0b7-345770d8f503"), 20, 0, "High end memory in amazing white color", null, "Memory", null, false, false, false, "Kingston", "Kingston 2x8GB DDR4 3200MHz HyperX Predator XMP HX432C16PB3K2/16 memória", null, 38000, "", "5 years", 3200, 0, 0, 8, 2, 3, 16 },
                    { new Guid("c73edf2d-b6ee-4abe-808e-c509956f4639"), 20, 0, "High end memory with inbuilt RGB for so many fps!!!", null, "Memory", null, false, false, false, "Kingston", "Kingston 2x8GB DDR4 3200MHz HyperX Predator RGB HX432C16PB3AK2/16 memória", null, 41000, "", "5 years", 3200, 0, 0, 8, 2, 3, 16 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "GamingFlag", "HasRGB", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "Chipset", "MemorySocketNumber", "Motherboard_Socket", "SupportedMemorySpeed", "SupportedMemoryType", "Type" },
                values: new object[,]
                {
                    { new Guid("c578f03e-2a39-41d3-897d-6423db6afe9d"), 20, 0, "Great motherboard. Gets shit done", null, "Motherboard", null, false, false, false, "ASUS", "Asus Prime Z390-A alaplap", null, 66000, "", "20 years", 0, 0, 0, "Z390", 4, 10, "2133, 2400, 2666, 2800, 3000, 3200, 3300, 3333, 3400, 3466, 3600, 3733, 3866, 4000, 4133, 4266", 3, 0 },
                    { new Guid("7aae5ffd-9f7e-4162-8e5e-8088119b0d67"), 20, 0, "Basic motherboard. No overcloccing here", null, "Motherboard", null, false, false, false, "Gigabyte", "Gigabyte GA-B365-D3H alaplap", null, 35000, "", "2 years", 0, 0, 0, "B365", 0, 10, "2133, 2400, 2666", 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "GamingFlag", "HasRGB", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "ATXConnector", "Efficiency", "IsModular", "MolexConnector", "SixPinConnector", "SixPlusTwoConnector" },
                values: new object[,]
                {
                    { new Guid("91899ffa-4e5b-4646-9552-616518ebc317"), 20, 0, "Cheap ass psu, dont buy this", null, "PowerSupply", null, false, false, false, "Chieftec", "Chieftec ECO 400W GPE-400S tápegység", null, 13700, "", "3 years", 0, 0, 0, 1, 85, false, 2, 0, 0 },
                    { new Guid("65803f10-dabe-4783-9dda-b55a6bfa5a70"), 20, 0, "You should by this not that chinesee shit", null, "PowerSupply", null, false, false, false, "FSP", "FSP 650W Hyper M tápegység", null, 29790, "", "3 years", 0, 0, 0, 1, 85, true, 3, 0, 4 }
                });
        }
    }
}
