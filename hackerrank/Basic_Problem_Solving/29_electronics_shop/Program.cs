using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _29_electronics_shop
{
  class Program
  {
    /*
     * Complete the getMoneySpent function below.
     */
    static int getMoneySpent(int[] keyboards, int[] drives, int b)
    {
      /*
       * Write your code here.
       */
      List<int> buf = new List<int>();
      foreach (int i in keyboards)
      {
        foreach (int j in drives)
        {
          int sum = i + j;
          if (sum <= b)
            buf.Add(sum);
        }
      }
      if (buf.Count == 0)
        return -1;
      else
        return buf.Max();
    }

    static void Main(string[] args)
    {
      string[] bnm = Console.ReadLine().Split(' ');
      int b = Convert.ToInt32(bnm[0]);
      int n = Convert.ToInt32(bnm[1]);
      int m = Convert.ToInt32(bnm[2]);
      int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp));
      int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp));
      /*
       * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
       */
      int moneySpent = getMoneySpent(keyboards, drives, b);
      Console.WriteLine(moneySpent);
    }
  }
}
