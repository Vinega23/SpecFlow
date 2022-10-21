using Calc;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        Kalkulacka k = new Kalkulacka();
        int a;
        int b;
        int result;
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            number = a = 50;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
           number = b = 50;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            result = k.Secti(a,b);
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.AreEqual(120, result);
        }
    }
}