using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolSummonerGameloopPlayerInfoV1
    {
        [JsonProperty("autoFillDataBagByQueueId")]
        public object AutoFillDataBagByQueueId { get; set; }
        [JsonProperty("rerollDataBag")]
        public LolSummonerRerollDataBagForClientV1 RerollDataBag { get; set; }
    }
}
