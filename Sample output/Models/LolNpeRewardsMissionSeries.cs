using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeRewardsMissionSeries
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("internalName")]
        public string InternalName { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
