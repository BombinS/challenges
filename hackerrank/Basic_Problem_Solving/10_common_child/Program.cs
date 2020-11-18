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

namespace _10_common_child
{
  class Program
  {
    // Complete the commonChild function below.
    static int commonChild(string s1, string s2)
    {
      List<char> arr1 = new List<char>();
      List<char> arr2 = new List<char>();
      foreach (char c in s1.ToCharArray())
      {
        if (s2.Contains(c) == true)
          arr1.Add(c);
      }
      foreach (char c in s2.ToCharArray())
      {
        if (s1.Contains(c) == true)
          arr2.Add(c);
      }
      List<char> min;
      List<char> max;
      if (arr1.Count < arr2.Count)
      {
        min = arr1;
        max = arr2;
      }
      else 
      {
        min = arr2;
        max = arr1;
      }
      string minString = new string(min.ToArray());
      string maxString = new string(max.ToArray());
      Console.WriteLine(minString);
      Console.WriteLine(maxString);

      bool isFounded = false;
      int maxLength = min.Count;
      for (; maxLength > 0; maxLength--) 
      {
        int index = 0;
        while (maxLength + index <= min.Count) 
        {
          if (maxString.Contains(minString.Substring(index, maxLength))) 
          {
            isFounded = true;
            break;
          }
          index++;
        }
        if (isFounded == true) 
        {
          break;
        }
      }
      return maxLength;
    }

    static void Main(string[] args)
    {
      string s1 = Console.ReadLine();
      string s2 = Console.ReadLine();
      //int result = commonChild(s1, s2);
      int result = commonChild("WEWOUCUIDGCGTRMEZEPXZFEJWISRSBBSYXAYDFEJJDLEBVHHKS", "FDAGCXGKCTKWNECHMRXZWMLRYUCOCZHJRRJBOAJOQJZZVUYXIC");
      Console.WriteLine(result);
    }
  }
}
