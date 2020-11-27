using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _20_drawing_book
{
  class Program
  {

    /*
     * Complete the pageCount function below.
     */
    static int pageCount(int n, int p)
    {
      List<List<int>> book = new List<List<int>>();
      book.Add(new List<int>{0, 1});
      int i = 2;
      while (i <= n) 
      {
        if (i % 2 == 0)
        {
          book.Add(new List<int>());
        }
        book.Last().Add(i);
        i++;
      }

      int toRight = 0;
      for (int j = 0; j < book.Count; j++)
      {
        if (book[j].Contains(p))
          break;
        toRight++;
      }

      int toLeft = 0;
      for (int j = book.Count - 1; j >= 0 ; j--)
      {
        if (book[j].Contains(p))
          break;
        toLeft++;
      }

      return Math.Min(toLeft, toRight);
    }

    static void Main(string[] args)
    {
      int n = Convert.ToInt32(Console.ReadLine());
      int p = Convert.ToInt32(Console.ReadLine());
      int result = pageCount(n, p);
      Console.WriteLine(result);
    }
  }
}
