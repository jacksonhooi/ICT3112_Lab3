Feature: UsingCalculateMusaLogarithmicModel
  In order to predict system reliability and estimate failures
  As a system quality engineer
  I want to calculate failure intensity and expected failures using the Musa Logarithmic model

@FailureIntensity
Scenario: Calculating failure intensity using the Musa Logarithmic model
	Given I have a calculator
	When I have entered 10 as initial failure intensity, 0.02 as failure intensity decay parameter, and 50 average expected number of failures experience at time
	Then the current failure intensity result should be  3.6787944117144233

@ExpectedFailures
Scenario: Calculating the number of expected failures using the Musa Logarithmic model
	Given I have a calculator
	When I have entered 10 as initial failure intensity, 0.02 as failure intensity decay parameter, and 100 as time
	Then the number of expected failures should be 152.22612188617114
