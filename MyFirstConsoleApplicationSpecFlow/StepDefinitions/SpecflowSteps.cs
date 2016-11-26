using System;
using TechTalk.SpecFlow;

namespace MyFirstConsoleApplicationSpecFlow.StepDefinitions
{
    [Binding]
    public class SpecflowSteps
    {
        [Given(@"I have (.*) pets")]
        public void GivenIHavePets(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I buy a cat")]
        public void WhenIBuyACat()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I buy a dog")]
        public void WhenIBuyADog()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the number of pets I have is (.*)")]
        public void ThenTheNumberOfPetsIHaveIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
