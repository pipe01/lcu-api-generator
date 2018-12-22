using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyLobbyPartyRewards
    {
        [JsonProperty("isCustom")]
        public bool IsCustom { get; set; }
        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }
        [JsonProperty("partyRewards")]
        public LolLobbyPartyReward[] PartyRewards { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
    }
}
