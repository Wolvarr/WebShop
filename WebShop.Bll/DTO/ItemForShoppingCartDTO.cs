using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Dal.Models;

namespace WebShop.Bll.DTO
{
    public class ItemForShoppingCartDTO
    {

        public ItemForShoppingCartDTO(Item item, int quantity)
        {
            this.Id = item.Id;
            this.Name = item.Name;
            this.PicturePath = item.PicturePath;
            this.Price = item.DiscountedPrice != null ? item.DiscountedPrice.Value : item.OriginalPrice;
            this.Quantity = quantity;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string PicturePath { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }
    }
}
