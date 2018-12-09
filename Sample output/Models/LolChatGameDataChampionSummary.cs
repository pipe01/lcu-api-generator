using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChatGameDataChampionSummary
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
