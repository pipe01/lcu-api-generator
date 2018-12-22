using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRankedGameflowGameData
    {
        [JsonProperty("queue")]
        public LolRankedQueue Queue { get; set; }
    }
}
