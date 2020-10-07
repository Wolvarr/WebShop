using System;

namespace WebShop.Dal.Models
{
    public class Rating
    {
        public Guid Id { get; set; }

        public Guid ItemId { get; set; }

        public Guid UserId { get; set; }

        public int Value { get; set; }
    }
}