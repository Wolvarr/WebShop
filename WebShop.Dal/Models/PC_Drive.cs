using System;
using System.ComponentModel.DataAnnotations;

namespace WebShop.Dal.Models
{
    public class PC_Drive
    {
        [Key]
        public Guid PcId { get; set; }

        public Guid DriveId { get; set; }
    }
}
