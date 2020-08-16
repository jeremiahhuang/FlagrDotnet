using FlagrDotNetCore.RequestModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlagrDotNetCore.ResponseModels
{
    public class EvaluationResponse<T> where T : Evaluation, new()
    {
        public int FlagID { get; set; }
        public string FlagKey { get; set; }
        public int FlagSnapshotID { get; set; }
        public int SegmentID { get; set; }
        public int VariantID { get; set; }
        public string VariantKey { get; set; }
        public Evalcontext<T> EvalContext { get; set; }
        public string Timestamp { get; set; }
        public Evaldebuglog EvalDebugLog { get; set; }
    }

  

    public class Evalcontext<T>
    {
        public string EntityID { get; set; }
        public string EntityType { get; set; }
        public T EntityContext { get; set; }
        public bool EnableDebug { get; set; }
        public int FlagID { get; set; }
        public string FlagKey { get; set; }
        public object[] FlagTags { get; set; }
    }


    public class Evaldebuglog
    {
        public Segmentdebuglog[] SegmentDebugLogs { get; set; }
        public string Msg { get; set; }
    }

    public class Segmentdebuglog
    {
        public int SegmentID { get; set; }
        public string Msg { get; set; }
    }

}
