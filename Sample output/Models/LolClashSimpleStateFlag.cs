using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashSimpleStateFlag
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("status")]
        public LolClashSimpleStateStatus Status { get; set; }
    }
}