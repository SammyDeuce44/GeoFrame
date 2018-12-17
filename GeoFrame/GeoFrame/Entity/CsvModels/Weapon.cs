using System;
using GeoFrame.Entity.Models;

namespace GeoFrame.Entity.CsvModels
{
    public class Weapon : CsvBase
    {
        public Weapon() { }
        public Weapon(string id, string weaponGroup, string name, string level, int hands, string weightId,
            string rangeId, string effect, int durability, string enigmaList, int damage, string description)
        {
            Id = id;
            WeaponGroup = weaponGroup;
            Name = name;
            Level = level;
            Hands = Convert.ToInt32(hands);
            WeightId = weightId;
            RangeId = rangeId;
            Effect = effect;
            Durability = Convert.ToInt32(durability);
            EnigmaList = enigmaList;
            Damage = Convert.ToInt32(damage);
            Description = description;
        }

        public string Id { get; set; }
        public string WeaponGroup { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public int Hands { get; set; }
        public string WeightId { get; set; }
        public string RangeId { get; set; }
        public string Effect { get; set; }
        public int Durability { get; set; }
        public string EnigmaList { get; set; }
        public int Damage { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11}",
                    Id, WeaponGroup, Name, Level, Hands, WeightId, RangeId, Effect, Durability, EnigmaList,
                    Damage, Description);
        }
    }
}