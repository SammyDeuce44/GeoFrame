using System;
using GeoFrame.Entity.Models;

namespace GeoFrame.Entity.CsvModels
{
    public class Aidulon : CsvBase
    {
        public Aidulon() { }
        public Aidulon(string id, string name, string element, string origins, int overall, string description)
        {
            Id = id;
            Name = name;
            Element = element;
            Origins = origins;
            Overall = Convert.ToInt32(overall);
            Description = description;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Element { get; set; }
        public string Origins { get; set; }
        public int Overall { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}", Id, Name, Element, Origins, Overall, Description);
        }
    }
}
