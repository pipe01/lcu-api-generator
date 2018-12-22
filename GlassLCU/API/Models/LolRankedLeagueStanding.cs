using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRankedLeagueStanding
    {
        [JsonProperty("apexDaysUntilDecay")]
        public long ApexDaysUntilDecay { get; set; }
        [JsonProperty("emblems")]
        public LolRankedLeagueEmblem[] Emblems { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("inactive")]
        public bool Inactive { get; set; }
        [JsonProperty("inactivityStatus")]
        public string InactivityStatus { get; set; }
        [JsonProperty("losses")]
        public long Losses { get; set; }
        [JsonProperty("miniseriesResults")]
        public LolRankedMiniseries[] MiniseriesResults { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("pendingDemotion")]
        public bool PendingDemotion { get; set; }
        [JsonProperty("pendingPromotion")]
        public bool PendingPromotion { get; set; }
        [JsonProperty("points")]
        public long Points { get; set; }
        [JsonProperty("position")]
        public long Position { get; set; }
        [JsonProperty("positionDelta")]
        public long PositionDelta { get; set; }
        [JsonProperty("previousPosition")]
        public long PreviousPosition { get; set; }
        [JsonProperty("rivalName")]
        public string RivalName { get; set; }
        [JsonProperty("wins")]
        public long Wins { get; set; }
    }
}
