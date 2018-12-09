using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolDiscordRpGameDataChampionSummary
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
