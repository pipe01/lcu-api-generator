using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class RankedPositionInfoDTO
    {
        [JsonProperty("demotionWarning")]
        public int DemotionWarning { get; set; }
        [JsonProperty("displayDecayWarning")]
        public bool DisplayDecayWarning { get; set; }
        [JsonProperty("games")]
        public int Games { get; set; }
        [JsonProperty("inactivityStatus")]
        public string InactivityStatus { get; set; }
        [JsonProperty("lp")]
        public int Lp { get; set; }
        [JsonProperty("miniSeries")]
        public LeaguesLcdsMiniSeriesDTO MiniSeries { get; set; }
        [JsonProperty("position")]
        public string Position { get; set; }
        [JsonProperty("provisional")]
        public bool Provisional { get; set; }
        [JsonProperty("rank")]
        public string Rank { get; set; }
        [JsonProperty("tier")]
        public string Tier { get; set; }
        [JsonProperty("timeUntilInactivityStatusChanges")]
        public long TimeUntilInactivityStatusChanges { get; set; }
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}
