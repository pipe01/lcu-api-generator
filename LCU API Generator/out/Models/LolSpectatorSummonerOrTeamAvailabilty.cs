using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSpectatorSummonerOrTeamAvailabilty
    {
        [JsonProperty("availableForWatching")]
        public string[] AvailableForWatching { get; set; }
    }
}
