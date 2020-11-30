using System;

namespace _23_find_digits
{
  class Program
  {
    // Complete the findDigits function below.
    static int findDigits(int n)
    {
      string nAsString = n.ToString();
      char[] digits = nAsString.ToCharArray();

      int result = 0;
      foreach (char item in digits)
      {
        char[] dummy = { item }; 
        string s = new string(dummy);
        int digit = int.Parse(s);
        if (digit != 0)
        {
          if (n % digit == 0)
            result++;
        }
      }
      return result;
    }


    static void Main(string[] args)
    {
      int t = Convert.ToInt32(Console.ReadLine());
      for (int tItr = 0; tItr < t; tItr++)
      {
        int n = Convert.ToInt32(Console.ReadLine());
        int result = findDigits(n);
        Console.WriteLine(result);
      }
    }
  }
}
