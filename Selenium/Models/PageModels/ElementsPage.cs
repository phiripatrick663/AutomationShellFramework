using OpenQA.Selenium;

namespace Selenium.Models.PageModels
{
    public class ElementsPage : BasePage
    {
        public ElementsPage(IWebDriver browser) : base(browser)
        {
            _browser = browser;

        }
        public IWebElement ElementsDropDownList
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("div:nth-child(1)>div>div>div:nth-child(1)>div>ul"));
            }
        }

        public IWebElement TextBoxFullNameField
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("#userName"));
            }
        }

        public IWebElement TextBoxEmailField
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("#userEmail"));
            }
        }

        public IWebElement TextBoxCurrentAddressField
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("#currentAddress"));
            }
        }

        public IWebElement TextBoxPermanentAddressField
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("#permanentAddress"));
            }
        }

        public IWebElement TextBoxSubmitButton
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("#submit"));
            }
        }

        public IWebElement TextBoxEntriesOutput
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("#output"));
            }
        }

        public IWebElement TextBoxEntriesOutputName
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("p#name"));
            }
        }

        public IWebElement TextBoxEntriesOutputEmail
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("p#email"));
            }
        }

        public IWebElement TextBoxEntriesOutputCurrentAddress
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("p#currentAddress"));
            }
        }

        public IWebElement TextBoxEntriesOutputPermanentAddress
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("p#permanentAddress"));
            }
        }
    }
}
