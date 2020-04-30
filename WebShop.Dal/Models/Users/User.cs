using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Dal.Models
{
    public class User : IdentityUser<Guid>
    {
        public Address BillingAddress { get; set; }

        public Address ShippingAddress { get; set; }

        public List<Comment> Comments { get; set; }

        public List<Rating> Ratings { get; set; }

        public List<Order> Orders { get; set; }
    }
}
