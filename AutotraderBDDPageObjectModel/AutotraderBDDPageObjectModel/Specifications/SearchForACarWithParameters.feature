Feature: SearchForACarWithParameters
	In order to view a specific car
	As a customer
	I want to be able to search for and view a specific car


Scenario Outline: Customer can search for a car with parameters
	Given I navigate to Autotrader website
	When search for a "<Make>"
	Then the result for "<Make>" is displayed
	And I can view a selected car

Scenarios: 
	| Make   |
	| Audi   |
	| Volvo  |
	| Ford   |
	| Honda  |
	| Toyota |
