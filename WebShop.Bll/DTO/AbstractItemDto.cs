using System;
using System.Linq;
using WebShop.Dal.Models;

namespace WebShop.Bll.DTO
{
    public class AbstractItemDto
    {
        public AbstractItemDto(Item item)
        {
            this.Id = item.Id;
            this.Name = item.Name;
            this.Available = item.Available;
            this.PicturePath = item.PicturePath;
            this.ExpectedAvailalbleDate = item.ExpectedAvailalbleDate;
            this.OriginalPrice = item.OriginalPrice;
            this.DiscountedPrice = item.DiscountedPrice;
            this.AverageRating = item.Ratings.Any() ? item.Ratings.Average(x => x.Value) : 0;
            this.Manufacturer = item.Manufacturer;
            this.Description = item.Description;
            this.Warranty = item.Warranty;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Available { get; set; }

        public string PicturePath { get; set; }

        public DateTime? ExpectedAvailalbleDate { get; set; }

        public int OriginalPrice { get; set; }

        public int? DiscountedPrice { get; set; }

        // {0..5}
        public double AverageRating { get; set; }

        public string Manufacturer { get; set; }

        public string Description { get; set; }

        public string Warranty { get; set; }
    }
}
