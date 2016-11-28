using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstConsoleApplication.Animal;

namespace MyFirstConsoleApplicationTest.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void AddDog()
        {
            var doggie = new Dog("Doggy", 4, 0.4f, DogBreed.Boxer);
            Assert.AreEqual("Doggy", doggie.name);
        }

        [TestMethod]
        public void DogHappyness()
        {
            var doggie = new Dog("Doggy", 4, 0.4f, DogBreed.Boxer);
            doggie.Bark();
            Assert.AreEqual(0.5f, doggie.happiness);
        }

        [TestMethod]
        public void NumberOfPets()
        {
            Animal.Count = 0;
            var doggie = new Dog("Doggy", 4, 0.4f, DogBreed.Boxer);
            var spotty = new Dog("Spotty", 2, 0.1f, DogBreed.Briard);
            Assert.AreEqual(2, Animal.Count);
        }

    }
}
