using Microsoft.AspNetCore.Mvc;
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
