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

namespace _33_circular_array_rotation
{
  class Program
  {
    // Complete the circularArrayRotation function below.
    static int[] circularArrayRotation(int[] a, int k, int[] queries)
    {
      List<int> buf = a.ToList();
      int l = buf.Count - 1;
      for (int i = 0; i < k; i++)
      {
        int temp = buf[l];
        buf.RemoveAt(l);
        buf.Insert(0, temp);
      }

      List<int> res = new List<int>();
      foreach (int item in queries)
      {
        res.Add(buf[item]);
      }

      return res.ToArray();
    }

    static void Main(string[] args)
    {
      string[] nkq = Console.ReadLine().Split(' ');
      int n = Convert.ToInt32(nkq[0]);
      int k = Convert.ToInt32(nkq[1]);
      int q = Convert.ToInt32(nkq[2]);
      int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
      int[] queries = new int[q];
      for (int i = 0; i < q; i++)
      {
        int queriesItem = Convert.ToInt32(Console.ReadLine());
        queries[i] = queriesItem;
      }
      int[] result = circularArrayRotation(a, k, queries);
      Console.WriteLine(string.Join("\n", result));
    }
  }
}
