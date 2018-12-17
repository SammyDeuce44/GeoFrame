using System;
using GeoFrame.Entity.Models;

namespace GeoFrame.Entity.CsvModels
{
    public class FightStyle : CsvBase
    {
        public FightStyle() { }
        public FightStyle(string id, string name, string description, int atk, int def, int acc, 
            int sta, int eva, int spd, int tech, int wpnAtk, int wpnDef, int shld, 
            int wpnSkl, int eniAtk, int eniDef, int hp, int mp)
        {
            Id = id;
            Name = name;
            Description = description;
            Attack = Convert.ToInt32(atk);
            Defence = Convert.ToInt32(def);
            Accuracy = Convert.ToInt32(acc);
            Stamina = Convert.ToInt32(sta);
            Evade = Convert.ToInt32(eva);
            Speed = Convert.ToInt32(spd);
            Technique = Convert.ToInt32(tech);
            WeaponAttack = Convert.ToInt32(wpnAtk);
            WeaponDefence = Convert.ToInt32(wpnDef);
            ShieldDefence = Convert.ToInt32(shld);
            WeaponSkill = Convert.ToInt32(wpnSkl);
            EnigrainAttack = Convert.ToInt32(eniAtk);
            EnigrainDefence = Convert.ToInt32(eniDef);
            Hp = Convert.ToInt32(hp);
            Mp = Convert.ToInt32(mp);
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Accuracy { get; set; }
        public int Stamina { get; set; }
        public int Evade { get; set; }
        public int Speed { get; set; }
        public int Technique { get; set; }
        public int WeaponAttack { get; set; }
        public int WeaponDefence { get; set; }
        public int ShieldDefence { get; set; }
        public int WeaponSkill { get; set; }
        public int EnigrainAttack { get; set; }
        public int EnigrainDefence { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7} " +
                                 "{8} {9} {10} {11} {12} {13} {14} {15} {16} {17}",
                    Id, Name, Description, Attack, Defence, Accuracy, Stamina, Evade, Speed, Technique,
                    WeaponAttack, WeaponDefence, ShieldDefence, WeaponSkill, EnigrainAttack, 
                    EnigrainDefence, Hp, Mp);
        }
    }
}
