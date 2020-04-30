﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Dal.Models
{
    public abstract class Hardware : Item
    {
        public int BaseClock { get; set; }

        public int TDP { get; set; }

        public int Weight { get; set; }
    }
}
