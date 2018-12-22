using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyPartyChatDto
    {
        [JsonProperty("jid")]
        public string Jid { get; set; }
    }
}
