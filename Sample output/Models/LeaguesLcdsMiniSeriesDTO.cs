using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LeaguesLcdsMiniSeriesDTO
    {
        [JsonProperty("losses")]
        public long Losses { get; set; }
        [JsonProperty("progress")]
        public string Progress { get; set; }
        [JsonProperty("target")]
        public long Target { get; set; }
        [JsonProperty("timeLeftToPlayMillis")]
        public long TimeLeftToPlayMillis { get; set; }
        [JsonProperty("wins")]
        public long Wins { get; set; }
    }
}
