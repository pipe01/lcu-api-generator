using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolTrophiesInventoryItemsByType
    {
        [JsonProperty("TOURNAMENT_TROPHY")]
        public LolTrophiesTournamentTrophyInventoryItem[] TOURNAMENT_TROPHY { get; set; }
    }
}
