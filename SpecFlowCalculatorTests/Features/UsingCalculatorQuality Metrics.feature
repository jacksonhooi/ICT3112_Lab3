Feature: UsingCalculateQualityMetrics
  In order to assess software quality and track system growth
  As a system quality engineer
  I want to calculate defect density and Shipped Source Instructions (SSI) for successive releases

@DefectDensity
Scenario: Calculating defect density for a system
	Given I have a calculator
	When I have entered 50 defects and 1000 source lines of code into the calculator
	Then the defect density result should be 0.05

@SSI
Scenario: Calculating Shipped Source Instructions for the 2nd release onward
	Given I have a calculator
	When I have entered 1000 SSI for the first release and 1500 SSI for the second release
	Then the total SSI result should be 2500