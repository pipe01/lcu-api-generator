using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMatchHistorySummonerIdAndName
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }
}
