using System;
using System.Collections.Generic;
using System.Text;
using Test.DataDapper.UserInfo;
using Test.Utils;
using Test.ViewModel;

namespace Test.Core.Sys
{
    public class LoginManager
    {
        public UserInfo Login(UserInfo user)
        {
            UserManager bll = new UserManager();
            var r=bll.GetUser(new UserInfo {
                UserName=user.UserName,
                UserId=user.UserId
            });
            if(r==null || r.Password!= EncryptHelper.GetMD5(user.Password))
            {
                return null;
            }
            
            return new UserInfo {UserName=r.UserName};
        }
    }
}
