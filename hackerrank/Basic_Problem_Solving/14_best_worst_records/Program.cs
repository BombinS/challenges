using System;

namespace _14_best_worst_records
{
  class Program
  {
    // Complete the breakingRecords function below.
    static int[] breakingRecords(int[] scores)
    {
      int best, worst;
      int bestResult = 0;
      int worstResult = 0;
      best = worst = scores[0];
      for (int i = 1; i < scores.Length; i++) 
      {
        if (scores[i] > best)
        {
          bestResult++;
          best = scores[i];
        }
        else if (scores[i] < worst)
        {
          worstResult++;
          worst = scores[i];
        }
      }
      return new int[] { bestResult, worstResult};
    }

    static void Main(string[] args)
    {
      int n = Convert.ToInt32(Console.ReadLine());
      int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
      int[] result = breakingRecords(scores);
      Console.WriteLine(string.Join(" ", result));
    }
  }
}
