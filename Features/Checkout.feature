Feature: Checkout
	As a registered user of Longrichway
	I want to be able to purchase item(s)
	So that I can have the item(s)

@mytag
Scenario: Choose Payment Method
	Given that I have added items to cart
	When I proceed to checkout
	Then I should see payment methods available
	And I should be able to make payment

Scenario: Choose shipping Delivery method
	Given that I have added items to cart
	And I have choosen a payment method
	When I choose a delivery method
	Then my shipping charges should be calculated
	And my purchase should be completed using my preferred option

Scenario: Successful Purchase Confirmation
	Given that I placed an order on Longrichway
	When I make payment
	Then I should see an order confirmation page
	And I should receive an order confirmation message

Scenario: Order status
	Given that I am registered on Longrichway
	When I am on the account page
	Then I should see my order status
