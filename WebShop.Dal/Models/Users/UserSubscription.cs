using System;

namespace WebShop.Dal.Models
{
    public class UserSubscription
    {
        public UserSubscription()
        {

        }

        public UserSubscription(WebShopUser user, Item item)
        {
            this.UserId = user.Id;
            this.ItemId = item.Id;
        }

        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid ItemId { get; set; }
    }
}