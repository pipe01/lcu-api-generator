using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampSelectChampSelectBannableChampions
    {
        [JsonProperty("championIds")]
        public int[] ChampionIds { get; set; }
    }
}
