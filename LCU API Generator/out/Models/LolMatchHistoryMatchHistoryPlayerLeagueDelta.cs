using Newtonsoft.Json;

namespace LCU_API_Generator
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
