using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Bll.DTO
{
    public class CreateItemDTO
    {
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

        public string Case { get; set; }

        public string Motherboard { get; set; }

        public string Cpu { get; set; }

        public string Gpu { get; set; }

        public string Memories { get; set; }

        public string Drives { get; set; }

        public string PowerSupply { get; set; }
        #endregion

        #region case
        public int? BuiltInFanNumber { get; set; }


        public string SupportedMotherboard { get; set; }

        public int? Height { get; set; }

        public int? Width { get; set; }

        public int? Depth { get; set; }

        public int? HDDNumber { get; set; }
        #endregion

        #region cpu
        public string ProcessorFamily { get; set; }

        public int? Technology { get; set; } // in nm

        public int? CoreNumber { get; set; }

        public int? ThreadNumber { get; set; }

        public string Socket { get; set; }

        #endregion

        #region gpu
        public int? BuiltInMemory { get; set; }

        public int? MemoryClock { get; set; }

        public int? BandWidth { get; set; }

        public string CoolerType { get; set; }

        public string MemoryType { get; set; }

        public string PowerSupplyConnection { get; set; }  //(pin)
        #endregion

        #region drive

        public int? Size { get; set; }

        public int? ReadSpeed { get; set; }

        public int? WriteSpeed { get; set; }

        public string DriveSocket { get; set; }
        #endregion

        #region memory


        public int? Capacity { get; set; }

        public string MemoryTypeForMmoryCard { get; set; }

        public int? Timing { get; set; } //(CL)

        public int? Kit { get; set; } //modules
        #endregion

        #region motherboard

        public string Type { get; set; }

        public string Chipset { get; set; }

        public string CpuSocketForMotherboard { get; set; }

        public string SupportedMemoryType { get; set; }

        public string SupportedMemorySpeed { get; set; }  //3000, 3200,..

        public int? MemorySocketNumber { get; set; }
        #endregion

        #region psu

        public int? ATXConnector { get; set; }

        public int? MolexConnector { get; set; }

        public int? SixPinConnector { get; set; }

        public int? SixPlusTwoConnector { get; set; }

        public int? Efficiency { get; set; } //(%)

        public bool? IsModular { get; set; }
        #endregion
    }
}
