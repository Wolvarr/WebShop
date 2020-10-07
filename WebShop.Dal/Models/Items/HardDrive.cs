namespace WebShop.Dal.Models
{
    public class HardDrive : Hardware
    {

        public HardDrive()
        {
            this.Category = Enums.Category.HardDrive;

        }
        public int Size { get; set; }

        public int ReadSpeed { get; set; }

        public int WriteSpeed { get; set; }

        public HardDriveSocket Socket { get; set; }
    }
}