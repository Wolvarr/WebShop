using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebShop.Dal.Models
{
    public class PC_Memory
    {
        [Key]
        public Guid PcId { get; set; }

        public Guid MemoryId { get; set; }
    }
}
