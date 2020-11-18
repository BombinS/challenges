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

namespace _06_staircase
{
  class Program
  {

    // Complete the staircase function below.
    static void staircase(int n)
    {
      for (int i = 0; i < n; i++) 
      {
        for (int j = 0; j < n - i - 1; j++) 
        {
          Console.Write(" ");
        }
        for (int z = 0; z < i + 1; z++)
        {
          Console.Write("#");
        }
        Console.WriteLine();
      }
    }

    static void Main(string[] args)
    {
      int n = Convert.ToInt32(Console.ReadLine());
      staircase(n);
    }
  }
}
