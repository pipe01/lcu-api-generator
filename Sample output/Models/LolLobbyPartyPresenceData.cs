//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
