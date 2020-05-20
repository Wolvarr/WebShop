using System.Collections.Generic;
using WebShop.Dal.Enums;

namespace WebShop.Bll.Specifications
{
    public class ItemSpecification
    {
        public int? PageNumber { get; set; } = 1;
        public int? PageSize { get; set; } = 15;

        //filtering

        public string ComplexFilter { get; set; }

        public string Name { get; set; }

        public List<string> SelectedCategories { get; set; } = new List<string>();

        public List<string> SelectedManufacturers { get; set; } = new List<string>();

        public bool? HasRGB { get; set; }

        public bool? IsGaming { get; set; }

        public bool? IsUsed { get; set; }

        public int? MinPrice { get; set; }

        public int? MaxPrice { get; set; }

        public int? MinRating { get; set; }

        public int? MaxRating { get; set; }

        public ItemOrder? Order { get; set; }

        public bool? IsNewArrival { get; set; }

        public bool? IsDiscounted { get; set; }

        public enum ItemOrder
        {
            PriceDescending,
            PriceAscending,
            RatingDescending,
            RatingAscending
        }
    }
}
