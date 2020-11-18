using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace _1_simple_array_sum
{
  class Program
  {

    /*
     * Complete the simpleArraySum function below.
     */
    static int simpleArraySum(int[] ar)
    {
      /*
       * Write your code here.
       */
      return ar.Sum();
    }

    static void Main(string[] args)
    {
      int arCount = Convert.ToInt32(Console.ReadLine());
      int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
      int result = simpleArraySum(ar);
      Console.WriteLine(result);
      Console.ReadLine();
    }

  }
}
