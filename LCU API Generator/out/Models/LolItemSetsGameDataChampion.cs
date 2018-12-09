using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolItemSetsGameDataChampion
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }
    }
}
