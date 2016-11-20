using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication.Animal
{
   class Animal
   {
      public static int count = 0;
      public string name;
      public int age;
      public float happiness;
      public string breed;

      public Animal ()
      {
         count++;
      }

      public void Print()
      {
         Console.WriteLine("Name: " + name);
         Console.WriteLine("Age: " + age);
         Console.WriteLine("Happpiness: " + happiness);
         Console.WriteLine("Breed: " + breed);
         Console.WriteLine("Number of Animals: " + count);
      }
   }
}
