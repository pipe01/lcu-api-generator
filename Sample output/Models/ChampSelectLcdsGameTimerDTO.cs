using Newtonsoft.Json;

namespace LCU_API_Generator
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
