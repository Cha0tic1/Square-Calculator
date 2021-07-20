using System;

namespace Programerings_test
{
    class Program
    {
        static void Main(string[] args)
        { 
          int side1;
          int side2;
          int x;
          int result;
          int result2;

          Console.Write("Please enter a side length(cm): ");
          side1 = Convert.ToInt32(Console.ReadLine());
          Console.Write("\nPlease enter the second side(cm): ");
          side2 = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Please enter a number.\n1 = area\n2 = circumfrence");
          x = Convert.ToInt32(Console.ReadLine());
          switch (x)
          {
              case 1:
              result = side1 * side2;
              Console.WriteLine("The area of the square is " + result + "cm2!");
              break;

              case 2:
              result2 = 2 * side1 + 2 * side2;
              Console.WriteLine("The circumfrence of the square is " + result2 + "cm!");
              break;

              default: 
              Console.WriteLine("Error! You didn't input a number from 1 - 2!");
              break;
          }
          Console.WriteLine("Press any button to close the calculator.");
          Console.ReadKey();

        }
    }
}
