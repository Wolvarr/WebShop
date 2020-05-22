using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Dal.Enums;
using WebShop.Dal.Models;

namespace WebShop.Models
{
    public class CreateItemViewModel
    {

        public bool Create { get; set; }

        [DisplayName("Termék név")]
        public string Name { get; set; }

        [DisplayName("Kategória")]
        public string Category { get; set; }

        [DisplayName("Mennyiség")]
        public int Available { get; set; }

        [DisplayName("Kép elérési útja")]
        public string PicturePath { get; set; }

        [DisplayName("Ár")]
        public int OriginalPrice { get; set; }

        [DisplayName("Akciós ár")]
        public int? DiscountedPrice { get; set; }

        [DisplayName("Gyártó")]
        public string Manufacturer { get; set; }

        [DisplayName("Leírás")]
        public string Description { get; set; }

        [DisplayName("Rövid leírás")]
        public string ShortDescription { get; set; }

        [DisplayName("Garancia")]
        public string Warranty { get; set; }

        [DisplayName("Gaming ajánlat")]
        public bool GamingFlag { get; set; }

        [DisplayName("Használt termék")]
        public bool IsUsed { get; set; }

        [DisplayName("RGB")]
        public bool HasRGB { get; set; }

        #region hardware

        [DisplayName("Órajel(mhz)")]
        public int? BaseClock { get; set; }

        [DisplayName("Fogyasztás(w)")]
        public int? TDP { get; set; }

        [DisplayName("Súly(g)")]
        public int? Weight { get; set; }
        #endregion

        #region PC

        [DisplayName("Gépház")]
        public string Case { get; set; }

        [DisplayName("Alaplap")]
        public string Motherboard { get; set; }

        [DisplayName("Processzor")]
        public string Cpu { get; set; }

        [DisplayName("Videókártya")]
        public string Gpu { get; set; }

        [DisplayName("Memória")]
        public string Memories { get; set; }

        [DisplayName("Meghajtók")]
        public string Drives { get; set; }

        [DisplayName("Tápegység")]
        public string PowerSupply { get; set; }
        #endregion

        #region case
        [DisplayName("Beépített ventillátorok(db)")]
        public int? BuiltInFanNumber { get; set; }

        [DisplayName("Alaplap típusa")]

        public MotherboardType SupportedMotherboard { get; set; }

        [DisplayName("Magasság(mm)")]
        public int? Height { get; set; }

        [DisplayName("Szélesség(mm)")]
        public int? Width { get; set; }

        [DisplayName("Mélység(mm)")]
        public int? Depth { get; set; }

        [DisplayName("HDD foglalatok száma")]
        public int? HDDNumber { get; set; }
        #endregion

        #region cpu
        [DisplayName("Processzor család")]
        public string ProcessorFamily { get; set; }

        [DisplayName("Technológia(nm)")]
        public int? Technology { get; set; } // in nm

        [DisplayName("Magok száma")]
        public int? CoreNumber { get; set; }

        [DisplayName("Szálak száma")]
        public int? ThreadNumber { get; set; }

        [DisplayName("Foglalat")]
        public CpuSocket Socket { get; set; }

        #endregion

        #region gpu
        [DisplayName("Beépített memória(MB)")]
        public int? BuiltInMemory { get; set; }

        [DisplayName("Memória órajel(Mhz)")]
        public int? MemoryClock { get; set; }

        [DisplayName("Sávszélesség(mb)")]
        public int? BandWidth { get; set; }

        [DisplayName("Hűtés típusa")]
        public string CoolerType { get; set; }

        [DisplayName("Memória típusas")]
        public MemoryType MemoryType { get; set; }

        [DisplayName("Tápegység csatlakozás")]
        public string PowerSupplyConnection { get; set; }  //(pin)
        #endregion

        #region drive

        [DisplayName("Méret(GB)")]
        public int? Size { get; set; }

        [DisplayName("Olvasási sebesség(MB/s)")]
        public int? ReadSpeed { get; set; }

        [DisplayName("Írási sebesség(MB/s)")]
        public int? WriteSpeed { get; set; }

        [DisplayName("Csatlakozás")]
        public HardDriveSocket DriveSocket { get; set; }
        #endregion

        #region memory

        [DisplayName("Méret(MB)")]
        public int? Capacity { get; set; }

        [DisplayName("Memória típusa")]
        public MemoryType MemoryTypeForMmoryCard { get; set; }

        [DisplayName("Időzítés(CL)")]
        public int? Timing { get; set; } //(CL)

        [DisplayName("Kiszerelés:")]
        public int? Kit { get; set; } //modules
        #endregion

        #region motherboard

        [DisplayName("Alaplap típusa")]
        public MotherboardType Type { get; set; }

        [DisplayName("Chipset típusa")]
        public string Chipset { get; set; }

        [DisplayName("Foglalat")]
        public CpuSocket CpuSocketForMotherboard { get; set; }

        [DisplayName("Támogatott memória típus")]
        public MemoryType SupportedMemoryType { get; set; }

        [DisplayName("Támogatott memória sebesség(Mzh)")]
        public string SupportedMemorySpeed { get; set; }  //3000, 3200,..

        [DisplayName("Memória foglalatok száma")]
        public int? MemorySocketNumber { get; set; }
        #endregion

        #region psu
        [DisplayName("ATX csatlakozók száma")]
        public int? ATXConnector { get; set; }

        [DisplayName("Molex csatlakozók száma")]
        public int? MolexConnector { get; set; }

        [DisplayName("Hat pines csatlakozók száma")]
        public int? SixPinConnector { get; set; }

        [DisplayName("Hat + két pines csatlakozók száma")]
        public int? SixPlusTwoConnector { get; set; }

        [DisplayName("Hatásfok")]
        public int? Efficiency { get; set; } //(%)

        [DisplayName("Moduláris tápegység")]
        public bool? IsModular { get; set; }
        #endregion
    }
}
