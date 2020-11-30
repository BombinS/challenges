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

namespace _24_picking_numbers
{

  class Result
  {

    /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int pickingNumbers(List<int> a)
    {
      int res = 1;
      IEnumerable<int> uniqValues = a.Distinct();
      foreach (int item in uniqValues)
      {
        IEnumerable<int> query = a.Where(x => item - x == 1 || item -x == 0);
        if (query.Count() > res)
          res = query.Count();
      }
      return res;
    }

  }
  class Program
  {


    static void Main(string[] args)
    {
      int n = Convert.ToInt32(Console.ReadLine().Trim());
      List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
      int result = Result.pickingNumbers(a);
      Console.WriteLine(result);
    }
  }
}
