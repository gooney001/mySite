using log4net;
using log4net.Config;
using log4net.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Test.Utils.Log
{
    public class Logger
    {
        private static Lazy<Logger> _instance = new Lazy<Logger>(()=> {
            return new Logger();
        },true);
        public static Logger Instance
        {
            get
            {
                return _instance.Value;
            }
        }
        private static ILog log;
        static Logger()
        {
            ILoggerRepository repository = LogManager.CreateRepository("NETCoreRepository");
            XmlConfigurator.Configure(repository, new FileInfo("log4net.config"));
            log = LogManager.GetLogger(repository.Name, "NETCorelog4net");
        }
        public void Write(string request,string response,Exception ex,int timeStamp=0)
        {
            string message = "\r\n";
            message += "RQ:"+ request+ "\r\n";
            message += "RS:" + response + "\r\n";
            if (ex != null)
            {
                message +="ERROR:"+ex.Message+ "\r\n";
            }
            if (timeStamp > 0)
            {
                message += "TimeStamp:"+ timeStamp.ToString()+ "\r\n";
            }
            log.Info(message);
        }
    }
}
