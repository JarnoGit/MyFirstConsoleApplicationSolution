using System;

namespace MyFirstConsoleApplication.Animal
{
   enum CatBreed { Siamese, Shorthair, Pers }

   class Cat : Animal
   {
      public float cuteness;

      public Cat(string _name, int _age, float _happiness, CatBreed _catBreed)
      {
         name = _name;
         age = _age;
         happiness = _happiness;
         breed = _catBreed.ToString();
      }


      public void meow()
      {
         Console.WriteLine("MEOW");
      }
   }
}
