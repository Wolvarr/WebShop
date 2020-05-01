﻿using System;
using System.Collections.Generic;

namespace WebShop.Dal.Models
{
    public  class Item
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Available { get; set; }

        public string PicturePath { get; set; }

        public DateTime? ExpectedAvailalbleDate { get; set; }

        public int OriginalPrice { get; set; }

        public int? DiscountedPrice { get; set; }

        public List<Rating> Ratings { get; set; }

        public string Manufacturer { get; set; }

        public string Description { get; set; }

        public string Warranty { get; set; }

    }
}