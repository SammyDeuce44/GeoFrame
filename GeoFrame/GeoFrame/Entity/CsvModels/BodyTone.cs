using System;
using GeoFrame.Entity.Models;

namespace GeoFrame.Entity.CsvModels
{
    public class BodyTone : CsvBase
    {
        public BodyTone() { }
        public BodyTone(string id, string name, string weight, int atk,
            int def, int acc, int sta, int eva, int spd, int tech)
        {
            Id = id;
            Tone = name;
            Weight = weight;
            Attack = Convert.ToInt32(atk);
            Defence = Convert.ToInt32(def);
            Accuracy = Convert.ToInt32(acc);
            Stamina = Convert.ToInt32(sta);
            Evade = Convert.ToInt32(eva);
            Speed = Convert.ToInt32(spd);
            Technique = Convert.ToInt32(tech);
        }

        public string Id { get; set; }
        public string Tone { get; set; }
        public string Weight { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Accuracy { get; set; }
        public int Stamina { get; set; }
        public int Evade { get; set; }
        public int Speed { get; set; }
        public int Technique { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}",
                    Id, Tone, Weight, Attack, Defence, Accuracy,
                    Stamina, Evade, Speed, Technique);
        }
    }
}