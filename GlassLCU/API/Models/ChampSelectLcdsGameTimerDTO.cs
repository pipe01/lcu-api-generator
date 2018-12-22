using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class ChampSelectLcdsGameTimerDTO
    {
        [JsonProperty("currentGameState")]
        public string CurrentGameState { get; set; }
        [JsonProperty("remainingTimeInMillis")]
        public float RemainingTimeInMillis { get; set; }
    }
}
