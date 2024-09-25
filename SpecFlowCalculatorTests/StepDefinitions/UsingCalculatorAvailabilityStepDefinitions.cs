using NUnit.Framework;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorAvailabilityStepDefinitions
    {

        private readonly CalculatorContext _calculatorContext;

        public UsingCalculatorAvailabilityStepDefinitions(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(double p0, double p1)
        {
            _calculatorContext.Result = _calculatorContext.Calculator.CalculateMTBF(p0,p1);
        }

        [Then(@"the MTBF result should be (.*)")]
        public void ThenTheMTBFResultShouldBe(double p0)
        {
            Assert.That(_calculatorContext.Result, Is.EqualTo(p0));
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(double p0, double p1)
        {
            _calculatorContext.Result = _calculatorContext.Calculator.CalculateAvailability(p0, p1);
        }
       
        [Then(@"the availability result should be (.*)")]
        public void ThenTheAvailabilityResultShouldBe(double p0)
        {
            Assert.That(_calculatorContext.Result, Is.EqualTo(p0));
        }

    }
}
