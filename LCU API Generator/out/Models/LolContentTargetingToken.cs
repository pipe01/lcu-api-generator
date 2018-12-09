using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolContentTargetingToken
    {
        [JsonProperty("entitlements")]
        public string[] Entitlements { get; set; }
    }
}
