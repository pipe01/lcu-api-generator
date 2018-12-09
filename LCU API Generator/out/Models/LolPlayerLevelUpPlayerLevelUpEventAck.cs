using Newtonsoft.Json;

namespace LCU_API_Generator
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
