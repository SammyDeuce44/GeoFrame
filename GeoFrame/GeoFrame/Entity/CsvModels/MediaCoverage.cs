using GeoFrame.Entity.Models;

namespace GeoFrame.Entity.CsvModels
{
   public class MediaCoverage : CsvBase
   {
      public MediaCoverage() { }

      public MediaCoverage(string id, string name, string presenter)
      {
         Id = id;
         Name = name;
         PresenterName = presenter;

      }

      public string Id { get; set; }
      public string Name { get; set; }
      public string PresenterName { get; set; }

      public override string ToString()
      {
         return string.Format("{0} {1} {2}", Id, Name, PresenterName);
      }
   }
}