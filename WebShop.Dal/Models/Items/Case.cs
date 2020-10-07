using WebShop.Dal.Enums;

namespace WebShop.Dal.Models
{
    public class Case : Item
    {
        public Case()
        {
            this.Category = Category.Case;
        }

        public int BuiltInFanNumber { get; set; }

        public MotherboardType SupportedMotherboard { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public int Depth { get; set; }

        public int HDDNumber { get; set; }
    }
}
