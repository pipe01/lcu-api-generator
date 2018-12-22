using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolBannersInventoryItemsByType
    {
        [JsonProperty("TOURNAMENT_FLAG")]
        public LolBannersTournamentFlagInventoryItem[] TOURNAMENT_FLAG { get; set; }
        [JsonProperty("TOURNAMENT_FRAME")]
        public LolBannersTournamentFrameInventoryItem[] TOURNAMENT_FRAME { get; set; }
    }
}
