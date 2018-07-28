using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Test.OpenSite.Utils;

namespace Test.OpenSite.Controllers
{
    public class BaseController:Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var r = GetCurrentInfo.Instance.UserInfo();
            if (r == null)
            {
                context.Result = new RedirectResult("/Login/Index");
                return;
            }
            base.OnActionExecuting(context);
        }
    }
}
