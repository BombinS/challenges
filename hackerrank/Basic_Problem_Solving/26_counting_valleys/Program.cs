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

namespace _26_counting_valleys
{

  class Result
  {

    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {      
      char[] splitted = path.ToCharArray();
      int prevLevel = 0;
      int thisLevel = 0;
      int valleyCount = 0;
      for (int i = 0; i < splitted.Length; i++)
      {
        if (splitted[i] == 'U')
          thisLevel++;
        else
          thisLevel--;

        if (thisLevel == -1 && prevLevel == 0)
          valleyCount++;

        prevLevel = thisLevel;
      }
      return valleyCount;
    }

  }

  class Program
  {

    static void Main(string[] args)
    {
      int steps = Convert.ToInt32(Console.ReadLine().Trim());
      string path = Console.ReadLine();
      int result = Result.countingValleys(steps, path);
      Console.WriteLine(result);
    }
  }
}
