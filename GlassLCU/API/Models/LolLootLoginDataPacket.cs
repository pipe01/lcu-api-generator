using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootLoginDataPacket
    {
        [JsonProperty("allSummonerData")]
        public LolLootLoginAllSummonerData AllSummonerData { get; set; }
        [JsonProperty("simpleMessages")]
        public LolLootLoginSimpleMessage[] SimpleMessages { get; set; }
    }
}