using GeoFrame.Entity.Models;

namespace GeoFrame.Entity.CsvModels
{
    public class Title : CsvBase
    {
        public Title() { }
        public Title(string id, string name, string segment, string description)
        {
            Id = id;
            Name = name;
            Segment = segment;
            Description = description;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Segment { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Id, Name, Segment, Description);
        }
    }
}
