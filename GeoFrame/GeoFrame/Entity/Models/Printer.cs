using System;
using System.Collections.Generic;

namespace GeoFrame.Entity.Models
{
   public class Printer
   {
      public static void Print<T>(string header, IEnumerable<T> output)
      {
         Console.WriteLine("=== Topic: {0} ===", header);
         foreach (var el in output)
            Console.WriteLine(el);
         Console.WriteLine();
      }
   }
}