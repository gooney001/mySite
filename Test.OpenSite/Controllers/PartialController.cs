using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Test.ViewModel;

namespace Test.OpenSite.Controllers
{
    public class PartialController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LeftMenu()
        {
            var menuList = new List<MenuView> {
                new MenuView{ Name="新增"},
                new MenuView{ Name="审核"},
            };

            return View();
        }
        public JsonResult GetMenu()
        {
            byte[] userInfoByte;
            HttpContext.Session.TryGetValue("userInfo", out userInfoByte);
            string userInfo = Convert.ToBase64String(userInfoByte);
            var menuList = new List<MenuView> {
                new MenuView{ Name="新增"},
                new MenuView{ Name="审核"},
            };
            return Json(menuList);
        }
    }
}
