using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampSelectLegacyChampSelectBannableChampions
    {
        [JsonProperty("championIds")]
        public int[] ChampionIds { get; set; }
    }
}
