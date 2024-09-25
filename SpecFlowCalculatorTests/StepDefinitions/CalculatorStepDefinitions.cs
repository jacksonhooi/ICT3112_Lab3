using NUnit.Framework;
namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorStepDefinitions
    {

        private readonly CalculatorContext _calculatorContext;

        // Injecting the CalculatorContext via constructor
        public UsingCalculatorStepDefinitions(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _calculatorContext.Calculator = new Calculator();
        }
        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _calculatorContext.Result = _calculatorContext.Calculator.Add(p0, p1);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_calculatorContext.Result, Is.EqualTo(p0));
        }
    }
}