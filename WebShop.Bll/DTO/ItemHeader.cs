using System;
using System.Linq;
using WebShop.Bll.Extensions;
using WebShop.Dal.Enums;
using WebShop.Dal.Models;

namespace WebShop.Bll.DTO
{
    public class ItemHeader
    {
        public ItemHeader(Item item)
        {
            this.Id = item.Id.ToString();
            this.Name = item.Name;
            this.Available = item.Available;
            this.PicturePath = item.PicturePath;
            this.OriginalPrice = item.OriginalPrice;
            this.DiscountedPrice = item.DiscountedPrice;
            this.AverageRating = item.Ratings.Any() ? Convert.ToInt32(item.Ratings.Average(x => x.Value)) : 0;
            this.Manufacturer = item.Manufacturer;
            this.ShortDescription = item.ShortDescription;
            this.Description = item.Description;
            this.GamingFlag = item.GamingFlag;
            this.IsUsed = item.IsUsed;
            this.HasRGB = item.HasRGB;
            this.Category = EnumExtensionMethods.GetDescription(item.Category);
            if(item is Motherboard)
            {
                this.CpuSocket = (item as Motherboard).Socket;
            }
            if (item is Cpu)
            {
                this.CpuSocket = (item as Cpu).Socket;
            }
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Category{ get; set; }

        public int Available { get; set; }

        public string PicturePath { get; set; }

        public int OriginalPrice { get; set; }

        public int? DiscountedPrice { get; set; }

        // {0..5}
        public int AverageRating { get; set; }

        public string Manufacturer { get; set; }

        public string Description { get; set; }

        public string ShortDescription { get; set; }

        public bool GamingFlag { get; set; }

        public bool IsUsed { get; set; }

        public bool HasRGB { get; set; }

        public CpuSocket? CpuSocket { get; set; }
    }
}
