using System;
using System.Linq;
using WebShop.Dal.Models;

namespace WebShop.Bll.DTO
{
    public class ItemHeader
    {
        public ItemHeader(Item item)
        {
            this.Id = item.Id;
            this.Name = item.Name;
            this.Available = item.Available;
            this.PicturePath = item.PicturePath;
            this.OriginalPrice = item.OriginalPrice;
            this.DiscountedPrice = item.DiscountedPrice;
            this.AverageRating = item.Ratings.Any() ? Convert.ToInt32(item.Ratings.Average(x => x.Value)) : 0;
            this.Manufacturer = item.Manufacturer;
            this.Description = item.Description;
            this.GamingFlag = item.GamingFlag;
            this.IsUserd = item.IsUsed;
            this.HasRGB = item.HasRGB;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Available { get; set; }

        public string PicturePath { get; set; }

        public int OriginalPrice { get; set; }

        public int? DiscountedPrice { get; set; }

        // {0..5}
        public int AverageRating { get; set; }

        public string Manufacturer { get; set; }

        public string Description { get; set; }

        public bool GamingFlag { get; set; }

        public bool IsUserd { get; set; }

        public bool HasRGB { get; set; }
    }
}
