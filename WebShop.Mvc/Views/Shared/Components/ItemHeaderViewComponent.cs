using Microsoft.AspNetCore.Mvc;
using WebShop.Bll.DTO;

namespace WebShop.Mvc.Views.Shared.Components
{
    public class ItemHeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(ItemHeader itemHeader)
        {
            return View(itemHeader);
        }
    }
}
