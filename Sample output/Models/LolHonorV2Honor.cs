//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
