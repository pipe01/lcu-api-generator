using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
