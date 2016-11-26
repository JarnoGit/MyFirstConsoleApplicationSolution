 using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstConsoleApplication.Animal;
using MyFirstConsoleApplicationIT.Actions;
using TechTalk.SpecFlow;

namespace MyFirstConsoleApplicationIT.StepDefinitions
{
    [Binding]
    public class TestSteps
    {
        TestActions actions = new TestActions();

        [Given(@"I have (.*) pets")]
        public void GivenIHavePets(int setNumberOfAnimals)
        {
            actions.SetAnimalCount(setNumberOfAnimals);
        }

        [When(@"I buy a (cat|dog)")]
        public void WhenIBuyACat()
        {
           // ScenarioContext.Current.Pending();
        }

        [Then(@"the number of pets I have is (.*)")]
        public void ThenTheNumberOfPetsIHaveIs(int numberOfPets)
        {
            Assert.AreEqual(numberOfPets, Animal.Count);
        }
    }
}
