using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolTrophiesInventoryItemsByType
    {
        [JsonProperty("TOURNAMENT_TROPHY")]
        public LolTrophiesTournamentTrophyInventoryItem[] TOURNAMENT_TROPHY { get; set; }
    }
}
