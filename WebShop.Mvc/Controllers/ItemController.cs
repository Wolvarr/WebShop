using System;
using System.IO;
using System.Linq;
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

        public IActionResult Index(ItemSpecification specification, ItemBrowserViewModel model = null)
        {
            if (specification?.PageNumber != null)
                specification.PageNumber -= 1;

            if (model == null)
            {
                return View(new ItemBrowserViewModel(this.itemService.GetAllItems(specification)));
            }
            else
            {
                return View(new ItemBrowserViewModel(this.itemService.GetAllItems(specification)) { SelectedCategory = model.SelectedCategory });
            }
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

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public IActionResult CreateItem(CreateItemViewModel item)
        {
            var dto = new CreateItemDTO();

            if (item.Create == true && item.Category != null && item.Name != null)
            {
                var file = Request.Form.Files.First();
                if (file != null)
                {
                    if (!Directory.Exists(Directory.GetCurrentDirectory() + "/wwwroot/images/items"))
                    {
                        Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/wwwroot/images/items");
                    }
                    using (var fileStream = new FileStream(Directory.GetCurrentDirectory() + "/wwwroot/images/items/" + file.FileName, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                }
                foreach (var prop in item.GetType().GetProperties())
                {
                    if (prop.GetValue(item, null) != null)
                    {
                        if (dto.GetType().GetProperties().SingleOrDefault(x => x.Name == prop.Name) != null)
                        {
                            var propertyToModify = dto.GetType().GetProperties().SingleOrDefault(x => x.Name == prop.Name);
                            propertyToModify.SetValue(dto, prop.GetValue(item, null));
                        }
                    }
                }
                dto.PicturePath = file.FileName;
                this.itemService.CreateItem(dto);

                return RedirectToAction("Index", "Home");
            }

            return View(item);
        }

        [HttpGet]
        public IActionResult CreateItem(CreateItemViewModel item, string category)
        {
            return View(item);

        }

    }
}