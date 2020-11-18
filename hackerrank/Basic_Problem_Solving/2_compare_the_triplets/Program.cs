using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_compare_the_triplets
{
  class Program
  { 
    // Complete the compareTriplets function below.
    static List<int> compareTriplets(List<int> a, List<int> b)
    {
      List<int> result = new List<int>();
      if (a.Count != 3 || b.Count != 3)
        return result;
      
      int aResult = 0;
      int bResult = 0;

      for (int i = 0; i < 3; i++) 
      {
        if (a[i] > b[i])
          aResult++;
        else if (a[i] < b[i])
          bResult++;
      }

      result.Add(aResult);
      result.Add(bResult);
      return result;
    }



    static void Main(string[] args)
    {
      List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
      List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();
      List<int> result = compareTriplets(a, b);
      Console.WriteLine(String.Join(" ", result));
      Console.ReadLine();
    }
  }
}
