using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LCDSChampionReward
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("skins")]
        public int[] Skins { get; set; }
    }
}
