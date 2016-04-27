Feature: SearchCarTest
	In order to buy a car
	As a customer
	I want to be able to search for a car


Scenario: Customer can search for a car
	Given I navigate to Autotrader website
	When search for a car type
	Then the result is displayed
