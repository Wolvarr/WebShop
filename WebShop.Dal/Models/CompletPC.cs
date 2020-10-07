using System;
using System.Collections.Generic;

namespace WebShop.Dal.Models
{
    public class CompletPC : Item
    {
        public string Brand { get; set; }

        public string  Case { get; set; }

        public string Motherboard { get; set; }

        public string Cpu { get; set; }

        public string Gpu { get; set; }

        public string Memories { get; set; }

        public string Drives { get; set; }

        public string PowerSupply { get; set; }

    }
}
