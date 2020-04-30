using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebShop.Bll.Services;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class HomeController : Controller
    {
        public ItemService itemService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ItemService itemService)
        {
            this.itemService = itemService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
