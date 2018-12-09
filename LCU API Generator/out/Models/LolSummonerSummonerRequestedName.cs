using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSummonerSummonerRequestedName
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
