using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashThirdPartyApiRoster
    {
        [JsonProperty("captain")]
        public LolClashThirdPartyApiPlayer Captain { get; set; }
        [JsonProperty("members")]
        public LolClashThirdPartyApiPlayer[] Members { get; set; }
    }
}
