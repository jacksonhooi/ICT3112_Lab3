Feature: UsingCalculatorFactorial
  In order to explore factorial calculations
  As a mathematics enthusiast
  I want to calculate factorials of numbers

  @Factorial
  Scenario: Factorial of a positive number
    Given I have a calculator
    When I have entered 5 into the calculator and press factorial
    Then the factorial result should be 120

  @Factorial
  Scenario: Factorial of zero
    Given I have a calculator
    When I have entered 0 into the calculator and press factorial
    Then the factorial result should be 1