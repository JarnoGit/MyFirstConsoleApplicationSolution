using MyFirstConsoleApplication.Animal;
using System;

namespace MyFirstConsoleApplicationSpecFlow.Actions
{
    public class TestActions
    {

        public static Cat AddCat(dynamic dynamicCatInstance)
        {
            string catName = dynamicCatInstance.name;
            int catAge = dynamicCatInstance.age;
            float catHappiness = (float)dynamicCatInstance.happiness;
            CatBreed catBreed = (CatBreed)Enum.Parse(typeof(CatBreed), dynamicCatInstance.breed);

            Cat cat = new Cat(catName, catAge, catHappiness, catBreed);
            return cat;

        }

      public static Dog AddDog(dynamic dynamicDogInstance)
      {
         string dogName = dynamicDogInstance.name;
         int dogAge = dynamicDogInstance.age;
         float dogHappiness = (float)dynamicDogInstance.happiness;
         DogBreed dogBreed = (DogBreed)Enum.Parse(typeof(DogBreed), dynamicDogInstance.breed);

         Dog dog = new Dog(dogName, dogAge, dogHappiness, dogBreed);
         return dog;
      }
   }
}
