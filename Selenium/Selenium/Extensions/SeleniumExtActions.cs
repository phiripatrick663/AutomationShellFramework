using OpenQA.Selenium;
using System;
using System.Linq;

namespace Selenium.Selenium.Extensions
{
    public class SeleniumExtActions
    {
        protected IWebDriver _browser;

        public SeleniumExtActions(IWebDriver browser)
        {
            _browser = browser;
        }

        /// <summary>
        /// Use keys to clear a text field.
        /// </summary>
        /// <param name="webElementField"></param>
        /// <returns></returns>
        public void ClearInputField(IWebElement webElementField)
        {
            webElementField.SendKeys(Keys.Control + "a");
            webElementField.SendKeys(Keys.Backspace);

        }

        /// <summary>
        /// Hover an element using Javascript executor.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public void JavaScriptHoverOverElement(IWebElement element)
        {
            IJavaScriptExecutor executor = _browser as IJavaScriptExecutor;
            String javaScript = "var evObj = document.createEvent('MouseEvents');" +
                "evObj.initMouseEvent(\"mouseover\",true, false, window, 0, 0, 0, 0, 0, false, false, false, false, 0, null);" +
            "arguments[0].dispatchEvent(evObj);";
            executor.ExecuteScript(javaScript, element);
        }

        /// <summary>
        /// Search for  a dropdown element by text and item tagname, and click on matched element.
        /// </summary>
        /// <param name="selectionControl"></param>
        /// <param name="tagname"></param>
        /// <param name="selectionText"></param>
        /// <returns></returns>
        public void SelectDropDownOption(IWebElement selectionControl, string tagname, string selectionText)
        {
            var OptionList = selectionControl.FindElements(By.TagName(tagname));
            var element = OptionList.First(e => e.Text == selectionText);
            JavaScriptHoverOverElement(element);
            element.Click();
        }
    }
}
