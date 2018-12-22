using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLoginAccountStateResource
    {
        [JsonProperty("state")]
        public LolLoginAccountStateType State { get; set; }
    }
}
