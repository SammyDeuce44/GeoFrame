using System.Collections.Generic;

namespace GeoFrame.Entity.Models
{
   public interface IReader
   {
      IEnumerable<T> Read<T>(string filePath, bool noHeadersPresent = false) where T : CsvBase, new();
   }
}