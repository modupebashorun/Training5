Feature: Signup
	So that I can use the site
	I need to sign up
	

@mytag
Scenario: Sign up
	Given I am not logged in
	When I complete the sign up form
	Then I am logged in
	And my username is displayed
