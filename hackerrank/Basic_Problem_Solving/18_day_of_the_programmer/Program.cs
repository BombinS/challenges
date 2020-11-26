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

namespace _18_day_of_the_programmer
{
  class Program
  {
    // Complete the dayOfProgrammer function below.
    static string dayOfProgrammer(int year)
    {
      int value = 28;
      if (year > 1918)
      {
        if (year % 400 == 0 || ((year % 4 == 0) && !(year % 100 == 0)))
          value = 29;

      }
      else if (year == 1918)
      {
        value = 15;
      }
      else 
      {
        if (year % 4 == 0)
          value = 29;
      }

      Dictionary<int, int> buf = new Dictionary<int, int>();
      
      buf.Add(0, 31);
      buf.Add(1, value);
      buf.Add(2, 31);

      buf.Add(3, 30);
      buf.Add(4, 31);
      buf.Add(5, 30);

      buf.Add(6, 31);
      buf.Add(7, 31);
      buf.Add(8, 30);
      
      buf.Add(9, 31);
      buf.Add(10, 30);
      buf.Add(11, 31);

      int sum = 0;
      int month = 0;
      do 
      {
        sum += buf[month];
        month++;
      } while (sum + buf[month] <= 256);

      return string.Format("{0:D2}.{1:D2}.{2}", 256 - sum, ++month, year);
    }

    static void Main(string[] args)
    {
      int year = Convert.ToInt32(Console.ReadLine().Trim());
      string result = dayOfProgrammer(year);
      Console.WriteLine(result);
    }
  }
}
