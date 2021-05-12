Feature: Login
	As a registered user of Longrichway
	I want to be able to login
	So that I can use the site

@mytag
Scenario: User Valid Login
	Given that a user navigates to the Standard Page "Login"
	When the user enters email as "" and password as ""
	Then the user should be Logged in


Scenario Outline: User valid login with examples
	Given that a user navigates to the Standard Page "Login"
	#When the user puts in the email "<Email>" and password "<password>"
	Then user should be logged into the site
Examples: 
	| Email | Password |
	|       |          |


Scenario Outline: User invalid login with examples
	Given that a user navigates to the Standard Page "Login"
	#When a user logs in with email "<Email>" and password "<password>"
	Then user should not be logged into the site
	And the error message "No user with such credentials, please create a new Account or do a Password Reset"
Examples: 
	| Email | Password |
	|       |          |