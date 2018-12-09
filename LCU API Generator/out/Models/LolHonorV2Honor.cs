using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolHonorV2Honor
    {
        [JsonProperty("honorCategory")]
        public string HonorCategory { get; set; }
        [JsonProperty("voterRelationship")]
        public string VoterRelationship { get; set; }
    }
}
