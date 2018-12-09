using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyPartyPresenceData
    {
        [JsonProperty("partyId")]
        public string PartyId { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
        [JsonProperty("summoners")]
        public long[] Summoners { get; set; }
    }
}
