using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilityStepDefinitions
    {
        private readonly CalculatorContext _calculatorContext;

        public UsingCalculatorBasicReliabilityStepDefinitions(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }

        // Step for calculating failure intensity λ(τ)
        [When(@"I have entered (.*) as initial failure intensity, (.*) as total expected failures, and (.*) total number of failures over infinite time")]
        public void WhenIHaveEnteredValuesForFailureIntensity(double p0, double p1, double p2)
        {
            _calculatorContext.Result = _calculatorContext.Calculator.CalculateFailureIntensity(p0, p1, p2);
        }

        [Then(@"the current failure intensity should be (.*)")]
        public void ThenTheCurrentFailureIntensityShouldBe(double p0)
        {
            Assert.That(_calculatorContext.Result, Is.EqualTo(p0));
        }

        // Step for calculating expected failures μ(τ)
        [When(@"I have entered (.*) as initial failure intensity, (.*) total number of failures over infinite time, and (.*) as time")]
        public void WhenIPressCalculateExpectedFailures(double p0, double p1, double p2)
        {
            _calculatorContext.Result = _calculatorContext.Calculator.CalculateExpectedFailures(p0, p1, p2);
        }

        [Then(@"the expected number of failures should be (.*)")]
        public void ThenTheExpectedNumberOfFailuresShouldBe(double p0)
        {
            Assert.That(_calculatorContext.Result, Is.EqualTo(p0));
        }
    }
}
