using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Dal.Models
{
    public class OrderItem
    {
        public Guid Id { get; set; }

        public Guid OrderId { get; set; }

        public Guid ItemId { get; set; }
    }
}
