using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolHonorV2HonorConfig
    {
        [JsonProperty("DayOneModalEnabled")]
        public bool DayOneModalEnabled { get; set; }
        [JsonProperty("Enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("Honor2018Enabled")]
        public bool Honor2018Enabled { get; set; }
        [JsonProperty("SecondsToVote")]
        public int SecondsToVote { get; set; }
    }
}
