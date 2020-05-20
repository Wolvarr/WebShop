using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
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
            CompletPCs = new List<CompletPC>()
            {
                new CompletPC()
                {
                    Id = new Guid("21000000-0000-0000-0000-000000000011"),
                    PicturePath = "21000000-0000-0000-0000-000000000011.jpg",
                    Name="ASUS ROG asztali gamer számítógép (G15DH-HU011D)",
                    Category = Enums.Category.CompletPc,
                    OriginalPrice = 295790,
                    DiscountedPrice = null,
                    Available= 15,
                    ShortDescription = "Viszonylag olcsó, jó árérték arányú számítógép",
                    Description = "A dinamikus, szélnyíró készülékház kifinomult formával rendelkezik, hogy növelje a légáramot, miközben 30dB alatt tartja a zajszinteket a csendesebb játék és munka érdekében. Az elülső hangsúlyokon keresztül megtalálható vágások kiszélesítették a szellőzőket, így több levegő jut a készülékházba. Belül a CPU, a grafikus kártya és a tápegység külön foglalatokban található, minimalizálva a termikus interferenciát és csökkentve a környezeti hőmérsékletet. A légáram növelő dizájn felgyorsítja a hőeloszlást, hogy magasabb általános teljesítményt tegyen lehetővé és tartson meg.",
                    Manufacturer = "ASUS",
                    Warranty = "2 years",
                    Case ="Asus omega colorful RGB gépház",
                    Motherboard = "ASUS Strix B460 gaming pro alaplap",
                    Cpu = "AMD Ryzen 5 3600X",
                    Gpu = "nvidia geforce gtx 1650",
                    Memories = "2 x Kingston HyperX fury 8gb 3200mhz",
                    Drives = "256GB SSD, 1TB HDD"
                },
                new CompletPC()
                {
                    Id = new Guid("21000000-0000-0000-0000-000000000012"),
                    PicturePath = "21000000-0000-0000-0000-000000000012.jpg",
                    Category = Enums.Category.CompletPc,
                    Available= 3,
                    Name="ASUS ROG Strix GA15 Gamer asztali számítógép(G15DH-HU004D)",
                    OriginalPrice = 295790,
                    DiscountedPrice = null,
                    ShortDescription = "Highend gaming pc mindenre is",
                    Description = "A dinamikus, szélnyíró készülékház kifinomult formával rendelkezik, hogy növelje a légáramot, miközben 30dB alatt tartja a zajszinteket a csendesebb játék és munka érdekében. Az elülső hangsúlyokon keresztül megtalálható vágások kiszélesítették a szellőzőket, így több levegő jut a készülékházba. Belül a CPU, a grafikus kártya és a tápegység külön foglalatokban található, minimalizálva a termikus interferenciát és csökkentve a környezeti hőmérsékletet. A légáram növelő dizájn felgyorsítja a hőeloszlást, hogy magasabb általános teljesítményt tegyen lehetővé és tartson meg.",
                    Manufacturer = "ASUS",
                    Warranty = "3 years",
                    Case ="Asus Strix Boss gépház",
                    Motherboard = "ASUS Strix Z490 gaming pro alaplap",
                    Cpu = "Intel I9-9900K",
                    Gpu = "nVidia GeForce RTX 2060 Super - 8GB",
                    Memories = "4 x Kingston HyperX fury 8gb 3200mhz",
                    Drives = "1TGB SSD, 10TB HDD"
                }
            };

            Cases = new List<Case>()
            {
                new Case
                {
                    Id = new Guid("21000000-0000-0000-0000-000000000000"),
                    PicturePath = "21000000-0000-0000-0000-000000000000.jpg",
                     Name = "Thermaltake CA-1P6-00F1WN-00 Level 20 HT számítógépház fekete",
                    Available = 10,
                    OriginalPrice = 59000,
                    DiscountedPrice = null,
                    Manufacturer = "Thermaltake",
                    ShortDescription = "Very nice case",
                    Description = "E-ATX formátumú Torony kialakítású számtógépház beépített 2 db 140 mm-es ventilátorral. Letisztul formabontó design, Edzett üveg oldalpanelek, TT LCS tanúsítvány. ",
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
                    PicturePath = "22000000-0000-0000-0000-000000000000.jpg",
                     Name = "DeepCool EARLKASE RGB WH fehér számítógép ház",
                    Available = 10,
                    OriginalPrice = 59000,
                    DiscountedPrice = null,
                    Manufacturer = "DeepCool",
                    ShortDescription = "White and big case",
                    Description = "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque.",
                    Warranty = "3 years",
                    BuiltInFanNumber = 3,
                    SupportedMotherboard = Enums.MotherboardType.ATX,
                    Height = 511,
                    Width = 204,
                    Depth = 500,
                    HDDNumber = 4,
                    DateSinceInStore = DateTime.Now.AddDays(-50),
                    HighlightedItem = false,
                },
                new Case
                {
                    Id = new Guid("31000000-0000-0000-0000-000000000000"),
                    PicturePath = "31000000-0000-0000-0000-000000000000.jpg",
                     Name = "Thermaltake View 32 Tempered Glass RGB Edition",
                    Available = 2,
                    OriginalPrice = 49000,
                    DiscountedPrice = 18000,
                    Manufacturer = "Thermaltake",
                    ShortDescription = "So much RGB => So much FPS",
                    Description = "A Thermaltake a számítógépházába összeolvasztotta a szépséget és a teljesítményt, a View 32 Tempered Glass RGB Edition középkategóriás számítógépház tervezésébe. Négy prémium minőségű, 4 mm vastag, edzett üvegablakkal (felső, elülső, bal és jobb) készült, a belső rendszer közvetlen megtekintéséhez és a kiváló alvázvédelemhez. Három beépített 120 mm-es Riing LED RGB ventilátor (kettő elöl és egy hátul) biztosítja az RGB megvilágítását és az optimális szellőzést.",
                    Warranty = "3 years",
                    BuiltInFanNumber = 3,
                    SupportedMotherboard = Enums.MotherboardType.ATX,
                    Height = 521,
                    Width = 201,
                    Depth = 500,
                    HDDNumber = 4,
                    DateSinceInStore = DateTime.Now.AddDays(-50),
                    HighlightedItem = true,
                }
            };
            Cpus = new List<Cpu>()
            {
                new Cpu
                {
                    Id = new Guid("10000000-0000-0000-0000-000000000000"),
                    PicturePath = "10000000-0000-0000-0000-000000000000.jpg",
                    Name = "AMD Ryzen 3 2200G",
                    Available = 10,
                    OriginalPrice = 31500,
                    DiscountedPrice = null,
                    Category = Enums.Category.Cpu,
                    Manufacturer = "AMD",
                    ShortDescription = "So basic processor",
                    Description = "A legjobb többprocesszoros teljesítmény az osztályában, a játékosok számára. Jobb teljesítmény. Hihetetlen technológia. Az intelligens Ryzen processzorok csak még okosabbak lettek. ",
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
                    PicturePath = "20000000-0000-0000-0000-000000000000.jpg",
                    Name = "Intel Core i5-9600K",
                    Available = 10,
                     Category = Enums.Category.Cpu,
                    OriginalPrice = 82000,
                    DiscountedPrice = 65000,
                    Manufacturer = "Intel",
                    ShortDescription = "Very good gaming processor",
                    Description = "Magok száma:6, Processzor foglalat:Intel 1151 v2, Család:Coffee Lake, Órajel (Mhz):3700, VGA típus:Intel UHD Graphics 630, Hűtőventilátor:Nem, Fogyasztás (W):95, Architektúra (bit):64, L3 Cache (MB):9, Hűtőborda:Nem, Gyártási technológia (nm):14, L2 Cache (MB):2, Szálak száma:6,",
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
                    PicturePath = "30000000-0000-0000-0000-000000000000.jpg",
                    Name = "Intel Core i5-9400f",
                    Available = 10,
                    Category = Enums.Category.Cpu,
                    OriginalPrice = 82000,
                    DiscountedPrice = null,
                    Manufacturer = "Intel",
                    ShortDescription = "Középkategóriás processor munkára és játékra egyaránt",
                    Description = "Magok száma:6, Processzor foglalat:Intel 1151 v2, Család:Coffee Lake, Órajel (Mhz):2900, VGA típus:Nem, Hűtőventilátor:Igen, Fogyasztás (W):65, Architektúra (bit):64, L3 Cache (MB):9, Hűtőborda:Igen, Gyártási technológia (nm):14, L2 Cache (MB):1,5, Szálak száma:6,",
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
                },
                   new Cpu
                {
                    Id = new Guid("33000000-0000-0000-0000-000000000000"),
                    PicturePath = "33000000-0000-0000-0000-000000000000.jpg",
                    Name = "AMD Ryzen Threadripper 2970WX ",
                    Available = 1,
                    Category = Enums.Category.Cpu,
                    OriginalPrice = 443390,
                    DiscountedPrice = 410000,
                    Manufacturer = "AMD",
                    ShortDescription = "Felsőkategóriás processor, munkaállomásba",
                    Description = "Magok száma:24, Család:AMD Ryzen Threadripper, Processzor foglalat:AMD TR4, Órajel (Mhz):3000, VGA típus:Nem, Fogyasztás (W):250, L3 Cache (MB):64, Architektúra (bit):Zen+, Gyártási technológia (nm):12, Hűtőventilátor:Nem, L2 Cache (MB):12, Hűtőborda:Nem",
                    Warranty = "3 years",
                    ProcessorFamily = "AMD threadripper",
                    Technology = 12,
                    CoreNumber = 24,
                    ThreadNumber = 24,
                    Socket = Enums.CpuSocket.AMDTR4,
                    BaseClock = 3000,
                    TDP = 250,
                    DateSinceInStore = DateTime.Now.AddDays(-30),
                    HighlightedItem = false,
                }
            };
            Graphics = new List<GraphicsCard>
            {
                new GraphicsCard
                {
                    Id = new Guid("40000000-0000-0000-0000-000000000000"),
                    PicturePath = "40000000-0000-0000-0000-000000000000.jpg",
                     Name = "Gigabyte RTX2070 Super 8GB GDDR6 GV-N207SGAMINGOC WHITE-8GD videokártya",
                    Available = 3,
                    OriginalPrice = 216000,
                    DiscountedPrice = 165000,
                    Manufacturer = "Gigabyte",
                    ShortDescription = "High end gpu in amazing white color",
                    Description = "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.",
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
                    PicturePath = "50000000-0000-0000-0000-000000000000.jpg",
                     Name = "MSI Radeon RX 5500 XT MECH 8G OC videokártya",
                    Available = 0,
                    OriginalPrice = 85500,
                    DiscountedPrice = 79900,
                    Manufacturer = "MSI",
                    ShortDescription = "Low end basic graphics card for work",
                    Description = "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.",
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
                },
                 new GraphicsCard
                {
                    Id = new Guid("55500000-0000-0000-0000-000000000000"),
                    PicturePath = "55500000-0000-0000-0000-000000000000.jpg",
                     Name = "Asus RTX2080 Ti 11GB GDDR6 ROG-STRIX-RTX2080TI-O11G-GAMING",
                    Available = 15,
                    OriginalPrice = 548590,
                    DiscountedPrice = 370000,
                    Manufacturer = "MSI",
                    ShortDescription = "Best GPU money can buy",
                    Description = "Új Turing GPU architektúra és Ray-tracing technológia: tükröződés és fejlettebb effektek valós időben. DirectX 12: fejlettebb vizualitás és optimalizált teljesítmény. Axial-tech fans: különleges és egyedi hűtés, halk és hatékony működés. Super Alloy Power II: elsőosztályú alkatrészekkel szerelve a hosszú élettartamért és a stabil energiaellátásért.MaxContact Technology: a hűtőborda hatékonyabb elhelyezésével nő a hővezetőképesség",
                    Warranty = "3 years",
                    BaseClock = 1350,
                    TDP = 170,
                    BuiltInMemory = 11264,
                    MemoryClock = 14000,
                    BandWidth = 128,
                    CoolerType = "Active",
                    MemoryType = Enums.MemoryType.GDDR6,
                    PowerSupplyConnection = "8 + 8",
                    DateSinceInStore = DateTime.Now.AddDays(-2),
                    HighlightedItem = true,
                }
            };
            HardDrives = new List<HardDrive>()
            {
                new HardDrive
                {
                    Id = new Guid("60000000-0000-0000-0000-000000000000"),
                    PicturePath = "60000000-0000-0000-0000-000000000000.jpg",
                     Name = "Samsung 250GB 970 EVO Plus MZ-V7S250BW M.2 PCIe SSD meghajtó",
                    Available = 20,
                    OriginalPrice = 28600,
                    DiscountedPrice = null,
                    Manufacturer = "Samsung",
                    ShortDescription = "Very fast SSD ",
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
                    PicturePath = "70000000-0000-0000-0000-000000000000.jpg",
                     Name = "Kingston 240GB SA400S37/240G SSD meghajtó",
                    Available = 0,
                    OriginalPrice = 14000,
                    DiscountedPrice = null,
                    Manufacturer = "Kingston",
                    ShortDescription = "Resonably fast SSD ",
                    Description = "A Kingston A400 egy 2,5\" -os SSD meghajtó, melynek kapacitása 240 GB és PC vagy notebook felhasználást képes teljesmértékben egy egy erőteljes géppé változtatni. A készülék frissítése még sosem volt egyszerűbb. Összehasonlítva a mechanikus merevlemezekkel azonnal észrevehető a teljesítmény növekedés. Már az indítás során észlelhetjük, hogy az operációs rendszer betöltése sokkal gyorsabb. Ésegyéb műveletek, mint az alkalmazások indítására, másolás vagy mozgó kép indítására sem kell már olyan sokáig várni, mint korábban",
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
                    PicturePath = "80000000-0000-0000-0000-000000000000.jpg",
                    Name = "Seagate SkyHawk Surveillance 10TB 7200rpm 256MB SATA3 3,5\" HDD",
                    Available = 20,
                    OriginalPrice = 108000,
                    DiscountedPrice = 65000,
                    Manufacturer = "Seagate",
                    ShortDescription = "Biggest HDD you've ever seen",
                    Description = "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.",
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
                    PicturePath = "90000000-0000-0000-0000-000000000000.jpg",
                     Name = "Kingston 2x8GB DDR4 3200MHz HyperX Predator XMP HX432C16PB3K2/16 memória",
                    Available = 20,
                    OriginalPrice = 38000,
                    DiscountedPrice = 34000,
                    Manufacturer = "Kingston",
                    ShortDescription = "High end memory in amazing white color",
                    Description = "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.",
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
                    PicturePath = "10000000-0000-0000-0000-000000000001.jpg",
                     Name = "Kingston 2x8GB DDR4 3200MHz HyperX Predator RGB HX432C16PB3AK2/16 memória",
                    Available = 20,
                    OriginalPrice = 41000,
                    DiscountedPrice = null,
                    Manufacturer = "Kingston",
                    ShortDescription = "High end memory with inbuilt RGB for so many fps!!!",
                    Description = "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.",
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
                    PicturePath = "11000000-0000-0000-0000-000000000000.jpg",
                    Name = "ASUS PRIME Z390-A alaplap",
                    Available = 20,
                    OriginalPrice = 69000,
                    DiscountedPrice = 48000,
                    Manufacturer = "ASUS",
                    ShortDescription = "Great motherboard. Gets the job done",
                    Description = "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.",
                    Warranty = "20 years",
                    Type = Enums.MotherboardType.ATX,
                    Chipset = "Z390",
                    Socket = Enums.CpuSocket.LGA1151,
                    SupportedMemoryType = Enums.MemoryType.DDR4,
                    SupportedMemorySpeed = "2133, 2400, 2666, 2800, 3000, 3200, 3300, 3333, 3400, 3466, 3600",
                    MemorySocketNumber = 4,
                    DateSinceInStore = DateTime.Now.AddDays(-30),
                    HighlightedItem = false,
                },

                 new Motherboard
                {
                    Id = new Guid("12000000-0000-0000-0000-000000000000"),
                    PicturePath = "12000000-0000-0000-0000-000000000000.jpg",
                    Name = "Gigabyte GA-B365-D3H alaplap",
                    Available = 20,
                    OriginalPrice = 35000,
                    DiscountedPrice = null,
                    Manufacturer = "Gigabyte",
                    ShortDescription = "Basic motherboard. No overcloccing here",
                    Description = "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.",
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
                    PicturePath = "13000000-0000-0000-0000-000000000000.jpg",
                     Name = "Chieftec ECO 400W GPE-400S tápegység",
                    Available = 20,
                    OriginalPrice = 13700,
                    DiscountedPrice = null,
                    Manufacturer = "Chieftec",
                    ShortDescription = "Cheap ass psu, dont buy this",
                    Description = "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.",
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
                    PicturePath = "14000000-0000-0000-0000-000000000000.jpg",
                     Name = "FSP 650W Hyper M tápegység",
                    Available = 0,
                    OriginalPrice = 29790,
                    DiscountedPrice = 25000,
                    Manufacturer = "FSP",
                    ShortDescription = "You should by this not that chinesee crap",
                    Description = "Morbi efficitur iaculis luctus. Quisque efficitur magna nec sapien finibus euismod. Nullam suscipit enim id dui hendrerit imperdiet. Donec ultrices venenatis nisl, nec condimentum neque. Vivamus ut arcu tincidunt, dapibus nunc ut, vulputate arcu. Nulla molestie leo at quam laoreet, id consectetur augue facilisis. Mauris in eleifend purus, a suscipit risus.",
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
