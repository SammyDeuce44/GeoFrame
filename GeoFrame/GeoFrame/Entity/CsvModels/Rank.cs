using System;
using GeoFrame.Entity.Models;

namespace GeoFrame.Entity.CsvModels
{
    public class Rank : CsvBase
    {
        public Rank() { }
        public Rank(string id, string name, string description, int composure, int min, int max)
        {
            Id = id;
            Name = name;
            Description = description;
            Composure = Convert.ToInt32(composure);
            Min = Convert.ToInt32(min);
            Max = Convert.ToInt32(max);
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Composure { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}", Id, Name, Description, Composure, Min, Max);
        }
    }
}
