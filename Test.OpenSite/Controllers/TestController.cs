using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.OpenSite.Controllers
{
    public class TestController:BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
