using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRankedRankedPositionInfo
    {
        [JsonProperty("demotionWarning")]
        public long DemotionWarning { get; set; }
        [JsonProperty("displayDecayWarning")]
        public bool DisplayDecayWarning { get; set; }
        [JsonProperty("division")]
        public LolRankedLeagueDivision Division { get; set; }
        [JsonProperty("games")]
        public long Games { get; set; }
        [JsonProperty("inactivityStatus")]
        public string InactivityStatus { get; set; }
        [JsonProperty("isProvisional")]
        public bool IsProvisional { get; set; }
        [JsonProperty("lp")]
        public long Lp { get; set; }
        [JsonProperty("miniseriesResults")]
        public LolRankedMiniseries[] MiniseriesResults { get; set; }
        [JsonProperty("miniseriesTimeLeftToPlayMillis")]
        public long MiniseriesTimeLeftToPlayMillis { get; set; }
        [JsonProperty("position")]
        public LolRankedRankedPosition Position { get; set; }
        [JsonProperty("queueType")]
        public LolRankedLeagueQueueType QueueType { get; set; }
        [JsonProperty("tier")]
        public LolRankedLeagueTier Tier { get; set; }
        [JsonProperty("timeUntilInactivityStatusChanges")]
        public long TimeUntilInactivityStatusChanges { get; set; }
        [JsonProperty("wins")]
        public long Wins { get; set; }
    }
}
