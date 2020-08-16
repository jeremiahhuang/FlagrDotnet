using FlagrDotNetCore.ResponseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlagrDotNetCore.RequestModels
{
    public class Evaluation
    {
        public string entityID { get; set; }
        public string entityType { get; set; }
        
        public bool enableDebug { get; set; }
        public int flagID { get; set; }
        public string flagKey { get; set; }
        public string[] flagTags { get; set; }
        
    }
   

}
