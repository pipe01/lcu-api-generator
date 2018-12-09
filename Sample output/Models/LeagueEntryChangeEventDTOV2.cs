using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LeagueEntryChangeEventDTOV2
    {
        [JsonProperty("leagueItem")]
        public LeaguesLcdsLeagueItemDTO LeagueItem { get; set; }
        [JsonProperty("leaguePointsDelta")]
        public int LeaguePointsDelta { get; set; }
        [JsonProperty("notifyReason")]
        public string NotifyReason { get; set; }
    }
}
