using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.IO;

namespace Configuration.Config
{
    public static class ConfigurationManager
    {
        public static WebDriverConfig GetJsonConfig
        {
            get
            {
                try
                {
                    var configFile = @".\Config\config.json";
                    var configFullPath = Path.Combine(TestContext.CurrentContext.TestDirectory, configFile);
                    return JsonConvert.DeserializeObject<WebDriverConfig>(File.ReadAllText(configFullPath));
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
        public static String WebDriverBaseDir = $@"{TestContext.CurrentContext.TestDirectory}\Selenium\Drivers";
    }
}
