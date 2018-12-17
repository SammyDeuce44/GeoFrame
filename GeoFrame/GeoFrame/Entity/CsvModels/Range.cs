﻿using GeoFrame.Entity.Models;

namespace GeoFrame.Entity.CsvModels
{
    public class Range : CsvBase
    {
        public Range() { }
        public Range(string id, string description)
        {
            Id = id;
            Description = description;
        }

        public string Id { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Id, Description);
        }
    }
}
