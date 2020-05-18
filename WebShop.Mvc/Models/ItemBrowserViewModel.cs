using System.Collections.Generic;
using System.Linq;
using WebShop.Bll.DTO;
using WebShop.Bll.Specifications;
using WebShop.Dal.Enums;

namespace WebShop.Models
{
    public class ItemBrowserViewModel
    {
        public ItemBrowserViewModel(PagedResult<ItemHeader> result)
        {
            this.ItemResults = result;
            this.AvailableCategories = result.Categories;
            this.AvailableManufacturers = result.Manufacturers;
            this.TotalMinPrice = result.TotalMinPrice;
            this.TotalMaxPrice = result.TotalMaxPrice;
            if (result.Results.Any())
            {
                var maxDiscounted = result.Results.Max(x => x.DiscountedPrice);
                var maxOriginal = result.Results.Max(x => x.OriginalPrice);
                var minDiscounted = result.Results.Min(x => x.DiscountedPrice);
                var minOriginal = result.Results.Min(x => x.OriginalPrice);
                if (maxDiscounted != null)
                {
                    this.SelectedMaxPrice = maxOriginal > maxDiscounted ? maxOriginal : maxDiscounted.Value;
                    this.SelectedMinPrice = maxOriginal > maxDiscounted ? minOriginal : minDiscounted.Value;
                }
                else
                {
                    this.SelectedMaxPrice = maxOriginal;
                    this.SelectedMinPrice = minOriginal;
                }
            }

            else
            {
                this.SelectedMaxPrice = TotalMaxPrice;
                this.SelectedMinPrice = 0;
            }
        }

        public PagedResult<ItemHeader> ItemResults { get; set; }

        public List<Category> AvailableCategories { get; set; } = new List<Category>();

        public List<string> AvailableManufacturers { get; set; } = new List<string>();

        public int SelectedMaxPrice { get; set; }

        public int SelectedMinPrice { get; set; }

        public int TotalMaxPrice { get; set; }

        public int TotalMinPrice { get; set; }
    }
}
