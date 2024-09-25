using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorDivisionStepDefinitions
    {

        private readonly CalculatorContext _calculatorContext;

        // Injecting the CalculatorContext via constructor
        public UsingCalculatorDivisionStepDefinitions(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }

       
        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(double p0, double p1)
        {
            _calculatorContext.Result = _calculatorContext.Calculator.Divide(p0, p1);
        }

        [Then(@"the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBe(double p0)
        {
            Assert.That(_calculatorContext.Result, Is.EqualTo(p0));
        }


        [Then(@"the division result equals positive_infinity")]
        public void ThenTheDivisionResultEqualsPositive_Infinity()
        {
            Assert.That(_calculatorContext.Result, Is.EqualTo(double.PositiveInfinity));
        }
    }
}
