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

namespace _11_grading_students
{
  class Result
  {

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    

    public static List<int> gradingStudents(List<int> grades)
    {
      IEnumerable<int> r = grades.Select(x => 
      {
        if (x < 38 == false)
        {
          if (x % 5 != 0)
          {
            int tmp = x;
            while (tmp % 5 != 0)
              tmp++;
            if (tmp - x < 3)
              return tmp;
          }
        }
        return x;
      });
      return r.ToList();
    }
  }


  class Program
  {
    static void Main(string[] args)
    {

      int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());
      List<int> grades = new List<int>();
      for (int i = 0; i < gradesCount; i++)
      {
        int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
        grades.Add(gradesItem);
      }
      List<int> result = Result.gradingStudents(grades);
      Console.WriteLine(String.Join("\n", result));
    }
  }
}
