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

namespace _32_angry_professor
{
  class Program
  {
    // Complete the angryProfessor function below.
    static string angryProfessor(int k, int[] a)
    {
      int count = 0;
      foreach (int item in a)
      {
        if (item <= 0)
          count++;
      }
      if (count < k)
        return "YES";
      else
        return "NO";
    }

    static void Main(string[] args)
    {
      int t = Convert.ToInt32(Console.ReadLine());
      for (int tItr = 0; tItr < t; tItr++)
      {
        string[] nk = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(nk[0]);
        int k = Convert.ToInt32(nk[1]);
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        string result = angryProfessor(k, a);
        Console.WriteLine(result);
      }
    }
  }
}
