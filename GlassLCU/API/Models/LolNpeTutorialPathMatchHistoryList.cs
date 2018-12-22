using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolNpeTutorialPathMatchHistoryList
    {
        [JsonProperty("games")]
        public LolNpeTutorialPathMatchHistoryGameList Games { get; set; }
    }
}
