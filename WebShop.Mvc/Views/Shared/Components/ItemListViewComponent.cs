using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Bll.DTO;

namespace WebShop.Mvc.Views.Shared.Components
{
    public class ItemListViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(PagedResult<ItemHeader> items)
        {
            return View(items);
        }
    }
}
