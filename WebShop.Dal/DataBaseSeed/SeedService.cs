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
                    Id = Guid.NewGuid(),
                    Name = "Thermaltake CA-1P6-00F1WN-00 Level 20 HT számítógépház fekete",
                    Available = 10,
                    PicturePath = "",
                    ExpectedAvailalbleDate = null,
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
                    HDDNumber = 4
                },
                new Case
                {
                    Id = Guid.NewGuid(),
                    Name = "DeepCool EARLKASE RGB WH fehér számítógép ház",
                    Available = 10,
                    PicturePath = "",
                    ExpectedAvailalbleDate = null,
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
                    HDDNumber = 4
                }
            };
            Cpus = new List<Cpu>()
            {
                new Cpu
                {
                    Id = Guid.NewGuid(),
                    Name = "AMD Ryzen 3 2200G",
                    Available = 10,
                    PicturePath = "",
                    ExpectedAvailalbleDate = null,
                    OriginalPrice = 31500,
                    DiscountedPrice = null,
                    Manufacturer = "AMD",
                    Description = "So basic processor",
                    Warranty = "5 years",
                    ProcessorFamily = "AMD Ryzen 3",
                    Technology = 14,
                    CoreNumber = 4,
                    ThreadNumber = 4,
                    Socket = Enums.CpuSocket.SocketAM4,
                    BaseClock = 3400,
                    TDP = 65
                },
                 new Cpu
                {
                    Id = Guid.NewGuid(),
                    Name = "Intel Core i5-9600K",
                    Available = 10,
                    PicturePath = "",
                    ExpectedAvailalbleDate = null,
                    OriginalPrice = 82000,
                    DiscountedPrice = null,
                    Manufacturer = "Intel",
                    Description = "Very good gaming processor",
                    Warranty = "3 years",
                    ProcessorFamily = "Intel core 5",
                    Technology = 14,
                    CoreNumber = 6,
                    ThreadNumber = 6,
                    Socket = Enums.CpuSocket.LGA1151,
                    BaseClock = 3700,
                    TDP = 65
                }
            };
            Graphics = new List<GraphicsCard>
            {
                new GraphicsCard
                {
                    Id = Guid.NewGuid(),
                    Name = "Gigabyte RTX2070 Super 8GB GDDR6 GV-N207SGAMINGOC WHITE-8GD videokártya",
                    Available = 3,
                    PicturePath = "",
                    ExpectedAvailalbleDate = null,
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
                    PowerSupplyConnection = "6 + 8"

                },
                 new GraphicsCard
                {
                    Id = Guid.NewGuid(),
                    Name = "MSI Radeon RX 5500 XT MECH 8G OC videokártya",
                    Available = 15,
                    PicturePath = "",
                    ExpectedAvailalbleDate = null,
                    OriginalPrice = 85500,
                    DiscountedPrice = null,
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
                    PowerSupplyConnection = "8"

                }
            };
            HardDrives = new List<HardDrive>()
            {
                new HardDrive
                {
                   Id = Guid.NewGuid(),
                    Name = "Samsung 250GB 970 EVO Plus MZ-V7S250BW M.2 PCIe SSD meghajtó",
                    Available = 20,
                    PicturePath = "",
                    ExpectedAvailalbleDate = null,
                    OriginalPrice = 28600,
                    DiscountedPrice = null,
                    Manufacturer = "Samsung",
                    Description = "Very fast SSD ",
                    Warranty = "5 years",
                    Size = 250,
                    ReadSpeed = 3500,
                    WriteSpeed = 2300,
                    Socket = HardDriveSocket.M_2
                },
                 new HardDrive
                {
                   Id = Guid.NewGuid(),
                    Name = "Kingston 240GB SA400S37/240G SSD meghajtó",
                    Available = 50,
                    PicturePath = "",
                    ExpectedAvailalbleDate = null,
                    OriginalPrice = 14000,
                    DiscountedPrice = null,
                    Manufacturer = "Kingston",
                    Description = "Resonably fast SSD ",
                    Warranty = "5 years",
                    Size = 240,
                    ReadSpeed = 500,
                    WriteSpeed = 350,
                    Socket = HardDriveSocket.SATA_III
                },
                  new HardDrive
                {
                   Id = Guid.NewGuid(),
                    Name = "Seagate SkyHawk Surveillance 10TB 7200rpm 256MB SATA3 3,5\" HDD",
                    Available = 20,
                    PicturePath = "",
                    ExpectedAvailalbleDate = null,
                    OriginalPrice = 108000,
                    DiscountedPrice = null,
                    Manufacturer = "Seagate",
                    Description = "Biggest HDD you've ever seen",
                    Warranty = "5 years",
                    Size = 10000,
                    ReadSpeed = 50,
                    WriteSpeed = 35
                }
            };
            Memories = new List<Memory>()
            {
                new Memory
                {
                    Id = Guid.NewGuid(),
                    Name = "Kingston 2x8GB DDR4 3200MHz HyperX Predator XMP HX432C16PB3K2/16 memória",
                    Available = 20,
                    PicturePath = "",
                    ExpectedAvailalbleDate = null,
                    OriginalPrice = 38000,
                    DiscountedPrice = null,
                    Manufacturer = "Kingston",
                    Description = "High end memory in amazing white color",
                    Warranty = "5 years",
                    BaseClock = 3200,
                    Capacity = 8,
                    MemoryType = Enums.MemoryType.DDR4,
                    Timing = 16,
                    Kit = 2
                },
                 new Memory
                {
                    Id = Guid.NewGuid(),
                    Name = "Kingston 2x8GB DDR4 3200MHz HyperX Predator RGB HX432C16PB3AK2/16 memória",
                    Available = 20,
                    PicturePath = "",
                    ExpectedAvailalbleDate = null,
                    OriginalPrice = 41000,
                    DiscountedPrice = null,
                    Manufacturer = "Kingston",
                    Description = "High end memory with inbuilt RGB for so many fps!!!",
                    Warranty = "5 years",
                    BaseClock = 3200,
                    Capacity = 8,
                    MemoryType = Enums.MemoryType.DDR4,
                    Timing = 16,
                    Kit = 2
                }
            };
            Motherboards = new List<Motherboard>()
            {
                new Motherboard
                {
                    Id = Guid.NewGuid(),
                    Name = "Asus Prime Z390-A alaplap",
                    Available = 20,
                    PicturePath = "",
                    ExpectedAvailalbleDate = null,
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
                    MemorySocketNumber = 4
                },

                 new Motherboard
                {
                    Id = Guid.NewGuid(),
                    Name = "Gigabyte GA-B365-D3H alaplap",
                    Available = 20,
                    PicturePath = "",
                    ExpectedAvailalbleDate = null,
                    OriginalPrice = 35000,
                    DiscountedPrice = null,
                    Manufacturer = "Gigabyte",
                    Description = "Basic motherboard. No overcloccing here",
                    Warranty = "2 years",
                    Type = Enums.MotherboardType.Micro_ATX,
                    Chipset = "B365",
                    Socket = Enums.CpuSocket.LGA1151,
                    SupportedMemoryType = Enums.MemoryType.DDR4,
                    SupportedMemorySpeed = "2133, 2400, 2666"
                },
            };
            PowerSupplies = new List<PowerSupply>()
            {
                new PowerSupply
                {
                    Id = Guid.NewGuid(),
                    Name = "Chieftec ECO 400W GPE-400S tápegység",
                    Available = 20,
                    PicturePath = "",
                    ExpectedAvailalbleDate = null,
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
                    IsModular = false
                },
                new PowerSupply
                {
                    Id = Guid.NewGuid(),
                    Name = "FSP 650W Hyper M tápegység",
                    Available = 20,
                    PicturePath = "",
                    ExpectedAvailalbleDate = null,
                    OriginalPrice = 29790,
                    DiscountedPrice = null,
                    Manufacturer = "FSP",
                    Description = "You should by this not that chinesee shit",
                    Warranty = "3 years",
                    ATXConnector = 1,
                    MolexConnector = 3,
                    SixPinConnector = 0,
                    SixPlusTwoConnector = 4,
                    Efficiency = 85,
                    IsModular = true
                }
            };
        }
    }
}
