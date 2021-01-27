using OpenQA.Selenium;
using System;
using System.Threading;

namespace Selenium.Selenium.Extensions
{
    public class SeleniumExtGeneral
    {
        protected IWebDriver _browser;

        public SeleniumExtGeneral(IWebDriver browser)
        {
            _browser = browser;
        }

        public IWebElement FindElementBy(By LocatorStatement)
        {
            try
            {
                var element = _browser.FindElement(LocatorStatement);
                if (element != null)
                    return _browser.FindElement(LocatorStatement);
            }
            catch (NotFoundException ex)
            {
                Console.WriteLine("Element not found", ex);
            };
            return null;
        }

        public void Wait(bool condition, int duration)
        {
            bool check = false;
            while (check == false && duration > 0)
            {
                new ManualResetEvent(false).WaitOne(500);
                check = condition;
                duration--;
            }
        }
    }
}
