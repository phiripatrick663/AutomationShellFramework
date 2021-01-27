using Configuration.Config;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.Models.PageModels;
using TechTalk.SpecFlow;

namespace SpecFlow.Steps
{
    [Binding]
    [TestFixture]
    public class GoogleSearchSteps : BasePage
    {
        private readonly GoogleSearchPage _googleSearchPage;
        private readonly bool _IsPageReady = false;


        public GoogleSearchSteps(IWebDriver browser) : base(browser)
        {
            _browser = browser;
            _googleSearchPage = new GoogleSearchPage(_browser);
        }

        [Given(@"I navigate to Google site")]
        public void GivenINavigateToGoogleSite()
        {
            _browser.Navigate().GoToUrl(ConfigurationManager.GetJsonConfig.DemoURL);
            _seleniumExtGeneral.Wait(_IsPageReady, 25);
        }

        [Given(@"I enter '(.*)' in search bar")]
        public void GivenIEnterInSearchBar(string searchText)
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _googleSearchPage.SearchBox.SendKeys(searchText);
            _googleSearchPage.SearchBox.SendKeys(Keys.Return);
        }

        [Then(@"The result page renders")]
        public void ThenTheResultPageRenders()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 10);
            _googleSearchPage.SearchBoxResults.Text.Should().Contain("About 104");
        }
    }
}
