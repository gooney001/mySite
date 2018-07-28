using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Utils;
using Test.ViewModel;

namespace Test.OpenSite.Utils
{
    public class GetCurrentInfo
    {
        private GetCurrentInfo() { }
        private static Lazy<GetCurrentInfo> _instance = new Lazy<GetCurrentInfo>(()=> {
            return new GetCurrentInfo();
        },true);
        public static GetCurrentInfo Instance
        {
            get
            {
                return _instance.Value;
            }
        }
        public UserInfo UserInfo()
        {
            try
            {
                //byte[] _userBytes;
                //HttpContextCurrent.Instance.HttpContext.Session.TryGetValue("userInfo", out _userBytes);

                //var _temp1 = ByteConvertHelper.Bytes2Object<UserInfo>(_userBytes);
                string _temp = HttpContextCurrent.Instance.HttpContext.Session.GetString("userInfo");
                if (string.IsNullOrWhiteSpace(_temp))
                    return null;
                var r = JsonConvert.DeserializeObject<UserInfo>(_temp);
                return r;
            }
            catch
            {

            }
            return null;
        }
        public void SetUserInfo(UserInfo user)
        {
            try
            {
                HttpContextCurrent.Instance.HttpContext.Session.Set("userInfo", ByteConvertHelper.Object2Bytes(user));
            }
            catch
            {

            }
        }
    }
}
