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

namespace _07_min_max_sum
{
  class Program
  {
    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr)
    {
      IEnumerable<long> sorted = Array.ConvertAll(arr, x => Convert.ToInt64(x)).OrderBy(x=>x) ;
      long min = sorted.ElementAt(0) + sorted.ElementAt(1) + sorted.ElementAt(2) + sorted.ElementAt(3);
      long max = sorted.ElementAt(1) + sorted.ElementAt(2) + sorted.ElementAt(3) + sorted.ElementAt(4);
      Console.WriteLine(string.Format("{0} {1}", min, max));
    }

    static void Main(string[] args)
    {
      int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
      miniMaxSum(arr);
    }
  }
}
