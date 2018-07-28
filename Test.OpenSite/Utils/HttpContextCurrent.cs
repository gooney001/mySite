using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.OpenSite.Utils
{
    public class HttpContextCurrent
    {
        private HttpContextCurrent() { }
        private static Lazy<HttpContextAccessor> _intance = new Lazy<HttpContextAccessor>(()=> {
            return new HttpContextAccessor();
        },true);
        public static HttpContextAccessor Instance
        {
            get
            {
                return _intance.Value;
            }
        }
    }
}
