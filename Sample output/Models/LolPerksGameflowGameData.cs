using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPerksGameflowGameData
    {
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("isCustomGame")]
        public bool IsCustomGame { get; set; }
        [JsonProperty("queue")]
        public LolPerksQueue Queue { get; set; }
    }
}
