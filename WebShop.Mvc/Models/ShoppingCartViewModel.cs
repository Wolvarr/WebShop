using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Bll.DTO;
using WebShop.Dal.Models;

namespace WebShop.Models
{
    public class ShoppingCartViewModel
    {
        public ShoppingCartViewModel(List<ItemForShoppingCartDTO> items)
        {
            this.ItemsInCart = items;
            this.TotalPrice = items.Sum(x => x.Price * x.Quantity);
        }

        public List<ItemForShoppingCartDTO> ItemsInCart { get; set; }

        public int TotalPrice { get; set; }
    }
}
