using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMatchHistoryMatchHistoryPlayerGameDelta
    {
        [JsonProperty("champMastery")]
        public LolMatchHistoryMatchHistoryPlayerChampMasteryDelta ChampMastery { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("gamePlatformId")]
        public string GamePlatformId { get; set; }
        [JsonProperty("leagueDelta")]
        public LolMatchHistoryMatchHistoryPlayerLeagueDelta LeagueDelta { get; set; }
        [JsonProperty("platformDelta")]
        public LolMatchHistoryMatchHistoryPlayerPlatformDelta PlatformDelta { get; set; }
    }
}
