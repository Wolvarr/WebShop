namespace WebShop.Dal.Models
{
    public class HardDrive : Hardware
    {
        public int Size { get; set; }

        public int ReadSpeed { get; set; }

        public int WriteSize { get; set; }
    }
}