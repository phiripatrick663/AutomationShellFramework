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