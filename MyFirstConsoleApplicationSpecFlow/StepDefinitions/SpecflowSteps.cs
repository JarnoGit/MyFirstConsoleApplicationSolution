using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstConsoleApplication.Animal;
using MyFirstConsoleApplication.Utils;
using MyFirstConsoleApplicationSpecFlow.Actions;
using System;
using System.Dynamic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MyFirstConsoleApplicationSpecFlow.StepDefinitions
{
    [Binding]
    public class SpecflowSteps
    {
        
        [Given(@"I have (.*) pets")]
        public void GivenIHavePets(int animalCount)
        {
            Animal.Count = animalCount;
        }
        
        [When(@"I buy a dog")]
        public void WhenIBuyACat()
        {
            var dog = new Dog("Doggie", 1, 0.5f, DogBreed.Bulldog);
        }
        
        [When(@"I buy a cat")]
        public void WhenIBuyADog()
        {
            var cat = new Cat("Spinner", 5, 1.0f, CatBreed.Shorthair);
        }

        [When(@"I buy (.*) cat and (.*) dog")]
        public void WhenIBuyCatAndDog(int numberofCatsToBuy, int numberOfDogsToBuy)
        {
            for (int cats = 0; cats < numberofCatsToBuy; cats++)
            {
                var cat = new Cat("Spinner", 5, 1.0f, CatBreed.Shorthair);
            }
            for (int dogs = 0; dogs < numberOfDogsToBuy; dogs++)
            {
                var dog = new Dog("Doggie", 1, 0.5f, DogBreed.Bulldog);
            }
        }

        [Then(@"the number of pets I have is (.*)")]
        public void ThenTheNumberOfPetsIHaveIs(int numberOfPets)
        {
            Assert.AreEqual(numberOfPets, Animal.Count);
        }

        [When(@"I buy the following pet")]
        public void WhenIBuyTheFollowingPet(Table catTable)
        {
            dynamic dynamicCatInstance = catTable.CreateDynamicInstance();
            var pet = TestActions.AddCat(dynamicCatInstance);
            ScenarioContext.Current.Add("pet", pet);
        }

        [When(@"I buy the following dog")]
        public void WhenIBuyTheFollowingDog(Table dogTable)
        {
            var dynamicDogInstance = dogTable.CreateDynamicInstance();
            var dog = TestActions.AddDog(dynamicDogInstance);
            ScenarioContext.Current.Add("dog", dog);
      }

      [When(@"I buy '(.*)', a '(.*)' cat with an age of (.*) and happiness (.*)")]
      public void WhenIBuyACatWithAnAgeOfAndHappiness(string name, string breed, int age, float happiness)
      {
         try
         {
            CatBreed catBreed = (CatBreed)Enum.Parse(typeof(CatBreed), breed);
            var cat = new Cat(name, age, happiness, catBreed);
         }
         catch (Exception)
         {

            throw new Exception("Catbreed not found. Catbreeds can be: " + EnumUtil.GetAllValuesAsString<CatBreed>());
         }

      }


      [Then(@"I should have the following pet")]
      public void ThenIShouldHaveTheFollowingCat(string multilinePetText)
      { 

        var pet = ScenarioContext.Current["pet"] as Animal;
         Assert.AreEqual(multilinePetText, pet.GetMultiLinePetInfo());
      }

   }
}
