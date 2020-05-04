using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Bll.ServiceInterfaces;
using WebShop.Bll.Specifications;

namespace WebShop.Mvc.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService itemService;

        public ItemController(IItemService itemService)
        {
            this.itemService = itemService;
        }

        public IActionResult Index(ItemSpecification specification)
        {
            if (specification?.PageNumber != null)
                specification.PageNumber -= 1;

            return View(this.itemService.GetAllItems(specification));
        }

        public IActionResult GetItemById(Guid? id)
        {
            if (!id.HasValue)
                return RedirectToAction("Index", "Home");

            return View("ItemFullView", this.itemService.GetItemById(id.Value));
        }

        public ActionResult AddToCart(Guid id, [Bind("Quantity")] int quantity = 1)
        {
            //todo
            var url = this.Request.Headers["Referer"].ToString();
            return Redirect(url);
        }
    }
}