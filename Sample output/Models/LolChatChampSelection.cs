using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChatChampSelection
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("selectedSkinIndex")]
        public int SelectedSkinIndex { get; set; }
        [JsonProperty("summonerInternalName")]
        public string SummonerInternalName { get; set; }
    }
}
