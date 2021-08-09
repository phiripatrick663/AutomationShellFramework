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

        public IWebElement WebTablesAddButton
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("#addNewRecordButton"));
            }
        }

        public IWebElement WebTablesFirstNameField
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("#firstName"));
            }
        }

        public IWebElement WebTablesLastNameField
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("#lastName"));
            }
        }

        public IWebElement WebTablesEmailField
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("#userEmail"));
            }
        }

        public IWebElement WebTablesAgeField
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("#age"));
            }
        }

        public IWebElement WebTablesSalaryField
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("#salary"));
            }
        }

        public IWebElement WebTablesDepartmentField
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("#department"));
            }
        }

        public IWebElement WebTablesSubmitButton
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("#submit"));
            }
        }

        public IWebElement WebTablesSearchBox
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("#searchBox"));
            }
        }

        public IWebElement WebTablesFirstRow
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("div.ReactTable.-striped.-highlight>div.rt-table"));
            }
        }

        public IWebElement WebTablesEditButton
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("//*[@title='Edit']"));
            }
        }

        public IWebElement WebTablesDeleteButton
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("//*[@title='Delete']"));
            }
        }
    }
}
