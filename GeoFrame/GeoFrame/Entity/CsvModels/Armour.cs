using System;
using GeoFrame.Entity.Models;

namespace GeoFrame.Entity.CsvModels
{
    public class Armour : CsvBase
    {
        public Armour() { }
        public Armour(string id, string name, string weightId, int defence)
        {
            Id = id;
            Name = name;
            WeightId = weightId;
            Defence = Convert.ToInt32(defence);
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string WeightId { get; set; }
        public int Defence { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Id, Name, WeightId, Defence);
        }
    }
}
