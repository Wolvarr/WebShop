using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Dal.Enums;

namespace WebShop.Bll.Specifications
{
    public class ItemSpecification
    {
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; } = 30;

        //filtering

        public string ComplexFilter { get; set; }

        public string Name { get; set; }

        public Category? Category { get; set; }

        public string Brand { get; set; }

        public bool? HasRGB { get; set; }

        public bool? IsGaming { get; set; }

        public bool? IsUsed { get; set; }

        public int? MinPrice { get; set; }

        public int? MaxPrice { get; set; }

        public int? MinRating { get; set; }

        public int? MaxRating { get; set; }

        public ItemOrder? Order { get; set; }

        public enum ItemOrder
        {
            PriceDescending,
            PriceAscending,
            RatingDescending,
            RatingAscending
        }
    }
}
