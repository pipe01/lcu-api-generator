using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsGameDataChampionMasteryRow
    {
        [JsonProperty("masteries")]
        public int[] Masteries { get; set; }
    }
}
