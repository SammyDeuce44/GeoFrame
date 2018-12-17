using System;
using GeoFrame.Entity.Models;

namespace GeoFrame.Entity.CsvModels
{
   public class Arena : CsvBase
   {
      public Arena() { }
      public Arena(string id, string name, string description, string arenaTypeId, int capacity, string mediaId)
      {
         Id = id;
         Name = name;
         Description = description;
         ArenaTypeId = arenaTypeId;
         Capacity = Convert.ToInt32(capacity);
         MediaId = mediaId;
      }

      public string Id { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
      public string ArenaTypeId { get; set; }
      public int Capacity { get; set; }
      public string MediaId { get; set; }

      public override string ToString()
      {
         return string.Format("{0} {1} {2} {3} {4} {5}", Id, Name, Description, ArenaTypeId, Capacity, MediaId);
      }
   }
}
