using System;
using GeoFrame.Entity.Models;

namespace GeoFrame.Entity.CsvModels
{
    public class MoveList : CsvBase
    {
        public MoveList() { }
        public MoveList(string id, string levelId, string name, int weaponGroupId,
            int def, int hands, int actionId, int impactAreaId, int damage, int castTime)
        {
            Id = id;
            LevelId = levelId;
            Name = name;
            WeaponGroupId = weaponGroupId;
            Equip = def;
            Hands = Convert.ToInt32(hands);
            ActionId = actionId;
            ImpactAreaId = impactAreaId;
            Damage = Convert.ToInt32(damage);
            CastTime = Convert.ToInt32(castTime);
        }

        public string Id { get; set; }
        public string LevelId { get; set; }
        public string Name { get; set; }
        public int WeaponGroupId { get; set; }
        public int Equip { get; set; }
        public int Hands { get; set; }
        public int ActionId { get; set; }
        public int ImpactAreaId { get; set; }
        public int Damage { get; set; }
        public int CastTime { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}",
                    Id, LevelId, Name, WeaponGroupId, Equip, Hands,
                    ActionId, ImpactAreaId, Damage, CastTime);
        }
    }
}