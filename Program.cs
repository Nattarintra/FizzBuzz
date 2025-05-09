using System;

namespace FizzBuzz
{
  class Program
  {
    static void Main(string[] args)
    {

      // Read input and split into three integers
      string[] parts = Console.ReadLine().Split(' ');
      int x = int.Parse(parts[0]);
      int y = int.Parse(parts[1]);
      int n = int.Parse(parts[2]);

      // testing 
      // int x = 3;
      // int y = 5;
      // int n = 10;

      for (int i = 1; i <= n; i++)
      {
        Console.WriteLine(GetFizzBuzzLine(i, x, y));
      }

    }

    // Returns the appropriate output for the given number
    private static string GetFizzBuzzLine(int i, int x, int y)
    {
      if (i % x == 0 && i % y == 0)
        return "FizzBuzz";
      else if (i % x == 0)
        return "Fizz";
      else if (i % y == 0)
        return "Buzz";
      else
        return i.ToString();
    }

  }
}
