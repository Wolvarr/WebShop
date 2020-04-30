using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebShop.Bll.Services;

namespace WebShop.Mvc.Controllers
{
    public class ItemController : Controller
    {
        private readonly ItemService itemService;

        public ItemController(ItemService itemService)
        {
            this.itemService = itemService;
        }

        [AllowAnonymous]
        public IActionResult Index(Guid? id)
        {
            if (!id.HasValue)
                return RedirectToAction("Index", "Home");

            var cpu = this.itemService.GetCpuById(id.Value);

            if (cpu == null)
                return NotFound();



            return View(cpu);
        }
    }
}