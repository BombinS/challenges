using System.Collections.Generic;
using System.Linq;
using System;

namespace _4_diagonal_difference
{

  class Result
  {
    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
      int lenght = arr.Count;
      int i;
      int d1 = 0;
      int d2 = 0;
      for (i = 0; i < lenght; i++)
      {
        d1 += arr[i][i];
        d2 += arr[i][lenght - 1 - i];
      }
      return Math.Abs(d1-d2);
    }  
  }


  class Program
  {

    static void Main(string[] args)
    {
      int n = Convert.ToInt32(Console.ReadLine().Trim());
      List<List<int>> arr = new List<List<int>>();

      for (int i = 0; i < n; i++)
      {
        arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
      }
      int result = Result.diagonalDifference(arr);
      Console.WriteLine(result);
    }
  }
}
