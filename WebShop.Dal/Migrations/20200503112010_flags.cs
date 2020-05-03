using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.Dal.Migrations
{
    public partial class flags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("04092a85-820c-4d74-bb16-d8211d9a0486"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f4099481-9168-45cf-ad0d-8a1ff5eb125d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b6ffb02a-3623-43fa-bed6-2886eb6f26cb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f90a3c5a-9d32-4c9b-bc0b-003fc6c0c246"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6d1f6d66-ca74-47d0-a41e-7b06d13ef4b1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("be11e82a-d759-4f14-9a3d-3dfc1980ec37"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0ce851c3-827a-4372-8ae7-d59f817a3023"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f3212a53-9952-40bb-a62f-2487ca73c321"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fe80a0c0-c034-4a6b-8b1f-bbd14788323f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("90734580-ca21-404b-956d-d5c98a6c44c6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ef0f10d9-f90c-4197-a752-c71abdce0b8e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0d406cec-4a45-4b25-86b1-7b7969bd8e83"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fb60813f-08cf-42de-afbb-9b7badbb2b5e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e5bf1add-8aba-42c6-96b5-c8bee3d8c02b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e627406d-b2ef-49c7-94a7-d1353c06f644"));

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "GamingFlag",
                table: "Items",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasRGB",
                table: "Items",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsUsed",
                table: "Items",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "GamingFlag", "HasRGB", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BuiltInFanNumber", "Depth", "HDDNumber", "Heigth", "SupportedMotherboard", "Width" },
                values: new object[,]
                {
                    { new Guid("8569cf4d-68b3-4a48-bca7-06102bb68b9d"), 10, 0, "Very nice case", null, "Case", null, false, false, false, "Thermaltake", "Thermaltake CA-1P6-00F1WN-00 Level 20 HT számítógépház fekete", null, 59000, "", "3 years", 3, 503, 4, 613, 0, 468 },
                    { new Guid("b79bacb5-70db-4c08-9d05-7155e7b35005"), 10, 0, "Very white and big case", null, "Case", null, false, false, false, "DeepCool", "DeepCool EARLKASE RGB WH fehér számítógép ház", null, 59000, "", "3 years", 3, 500, 4, 511, 0, 204 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "GamingFlag", "HasRGB", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "CoreNumber", "ProcessorFamily", "Socket", "Technology", "ThreadNumber" },
                values: new object[,]
                {
                    { new Guid("6a982928-1e11-4cf5-924d-f776e0c8cda4"), 10, 0, "So basic processor", null, "Cpu", null, false, false, false, "AMD", "AMD Ryzen 3 2200G", null, 31500, "", "5 years", 3400, 65, 0, 4, "AMD Ryzen 3", 3, 14, 4 },
                    { new Guid("b1ee4fad-5615-4bd9-af03-f8343d3bcd29"), 10, 0, "Very good gaming processor", null, "Cpu", null, false, false, false, "Intel", "Intel Core i5-9600K", null, 82000, "", "3 years", 3700, 65, 0, 6, "Intel core 5", 10, 14, 6 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "GamingFlag", "HasRGB", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "BandWidth", "BuiltInMemory", "CoolerType", "MemoryClock", "MemoryType", "PowerSupplyConnection" },
                values: new object[,]
                {
                    { new Guid("861a5b7d-71ae-47b5-835e-57450def44cf"), 3, 0, "High end gpu in amazing white color", null, "GraphicsCard", null, false, false, false, "Gigabyte", "Gigabyte RTX2070 Super 8GB GDDR6 GV-N207SGAMINGOC WHITE-8GD videokártya", null, 216000, "", "5 years", 1770, 215, 0, 256, 8192, "Windforce 3x", 14000, 7, "6 + 8" },
                    { new Guid("2107df63-d2af-4e87-be13-47e3471d85bc"), 15, 0, "Low end basic graphics card for work", null, "GraphicsCard", null, false, false, false, "MSI", "MSI Radeon RX 5500 XT MECH 8G OC videokártya", null, 85500, "", "3 years", 1845, 130, 0, 128, 8192, "Active", 14000, 7, "8" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "GamingFlag", "HasRGB", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "ReadSpeed", "Size", "HardDrive_Socket", "WriteSpeed" },
                values: new object[,]
                {
                    { new Guid("bb8fd077-9289-4185-9ef5-fab7090c03cd"), 20, 0, "Very fast SSD ", null, "HardDrive", null, false, false, false, "Samsung", "Samsung 250GB 970 EVO Plus MZ-V7S250BW M.2 PCIe SSD meghajtó", null, 28600, "", "5 years", 0, 0, 0, 3500, 250, 2, 2300 },
                    { new Guid("9be8e5b8-ed88-4fde-9dd4-38e7f0342ab9"), 50, 0, "Resonably fast SSD ", null, "HardDrive", null, false, false, false, "Kingston", "Kingston 240GB SA400S37/240G SSD meghajtó", null, 14000, "", "5 years", 0, 0, 0, 500, 240, 1, 350 },
                    { new Guid("d063a055-7e0d-4e75-8b6f-43eb5f56deaf"), 20, 0, "Biggest HDD you've ever seen", null, "HardDrive", null, false, false, false, "Seagate", "Seagate SkyHawk Surveillance 10TB 7200rpm 256MB SATA3 3,5\" HDD", null, 108000, "", "5 years", 0, 0, 0, 50, 10000, 0, 35 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "GamingFlag", "HasRGB", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "Capacity", "Kit", "MemoryType1", "Timing" },
                values: new object[,]
                {
                    { new Guid("f4d1a769-3479-4fd5-b614-1dbc9c3684c5"), 20, 0, "High end memory in amazing white color", null, "Memory", null, false, false, false, "Kingston", "Kingston 2x8GB DDR4 3200MHz HyperX Predator XMP HX432C16PB3K2/16 memória", null, 38000, "", "5 years", 3200, 0, 0, 8, 2, 3, 16 },
                    { new Guid("6d5e69b1-3bd5-4fdd-85e3-270e177b9497"), 20, 0, "High end memory with inbuilt RGB for so many fps!!!", null, "Memory", null, false, false, false, "Kingston", "Kingston 2x8GB DDR4 3200MHz HyperX Predator RGB HX432C16PB3AK2/16 memória", null, 41000, "", "5 years", 3200, 0, 0, 8, 2, 3, 16 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "GamingFlag", "HasRGB", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "Chipset", "MemorySocketNumber", "Motherboard_Socket", "SupportedMemorySpeed", "SupportedMemoryType", "Type" },
                values: new object[,]
                {
                    { new Guid("d5491921-19e0-457a-b585-791a637998d8"), 20, 0, "Great motherboard. Gets shit done", null, "Motherboard", null, false, false, false, "ASUS", "Asus Prime Z390-A alaplap", null, 66000, "", "20 years", 0, 0, 0, "Z390", 4, 10, "2133, 2400, 2666, 2800, 3000, 3200, 3300, 3333, 3400, 3466, 3600, 3733, 3866, 4000, 4133, 4266", 3, 0 },
                    { new Guid("ed44c3f5-29fa-4d01-adfd-46c607982eda"), 20, 0, "Basic motherboard. No overcloccing here", null, "Motherboard", null, false, false, false, "Gigabyte", "Gigabyte GA-B365-D3H alaplap", null, 35000, "", "2 years", 0, 0, 0, "B365", 0, 10, "2133, 2400, 2666", 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Available", "Category", "Description", "DiscountedPrice", "Discriminator", "ExpectedAvailalbleDate", "GamingFlag", "HasRGB", "IsUsed", "Manufacturer", "Name", "OrderId", "OriginalPrice", "PicturePath", "Warranty", "BaseClock", "TDP", "Weight", "ATXConnector", "Efficiency", "IsModular", "MolexConnector", "SixPinConnector", "SixPlusTwoConnector" },
                values: new object[,]
                {
                    { new Guid("6fecfe63-e382-48ea-902e-b086b8a3e965"), 20, 0, "Cheap ass psu, dont buy this", null, "PowerSupply", null, false, false, false, "Chieftec", "Chieftec ECO 400W GPE-400S tápegység", null, 13700, "", "3 years", 0, 0, 0, 1, 85, false, 2, 0, 0 },
                    { new Guid("32951c3d-656a-4ba2-9052-84457f820b4b"), 20, 0, "You should by this not that chinesee shit", null, "PowerSupply", null, false, false, false, "FSP", "FSP 650W Hyper M tápegység", null, 29790, "", "3 years", 0, 0, 0, 1, 85, true, 3, 0, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8569cf4d-68b3-4a48-bca7-06102bb68b9d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b79bacb5-70db-4c08-9d05-7155e7b35005"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6a982928-1e11-4cf5-924d-f776e0c8cda4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b1ee4fad-5615-4bd9-af03-f8343d3bcd29"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2107df63-d2af-4e87-be13-47e3471d85bc"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("861a5b7d-71ae-47b5-835e-57450def44cf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9be8e5b8-ed88-4fde-9dd4-38e7f0342ab9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bb8fd077-9289-4185-9ef5-fab7090c03cd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d063a055-7e0d-4e75-8b6f-43eb5f56deaf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6d5e69b1-3bd5-4fdd-85e3-270e177b9497"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f4d1a769-3479-4fd5-b614-1dbc9c3684c5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d5491921-19e0-457a-b585-791a637998d8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ed44c3f5-29fa-4d01-adfd-46c607982eda"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("32951c3d-656a-4ba2-9052-84457f820b4b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6fecfe63-e382-48ea-902e-b086b8a3e965"));

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "GamingFlag",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "HasRGB",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "IsUsed",
                table: "Items");

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
        }
    }
}
