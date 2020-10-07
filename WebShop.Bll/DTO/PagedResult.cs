using System.Collections.Generic;
using WebShop.Bll.Specifications;
using WebShop.Dal.Enums;

namespace WebShop.Bll.DTO
{
    public class PagedResult<T>
    {
        public IEnumerable<T> Results { get; set; }

        public int? AllResultsCount { get; set; }

        public List<string> Categories { get; set; }

        public List<string> Manufacturers { get; set; }

        public int TotalMinPrice { get; set; }

        public int TotalMaxPrice { get; set; }

        public int? PageNumber { get; set; }

        public int? PageSize { get; set; }

        public ItemSpecification Specification { get; set; }
    }
}
