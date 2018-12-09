using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsSummonerProfileUpdate
    {
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("value")]
        public object Value { get; set; }
    }
}
