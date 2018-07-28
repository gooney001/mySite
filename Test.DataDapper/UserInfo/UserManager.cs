using Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using Test.DataDapper.Entity;
using Test.DataDapper.Model;

namespace Test.DataDapper.UserInfo
{
    public class UserManager
    {
        public List<UserMenuModel> GetUserMenus(int userId)
        {
            string sql = @"SELECT ur.UserId,rm.MenuId,m.Name AS MenuName,m.Icon AS MenuIcon,m.url AS MenuUrl,m.ParentId AS MenuParentId,m.Type AS MenuType,rm.RoleId,r.Name AS RoleName 
FROM sysdb.`sys_userrolemap` ur
INNER JOIN sysdb.`sys_role` r ON r.Id = ur.RoleId AND r.IsDel = 0
INNER JOIN sysdb.`sys_rolemenumap` rm ON r.Id = rm.RoleId AND rm.IsDel = 0
INNER JOIN sysdb.`sys_menu` m ON rm.MenuId = m.Id AND m.IsDel = 0
WHERE ur.IsDel = 0 AND ur.UserId = @UserId";
            DapperMySQLHelp dapperMySQLHelp = new DapperMySQLHelp();
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@UserId", userId);
            var r = dapperMySQLHelp.FindToList<UserMenuModel>(sql, parameters) as List<UserMenuModel>;
            return r;
        }
        public sys_user GetUser(Test.ViewModel.UserInfo user)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"SELECT
  `Id`,
  `UserName`,
  `Password`,
  `RealName`,
  `Email`,
  `Mobile`,
  `Remark`,
  `CreaterId`,
  `CreateTime`,
  `UpdaterId`,
  `UpdateTime`,
  `LastLoginTime`,
  `LoginTimes`,
  `DepartmentId`,
  `IsDeleted`
FROM
  `sysdb`.`sys_user` U WHERE 1=1");
            DapperMySQLHelp dapperMySQLHelp = new DapperMySQLHelp();
            DynamicParameters parameters = new DynamicParameters();
            if (!string.IsNullOrWhiteSpace(user.UserName))
            {
                sb.Append(" AND U.UserName=@UserName");
                parameters.Add("@UserName", user.UserName);
            }
            var r=dapperMySQLHelp.FindOne<sys_user>(sb.ToString(),parameters);
            return r;
        }
    }
}
