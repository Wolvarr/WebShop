using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebShop.Bll.ServiceInterfaces;
using WebShop.Dal.Models;
using WebShop.Models;

namespace WebShop.Mvc.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IUserService userService;

        public ShoppingCartController(IUserService userService)
        {
            this.userService = userService;
        }

        [Authorize]
        public IActionResult Index(Guid userId)
        {
            return View(this.GetItemsInCart(userId));
        }

        public ShoppingCartViewModel GetItemsInCart(Guid userId)
        {
            return new ShoppingCartViewModel(this.userService.GetAllItemsInCart(userId));
        }

        public IActionResult RemoveItemFromCart(Guid userId, Guid itemId)
        {
            this.userService.RemoveItemFromCart(userId, itemId);
            var url = this.Request.Headers["Referer"].ToString();
            return Redirect(url);
        }

        public IActionResult EditCartItemQuantity(Guid userId, Guid cartItemId, int quantity)
        {
            this.userService.EditCartItemQuantity(userId, cartItemId, quantity);
            var url = this.Request.Headers["Referer"].ToString();
            return Redirect(url);
        }

        public IActionResult FinalizeOrder()
        {
            return View();
        }
    }
}