using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
