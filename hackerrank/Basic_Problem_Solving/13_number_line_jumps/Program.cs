using System;

namespace _13_number_line_jumps
{
  class Program
  {

    // Complete the kangaroo function below.
    static string kangaroo(int x1, int v1, int x2, int v2)
    {
      int belowPosition, belowSpeed, aheadPosition, aheadSpeed;
      if (x1 < x2)
      {
        belowPosition = x1;
        belowSpeed = v1;
        aheadPosition = x2;
        aheadSpeed = v2;
      }
      else 
      {
        belowPosition = x2;
        belowSpeed = v2;
        aheadPosition = x1;
        aheadSpeed = v1;
      }
      bool isOvertake = false;
      while (isOvertake == false) 
      {
        belowPosition += belowSpeed;
        aheadPosition += aheadSpeed;
        if (belowPosition == aheadPosition) 
        {
          return "YES";
        }
        if (belowPosition > aheadPosition || belowSpeed <= aheadSpeed) 
        {
          break;
        }
      }
      return "NO";
    }

    static void Main(string[] args)
    {
      string[] x1V1X2V2 = Console.ReadLine().Split(' ');
      int x1 = Convert.ToInt32(x1V1X2V2[0]);
      int v1 = Convert.ToInt32(x1V1X2V2[1]);
      int x2 = Convert.ToInt32(x1V1X2V2[2]);
      int v2 = Convert.ToInt32(x1V1X2V2[3]);
      string result = kangaroo(x1, v1, x2, v2);
      Console.WriteLine(result);
    }
  }
}
