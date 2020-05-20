using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebShop.Bll.DTO;
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
        private readonly IUserService userService;

        public ItemController(IItemService itemService, UserManager<WebShopUser> userManager, IUserService userService)
        {
            this.itemService = itemService;
            this.userManager = userManager;
            this.userService = userService;
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

        [Authorize]
        public IActionResult AddItemToCart(Guid userId, Guid id, int quantity = 1)
        {
            this.userService.AddItemToCart(userId, id, quantity);
            TempData["message"] = "Termék sikeresen hozzáadva a kosárhoz";
            var url = this.Request.Headers["Referer"].ToString();
            return Redirect(url);
        }

        [Authorize]
        public IActionResult SubscriebeToNotification(Guid userId, Guid itemId)
        {
            if (this.userService.SubscriebeToNotification(userId, itemId))
            {
                TempData["message"] = "Sikeresen feliratkoztál a termékre";
                var url = this.Request.Headers["Referer"].ToString();
                return Redirect(url);

            }
            else
            {
                TempData["message"] = "Erre a termékre már korábban feliratkoztál";
                var url = this.Request.Headers["Referer"].ToString();
                return Redirect(url);
            }
        }

        [Authorize]
        public IActionResult AddRating(int rating)
        {
            TempData["message"] = "Sikeresen feliratkoztál a termékre";
            var url = this.Request.Headers["Referer"].ToString();
            return Redirect(url);
        }

        [Authorize]
        public IActionResult AddComment(AddCommentDTO dto)
        {
            this.itemService.AddComment(dto.UserId, dto.ItemId, dto.Content, dto.Rating, DateTime.Now);
            TempData["message"] = "Kommentedet sikeresen rögzítettük";
            var url = this.Request.Headers["Referer"].ToString();
            return Redirect(url);
        }
    }
}