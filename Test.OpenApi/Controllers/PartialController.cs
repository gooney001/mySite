using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Test.OpenApi.Controllers
{
    public class PartialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LeftMenu()
        {
            var item = new MenuView { };
               
            return View();
        }
    }
}