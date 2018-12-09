using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampSelectLegacyChampSelectPickableChampions
    {
        [JsonProperty("championIds")]
        public int[] ChampionIds { get; set; }
    }
}
