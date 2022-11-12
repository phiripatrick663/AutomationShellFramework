Feature: DemoProjectElements
	Interact with Elements page

Background: 
	Given I navigate to DemoQA site

Scenario: Elements-TextBox
	Given I open Elements card from landing page
	And   I select 'Text Box' from dropdown list
	And   I eneter 'Demo Tester' in the full name filed
	And   I enter 'demotester@exampletest.com' in the email field
	And   I enter '400 N. County Road', 'Frisco', and 'TX, 75035' in the current address field
	And   I enter 'Same As Above' in the permanent address field
	When  I click the Submit button
	Then  An output box displays my entries

Scenario: Elements-WebTables
	Given I open Elements card from landing page
	And   I select 'Web Tables' from dropdown list
	And   I click the Web Tables Add button
	And   I enter 'Demo' in the first name field
	And   I enter 'Tester' in the last name field
	And   I enter 'demotester@exampletest.com' in the email field for web tables
	And   I enter '30' in the age field
	And   I enter '4000' in the salary field
	And   I enter 'Quality Assurance' in the department field
	Then  I click the Web Tables Submit button
	When  I type first name in the search box
	Then  Newly created table entry is displayed
	When  I click Web Table Edit button
	And   I change salary to '6000'
	Then  I click the Web Tables Submit button
	When  I type first name in the search box
	Then  Newly edited table entry is displayed
	When  I click the Web Tables Delete button
	Then  New record is removed from table