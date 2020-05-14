using Microsoft.AspNetCore.Mvc;

namespace WebShop.Mvc.Controllers
{
    public class PcBuilderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}