using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLoginAccountStateResource
    {
        [JsonProperty("state")]
        public LolLoginAccountStateType State { get; set; }
    }
}
