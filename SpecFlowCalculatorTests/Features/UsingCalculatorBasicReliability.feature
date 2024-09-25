Feature: UsingCalculatorBasicReliability
In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

@BasicReliability
Scenario: Calculating current failure intensity 
	Given I have a calculator
	When I have entered 10 as initial failure intensity, 50 as total expected failures, and 100 total number of failures over infinite time
	Then the current failure intensity should be 5

@BasicReliability
Scenario: Calculating expected failures
	Given I have a calculator
	When I have entered 10 as initial failure intensity, 100 total number of failures over infinite time, and 100 as time
	Then the expected number of failures should be 99.995460007023752