﻿using WebShop.Dal.Enums;

namespace WebShop.Dal.Models
{
    public class Memory : Hardware
    {

        public Memory()
        {
            this.Category = Category.Memory;

        }
        public int Capacity { get; set; }

        public MemoryType MemoryType { get; set; }

        public int Timing { get; set; } //(CL)

        public int Kit { get; set; } //modules
    }
}
