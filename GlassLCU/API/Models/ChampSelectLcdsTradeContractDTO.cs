using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class ChampSelectLcdsTradeContractDTO
    {
        [JsonProperty("requesterChampionId")]
        public int RequesterChampionId { get; set; }
        [JsonProperty("requesterInternalSummonerName")]
        public string RequesterInternalSummonerName { get; set; }
        [JsonProperty("responderChampionId")]
        public int ResponderChampionId { get; set; }
        [JsonProperty("responderInternalSummonerName")]
        public string ResponderInternalSummonerName { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
    }
}
