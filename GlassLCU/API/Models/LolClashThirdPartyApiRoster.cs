using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
