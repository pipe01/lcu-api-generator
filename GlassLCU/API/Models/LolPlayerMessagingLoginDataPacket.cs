using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPlayerMessagingLoginDataPacket
    {
        [JsonProperty("allSummonerData")]
        public LolPlayerMessagingAllSummonerData AllSummonerData { get; set; }
        [JsonProperty("simpleMessages")]
        public LolPlayerMessagingSimpleMessage[] SimpleMessages { get; set; }
    }
}
