using System;

namespace MyFirstConsoleApplication.Animal
{
   public enum CatBreed { Siamese, Shorthair, Pers }

   public class Cat : Animal
   {
      private float cuteness;

      public Cat(string _name, int _age, float _happiness, CatBreed _catBreed)
      {
         name = _name;
         age = _age;
         happiness = _happiness;
         breed = _catBreed.ToString();
      }


      public void Meow()
      {
         Console.WriteLine("MEOW");
      }
   }
}
