using System;
using System.Collections.Generic;
using System.Text;
using Test.DataDapper.UserInfo;
using Test.ViewModel;

namespace Test.Core.Sys
{
    public class MenuManager
    {
        public List<MenuView> GetMenu(QueryMenuView request)
        {
            //var menuList = new List<MenuView> {
            //    new MenuView{ Name="审批",Items=new List<MenuItemView>{
            //        new MenuItemView{ Name="新增"},
            //        new MenuItemView{ Name="删除"},
            //        new MenuItemView{ Name="修改"}
            //    } },
            //    new MenuView{ Name="审核",Items=new List<MenuItemView>{
            //        new MenuItemView{ Name="新增"},
            //        new MenuItemView{ Name="删除"},
            //        new MenuItemView{ Name="修改"}
            //    } },
            //};
            var menuList=new List<MenuView> { };
            UserManager manager = new UserManager();
            var r = manager.GetUserMenus(request.UserId);
            return menuList;
        }
    }
}
