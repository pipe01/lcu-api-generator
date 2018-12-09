using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderChampSelectTradeContract
    {
        [JsonProperty("cellId")]
        public long CellId { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("state")]
        public LolLobbyTeamBuilderChampSelectTradeState State { get; set; }
    }
}
