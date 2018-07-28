using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Utils
{
    public class Test
    {
        public void Test1()
        {
            var r = ConfigHelper.Instance.GetConnectionString();
            Console.WriteLine(r);
        }
    }
}
