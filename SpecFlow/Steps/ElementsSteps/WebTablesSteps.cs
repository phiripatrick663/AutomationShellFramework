using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Selenium.Models.PageModels;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow.Steps.ElementsSteps
{
    [Binding]
    public class WebTablesSteps : BasePage
    {
        private readonly ElementsPage _elementsPage;
        private readonly bool _IsPageReady = false;
        private string __firstName;
        private string _email;
        private string _editedSalary;

        public WebTablesSteps(IWebDriver browser) : base(browser)
        {
            _browser = browser;
            _elementsPage = new ElementsPage(_browser);
        }

        [Given(@"I click the Web Tables Add button")]
        public void GivenIClickTheWebTablesAddButton()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.WebTablesAddButton.Should().NotBeNull();
            new Actions(_browser).MoveToElement(_elementsPage.WebTablesAddButton).Click().Build().Perform();
        }

        [Given(@"I enter '(.*)' in the first name field")]
        public void GivenIEnterInTheFirstNameField(string firstName)
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.WebTablesFirstNameField.Should().NotBeNull();
            _seleniumExtActions.ClearInputField(_elementsPage.WebTablesFirstNameField);
            _seleniumExtGeneral.Wait(_IsPageReady, 2);
            _elementsPage.WebTablesFirstNameField.SendKeys(firstName);
            __firstName = firstName;
        }

        [Given(@"I enter '(.*)' in the last name field")]
        public void GivenIEnterInTheLastNameField(string lastname)
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.WebTablesLastNameField.Should().NotBeNull();
            _seleniumExtActions.ClearInputField(_elementsPage.WebTablesLastNameField);
            _seleniumExtGeneral.Wait(_IsPageReady, 2);
            _elementsPage.WebTablesLastNameField.SendKeys(lastname);
        }

        [Given(@"I enter '(.*)' in the email field for web tables")]
        public void GivenIEnterInTheEmailFieldForWebTables(string email)
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.WebTablesEmailField.Should().NotBeNull();
            _seleniumExtActions.ClearInputField(_elementsPage.WebTablesEmailField);
            _seleniumExtGeneral.Wait(_IsPageReady, 2);
            _elementsPage.WebTablesEmailField.SendKeys(email);
            _email = email;
        }

        [Given(@"I enter '(.*)' in the age field")]
        public void GivenIEnterInTheAgeField(int age)
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.WebTablesAgeField.Should().NotBeNull();
            _seleniumExtActions.ClearInputField(_elementsPage.WebTablesAgeField);
            _seleniumExtGeneral.Wait(_IsPageReady, 2);
            _elementsPage.WebTablesAgeField.SendKeys(age.ToString());
        }

        [Given(@"I enter '(.*)' in the salary field")]
        public void GivenIEnterInTheSalaryField(string salary)
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.WebTablesSalaryField.Should().NotBeNull();
            _seleniumExtActions.ClearInputField(_elementsPage.WebTablesSalaryField);
            _seleniumExtGeneral.Wait(_IsPageReady, 2);
            _elementsPage.WebTablesSalaryField.SendKeys(salary.ToString());
        }

        [Given(@"I enter '(.*)' in the department field")]
        public void GivenIEnterInTheDepartmentField(string department)
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.WebTablesDepartmentField.Should().NotBeNull();
            _seleniumExtActions.ClearInputField(_elementsPage.WebTablesDepartmentField);
            _seleniumExtGeneral.Wait(_IsPageReady, 2);
            _elementsPage.WebTablesDepartmentField.SendKeys(department);
        }

        [Then(@"I click the Web Tables Submit button")]
        public void ThenIClickTheWebTablesSubmitButton()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.WebTablesSubmitButton.Should().NotBeNull();
            new Actions(_browser).MoveToElement(_elementsPage.WebTablesSubmitButton).Click().Build().Perform();
        }

        [When(@"I type first name in the search box")]
        public void WhenITypeFirstNameInTheSearchBox()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.WebTablesSearchBox.Should().NotBeNull();
            _seleniumExtActions.ClearInputField(_elementsPage.WebTablesSearchBox);
            _seleniumExtGeneral.Wait(_IsPageReady, 2);
            _elementsPage.WebTablesSearchBox.SendKeys(__firstName);
        }

        [Then(@"Newly created table entry is displayed")]
        public void ThenNewlyCreatedTableEntryIsDisplayed()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.WebTablesFirstRow.Should().NotBeNull();
            _elementsPage.WebTablesFirstRow.Text.Should().Contain(__firstName);
            _elementsPage.WebTablesFirstRow.Text.Should().Contain(_email);
        }

        [When(@"I click Web Table Edit button")]
        public void WhenIClickWebTableEditButton()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.WebTablesEditButton.Should().NotBeNull();
            new Actions(_browser).MoveToElement(_elementsPage.WebTablesEditButton).Click().Build().Perform();
        }

        [When(@"I change salary to '(.*)'")]
        public void WhenIChangeSalaryTo(int salary)
        {
            _browser.SwitchTo().ActiveElement();
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.WebTablesSalaryField.Should().NotBeNull();
            _elementsPage.WebTablesSalaryField.SendKeys(Keys.Control + "a");
            _seleniumExtGeneral.Wait(_IsPageReady, 2);
            _elementsPage.WebTablesSalaryField.SendKeys(salary.ToString());
            _editedSalary = salary.ToString();
            _browser.SwitchTo().DefaultContent();
        }

        [Then(@"Newly edited table entry is displayed")]
        public void ThenNewlyEditedTableEntryIsDisplayed()
        {
            //search for edited record
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.WebTablesSearchBox.Should().NotBeNull();
            _seleniumExtActions.ClearInputField(_elementsPage.WebTablesSearchBox);
            _seleniumExtGeneral.Wait(_IsPageReady, 2);
            _elementsPage.WebTablesSearchBox.SendKeys(_editedSalary);

            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.WebTablesFirstRow.Should().NotBeNull();
            _elementsPage.WebTablesFirstRow.Text.Should().Contain(__firstName);
            _elementsPage.WebTablesFirstRow.Text.Should().Contain(_editedSalary);
        }

        [When(@"I click the Web Tables Delete button")]
        public void WhenIClickTheWebTablesDeleteButton()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.WebTablesDeleteButton.Should().NotBeNull();
            new Actions(_browser).MoveToElement(_elementsPage.WebTablesDeleteButton).Click().Build().Perform();
        }

        [Then(@"New record is removed from table")]
        public void ThenNewRecordIsRemovedFromTable()
        {
            //confirm edited record is removed
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.WebTablesSearchBox.Should().NotBeNull();
            _seleniumExtActions.ClearInputField(_elementsPage.WebTablesSearchBox);
            _seleniumExtGeneral.Wait(_IsPageReady, 2);
            _elementsPage.WebTablesSearchBox.SendKeys(_editedSalary);

            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.WebTablesFirstRow.Text.Should().NotContain(_editedSalary);
        }
    }
}
