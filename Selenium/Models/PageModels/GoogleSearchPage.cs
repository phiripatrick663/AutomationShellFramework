using OpenQA.Selenium;

namespace Selenium.Models.PageModels
{
    public class GoogleSearchPage : BasePage
    {
        public GoogleSearchPage(IWebDriver browser) : base(browser)
        {
            _browser = browser;
        }

        public IWebElement SearchBox
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("div>div.a4bIc>input"));
            }
        }

        public IWebElement SearchBoxResults
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("#result-stats"));
            }
        }
    }
}
