using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication.Grid
{
   public class Grids
   {

      public static void AnotherGrid()
      {
         int width = 10;
         int height = 10;

         // Why does this code not work?
         //int[][] grid = new int[width][height];

      }

      public static void CreateGrid()
      {
         int width = 5;
         int height = 5;

         int[,] grid = new int[width, height];
         grid[0, 0] = 1;
         grid[1, 1] = 1;
         grid[2, 2] = 1;
         grid[3, 3] = 1;
         grid[4, 4] = 1;

         for (int x = 0; x < width; x++)
         {
            for (int y = 0; y < height; y++)
            {
               Console.Write(grid[x, y] + " ");
            }
            Console.WriteLine();
         }
      }

   }
}
