//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
