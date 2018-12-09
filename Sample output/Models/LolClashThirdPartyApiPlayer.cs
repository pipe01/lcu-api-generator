using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashThirdPartyApiPlayer
    {
        [JsonProperty("role")]
        public string Role { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
