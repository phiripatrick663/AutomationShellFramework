using OpenQA.Selenium;
using Selenium.Selenium.Extensions;

namespace Selenium.Models.PageModels
{
    public class BasePage
    {
        public IWebDriver _browser;
        protected SeleniumExtGeneral _seleniumExtGeneral;

        public BasePage(IWebDriver browser)
        {
            _browser = browser;
            _seleniumExtGeneral = new SeleniumExtGeneral(_browser);
        }
    }
}
