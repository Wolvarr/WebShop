using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Dal.Enums;

namespace WebShop.Models
{
    public class CreateItemViewModel
    {

        public bool Create { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public int Available { get; set; }

        public string PicturePath { get; set; }

        public int OriginalPrice { get; set; }

        public int? DiscountedPrice { get; set; }

        public string Manufacturer { get; set; }

        public string Description { get; set; }

        public string ShortDescription { get; set; }

        public string Warranty { get; set; }

        public bool GamingFlag { get; set; }

        public bool IsUsed { get; set; }

        public bool HasRGB { get; set; }

        #region hardware

        public int? BaseClock { get; set; }

        public int? TDP { get; set; }

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
        [DisplayName("Beépített ventillátorok")]
        public int? BuiltInFanNumber { get; set; }

        [DisplayName("Alaplap típusa")]

        public string SupportedMotherboard { get; set; }

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
        public string Socket { get; set; }

        #endregion

        #region gpu
        [DisplayName("Beépített memória")]
        public int? BuiltInMemory { get; set; }

        [DisplayName("Memória órajel")]
        public int? MemoryClock { get; set; }

        [DisplayName("Sávszélesség")]
        public int? BandWidth { get; set; }

        [DisplayName("Hűtés típusa")]
        public string CoolerType { get; set; }

        [DisplayName("Memória típusas")]
        public string MemoryType { get; set; }

        [DisplayName("Tápegység csatlakozás")]
        public string PowerSupplyConnection { get; set; }  //(pin)
        #endregion

        #region drive

        [DisplayName("Méret")]
        public int? Size { get; set; }

        [DisplayName("Olvasási sebesség")]
        public int? ReadSpeed { get; set; }

        [DisplayName("Írási sebesség")]
        public int? WriteSpeed { get; set; }

        [DisplayName("Csatlakozás")]
        public string DriveSocket { get; set; }
        #endregion

        #region memory

        [DisplayName("Méret")]
        public int? Capacity { get; set; }

        [DisplayName("Memória típusa")]
        public string MemoryTypeForMmoryCard { get; set; }

        [DisplayName("Időzítés(CL)")]
        public int? Timing { get; set; } //(CL)

        [DisplayName("Kiszerelés:")]
        public int? Kit { get; set; } //modules
        #endregion

        #region motherboard

        [DisplayName("Alaplap típusa")]
        public string Type { get; set; }

        [DisplayName("Chipset típusa")]
        public string Chipset { get; set; }

        [DisplayName("Foglalat")]
        public string CpuSocketForMotherboard { get; set; }

        [DisplayName("Támogatott memória típus")]
        public string SupportedMemoryType { get; set; }

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
