using System.Collections.Generic;
using System.IO;

namespace GeoFrame.Entity.Models
{
   public class CsvStringReader : IReader
   {
      public IEnumerable<T> Read<T>(string filePath, bool noHeadersPresent = false) where T : CsvBase, new()
      {
         var objects = new List<T>();
         using (var sr = new StreamReader(RelativePath(filePath)))
         {
            string line;
            do
            {
               line = sr.ReadLine();
               if (line != null && !noHeadersPresent)
               {
                  var obj = new T();
                  var propertyValues = line.Split(',');
                  obj.AssignValuesFromCsv(propertyValues);
                  objects.Add(obj);
               }
               if (noHeadersPresent)
               {
                  noHeadersPresent = false;
               }
            } while (line != null);
         }
         return objects;
      }

      private string RelativePath(string filename)
      {
         return "./Entity/CSV/" + filename + ".csv";
      }
   }
}