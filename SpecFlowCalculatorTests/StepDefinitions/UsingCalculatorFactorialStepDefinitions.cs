using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorFactorialStepDefinitions
    {

        private readonly CalculatorContext _calculatorContext;

        public UsingCalculatorFactorialStepDefinitions(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }
        [When(@"I have entered (.*) into the calculator and press factorial")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(double p0)
        {
            _calculatorContext.Result = _calculatorContext.Calculator.Factorial(p0);
        }

        [Then(@"the factorial result should be (.*)")]
        public void ThenTheFactorialResultShouldBe(double p0)
        {
            Assert.That(_calculatorContext.Result, Is.EqualTo(p0));
        }
    }
}
