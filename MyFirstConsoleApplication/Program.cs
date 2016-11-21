using MyFirstConsoleApplication.Animal;
using System;

namespace MyFirstConsoleApplication
{
   class Program
   {
      static void Main(string[] args)
      {

         DateTime curTime = DateTime.Now;
         Console.WriteLine(curTime);
         
         // Grids         
         //Grids.CreateGrid();
         //Grids.AnotherGrid();

         // Classes and inherritance
         Console.WriteLine("This is my doggie");
         Dog doggie = new Dog("Doggy", 4, 0.4f, DogBreed.Boxer);
         doggie.Print();
         doggie.Bark();
         Console.WriteLine("Happyness is now: " + doggie.happiness);
         Console.WriteLine();
         Console.WriteLine("This is my cat");
         Cat kitty = new Cat("Kitty", 8, 0.2f, CatBreed.Siamese);
         kitty.Print();

         Console.ReadKey();
      }
   }
}
