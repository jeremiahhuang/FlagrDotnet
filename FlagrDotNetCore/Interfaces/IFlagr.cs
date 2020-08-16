using FlagrDotNetCore.RequestModels;
using FlagrDotNetCore.ResponseModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlagrDotNetCore.Interfaces
{
    public interface IFlagr
    {
        List<GetFlagsResponse> GetFlagsByTag(string tag);
        Task<bool> CheckIfFeatureIsOnById(string id);
        Task<EvaluationResponse<T>> EvaluateFlag<T>(Evaluation evaluation) where T : Evaluation, new();
    }
}
