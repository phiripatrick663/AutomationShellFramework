using Configuration.Config;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Selenium.Models.PageModels;
using TechTalk.SpecFlow;

namespace SpecFlow.Steps.ElementsSteps
{
    [Binding]
    public class TextBoxSteps : BasePage
    {
        private readonly DemoQAHomePage _demoQAHomePage;
        private readonly ElementsPage _elementsPage;
        private readonly bool _IsPageReady = false;
        private readonly string _tagname = "li";
        private string __fullName;
        private string _email;
        private string _currentAddress;
        private string _permanentAddressString;

        public TextBoxSteps(IWebDriver browser) : base(browser)
        {
            _browser = browser;
            _demoQAHomePage = new DemoQAHomePage(_browser);
            _elementsPage = new ElementsPage(_browser);
        }

        [Given(@"I navigate to DemoQA site")]
        public void GivenINavigateToDemoQASite()
        {
            _browser.Navigate().GoToUrl(URLSettings.DemoProjectURL);
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
        }

        [Given(@"I open Elements card from landing page")]
        public void GivenIOpenElementsCardFromLandingPage()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _demoQAHomePage.DemoqaLandingPageElementsCard.Should().NotBeNull();
            new Actions(_browser).MoveToElement(_demoQAHomePage.DemoqaLandingPageElementsCard).Click().Build().Perform();
        }

        [Given(@"I select '(.*)' from dropdown list")]
        public void GivenISelectFromDropdownList(string elementsDropDownSelection)
        {
            var dropDownOptions = _elementsPage.ElementsDropDownList;
            _seleniumExtActions.SelectDropDownOption(dropDownOptions, _tagname, elementsDropDownSelection);
        }

        [Given(@"I eneter '(.*)' in the full name filed")]
        public void GivenIEneterInTheFullNameFiled(string textBoxFullName)
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.TextBoxFullNameField.Should().NotBeNull();
            _seleniumExtActions.ClearInputField(_elementsPage.TextBoxFullNameField);
            _seleniumExtGeneral.Wait(_IsPageReady, 2);
            _elementsPage.TextBoxFullNameField.SendKeys(textBoxFullName);
            __fullName = textBoxFullName;
        }

        [Given(@"I enter '(.*)' in the email field")]
        public void GivenIEnterInTheEmailField(string textBoxEmail)
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.TextBoxEmailField.Should().NotBeNull();
            _seleniumExtActions.ClearInputField(_elementsPage.TextBoxEmailField);
            _seleniumExtGeneral.Wait(_IsPageReady, 2);
            _elementsPage.TextBoxEmailField.SendKeys(textBoxEmail);
            _email = textBoxEmail;
        }

        [Given(@"I enter '(.*)', '(.*)', and '(.*)' in the current address field")]
        public void GivenIEnterAndInTheCurrentAddressField(string streetName, string city, string zipCode)
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.TextBoxCurrentAddressField.Should().NotBeNull();
            _seleniumExtActions.ClearInputField(_elementsPage.TextBoxCurrentAddressField);
            _seleniumExtGeneral.Wait(_IsPageReady, 2);
            _elementsPage.TextBoxCurrentAddressField.SendKeys(streetName);
            _seleniumExtGeneral.Wait(_IsPageReady, 2);
            _elementsPage.TextBoxCurrentAddressField.SendKeys(Keys.Shift + Keys.Enter);
            _seleniumExtGeneral.Wait(_IsPageReady, 2);
            _elementsPage.TextBoxCurrentAddressField.SendKeys(city);
            _seleniumExtGeneral.Wait(_IsPageReady, 2);
            _elementsPage.TextBoxCurrentAddressField.SendKeys(Keys.Shift + Keys.Enter);
            _seleniumExtGeneral.Wait(_IsPageReady, 2);
            _elementsPage.TextBoxCurrentAddressField.SendKeys(zipCode);

            _currentAddress = string.Concat(streetName + " " + city + " " + zipCode);
        }

        [Given(@"I enter '(.*)' in the permanent address field")]
        public void GivenIEnterInThePermanentAddressField(string permanentAddressString)
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.TextBoxPermanentAddressField.Should().NotBeNull();
            _seleniumExtActions.ClearInputField(_elementsPage.TextBoxPermanentAddressField);
            _seleniumExtGeneral.Wait(_IsPageReady, 2);
            _elementsPage.TextBoxPermanentAddressField.SendKeys(permanentAddressString);
            _permanentAddressString = permanentAddressString;
        }

        [When(@"I click the Submit button")]
        public void WhenIClickTheSubmitButton()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.TextBoxSubmitButton.Should().NotBeNull();
            new Actions(_browser).MoveToElement(_elementsPage.TextBoxSubmitButton).Click().Build().Perform();
        }

        [Then(@"An output box displays my entries")]
        public void ThenAnOutputBoxDisplaysMyEntries()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.TextBoxEntriesOutput.Should().NotBeNull();
            _elementsPage.TextBoxEntriesOutputName.Text.Should().Contain(__fullName);
            _elementsPage.TextBoxEntriesOutputEmail.Text.Should().Contain(_email);
            _elementsPage.TextBoxEntriesOutputCurrentAddress.Text.Should().Contain(_currentAddress);
            _elementsPage.TextBoxEntriesOutputPermanentAddress.Text.Should().Contain(_permanentAddressString);
        }
    }
}
