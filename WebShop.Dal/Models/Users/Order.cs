using System;
using System.Collections.Generic;
using WebShop.Dal.Enums;

namespace WebShop.Dal.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public WebShopUser User { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public List<OrderItem> Items { get; set; }

        public Address BillingAddress { get; set; }

        public Address ShippingAddress { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public string Comment { get; set; }
    }
}