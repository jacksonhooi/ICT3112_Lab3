using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculateQualityMetricsStepDefinitions
    {
        private readonly CalculatorContext _calculatorContext;

        // Injecting the CalculatorContext via constructor
        public UsingCalculateQualityMetricsStepDefinitions(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }

        [When(@"I have entered (.*) defects and (.*) source lines of code into the calculator")]
        public void WhenIHaveEnteredDefectsAndSourceLinesOfCodeIntoTheCalculator(double p0, double p1)
        {
            _calculatorContext.Result = _calculatorContext.Calculator.Divide(p0, p1);
        }

        [Then(@"the defect density result should be (.*)")]
        public void ThenTheDefectDensityResultShouldBe(double p0)
        {
            Assert.That(_calculatorContext.Result, Is.EqualTo(p0));
        }

        [When(@"I have entered (.*) SSI for the first release and (.*) SSI for the second release")]
        public void WhenIHaveEnteredSSIForTheFirstReleaseAndSSIForTheSecondRelease(double p0, double p1)
        {
            _calculatorContext.Result = _calculatorContext.Calculator.Add(p0, p1);
        }

        [Then(@"the total SSI result should be (.*)")]
        public void ThenTheTotalSSIResultShouldBe(int p0)
        {
            Assert.That(_calculatorContext.Result, Is.EqualTo(p0));
        }
    }
}
