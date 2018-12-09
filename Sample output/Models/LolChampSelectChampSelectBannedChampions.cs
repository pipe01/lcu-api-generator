using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampSelectChampSelectBannedChampions
    {
        [JsonProperty("myTeamBans")]
        public int[] MyTeamBans { get; set; }
        [JsonProperty("numBans")]
        public int NumBans { get; set; }
        [JsonProperty("theirTeamBans")]
        public int[] TheirTeamBans { get; set; }
    }
}
