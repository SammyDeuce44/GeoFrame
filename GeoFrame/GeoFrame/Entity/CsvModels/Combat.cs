using GeoFrame.Entity.Models;

namespace GeoFrame.Entity.CsvModels
{
    public class Combat : CsvBase
    {
        public Combat() { }
        public Combat(string id, string stat)
        {
            Id = id;
            Stat = double.Parse(stat);
        }

        public string Id { get; set; }
        public double Stat { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Id, Stat);
        }
    }
}
