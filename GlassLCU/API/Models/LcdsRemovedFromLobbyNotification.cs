using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LcdsRemovedFromLobbyNotification
    {
        [JsonProperty("removalReason")]
        public LcdsRemovalReason RemovalReason { get; set; }
    }
}
