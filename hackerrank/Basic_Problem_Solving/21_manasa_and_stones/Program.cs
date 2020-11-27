using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace _21_manasa_and_stones
{
  class Program
  {

    // Complete the stones function below.
    static int[] stones(int n, int a, int b)
    {
      List<int> result = new List<int>();
      int firstCount = n - 1;
      int secondCount = (n - 1) - firstCount;
      while (true)
      {
        int temp = 0;
        for (int i = 0; i < firstCount; i++)
        {
          temp += a;
        }
        for (int i = 0; i < secondCount; i++)
        {
          temp+=b;
        }
        result.Add(temp);
        firstCount--;
        secondCount++;
        if (firstCount < 0)
          break;
      }
      return result.Distinct().OrderBy(x => x).ToArray();
    }

    static void Main(string[] args)
    {
      int T = Convert.ToInt32(Console.ReadLine());
      for (int TItr = 0; TItr < T; TItr++)
      {
        int n = Convert.ToInt32(Console.ReadLine());
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int[] result = stones(n, a, b);
        Console.WriteLine(string.Join(" ", result));
      }
    }
  }
}
