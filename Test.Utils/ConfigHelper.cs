using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;

namespace Test.Utils
{
    public class ConfigHelper
    {
        public static ConfigHelper Instance = new ConfigHelper();
        private static IConfiguration configuration;
        static ConfigHelper()
        {
            configuration = new ConfigurationBuilder()
            .Add(new JsonConfigurationSource { Path = "config.json", ReloadOnChange = true })
            .Build();
        }
        public string GetValue(string name,string key)
        {
            string result = string.Empty;
            try
            {
                result = configuration.GetSection(name)[key];
            }
            catch
            {

            }
            return result;
        }
        public string GetValue(string key)
        {
            string result = string.Empty;
            try
            {
                result = configuration[key];
            }
            catch
            {

            }
            return result;
        }
        public string GetConnectionString(string key="")
        {
            string result = string.Empty;
            try
            {
                if (string.IsNullOrWhiteSpace(key))
                    key = "conn";
                result = configuration.GetConnectionString(key);
            }
            catch
            {

            }
            return result;
        }
    }
}
