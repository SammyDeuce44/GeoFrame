using GeoFrame.Entity.Models;

namespace GeoFrame.Entity.CsvModels
{
    public class WeaponGroup : CsvBase
    {
        public WeaponGroup()
        {
        }

        public WeaponGroup(string id, string groupName)
        {
            Id = id;
            GroupName = groupName;
        }

        public string Id { get; set; }
        public string GroupName { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Id, GroupName);
        }
    }
}
