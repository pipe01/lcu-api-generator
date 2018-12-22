using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLeaverBusterLoginDataPacket
    {
        [JsonProperty("allSummonerData")]
        public LolLeaverBusterAllSummonerData AllSummonerData { get; set; }
        [JsonProperty("simpleMessages")]
        public LolLeaverBusterSimpleMessage[] SimpleMessages { get; set; }
    }
}
