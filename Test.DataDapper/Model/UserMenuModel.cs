using System;
using System.Collections.Generic;
using System.Text;

namespace Test.DataDapper.Model
{
    public class UserMenuModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string MenuIcon { get; set; }
        public string MenuUrl { get; set; }
        public int MenuParentId { get; set; }
        public int MenuType { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
