using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Bll.ServiceInterfaces;

namespace WebShop.Mvc.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService itemService;

        public ItemController(IItemService itemService)
        {
            this.itemService = itemService;
        }

        public IActionResult Index()
        {
            return View(this.itemService.GetAllItems());
        }

        public IActionResult GetItemById(Guid? id)
        {
            if (!id.HasValue)
                return RedirectToAction("Index", "Home");

            return View("ItemFullView", this.itemService.GetItemById(id.Value));

            
        }
    }
}