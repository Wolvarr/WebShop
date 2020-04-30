using System;

namespace WebShop.Dal.Models
{
    public class Rating
    {
        public Guid Id { get; set; }

        public Guid ItemId { get; set; }

        public Item Item { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }

        public int Value { get; set; }
    }
}