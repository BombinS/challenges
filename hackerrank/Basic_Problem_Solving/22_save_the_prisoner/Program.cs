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


namespace _22_save_the_prisoner
{
  class Program
  {
    // Complete the saveThePrisoner function below.
    static int saveThePrisoner(int n, int m, int s)
    {
      int x1 = s + (m - 1);
      if (x1 <= n)
        return x1;
      else 
      {
        int res = x1 % n;
        if (res == 0)
          return n;
        else
          return res;
      }
        
    }

    static void Main(string[] args)
    {
      int t = Convert.ToInt32(Console.ReadLine());

      for (int tItr = 0; tItr < t; tItr++)
      {
        string[] nms = Console.ReadLine().Split(' ');
        
        int n = Convert.ToInt32(nms[0]);
        int m = Convert.ToInt32(nms[1]);
        int s = Convert.ToInt32(nms[2]);
        int result = saveThePrisoner(n, m, s);
        Console.WriteLine(result);
      }

    }
  }
}
