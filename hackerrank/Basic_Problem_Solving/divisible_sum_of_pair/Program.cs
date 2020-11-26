using System;

namespace _16_divisible_sum_of_pair
{
  class Program
  {

    // Complete the divisibleSumPairs function below.
    static int divisibleSumPairs(int n, int k, int[] ar)
    {
      int result = 0;
      for (int i = 0; i < ar.Length - 1; i++) 
      {
        for (int j = i + 1; j < ar.Length; j++) 
        {
          if ((ar[i] + ar[j]) % k == 0) 
          {
            result++;
          }
        }
      }
      return result;
    }

    static void Main(string[] args)
    {
      string[] nk = Console.ReadLine().Split(' ');
      int n = Convert.ToInt32(nk[0]);
      int k = Convert.ToInt32(nk[1]);
      int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
      int result = divisibleSumPairs(n, k, ar);
      Console.WriteLine(result);
    }
  }
}
