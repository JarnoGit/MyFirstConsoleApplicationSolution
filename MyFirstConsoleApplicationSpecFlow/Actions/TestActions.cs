using MyFirstConsoleApplication.Animal;
using System;

namespace MyFirstConsoleApplicationSpecFlow.Actions
{
    public class TestActions
    {

        public static void AddCat(dynamic dynamicCatInstance)
        {
            string catName = dynamicCatInstance.name;
            int catAge = dynamicCatInstance.age;
            float catHappiness = (float)dynamicCatInstance.happiness;
            CatBreed catBreed = (CatBreed)Enum.Parse(typeof(CatBreed), dynamicCatInstance.breed);

            Cat cat = new Cat(catName, catAge, catHappiness, catBreed);

        }
    }
}
