using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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