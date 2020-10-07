using WebShop.Dal.Enums;

namespace WebShop.Dal.Models
{
    public class GraphicsCard : Hardware
    {

        public GraphicsCard()
        {
            this.Category = Category.Gpu;

        }
        public int BuiltInMemory { get; set; }

        public int MemoryClock { get; set; }

        public int BandWidth { get; set; }

        public string CoolerType { get; set; }

        public MemoryType MemoryType { get; set; }

        public string PowerSupplyConnection { get; set; }  //(pin)
    }
}
