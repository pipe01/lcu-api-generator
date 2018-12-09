using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class EndOfGameLcdsPointsPenalty
    {
        [JsonProperty("penalty")]
        public float Penalty { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
