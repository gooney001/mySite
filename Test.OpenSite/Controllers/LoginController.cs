using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Core.Sys;
using Test.OpenSite.Utils;
using Test.ViewModel;

namespace Test.OpenSite.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login([FromForm]UserInfo user)
        {
            var _user=GetCurrentInfo.Instance.UserInfo();
            if (_user != null)
            {
                return Redirect("/Test/Index");
            }
            LoginManager lg = new LoginManager();
            var r=lg.Login(user);
            if (r == null)
            {
                ViewBag.ErrInfo = "用户名或密码错误";
                return View("Index",new {ok=false,msg="用户名或密码错误"});
            }
            GetCurrentInfo.Instance.SetUserInfo(r);

            return Redirect("/Test/Index");
        }
    }
}
