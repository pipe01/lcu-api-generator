using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolSpectatorSummonerOrTeamAvailabilty
    {
        [JsonProperty("availableForWatching")]
        public string[] AvailableForWatching { get; set; }
    }
}
