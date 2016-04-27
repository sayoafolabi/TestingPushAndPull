Feature: SearchAndViewACar
	In order to view a car
	As a customer
	I want to be able to search for and view a car


Scenario: Customer can search for and view a car
	Given I navigate to Autotrader website
	When search for a car type
	Then the result is displayed
	And I can view a selected car
