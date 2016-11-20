using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication.Animal
{
   enum DogBreed { Bulldog, Boxer, Briard }
   
   class Dog : Animal
   {
      public int spotCount;
   
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
