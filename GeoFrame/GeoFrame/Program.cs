using GeoFrame.Builder;
using GeoFrame.Models;

namespace GeoFrame
{
   class Program
   {
      static void Main(string[] args)
      {
         var csvContext = new CsvContext();
         var csvBuilder = new CsvBuilder(csvContext);
         csvBuilder.Build();
         var storedData = csvContext.Data;
      }
   }
}