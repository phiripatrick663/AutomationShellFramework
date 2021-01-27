using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using Configuration.Config;

namespace Selenium.Selenium.Browserfactory
{
    public class Browsers
    {
        private readonly string _browser;

        public Browsers()
        {
                //Getting the BROWSER parameter from the config file
                _browser = ConfigurationManager.GetJsonConfig.Browser;
        }

        public IWebDriver GetBrowser()
        {
            IWebDriver webDriver;

            switch (_browser)
            {
                case "Chrome":
                    var chromeOptions = new ChromeOptions();
                    chromeOptions.SetLoggingPreference(LogType.Driver, LogLevel.All);
                    chromeOptions.AddAdditionalCapability("useAutomationExtension", false);
                    chromeOptions.AddArguments("--no-sandbox");
                    webDriver = new ChromeDriver(chromeOptions);
                    return webDriver;
                case "IE":
                    InternetExplorerOptions options = new InternetExplorerOptions()
                    {
                        EnableNativeEvents = false,
                        IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                        IgnoreZoomLevel = true,
                        EnablePersistentHover = true,
                        RequireWindowFocus = true,
                        PageLoadStrategy = PageLoadStrategy.Eager
                    };

                    webDriver = new InternetExplorerDriver(ConfigurationManager.WebDriverBaseDir, options, TimeSpan.FromSeconds(30));
                    return webDriver;
                case "Firefox":
                    webDriver = new FirefoxDriver();
                    return webDriver;
                default:
                    throw new ArgumentException("No browser found in configuration file");
            }
        }
    }
}
