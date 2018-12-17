using System.Collections.Generic;

namespace GeoFrame.Models
{
   public class CsvContext
   {
      public Dictionary<CsvKey, object> Data { get; set; }

      public CsvContext()
      {
         Data = new Dictionary<CsvKey, object>();
      }
   }
}