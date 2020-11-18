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

namespace _05_plus_minus
{
  class Program
  {
    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
      int lenght = arr.Length;
      float positive = (float)arr.Where(x => x > 0).Count()/lenght; 
      float negative = (float)arr.Where(x => x < 0).Count()/lenght;
      float zero = (float)arr.Where(x => x == 0).Count()/lenght;

      Console.WriteLine(positive.ToString("F6", CultureInfo.CurrentCulture));
      Console.WriteLine(negative.ToString("F6", CultureInfo.CurrentCulture));
      Console.WriteLine(zero.ToString("F6", CultureInfo.CurrentCulture));
    }

    static void Main(string[] args)
    {
      int n = Convert.ToInt32(Console.ReadLine());
      int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
      plusMinus(arr);
    }
  }
}
