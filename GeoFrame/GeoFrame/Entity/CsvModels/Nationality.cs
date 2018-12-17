using GeoFrame.Entity.Models;

namespace GeoFrame.Entity.CsvModels
{
    public class Nationality : CsvBase
    {
        public Nationality()
        {
        }

        public Nationality(string id, string name, string region, string description, string type)
        {
            Id = id;
            Name = name;
            Region = region;
            Description = description;
            Type = type;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", Id, Name, Region, Description, Type);
        }
    }
}
