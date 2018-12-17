using System;
using GeoFrame.Entity.Models;

namespace GeoFrame.Entity.CsvModels
{
    public class Accessory : CsvBase
    {
        public Accessory()
        {
        }

        public Accessory(string id, string type, string name, string attributeId, int amount)
        {
            Id = id;
            Type = type;
            Name = name;
            AttributeId = attributeId;
            Amount = Convert.ToInt32(amount);
        }

        public string Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string AttributeId { get; set; }
        public int Amount { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", Id, Type, Name, AttributeId, Amount);
        }
    }
}
