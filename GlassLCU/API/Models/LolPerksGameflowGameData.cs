using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
