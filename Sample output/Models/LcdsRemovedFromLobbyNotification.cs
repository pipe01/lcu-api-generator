using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LcdsRemovedFromLobbyNotification
    {
        [JsonProperty("removalReason")]
        public LcdsRemovalReason RemovalReason { get; set; }
    }
}
