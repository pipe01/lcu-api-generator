//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPlayerLevelUpQueue
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("minLevel")]
        public int MinLevel { get; set; }
    }
}
