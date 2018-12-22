using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCollectionsGameDataChampionMasteryRow
    {
        [JsonProperty("masteries")]
        public int[] Masteries { get; set; }
    }
}
