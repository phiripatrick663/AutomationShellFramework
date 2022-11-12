Feature: GoogleSearch
	Simple Google search

@mytag
Scenario: Google Search
	Given I navigate to Google site
	And   I enter 'Serena Williams' in search bar
	Then  The result page renders