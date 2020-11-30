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

namespace _27_hurdle_race
{
  class Program
  {
    // Complete the hurdleRace function below.
    static int hurdleRace(int k, int[] height)
    {
      int res = height.Max() - k;
      if (res < 0)
        return 0;
      return res;
    }

    static void Main(string[] args)
    {
      string[] nk = Console.ReadLine().Split(' ');
      int n = Convert.ToInt32(nk[0]);
      int k = Convert.ToInt32(nk[1]);
      int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp));
      int result = hurdleRace(k, height);
      Console.WriteLine(result);
    }
  }
}
