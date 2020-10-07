using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Bll.DTO
{
    public class AddCommentDTO
    {
        public string Content { get; set; }

        public int? Rating { get; set; }

        public Guid UserId { get; set; }

        public Guid ItemId { get; set; }
    }
}
