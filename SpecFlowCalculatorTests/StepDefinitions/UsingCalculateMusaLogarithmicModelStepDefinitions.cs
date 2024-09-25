using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculateMusaLogarithmicModelStepDefinitions
    {
        private readonly CalculatorContext _calculatorContext;

        // Injecting the CalculatorContext via constructor
        public UsingCalculateMusaLogarithmicModelStepDefinitions(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }

        [When(@"I have entered (.*) as initial failure intensity, (.*) as failure intensity decay parameter, and (.*) average expected number of failures experience at time")]
        public void WhenIHaveEnteredAsInitialFailureIntensityAsFailureIntensityDecayParameterAndAverageExpectedNumberOfFailuresExperienceAtTime(double p0, double p1, double p2)
        {
            _calculatorContext.Result = _calculatorContext.Calculator.CalculateFailureIntensityUsingMusaLogarithmicModel(p0, p1, p2);
        }

        [Then(@"the current failure intensity result should be (.*)")]
        public void ThenTheCurrentFailureIntensityResultShouldBe(double p0)
        {
            Assert.That(_calculatorContext.Result, Is.EqualTo(p0));
        }

        [When(@"I have entered (.*) as initial failure intensity, (.*) as failure intensity decay parameter, and (.*) as time")]
        public void WhenIHaveEnteredAsInitialFailureIntensityAsFailureIntensityDecayParameterAndAsTime(double p0, double p1, double p2)
        {
            _calculatorContext.Result = _calculatorContext.Calculator.CalculateExpectedFailuresUsingMusaLogarithmicModel(p0, p1, p2);
        }

        [Then(@"the number of expected failures should be (.*)")]
        public void ThenTheNumberOfExpectedFailuresShouldBe(double p0)
        {
            Assert.That(_calculatorContext.Result, Is.EqualTo(p0));
        }
    }
}
