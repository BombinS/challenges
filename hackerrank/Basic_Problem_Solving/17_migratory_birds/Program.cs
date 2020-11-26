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

namespace _17_migratory_birds
{
  class Program
  {
    
    // Complete the migratoryBirds function below.
    static int migratoryBirds(List<int> arr)
    {
      Dictionary<int, int> buf = new Dictionary<int, int>();
      foreach (int item in arr)
      {
        if (buf.ContainsKey(item) == false)
          buf.Add(item, 0);
        buf[item]++;
      }
      
      int maxCount = buf.Values.Max();

      IEnumerable<KeyValuePair<int, int>> query = buf.Where(x => x.Value == maxCount);
      int min = 0;
      if (query.Count() != 0) 
      {
        min = query.ElementAt(0).Key;
        for (int i = 1; i < query.Count(); i++) 
        {
          if (min > query.ElementAt(i).Key)
            min = query.ElementAt(i).Key;
        }
      }
      return min;
    }


    static void Main(string[] args)
    {
      int arrCount = Convert.ToInt32(Console.ReadLine().Trim());
      List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
      int result = migratoryBirds(arr);
      Console.WriteLine(result);
    }
  }
}
