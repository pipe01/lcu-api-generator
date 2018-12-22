using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class ChampSelectLcdsObfuscatedParticipant
    {
        [JsonProperty("gameUniqueId")]
        public long GameUniqueId { get; set; }
    }
}
