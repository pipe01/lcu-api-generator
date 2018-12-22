using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMatchHistoryMatchHistoryPlayerLeagueDelta
    {
        [JsonProperty("leaguePointDelta")]
        public long LeaguePointDelta { get; set; }
        [JsonProperty("miniSeriesProgress")]
        public string[] MiniSeriesProgress { get; set; }
        [JsonProperty("reason")]
        public string Reason { get; set; }
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}
