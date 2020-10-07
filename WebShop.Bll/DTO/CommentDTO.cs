using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Bll.DTO
{
    public class CommentDTO
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string CommentText { get; set; }

        public int Rating { get; set; }

        public DateTime Date { get; set; }
    }
}
