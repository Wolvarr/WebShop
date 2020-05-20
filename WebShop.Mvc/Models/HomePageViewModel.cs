using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebShop.Bll.DTO;

namespace WebShop.Models
{
    public class HomePageViewModel
    {
        public HomePageViewModel(List<ItemHeader> di, List<ItemHeader>hi, string message)
        {
            this.DiscountedItems = di;
            this.HighlightedItems = hi;
            this.StatusMessage = message; 
        }

        public List<ItemHeader> DiscountedItems { get; set; }
        public List<ItemHeader> HighlightedItems { get; set; }

        [TempData]
        public string StatusMessage { get; set; }
    }
}
