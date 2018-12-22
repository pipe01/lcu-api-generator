using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyChatFriend
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("lol")]
        public object Lol { get; set; }
    }
}
