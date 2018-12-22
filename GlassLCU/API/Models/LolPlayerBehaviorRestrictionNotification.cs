using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPlayerBehaviorRestrictionNotification
    {
        [JsonProperty("displayReformCard")]
        public bool DisplayReformCard { get; set; }
        [JsonProperty("gamesRemaining")]
        public long GamesRemaining { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("source")]
        public LolPlayerBehaviorNotificationSource Source { get; set; }
    }
}