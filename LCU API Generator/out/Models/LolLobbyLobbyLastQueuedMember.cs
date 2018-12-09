using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyLobbyLastQueuedMember
    {
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
