using GeoFrame.Entity.Models;

namespace GeoFrame.Entity.CsvModels
{
    public class Team : CsvBase
    {
        public Team() { }

        public Team(string id, string name, string leader, string achetypeId, string description)
        {
            Id = id;
            Name = name;
            Leader = leader;
            AchetypeId = achetypeId;
            Description = description;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Leader { get; set; }
        public string AchetypeId { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", Id, Name, Leader, AchetypeId, Description);
        }
    }
}
