using System;
using System.Collections.Generic;
using WebShop.Dal.Enums;

namespace WebShop.Dal.Models
{
    public  class Item
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Category Category { get; set; }

        public int Available { get; set; }

        public string PicturePath { get; set; }

        public int OriginalPrice { get; set; }

        public int? DiscountedPrice { get; set; }

        public List<Rating> Ratings { get; set; }

        public string Manufacturer { get; set; }

        public string Description { get; set; }

        public string Warranty { get; set; }

        public bool GamingFlag { get; set; }

        public bool IsUsed { get; set; }

        public bool HasRGB { get; set; }

        public DateTime DateSinceInStore { get; set; }

        public bool HighlightedItem { get; set; }

    }
}
