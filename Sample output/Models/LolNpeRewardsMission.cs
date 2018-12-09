using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeRewardsMission
    {
        [JsonProperty("completedDate")]
        public long CompletedDate { get; set; }
        [JsonProperty("internalName")]
        public string InternalName { get; set; }
        [JsonProperty("seriesName")]
        public string SeriesName { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
