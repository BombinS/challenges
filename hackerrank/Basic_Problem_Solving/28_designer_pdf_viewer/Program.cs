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

namespace _28_designer_pdf_viewer
{
  class Program
  {

    // Complete the designerPdfViewer function below.
    static int designerPdfViewer(int[] h, string word)
    {
      char[] splitted = word.ToCharArray();
      int max = 0;
      foreach (char item in splitted)
      {
        if (h[item - 'a'] > max)
          max = h[item - 'a'];
      }
      return max * word.Length;
    }

    static void Main(string[] args)
    {
      int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp));
      string word = Console.ReadLine();
      int result = designerPdfViewer(h, word);
      Console.WriteLine(result);
    }
  }
}
