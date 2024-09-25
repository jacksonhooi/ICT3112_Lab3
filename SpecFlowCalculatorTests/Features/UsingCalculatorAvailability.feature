Feature: UsingCalculatorAvailability
In order to calculate MTBF and Availability
As someone who struggles with math
I want to be able to use my calculator to do this
@Availability
Scenario: Calculating MTBF
	Given I have a calculator
	When I have entered 200 and 10 into the calculator and press MTBF
	Then the MTBF result should be 210

@Availability
Scenario: Calculating Availability
	Given I have a calculator
	When I have entered 200 and 10 into the calculator and press Availability
	Then the availability result should be 0.95238095238095233

@Availability
Scenario: MTBF with zero MTTR
	Given I have a calculator
	When I have entered 400 and 0 into the calculator and press MTBF
	Then the MTBF result should be 400

@Availability
Scenario: Availability with zero MTTR
	Given I have a calculator
	When I have entered 400 and 0 into the calculator and press Availability
	Then the availability result should be 1