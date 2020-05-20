using System;

namespace WebShop.Dal.Models
{
    public class Comment
    {
        public Guid Id { get; set; }

        public Guid ItemId { get; set; }

        public Guid UserId { get; set; }

        public string CommentText { get; set; }

        public DateTime Date { get; set; }
    }
}