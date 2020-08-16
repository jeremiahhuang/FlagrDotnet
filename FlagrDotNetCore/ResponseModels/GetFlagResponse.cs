using System;
using System.Collections.Generic;
using System.Text;

namespace FlagrDotNetCore.ResponseModels
{
    public class GetFlagsResponse
    {
        public bool dataRecordsEnabled { get; set; }
        public string description { get; set; }
        public bool enabled { get; set; }
        public int id { get; set; }
        public string key { get; set; }
        public List<Segment> segments { get; set; }
        public List<Tag> tags { get; set; }
        public DateTime updatedAt { get; set; }
        public List<Variant> variants { get; set; }

    }

    public class Segment
    {
        public List<Constraint> constraints { get; set; }
        public string description { get; set; }
        public List<Distribution> distributions { get; set; }
        public int id { get; set; }
        public int rank { get; set; }
        public int rolloutPercent { get; set; }
    }

    public class Constraint
    {
        public int id { get; set; }
        public string _operator { get; set; }
        public string property { get; set; }
        public string value { get; set; }
    }

    public class Distribution
    {
        public int id { get; set; }
        public int percent { get; set; }
        public int variantID { get; set; }
        public string variantKey { get; set; }
    }

    public class Tag
    {
        public int id { get; set; }
        public string value { get; set; }
    }
    
    public class Variant
    {        
        public int id { get; set; }
        public string key { get; set; }
    }



}
