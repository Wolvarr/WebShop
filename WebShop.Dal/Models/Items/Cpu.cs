using WebShop.Dal.Enums;

namespace WebShop.Dal.Models
{
    public class Cpu : Hardware
    {

        public Cpu()
        {
            this.Category = Category.Cpu;

        }
        public string ProcessorFamily { get; set; }

        public int Technology { get; set; } // in nm

        public int CoreNumber { get; set; }

        public int ThreadNumber { get; set; }

        public CpuSocket Socket { get; set; }
    }
}
