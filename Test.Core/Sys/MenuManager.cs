using System;
using System.Collections.Generic;
using System.Text;
using Test.ViewModel;

namespace Test.Core.Sys
{
    public class MenuManager
    {
        public List<MenuView> GetMenu(QueryMenuView request)
        {
            var menuList = new List<MenuView> {
                new MenuView{ Name="新增"},
                new MenuView{ Name="审核"},
            };
            return menuList;
        }
    }
}
