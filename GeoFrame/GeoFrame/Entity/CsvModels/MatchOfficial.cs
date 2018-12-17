using System;
using GeoFrame.Entity.Models;

namespace GeoFrame.Entity.CsvModels
{
   public class MatchOfficial : CsvBase
   {
      public MatchOfficial() { }

      public MatchOfficial(string id, string fname, string lname, string gender, string experience, string tolerance)
      {
         ID = id;
         Firstname = fname;
         Lastname = lname;
         Gender = gender;
         Experience = Convert.ToInt32(experience);
         Tolerance = Convert.ToInt32(tolerance);
      }

      public string ID { get; set; }
      public string Firstname { get; set; }
      public string Lastname { get; set; }
      public string Gender { get; set; }
      public int Experience { get; set; }
      public int Tolerance { get; set; }
   }
}