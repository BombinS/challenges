using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _09_time_conversion
{
  class Program
  {
    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s)
    {
      /*
       * Write your code here.
       */
      DateTime dt = DateTime.Parse(s);
      return string.Format("{0:D2}:{1:D2}:{2:D2}", dt.Hour, dt.Minute, dt.Second);
    }

    static void Main(string[] args)
    {
      string s = Console.ReadLine();
      string result = timeConversion(s);
      Console.WriteLine(result);
    }
  }
}
