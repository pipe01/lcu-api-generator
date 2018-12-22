using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLoyaltyGlobalRewards
    {
        [JsonProperty("allChampions")]
        public bool AllChampions { get; set; }
    }
}
