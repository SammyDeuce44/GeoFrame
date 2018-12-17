using System;
using GeoFrame.Entity.Models;

namespace GeoFrame.Entity.CsvModels
{
    public class Race : CsvBase
    {
        public Race() { }
        public Race(string id, string name, string description, int hp, int mp, int sta, int bon)
        {
            Id = id;
            Name = name;
            Description = description;
            Hp = Convert.ToInt32(hp);
            Mp = Convert.ToInt32(mp);
            Starx = Convert.ToInt32(sta);
            Bonus = Convert.ToInt32(bon);
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }
        public int Starx { get; set; }
        public int Bonus { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6}",
                    Id, Name, Description, Hp, Mp, Starx, Bonus);
        }
    }
}