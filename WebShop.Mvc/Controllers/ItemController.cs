using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebShop.Bll.ServiceInterfaces;
using WebShop.Bll.Specifications;
using WebShop.Dal.Models;
using WebShop.Models;

namespace WebShop.Mvc.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService itemService;
        private readonly UserManager<WebShopUser> userManager;

        public ItemController(IItemService itemService, UserManager<WebShopUser> userManager)
        {
            this.itemService = itemService;
            this.userManager = userManager;
        }

        public IActionResult Index(ItemSpecification specification)
        {
            if (specification?.PageNumber != null)
                specification.PageNumber -= 1;

            return View(new ItemBrowserViewModel(this.itemService.GetAllItems(specification)));
        }

        public IActionResult GetItemById(Guid? id)
        {
            if (!id.HasValue)
                return RedirectToAction("Index", "Home");

            return View("ItemFullView", this.itemService.GetItemById(id.Value));
        }

        public IActionResult AddItemToCart(Guid userId, Guid id, int quantity = 1)
        {
            this.itemService.AddItemToCart(userId, id, quantity);
            var url = this.Request.Headers["Referer"].ToString();
            return Redirect(url);
        }
    }
}