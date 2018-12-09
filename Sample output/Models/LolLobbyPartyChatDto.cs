using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyPartyChatDto
    {
        [JsonProperty("jid")]
        public string Jid { get; set; }
    }
}
