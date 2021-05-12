Feature: MyAccount
	As a user of Longrichway
	I want to be able to access my account
	So that I can manage my account

@mytag
Scenario: View orders
	Given that I am on Logged in to Longrichway
	When I click on the account icon
	Then I should see all order on the landing page

Scenario: Update profile
	Given that I am on Logged in to Longrichway
	When I click on the account icon
	Then I should be able to update my profile