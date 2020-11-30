using System;

namespace _25_cats_and_mouse
{
  class Program
  {
    // Complete the catAndMouse function below.
    static string catAndMouse(int x, int y, int z)
    {
      int a = Math.Abs(x - z);
      int b = Math.Abs(y - z);
      if (a == b)
        return "Mouse C";
      else if (a < b)
        return "Cat A";
      return "Cat B";

    }

    static void Main(string[] args)
    {
      int q = Convert.ToInt32(Console.ReadLine());
      for (int qItr = 0; qItr < q; qItr++)
      {
        string[] xyz = Console.ReadLine().Split(' ');
        int x = Convert.ToInt32(xyz[0]);
        int y = Convert.ToInt32(xyz[1]);
        int z = Convert.ToInt32(xyz[2]);
        string result = catAndMouse(x, y, z);
        Console.WriteLine(result);
      }
    }
  }
}
