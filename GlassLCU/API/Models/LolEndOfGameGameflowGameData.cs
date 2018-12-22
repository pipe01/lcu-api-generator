using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolEndOfGameGameflowGameData
    {
        [JsonProperty("gameId")]
        public long GameId { get; set; }
    }
}
