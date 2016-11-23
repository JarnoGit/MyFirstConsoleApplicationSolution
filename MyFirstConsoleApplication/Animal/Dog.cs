using System;

namespace MyFirstConsoleApplication.Animal
{
   public enum DogBreed { Bulldog, Boxer, Briard }
   
   public class Dog : Animal
   {
      private int spotCount;
   
      public Dog (string _name, int _age, float _happiness, DogBreed _dogBreed)
      {
         name = _name;
         age = _age;
         happiness = _happiness;
         breed = _dogBreed.ToString();
      }


      public void Bark()
      {
         Console.WriteLine("WUF");
         base.happiness += 0.1f;

      }
   }
}
