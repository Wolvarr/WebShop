using WebShop.Dal.Enums;

namespace WebShop.Dal.Models
{
    public class Motherboard : Hardware
    {
        public MotherboardType Type { get; set; }

        public string Chipset { get; set; }

        public CpuSocket Socket { get; set; }

        public MemoryType SupportedMemoryType { get; set; }

        public string SupportedMemorySpeed { get; set; }  //3000, 3200,..

        public int MemorySocketNumber { get; set; }
    }
}
