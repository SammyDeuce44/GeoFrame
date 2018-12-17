using GeoFrame.Entity.Models;

namespace GeoFrame.Entity.CsvModels
{
    public class ProfileMap : CsvBase
    {
        public ProfileMap() { }
        public ProfileMap(string id, string statLinkId, string moveSetId)
        {
            Id = id;
            StatLinkId = statLinkId;
            MoveSetId = moveSetId;
        }

        public string Id { get; set; }
        public string MoveSetId { get; set; }
        public string StatLinkId { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Id, StatLinkId, MoveSetId);
        }
    }
}
