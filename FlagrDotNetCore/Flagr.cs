using FlagrDotNetCore.Interfaces;
using FlagrDotNetCore.RequestModels;
using FlagrDotNetCore.ResponseModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FlagrDotNetCore
{

    public class Flagr : IFlagr
    {
        private static HttpClient Client = new HttpClient();
        private string FlagrURL = "http://localhost:18000/api/v1/";
        public Flagr(string flagrURL,HttpClient client)
        {
            FlagrURL = flagrURL;
            Client = client;
        }
        public Flagr(string flagrURL)
        {
            FlagrURL = flagrURL;
        }
        //GET Flags by tag
        public List<GetFlagsResponse> GetFlagsByTag(string tag)
        {
            var response = Client.GetAsync($"{FlagrURL}/flags?tags={tag}").Result;
            List<GetFlagsResponse> flags = new List<GetFlagsResponse>();
            flags = JsonConvert.DeserializeObject<List<GetFlagsResponse>>(response.Content.ReadAsStringAsync().Result);
            return flags;
        }
        public async Task<bool> CheckIfFeatureIsOnById(string id)
        {
            var response = Client.GetAsync($"{FlagrURL}/flags/{id}").Result;
            GetFlagsResponse flags = new GetFlagsResponse();            
            flags = JsonConvert.DeserializeObject<GetFlagsResponse>(await response.Content.ReadAsStringAsync());
            return flags.enabled;
        }
        public async Task<EvaluationResponse<T>> EvaluateFlag<T>(Evaluation evaluation) where T: Evaluation,new()
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(evaluation), System.Text.Encoding.UTF8, "application/json");
            var response = await Client.PostAsync($"{FlagrURL}/evaluation",content);
            var s = response.Content.ReadAsStringAsync().Result;
            var eval = JsonConvert.DeserializeObject<EvaluationResponse<T>>(s);
            return eval;
        }
    }



}
