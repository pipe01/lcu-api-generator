using Newtonsoft.Json;

namespace LCU_API_Generator
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
