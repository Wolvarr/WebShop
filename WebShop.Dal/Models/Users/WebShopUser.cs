using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using WebShop.Dal.Models.Users;

namespace WebShop.Dal.Models
{
    public class WebShopUser : IdentityUser<Guid>
    {
        public string NickName { get; set; }

        public Address BillingAddress { get; set; }

        public List<Comment> Comments { get; set; }

        public List<Rating> Ratings { get; set; }

        public List<UserCartItem> CartItems { get; set; }

        public List<UserSubscription> Subscriptions { get; set; }

        public List<Order> Orders { get; set; }
    }
}
