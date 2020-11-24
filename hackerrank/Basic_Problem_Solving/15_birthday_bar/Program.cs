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

namespace _15_birthday_bar
{
  class Program
  {
    // Complete the birthday function below.
    static int birthday(List<int> s, int d, int m)
    {
      int counter = 0;
      int i = 0;
      while (i + m <= s.Count) 
      {
        int sum = 0;
        for (int j = 0; j < m; j++) 
        {
          sum += s[i + j];
        }
        if (sum == d) 
        {
          counter++;
        }
        i++;
      }
      return counter;
    }

    static void Main(string[] args)
    {
      int n = Convert.ToInt32(Console.ReadLine().Trim());
      List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();
      string[] dm = Console.ReadLine().TrimEnd().Split(' ');
      int d = Convert.ToInt32(dm[0]);
      int m = Convert.ToInt32(dm[1]);
      int result = birthday(s, d, m);
      Console.WriteLine(result);

    }
  }
}
