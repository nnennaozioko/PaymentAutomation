Feature: ShoppingCart
	As a registered user of Longrichway
	I want to be able to use the shopping cart
	So that I can shop on Longrichway

@mytag
Scenario: Add item(s) to cart
	Given that I am on Longrichway website
	When I add an item to cart
	Then it should be added to cart

Scenario: View item(s) to cart
	Given that I am on Longrichway website
	When I add an item to cart
	Then I should be to view item in cart

Scenario: Remove item(s) from cart
	Given that I have an item added to cart on Longrichway
	When I remove an item from cart
	Then the item should be removed from cart

Scenario: Add multiple item of the same product to cart
	Given that I have an item added to cart on Longrichway
	When I add the same item to cart
	Then the item should be added to cart
	And the quantity of the item should increase

Scenario: Change the quantity of item in the shopping cart
	Given that I have an item added to cart on Longrichway
	And I am on the shopping cart page
	When I change the quantity of item in the shopping cart
	Then the amount of item should change
	And the new quantity should reflect

Scenario: Coupon/discount code applied
	Given that I have added items to cart
	And I have a valid coupon code
	When I apply the coupon code
	Then it should be accounted for in the total price

Scenario: Out-of-Stock item during shopping
	Given that I am on Longrichway website
	And an item is presently availble
	When the item becomes out-of-stock while shopping
	Then I should not be able to add the item to cart

Scenario: Out-of-Stock item
	Given that I am registered on Longrichway
	When an item is already out-of-stock
	Then I should not be able to add the item to cart

Scenario: User adds item to cart and closes browser
	Given that I am registered on Longrichway
	And I have added some items to cart
	When I close the browser tab
	And open the browser again
	Then the item should still be in the cart

Scenario: Add multiple item of the different product to cart
	Given that I have an item added to cart on Longrichway
	When I add the another different item to cart
	Then all items should be added to cart
	And the quantity of the item should increase




