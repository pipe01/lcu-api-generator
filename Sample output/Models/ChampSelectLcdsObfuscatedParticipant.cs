using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class ChampSelectLcdsObfuscatedParticipant
    {
        [JsonProperty("gameUniqueId")]
        public long GameUniqueId { get; set; }
    }
}
