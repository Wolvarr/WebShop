using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Dal.Models;

namespace WebShop.Bll.DTO
{
    public class AbstractItemDto
    {
        public AbstractItemDto(Item item)
        {

            this.Name = item.Name;
            this.Available = item.Available;
            this.PicturePath = item.PicturePath;
            this.ExpectedAvailalbleDate = item.ExpectedAvailalbleDate;
            this.OriginalPrice = item.OriginalPrice;
            this.DiscountedPrice = item.DiscountedPrice;
            this.AverageRating = item.AverageRating;
            this.Manufacturer = item.Manufacturer;
            this.Description = item.Description;
            this.Warranty = item.Warranty;
        }

        public string Name { get; set; }

        public int Available { get; set; }

        public string PicturePath { get; set; }

        public DateTime ExpectedAvailalbleDate { get; set; }

        public int OriginalPrice { get; set; }

        public int DiscountedPrice { get; set; }

        // {0..5}
        public int AverageRating { get; set; }

        public string Manufacturer { get; set; }

        public string Description { get; set; }

        public string Warranty { get; set; }
    }
}
