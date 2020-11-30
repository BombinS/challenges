using System;

namespace _31_beautiful_days
{
  class Program
  {
    // Complete the beautifulDays function below.
    static int beautifulDays(int i, int j, int k)
    {
      int res = 0;
      for (int z = i; z <= j; z++)
      {
        int n = z;
        int zz = 0;
        while (n != 0)
        {
          zz = zz * 10 + n % 10;
          n /= 10;
        }
        if ((z - zz) % k == 0)
          res++;
      }
      return res;
    }

    static void Main(string[] args)
    {
      string[] ijk = Console.ReadLine().Split(' ');
      int i = Convert.ToInt32(ijk[0]);
      int j = Convert.ToInt32(ijk[1]);
      int k = Convert.ToInt32(ijk[2]);
      int result = beautifulDays(i, j, k);
      Console.WriteLine(result);
    }
  }
}
