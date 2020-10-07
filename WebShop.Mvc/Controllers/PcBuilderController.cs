using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebShop.Bll.ServiceInterfaces;
using WebShop.Dal.Models;
using WebShop.Models;
using WebShop.Mvc.Models;

namespace WebShop.Mvc.Controllers
{
    public class PcBuilderController : Controller
    {
        private readonly IItemService itemService;
        private readonly UserManager<WebShopUser> userManager;
        private readonly IUserService userService;

        public PcBuilderController(IItemService itemService, UserManager<WebShopUser> userManager, IUserService userService)
        {
            this.itemService = itemService;
            this.userManager = userManager;
            this.userService = userService;
        }

        public IActionResult Index(PcBuilderViewModel model = null)
        {
            if (model == null)
            {
                return View(new PcBuilderViewModel(this.itemService.GetAvailableItems()));
            }
            else
            {
                var asd = new PcBuilderViewModel(this.itemService.GetAvailableItems());
                asd.Motherboard = model.Motherboard;
                asd.CPU = model.CPU;
                asd.RAM = model.RAM;
                asd.GPU = model.GPU;
                asd.Drive = model.Drive;
                asd.PSU = model.PSU;
                asd.Case = model.Case;

                return View(asd);
            }
        }

        public IActionResult AddToCart(Guid userId, PcBuilderViewModel model)
        {
            var items = new List<Guid>();

            if(model.CPU != Guid.Empty)
            items.Add(model.CPU);

            if (model.Motherboard != Guid.Empty)
                items.Add(model.Motherboard);

            if (model.GPU != Guid.Empty)
                items.Add(model.GPU);

            if (model.RAM != Guid.Empty)
                items.Add(model.RAM);

            if (model.PSU != Guid.Empty)
                items.Add(model.PSU);

            if (model.Drive != Guid.Empty)
                items.Add(model.Drive);

            if (model.Case != Guid.Empty)
                items.Add(model.Case);
            this.userService.AddAllItemsToCart(userId,items);

            return RedirectToAction("Index", "ShoppingCart", new { userId = userId });
        }

    }

}