using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeTutorialPathMatchHistoryList
    {
        [JsonProperty("games")]
        public LolNpeTutorialPathMatchHistoryGameList Games { get; set; }
    }
}
