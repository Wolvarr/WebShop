using System;
using System.Collections.Generic;
using WebShop.Dal.Models;

namespace WebShop.Dal.DataBaseSeed
{
    public class SeedService : ISeedService
    {
        public IList<Cpu> Cpus { get; }
        public IList<Case> Cases { get; }
        public IList<CompletPC> CompletPCs { get; }

        public IList<GraphicsCard> Graphics { get; }

        public IList<HardDrive> HardDrives { get; }

        public IList<Memory> Memories { get; }

        public IList<Motherboard> Motherboards { get; }

        public IList<PowerSupply> PowerSupplies { get; }

        public SeedService()
        {
            CompletPCs = new List<CompletPC>();

            Cases = new List<Case>()
            {
                new Case
                {
                    Id = new Guid("21000000-0000-0000-0000-000000000000"),
                    PicturePath = "21000000-0000-0000-0000-000000000000",
                     Name = "Thermaltake CA-1P6-00F1WN-00 Level 20 HT számítógépház fekete",
                    Available = 10,
                    OriginalPrice = 59000,
                    DiscountedPrice = null,
                    Manufacturer = "Thermaltake",
                    Description = "Very nice case",
                    Warranty = "3 years",
                    BuiltInFanNumber = 3,
                    SupportedMotherboard = Enums.MotherboardType.ATX,
                    Height = 613,
                    Width = 468,
                    Depth = 503,
                    HDDNumber = 4,
                    DateSinceInStore = DateTime.Now.AddDays(-50),
                    HighlightedItem = false,
                },
                new Case
                {
                    Id = new Guid("22000000-0000-0000-0000-000000000000"),
                    PicturePath = "22000000-0000-0000-0000-000000000000",
                     Name = "DeepCool EARLKASE RGB WH fehér számítógép ház",
                    Available = 10,
                    OriginalPrice = 59000,
                    DiscountedPrice = null,
                    Manufacturer = "DeepCool",
                    Description = "Very white and big case",
                    Warranty = "3 years",
                    BuiltInFanNumber = 3,
                    SupportedMotherboard = Enums.MotherboardType.ATX,
                    Height = 511,
                    Width = 204,
                    Depth = 500,
                    HDDNumber = 4,
                    DateSinceInStore = DateTime.Now.AddDays(-50),
                    HighlightedItem = false,
                }
            };
            Cpus = new List<Cpu>()
            {
                new Cpu
                {
                    Id = new Guid("10000000-0000-0000-0000-000000000000"),
                    PicturePath = "10000000-0000-0000-0000-000000000000",
                    Name = "AMD Ryzen 3 2200G",
                    Available = 10,
                    OriginalPrice = 31500,
                    DiscountedPrice = null,
                    Category = Enums.Category.Cpu,
                    Manufacturer = "AMD",
                    Description = "So basic processor\n random leírás ami ki tesz több sort, hogy kiderüljön, hogy a ui-on mégiscsak ugyanmár hogy a faszba néz ki.",
                    Warranty = "5 years",
                    ProcessorFamily = "AMD Ryzen 3",
                    Technology = 14,
                    CoreNumber = 4,
                    ThreadNumber = 4,
                    Socket = Enums.CpuSocket.SocketAM4,
                    BaseClock = 3400,
                    TDP = 65,
                    DateSinceInStore = DateTime.Now.AddDays(-50),
                    HighlightedItem = false,
                },
                 new Cpu
                {
                    Id = new Guid("20000000-0000-0000-0000-000000000000"),
                    PicturePath = "20000000-0000-0000-0000-000000000000",
                    Name = "Intel Core i5-9600K",
                    Available = 10,
                     Category = Enums.Category.Cpu,
                    OriginalPrice = 82000,
                    DiscountedPrice = 75000,
                    Manufacturer = "Intel",
                    Description = "Very good gaming processor",
                    Warranty = "3 years",
                    ProcessorFamily = "Intel core 5",
                    Technology = 14,
                    CoreNumber = 6,
                    ThreadNumber = 6,
                    Socket = Enums.CpuSocket.LGA1151,
                    BaseClock = 3700,
                    TDP = 65,
                    DateSinceInStore = DateTime.Now.AddDays(-30),
                    HighlightedItem = true,
                },
                  new Cpu
                {
                    Id = new Guid("30000000-0000-0000-0000-000000000000"),
                    PicturePath = "30000000-0000-0000-0000-000000000000",
                    Name = "Intel Core i5-9400f",
                    Available = 10,
                    Category = Enums.Category.Cpu,
                    OriginalPrice = 82000,
                    DiscountedPrice = null,
                    Manufacturer = "Intel",
                    Description = "Középkategóriás processor munkára és játékra egyaránt",
                    Warranty = "3 years",
                    ProcessorFamily = "Intel core 5",
                    Technology = 14,
                    CoreNumber = 4,
                    ThreadNumber = 4,
                    Socket = Enums.CpuSocket.LGA1151,
                    BaseClock = 3500,
                    TDP = 45,
                    DateSinceInStore = DateTime.Now.AddDays(-30),
                    HighlightedItem = false,
                }
            };
            Graphics = new List<GraphicsCard>
            {
                new GraphicsCard
                {
                    Id = new Guid("40000000-0000-0000-0000-000000000000"),
                    PicturePath = "40000000-0000-0000-0000-000000000000",
                     Name = "Gigabyte RTX2070 Super 8GB GDDR6 GV-N207SGAMINGOC WHITE-8GD videokártya",
                    Available = 3,
                    OriginalPrice = 216000,
                    DiscountedPrice = null,
                    Manufacturer = "Gigabyte",
                    Description = "High end gpu in amazing white color",
                    Warranty = "5 years",
                    BaseClock = 1770,
                    TDP = 215,
                    BuiltInMemory = 8192,
                    MemoryClock = 14000,
                    BandWidth = 256,
                    CoolerType = "Windforce 3x",
                    MemoryType = Enums.MemoryType.GDDR6,
                    PowerSupplyConnection = "6 + 8",
                    DateSinceInStore = DateTime.Now.AddDays(-30),
                    HighlightedItem = true,
                },
                 new GraphicsCard
                {
                    Id = new Guid("50000000-0000-0000-0000-000000000000"),
                    PicturePath = "50000000-0000-0000-0000-000000000000",
                     Name = "MSI Radeon RX 5500 XT MECH 8G OC videokártya",
                    Available = 15,
                    OriginalPrice = 85500,
                    DiscountedPrice = 79900,
                    Manufacturer = "MSI",
                    Description = "Low end basic graphics card for work",
                    Warranty = "3 years",
                    BaseClock = 1845,
                    TDP = 130,
                    BuiltInMemory = 8192,
                    MemoryClock = 14000,
                    BandWidth = 128,
                    CoolerType = "Active",
                    MemoryType = Enums.MemoryType.GDDR6,
                    PowerSupplyConnection = "8",
                    DateSinceInStore = DateTime.Now.AddDays(-2),
                    HighlightedItem = false,
                }
            };
            HardDrives = new List<HardDrive>()
            {
                new HardDrive
                {
                    Id = new Guid("60000000-0000-0000-0000-000000000000"),
                    PicturePath = "60000000-0000-0000-0000-000000000000",
                     Name = "Samsung 250GB 970 EVO Plus MZ-V7S250BW M.2 PCIe SSD meghajtó",
                    Available = 20,
                    OriginalPrice = 28600,
                    DiscountedPrice = null,
                    Manufacturer = "Samsung",
                    Description = "Very fast SSD ",
                    Warranty = "5 years",
                    Size = 250,
                    ReadSpeed = 3500,
                    WriteSpeed = 2300,
                    Socket = HardDriveSocket.M_2,
                    DateSinceInStore = DateTime.Now.AddDays(-30),
                    HighlightedItem = false,
                },
                 new HardDrive
                {
                    Id = new Guid("70000000-0000-0000-0000-000000000000"),
                    PicturePath = "70000000-0000-0000-0000-000000000000",
                     Name = "Kingston 240GB SA400S37/240G SSD meghajtó",
                    Available = 50,
                    OriginalPrice = 14000,
                    DiscountedPrice = null,
                    Manufacturer = "Kingston",
                    Description = "Resonably fast SSD ",
                    Warranty = "5 years",
                    Size = 240,
                    ReadSpeed = 500,
                    WriteSpeed = 350,
                    Socket = HardDriveSocket.SATA_III,
                    DateSinceInStore = DateTime.Now.AddDays(-30),
                    HighlightedItem = true,
                },
                  new HardDrive
                {
                    Id = new Guid("80000000-0000-0000-0000-000000000000"),
                    PicturePath = "80000000-0000-0000-0000-000000000000",
                    Name = "Seagate SkyHawk Surveillance 10TB 7200rpm 256MB SATA3 3,5\" HDD",
                    Available = 20,
                    OriginalPrice = 108000,
                    DiscountedPrice = null,
                    Manufacturer = "Seagate",
                    Description = "Biggest HDD you've ever seen",
                    Warranty = "5 years",
                    Size = 10000,
                    ReadSpeed = 50,
                    WriteSpeed = 35,
                    DateSinceInStore = DateTime.Now.AddDays(-3),
                    HighlightedItem = false,
                }
            };
            Memories = new List<Memory>()
            {
                new Memory
                {
                    Id = new Guid("90000000-0000-0000-0000-000000000000"),
                    PicturePath = "90000000-0000-0000-0000-000000000000",
                     Name = "Kingston 2x8GB DDR4 3200MHz HyperX Predator XMP HX432C16PB3K2/16 memória",
                    Available = 20,
                    OriginalPrice = 38000,
                    DiscountedPrice = 34000,
                    Manufacturer = "Kingston",
                    Description = "High end memory in amazing white color",
                    Warranty = "5 years",
                    BaseClock = 3200,
                    Capacity = 8,
                    MemoryType = Enums.MemoryType.DDR4,
                    Timing = 16,
                    Kit = 2,
                    DateSinceInStore = DateTime.Now.AddDays(-30),
                    HighlightedItem = false,
                },
                 new Memory
                {
                    Id = new Guid("10000000-0000-0000-0000-000000000001"),
                    PicturePath = "10000000-0000-0000-0000-000000000001",
                     Name = "Kingston 2x8GB DDR4 3200MHz HyperX Predator RGB HX432C16PB3AK2/16 memória",
                    Available = 20,
                    OriginalPrice = 41000,
                    DiscountedPrice = null,
                    Manufacturer = "Kingston",
                    Description = "High end memory with inbuilt RGB for so many fps!!!",
                    Warranty = "5 years",
                    BaseClock = 3200,
                    Capacity = 8,
                    MemoryType = Enums.MemoryType.DDR4,
                    Timing = 16,
                    Kit = 2,
                    DateSinceInStore = DateTime.Now.AddDays(-5),
                    HighlightedItem = true,
                }
            };
            Motherboards = new List<Motherboard>()
            {
                new Motherboard
                {
                    Id = new Guid("11000000-0000-0000-0000-000000000000"),
                    PicturePath = "11000000-0000-0000-0000-000000000000",
                    Name = "ASUS PRIME Z390-A alaplap",
                    Available = 20,
                    OriginalPrice = 66000,
                    DiscountedPrice = null,
                    Manufacturer = "ASUS",
                    Description = "Great motherboard. Gets shit done",
                    Warranty = "20 years",
                    Type = Enums.MotherboardType.ATX,
                    Chipset = "Z390",
                    Socket = Enums.CpuSocket.LGA1151,
                    SupportedMemoryType = Enums.MemoryType.DDR4,
                    SupportedMemorySpeed = "2133, 2400, 2666, 2800, 3000, 3200, 3300, 3333, 3400, 3466, 3600, 3733, 3866, 4000, 4133, 4266",
                    MemorySocketNumber = 4,
                    DateSinceInStore = DateTime.Now.AddDays(-30),
                    HighlightedItem = false,
                },

                 new Motherboard
                {
                    Id = new Guid("12000000-0000-0000-0000-000000000000"),
                    PicturePath = "12000000-0000-0000-0000-000000000000",
                    Name = "Gigabyte GA-B365-D3H alaplap",
                    Available = 20,
                    OriginalPrice = 35000,
                    DiscountedPrice = null,
                    Manufacturer = "Gigabyte",
                    Description = "Basic motherboard. No overcloccing here",
                    Warranty = "2 years",
                    Type = Enums.MotherboardType.Micro_ATX,
                    Chipset = "B365",
                    Socket = Enums.CpuSocket.LGA1151,
                    SupportedMemoryType = Enums.MemoryType.DDR4,
                    SupportedMemorySpeed = "2133, 2400, 2666",
                    DateSinceInStore = DateTime.Now.AddDays(-30),
                    HighlightedItem = false,
                },
            };
            PowerSupplies = new List<PowerSupply>()
            {
                new PowerSupply
                {
                    Id = new Guid("13000000-0000-0000-0000-000000000000"),
                    PicturePath = "13000000-0000-0000-0000-000000000000",
                     Name = "Chieftec ECO 400W GPE-400S tápegység",
                    Available = 20,
                    OriginalPrice = 13700,
                    DiscountedPrice = null,
                    Manufacturer = "Chieftec",
                    Description = "Cheap ass psu, dont buy this",
                    Warranty = "3 years",
                    ATXConnector = 1,
                    MolexConnector = 2,
                    SixPinConnector = 0,
                    SixPlusTwoConnector = 0,
                    Efficiency = 85,
                    IsModular = false,
                    DateSinceInStore = DateTime.Now.AddDays(-30),
                    HighlightedItem = false,
                },
                new PowerSupply
                {
                    Id = new Guid("14000000-0000-0000-0000-000000000000"),
                    PicturePath = "14000000-0000-0000-0000-000000000000",
                     Name = "FSP 650W Hyper M tápegység",
                    Available = 20,
                    OriginalPrice = 29790,
                    DiscountedPrice = 25000,
                    Manufacturer = "FSP",
                    Description = "You should by this not that chinesee shit",
                    Warranty = "3 years",
                    ATXConnector = 1,
                    MolexConnector = 3,
                    SixPinConnector = 0,
                    SixPlusTwoConnector = 4,
                    Efficiency = 85,
                    IsModular = true,
                    DateSinceInStore = DateTime.Now.AddDays(-30),
                    HighlightedItem = true,
                }
            };
        }
    }
}
