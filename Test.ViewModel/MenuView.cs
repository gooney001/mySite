using System;
using System.Collections.Generic;

namespace Test.ViewModel
{
    public class MenuView
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public List<MenuItemView> Items { get; set; }
    }
    public class MenuItemView
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
    }
    public class QueryMenuView
    {
        public int UserId { get; set; }
    }
}
