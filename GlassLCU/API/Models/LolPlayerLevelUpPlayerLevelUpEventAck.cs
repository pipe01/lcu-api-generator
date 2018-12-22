using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPlayerLevelUpPlayerLevelUpEventAck
    {
        [JsonProperty("newSummonerLevel")]
        public int NewSummonerLevel { get; set; }
        [JsonProperty("seenThisEvent")]
        public bool SeenThisEvent { get; set; }
    }
}
