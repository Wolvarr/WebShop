using System;
using System.ComponentModel.DataAnnotations;

namespace WebShop.Dal.Models
{
    public class PC_Memory
    {
        [Key]
        public Guid PcId { get; set; }

        public Guid MemoryId { get; set; }
    }
}
