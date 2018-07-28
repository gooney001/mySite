using System;
using System.Collections.Generic;
using System.Text;

namespace Test.DataDapper.Entity
{
    public class sys_user
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RealName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Remark { get; set; }
        public DateTime LastLoginTime { get; set; }
        public int LoginTimes { get; set; }
        public int DepartmentId { get; set; }
    }
}
