//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashPlayerData
    {
        [JsonProperty("isClashBanned")]
        public bool IsClashBanned { get; set; }
        [JsonProperty("tickets")]
        public int Tickets { get; set; }
        [JsonProperty("tier")]
        public int Tier { get; set; }
    }
}
