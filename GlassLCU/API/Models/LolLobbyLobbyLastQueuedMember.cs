using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyLobbyLastQueuedMember
    {
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}