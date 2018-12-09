using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLootGameDataSummonerIcon
    {
        [JsonProperty("iconPath")]
        public string IconPath { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
