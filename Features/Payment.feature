Feature: Payment
	Users should be able to select a method of payment
    So that they may be able to pay for their products.Existing address /Success card
	

@mytag
Scenario: Valid Test: Payment using Paystack/Homedelivery/
Given a registered user navigate to "https://longrichway.com/"
	When a usre click country type 
	And a user click Ok
	And a user click sign in
	And a user enter email "ozioko.nnenna@yahoo.com"
	And a user type password "Kamsi12£"
	And a user click login
	#And a user navigate to "https://longrichway.com/home/category/97"
	And a user click categories
	And a userclick faminine care
	And a user click featured Product
	And a user enter quantity "2"
	And a user click add to cart
	And a user click cart
	And a user click view cart
	#And a user click proceed checkout
	#And a user click pay stack
	#And a user click home delivery
	#And a user click existing address
	#And a user enter comment
	#And a user click complete order
	#And a userclick on success card
	#And a user click pay
	#Then payment notification apperated "payment made successfully"