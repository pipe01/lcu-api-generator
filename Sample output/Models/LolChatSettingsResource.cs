using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChatSettingsResource
    {
        [JsonProperty("data")]
        public object Data { get; set; }
    }
}
