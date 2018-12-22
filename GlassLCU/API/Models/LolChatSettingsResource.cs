using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChatSettingsResource
    {
        [JsonProperty("data")]
        public object Data { get; set; }
    }
}
