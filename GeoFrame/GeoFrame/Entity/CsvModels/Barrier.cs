using System;
using GeoFrame.Entity.Models;

namespace GeoFrame.Entity.CsvModels
{
    public class Barrier : CsvBase
    {
        public Barrier() { }
        public Barrier(string id, string name, string rangeId, int defence)
        {
            Id = id;
            Name = name;
            RangeId = rangeId;
            Defence = Convert.ToInt32(defence);
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string RangeId { get; set; }
        public int Defence { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Id, Name, RangeId, Defence);
        }
    }
}
