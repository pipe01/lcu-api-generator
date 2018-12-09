using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeRewardsReward
    {
        [JsonProperty("data")]
        public object Data { get; set; }
        [JsonProperty("renderer")]
        public string Renderer { get; set; }
    }
}
