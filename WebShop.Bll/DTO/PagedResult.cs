﻿using System.Collections.Generic;
using WebShop.Dal.Enums;

namespace WebShop.Bll.DTO
{
    public class PagedResult<T>
    {
        public IEnumerable<T> Results { get; set; }
        public int? AllResultsCount { get; set; }

        public List<Category> Categories { get; set; }
        public List<string> Manufacturers { get; set; }
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }
    }
}
