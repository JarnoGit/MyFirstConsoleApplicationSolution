using System;

namespace MyFirstConsoleApplication.Animal
{
   public class Animal
   {
      private static int count = 0;
      public string name;
      public int age;
      public float happiness;
      public string breed;

      protected Animal ()
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
