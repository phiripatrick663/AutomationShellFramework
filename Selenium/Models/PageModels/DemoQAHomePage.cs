using OpenQA.Selenium;

namespace Selenium.Models.PageModels
{
    public class DemoQAHomePage : BasePage
    {
        public DemoQAHomePage(IWebDriver browser) : base(browser)
        {
            _browser = browser;

        }

        public IWebElement DemoqaLandingPageElementsCard
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("div.home-body>div>div:nth-child(1)"));
            }
        }

        public IWebElement DemoqaLandingPageFormsCard
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("div.home-body>div>div:nth-child(2)"));
            }
        }

        public IWebElement DemoqaLandingPageAlertsFrameWindowsCard
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("div.home-body>div>div:nth-child(3)"));
            }
        }

        public IWebElement DemoqaLandingPageWidgetsCard
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("div.home-body>div>div:nth-child(4)"));
            }
        }

        public IWebElement DemoqaLandingPageInteractionsCard
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("div.home-body>div>div:nth-child(5)"));
            }
        }

        public IWebElement DemoqaLandingPageBookStoreApplicationCard
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("div.home-body>div>div:nth-child(6)"));
            }
        }
    }
}
