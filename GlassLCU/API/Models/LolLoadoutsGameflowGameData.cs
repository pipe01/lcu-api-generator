using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLoadoutsGameflowGameData
    {
        [JsonProperty("queue")]
        public LolLoadoutsQueue Queue { get; set; }
    }
}
