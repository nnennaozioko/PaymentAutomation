Feature: Registration
As a User,
I Must be able to register ,
So that I can have an account.

@mytag
Scenario: Valid Registration
	Given a user navigate to "https://longrichway.com/"
	When a user click country type
	And a user click okay to select country type
	And a user click on Register
	And a user enter first name "Mary"
	And a user enter last name "Johnson"
	And a user enter email address "testautomation@yahoo.com"
	And a user enter phone number "07474713298"
	And a user enter password "done"
	And a user enter confirm password "done"
	And a user enter street address "25 Tenby"
	And a user enter Town/City "Romford"
	And a user enter state "London"
	And a user click create account
	Then success notification 'Registration succeful login to your account' 

	@mytag
#Scenario: Invalid test(Wrong Email format)
	#Given a user navigate to "https://longrichway.com/"
	#When a user click country type
	#And a user click okay to select country type
	#And a user click on Register
	#And a user enter first name "Mary"
	#And a user enter last name "Johnson"
	#And a user enter email address "testautomationyahoo.com"
	#And a user enter phone number "07474713298"
	#And a user enter password "done"
	#And a user enter confirm password "done"
	#And a user enter street address "25 Tenby"
	#And a user enter Town/City "Romford"
	#And a user enter state "London"
	#And a user click create account
	#Then error message displayed

	@mytag
Scenario: Invalid test(Mismatched password)
	Given a user navigate to "https://longrichway.com/"
	When a user click country type
	And a user click okay to select country type
	And a user click on Register
	And a user enter first name "Mary"
	And a user enter last name "Johnson"
	And a user enter email address "testautomationyahoo.com"
	And a user enter phone number "07474713298"
	And a user enter password "done"
	And a user enter confirm password "none"
	And a user enter street address "25 Tenby"
	And a user enter Town/City "Romford"
	And a user enter state "London"
	And a user click create account
	Then error notification 'The password and confirm password do not match'

		@mytag
Scenario: Invalid test(blank first name)
	Given a user navigate to "https://longrichway.com/"
	When a user click country type
	And a user click okay to select country type
	And a user click on Register
	#And a user enter first name "MarY"
	And a user enter last name "Johnson"
	And a user enter email address "testautomationyahoo.com"
	And a user enter phone number "07474713298"
	And a user enter password "done"
	And a user enter confirm password "done"
	And a user enter street address "25 Tenby"
	And a user enter Town/City "Romford"
	And a user enter state "London"
	And a user click create account
	Then error message first name is required'







