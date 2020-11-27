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

namespace _19_sales_by_match
{
  class Program
  {

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {
      Dictionary<int, int> buf = new Dictionary<int, int>();
      foreach (int item in ar)
      {
        if (buf.ContainsKey(item) == false)
          buf.Add(item, 0);
        buf[item]++;
      }
      
      int res = 0;
      foreach (KeyValuePair<int,int> item in buf)
      {
        res += item.Value / 2;
      }

      return res;    
    }

    static void Main(string[] args)
    {
      int n = Convert.ToInt32(Console.ReadLine());
      int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
      int result = sockMerchant(n, ar);
      Console.WriteLine(result);
    }
  }
}
