using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Dal.Models.Users
{
    public class UserCartItem
    {

        public UserCartItem()
        {
                
        }

        public UserCartItem(WebShopUser user, Item item, int quantity)
        {
            this.UserId = user.Id;
            this.ItemId = item.Id;
            this.Quantity = quantity;
        }

        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid ItemId { get; set; }

        public int Quantity { get; set; }
    }
}
