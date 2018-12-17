using System;
using GeoFrame.Entity.Models;

namespace GeoFrame.Entity.CsvModels
{
    public class Technique : CsvBase
    {
        public Technique() { }
        public Technique(string id, string type, string group, string name, string level,
            int atbCost, string range, string description, string wielder)
        {
            Id = id;
            Type = type;
            Group = group;
            Name = name;
            Level = level;
            AtbCost = Convert.ToInt32(atbCost); ;
            Range = range;
            Description = description;
            Wielder = wielder;
        }

        public string Id { get; set; }
        public string Type { get; set; }
        public string Group { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public int AtbCost { get; set; }
        public string Range { get; set; }
        public string Description { get; set; }
        public string Wielder { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8}",
                Id, Type, Group, Name, Level, AtbCost, Range, Description, Wielder);
        }
    }
}